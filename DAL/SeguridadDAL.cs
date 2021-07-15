using BE;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class SeguridadDAL
    {
        public List<RolPatenteBE> ObtenerPermisosDeUsuario(UsuarioBE user)
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var rolUsuario = (from usuario in dbContext.Usuarios
                                  where usuario.Usuario1.ToLower().Trim() == user.NombreDeUsuario.ToLower().Trim()
                                   && string.Compare(usuario.Contraseña, user.Password) == 0
                                  select usuario.Rol).FirstOrDefault();

                var rolPatenteResultado = from rolPatente in dbContext.RolPatentes
                                          where rolPatente.Id_rol == rolUsuario.Id
                                          join patente in dbContext.Patentes on rolPatente.Id_patente equals patente.Id
                                          select new RolPatenteBE
                                          {
                                              IdPatente = patente.Id,
                                              DescripcionPatente = patente.Descripcion,
                                              Rol = rolUsuario.Descripcion
                                          };

                return rolPatenteResultado.ToList();
            }
        }


        public List<BitacoraBE> ObtenerBitacoraCompleta()
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var bitacora = (from bt in dbContext.Bitacoras
                                select new BitacoraBE
                                {
                                    Descripcion = bt.Descripcion,
                                    FechaFin = bt.Fecha_fin,
                                    FechaInicio = bt.Fecha_inicio,
                                    Id = bt.Id,
                                    Usuario_id = bt.Usuario_id
                                }).OrderByDescending(x=>x.FechaInicio).ToList();

                return bitacora;

            }
        }

        public List<BackUp> ObtenerBackUps(string path)
        {
            string[] fileEntries = Directory.GetFiles(path);
            List<BackUp> backups = new List<BackUp>();


            foreach (string item in fileEntries)
            {
                if (!item.Contains(".ini"))
                {
                    backups.Add(new BackUp()
                    {
                        NombreBD = item.Substring(item.LastIndexOf('\\') + 1),
                        BackUpPath = item.Substring(0, item.LastIndexOf('\\'))
                    });

                }
            }

            return backups;
        }

        public void RecalcularDigitoVerificadorHorizontalTodos()
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var rowsToHash = (from hash in dbContext.Usuarios select hash).ToList();

                foreach (var row in rowsToHash)
                {
                    var hash = GenerarHash(row.Usuario1, row.Contraseña, row.Id_rol.ToString());
                    row.Dig_ver_h = hash;

                }

                var bebidaRows = (from hash in dbContext.Bebidas select hash).ToList();

                foreach (var row in bebidaRows)
                {
                    var hash = GenerarHash(row.Descripcion, row.SKU, row.Precio.ToString());
                    row.Dig_ver_h = hash;
                }

                dbContext.SubmitChanges();
            }
        }

        public void CrearBitacora(UsuarioBE user, string action)
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var bitacora = new Bitacora()
                {
                    Descripcion = string.Format("{0}. Usuario: {1}. Rol: {2}", action, user.NombreDeUsuario, user.PerfilDeUsuario.Descripcion),
                    Fecha_fin = null,
                    Fecha_inicio = DateTime.Now,
                    Usuario_id = user.Id,

                };

                dbContext.Bitacoras.InsertOnSubmit(bitacora);
                dbContext.SubmitChanges();
            }
        }

        public List<Bebida> ObtenerHashProductoParaValidarIntegridad()
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var rows = (from hash in dbContext.Bebidas select hash).ToList();

                return rows;
            }
        }

        public List<Usuario> ObtenerHashUsuarioParaValidarIntegridad()
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var usuarioRows = (from hash in dbContext.Usuarios select hash).ToList();

                return usuarioRows;
            }
        }

        public string GenerarHash(params string[] param)
        {
            string fila = string.Join("5", param);
            var hashedData = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(fila));
            var hash = BitConverter.ToString(hashedData).Replace("-", "").ToLower();

            return hash;
        }

        //Method, pass your databaseName, username, password, server name and destination path to save backup file
        public bool BackupDatabase(string databaseName, string destinationPath)
        {
            try
            {
                //Define a Backup object variable.

                Backup sqlBackup = new Backup();
                //Specify the type of backup, the description, the name, and the database to be backed up.

                sqlBackup.Action = BackupActionType.Database;

                sqlBackup.BackupSetDescription = string.Format("BackUp_{0}_{1}.bak", databaseName, DateTime.Now.ToString("yyyyMMddHHmmss"));

                sqlBackup.BackupSetName = string.Format("BackUp_{0}_{1}.bak", databaseName, DateTime.Now.ToString("yyyyMMddHHmmss"));

                sqlBackup.Database = databaseName;
                //Declare a BackupDeviceItem

                //Nombre de la Base de Datos.
                BackupDeviceItem deviceItem = new BackupDeviceItem(string.Format("{0}BackUp_{1}_{2}.bak", destinationPath, databaseName, DateTime.Now.ToString("yyyyMMddHHmmss")), DeviceType.File);

                ////Define Server connection if diferent to LOCAL               
                //var connectionString = new SqlConnection(@"Data Source =.\sebas; Initial Catalog = PuroEscabio; Integrated Security = True");
                //ServerConnection connection = new ServerConnection(connectionString);//To Avoid TimeOut Exception

                Server sqlServer = new Server();
                sqlServer.LoginMode = ServerLoginMode.Integrated;
                sqlServer.ConnectionContext.StatementTimeout = 60 * 60;
                Database db = sqlServer.Databases[databaseName];

                sqlBackup.Initialize = true;

                sqlBackup.Checksum = true;

                sqlBackup.ContinueAfterError = true;
                //Add the device to the Backup object.

                sqlBackup.Devices.Add(deviceItem);

                //Set the Incremental property to False to specify that this is a full database backup. 
                sqlBackup.Incremental = false;
                sqlBackup.ExpirationDate = DateTime.Now.AddDays(3);

                //Specify that the log must be truncated after the backup is complete.        
                sqlBackup.LogTruncation = BackupTruncateLogType.Truncate;
                sqlBackup.FormatMedia = false;

                //Run SqlBackup to perform the full database backup on the instance of SQL Server. 
                sqlBackup.SqlBackup(sqlServer);

                //Remove the backup device from the Backup object.           
                sqlBackup.Devices.Remove(deviceItem);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public bool RestoreDataBase(string rootPath, string databaseName, string databaseBackupName)
        {

            try
            {
                // Define a Restore object variable.  
                Restore rs = new Restore();

                BackupDeviceItem bdi = new BackupDeviceItem(string.Format("{0}{1}", rootPath, databaseBackupName), DeviceType.File);

                // Set the NoRecovery property to true, so the transactions are not recovered.   
                rs.NoRecovery = false;
                rs.Action = RestoreActionType.Database;
                rs.ReplaceDatabase = true;
                // Add the device that contains the full database backup to the Restore object.   
                rs.Devices.Add(bdi);

                // Specify the database name.   
                rs.Database = databaseName;                
                
                


                // Restore the full database backup with no recovery.   
                Server srv = new Server();
                srv.LoginMode = ServerLoginMode.Integrated;                
                srv.ConnectionContext.StatementTimeout = 60 * 60;
                srv.KillDatabase(databaseName);
                rs.Wait();
                rs.SqlRestore(srv);
                

                // Inform the user that the Full Database Restore is complete.   
                Console.WriteLine("Full Database Restore complete.");

                // Remove the backup files from the hard disk.  
                // This location is dependent on the installation of SQL Server  
                //System.IO.File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup\\Test_Full_Backup1");
                //System.IO.File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup\\Test_Differential_Backup1");

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
