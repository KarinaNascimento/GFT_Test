//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GFT_Solution_Test.TradeCategoryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TradeType", Namespace="http://schemas.datacontract.org/2004/07/GFT_Test_Service")]
    [System.SerializableAttribute()]
    public partial class TradeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientSectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValueField;
        
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
        public string ClientSector {
            get {
                return this.ClientSectorField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientSectorField, value) != true)) {
                    this.ClientSectorField = value;
                    this.RaisePropertyChanged("ClientSector");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TradeCategoryService.ITradeCategory")]
    public interface ITradeCategory {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITradeCategory/CheckCategory", ReplyAction="http://tempuri.org/ITradeCategory/CheckCategoryResponse")]
        string[] CheckCategory(GFT_Solution_Test.TradeCategoryService.TradeType[] tradeList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITradeCategory/CheckCategory", ReplyAction="http://tempuri.org/ITradeCategory/CheckCategoryResponse")]
        System.Threading.Tasks.Task<string[]> CheckCategoryAsync(GFT_Solution_Test.TradeCategoryService.TradeType[] tradeList);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITradeCategoryChannel : GFT_Solution_Test.TradeCategoryService.ITradeCategory, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TradeCategoryClient : System.ServiceModel.ClientBase<GFT_Solution_Test.TradeCategoryService.ITradeCategory>, GFT_Solution_Test.TradeCategoryService.ITradeCategory {
        
        public TradeCategoryClient() {
        }
        
        public TradeCategoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TradeCategoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TradeCategoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TradeCategoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] CheckCategory(GFT_Solution_Test.TradeCategoryService.TradeType[] tradeList) {
            return base.Channel.CheckCategory(tradeList);
        }
        
        public System.Threading.Tasks.Task<string[]> CheckCategoryAsync(GFT_Solution_Test.TradeCategoryService.TradeType[] tradeList) {
            return base.Channel.CheckCategoryAsync(tradeList);
        }
    }
}
