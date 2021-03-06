﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GraduateProject_WebApplication.GraduateProjectServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GraduateProjectServices.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Weather5day", ReplyAction="http://tempuri.org/IService1/Weather5dayResponse")]
        string[] Weather5day(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Weather5day", ReplyAction="http://tempuri.org/IService1/Weather5dayResponse")]
        System.Threading.Tasks.Task<string[]> Weather5dayAsync(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/get_UV_Index", ReplyAction="http://tempuri.org/IService1/get_UV_IndexResponse")]
        string get_UV_Index(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/get_UV_Index", ReplyAction="http://tempuri.org/IService1/get_UV_IndexResponse")]
        System.Threading.Tasks.Task<string> get_UV_IndexAsync(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WindIntensity", ReplyAction="http://tempuri.org/IService1/WindIntensityResponse")]
        string[] WindIntensity(string zipcode, string countryCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WindIntensity", ReplyAction="http://tempuri.org/IService1/WindIntensityResponse")]
        System.Threading.Tasks.Task<string[]> WindIntensityAsync(string zipcode, string countryCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : GraduateProject_WebApplication.GraduateProjectServices.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<GraduateProject_WebApplication.GraduateProjectServices.IService1>, GraduateProject_WebApplication.GraduateProjectServices.IService1 {
        
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
        
        public string[] Weather5day(string zipcode) {
            return base.Channel.Weather5day(zipcode);
        }
        
        public System.Threading.Tasks.Task<string[]> Weather5dayAsync(string zipcode) {
            return base.Channel.Weather5dayAsync(zipcode);
        }
        
        public string get_UV_Index(string zipcode) {
            return base.Channel.get_UV_Index(zipcode);
        }
        
        public System.Threading.Tasks.Task<string> get_UV_IndexAsync(string zipcode) {
            return base.Channel.get_UV_IndexAsync(zipcode);
        }
        
        public string[] WindIntensity(string zipcode, string countryCode) {
            return base.Channel.WindIntensity(zipcode, countryCode);
        }
        
        public System.Threading.Tasks.Task<string[]> WindIntensityAsync(string zipcode, string countryCode) {
            return base.Channel.WindIntensityAsync(zipcode, countryCode);
        }
    }
}
