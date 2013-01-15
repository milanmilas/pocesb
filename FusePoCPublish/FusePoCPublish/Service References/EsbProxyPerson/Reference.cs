﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FusePoCPublish.EsbProxyPerson {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://pocesb.allocatesoftware.com", ConfigurationName="EsbProxyPerson.SayHiEndpoint")]
    public interface SayHiEndpoint {
        
        // CODEGEN: Generating message contract since the operation SayHi is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://pocesb.allocatesoftware.com/SayHi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        FusePoCPublish.EsbProxyPerson.SayHiResponse SayHi(FusePoCPublish.EsbProxyPerson.SayHiRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pocesb.allocatesoftware.com/SayHi", ReplyAction="*")]
        System.Threading.Tasks.Task<FusePoCPublish.EsbProxyPerson.SayHiResponse> SayHiAsync(FusePoCPublish.EsbProxyPerson.SayHiRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://pocesb.allocatesoftware.com")]
    public partial class Person : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string surnameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Surname {
            get {
                return this.surnameField;
            }
            set {
                this.surnameField = value;
                this.RaisePropertyChanged("Surname");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SayHiRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public FusePoCPublish.EsbProxyPerson.Person @in;
        
        public SayHiRequest() {
        }
        
        public SayHiRequest(FusePoCPublish.EsbProxyPerson.Person @in) {
            this.@in = @in;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SayHiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public bool @out;
        
        public SayHiResponse() {
        }
        
        public SayHiResponse(bool @out) {
            this.@out = @out;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SayHiEndpointChannel : FusePoCPublish.EsbProxyPerson.SayHiEndpoint, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SayHiEndpointClient : System.ServiceModel.ClientBase<FusePoCPublish.EsbProxyPerson.SayHiEndpoint>, FusePoCPublish.EsbProxyPerson.SayHiEndpoint {
        
        public SayHiEndpointClient() {
        }
        
        public SayHiEndpointClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SayHiEndpointClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SayHiEndpointClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SayHiEndpointClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FusePoCPublish.EsbProxyPerson.SayHiResponse FusePoCPublish.EsbProxyPerson.SayHiEndpoint.SayHi(FusePoCPublish.EsbProxyPerson.SayHiRequest request) {
            return base.Channel.SayHi(request);
        }
        
        public bool SayHi(FusePoCPublish.EsbProxyPerson.Person @in) {
            FusePoCPublish.EsbProxyPerson.SayHiRequest inValue = new FusePoCPublish.EsbProxyPerson.SayHiRequest();
            inValue.@in = @in;
            FusePoCPublish.EsbProxyPerson.SayHiResponse retVal = ((FusePoCPublish.EsbProxyPerson.SayHiEndpoint)(this)).SayHi(inValue);
            return retVal.@out;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FusePoCPublish.EsbProxyPerson.SayHiResponse> FusePoCPublish.EsbProxyPerson.SayHiEndpoint.SayHiAsync(FusePoCPublish.EsbProxyPerson.SayHiRequest request) {
            return base.Channel.SayHiAsync(request);
        }
        
        public System.Threading.Tasks.Task<FusePoCPublish.EsbProxyPerson.SayHiResponse> SayHiAsync(FusePoCPublish.EsbProxyPerson.Person @in) {
            FusePoCPublish.EsbProxyPerson.SayHiRequest inValue = new FusePoCPublish.EsbProxyPerson.SayHiRequest();
            inValue.@in = @in;
            return ((FusePoCPublish.EsbProxyPerson.SayHiEndpoint)(this)).SayHiAsync(inValue);
        }
    }
}