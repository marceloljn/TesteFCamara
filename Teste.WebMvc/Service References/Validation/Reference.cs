﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teste.WebMvc.Validation {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Token", Namespace="http://schemas.datacontract.org/2004/07/Teste.Wcf.Model")]
    [System.SerializableAttribute()]
    public partial class Token : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ExpirationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public System.DateTime ExpirationDate {
            get {
                return this.ExpirationDateField;
            }
            set {
                if ((this.ExpirationDateField.Equals(value) != true)) {
                    this.ExpirationDateField = value;
                    this.RaisePropertyChanged("ExpirationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Validation.IValidation")]
    public interface IValidation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IValidation/GenerateToken", ReplyAction="http://tempuri.org/IValidation/GenerateTokenResponse")]
        Teste.WebMvc.Validation.Token GenerateToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IValidation/GenerateToken", ReplyAction="http://tempuri.org/IValidation/GenerateTokenResponse")]
        System.Threading.Tasks.Task<Teste.WebMvc.Validation.Token> GenerateTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IValidation/ValidateToken", ReplyAction="http://tempuri.org/IValidation/ValidateTokenResponse")]
        bool ValidateToken(string tokenValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IValidation/ValidateToken", ReplyAction="http://tempuri.org/IValidation/ValidateTokenResponse")]
        System.Threading.Tasks.Task<bool> ValidateTokenAsync(string tokenValue);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IValidationChannel : Teste.WebMvc.Validation.IValidation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidationClient : System.ServiceModel.ClientBase<Teste.WebMvc.Validation.IValidation>, Teste.WebMvc.Validation.IValidation {
        
        public ValidationClient() {
        }
        
        public ValidationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ValidationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Teste.WebMvc.Validation.Token GenerateToken() {
            return base.Channel.GenerateToken();
        }
        
        public System.Threading.Tasks.Task<Teste.WebMvc.Validation.Token> GenerateTokenAsync() {
            return base.Channel.GenerateTokenAsync();
        }
        
        public bool ValidateToken(string tokenValue) {
            return base.Channel.ValidateToken(tokenValue);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateTokenAsync(string tokenValue) {
            return base.Channel.ValidateTokenAsync(tokenValue);
        }
    }
}
