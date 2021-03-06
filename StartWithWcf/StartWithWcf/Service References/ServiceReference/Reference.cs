﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ICalcService")]
    public interface ICalcService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Sum", ReplyAction="http://tempuri.org/ICalcService/SumResponse")]
        int Sum(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Sum", ReplyAction="http://tempuri.org/ICalcService/SumResponse")]
        System.Threading.Tasks.Task<int> SumAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Devide", ReplyAction="http://tempuri.org/ICalcService/DevideResponse")]
        double Devide(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Devide", ReplyAction="http://tempuri.org/ICalcService/DevideResponse")]
        System.Threading.Tasks.Task<double> DevideAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcServiceChannel : Client.ServiceReference.ICalcService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcServiceClient : System.ServiceModel.ClientBase<Client.ServiceReference.ICalcService>, Client.ServiceReference.ICalcService {
        
        public CalcServiceClient() {
        }
        
        public CalcServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Sum(int a, int b) {
            return base.Channel.Sum(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(int a, int b) {
            return base.Channel.SumAsync(a, b);
        }
        
        public double Devide(int a, int b) {
            return base.Channel.Devide(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DevideAsync(int a, int b) {
            return base.Channel.DevideAsync(a, b);
        }
    }
}
