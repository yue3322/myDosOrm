using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.IO;
//using ICSharpCode.SharpZipLib.GZip;

namespace Librarys
{
    public static class ApiHelper
    {

    //    /// <summary>
    //    /// 通用调用亿通接口
    //    /// </summary>
    //    /// <param name="xml"></param>
    //    /// <returns></returns>
    //    public static string QueryData(string xml)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }
    //    #region 海关查验
    //    /// <summary>
    //    /// 海关查验
    //    /// </summary>
    //    /// <param name="DECL_BEG_DATE">申报开始日期:YYYYMMDD格式，例如20160219</param>
    //    /// <param name="DECL_END_DATE">申报结束日期:YYYYMMDD格式，例如20160219</param>
    //    /// <param name="DECL_CODE">申报单位代码</param>
    //    /// <param name="DECL_NAME">申报单位名称</param>
    //    /// <param name="TRADE_CO">经营单位代码</param>
    //    /// <param name="TRADE_NAME">经营单位名称</param>
    //    /// <param name="I_E_FLAG">进出口标识:I 进口,E 出口</param>
    //    /// <param name="RSLT_BEG_DATE">查验开始日期:YYYYMMDD格式，例如20160219</param>
    //    /// <param name="RSLT_END_DATE">查验结束日期:YYYYMMDD格式，例如20160219</param>
    //    /// <param name="ENTRY_ID">报关单号:后九位数字</param>
    //    /// <returns>ENTRY_ID	报关单号
    //    /// OWN_CODE	货主单位
    //    /// DECL_CODE	申报单位代码
    //    /// DECL_NAME	申报单位名称
    //    /// TRADE_CO	经营单位代码
    //    /// TRADE_NAME	经营单位名称
    //    /// DECL_DATE	申报日期
    //    /// I_E_FLAG	进出口标识:I 进口,E 出口
    //    /// RSLT_FLAG_CODE	查验结果:Y 查验，N 不查验
    //    /// RSLT_DATE	查验日期
    //    /// </returns>
    //    public static string CUSWEB_RSK_RESULT_REL(string DECL_BEG_DATE, string DECL_END_DATE, string DECL_CODE, string DECL_NAME, string TRADE_CO,
    //        string TRADE_NAME, string I_E_FLAG, string RSLT_BEG_DATE, string RSLT_END_DATE, string ENTRY_ID)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    //        xml += "<GCCQuery xmlns=\"biz.easipass.com\">";
    //        xml += "<Info>";
    //        xml += "<QueryType>CUSWEB_RSK_RESULT_REL</QueryType>";
    //        xml += "<Authenticator><user>a</user><password>a</password><sign>0123456789</sign></Authenticator>";
    //        xml += "</Info>";
    //        xml += "<Criteria>";
    //        if (!string.IsNullOrEmpty(DECL_BEG_DATE))
    //            xml += "<Key><name>DECL_BEG_DATE</name><value>" + DECL_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(DECL_END_DATE))
    //            xml += "<Key><name>DECL_END_DATE</name><value>" + DECL_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(DECL_CODE))
    //            xml += "<Key><name>DECL_CODE</name><value>" + DECL_CODE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(DECL_NAME))
    //            xml += "<Key><name>DECL_NAME</name><value>" + DECL_NAME + "</value></Key>";
    //        if (!string.IsNullOrEmpty(TRADE_CO))
    //            xml += "<Key><name>TRADE_CO</name><value>" + TRADE_CO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(TRADE_NAME))
    //            xml += "<Key><name>TRADE_NAME</name><value>" + TRADE_NAME + "</value></Key>";
    //        if (!string.IsNullOrEmpty(I_E_FLAG))
    //            xml += "<Key><name>I_E_FLAG</name><value>" + I_E_FLAG + "</value></Key>";
    //        if (!string.IsNullOrEmpty(RSLT_BEG_DATE))
    //            xml += "<Key><name>RSLT_BEG_DATE</name><value>" + RSLT_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(RSLT_END_DATE))
    //            xml += "<Key><name>RSLT_END_DATE</name><value>" + RSLT_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(ENTRY_ID))
    //            xml += "<Key><name>ENTRY_ID</name><value>" + ENTRY_ID + "</value></Key>";
    //        xml += "</Criteria>";
    //        xml += "</GCCQuery>";
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }
    //    #endregion
    //    #region 洋山查验
    //    /// <summary>
    //    /// 洋山查验
    //    /// </summary>
    //    /// <param name="DECL_BEG_DATE">申报开始日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="DECL_END_DATE">申报结束日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="TRADE_CO">经营单位代码</param>
    //    /// <param name="TRADE_NAME">经营单位名称</param>
    //    /// <param name="DECL_CODE">申报单位代码</param>
    //    /// <param name="DECL_NAME">申报单位名称</param>
    //    /// <param name="I_E_FLAG">进出口标识	I 进口,E 出口</param>
    //    /// <param name="ENTRY_ID">报关单号</param>
    //    /// <returns>
    //    /// ENTRY_ID	报关单号	
    //    /// OWN_CODE	货主单位	
    //    /// DECL_CODE	申报单位代码	
    //    /// DECL_NAME	申报单位名称	
    //    /// TRADE_CO	经营单位代码	
    //    /// TRADE_NAME	经营单位名称	
    //    /// DECL_DATE	申报日期	
    //    /// I_E_FLAG	进出口标识	I 进口,E 出口
    //    /// RSK_CODE	查验结果	01：货物未运抵
    //    ///                         02：报关单已撤消
    //    ///                         03：海关查验、货超期运抵
    //    ///                         04：海关查验
    //    ///                         05：海关不查验、货超期运抵
    //    ///                         06：海关不查验
    //    /// RSK_DATE	查验日期	
    //    /// </returns>
    //    public static string CUSWEB_RSK_RESULT_YSGK(string DECL_BEG_DATE, string DECL_END_DATE, string TRADE_CO, string TRADE_NAME, string DECL_CODE, string DECL_NAME, string I_E_FLAG, string ENTRY_ID)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    //        xml += "<GCCQuery xmlns=\"biz.easipass.com\">";
    //        xml += "<Info>";
    //        xml += "<QueryType>CUSWEB_RSK_RESULT_YSGK</QueryType>";
    //        xml += "<Authenticator><user>a</user><password>a</password><sign>0123456789</sign></Authenticator>";
    //        xml += "</Info>";
    //        xml += "<Criteria>";
    //        if (!string.IsNullOrEmpty(DECL_BEG_DATE))
    //            xml += "<Key><name>DECL_BEG_DATE</name><value>" + DECL_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(DECL_END_DATE))
    //            xml += "<Key><name>DECL_END_DATE</name><value>" + DECL_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(TRADE_CO))
    //            xml += "<Key><name>TRADE_CO</name><value>" + TRADE_CO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(TRADE_NAME))
    //            xml += "<Key><name>TRADE_NAME</name><value>" + TRADE_NAME + "</value></Key>";
    //        if (!string.IsNullOrEmpty(DECL_CODE))
    //            xml += "<Key><name>DECL_CODE</name><value>" + DECL_CODE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(DECL_NAME))
    //            xml += "<Key><name>DECL_NAME</name><value>" + DECL_NAME + "</value></Key>";
    //        if (!string.IsNullOrEmpty(I_E_FLAG))
    //            xml += "<Key><name>I_E_FLAG</name><value>" + I_E_FLAG + "</value></Key>";
    //        if (!string.IsNullOrEmpty(ENTRY_ID))
    //            xml += "<Key><name>ENTRY_ID</name><value>" + ENTRY_ID + "</value></Key>";
    //        xml += "</Criteria>";
    //        xml += "</GCCQuery>";
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }
    //    #endregion
    //    #region 现场放行
    //    /// <summary>
    //    /// 现场放行
    //    /// </summary>
    //    /// <param name="BILL_NO">提单号</param>
    //    /// <param name="I_E_FLAG">进出口标识:I 进口,E 出口</param>
    //    /// <param name="PASS_BEG_DATE">放行开始日期:YYYYMMDD格式，例如20160219</param>
    //    /// <param name="PASS_END_DATE">放行结束日期:YYYYMMDD格式，例如20160219</param>
    //    /// <param name="ENTRY_ID">报关单号:后九位数字</param>
    //    /// <returns>
    //    /// ENTRY_ID	报关单号	
    //    /// OWN_CODE	货主单位	
    //    /// TRADE_CO	经营单位代码	
    //    /// TRADE_NAME	经营单位名称	
    //    /// PACKAGE	件数	
    //    /// GROSSWET	毛重	
    //    /// TRANS_MODE	运输方式	
    //    /// TRANS_CODE	运输工具	
    //    /// BILL_NO	提单号	
    //    /// I_E_FLAG	进出口标识	I 进口,E 出口
    //    /// PASS_TIME	放行日期	
    //    /// </returns>
    //    public static string CUSWEB_REL_PASS(string BILL_NO, string I_E_FLAG, string PASS_BEG_DATE, string PASS_END_DATE, string ENTRY_ID)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    //        xml += "<GCCQuery xmlns=\"biz.easipass.com\">";
    //        xml += "<Info>";
    //        xml += "<QueryType>CUSWEB_REL_PASS</QueryType>";
    //        xml += "<Authenticator><user>a</user><password>a</password><sign>0123456789</sign></Authenticator>";
    //        xml += "</Info>";
    //        xml += "<Criteria>";
    //        if (!string.IsNullOrEmpty(BILL_NO))
    //            xml += "<Key><name>BILL_NO</name><value>" + BILL_NO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(I_E_FLAG))
    //            xml += "<Key><name>I_E_FLAG</name><value>" + I_E_FLAG + "</value></Key>";
    //        if (!string.IsNullOrEmpty(PASS_BEG_DATE))
    //            xml += "<Key><name>PASS_BEG_DATE</name><value>" + PASS_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(PASS_END_DATE))
    //            xml += "<Key><name>PASS_END_DATE</name><value>" + PASS_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(ENTRY_ID))
    //            xml += "<Key><name>ENTRY_ID</name><value>" + ENTRY_ID + "</value></Key>";
    //        xml += "</Criteria>";
    //        xml += "</GCCQuery>";
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }
    //    #endregion
    //    #region 预配舱单查询
    //    /// <summary>
    //    /// 预配舱单查询
    //    /// </summary>
    //    /// <param name="BILL_NO">提单号</param>
    //    /// <param name="SENDER_BEG_DATE">舱单生成开始日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="SENDER_END_DATE">舱单生成结束日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="I_E_BEG_DATE">进出港开始日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="I_E_END_DATE">进出港结束日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="I_E_FLAG">进出口标识	I 进口,E 出口</param>
    //    /// <param name="VOYAGE_NO">航次</param>
    //    /// <param name="SHIP_NAME_EN">船名</param>
    //    /// <returns>
    //    /// SENDER_DATE	舱单生成日期	
    //    /// SENDER_CODE	船代	
    //    /// I_E_FLAG	进出口标识	I 进口,E 出口
    //    /// SHIP_NAME_CN	中文船名	
    //    /// SHIP_NAME_EN	英文船名	
    //    /// VOYAGE_NO	航次	
    //    /// CUSTOM_ID	关别代码	
    //    /// I_E_DATE	进出港日期	
    //    /// MAIN_G_NAME	商品名称	
    //    /// PACK_NUM	件数	
    //    /// GROSS_WT	毛重	
    //    /// CTN_NUM	本提单集装箱数	
    //    /// BILL_NO	提单号	
    //    /// UNLOAD_PLACE	卸货地	
    //    /// VOLUME	体积	
    //    /// OWNER_NAME	货主名称	
    //    /// WRAP_TYPE	包装种类	
    //    /// </returns>
    //    public static string ODISRC_CNCP01(string BILL_NO, string SENDER_BEG_DATE, string SENDER_END_DATE, string I_E_BEG_DATE, string I_E_END_DATE, string I_E_FLAG, string VOYAGE_NO, string SHIP_NAME_EN)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    //        xml += "<GCCQuery xmlns=\"biz.easipass.com\">";
    //        xml += "<Info>";
    //        xml += "<QueryType>ODISRC_CNCP01</QueryType>";
    //        xml += "<Authenticator><user>a</user><password>a</password><sign>0123456789</sign></Authenticator>";
    //        xml += "</Info>";
    //        xml += "<Criteria>";
    //        if (!string.IsNullOrEmpty(BILL_NO))
    //            xml += "<Key><name>BILL_NO</name><value>" + BILL_NO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(SENDER_BEG_DATE))
    //            xml += "<Key><name>SENDER_BEG_DATE</name><value>" + SENDER_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(SENDER_END_DATE))
    //            xml += "<Key><name>SENDER_END_DATE</name><value>" + SENDER_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(I_E_BEG_DATE))
    //            xml += "<Key><name>I_E_BEG_DATE</name><value>" + I_E_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(I_E_END_DATE))
    //            xml += "<Key><name>I_E_END_DATE</name><value>" + I_E_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(I_E_FLAG))
    //            xml += "<Key><name>I_E_FLAG</name><value>" + I_E_FLAG + "</value></Key>";
    //        if (!string.IsNullOrEmpty(VOYAGE_NO))
    //            xml += "<Key><name>VOYAGE_NO</name><value>" + VOYAGE_NO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(SHIP_NAME_EN))
    //            xml += "<Key><name>SHIP_NAME_EN</name><value>" + SHIP_NAME_EN + "</value></Key>";
    //        xml += "</Criteria>";
    //        xml += "</GCCQuery>";
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }
    //    #endregion
    //    #region 海关H2000查询
    //    /// <summary>
    //    /// 海关H2000查询
    //    /// </summary>
    //    /// <param name="D_BEG_DATE">申报开始日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="D_END_DATE">申报结束日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="E_BEG_DATE">结关开始日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="E_END_DATE">结关结束日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="IO_FLAG">进出口标识	I 进口,E 出口</param>
    //    /// <param name="BILL_NO">提单号</param>
    //    /// <param name="ENTRY_ID">报关单号</param>
    //    /// <returns>
    //    /// ENTRY_ID  报关单号
    //    /// BILL_NO  提单号
    //    /// TRADE_CODE  经营单位代码
    //    /// TRADE_NAME  经营单位名称
    //    /// OWNER_CODE  货主单位代码
    //    /// OWNER_NAME  货主单位名称
    //    /// AGENT_CODE  申报单位代码 
    //    /// AGENT_NAME  申报单位名称
    //    /// PACK_NO  件数
    //    /// GROSS_WT  毛重
    //    /// SHIP_ID  船名
    //    /// VOYAGE_NO  航次
    //    /// D_DATE  申报日期
    //    /// IO_FLAG  进出口标识（I 进口,E 出口）
    //    /// I_E_PORT 进出口岸
    //    /// F_MATTER  结关状态
    //    ///E_DATE  结关日期
    //    /// </returns>
    //    public static string CUSWEB_H2000RTAX(string D_BEG_DATE, string D_END_DATE, string E_BEG_DATE, string E_END_DATE, string IO_FLAG, string BILL_NO, string ENTRY_ID)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    //        xml += "<GCCQuery xmlns=\"biz.easipass.com\">";
    //        xml += "<Info>";
    //        xml += "<QueryType>CUSWEB_H2000RTAX</QueryType>";
    //        xml += "<Authenticator><user>a</user><password>a</password><sign>0123456789</sign></Authenticator>";
    //        xml += "</Info>";
    //        xml += "<Criteria>";
    //        if (!string.IsNullOrEmpty(D_BEG_DATE))
    //            xml += "<Key><name>D_BEG_DATE</name><value>" + D_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(D_END_DATE))
    //            xml += "<Key><name>D_END_DATE</name><value>" + D_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(E_BEG_DATE))
    //            xml += "<Key><name>E_BEG_DATE</name><value>" + E_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(E_END_DATE))
    //            xml += "<Key><name>E_END_DATE</name><value>" + E_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(IO_FLAG))
    //            xml += "<Key><name>IO_FLAG</name><value>" + IO_FLAG + "</value></Key>";
    //        if (!string.IsNullOrEmpty(BILL_NO))
    //            xml += "<Key><name>BILL_NO</name><value>" + BILL_NO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(ENTRY_ID))
    //            xml += "<Key><name>ENTRY_ID</name><value>" + ENTRY_ID + "</value></Key>";
    //        xml += "</Criteria>";
    //        xml += "</GCCQuery>";
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }
    //    #endregion
    //    #region 海关H883查询
    //    /// <summary>
    //    /// 海关H883查询
    //    /// </summary>
    //    /// <param name="D_BEG_DATE">申报开始日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="D_END_DATE">申报结束日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="E_BEG_DATE">结关开始日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="E_END_DATE">结关结束日期	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="IO_FLAG">进出口标识	I 进口,E 出口</param>
    //    /// <param name="BILL_NO">提单号</param>
    //    /// <param name="ENTRY_ID">报关单号</param>
    //    /// <returns>
    //    /// ENTRY_ID  报关单号
    //    /// BILL_NO  提单号
    //    /// TRADE_CODE  经营单位代码
    //    /// TRADE_NAME  经营单位名称
    //    /// OWNER_CODE  货主单位代码
    //    /// OWNER_NAME  货主单位名称
    //    /// AGENT_CODE  申报单位代码 
    //    /// AGENT_NAME  申报单位名称
    //    /// PACK_NO  件数
    //    /// GROSS_WT  毛重
    //    /// SHIP_ID  船名
    //    /// VOYAGE_NO  航次
    //    /// D_DATE  申报日期
    //    /// IO_FLAG  进出口标识（I 进口,E 出口）
    //    /// I_E_PORT 进出口岸
    //    /// F_MATTER  结关状态
    //    ///E_DATE  结关日期
    //    /// </returns>
    //    public static string CUSWEB_POSTRTAX(string D_BEG_DATE, string D_END_DATE, string E_BEG_DATE, string E_END_DATE, string IO_FLAG, string BILL_NO, string ENTRY_ID)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    //        xml += "<GCCQuery xmlns=\"biz.easipass.com\">";
    //        xml += "<Info>";
    //        xml += "<QueryType>CUSWEB_POSTRTAX</QueryType>";
    //        xml += "<Authenticator><user>a</user><password>a</password><sign>0123456789</sign></Authenticator>";
    //        xml += "</Info>";
    //        xml += "<Criteria>";
    //        if (!string.IsNullOrEmpty(D_BEG_DATE))
    //            xml += "<Key><name>D_BEG_DATE</name><value>" + D_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(D_END_DATE))
    //            xml += "<Key><name>D_END_DATE</name><value>" + D_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(E_BEG_DATE))
    //            xml += "<Key><name>E_BEG_DATE</name><value>" + E_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(E_END_DATE))
    //            xml += "<Key><name>E_END_DATE</name><value>" + E_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(IO_FLAG))
    //            xml += "<Key><name>IO_FLAG</name><value>" + IO_FLAG + "</value></Key>";
    //        if (!string.IsNullOrEmpty(BILL_NO))
    //            xml += "<Key><name>BILL_NO</name><value>" + BILL_NO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(ENTRY_ID))
    //            xml += "<Key><name>ENTRY_ID</name><value>" + ENTRY_ID + "</value></Key>";
    //        xml += "</Criteria>";
    //        xml += "</GCCQuery>";
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }
    //    #endregion

    //    #region 电子装箱单查询
    //    /// <summary>
    //    /// 电子装箱单查询
    //    /// </summary>
    //    /// <param name="BL_NO">提单号</param>
    //    /// <param name="CTN_NO">箱号</param>
    //    /// <returns>
    //    /// VESSEL  船名
    //    /// VOYAGE  航次
    //    /// PORT_IN_TIME   进港时间
    //    /// PORT_IN_LOCATION  进港地点
    //    /// BL_NO  提单号
    //    ///CTN_NO  箱号
    //    /// SEAL_NO  封号
    //    /// CTN_SIZE_TYPE  规格
    //    /// TOTAL_PACKAGES  分件数
    //    /// TOTAL_WEIGHT  分毛重
    //    /// TOTAL_OF_MEASUREMENT  分体积
    //    /// CTN_OPERATOR_CODE  箱经营人
    //    ///CTN_OPERATOR  箱经营人
    //    /// DISCHARGE_PORT_CODE  卸港代码
    //    /// DISCHARGE_PORT  卸港地
    //    /// RECV_FLAG  海关回执
    //    /// RSPTIME  海关接收时间
    //    /// </returns>
    //    public static string ODISRC_COSTRP(string BL_NO, string CTN_NO)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    //        xml += "<GCCQuery xmlns=\"biz.easipass.com\">";
    //        xml += "<Info>";
    //        xml += "<QueryType>ODISRC_COSTRP</QueryType>";
    //        xml += "<Authenticator><user>a</user><password>a</password><sign>0123456789</sign></Authenticator>";
    //        xml += "</Info>";
    //        xml += "<Criteria>";
    //        if (!string.IsNullOrEmpty(BL_NO))
    //            xml += "<Key><name>BL_NO</name><value>" + BL_NO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(CTN_NO))
    //            xml += "<Key><name>CTN_NO</name><value>" + CTN_NO + "</value></Key>";
    //        xml += "</Criteria>";
    //        xml += "</GCCQuery>";
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }

    //    #endregion
    //    #region 手册查询
    //    /// <summary>
    //    /// 手册查询
    //    /// </summary>
    //    /// <param name="MANUAL_NO">手册号</param>
    //    /// <param name="E_BEG_DATE">进出口有效期开始	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="E_END_DATE">进出口有效期结束	YYYYMMDD格式，例如20160219</param>
    //    /// <param name="OWNER_CODE">货主单位代码</param>
    //    /// <param name="TRADE_CO">进经营单位代码</param>
    //    /// <returns>
    //    /// MANUAL_NO	手册号	
    //    /// TRADE_NAME	经营单位	
    //    /// OWNER_NAME	货主单位
    //    /// OWNER_CODE	货主单位代码	
    //    /// TRADE_CO	经营单位代码	
    //    /// I_DATE	首次进出口日期	
    //    /// E_DATE	进出口有效期	
    //    /// LIMIT_DATE	变更日期	
    //    /// CLEAR_DATE	核销日期	
    //    /// CLOSE_DATE	结案日期	
    //    /// </returns>
    //    public static string CUSWEB_MNL_HD_H2K(string MANUAL_NO, string E_BEG_DATE, string E_END_DATE, string OWNER_CODE, string TRADE_CO)
    //    {
    //        UNILOG.LIP.Web.QueryDataService.GCCDataPortClient server = new UNILOG.LIP.Web.QueryDataService.GCCDataPortClient();
    //        string user = ConfigurationManager.AppSettings["user"].ToString();
    //        string password = ConfigurationManager.AppSettings["password"].ToString();
    //        string sign = ConfigurationManager.AppSettings["sign"].ToString();
    //        string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    //        xml += "<GCCQuery xmlns=\"biz.easipass.com\">";
    //        xml += "<Info>";
    //        xml += "<QueryType>CUSWEB_MNL_HD_H2K</QueryType>";
    //        xml += "<Authenticator><user>a</user><password>a</password><sign>0123456789</sign></Authenticator>";
    //        xml += "</Info>";
    //        xml += "<Criteria>";
    //        if (!string.IsNullOrEmpty(MANUAL_NO))
    //            xml += "<Key><name>MANUAL_NO</name><value>" + MANUAL_NO + "</value></Key>";
    //        if (!string.IsNullOrEmpty(E_BEG_DATE))
    //            xml += "<Key><name>E_BEG_DATE</name><value>" + E_BEG_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(E_END_DATE))
    //            xml += "<Key><name>E_END_DATE</name><value>" + E_END_DATE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(OWNER_CODE))
    //            xml += "<Key><name>OWNER_CODE</name><value>" + OWNER_CODE + "</value></Key>";
    //        if (!string.IsNullOrEmpty(TRADE_CO))
    //            xml += "<Key><name>TRADE_CO</name><value>" + TRADE_CO + "</value></Key>";
    //        xml += "</Criteria>";
    //        xml += "</GCCQuery>";
    //        string str = server.queryData(user, password, sign, xml);
    //        return str;
    //    }
    //    #endregion


    //    #region 电子装箱单信息 最新版2016-10-13
    //    public static string GetCstVslInfoSearch(string blno, string ctnno)
    //    {

    //        testorm.ServiceFreight.ServiceClient server = new testorm.ServiceFreight.ServiceClient();
    //        byte[] res = server.getCstVslInfo(blno, ctnno);
    //        byte[] writeData = new byte[res.Length * 3];
    //        MemoryStream inStream = new MemoryStream(res);
    //        Stream zipStream = new GZipInputStream(inStream) as Stream;
    //        MemoryStream outStream = new MemoryStream();
    //        try
    //        {
    //            while (true)
    //            {
    //                int size = zipStream.Read(writeData, 0, writeData.Length);
    //                if (size > 0)
    //                {
    //                    outStream.Write(writeData, 0, size);
    //                }
    //                else
    //                {
    //                    break;
    //                }
    //            }
    //            inStream.Close();
    //            zipStream.Close();
    //            byte[] outData = outStream.ToArray();
    //            outStream.Close();
    //            return System.Text.Encoding.UTF8.GetString(outData);
    //        }
    //        catch (Exception ex)
    //        {
    //            inStream.Close();
    //            zipStream.Close();
    //            outStream.Close();
    //        }
    //        return "";
    //    }
    //    #endregion
    }
}