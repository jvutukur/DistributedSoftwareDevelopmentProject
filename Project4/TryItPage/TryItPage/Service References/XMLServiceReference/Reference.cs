﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryItPage.XMLServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="XMLServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/verification", ReplyAction="http://tempuri.org/IService1/verificationResponse")]
        string verification(string xmlurl, string xsdurl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/verification", ReplyAction="http://tempuri.org/IService1/verificationResponse")]
        System.Threading.Tasks.Task<string> verificationAsync(string xmlurl, string xsdurl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/transformation", ReplyAction="http://tempuri.org/IService1/transformationResponse")]
        string transformation(string xmlurl, string xslurl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/transformation", ReplyAction="http://tempuri.org/IService1/transformationResponse")]
        System.Threading.Tasks.Task<string> transformationAsync(string xmlurl, string xslurl);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TryItPage.XMLServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TryItPage.XMLServiceReference.IService1>, TryItPage.XMLServiceReference.IService1 {
        
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
        
        public string verification(string xmlurl, string xsdurl) {
            return base.Channel.verification(xmlurl, xsdurl);
        }
        
        public System.Threading.Tasks.Task<string> verificationAsync(string xmlurl, string xsdurl) {
            return base.Channel.verificationAsync(xmlurl, xsdurl);
        }
        
        public string transformation(string xmlurl, string xslurl) {
            return base.Channel.transformation(xmlurl, xslurl);
        }
        
        public System.Threading.Tasks.Task<string> transformationAsync(string xmlurl, string xslurl) {
            return base.Channel.transformationAsync(xmlurl, xslurl);
        }
    }
}
