﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace testorm.ServiceFreight {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceFreight.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetYtServerData", ReplyAction="http://tempuri.org/IService/GetYtServerDataResponse")]
        System.Data.DataSet GetYtServerData(string in0, byte[] in1, byte[] in2, byte[] in3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/NewGetYtServerData", ReplyAction="http://tempuri.org/IService/NewGetYtServerDataResponse")]
        System.Data.DataSet NewGetYtServerData(string in0, byte[] in1, byte[] in2, byte[] in3, byte[] in4, byte[] in5, byte[] in6, byte[] in7);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VilidateUser", ReplyAction="http://tempuri.org/IService/VilidateUserResponse")]
        System.Data.DataSet VilidateUser(string in0, byte[] in1, byte[] in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMenuDll", ReplyAction="http://tempuri.org/IService/GetMenuDllResponse")]
        System.Data.DataSet GetMenuDll(string in0, byte[] in1, byte[] in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMenuDllFile", ReplyAction="http://tempuri.org/IService/GetMenuDllFileResponse")]
        System.Data.DataSet GetMenuDllFile(string in0, byte[] in1, byte[] in2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/BookingInfoList", ReplyAction="http://tempuri.org/IService/BookingInfoListResponse")]
        System.Data.DataSet BookingInfoList(string vessel, string voyage, string blno, string page, string clientno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/BlcInfoList", ReplyAction="http://tempuri.org/IService/BlcInfoListResponse")]
        System.Data.DataSet BlcInfoList(string vessel, string voyage, string blno, string page, string clientno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoadAndUnloadPortInfoList", ReplyAction="http://tempuri.org/IService/LoadAndUnloadPortInfoListResponse")]
        System.Data.DataSet LoadAndUnloadPortInfoList(string vessel, string voyage, string blno, string UlpContainer, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CleanManifestInfoList", ReplyAction="http://tempuri.org/IService/CleanManifestInfoListResponse")]
        System.Data.DataSet CleanManifestInfoList(string vessel, string voyage, string blno, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EdiLetPassInfoList", ReplyAction="http://tempuri.org/IService/EdiLetPassInfoListResponse")]
        System.Data.DataSet EdiLetPassInfoList(string blno, string UlpContainer, string entryid, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CstVslInfoList", ReplyAction="http://tempuri.org/IService/CstVslInfoListResponse")]
        System.Data.DataSet CstVslInfoList(string blno, string UlpContainer, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CodecoInfoList", ReplyAction="http://tempuri.org/IService/CodecoInfoListResponse")]
        System.Data.DataSet CodecoInfoList(string jobno, string UlpContainer, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PremanifestInfoList", ReplyAction="http://tempuri.org/IService/PremanifestInfoListResponse")]
        System.Data.DataSet PremanifestInfoList(string vessel, string voyage, string blno, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getAllowData", ReplyAction="http://tempuri.org/IService/getAllowDataResponse")]
        string[][] getAllowData(System.Nullable<System.DateTime> UsoEtdDtFrom, System.Nullable<System.DateTime> UsoEtdDtTo, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getEmbarkData", ReplyAction="http://tempuri.org/IService/getEmbarkDataResponse")]
        string[][] getEmbarkData(System.Nullable<System.DateTime> UsoEtdDtFrom, System.Nullable<System.DateTime> UsoEtdDtTo, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/BookingInfoOriginalList", ReplyAction="http://tempuri.org/IService/BookingInfoOriginalListResponse")]
        System.Data.DataSet BookingInfoOriginalList(string vessel, string voyage, string blno, string page, string clientno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/BlcInfoOriginalList", ReplyAction="http://tempuri.org/IService/BlcInfoOriginalListResponse")]
        System.Data.DataSet BlcInfoOriginalList(string vessel, string voyage, string blno, string page, string clientno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoadAndUnloadPortInfoOriginalList", ReplyAction="http://tempuri.org/IService/LoadAndUnloadPortInfoOriginalListResponse")]
        System.Data.DataSet LoadAndUnloadPortInfoOriginalList(string vessel, string voyage, string blno, string UlpContainer, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CleanManifestInfoOriginalList", ReplyAction="http://tempuri.org/IService/CleanManifestInfoOriginalListResponse")]
        System.Data.DataSet CleanManifestInfoOriginalList(string vessel, string voyage, string blno, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/EdiLetPassInfoOriginalList", ReplyAction="http://tempuri.org/IService/EdiLetPassInfoOriginalListResponse")]
        System.Data.DataSet EdiLetPassInfoOriginalList(string blno, string UlpContainer, string entryid, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CstVslInfoOriginalList", ReplyAction="http://tempuri.org/IService/CstVslInfoOriginalListResponse")]
        System.Data.DataSet CstVslInfoOriginalList(string blno, string UlpContainer, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CodecoInfoOriginalList", ReplyAction="http://tempuri.org/IService/CodecoInfoOriginalListResponse")]
        System.Data.DataSet CodecoInfoOriginalList(string jobno, string UlpContainer, string page);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PremanifestInfoOriginalList", ReplyAction="http://tempuri.org/IService/PremanifestInfoOriginalListResponse")]
        System.Data.DataSet PremanifestInfoOriginalList(string vessel, string voyage, string blno, string page);
        
        // CODEGEN: 消息 FileWrapper 的包装名称(FileWrapper)以后生成的消息协定与默认值(UploadFile)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UploadFile", ReplyAction="http://tempuri.org/IService/UploadFileResponse")]
        testorm.ServiceFreight.result UploadFile(testorm.ServiceFreight.FileWrapper request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DownloadFile", ReplyAction="http://tempuri.org/IService/DownloadFileResponse")]
        System.IO.Stream DownloadFile(string in0, byte[] in1, byte[] in2, string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DownLoadPhysicalApplicationPathFile", ReplyAction="http://tempuri.org/IService/DownLoadPhysicalApplicationPathFileResponse")]
        System.IO.Stream DownLoadPhysicalApplicationPathFile(string in0, byte[] in1, byte[] in2, string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetFileList", ReplyAction="http://tempuri.org/IService/GetFileListResponse")]
        System.Data.DataSet GetFileList(string in0, byte[] in1, byte[] in2, string in3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetFileInfo", ReplyAction="http://tempuri.org/IService/GetFileInfoResponse")]
        System.Data.DataSet GetFileInfo(string in0, byte[] in1, byte[] in2, string in3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FreeApply", ReplyAction="http://tempuri.org/IService/FreeApplyResponse")]
        string[] FreeApply(string in0, byte[] in1, byte[] in2, string[] in3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ChangePassword", ReplyAction="http://tempuri.org/IService/ChangePasswordResponse")]
        string[] ChangePassword(string in0, byte[] in1, byte[] in2, byte[] in3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getPremanifestInfo", ReplyAction="http://tempuri.org/IService/getPremanifestInfoResponse")]
        byte[] getPremanifestInfo(string vessel, string voyage, string blno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCodecoInfo", ReplyAction="http://tempuri.org/IService/getCodecoInfoResponse")]
        byte[] getCodecoInfo(string ctnno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCstVslInfo", ReplyAction="http://tempuri.org/IService/getCstVslInfoResponse")]
        byte[] getCstVslInfo(string blno, string ctnno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getEdiLetPassInfo", ReplyAction="http://tempuri.org/IService/getEdiLetPassInfoResponse")]
        byte[] getEdiLetPassInfo(string blno, string ctnno, string entryid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCleanManifestInfo", ReplyAction="http://tempuri.org/IService/getCleanManifestInfoResponse")]
        byte[] getCleanManifestInfo(string vessel, string voyage, string blno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getLoadAndUnloadPortInfo", ReplyAction="http://tempuri.org/IService/getLoadAndUnloadPortInfoResponse")]
        byte[] getLoadAndUnloadPortInfo(string vessel, string voyage, string blno, string ctnno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getBlcInfo", ReplyAction="http://tempuri.org/IService/getBlcInfoResponse")]
        byte[] getBlcInfo(string vessel, string voyage, string blno, string bookingNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getBookingInfo", ReplyAction="http://tempuri.org/IService/getBookingInfoResponse")]
        byte[] getBookingInfo(string vessel, string voyage, string blno, string bookingNo);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FileWrapper", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FileWrapper {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string in0;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public byte[] in1;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public byte[] in2;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string in3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream in4;
        
        public FileWrapper() {
        }
        
        public FileWrapper(string in0, byte[] in1, byte[] in2, string in3, System.IO.Stream in4) {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
            this.in3 = in3;
            this.in4 = in4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="result", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class result {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool returnresult;
        
        public result() {
        }
        
        public result(bool returnresult) {
            this.returnresult = returnresult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : testorm.ServiceFreight.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<testorm.ServiceFreight.IService>, testorm.ServiceFreight.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetYtServerData(string in0, byte[] in1, byte[] in2, byte[] in3) {
            return base.Channel.GetYtServerData(in0, in1, in2, in3);
        }
        
        public System.Data.DataSet NewGetYtServerData(string in0, byte[] in1, byte[] in2, byte[] in3, byte[] in4, byte[] in5, byte[] in6, byte[] in7) {
            return base.Channel.NewGetYtServerData(in0, in1, in2, in3, in4, in5, in6, in7);
        }
        
        public System.Data.DataSet VilidateUser(string in0, byte[] in1, byte[] in2) {
            return base.Channel.VilidateUser(in0, in1, in2);
        }
        
        public System.Data.DataSet GetMenuDll(string in0, byte[] in1, byte[] in2) {
            return base.Channel.GetMenuDll(in0, in1, in2);
        }
        
        public System.Data.DataSet GetMenuDllFile(string in0, byte[] in1, byte[] in2) {
            return base.Channel.GetMenuDllFile(in0, in1, in2);
        }
        
        public System.Data.DataSet BookingInfoList(string vessel, string voyage, string blno, string page, string clientno) {
            return base.Channel.BookingInfoList(vessel, voyage, blno, page, clientno);
        }
        
        public System.Data.DataSet BlcInfoList(string vessel, string voyage, string blno, string page, string clientno) {
            return base.Channel.BlcInfoList(vessel, voyage, blno, page, clientno);
        }
        
        public System.Data.DataSet LoadAndUnloadPortInfoList(string vessel, string voyage, string blno, string UlpContainer, string page) {
            return base.Channel.LoadAndUnloadPortInfoList(vessel, voyage, blno, UlpContainer, page);
        }
        
        public System.Data.DataSet CleanManifestInfoList(string vessel, string voyage, string blno, string page) {
            return base.Channel.CleanManifestInfoList(vessel, voyage, blno, page);
        }
        
        public System.Data.DataSet EdiLetPassInfoList(string blno, string UlpContainer, string entryid, string page) {
            return base.Channel.EdiLetPassInfoList(blno, UlpContainer, entryid, page);
        }
        
        public System.Data.DataSet CstVslInfoList(string blno, string UlpContainer, string page) {
            return base.Channel.CstVslInfoList(blno, UlpContainer, page);
        }
        
        public System.Data.DataSet CodecoInfoList(string jobno, string UlpContainer, string page) {
            return base.Channel.CodecoInfoList(jobno, UlpContainer, page);
        }
        
        public System.Data.DataSet PremanifestInfoList(string vessel, string voyage, string blno, string page) {
            return base.Channel.PremanifestInfoList(vessel, voyage, blno, page);
        }
        
        public string[][] getAllowData(System.Nullable<System.DateTime> UsoEtdDtFrom, System.Nullable<System.DateTime> UsoEtdDtTo, string page) {
            return base.Channel.getAllowData(UsoEtdDtFrom, UsoEtdDtTo, page);
        }
        
        public string[][] getEmbarkData(System.Nullable<System.DateTime> UsoEtdDtFrom, System.Nullable<System.DateTime> UsoEtdDtTo, string page) {
            return base.Channel.getEmbarkData(UsoEtdDtFrom, UsoEtdDtTo, page);
        }
        
        public System.Data.DataSet BookingInfoOriginalList(string vessel, string voyage, string blno, string page, string clientno) {
            return base.Channel.BookingInfoOriginalList(vessel, voyage, blno, page, clientno);
        }
        
        public System.Data.DataSet BlcInfoOriginalList(string vessel, string voyage, string blno, string page, string clientno) {
            return base.Channel.BlcInfoOriginalList(vessel, voyage, blno, page, clientno);
        }
        
        public System.Data.DataSet LoadAndUnloadPortInfoOriginalList(string vessel, string voyage, string blno, string UlpContainer, string page) {
            return base.Channel.LoadAndUnloadPortInfoOriginalList(vessel, voyage, blno, UlpContainer, page);
        }
        
        public System.Data.DataSet CleanManifestInfoOriginalList(string vessel, string voyage, string blno, string page) {
            return base.Channel.CleanManifestInfoOriginalList(vessel, voyage, blno, page);
        }
        
        public System.Data.DataSet EdiLetPassInfoOriginalList(string blno, string UlpContainer, string entryid, string page) {
            return base.Channel.EdiLetPassInfoOriginalList(blno, UlpContainer, entryid, page);
        }
        
        public System.Data.DataSet CstVslInfoOriginalList(string blno, string UlpContainer, string page) {
            return base.Channel.CstVslInfoOriginalList(blno, UlpContainer, page);
        }
        
        public System.Data.DataSet CodecoInfoOriginalList(string jobno, string UlpContainer, string page) {
            return base.Channel.CodecoInfoOriginalList(jobno, UlpContainer, page);
        }
        
        public System.Data.DataSet PremanifestInfoOriginalList(string vessel, string voyage, string blno, string page) {
            return base.Channel.PremanifestInfoOriginalList(vessel, voyage, blno, page);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        testorm.ServiceFreight.result testorm.ServiceFreight.IService.UploadFile(testorm.ServiceFreight.FileWrapper request) {
            return base.Channel.UploadFile(request);
        }
        
        public bool UploadFile(string in0, byte[] in1, byte[] in2, string in3, System.IO.Stream in4) {
            testorm.ServiceFreight.FileWrapper inValue = new testorm.ServiceFreight.FileWrapper();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            inValue.in3 = in3;
            inValue.in4 = in4;
            testorm.ServiceFreight.result retVal = ((testorm.ServiceFreight.IService)(this)).UploadFile(inValue);
            return retVal.returnresult;
        }
        
        public System.IO.Stream DownloadFile(string in0, byte[] in1, byte[] in2, string filename) {
            return base.Channel.DownloadFile(in0, in1, in2, filename);
        }
        
        public System.IO.Stream DownLoadPhysicalApplicationPathFile(string in0, byte[] in1, byte[] in2, string filename) {
            return base.Channel.DownLoadPhysicalApplicationPathFile(in0, in1, in2, filename);
        }
        
        public System.Data.DataSet GetFileList(string in0, byte[] in1, byte[] in2, string in3) {
            return base.Channel.GetFileList(in0, in1, in2, in3);
        }
        
        public System.Data.DataSet GetFileInfo(string in0, byte[] in1, byte[] in2, string in3) {
            return base.Channel.GetFileInfo(in0, in1, in2, in3);
        }
        
        public string[] FreeApply(string in0, byte[] in1, byte[] in2, string[] in3) {
            return base.Channel.FreeApply(in0, in1, in2, in3);
        }
        
        public string[] ChangePassword(string in0, byte[] in1, byte[] in2, byte[] in3) {
            return base.Channel.ChangePassword(in0, in1, in2, in3);
        }
        
        public byte[] getPremanifestInfo(string vessel, string voyage, string blno) {
            return base.Channel.getPremanifestInfo(vessel, voyage, blno);
        }
        
        public byte[] getCodecoInfo(string ctnno) {
            return base.Channel.getCodecoInfo(ctnno);
        }
        
        public byte[] getCstVslInfo(string blno, string ctnno) {
            return base.Channel.getCstVslInfo(blno, ctnno);
        }
        
        public byte[] getEdiLetPassInfo(string blno, string ctnno, string entryid) {
            return base.Channel.getEdiLetPassInfo(blno, ctnno, entryid);
        }
        
        public byte[] getCleanManifestInfo(string vessel, string voyage, string blno) {
            return base.Channel.getCleanManifestInfo(vessel, voyage, blno);
        }
        
        public byte[] getLoadAndUnloadPortInfo(string vessel, string voyage, string blno, string ctnno) {
            return base.Channel.getLoadAndUnloadPortInfo(vessel, voyage, blno, ctnno);
        }
        
        public byte[] getBlcInfo(string vessel, string voyage, string blno, string bookingNo) {
            return base.Channel.getBlcInfo(vessel, voyage, blno, bookingNo);
        }
        
        public byte[] getBookingInfo(string vessel, string voyage, string blno, string bookingNo) {
            return base.Channel.getBookingInfo(vessel, voyage, blno, bookingNo);
        }
    }
}
