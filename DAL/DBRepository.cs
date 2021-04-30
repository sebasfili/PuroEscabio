using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public sealed class DBRepository : IDisposable
    {
        private static SqlConnection _instance = null;
        private static readonly object _syncObject = new object();
        private string conString = ConfigurationManager.ConnectionStrings["PuroEscabioConnection"].ConnectionString;

        private DBRepository()
        {
            _instance = new SqlConnection(conString);
        }

        public static SqlConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncObject)
                    {
                        if (_instance == null)
                        {
                            new DBRepository();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Dispose()
        {
            if (_instance != null && _instance.State == ConnectionState.Open)
            {
                _instance.Close();
            }
            _instance.Dispose();
        }
    }
}
