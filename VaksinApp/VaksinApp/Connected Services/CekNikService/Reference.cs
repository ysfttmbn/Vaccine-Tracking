﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VaksinApp.CekNikService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Data_Penduduk", Namespace="http://schemas.datacontract.org/2004/07/CekNikService")]
    [System.SerializableAttribute()]
    public partial class Data_Penduduk : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string alamatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jenis_kelaminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nikField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string alamat {
            get {
                return this.alamatField;
            }
            set {
                if ((object.ReferenceEquals(this.alamatField, value) != true)) {
                    this.alamatField = value;
                    this.RaisePropertyChanged("alamat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string jenis_kelamin {
            get {
                return this.jenis_kelaminField;
            }
            set {
                if ((object.ReferenceEquals(this.jenis_kelaminField, value) != true)) {
                    this.jenis_kelaminField = value;
                    this.RaisePropertyChanged("jenis_kelamin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nama {
            get {
                return this.namaField;
            }
            set {
                if ((object.ReferenceEquals(this.namaField, value) != true)) {
                    this.namaField = value;
                    this.RaisePropertyChanged("nama");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nik {
            get {
                return this.nikField;
            }
            set {
                if ((object.ReferenceEquals(this.nikField, value) != true)) {
                    this.nikField = value;
                    this.RaisePropertyChanged("nik");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CekNikService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNik", ReplyAction="http://tempuri.org/IService1/GetNikResponse")]
        VaksinApp.CekNikService.Data_Penduduk[] GetNik();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNik", ReplyAction="http://tempuri.org/IService1/GetNikResponse")]
        System.Threading.Tasks.Task<VaksinApp.CekNikService.Data_Penduduk[]> GetNikAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CekNik", ReplyAction="http://tempuri.org/IService1/CekNikResponse")]
        bool CekNik(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CekNik", ReplyAction="http://tempuri.org/IService1/CekNikResponse")]
        System.Threading.Tasks.Task<bool> CekNikAsync(string search);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : VaksinApp.CekNikService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<VaksinApp.CekNikService.IService1>, VaksinApp.CekNikService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public VaksinApp.CekNikService.Data_Penduduk[] GetNik() {
            return base.Channel.GetNik();
        }
        
        public System.Threading.Tasks.Task<VaksinApp.CekNikService.Data_Penduduk[]> GetNikAsync() {
            return base.Channel.GetNikAsync();
        }
        
        public bool CekNik(string search) {
            return base.Channel.CekNik(search);
        }
        
        public System.Threading.Tasks.Task<bool> CekNikAsync(string search) {
            return base.Channel.CekNikAsync(search);
        }
    }
}
