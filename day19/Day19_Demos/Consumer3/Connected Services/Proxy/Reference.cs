﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consumer3.Proxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Emp", Namespace="http://schemas.datacontract.org/2004/07/TestServices")]
    [System.SerializableAttribute()]
    public partial class Emp : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int No {
            get {
                return this.NoField;
            }
            set {
                if ((this.NoField.Equals(value) != true)) {
                    this.NoField = value;
                    this.RaisePropertyChanged("No");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Proxy.IDBService")]
    public interface IDBService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/GetEmps", ReplyAction="http://tempuri.org/IDBService/GetEmpsResponse")]
        System.Collections.Generic.List<Consumer3.Proxy.Emp> GetEmps();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBService/GetEmps", ReplyAction="http://tempuri.org/IDBService/GetEmpsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Consumer3.Proxy.Emp>> GetEmpsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBServiceChannel : Consumer3.Proxy.IDBService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBServiceClient : System.ServiceModel.ClientBase<Consumer3.Proxy.IDBService>, Consumer3.Proxy.IDBService {
        
        public DBServiceClient() {
        }
        
        public DBServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Consumer3.Proxy.Emp> GetEmps() {
            return base.Channel.GetEmps();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Consumer3.Proxy.Emp>> GetEmpsAsync() {
            return base.Channel.GetEmpsAsync();
        }
    }
}
