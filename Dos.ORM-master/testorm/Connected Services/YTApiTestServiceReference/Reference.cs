﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace testorm.YTApiTestServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="YTApiTestServiceReference.IYTApiTestService")]
    public interface IYTApiTestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYTApiTestService/CUSWEB_RSK_RESULT_REL", ReplyAction="http://tempuri.org/IYTApiTestService/CUSWEB_RSK_RESULT_RELResponse")]
        string CUSWEB_RSK_RESULT_REL(string DECL_BEG_DATE, string DECL_END_DATE, string DECL_CODE, string DECL_NAME, string TRADE_CO, string TRADE_NAME, string I_E_FLAG, string RSLT_BEG_DATE, string RSLT_END_DATE, string ENTRY_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYTApiTestService/CUSWEB_RSK_RESULT_YSGK", ReplyAction="http://tempuri.org/IYTApiTestService/CUSWEB_RSK_RESULT_YSGKResponse")]
        string CUSWEB_RSK_RESULT_YSGK(string DECL_BEG_DATE, string DECL_END_DATE, string TRADE_CO, string TRADE_NAME, string DECL_CODE, string DECL_NAME, string I_E_FLAG, string ENTRY_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYTApiTestService/CUSWEB_REL_PASS", ReplyAction="http://tempuri.org/IYTApiTestService/CUSWEB_REL_PASSResponse")]
        string CUSWEB_REL_PASS(string BILL_NO, string I_E_FLAG, string PASS_BEG_DATE, string PASS_END_DATE, string ENTRY_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYTApiTestService/ODISRC_CNCP01", ReplyAction="http://tempuri.org/IYTApiTestService/ODISRC_CNCP01Response")]
        string ODISRC_CNCP01(string BILL_NO, string SENDER_BEG_DATE, string SENDER_END_DATE, string I_E_BEG_DATE, string I_E_END_DATE, string I_E_FLAG, string VOYAGE_NO, string SHIP_NAME_EN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYTApiTestService/CUSWEB_H2000RTAX", ReplyAction="http://tempuri.org/IYTApiTestService/CUSWEB_H2000RTAXResponse")]
        string CUSWEB_H2000RTAX(string D_BEG_DATE, string D_END_DATE, string E_BEG_DATE, string E_END_DATE, string IO_FLAG, string BILL_NO, string ENTRY_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYTApiTestService/CUSWEB_POSTRTAX", ReplyAction="http://tempuri.org/IYTApiTestService/CUSWEB_POSTRTAXResponse")]
        string CUSWEB_POSTRTAX(string D_BEG_DATE, string D_END_DATE, string E_BEG_DATE, string E_END_DATE, string IO_FLAG, string BILL_NO, string ENTRY_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYTApiTestService/ODISRC_COSTRP", ReplyAction="http://tempuri.org/IYTApiTestService/ODISRC_COSTRPResponse")]
        string ODISRC_COSTRP(string BL_NO, string CTN_NO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYTApiTestService/QueryData", ReplyAction="http://tempuri.org/IYTApiTestService/QueryDataResponse")]
        string QueryData(string xml);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IYTApiTestServiceChannel : testorm.YTApiTestServiceReference.IYTApiTestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class YTApiTestServiceClient : System.ServiceModel.ClientBase<testorm.YTApiTestServiceReference.IYTApiTestService>, testorm.YTApiTestServiceReference.IYTApiTestService {
        
        public YTApiTestServiceClient() {
        }
        
        public YTApiTestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public YTApiTestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YTApiTestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YTApiTestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CUSWEB_RSK_RESULT_REL(string DECL_BEG_DATE, string DECL_END_DATE, string DECL_CODE, string DECL_NAME, string TRADE_CO, string TRADE_NAME, string I_E_FLAG, string RSLT_BEG_DATE, string RSLT_END_DATE, string ENTRY_ID) {
            return base.Channel.CUSWEB_RSK_RESULT_REL(DECL_BEG_DATE, DECL_END_DATE, DECL_CODE, DECL_NAME, TRADE_CO, TRADE_NAME, I_E_FLAG, RSLT_BEG_DATE, RSLT_END_DATE, ENTRY_ID);
        }
        
        public string CUSWEB_RSK_RESULT_YSGK(string DECL_BEG_DATE, string DECL_END_DATE, string TRADE_CO, string TRADE_NAME, string DECL_CODE, string DECL_NAME, string I_E_FLAG, string ENTRY_ID) {
            return base.Channel.CUSWEB_RSK_RESULT_YSGK(DECL_BEG_DATE, DECL_END_DATE, TRADE_CO, TRADE_NAME, DECL_CODE, DECL_NAME, I_E_FLAG, ENTRY_ID);
        }
        
        public string CUSWEB_REL_PASS(string BILL_NO, string I_E_FLAG, string PASS_BEG_DATE, string PASS_END_DATE, string ENTRY_ID) {
            return base.Channel.CUSWEB_REL_PASS(BILL_NO, I_E_FLAG, PASS_BEG_DATE, PASS_END_DATE, ENTRY_ID);
        }
        
        public string ODISRC_CNCP01(string BILL_NO, string SENDER_BEG_DATE, string SENDER_END_DATE, string I_E_BEG_DATE, string I_E_END_DATE, string I_E_FLAG, string VOYAGE_NO, string SHIP_NAME_EN) {
            return base.Channel.ODISRC_CNCP01(BILL_NO, SENDER_BEG_DATE, SENDER_END_DATE, I_E_BEG_DATE, I_E_END_DATE, I_E_FLAG, VOYAGE_NO, SHIP_NAME_EN);
        }
        
        public string CUSWEB_H2000RTAX(string D_BEG_DATE, string D_END_DATE, string E_BEG_DATE, string E_END_DATE, string IO_FLAG, string BILL_NO, string ENTRY_ID) {
            return base.Channel.CUSWEB_H2000RTAX(D_BEG_DATE, D_END_DATE, E_BEG_DATE, E_END_DATE, IO_FLAG, BILL_NO, ENTRY_ID);
        }
        
        public string CUSWEB_POSTRTAX(string D_BEG_DATE, string D_END_DATE, string E_BEG_DATE, string E_END_DATE, string IO_FLAG, string BILL_NO, string ENTRY_ID) {
            return base.Channel.CUSWEB_POSTRTAX(D_BEG_DATE, D_END_DATE, E_BEG_DATE, E_END_DATE, IO_FLAG, BILL_NO, ENTRY_ID);
        }
        
        public string ODISRC_COSTRP(string BL_NO, string CTN_NO) {
            return base.Channel.ODISRC_COSTRP(BL_NO, CTN_NO);
        }
        
        public string QueryData(string xml) {
            return base.Channel.QueryData(xml);
        }
    }
}
