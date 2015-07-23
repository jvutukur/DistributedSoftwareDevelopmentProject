﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_5.RequiredServicesClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RequiredServicesClient.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Top10Words", ReplyAction="http://tempuri.org/IService1/Top10WordsResponse")]
        string[] Top10Words(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Top10Words", ReplyAction="http://tempuri.org/IService1/Top10WordsResponse")]
        System.Threading.Tasks.Task<string[]> Top10WordsAsync(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewsFocus", ReplyAction="http://tempuri.org/IService1/NewsFocusResponse")]
        string[] NewsFocus(string topics);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewsFocus", ReplyAction="http://tempuri.org/IService1/NewsFocusResponse")]
        System.Threading.Tasks.Task<string[]> NewsFocusAsync(string topics);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Project_5.RequiredServicesClient.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Project_5.RequiredServicesClient.IService1>, Project_5.RequiredServicesClient.IService1 {
        
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
        
        public string[] Top10Words(string url) {
            return base.Channel.Top10Words(url);
        }
        
        public System.Threading.Tasks.Task<string[]> Top10WordsAsync(string url) {
            return base.Channel.Top10WordsAsync(url);
        }
        
        public string[] NewsFocus(string topics) {
            return base.Channel.NewsFocus(topics);
        }
        
        public System.Threading.Tasks.Task<string[]> NewsFocusAsync(string topics) {
            return base.Channel.NewsFocusAsync(topics);
        }
    }
}
