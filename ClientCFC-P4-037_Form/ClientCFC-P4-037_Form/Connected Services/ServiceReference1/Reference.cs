﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientCFC_P4_037_Form.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Imatematika")]
    public interface Imatematika {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Tambah", ReplyAction="http://tempuri.org/Imatematika/TambahResponse")]
        int Tambah(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Tambah", ReplyAction="http://tempuri.org/Imatematika/TambahResponse")]
        System.Threading.Tasks.Task<int> TambahAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Kurang", ReplyAction="http://tempuri.org/Imatematika/KurangResponse")]
        int Kurang(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Kurang", ReplyAction="http://tempuri.org/Imatematika/KurangResponse")]
        System.Threading.Tasks.Task<int> KurangAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Kali", ReplyAction="http://tempuri.org/Imatematika/KaliResponse")]
        int Kali(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Kali", ReplyAction="http://tempuri.org/Imatematika/KaliResponse")]
        System.Threading.Tasks.Task<int> KaliAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Bagi", ReplyAction="http://tempuri.org/Imatematika/BagiResponse")]
        int Bagi(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Bagi", ReplyAction="http://tempuri.org/Imatematika/BagiResponse")]
        System.Threading.Tasks.Task<int> BagiAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/TKoordinat", ReplyAction="http://tempuri.org/Imatematika/TKoordinatResponse")]
        ServiceMtk_P1_037.Koordinat TKoordinat(ServiceMtk_P1_037.Koordinat a, ServiceMtk_P1_037.Koordinat b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/TKoordinat", ReplyAction="http://tempuri.org/Imatematika/TKoordinatResponse")]
        System.Threading.Tasks.Task<ServiceMtk_P1_037.Koordinat> TKoordinatAsync(ServiceMtk_P1_037.Koordinat a, ServiceMtk_P1_037.Koordinat b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ImatematikaChannel : ClientCFC_P4_037_Form.ServiceReference1.Imatematika, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImatematikaClient : System.ServiceModel.ClientBase<ClientCFC_P4_037_Form.ServiceReference1.Imatematika>, ClientCFC_P4_037_Form.ServiceReference1.Imatematika {
        
        public ImatematikaClient() {
        }
        
        public ImatematikaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImatematikaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImatematikaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImatematikaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Tambah(int a, int b) {
            return base.Channel.Tambah(a, b);
        }
        
        public System.Threading.Tasks.Task<int> TambahAsync(int a, int b) {
            return base.Channel.TambahAsync(a, b);
        }
        
        public int Kurang(int a, int b) {
            return base.Channel.Kurang(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KurangAsync(int a, int b) {
            return base.Channel.KurangAsync(a, b);
        }
        
        public int Kali(int a, int b) {
            return base.Channel.Kali(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KaliAsync(int a, int b) {
            return base.Channel.KaliAsync(a, b);
        }
        
        public int Bagi(int a, int b) {
            return base.Channel.Bagi(a, b);
        }
        
        public System.Threading.Tasks.Task<int> BagiAsync(int a, int b) {
            return base.Channel.BagiAsync(a, b);
        }
        
        public ServiceMtk_P1_037.Koordinat TKoordinat(ServiceMtk_P1_037.Koordinat a, ServiceMtk_P1_037.Koordinat b) {
            return base.Channel.TKoordinat(a, b);
        }
        
        public System.Threading.Tasks.Task<ServiceMtk_P1_037.Koordinat> TKoordinatAsync(ServiceMtk_P1_037.Koordinat a, ServiceMtk_P1_037.Koordinat b) {
            return base.Channel.TKoordinatAsync(a, b);
        }
    }
}
