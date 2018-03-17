﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Currency_Exchange.Currency_Service {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Currency_Service.ConverterSoap")]
    public interface ConverterSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCurrencies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] GetCurrencies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCurrencies", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> GetCurrenciesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCurrencyRate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        decimal GetCurrencyRate(string Currency, System.DateTime RateDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCurrencyRate", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> GetCurrencyRateAsync(string Currency, System.DateTime RateDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCurrencyRates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetCurrencyRates(System.DateTime RateDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCurrencyRates", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCurrencyRatesAsync(System.DateTime RateDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConversionRate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        decimal GetConversionRate(string CurrencyFrom, string CurrencyTo, System.DateTime RateDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConversionRate", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> GetConversionRateAsync(string CurrencyFrom, string CurrencyTo, System.DateTime RateDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConversionAmount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        decimal GetConversionAmount(string CurrencyFrom, string CurrencyTo, System.DateTime RateDate, decimal Amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConversionAmount", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> GetConversionAmountAsync(string CurrencyFrom, string CurrencyTo, System.DateTime RateDate, decimal Amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCultureInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetCultureInfo(string Currency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCultureInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetCultureInfoAsync(string Currency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertDataTableColumn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Currency_Exchange.Currency_Service.ConvertDataTableColumnResponse ConvertDataTableColumn(Currency_Exchange.Currency_Service.ConvertDataTableColumnRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertDataTableColumn", ReplyAction="*")]
        System.Threading.Tasks.Task<Currency_Exchange.Currency_Service.ConvertDataTableColumnResponse> ConvertDataTableColumnAsync(Currency_Exchange.Currency_Service.ConvertDataTableColumnRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLastUpdateDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.DateTime GetLastUpdateDate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLastUpdateDate", ReplyAction="*")]
        System.Threading.Tasks.Task<System.DateTime> GetLastUpdateDateAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConvertDataTableColumn", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConvertDataTableColumnRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataSet ds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int TableIndex;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string ColumnName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string FromCurrency;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string ToCurrency;
        
        public ConvertDataTableColumnRequest() {
        }
        
        public ConvertDataTableColumnRequest(System.Data.DataSet ds, int TableIndex, string ColumnName, string FromCurrency, string ToCurrency) {
            this.ds = ds;
            this.TableIndex = TableIndex;
            this.ColumnName = ColumnName;
            this.FromCurrency = FromCurrency;
            this.ToCurrency = ToCurrency;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConvertDataTableColumnResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ConvertDataTableColumnResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataSet ds;
        
        public ConvertDataTableColumnResponse() {
        }
        
        public ConvertDataTableColumnResponse(System.Data.DataSet ds) {
            this.ds = ds;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConverterSoapChannel : Currency_Exchange.Currency_Service.ConverterSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConverterSoapClient : System.ServiceModel.ClientBase<Currency_Exchange.Currency_Service.ConverterSoap>, Currency_Exchange.Currency_Service.ConverterSoap {
        
        public ConverterSoapClient() {
        }
        
        public ConverterSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConverterSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConverterSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConverterSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetCurrencies() {
            return base.Channel.GetCurrencies();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCurrenciesAsync() {
            return base.Channel.GetCurrenciesAsync();
        }
        
        public decimal GetCurrencyRate(string Currency, System.DateTime RateDate) {
            return base.Channel.GetCurrencyRate(Currency, RateDate);
        }
        
        public System.Threading.Tasks.Task<decimal> GetCurrencyRateAsync(string Currency, System.DateTime RateDate) {
            return base.Channel.GetCurrencyRateAsync(Currency, RateDate);
        }
        
        public System.Data.DataSet GetCurrencyRates(System.DateTime RateDate) {
            return base.Channel.GetCurrencyRates(RateDate);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCurrencyRatesAsync(System.DateTime RateDate) {
            return base.Channel.GetCurrencyRatesAsync(RateDate);
        }
        
        public decimal GetConversionRate(string CurrencyFrom, string CurrencyTo, System.DateTime RateDate) {
            return base.Channel.GetConversionRate(CurrencyFrom, CurrencyTo, RateDate);
        }
        
        public System.Threading.Tasks.Task<decimal> GetConversionRateAsync(string CurrencyFrom, string CurrencyTo, System.DateTime RateDate) {
            return base.Channel.GetConversionRateAsync(CurrencyFrom, CurrencyTo, RateDate);
        }
        
        public decimal GetConversionAmount(string CurrencyFrom, string CurrencyTo, System.DateTime RateDate, decimal Amount) {
            return base.Channel.GetConversionAmount(CurrencyFrom, CurrencyTo, RateDate, Amount);
        }
        
        public System.Threading.Tasks.Task<decimal> GetConversionAmountAsync(string CurrencyFrom, string CurrencyTo, System.DateTime RateDate, decimal Amount) {
            return base.Channel.GetConversionAmountAsync(CurrencyFrom, CurrencyTo, RateDate, Amount);
        }
        
        public string GetCultureInfo(string Currency) {
            return base.Channel.GetCultureInfo(Currency);
        }
        
        public System.Threading.Tasks.Task<string> GetCultureInfoAsync(string Currency) {
            return base.Channel.GetCultureInfoAsync(Currency);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Currency_Exchange.Currency_Service.ConvertDataTableColumnResponse Currency_Exchange.Currency_Service.ConverterSoap.ConvertDataTableColumn(Currency_Exchange.Currency_Service.ConvertDataTableColumnRequest request) {
            return base.Channel.ConvertDataTableColumn(request);
        }
        
        public void ConvertDataTableColumn(ref System.Data.DataSet ds, int TableIndex, string ColumnName, string FromCurrency, string ToCurrency) {
            Currency_Exchange.Currency_Service.ConvertDataTableColumnRequest inValue = new Currency_Exchange.Currency_Service.ConvertDataTableColumnRequest();
            inValue.ds = ds;
            inValue.TableIndex = TableIndex;
            inValue.ColumnName = ColumnName;
            inValue.FromCurrency = FromCurrency;
            inValue.ToCurrency = ToCurrency;
            Currency_Exchange.Currency_Service.ConvertDataTableColumnResponse retVal = ((Currency_Exchange.Currency_Service.ConverterSoap)(this)).ConvertDataTableColumn(inValue);
            ds = retVal.ds;
        }
        
        public System.Threading.Tasks.Task<Currency_Exchange.Currency_Service.ConvertDataTableColumnResponse> ConvertDataTableColumnAsync(Currency_Exchange.Currency_Service.ConvertDataTableColumnRequest request) {
            return base.Channel.ConvertDataTableColumnAsync(request);
        }
        
        public System.DateTime GetLastUpdateDate() {
            return base.Channel.GetLastUpdateDate();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetLastUpdateDateAsync() {
            return base.Channel.GetLastUpdateDateAsync();
        }
    }
}
