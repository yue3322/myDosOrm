﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace testorm.CustomerServiceWcf {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/CustomerServiceWcf")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UCLEnum", Namespace="http://schemas.datacontract.org/2004/07/ServiceCommon.Enum")]
    public enum UCLEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Import = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Upload = 20,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ElectronicPacking", Namespace="http://schemas.datacontract.org/2004/07/CustomerServiceCommon.Models.Model")]
    [System.SerializableAttribute()]
    public partial class ElectronicPacking : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string csotcoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string csotcoDtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ctntypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private testorm.CustomerServiceWcf.CtnResult[] detailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string in_addrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string in_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string total_packageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string total_weightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string voyageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vslnameField;
        
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
        public string csotco {
            get {
                return this.csotcoField;
            }
            set {
                if ((object.ReferenceEquals(this.csotcoField, value) != true)) {
                    this.csotcoField = value;
                    this.RaisePropertyChanged("csotco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string csotcoDt {
            get {
                return this.csotcoDtField;
            }
            set {
                if ((object.ReferenceEquals(this.csotcoDtField, value) != true)) {
                    this.csotcoDtField = value;
                    this.RaisePropertyChanged("csotcoDt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ctntype {
            get {
                return this.ctntypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ctntypeField, value) != true)) {
                    this.ctntypeField = value;
                    this.RaisePropertyChanged("ctntype");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public testorm.CustomerServiceWcf.CtnResult[] detail {
            get {
                return this.detailField;
            }
            set {
                if ((object.ReferenceEquals(this.detailField, value) != true)) {
                    this.detailField = value;
                    this.RaisePropertyChanged("detail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string in_addr {
            get {
                return this.in_addrField;
            }
            set {
                if ((object.ReferenceEquals(this.in_addrField, value) != true)) {
                    this.in_addrField = value;
                    this.RaisePropertyChanged("in_addr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string in_date {
            get {
                return this.in_dateField;
            }
            set {
                if ((object.ReferenceEquals(this.in_dateField, value) != true)) {
                    this.in_dateField = value;
                    this.RaisePropertyChanged("in_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string total_package {
            get {
                return this.total_packageField;
            }
            set {
                if ((object.ReferenceEquals(this.total_packageField, value) != true)) {
                    this.total_packageField = value;
                    this.RaisePropertyChanged("total_package");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string total_weight {
            get {
                return this.total_weightField;
            }
            set {
                if ((object.ReferenceEquals(this.total_weightField, value) != true)) {
                    this.total_weightField = value;
                    this.RaisePropertyChanged("total_weight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string voyage {
            get {
                return this.voyageField;
            }
            set {
                if ((object.ReferenceEquals(this.voyageField, value) != true)) {
                    this.voyageField = value;
                    this.RaisePropertyChanged("voyage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vslname {
            get {
                return this.vslnameField;
            }
            set {
                if ((object.ReferenceEquals(this.vslnameField, value) != true)) {
                    this.vslnameField = value;
                    this.RaisePropertyChanged("vslname");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CtnResult", Namespace="http://schemas.datacontract.org/2004/07/CustomerServiceCommon.Models.Model")]
    [System.SerializableAttribute()]
    public partial class CtnResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string blnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string csotrpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ctn_opr_codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ctnnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cus_statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cus_timeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string packageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string unloadportField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string voyageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vslnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string weightField;
        
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
        public string blno {
            get {
                return this.blnoField;
            }
            set {
                if ((object.ReferenceEquals(this.blnoField, value) != true)) {
                    this.blnoField = value;
                    this.RaisePropertyChanged("blno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string csotrp {
            get {
                return this.csotrpField;
            }
            set {
                if ((object.ReferenceEquals(this.csotrpField, value) != true)) {
                    this.csotrpField = value;
                    this.RaisePropertyChanged("csotrp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ctn_opr_code {
            get {
                return this.ctn_opr_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.ctn_opr_codeField, value) != true)) {
                    this.ctn_opr_codeField = value;
                    this.RaisePropertyChanged("ctn_opr_code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ctnno {
            get {
                return this.ctnnoField;
            }
            set {
                if ((object.ReferenceEquals(this.ctnnoField, value) != true)) {
                    this.ctnnoField = value;
                    this.RaisePropertyChanged("ctnno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cus_status {
            get {
                return this.cus_statusField;
            }
            set {
                if ((object.ReferenceEquals(this.cus_statusField, value) != true)) {
                    this.cus_statusField = value;
                    this.RaisePropertyChanged("cus_status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cus_time {
            get {
                return this.cus_timeField;
            }
            set {
                if ((object.ReferenceEquals(this.cus_timeField, value) != true)) {
                    this.cus_timeField = value;
                    this.RaisePropertyChanged("cus_time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string package {
            get {
                return this.packageField;
            }
            set {
                if ((object.ReferenceEquals(this.packageField, value) != true)) {
                    this.packageField = value;
                    this.RaisePropertyChanged("package");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unloadport {
            get {
                return this.unloadportField;
            }
            set {
                if ((object.ReferenceEquals(this.unloadportField, value) != true)) {
                    this.unloadportField = value;
                    this.RaisePropertyChanged("unloadport");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string voyage {
            get {
                return this.voyageField;
            }
            set {
                if ((object.ReferenceEquals(this.voyageField, value) != true)) {
                    this.voyageField = value;
                    this.RaisePropertyChanged("voyage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vslname {
            get {
                return this.vslnameField;
            }
            set {
                if ((object.ReferenceEquals(this.vslnameField, value) != true)) {
                    this.vslnameField = value;
                    this.RaisePropertyChanged("vslname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string weight {
            get {
                return this.weightField;
            }
            set {
                if ((object.ReferenceEquals(this.weightField, value) != true)) {
                    this.weightField = value;
                    this.RaisePropertyChanged("weight");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerServiceWcf.ICustomerServiceWcfService")]
    public interface ICustomerServiceWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/GetData", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/GetDataUsingDataContractResponse")]
        testorm.CustomerServiceWcf.CompositeType GetDataUsingDataContract(testorm.CustomerServiceWcf.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/exportEntryList", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/exportEntryListResponse")]
        bool exportEntryList(string sJson, string customercd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/synchronizationData", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/synchronizationDataResponse")]
        bool synchronizationData(string sJson, ref string errorstr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/importCDSystemData", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/importCDSystemDataResponse")]
        string importCDSystemData(string EPAccount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/getCDSystemData", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/getCDSystemDataResponse")]
        bool getCDSystemData(string sJson, ref string errorstr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/getExportEdiNOs", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/getExportEdiNOsResponse")]
        string getExportEdiNOs(string EPAccount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/changeExportState", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/changeExportStateResponse")]
        bool changeExportState(string ediNO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/changeImportState", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/changeImportStateResponse")]
        bool changeImportState(string ediNO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/importCDSystemDataStr", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/importCDSystemDataStrResponse")]
        string importCDSystemDataStr(string EPAccount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/checkCustomerSeviceEdiNo", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/checkCustomerSeviceEdiNoResponse")]
        bool checkCustomerSeviceEdiNo(string ediNO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/exportDF", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/exportDFResponse")]
        bool exportDF(string sJson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/getuploadFile", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/getuploadFileResponse")]
        string getuploadFile(string Number, string SysCd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/SaveUclLog", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/SaveUclLogResponse")]
        void SaveUclLog(string EdiNo, testorm.CustomerServiceWcf.UCLEnum enumtype, string ep, string customercd, string ex, bool status, string UclOperator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/ErrorLog", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/ErrorLogResponse")]
        void ErrorLog(string ErrorFile, string Message, string EDINo, string epNo, string CudtomerCd, string Operator, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/getEdiNo", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/getEdiNoResponse")]
        string[] getEdiNo(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/exportManual", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/exportManualResponse")]
        bool exportManual(string tableName, string json);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/H2000ImportDeclare", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/H2000ImportDeclareResponse")]
        string[] H2000ImportDeclare(string sJson, int days, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/exportManualSingle", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/exportManualSingleResponse")]
        string exportManualSingle(string json);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/getStatus", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/getStatusResponse")]
        void getStatus(string json);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/updateEntryId", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/updateEntryIdResponse")]
        void updateEntryId(string[] strList, string customercd);
        
        // CODEGEN: 消息 getDataRequest 的包装名称(getData)以后生成的消息协定与默认值(getData1)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/getData", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/getDataResponse")]
        testorm.CustomerServiceWcf.getDataResponse getData1(testorm.CustomerServiceWcf.getDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerServiceWcfService/GetCstVslInfo", ReplyAction="http://tempuri.org/ICustomerServiceWcfService/GetCstVslInfoResponse")]
        testorm.CustomerServiceWcf.ElectronicPacking GetCstVslInfo(string blno, string ctnno);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string tableName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string where;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string token;
        
        public getDataRequest() {
        }
        
        public getDataRequest(string tableName, string where, string token) {
            this.tableName = tableName;
            this.where = where;
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDataResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string getDataResult;
        
        public getDataResponse() {
        }
        
        public getDataResponse(string getDataResult) {
            this.getDataResult = getDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceWcfServiceChannel : testorm.CustomerServiceWcf.ICustomerServiceWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceWcfServiceClient : System.ServiceModel.ClientBase<testorm.CustomerServiceWcf.ICustomerServiceWcfService>, testorm.CustomerServiceWcf.ICustomerServiceWcfService {
        
        public CustomerServiceWcfServiceClient() {
        }
        
        public CustomerServiceWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public testorm.CustomerServiceWcf.CompositeType GetDataUsingDataContract(testorm.CustomerServiceWcf.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public bool exportEntryList(string sJson, string customercd) {
            return base.Channel.exportEntryList(sJson, customercd);
        }
        
        public bool synchronizationData(string sJson, ref string errorstr) {
            return base.Channel.synchronizationData(sJson, ref errorstr);
        }
        
        public string importCDSystemData(string EPAccount) {
            return base.Channel.importCDSystemData(EPAccount);
        }
        
        public bool getCDSystemData(string sJson, ref string errorstr) {
            return base.Channel.getCDSystemData(sJson, ref errorstr);
        }
        
        public string getExportEdiNOs(string EPAccount) {
            return base.Channel.getExportEdiNOs(EPAccount);
        }
        
        public bool changeExportState(string ediNO) {
            return base.Channel.changeExportState(ediNO);
        }
        
        public bool changeImportState(string ediNO) {
            return base.Channel.changeImportState(ediNO);
        }
        
        public string importCDSystemDataStr(string EPAccount) {
            return base.Channel.importCDSystemDataStr(EPAccount);
        }
        
        public bool checkCustomerSeviceEdiNo(string ediNO) {
            return base.Channel.checkCustomerSeviceEdiNo(ediNO);
        }
        
        public bool exportDF(string sJson) {
            return base.Channel.exportDF(sJson);
        }
        
        public string getuploadFile(string Number, string SysCd) {
            return base.Channel.getuploadFile(Number, SysCd);
        }
        
        public void SaveUclLog(string EdiNo, testorm.CustomerServiceWcf.UCLEnum enumtype, string ep, string customercd, string ex, bool status, string UclOperator) {
            base.Channel.SaveUclLog(EdiNo, enumtype, ep, customercd, ex, status, UclOperator);
        }
        
        public void ErrorLog(string ErrorFile, string Message, string EDINo, string epNo, string CudtomerCd, string Operator, string status) {
            base.Channel.ErrorLog(ErrorFile, Message, EDINo, epNo, CudtomerCd, Operator, status);
        }
        
        public string[] getEdiNo(string str) {
            return base.Channel.getEdiNo(str);
        }
        
        public bool exportManual(string tableName, string json) {
            return base.Channel.exportManual(tableName, json);
        }
        
        public string[] H2000ImportDeclare(string sJson, int days, string date) {
            return base.Channel.H2000ImportDeclare(sJson, days, date);
        }
        
        public string exportManualSingle(string json) {
            return base.Channel.exportManualSingle(json);
        }
        
        public void getStatus(string json) {
            base.Channel.getStatus(json);
        }
        
        public void updateEntryId(string[] strList, string customercd) {
            base.Channel.updateEntryId(strList, customercd);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        testorm.CustomerServiceWcf.getDataResponse testorm.CustomerServiceWcf.ICustomerServiceWcfService.getData1(testorm.CustomerServiceWcf.getDataRequest request) {
            return base.Channel.getData1(request);
        }
        
        public string getData1(string tableName, string where, string token) {
            testorm.CustomerServiceWcf.getDataRequest inValue = new testorm.CustomerServiceWcf.getDataRequest();
            inValue.tableName = tableName;
            inValue.where = where;
            inValue.token = token;
            testorm.CustomerServiceWcf.getDataResponse retVal = ((testorm.CustomerServiceWcf.ICustomerServiceWcfService)(this)).getData1(inValue);
            return retVal.getDataResult;
        }
        
        public testorm.CustomerServiceWcf.ElectronicPacking GetCstVslInfo(string blno, string ctnno) {
            return base.Channel.GetCstVslInfo(blno, ctnno);
        }
    }
}
