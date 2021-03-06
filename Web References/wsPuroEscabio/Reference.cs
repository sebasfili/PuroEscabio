//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PuroEscabio.wsPuroEscabio {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback PedidoDeStockOperationCompleted;
        
        private System.Threading.SendOrPostCallback PedidoDeStockPorSucursalOperationCompleted;
        
        private System.Threading.SendOrPostCallback ModificarStockOperationCompleted;
        
        private System.Threading.SendOrPostCallback CarritoDeComprasOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::PuroEscabio.Properties.Settings.Default.PuroEscabio_wsPuroEscabio_WebService1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event PedidoDeStockCompletedEventHandler PedidoDeStockCompleted;
        
        /// <remarks/>
        public event PedidoDeStockPorSucursalCompletedEventHandler PedidoDeStockPorSucursalCompleted;
        
        /// <remarks/>
        public event ModificarStockCompletedEventHandler ModificarStockCompleted;
        
        /// <remarks/>
        public event CarritoDeComprasCompletedEventHandler CarritoDeComprasCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PedidoDeStock", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StockResponse PedidoDeStock() {
            object[] results = this.Invoke("PedidoDeStock", new object[0]);
            return ((StockResponse)(results[0]));
        }
        
        /// <remarks/>
        public void PedidoDeStockAsync() {
            this.PedidoDeStockAsync(null);
        }
        
        /// <remarks/>
        public void PedidoDeStockAsync(object userState) {
            if ((this.PedidoDeStockOperationCompleted == null)) {
                this.PedidoDeStockOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPedidoDeStockOperationCompleted);
            }
            this.InvokeAsync("PedidoDeStock", new object[0], this.PedidoDeStockOperationCompleted, userState);
        }
        
        private void OnPedidoDeStockOperationCompleted(object arg) {
            if ((this.PedidoDeStockCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PedidoDeStockCompleted(this, new PedidoDeStockCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PedidoDeStockPorSucursal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StockResponse PedidoDeStockPorSucursal(int idSucursal) {
            object[] results = this.Invoke("PedidoDeStockPorSucursal", new object[] {
                        idSucursal});
            return ((StockResponse)(results[0]));
        }
        
        /// <remarks/>
        public void PedidoDeStockPorSucursalAsync(int idSucursal) {
            this.PedidoDeStockPorSucursalAsync(idSucursal, null);
        }
        
        /// <remarks/>
        public void PedidoDeStockPorSucursalAsync(int idSucursal, object userState) {
            if ((this.PedidoDeStockPorSucursalOperationCompleted == null)) {
                this.PedidoDeStockPorSucursalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPedidoDeStockPorSucursalOperationCompleted);
            }
            this.InvokeAsync("PedidoDeStockPorSucursal", new object[] {
                        idSucursal}, this.PedidoDeStockPorSucursalOperationCompleted, userState);
        }
        
        private void OnPedidoDeStockPorSucursalOperationCompleted(object arg) {
            if ((this.PedidoDeStockPorSucursalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PedidoDeStockPorSucursalCompleted(this, new PedidoDeStockPorSucursalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ModificarStock", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ModificarStock(int idSucursal, int idProducto, int cantidad) {
            object[] results = this.Invoke("ModificarStock", new object[] {
                        idSucursal,
                        idProducto,
                        cantidad});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ModificarStockAsync(int idSucursal, int idProducto, int cantidad) {
            this.ModificarStockAsync(idSucursal, idProducto, cantidad, null);
        }
        
        /// <remarks/>
        public void ModificarStockAsync(int idSucursal, int idProducto, int cantidad, object userState) {
            if ((this.ModificarStockOperationCompleted == null)) {
                this.ModificarStockOperationCompleted = new System.Threading.SendOrPostCallback(this.OnModificarStockOperationCompleted);
            }
            this.InvokeAsync("ModificarStock", new object[] {
                        idSucursal,
                        idProducto,
                        cantidad}, this.ModificarStockOperationCompleted, userState);
        }
        
        private void OnModificarStockOperationCompleted(object arg) {
            if ((this.ModificarStockCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ModificarStockCompleted(this, new ModificarStockCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CarritoDeCompras", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ItemBE CarritoDeCompras(UsuarioBE user) {
            object[] results = this.Invoke("CarritoDeCompras", new object[] {
                        user});
            return ((ItemBE)(results[0]));
        }
        
        /// <remarks/>
        public void CarritoDeComprasAsync(UsuarioBE user) {
            this.CarritoDeComprasAsync(user, null);
        }
        
        /// <remarks/>
        public void CarritoDeComprasAsync(UsuarioBE user, object userState) {
            if ((this.CarritoDeComprasOperationCompleted == null)) {
                this.CarritoDeComprasOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCarritoDeComprasOperationCompleted);
            }
            this.InvokeAsync("CarritoDeCompras", new object[] {
                        user}, this.CarritoDeComprasOperationCompleted, userState);
        }
        
        private void OnCarritoDeComprasOperationCompleted(object arg) {
            if ((this.CarritoDeComprasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CarritoDeComprasCompleted(this, new CarritoDeComprasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class StockResponse {
        
        private BebidasBE[] productosEnStockField;
        
        private BebidasBE[] productosARenovarField;
        
        /// <remarks/>
        public BebidasBE[] ProductosEnStock {
            get {
                return this.productosEnStockField;
            }
            set {
                this.productosEnStockField = value;
            }
        }
        
        /// <remarks/>
        public BebidasBE[] ProductosARenovar {
            get {
                return this.productosARenovarField;
            }
            set {
                this.productosARenovarField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BebidasBE {
        
        private int idField;
        
        private string sKUField;
        
        private string descripcionField;
        
        private System.Nullable<decimal> precioField;
        
        private string digVerificadorField;
        
        private System.Nullable<int> stockMinimoField;
        
        private System.Nullable<int> stockActualField;
        
        private string sucursalField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string SKU {
            get {
                return this.sKUField;
            }
            set {
                this.sKUField = value;
            }
        }
        
        /// <remarks/>
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> Precio {
            get {
                return this.precioField;
            }
            set {
                this.precioField = value;
            }
        }
        
        /// <remarks/>
        public string DigVerificador {
            get {
                return this.digVerificadorField;
            }
            set {
                this.digVerificadorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> StockMinimo {
            get {
                return this.stockMinimoField;
            }
            set {
                this.stockMinimoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> StockActual {
            get {
                return this.stockActualField;
            }
            set {
                this.stockActualField = value;
            }
        }
        
        /// <remarks/>
        public string Sucursal {
            get {
                return this.sucursalField;
            }
            set {
                this.sucursalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ItemBE {
        
        private int idField;
        
        private System.DateTime fechaField;
        
        private BebidasBE[] productoField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }
        
        /// <remarks/>
        public BebidasBE[] Producto {
            get {
                return this.productoField;
            }
            set {
                this.productoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class PerfilBE {
        
        private int idField;
        
        private string descripcionField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UsuarioBE {
        
        private int idField;
        
        private string nombreDeUsuarioField;
        
        private string passwordField;
        
        private string digVerificadorField;
        
        private PerfilBE perfilDeUsuarioField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string NombreDeUsuario {
            get {
                return this.nombreDeUsuarioField;
            }
            set {
                this.nombreDeUsuarioField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string DigVerificador {
            get {
                return this.digVerificadorField;
            }
            set {
                this.digVerificadorField = value;
            }
        }
        
        /// <remarks/>
        public PerfilBE PerfilDeUsuario {
            get {
                return this.perfilDeUsuarioField;
            }
            set {
                this.perfilDeUsuarioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void PedidoDeStockCompletedEventHandler(object sender, PedidoDeStockCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PedidoDeStockCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PedidoDeStockCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StockResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StockResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void PedidoDeStockPorSucursalCompletedEventHandler(object sender, PedidoDeStockPorSucursalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PedidoDeStockPorSucursalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PedidoDeStockPorSucursalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StockResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StockResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ModificarStockCompletedEventHandler(object sender, ModificarStockCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ModificarStockCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ModificarStockCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CarritoDeComprasCompletedEventHandler(object sender, CarritoDeComprasCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CarritoDeComprasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CarritoDeComprasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ItemBE Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ItemBE)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591