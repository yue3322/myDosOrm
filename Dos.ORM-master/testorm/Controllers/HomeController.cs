using Dos.Model;
using Dos.ORM;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Windows.Browser;
using testorm.Models;
using testorm.WCF;
using UNILOG.LIP.Business;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace testorm.Controllers
{
    public class servertest
    {
        public string say()
        {
            return System.AppDomain.CurrentDomain.BaseDirectory;

        }
    }
    public class CstVslInfoSearchJson
    {
        public CstVslInfoSearchJson()
        {
            detail = new List<CtnResult>();
        }
        public List<CtnResult> detail { get; set; }
        /// <summary>
        /// 船名
        /// </summary>
        public string vslname { get; set; }
        /// <summary>
        /// 航次
        /// </summary>
        public string voyage { get; set; }
        /// <summary>
        /// 总件数
        /// </summary>
        public string total_package { get; set; }
        /// <summary>
        /// 总体重
        /// </summary>
        public string total_weight { get; set; }
        /// <summary>
        /// 箱型
        /// </summary>
        public string ctntype { get; set; }
        /// <summary>
        /// COSTCO报文发送时间
        /// </summary>
        public string csotcoDt { get; set; }
        /// <summary>
        /// COSTCO报文号
        /// </summary>
        public string csotco { get; set; }
        /// <summary>
        ///进港时间
        /// </summary>
        public string in_date { get; set; }
        /// <summary>
        ///  进港地点
        /// </summary>
        public string in_addr { get; set; }




    }

    public class CtnResult
    {
        /// <summary>
        /// 海关回执
        /// </summary>
        public string cus_status { get; set; }
        /// <summary>
        /// COSTRP号
        /// </summary>
        public string csotrp { get; set; }
        /// <summary>
        /// 卸港代码
        /// </summary>
        public string unloadport { get; set; }
        /// <summary>
        /// 箱经营人
        /// </summary>
        public string ctn_opr_code { get; set; }
        /// <summary>
        /// 海关接收回执时间
        /// </summary>
        public string cus_time { get; set; }
        /// <summary>
        /// 提单号
        /// </summary>
        public string blno { get; set; }
        /// <summary>
        /// 体重
        /// </summary>
        public string weight { get; set; }
        /// <summary>
        /// 件数
        /// </summary>
        public string package { get; set; }
        /// <summary>
        /// 箱号
        /// </summary>
        public string ctnno { get; set; }
        /// <summary>
        /// 船名
        /// </summary>
        public string vslname { get; set; }
        /// <summary>
        /// 航次
        /// </summary>
        public string voyage { get; set; }
    }
    public class QeuryStringJson
    {
        public GCCResult GCCResult { get; set; }
    }

    public class GCCResult
    {
        public GCCResult()
        {
            this.Page = new Page();
            this.sets = new List<Sets>();
        }
        public string @code { get; set; }
        public string @desc { get; set; }
        public Page Page { get; set; }
        public List<Sets> sets { get; set; }
    }
    public class Page
    {
        public string targetPage { get; set; }
        public string pageSize { get; set; }
        public string totalCount { get; set; }
    }
    public class Sets
    {
        public Sets()
        {
            this.fields = new List<Fields>();
        }
        public List<Fields> fields { get; set; }
    }
    public class Fields
    {
        public string name { get; set; }
        public string value { get; set; }
        public string tag { get; set; }
    }

    public class HomeController : Controller
    {
        private testorm.CustomerServiceWcf.CustomerServiceWcfServiceClient CustomerService = new testorm.CustomerServiceWcf.CustomerServiceWcfServiceClient();
        public class DB
        {
            public DB()
            {
                this.updater = "222";
            }
            public static readonly DbSession OracleDB = new DbSession("OracleConn");
            public static readonly DbSession MysqlDB = new DbSession("MysqlConn");
            public static readonly DbSession SqlServerDB = new DbSession("OracleConn");
            public static readonly DbSession AccessDB = new DbSession("AccessConn");
            public static readonly DbSession OracleNDB = new DbSession("OracleNConn");
            public static readonly DbSession ServiceAccessDB = new DbSession("ServiceAccessConn");
            public static readonly DbSession MysqlHomeDB = new DbSession("MysqlHomeConn"); 

            //public static readonly DbSession cusdeclOracleDB = new DbSession("cusdeclOracleConn");
            protected string updater { get; set; }
        }
        #region pre
        ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private string sql;
        void database_OnLog(string logMsg)
        {
            //保存执行的DbCommand (sql语句和参数)
            //sql += "<br />" + logMsg;
            log.Info("测试dosorm日志：" + logMsg);

        }
        public List<T> entitys<T>(OleDbCommand commandx) where T : class, new()
        {

            var dbupdater = new DB();
            var ser = Server.MapPath("");
            OleDbDataReader thisReader = commandx.ExecuteReader();
            // adapterx.SelectCommand = commandx;
            var listthis = new List<T>();
            while (thisReader.Read())
            {
                var head = new T();
                var type = head.GetType();
                for (int i = 0; i < thisReader.FieldCount; i++)
                {

                    foreach (PropertyInfo itemInfo in type.GetProperties())
                    {
                        Type ftype = itemInfo.PropertyType;
                        if (itemInfo.Name == thisReader.GetName(i))
                        {

                            //判断type类型是否为泛型，因为nullable是泛型类,  
                            if (ftype.IsGenericType && ftype.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))//判断convertsionType是否为nullable泛型类  
                            {
                                //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换  
                                System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(ftype);
                                //将type转换为nullable对的基础基元类型  
                                ftype = nullableConverter.UnderlyingType;
                            }
                            if (string.IsNullOrEmpty(thisReader[i].ToString()))
                            {
                                itemInfo.SetValue(head, null, null);
                            }
                            else
                            {
                                itemInfo.SetValue(head, Convert.ChangeType(thisReader[i], ftype), null);
                            }
                        }
                    }

                }
                listthis.Add(head);
            }
            return listthis;
        }
        public List<T> entitys<T>(OracleCommand commandx) where T : class, new()
        {
            OracleDataReader thisReader = commandx.ExecuteReader();
            // adapterx.SelectCommand = commandx;
            var listthis = new List<T>();
            while (thisReader.Read())
            {
                var head = new T();
                var type = head.GetType();
                for (int i = 0; i < thisReader.FieldCount; i++)
                {

                    foreach (PropertyInfo itemInfo in type.GetProperties())
                    {
                        Type ftype = itemInfo.PropertyType;
                        if (itemInfo.Name == thisReader.GetName(i))
                        {

                            //判断type类型是否为泛型，因为nullable是泛型类,  
                            if (ftype.IsGenericType && ftype.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))//判断convertsionType是否为nullable泛型类  
                            {
                                //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换  
                                System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(ftype);
                                //将type转换为nullable对的基础基元类型  
                                ftype = nullableConverter.UnderlyingType;
                            }
                            if (string.IsNullOrEmpty(thisReader[i].ToString()))
                            {
                                itemInfo.SetValue(head, null, null);
                            }
                            else
                            {
                                itemInfo.SetValue(head, Convert.ChangeType(thisReader[i], ftype), null);
                            }
                        }
                    }

                }
                listthis.Add(head);
            }
            return listthis;
        }
        public void oracletest()
        {
            OracleConnection connection = new OracleConnection(@"data source=41;persist security info=True;user id=ulip3;password=uuuuuuuu");
            connection.Open();
            OracleCommand commandx = new OracleCommand();

            commandx.Connection = connection;
            commandx.CommandText = "select * from dc_ep_dec_head where updater = 'SYS' and rownum < 100";
            // var retn = commandx.ExecuteNonQuery();
            //OleDbDataAdapter adapterx = new OleDbDataAdapter();
            OracleDataReader thisReader = commandx.ExecuteReader();
            // adapterx.SelectCommand = commandx;
            var listthis = new List<HeadListModel>();
            while (thisReader.Read())
            {
                var model = new HeadListModel();
                var head = new DC_EP_DEC_HEAD_O();

                model.head = head;
                var type = head.GetType();
                for (int i = 0; i < thisReader.FieldCount; i++)
                {

                    foreach (PropertyInfo itemInfo in type.GetProperties())
                    {
                        Type ftype = itemInfo.PropertyType;
                        var name = thisReader.GetName(i);
                        if (itemInfo.Name == thisReader.GetName(i))
                        {
                            if (thisReader.GetName(i) == "DEH_ID")
                            {
                                OracleCommand command = new OracleCommand();
                                command.Connection = connection;
                                command.CommandText = "select * from DC_EP_DEC_DTL where ded_deh_id ='" + thisReader[i] + "'";
                                model.dtls = entitys<DC_EP_DEC_DTL>(command);
                            }
                            //判断type类型是否为泛型，因为nullable是泛型类,  
                            if (ftype.IsGenericType && ftype.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))//判断convertsionType是否为nullable泛型类  
                            {
                                //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换  
                                System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(ftype);
                                //将type转换为nullable对的基础基元类型  
                                ftype = nullableConverter.UnderlyingType;
                            }
                            if (string.IsNullOrEmpty(thisReader[i].ToString()))
                            {
                                itemInfo.SetValue(head, null, null);
                            }
                            else
                            {
                                itemInfo.SetValue(head, Convert.ChangeType(thisReader[i], ftype), null);
                            }
                        }
                    }

                }

                listthis.Add(model);

            }
            int n = 0;
        }
        public void customerx(object arg)
        {
            var str = arg as List<string>;
            var str1 = "111" + str[0] + str[1];
            Console.Write("111" + str[0] + str[1]);
        }
        public void customerx2(object arg)
        {
            var str = arg as List<string>;
            var str1 = "111" + str[0] + str[1];
            Console.Write("111" + str[0] + str[1]);
            var stats4 = Thread.CurrentThread;
        }
        //static async void DisplayDataAsync()
        // {
        //     Console.WriteLine("start");

        //     var data = await GetData();

        //     Console.WriteLine(data);
        //    Console.WriteLine("end");
        //} 
        //public async void testasync()
        //{
        //    string stri = "";
        //    for (int i = 0; i < 100000; i++)
        //    {
        //        stri += i;
        //    }
        //    //int j = 0;
        //}
        #endregion
        public ActionResult Index()
        {
            //testasync();
            int eddd = 0;

<<<<<<< HEAD
            //DB.OracleDB.RegisterSqlLogger(database_OnLog);
            var exCredential = new List<string>() { "3", "4", "5", "8", "B", "" };
            //var Credential = CachePool.GetValue("DcBasSuperviseCredential" + Csla.ApplicationContext.User.Identity.Name) as DcBasSuperviseCredentialList;
            //var cusdecl1111 = DB.OracleDB.From<DC_EP_DEC_HEAD_O>().Where(x => x.DEH_ENTRY_NO == "222920170001934177").ToList();
=======
            DB.OracleDB.RegisterSqlLogger(database_OnLog);
            DB.MysqlDB.RegisterSqlLogger(database_OnLog);
            var exCredential = new List<string>() { "3", "4", "5", "8", "B", "" };
            //var Credential = CachePool.GetValue("DcBasSuperviseCredential" + Csla.ApplicationContext.User.Identity.Name) as DcBasSuperviseCredentialList;
            var cusdecl1111 = DB.OracleDB.From<DC_EP_DEC_HEAD_O>().Where(x => x.DEH_ENTRY_NO == "22292017000193417711").First();

            var head11D = DcEpDecHeadList.Fetch(new DcEpDecHeadCriteria { DehId = 191936825972021 });
>>>>>>> c1722096a0d0083b0dcd1b914983e83c76c848c1

            //var Credential = DcBasSuperviseCredentialList.Fetch(new DcBasSuperviseCredentialCriteria { });
            //CachePool.SetValue("DcBasSuperviseCredential" + Csla.ApplicationContext.User.Identity.Name, Credential, 36000);
            //var CredentialNm = Credential.Where(x => x.DscCd == "AB").FirstOrDefault();
            var cache = new System.Web.Caching.Cache();
            HttpRuntime.Cache.Insert("test", "runtimessss");
            //cache.Add("test", "aaaa");
            return View();
            foreach (string name in Request.Cookies)
            {

                var info = string.Format("{0} = {1} \r\n ", name, Request.Cookies[name].Value);

            }
            var cusdecl = DB.OracleDB.From<DC_EP_DEC_HEAD_O>().Where(x => x.DEH_ENTRY_NO == "222920170001934177").ToList();
            //var testmssstop = DB.MysqlDB.From<top200>().Where(x => x.deh_dpa_id.IsNotNull()).Top(10).ToList();
            var batch = DB.MysqlDB.From<dc_ep_dec_head_M>().Where(x => Convert.ToDateTime(x.inputer) >= Convert.ToDateTime("2017-08-01")).ToDataTable();
            //foreach(var item in testmssstop)
            //{
            //    item.deh_import_status = 1;
            //    item.Attach();
            //}
            //testmssstop[0].Attach();
            /* var retBatch = DB.MysqlDB.Update(testmssstop)*/
            int i = 0;
            goto cc;
            i = 9;
        cc: i = 7;
            var eff = i;
            var e = new servertest().say();
            var arrList = new ArrayList();
            arrList.Add(new test());
            arrList.Add(111);
            //var arrListAdd = arrList[1] + 1;
            var arrListType = arrList[1].GetType();
            var testmsss = DB.MysqlDB.From<dc_ep_dec_head_M>().Where(x => x.deh_bill_no == "CKA0100030").ToDataTable();
            var dataSetList = testmsss.AsEnumerable().Where(x => Convert.ToInt64(x["deh_id"]) == 122563818364305);
            // var set = dataSetList[0]["deh_id"];
            //while (testmsss.Read())
            //{
            //    var dehid = testmsss["deh_id"];
            //}
            var newthStart = new ParameterizedThreadStart(customerx);
            newthStart += customerx2;
            Thread newth = new Thread(newthStart);
            newth.Name = "t1";
            Thread newth2 = new Thread(customerx2);
            newth2.Start(new List<string>() { "sss", "111" });
            newth2.Name = "t2";
            var stat1 = newth.ThreadState;
            //Thread.Sleep(TimeSpan.FromSeconds(1));
            //newth.Abort();
            var stat2 = newth.ThreadState;
            var stats3 = Thread.CurrentThread;
            stats3.Name = "main";
            //stats3.Abort();
            var culture = newth.CurrentCulture.Name;
            newth.Start(new List<string>() { "aaa", "bbb" });
            var stat3 = newth.ThreadState;
            Thread th = Thread.CurrentThread;
            var thname = th.Name;
            var testfl = new test();
            var stats4 = Thread.CurrentThread;
            // var task = Task.Factory.StartNew(customerx);
            testfl.name = "111";
            //var name = testfl.name;
            var fltype = testfl.GetType();
            foreach (var item in fltype.GetProperties())
            {
                if (item.PropertyType.Name == "String" && item.GetValue(testfl, null) == null)
                {

                }
            }
            string strlong = null;

            DateTime? time1 = null;
            string timerstr = "1";

            var timerstrdate = DBNull.Value;
            DateTime? time2 = DateTime.Now;
            if ((time1 ?? DateTime.MinValue) < time2)
            {
                //string s = "S";
                //var type = (testmsss.Rows[0]["deh_id"]).GetType();
                //var typeint = typeof(int);
                //var typehead = typeof(dc_ep_dec_head_M);
            }
            // var  longa = 10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000;
            int? ae = null;
            var intstr = ae.ToString();
            var date = "" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            date = string.Format("{0:G}", DateTime.Now);
            log.Info("info");
            log.Error("error");
            log.Fatal("Fatal");
            log.Debug("debug");
            log.Warn("warn");
            var testm = DB.MysqlDB.From<DC_EP_DEC_HEAD_O>().Where(x => x.DEH_ENTRY_ID == "222920170001934177").ToFirst();
            var testmu = DB.MysqlDB.From<dc_ep_dec_head_M>().Where(x => x.deh_bill_no == "CKA0100030").ToFirst();
            var dehdb = DB.OracleNDB.FromSql("select deh_entry_no,deh_bill_no,deh_id,deh_edi_no from dc_ep_dec_head where sys_customer_cd ='1000007000000' and input_tm > (sysdate-61)").ToList<head_id>();
            var select = DB.OracleNDB.FromSql("select * from dc_ep_dec_head where input_tm > to_date('2016-12-30','yyyy-MM-dd')").ToList<DC_EP_DEC_HEAD_O>();

            var listc = select.Where(x => x.DEH_BILL_NO == "CNOM253529").ToList();
            foreach (var item in select)
            {
                try
                {
                    var mhead = new dc_ep_dec_head_M();

                    byte[] buffer = Guid.NewGuid().ToByteArray();
                    var num = BitConverter.ToInt64(buffer, 0);
                    mhead.deh_id = Convert.ToDecimal(num.ToString().Substring(0, 15));
                    var itemtype = item.GetType();
                    var mheadtype = mhead.GetType();

                    foreach (var iteminfo in itemtype.GetProperties())
                    {

                        foreach (var headinfo in mheadtype.GetProperties())
                        {

                            if (iteminfo.Name == headinfo.Name.ToUpper())
                            {
                                Type ftype = headinfo.PropertyType;
                                //判断type类型是否为泛型，因为nullable是泛型类,  
                                if (ftype.IsGenericType && ftype.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))//判断convertsionType是否为nullable泛型类  
                                {
                                    //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换  
                                    System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(ftype);
                                    //将type转换为nullable对的基础基元类型  
                                    ftype = nullableConverter.UnderlyingType;
                                }
                                var val = Convert.ToString(iteminfo.GetValue(item, null));
                                if (string.IsNullOrEmpty(val))
                                {
                                    headinfo.SetValue(mhead, null, null);
                                }
                                else
                                {
                                    headinfo.SetValue(mhead, Convert.ChangeType(val, ftype), null);
                                }

                            }
                        }
                    }
                    DB.MysqlDB.Insert<dc_ep_dec_head_M>(mhead);
                }
                catch (Exception ex)
                {
                    var str = ex.Message;
                }
            }

            var test1111111 = DB.AccessDB.From<Container_number>().ToList();
            var test222222 = DB.AccessDB.From<Container_number>().Where(x => x.pre_entry_id == "223120170002016815").ToList();
            var test33333 = DB.AccessDB.From<Form_List>().ToList();
            var FormListin = DB.AccessDB.FromSql("select * from form_list where pre_entry_id in (select pre_entry_id from form_head where create_date >'2017-07-03')").ToList<Form_List>();
            var accesslist1111 = DB.AccessDB.From<Form_Head>().Where(Form_Head._.create_date > "2017-07-03").ToList();
            foreach (var item in accesslist1111)
            {
                var testitem = FormListin.Where(x => x.pre_entry_id == item.pre_entry_id).ToList();
            }
            //for (int i = 0; i < 100; i++)
            //{
            //    var test2222223 = DB.AccessDB.From<Container_number>().Where(x => x.pre_entry_id == "223120170002016815").ToList();
            //}
            //int c = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    var test33333s = DB.AccessDB.From<Form_List>().Where(x => x.pre_entry_id == "223120170002016815").ToList();
            //}
            var test44444 = DB.AccessDB.From<Form_List>().ToList();
            oracletest();
            //var headlist = DB.OracleDB.From<DC_EP_DEC_HEAD_O>().Where(x => x.UPDATER == "SYS").ToList();
            //var testlistHeadListModel = new List<HeadListModel>();
            //foreach (var item in headlist)
            //{
            //    var lists = new HeadListModel();
            //    lists.containers = DB.OracleDB.From<DC_EP_DEC_CONTAINER>().Where(x => x.DEC_DEH_ID == item.DEH_ID).ToList();
            //    lists.dtls = DB.OracleDB.From<DC_EP_DEC_DTL>().Where(x => x.DED_DEH_ID == item.DEH_ID).ToList();
            //    testlistHeadListModel.Add(lists);
            //}
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=CA2022F39FAC2501E232;Data Source=D:/access/CustomData2004.accdb;User ID=Admin;");
            connection.Open();
            OleDbCommand commandx = new OleDbCommand();

            commandx.Connection = connection;
            commandx.CommandText = "select * from form_head where create_date > '2017-07-04'";
            // var retn = commandx.ExecuteNonQuery();
            //OleDbDataAdapter adapterx = new OleDbDataAdapter();
            OleDbDataReader thisReader = commandx.ExecuteReader();
            // adapterx.SelectCommand = commandx;
            var listthis = new List<FormListModel>();
            while (thisReader.Read())
            {
                var model = new FormListModel();
                var head = new Form_Head();

                model.head = head;
                var type = head.GetType();
                //for (int i = 0; i < thisReader.FieldCount; i++)
                //{

                foreach (PropertyInfo itemInfo in type.GetProperties())
                {
                    Type ftype = itemInfo.PropertyType;
                    if (itemInfo.Name.ToLower() == thisReader.GetName(i))
                    {
                        if (thisReader.GetName(i) == "pre_entry_id")
                        {
                            OleDbCommand command = new OleDbCommand();
                            command.Connection = connection;
                            command.CommandText = "select * from Container_number where pre_entry_id ='" + thisReader[i] + "'";
                            model.container = entitys<Container_number>(command);
                        }
                        //判断type类型是否为泛型，因为nullable是泛型类,  
                        if (ftype.IsGenericType && ftype.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))//判断convertsionType是否为nullable泛型类  
                        {
                            //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换  
                            System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(ftype);
                            //将type转换为nullable对的基础基元类型  
                            ftype = nullableConverter.UnderlyingType;
                        }
                        if (string.IsNullOrEmpty(thisReader[i].ToString()))
                        {
                            itemInfo.SetValue(head, null, null);
                        }
                        else
                        {
                            itemInfo.SetValue(head, Convert.ChangeType(thisReader[i], ftype), null);
                        }
                    }
                }

                /// }

                listthis.Add(model);

            }
            int n = 0;
            //var set = new DataSet();
            //adapterx.Fill(set);
            //foreach (DataTable dt in set.Tables)
            //{

            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        var test111 = dr["pre_entry_id"].ToString();
            //    }
            //}






















            int b = 0;
            var test = DB.AccessDB.From<Form_List>().Where(x => x.pre_entry_id == "sss").ToList();
            // var accesslist = DB.AccessDB.From<Form_Head>().Where(Form_Head._.create_date > "2017-07-03").Select<FormListModel, Form_List>(d => new { head = d, formList = DB.AccessDB.From<Form_List>().Where(x => x.pre_entry_id == d.pre_entry_id).ToList() },true).ToList().Take(200).ToList();
            var accesslist = DB.AccessDB.From<Form_Head>().Where(Form_Head._.create_date > "2017-07-03").ToList();//.Select(d => new { head = d, formList = DB.AccessDB.From<Form_List>().Where(x => x.pre_entry_id == d.pre_entry_id).ToList() }).ToList().Take(200).ToList();
            foreach (var formHead in accesslist)
            {
                var deh = new dc_ep_dec_head();
                var ret = DB.MysqlDB.Exists<dc_ep_dec_head>(dc_ep_dec_head._.deh_edi_no == formHead.EDI_NO);
                if (!ret)
                {
                    deh.Attach();
                    byte[] buffer = Guid.NewGuid().ToByteArray();
                    var num = BitConverter.ToInt64(buffer, 0);
                    deh.deh_id = Convert.ToDecimal(num.ToString().Substring(0, 15));
                }
                Type itemType = deh.GetType();
                var ModelformHeadType = formHead.GetType();
                foreach (PropertyInfo ModelInfo in itemType.GetProperties())
                {

                    var name = ModelInfo.Name;//.Replace("_", "").ToUpper();
                    if (name == "DEHPAPERLESSTAX" || name == "DEHTRAFNAME" || name == "DEHTRAFMODE" || name == "DEHAGENTNAME" || name == "DEHAGENTCODE" || name == "DEHOWNERNAME" || name == "DEHOWNERCODE" || name == "DEHEDINO" || name == "DEHDDATE" || name == "DEHIEDATE" || name == "DEHCONTRNO")//|| name =="DEHTRADECO" name == "DEHTRADECOSCC" || name == "DEHAGENTCODESCC" || name == "DEHOWNERCODESCC" || 
                    {
                        continue;
                    }

                    foreach (PropertyInfo itemInfo in ModelformHeadType.GetProperties())
                    {
                        Type ftype = ModelInfo.PropertyType;
                        var itemInfoName = "deh_" + itemInfo.Name;
                        if (itemInfoName == name)
                        {
                            //判断type类型是否为泛型，因为nullable是泛型类,  
                            if (ftype.IsGenericType && ftype.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))//判断convertsionType是否为nullable泛型类  
                            {
                                //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换  
                                System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(ftype);
                                //将type转换为nullable对的基础基元类型  
                                ftype = nullableConverter.UnderlyingType;
                            }
                            if (string.IsNullOrEmpty(itemInfo.GetValue(formHead, null).ToString()))
                            {
                                ModelInfo.SetValue(deh, null, null);
                            }
                            else
                            {
                                ModelInfo.SetValue(deh, Convert.ChangeType(itemInfo.GetValue(formHead, null), ftype), null);
                            }
                        }
                    }
                }
                var tool = new Tools();
                var promise = formHead.PROMISE_ITMES;
                if (promise != null && promise.Length == 4)
                {
                    deh.deh_spec_rel_confir = Convert.ToDecimal(promise.Substring(0, 1));
                    deh.deh_pay_of_licen_fees = Convert.ToDecimal(promise.Substring(1, 1));
                    deh.deh_price_confir = Convert.ToDecimal(promise.Substring(2, 1));
                }
                deh.deh_license_no = formHead.lisence_no;
                deh.deh_traf_name = string.IsNullOrEmpty(formHead.traf_name) ? "" : tool.Decrypt(formHead.traf_name);
                deh.deh_traf_mode = string.IsNullOrEmpty(formHead.traf_mode) ? "" : tool.Decrypt(formHead.traf_mode);
                deh.deh_agent_name = string.IsNullOrEmpty(formHead.agent_name) ? "" : tool.Decrypt(formHead.agent_name);
                deh.deh_agent_code = string.IsNullOrEmpty(formHead.agent_code) ? "" : tool.Decrypt(formHead.agent_code);
                deh.deh_contr_no = string.IsNullOrEmpty(formHead.contr_no) ? "" : tool.Decrypt(formHead.contr_no);
                deh.deh_owner_code = string.IsNullOrEmpty(formHead.owner_code) ? "" : tool.Decrypt(formHead.owner_code);
                deh.deh_owner_name = string.IsNullOrEmpty(formHead.owner_name) ? "" : tool.Decrypt(formHead.owner_name);
                if (!string.IsNullOrEmpty(formHead.d_date))
                {
                    deh.deh_d_date = Convert.ToDateTime(formHead.d_date);
                }
                else
                {
                    deh.deh_d_date = null;
                }
                if (!string.IsNullOrEmpty(formHead.i_e_date))
                {
                    deh.deh_i_e_date = Convert.ToDateTime(formHead.d_date);
                }
                else
                {
                    deh.deh_i_e_date = null;
                }
                //deh.DehPaperlessTax = formHead.PaperLessTax.IsNullOrEmpty() ? false : true;
                deh.deh_apply_port = formHead.DECL_PORT;
                deh.deh_ch_no = formHead.customs_id;
                deh.deh_entry_id = formHead.pre_entry_id;
                deh.deh_paperless_tax = 1;
                deh.update_tm = DateTime.Now;
                // deh.DehDecType = deh.DehIeFlag;


                deh.updater = "CS";
                if (ret)
                {
                    //  DB.MysqlDB.Update(deh);
                }
                else
                {
                    deh.inputer = "CS";
                    deh.input_tm = DateTime.Now;
                    //   DB.MysqlDB.Insert(deh);
                }
            }
            int a = 0;
            DB.OracleDB.RegisterSqlLogger(database_OnLog);
            foreach (var formHead in accesslist)
            {
                var deh = new DC_EP_DEC_HEAD_O();

                var ret = DB.OracleDB.Exists<DC_EP_DEC_HEAD_O>(DC_EP_DEC_HEAD_O._.DEH_EDI_NO == formHead.EDI_NO);
                if (!ret)
                {
                    deh.Attach();
                    byte[] buffer = Guid.NewGuid().ToByteArray();
                    var num = BitConverter.ToInt64(buffer, 0);
                    deh.DEH_ID = long.Parse(num.ToString().Substring(0, 15));
                }
                Type itemType = deh.GetType();
                var ModelformHeadType = formHead.GetType();
                foreach (PropertyInfo ModelInfo in itemType.GetProperties())
                {

                    var name = ModelInfo.Name.ToUpper();
                    foreach (PropertyInfo itemInfo in ModelformHeadType.GetProperties())
                    {
                        Type ftype = ModelInfo.PropertyType;
                        var itemInfoName = "DEH_" + itemInfo.Name.ToUpper();
                        if (itemInfoName == name)
                        {
                            //判断type类型是否为泛型，因为nullable是泛型类,  
                            if (ftype.IsGenericType && ftype.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))//判断convertsionType是否为nullable泛型类  
                            {
                                //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换  
                                System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(ftype);
                                //将type转换为nullable对的基础基元类型  
                                ftype = nullableConverter.UnderlyingType;
                            }
                            if (string.IsNullOrEmpty(itemInfo.GetValue(formHead, null).ToString()))
                            {
                                ModelInfo.SetValue(deh, null, null);
                            }
                            else
                            {
                                ModelInfo.SetValue(deh, Convert.ChangeType(itemInfo.GetValue(formHead, null), ftype), null);
                            }
                        }
                    }
                }
                var tool = new Tools();
                var promise = formHead.PROMISE_ITMES;
                if (promise != null && promise.Length == 4)
                {
                    deh.DEH_SPEC_REL_CONFIR = Convert.ToDouble(promise.Substring(0, 1));
                    deh.DEH_PAY_OF_LICEN_FEES = Convert.ToDouble(promise.Substring(1, 1));
                    deh.DEH_PRICE_CONFIR = Convert.ToDouble(promise.Substring(2, 1));
                }
                deh.DEH_LICENSE_NO = formHead.lisence_no;
                deh.DEH_TRAF_NAME = string.IsNullOrEmpty(formHead.traf_name) ? "" : tool.Decrypt(formHead.traf_name);
                deh.DEH_TRAF_MODE = string.IsNullOrEmpty(formHead.traf_mode) ? "" : tool.Decrypt(formHead.traf_mode);
                deh.DEH_AGENT_NAME = string.IsNullOrEmpty(formHead.agent_name) ? "" : tool.Decrypt(formHead.agent_name);
                deh.DEH_AGENT_CODE = string.IsNullOrEmpty(formHead.agent_code) ? "" : tool.Decrypt(formHead.agent_code);
                deh.DEH_CONTR_NO = string.IsNullOrEmpty(formHead.contr_no) ? "" : tool.Decrypt(formHead.contr_no);
                deh.DEH_OWNER_CODE = string.IsNullOrEmpty(formHead.owner_code) ? "" : tool.Decrypt(formHead.owner_code);
                deh.DEH_OWNER_NAME = string.IsNullOrEmpty(formHead.owner_name) ? "" : tool.Decrypt(formHead.owner_name);
                if (!string.IsNullOrEmpty(formHead.d_date))
                {
                    deh.DEH_D_DATE = Convert.ToDateTime(formHead.d_date);
                }
                else
                {
                    deh.DEH_D_DATE = null;
                }
                if (!string.IsNullOrEmpty(formHead.i_e_date))
                {
                    deh.DEH_I_E_DATE = Convert.ToDateTime(formHead.d_date);
                }
                else
                {
                    deh.DEH_I_E_DATE = null;
                }
                //deh.DehPaperlessTax = formHead.PaperLessTax.IsNullOrEmpty() ? false : true;
                deh.DEH_APPLY_PORT = formHead.DECL_PORT;
                deh.DEH_CH_NO = formHead.customs_id;
                deh.DEH_ENTRY_ID = formHead.pre_entry_id;
                deh.DEH_PAPERLESS_TAX = 1;
                deh.UPDATE_TM = DateTime.Now;
                // deh.DehDecType = deh.DehIeFlag;


                deh.UPDATER = "CS";
                if (ret)
                {
                    DB.OracleDB.Update(deh);

                }
                else
                {
                    deh.INPUTER = "CS";
                    deh.INPUT_TM = DateTime.Now;
                    DB.OracleDB.Insert(deh);
                }
            }
            DbSession MysqlDB = new DbSession("MysqlConn");
            var list = MysqlDB.FromSql("select * from customer").ToDataTable();
            DB.MysqlDB.RegisterSqlLogger(database_OnLog);
            using (DbTrans trans = DB.MysqlDB.BeginTransaction())
            {
                trans.Update<customer>(customer._.name, "2222", customer._.id == 8);
                customer cus = trans.From<customer>().ToFirst();
                trans.Commit();
            }
            try
            {

                //var list2 = DB.MysqlDB.From<customer>().ToList();
                //list2[0].input_tm = DateTime.Now;
                //var cuList = new List<customer>();
                //for (int i = 0; i < 1; i++)
                //{
                //    var cu = new customer();
                //    cu.name = "1111";
                //    cu.age = 10;
                //    cu.input_tm = DateTime.Now;
                //    cuList.Add(cu);
                //}
                var testas = DB.MysqlDB.From<customer>().Where(x => x.id == 8 && x.name.In("111", "11111")).ToFirstDefault();
                var dcustomer = DB.MysqlDB.From<customer>().Where(x => x.name == "111").Where(customer._.id == 11110).Select(x => new { name = x.name, age = x.age }).ToFirst<test>();
                if (null == dcustomer)
                {
                    var cu = new customer();
                    cu.name = "1111";
                    cu.id = 10;
                    cu.age = 10;
                    cu.input_tm = DateTime.Now;
                    DB.MysqlDB.Insert(cu);

                }
                else
                {
                    var d = DB.MysqlDB.Delete<customer>(10);
                }

                //var ret = DB.MysqlDB.Insert<customer>(cuList);
                //list2[0].at
                // var updateret = DB.MysqlDB.Update(list2);
            }
            catch (Exception ex)
            {
                var str = ex.Message;
            }
            return View(list);
        }
        public ActionResult FormHead()
        {
            return View();
        }
        public ActionResult GetToolsData(string company, string edino, string chno, string billno, string clientno)
        {
            //var sqlstr = "select * from dc_ep_dec_head where sys_customer_cd ='1000001000000' and Deh_Traf_Name = 'MAULLIN' and Deh_Voyage_no = '043E' and deh_bill_no='NYKSAMDT05318200'";
            //var list = DB.OracleDB.FromSql(sqlstr).ToDataTable();
            //var count = list.Rows.Count;
            if (string.IsNullOrEmpty(edino) && string.IsNullOrEmpty(chno) && string.IsNullOrEmpty(billno) && string.IsNullOrEmpty(clientno))
            {
                return Json(new { Success = false, Message = "请输入edino或提单号或clientno" });
            }
            var str = "";
            if (company == "怡中")
            {
                str = "http://112.65.140.14:8733";
            }
            else if (company == "航联")
            {
                str = "http://219.233.186.218:8733";
            }
            else if (company == "美设")
            {
                str = "http://27.115.41.141:8733";
            }
            else if (company == "亚东")
            {
                str = "http://116.247.101.238:8733/Design_Time_Addresses/CustomerServiceWcf/CustomerServiceWcfService/";
            }
            else if (company == "40")
            {
                str = "http://192.168.17.40:8733";
            }
            else if (company == "锦海捷亚")
            {
                str = "http://101.95.22.182:8733/Design_Time_Addresses/CustomerServiceWcf/CustomerServiceWcfService/";
            }
            else
            {
                return Json(new { Success = false });
            }
            if (!string.IsNullOrEmpty(str))
            {
                CustomerService.Endpoint.Address = new EndpointAddress(str);
            }
            var sql = " 1=1 ";
            if (!edino.IsNullOrEmpty())
            {
                sql += " and edi_no ='" + edino + "'";
            }
            if (!chno.IsNullOrEmpty())
            {
                sql += " and pre_entry_id ='" + chno + "'";
            }
            if (!billno.IsNullOrEmpty())
            {
                sql += " and bill_no ='" + billno + "'";
            }
            if (!clientno.IsNullOrEmpty())
            {
                sql += " and client_no ='" + clientno + "'";
            }
            DataTable dr = new DataTable();
            //var edinoPort = CustomerService.getEdiNo("FTT201710130002"); EDI178000031790337
            try
            {
                var data = CustomerService.getData1("form_head", sql, "ygjirsoqoidmlmj3xzcaupq5");
                var tool = new Tools();
                // IList<Hxj.Model.ServiceAccess.Form_Head> list = new List<Hxj.Model.ServiceAccess.Form_Head>();
                if (!data.IsNullOrEmpty())
                {
                    dr = JsonConvert.DeserializeObject<DataTable>(data);
                    //var head = JsonConvert.DeserializeObject <Service_Form_Head> (data);
                    //var servicelist = Tools.GetEntities<Service_Form_Head>(dr);
                    //DB.ServiceAccessDB.Insert<Service_Form_Head>(servicelist);
                    //var formList = Tools.GetEntities<Form_List>(dr);//JsonConvert.DeserializeObject<Form_List>(data);
                    //DB.ServiceAccessDB.Insert<Form_List>(formList);
                    // var servicelist = Tools.GetEntities<Service_Form_Head>(dr);
                    //foreach (var formHead in list)
                    //{
                    //    formHead.traf_name = formHead.traf_name.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.traf_name);
                    //    formHead.traf_mode = formHead.traf_mode.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.traf_mode);
                    //    formHead.agent_name = formHead.agent_name.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.agent_name);
                    //    formHead.agent_code = formHead.agent_code.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.agent_code);
                    //    formHead.contr_no = formHead.contr_no.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.contr_no);
                    //    formHead.owner_code = formHead.owner_code.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.owner_code);
                    //    formHead.owner_name = formHead.owner_name.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.owner_name);
                    //}
                    foreach (System.Data.DataRow item in dr.Rows)
                    {
                        item["traf_name"] = item["traf_name"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["traf_name"].ToString());
                        item["traf_mode"] = item["traf_mode"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["traf_mode"].ToString());
                        item["agent_name"] = item["agent_name"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["agent_name"].ToString());
                        item["agent_code"] = item["agent_code"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["agent_code"].ToString());
                        item["contr_no"] = item["contr_no"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["contr_no"].ToString());
                        item["owner_code"] = item["owner_code"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["owner_code"].ToString());
                        item["owner_name"] = item["owner_name"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["owner_name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = "ex:" + ex.Message });
            }
            return View(dr);
        }
        public ActionResult GetFormChild(string preEntryId, string company, string table)
        {
            if (preEntryId.IsNullOrEmpty() || company.IsNullOrEmpty() || table.IsNullOrEmpty())
            {
                return Json(new { Success = false, Message = "请输入edino或公司或表名" });
            }
            var str = "";
            if (company == "怡中")
            {
                str = "http://112.65.140.14:8733";
            }
            else if (company == "航联")
            {
                str = "http://219.233.186.218:8733";
            }
            else if (company == "美设")
            {
                str = "http://27.115.41.141:8733";
            }
            else if (company == "亚东")
            {
                str = "http://116.247.101.238:8733";
            }
            else if (company == "40")
            {
                str = "http://192.168.17.40:8733";
            }
            else
            {
                return Json(new { Success = false });
            }
            if (!string.IsNullOrEmpty(str))
            {
                CustomerService.Endpoint.Address = new EndpointAddress(str);
            }
            var sql = "  pre_entry_id ='" + preEntryId + "'";


            DataTable dr = new DataTable();
            //var edinoPort = CustomerService.getEdiNo("FTT201710130002"); EDI178000031790337
            try
            {
                var data = CustomerService.getData1(table, sql, "ygjirsoqoidmlmj3xzcaupq5");
                var tool = new Tools();
                // IList<Hxj.Model.ServiceAccess.Form_Head> list = new List<Hxj.Model.ServiceAccess.Form_Head>();
                if (!data.IsNullOrEmpty())
                {
                    dr = JsonConvert.DeserializeObject<DataTable>(data);
                    //var head = JsonConvert.DeserializeObject <Service_Form_Head> (data);
                    //var servicelist = Tools.GetEntities<Service_Form_Head>(dr);
                    //DB.ServiceAccessDB.Insert<Service_Form_Head>(servicelist);
                    //var formList = Tools.GetEntities<Form_List>(dr);//JsonConvert.DeserializeObject<Form_List>(data);
                    //DB.ServiceAccessDB.Insert<Form_List>(formList);
                    // var servicelist = Tools.GetEntities<Service_Form_Head>(dr);
                    //foreach (var formHead in list)
                    //{
                    //    formHead.traf_name = formHead.traf_name.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.traf_name);
                    //    formHead.traf_mode = formHead.traf_mode.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.traf_mode);
                    //    formHead.agent_name = formHead.agent_name.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.agent_name);
                    //    formHead.agent_code = formHead.agent_code.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.agent_code);
                    //    formHead.contr_no = formHead.contr_no.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.contr_no);
                    //    formHead.owner_code = formHead.owner_code.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.owner_code);
                    //    formHead.owner_name = formHead.owner_name.IsNullOrEmpty() ? "" : tool.Decrypt(formHead.owner_name);
                    //}
                    foreach (System.Data.DataRow item in dr.Rows)
                    {
                        item["code_t"] = item["code_t"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["code_t"].ToString());
                        item["g_name"] = item["g_name"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["g_name"].ToString());
                        item["g_model"] = item["g_model"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["g_model"].ToString());
                        item["code_s"] = item["code_s"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["code_s"].ToString());
                        item["origin_country"] = item["origin_country"].ToStringNoNull().IsNullOrEmpty() ? "" : tool.Decrypt(item["origin_country"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }
            return View("~/Views/Home/GetToolsData.cshtml", dr);

        }
        public ActionResult DelDeh(long id, string customercd)
        {
            if (customercd.IsNullOrEmpty())
            {
                return Json(new { Success = false, Message = "customer必填" });
            }
            UNILOG.MultiUser.Business.Security.UserPrincipal.CreateAuthenticated("", "CSSYS", customercd, "");
            try
            {
                var deh = DcEpDecHeadList.Fetch(new DcEpDecHeadCriteria { DehId = id }).FirstOrDefault();
                // deh.Save();
                if (deh != null)
                {
                    deh.DeleteAllChild = true;
                    deh.Delete();
                    deh.Save();

                    //deh.DcPreAcceptanceMember.Save();
                    if (deh.DcPreAcceptanceMember != null)
                    {
                        deh.DcPreAcceptanceMember.DeleteAllChild = true;
                        deh.DcPreAcceptanceMember.Delete();
                        deh.DcPreAcceptanceMember.Save();
                        if (deh.DcPreAcceptanceMember.UseShipOrderMember != null)
                        {
                            deh.DcPreAcceptanceMember.UseShipOrderMember.DeleteAllChild = true;
                            deh.DcPreAcceptanceMember.UseShipOrderMember.Delete();
                            deh.DcPreAcceptanceMember.UseShipOrderMember.Save();
                        }
                    }
                }
                else
                {
                    return Json(new { Success = false, Message = "查无此数据" });
                }
                return Json(new { Success = true });
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }
        }
        public string GetJson(string TradeCo)
        {
            if (TradeCo.IsNullOrEmpty())
            {
                return "callback(" + JsonConvert.SerializeObject(new CompanyResult { Success = false, Message = "经营单位不能为空" }) + ")";
            }
            var company = DcBasCompanyList.Fetch(new DcBasCompanyCriteria { DbcTradeCo = TradeCo }).FirstOrDefault();
            var result = new CompanyResult();
            var model = new Company();
            result.Success = true;
            result.Message = "获取成功";
            model.TradeCo = company.DbcTradeCo;
            model.FullCo = company.DbcFullCo;
            result.List.Add(model);
            return "callback(" + JsonConvert.SerializeObject(result) + ")";
            //response.setHeader("Access-Control-Allow-Origin", "*");
            // return "callback({\"Success\":true,\"Message\":\"获取成功\",jsonPData:\"" + jsonPData + "\"})";//Json(new { Success = true, Message = "获取成功" }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult DelDehIndex()
        {
            return View();
        }
        public ActionResult GetCustomer()
        {
            return View();
        }
        public ActionResult GetCustomerList()
        {
            var list = DB.MysqlDB.From<customer>().ToList();
            return Json(new { list = list });
        }
        public ActionResult VueJsData(customer cus)
        {
            var testas = DB.MysqlDB.From<customer>().Where(x => x.id == cus.id).ToFirstDefault();
            return Json(testas);
        }
        public ActionResult SaveVueJs(customer cus)
        {
            try
            {
                var testas = DB.MysqlDB.From<customer>().Where(x => x.id == cus.id).ToFirstDefault();
                if (testas != null)
                {
                    testas.tel = cus.tel;
                    testas.name = cus.name;
                    testas.age = cus.age;
                    DB.MysqlDB.Update(testas);
                }
                // var dataMysql = DB.MysqlDB.From<>();
                return Json(new { Success = true, Message = "保存成功" });
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }
        }
        public ActionResult WService()
        {

            // var factory = new ChannelFactory<testorm.WService.IW>(
            //new NetTcpBinding(),
            //"");
            //var _client = factory.CreateChannel();
            var timer = new System.Timers.Timer();
            timer.Interval = 5000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer);
            timer.Start();
            return null;
        }
        public ActionResult NewWService()
        {

            // var factory = new ChannelFactory<testorm.WService.IW>(
            //new NetTcpBinding(),
            //"");
            //var _client = factory.CreateChannel();
            var timer = new System.Timers.Timer();
            timer.Interval = 5000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer);
            timer.Start();
            return null;
        }
        public void Timer(object sender, ElapsedEventArgs e)
        {
            var w = new testorm.WService.WClient();
            for (int i = 0; i < 100; i++)
            {
                var str = w.GetData();
            }
        }
        public ActionResult VueJs()
        {

            return View();
        }
        void MysqlLog(string log)
        {

        }
        public void AutoRegister()
        {
            HttpWebRequest httpWebRequest;
            HttpWebResponse webResponse;
            Stream getStream;
            StreamReader streamReader;
            string getString = "";
            httpWebRequest = (HttpWebRequest)HttpWebRequest.Create("http://www.99myyh.com/core/Cx_Ajax.php");
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Referer = "http://www.99myyh.com/core/Cx_Ajax.php";
            CookieContainer co = new CookieContainer();
            //co.SetCookies(new Uri("http://www.99myyh.com/core/Cx_Ajax.php"), "");
            //httpWebRequest.CookieContainer = co;
            httpWebRequest.UserAgent =
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";
            httpWebRequest.Method = "POST";
            webResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var header = webResponse.Headers.ToString();
            getStream = webResponse.GetResponseStream();
            streamReader = new StreamReader(getStream, Encoding.GetEncoding("utf-8"));
            getString = streamReader.ReadToEnd();
            streamReader.Close();
            getStream.Close();
        }
        public ActionResult Login(string username, string password)
        {
            try
            {
                //    var dt = new DataTable();
                //    DB.MysqlDB.RegisterSqlLogger(MysqlLog);
                //    //var testas = DB.MysqlDB.Count<customer>(customer._.name == username && customer._.tel == password);//   .Count<customer>().Where(x => x.== cus.id);
                //    //MySqlParameter[] paras = new MySqlParameter[]{//参数数组
                //    //new MySql.Data.MySqlClient.MySqlParameter("@Name",MySql.Data.MySqlClient.MySqlDbType.VarChar,50),
                //    //new MySql.Data.MySqlClient.MySqlParameter("@Password",MySql.Data.MySqlClient.MySqlDbType.VarChar,50)
                //};
                //    paras[0].Value = username;//绑定用户名
                //    //paras[1].Value = password;//绑定用户密码

                //    //var testas = DB.MysqlDB.FromSql("select * from customer c where c.name=@username").AddParameter(paras).ToFirst<customer>();//.where(customer._.name == username && customer._.tel == password);
                //     var testas = DB.MysqlDB.FromSql("select * from customer c where c.name='"+username+"',c").ToFirst<customer>();
                //    if (testas != null)
                //    {
                //        return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
                //    }
                //    else
                //    {
                //        return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
                //    }
                return null;
            }
            catch (Exception ex)
            {
                return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult getHeadMinData()
        {
            var list = DcEpDecHeadList.FetchMin(new DcEpDecHeadCriteria { DehId = 503518148079665 });
            //WebClient wc = new WebClient();
            //wc.BaseAddress = "";
            //wc.Encoding = Encoding.UTF8;
            //HtmlDocument doc = new HtmlDocument();
            return View();
        }
        /// <summary>
        /// 测试dosorm框架自动去掉查询字段值的N的bug
        /// </summary>
        /// <returns></returns>
        public ActionResult TestDosOrmNBug()
        {
            var str = "select * from dc_ep_dec_head where sys_customer_cd ='1000001000000' and Deh_Traf_Name = 'AS COLUMBIA' and Deh_Voyage_no = 'A0004SN' and deh_bill_no='SNKO010180102653'";

            var head = DB.OracleDB.FromSql(str).ToFirst<dc_ep_dec_head>();
            var headLamp = DB.OracleDB.From<DC_EP_DEC_HEAD_O>().Where(x => x.SYS_CUSTOMER_CD == "1000001000000" && x.DEH_TRAF_NAME == "AS COLUMBIA" && x.DEH_VOYAGE_NO == "A0004SN" && x.DEH_BILL_NO == "SNKO010180102653").ToFirstDefault();
            var headCSLA = DcEpDecHeadList.Fetch(new DcEpDecHeadCriteria { DehBillNo = "115088666" });
            var headCSLASingle = DcEpDecHeadList.Fetch(new DcEpDecHeadCriteria { DehTrafName = "220N", DehVoyageNo = "220", DehBillNo = "115088666" }).FirstOrDefault();
            return null;
        }
        public ActionResult getEco()
        {
            var uso = UseShipOrderList.Fetch(new UseShipOrderCriteria { UsoId = 184936429408599, SysCustomerCd = "1000007000000" });
            var retDoc = getDocuNumber("1000001000000");
            //var retDoc = DB.OracleDB.FromSql("select bpd_pbt_cd  from bas_public_details  d where d.bpd_pbt_cd='SYS_SET' and d.bpd_cd='AndSingularNum' and d.sys_customer_cd='" + "1000009000000" + "'").ToFirstDefault<>();
            //var crit = new BasPublicDetailCriteria { BpdPbtCd = "SYS_SET", BpdCd = "AndSingularNum", SysCustomerCd = "1000009000000" };
            //var AndSingularNum = BasPublicDetailList.Fetch(crit);
            //InsertDcEpDecHeadCommand.InsertDcEpDecHead(deh.DehId, deh.DehEntryNo, deh.DehTradeCo, deh.DehTradeName, deh.DehDistrictCode, deh.DehOwnerCode, deh.DehOwnerName,
            //   deh.DehAgentCode, deh.DehAgentName, deh.DehTrafMode, deh.DehIEPort, deh.DehDistinatePort, deh.DehTrafName, deh.DehContrNo, Convert.ToDecimal(deh.DehInRatio),
            //   deh.DehBillNo, deh.DehTradeCountry, deh.DehTradeMode, deh.DehCutMode, deh.DehPayMode, deh.DehTransMode, deh.DehPayWay, deh.DehFeeMark,
            //   deh.DehFeeCurr, Convert.ToDecimal(deh.DehFeeRate), deh.DehOtherMark, deh.DehOtherCurr, Convert.ToDecimal(deh.DehOtherRate), deh.DehInsurMark, deh.DehInsurCurr, Convert.ToDecimal(deh.DehInsurRate),
            //   Convert.ToDecimal(deh.DehPackNo), Convert.ToDecimal(deh.DehGrossWt), Convert.ToDecimal(deh.DehNetWt), deh.DehLicenseNo, deh.DehApprNo, deh.DehManualNo, deh.DehIEDate, deh.DehWrapType, deh.DehNoteS,
            //   deh.DehDDate, deh.DehExSource, deh.DehVoyageNo, deh.DehIeFlag, deh.DehPrdtid, deh.DehStoreno, deh.DehRamanualno, deh.DehRadeclno, deh.DehStatus,
            //   deh.DehMemo, deh.DehDpaId, deh.Inputer, deh.InputTm, deh.Updater, deh.UpdateTm, deh.SysCustomerCd, deh.DehApplyPort, deh.DehYear, deh.DehIeType,
            //   deh.DehChNo, deh.DehEurope, 0, deh.DehPrinter, deh.DehChecker, deh.DehDecType, deh.DehReChecker, 0, 0,
            //   0, deh.DehPassTm, 0, 0, deh.DehListType, deh.DehNoteType, deh.DehTaxation,
            //   0, deh.DehSpecRelConfir ? 1 : 0, deh.DehPriceConfir ? 1 : 0, deh.DehPayOfLicenFees ? 1 : 0, deh.DehTradeCoScc, deh.DehDeclPort, deh.DehTradeAreaCode,
            //   deh.DehOwnerCodeScc, deh.DehAgentCodeScc, deh.DehEdiNo, deh.DehCustomsDeclaration, deh.DehTradeCoEi, deh.DehSource, deh.DehIfCheck, deh.DehUesFtpTm,
            //   deh.DehEntryId, deh.DehFixNo, 0, deh.DehSendStatus, 1, deh.DehIsStatus, deh.DehUserInfo, deh.DehTradeContact, deh.DehTradeAddress, Intermodality);



            List<long> ids = new List<long>();
            ids.Add(111);
            ids.Add(222);
            var ret = DB.OracleDB.From<DC_EP_DEC_HEAD_O>().Where(DC_EP_DEC_HEAD_O._.DEH_ID.SelectIn(ids)).ToList();
            return null;
        }
        public int getDocuNumber(string customerCd)
        {
            int DocuNumber = 5;
            var AndSingularNum = DB.OracleDB.From<Dos.Model.BAS_PUBLIC_DETAILS>().Where(Dos.Model.BAS_PUBLIC_DETAILS._.BPD_PBT_CD == "SYS_SET" && Dos.Model.BAS_PUBLIC_DETAILS._.BPD_CD == "AndSingularNum" && Dos.Model.BAS_PUBLIC_DETAILS._.SYS_CUSTOMER_CD == customerCd).ToFirst();
            if (AndSingularNum != null)
            {
                if (AndSingularNum.BPD_REMARK != null)
                {
                    DocuNumber = Convert.ToInt16(AndSingularNum.BPD_REMARK);
                }
            }
            return DocuNumber;
        }
        /// <summary>
        /// 随附单据表单
        /// </summary>
        /// <returns></returns>
        public ActionResult docAttachedEntryId(RunBackModel model)
        {
            var doc = new documentsattached();
            return Json(new { Success = true });
        }
        public void createWCF()
        {
            //创建服务网址
            Uri url = new Uri("http://localhost:5220/Service1/");
            //创建服务器主机
            var host = new ServiceHost(typeof(Service1), url);
            //创建服务器主机
            host.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "serviceName1");
            //启用元素交换
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            //host.Description.Behaviors.Add(smb);
            host.Open();
            //var thread = new Thread(RunService);
        }
        public void UpdateHead()
        {

        }
<<<<<<< HEAD
        public ActionResult Liangliang()
        {
            var llList = DB.MysqlHomeDB.From<liangliang>().Where(liangliang._.time >= "2018-01-20".ToDateTime() && liangliang._.time < "2018-01-21".ToDateTime()).ToList();
            return View(llList);
=======
        //public ActionResult getLogListIndex()
        //{

        //}
        //public ActionResult getLog()
        //{

        //}
        //    public ActionResult GetMainFest(string billno)
        //    {
        //        string resultstr = "";
        //        resultstr = CommonApiHelper.CUSWEB_CLEAN_BILL_RECORD(uso.UsoBlNo, null, null, null, null, "E", null, null);
        //        QeuryStringJson model = new QeuryStringJson();
        //        JavaScriptSerializer ser = new JavaScriptSerializer();
        //        model = ser.Deserialize<QeuryStringJson>(resultstr);

        //        if (model.GCCResult.Page.totalCount != "0")
        //        {
        //            DcCleanBillRecordList festdels = DcCleanBillRecordList.Fetch(new DcCleanBillRecordCriteria { DamDpaId = dpaid });
        //            for (var fi = festdels.Count() - 1; fi >= 0; fi--)
        //            {
        //                festdels.RemoveAt(fi);
        //            }
        //            festdels.Save();//9.根据dapid 删除对应的预配舱单
        //            DcCleanCtnList clc = DcCleanCtnList.NewList();
        //            DcCleanBillRecord cleanBill = new DcCleanBillRecord();
        //            for (int i = 0; i < model.GCCResult.sets.Count; i++)
        //            {
        //                DcCleanCtn dclcon = new DcCleanCtn();
        //                foreach (var item in model.GCCResult.sets[i].fields)
        //                {
        //                    if (item.name == "CUSTOM_ID")
        //                    {
        //                        cleanBill.DcbrCustomId = item.value;
        //                    }
        //                    if (item.name == "I_E_FLAG")
        //                    {
        //                        cleanBill.DcbrIEFlag = item.value.ToIntNull();
        //                    }
        //                    if (item.name == "TRAF_MODE")
        //                    {
        //                        cleanBill.DcbrTrafMode = item.value.ToIntNull();
        //                    }
        //                    if (item.name == "P_E_FLAG")
        //                    {
        //                        cleanBill.DcbrPEFlag = item.value;
        //                    }
        //                    if (item.name == "SHIP_ID")
        //                    {
        //                        cleanBill.DcbrShipId = item.value;
        //                    }
        //                    if (item.name == "VOYAGE_NO")
        //                    {
        //                        cleanBill.DcbrVoyageNo = item.value;
        //                    }
        //                    if (item.name == "SHIP_NAME_EN")
        //                    {
        //                        cleanBill.DcbrShipNameEn = item.value;
        //                    }
        //                    if (item.name == "SHIP_NAME_CN")
        //                    {
        //                        cleanBill.DcbrShipNameCn = item.value;
        //                    }
        //                    if (item.name == "WAREHOUSE_NO")
        //                    {
        //                        cleanBill.DcbrWarehouseNo = item.value.ToLongNull();
        //                    }
        //                    if (item.name == "I_E_DATE")
        //                    {
        //                        cleanBill.DcbrIEDate = item.value.ToDateTimeNull();
        //                    }
        //                    if (item.name == "SEND_NAME")
        //                    {
        //                        cleanBill.DcbrSendName = item.value;
        //                    }
        //                    if (item.name == "SEND_CODE")
        //                    {
        //                        cleanBill.DcbrSendCode = item.value;
        //                    }
        //                    if (item.name == "SEND_DATE")
        //                    {
        //                        cleanBill.DcbrSendDate = item.value.ToDateTimeNull();
        //                    }
        //                    if (item.name == "BILL_SEQ_NO")
        //                    {
        //                        cleanBill.DcbrBillSeqNo = item.value;
        //                    }
        //                    if (item.name == "BILL_NO")
        //                    {
        //                        cleanBill.DcbrBillNo = item.value;
        //                    }
        //                    if (item.name == "LOADING_PORT")
        //                    {
        //                        cleanBill.DcbrLoadingPort = item.value;
        //                    }
        //                    if (item.name == "DISTRICT_CODE")
        //                    {
        //                        cleanBill.DcbrDistrictCode = item.value;
        //                    }
        //                    if (item.name == "UNLOAD_PLACE")
        //                    {
        //                        cleanBill.DcbrUnloadPlace = item.value;
        //                    }
        //                    if (item.name == "WRAP_TYPE")
        //                    {
        //                        cleanBill.DcbrWrapType = item.value.ToIntNull();
        //                    }
        //                    if (item.name == "VOLUME")
        //                    {
        //                        cleanBill.DcbrVolume = item.value;
        //                    }
        //                    if (item.name == "MAIN_G_NAME")
        //                    {
        //                        cleanBill.DcbrMainGName = item.value;
        //                    }
        //                    if (item.name == "PACK_NUM")
        //                    {
        //                        cleanBill.DcbrPackNum = item.value.ToLongNull();
        //                    }
        //                    if (item.name == "GROSS_WT")
        //                    {
        //                        cleanBill.DcbrGrossWt = item.value.ToLongNull();
        //                    }
        //                    if (item.name == "CHEST_NUM")
        //                    {
        //                        cleanBill.DcbrChestNum = item.value.ToLongNull();
        //                    }
        //                    if (item.name == "CONTR_NO")
        //                    {
        //                        cleanBill.DcbrContrNo = item.value;
        //                    }
        //                    if (item.name == "REC_NAME")
        //                    {
        //                        cleanBill.DcbrRecName = item.value;
        //                    }
        //                    if (item.name == "OWNER_NAME")
        //                    {
        //                        cleanBill.DcbrOwnerName = item.value;
        //                    }
        //                    if (item.name == "IMP_DATE")
        //                    {
        //                        cleanBill.DcbrImpDate = item.value.ToDateTimeNull();
        //                    }

        //                    dclcon.DccDcbrId = cleanBill.DcbrId;
        //                    if (item.name == "CONTA_SEQ_NO")
        //                    {
        //                        dclcon.DccContaSeqNo = item.value.ToIntNull();
        //                    }
        //                    if (item.name == "CONTA_NO")
        //                    {
        //                        dclcon.DccContaNo = item.value;//.ToLongNull();
        //                    }
        //                    if (item.name == "CONTA_SIZE")
        //                    {
        //                        dclcon.DccContaSize = item.value.ToIntNull();
        //                    }
        //                    if (item.name == "SEAL_NO")
        //                    {
        //                        dclcon.DccSealNo = item.value;
        //                    }
        //                    if (item.name == "CONAT_TYPE")
        //                    {
        //                        dclcon.DccConatType = item.value.ToIntNull();
        //                    }
        //                }
        //                clc.Add(dclcon);
        //                festdels.Add(cleanBill);
        //            }
        //        }
        //    public ActionResult About()
        //    {
        //        var id = Session.SessionID;
        //        Session.Add("test", "ssssss");
        //        var seTest = Session["test"];
        //        var test = HttpRuntime.Cache.Get("test");
        //        var cache = new System.Web.Caching.Cache();
        //        //var test = cache.Get("test");
        //        ViewBag.Message = "Your app description page.";
        //        HttpContext.Cache.Insert("test2", "test2ssss");
        //        cache.Insert("test1", "sssss");
        //        var test1 = cache.Get("test1");
        //        return View();
        //    }

        //    public ActionResult Contact()
        //    {
        //        ViewBag.Message = "Your contact page.";

        //        return View();
        //    }

        //}
        //public ActionResult GetPackInfo(string billno,string boxno)
        //{
        //    string resultstr = "";
        //    if (!boxno.IsNullOrEmpty())//调用电子装箱单的单据是拼箱类型且来源是美设业务时，取主提单号和集装箱号调取接口
        //    {
        //        resultstr = ApiHelper.GetCstVslInfoSearch("", sDlhBoxNo);//直接按箱号查询接口数据
        //    }
        //    else
        //    {
        //        resultstr = ApiHelper.GetCstVslInfoSearch(sMDehBillNo, "");//整箱按提单号调用接口
        //    }
        //    CstVslInfoSearchJson cstVsl = new CstVslInfoSearchJson();//该实体类存在Model下 没放在控制器下面增加位置
        //    JavaScriptSerializer jCstVsl = new JavaScriptSerializer();
        //    cstVsl = ser.Deserialize<CstVslInfoSearchJson>(resultstr);
        //    if (cstVsl != null && cstVsl.detail.Count() != 0)
        //    {
        //        #region 报关单集装箱对象2016-11-12
        //        DcEpDecContainer containerModel = new DcEpDecContainer();
        //        containerModel.DecContainerNo = sDlhBoxNo;//箱号
        //                                                  //containerModel.DecContainerWt = set.weight.ToDouble();//重量//此处应该是箱自重，而不是接口返回重量数据，待验证
        //        containerModel.DecDehId = dehid.Value;
        //        string sCtnType = "";
        //        if (cstVsl.ctntype != null)//如果接口返回的箱型不为空，则取前三位到缓存中读取翻译箱型代码并存入电子装箱单和集装箱表中对应的箱型字段
        //        {
        //            sCtnType = cstVsl.ctntype.Substring(0, 3);
        //            var CodeList = _BasContCodeList.Where(a => a.BccCode95.Contains(sCtnType)).FirstOrDefault();
        //            if (CodeList != null)
        //            {
        //                containerModel.DecContType = CodeList.BccContCd;//箱型翻译
        //                                                                // containerModel.DecContainerWt = CodeList.BccContWt;//重量//此处应该是箱自重，而不是接口返回重量数据，待验证[2017-01-06取箱自重]
        //            }
        //        }
        //        else//否则存入空值
        //        {
        //            containerModel.DecContType = cstVsl.ctntype;
        //            containerModel.DecContainerWt = 0;
        //        }
        //        //规格型号
        //        if (containerModel.DecContType != "")
        //        {
        //            if (Convert.ToInt32(containerModel.DecContType.Substring(0, 2)) >= 40)
        //            {
        //                containerModel.DecContainerModel = "2";
        //                containerModel.DecContainerWt = 3800;
        //            }
        //            else
        //            {
        //                containerModel.DecContainerModel = "1";
        //                containerModel.DecContainerWt = 2300;
        //            }
        //        }
        //        dcEpDecContainerList.Add(containerModel);//循环添加集装箱信息
        //        #endregion
        //        //2.1.3.1 循环数据添加倒list中
        //        foreach (var set in cstVsl.detail)
        //        {
        //            #region 电子装箱单表对象赋值
        //            DcElectronicPacking temp = new DcElectronicPacking();
        //            temp.DepContainerNo = set.ctnno;//箱号
        //            if (!string.IsNullOrWhiteSpace(set.cus_time))
        //            {
        //                temp.DepReceiptTm = DateTime.ParseExact(set.cus_time, "yyyyMMddHHmm", System.Globalization.CultureInfo.CurrentCulture);//海关接收回执时间
        //            }
        //            if (!string.IsNullOrWhiteSpace(set.weight))
        //            {
        //                temp.DepWeight = set.weight.ToDouble();//重量
        //            }
        //            if (!string.IsNullOrWhiteSpace(set.package))
        //            {
        //                temp.DepPackNo = set.package.ToLong();//件数
        //            }
        //            temp.DepReceipt = set.cus_status;//海关回执   问题：返回值是1和0  分别代表什么！
        //            temp.DepContainerTransactor = set.ctn_opr_code;//箱经营人
        //            temp.DepDischargeBwCd = set.unloadport;//卸港代码
        //            temp.DepBillNo = set.blno;//提单号                                              

        //            temp.DepContType = containerModel.DecContType;//箱型
        //            if (!string.IsNullOrWhiteSpace(cstVsl.csotcoDt))
        //            {
        //                temp.DepPacketTransmissionTm = DateTime.ParseExact(cstVsl.csotcoDt, "yyyyMMddHHmm", System.Globalization.CultureInfo.CurrentCulture);//报文发送时间
        //            }
        //            temp.DepArrivalPlace = cstVsl.in_addr;//进港地点
        //            if (!string.IsNullOrWhiteSpace(cstVsl.in_date))
        //            {
        //                temp.DepArrivalTm = DateTime.ParseExact(cstVsl.in_date, "yyyyMMddHHmm", System.Globalization.CultureInfo.CurrentCulture);//进港时间
        //            }
        //            temp.DepMessageNumber = cstVsl.csotco; //报文号

        //            lPackage += temp.DepPackNo;
        //            if (temp.DepWeight.HasValue)
        //            {
        //                lWeight += temp.DepWeight.Value;
        //            }
        //            list.Add(temp);
        //            #endregion
        //        }
        //        if (list.Count > 0)
        //        {
        //            for (int i = 0; i < list.Count; i++)
        //            {
        //                list[i].DepTotalPackNo = lPackage;
        //                list[i].DepTotalWeight = lWeight;
        //            }
        //        }
        //}
        #region pdf
        public ActionResult PDF()
        {
            var list = DB.MysqlDB.From<pdf>().ToList();
            return View(list);
            //var htmlweb = new HtmlAgilityPack.HtmlWeb();
            //htmlweb.OverrideEncoding = Encoding.GetEncoding("utf-8");
            //htmlweb.PreRequest = new HtmlAgilityPack.HtmlWeb.PreRequestHandler(PreRequest);
            //var docweb = htmlweb.Load("http://www.minxue.net/55/n-102355.html");
            //string html = "<div id='test'><span>testspan1</span><span>testspan2</span><span id='span3'>testspan3</span><div><span>testspanA1</span></div></div>";
            //var doc = new HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(html);
            //var span = doc.DocumentNode.SelectSingleNode("//div[@id='test']/span[@id='span3']");
            //var span2 = doc.DocumentNode.SelectNodes("//div[@id='test']/span");
            //var span3 = doc.DocumentNode.SelectNodes("./div//span");

        }
        public ActionResult PDFDtl(long id)
        {
            var p = DB.MysqlDB.From<pdf>().Where(x => x.Id == id).ToFirstDefault();
            var d = DB.MysqlDB.From<pdf_dtl>().Where(x => x.id == id).ToList();
            var model = new  PDFModel();
            model.p = p;
            model.dtls = d;
            return View(model);
        }
        public ActionResult DelPDF(long id)
        {
            try
            {
                var p = DB.MysqlDB.From<pdf>().Where(x => x.Id == id).ToFirst();
               var ret = DB.MysqlDB.Delete(p);
                return Json(new { Success = true });
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }
        }
        public class PDFModel
        {
            public PDFModel()
            {
                dtls = new List<pdf_dtl>();
            }
            public pdf p { get; set; }
            public List<pdf_dtl> dtls { get; set; }
        }
        #endregion
        bool PreRequest(HttpWebRequest request)
        {
            request.Headers[HttpRequestHeader.AcceptEncoding] = "gzip, deflate";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            request.CookieContainer = new CookieContainer();
            return true;
>>>>>>> c1722096a0d0083b0dcd1b914983e83c76c848c1
        }
        public class CompanyResult
        {
            public CompanyResult()
            {
                List = new List<Company>();
            }
            public bool Success { get; set; }
            public string Message { get; set; }
            public List<Company> List { get; set; }

        }
        public class Company
        {
            public string TradeCo { get; set; }
            public string FullCo { get; set; }
        }
        public class test
        {
            private string pname { get; set; }
            public string name
            {
                get
                {
                    return pname;
                }
                set
                {
                    pname = value;
                }
            }
            public int age { get; set; }
        }
        /// <summary>
        /// 随附单据表单上传字段
        /// </summary>
        public class RunBackModel
        {
            public string method;       //insert/upload必填

            public string gotoFlag;
            public string id;
            public string dataStatus;
            public string status;
            public string groupId;
            public string fileDigest;
            public string signCert;
            public string fileSign;
            public string fileInfo;
            public string fileInfoStr;
            public string filePath;
            public string signTime;
            public string tradeFileName;
            public string lockFlag;
            public string tradeCode;
            public string formatType;   //US insert必填
            public string preEntryId;   //EDI号 insert必填
            public string entryId;      //EDI号 insert必填
            public string declCode;     //卡号 insert必填
            public string declName;     //卡号绑定的操作人 insert必填
            public string fileTypeCN;   //仅upload使用的参数
            public string fileType;     //附件类型 00000001 insert必填
            public string fileTypeSign; //仅upload使用的参数
            public string customsCode;  //关区 2229 insert必填
            public string signUnit;     //上传企业代码 3109980360 insert必填
            public string fileName;
            public string opNote;
            public string edocOwnerCode;
            public string edocOwnerName;
            public string uploadFileName;
            public string cookie;
        }
        public class Tools
        {
            public static T GetEntity<T>(DataTable table) where T : new()
            {
                T entity = new T();
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in entity.GetType().GetProperties())
                    {
                        if (row.Table.Columns.Contains(item.Name))
                        {
                            if (DBNull.Value != row[item.Name])
                            {
                                item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                            }

                        }
                    }
                }

                return entity;
            }

            public static IList<T> GetEntities<T>(DataTable table) where T : new()
            {
                IList<T> entities = new List<T>();
                foreach (DataRow row in table.Rows)
                {
                    T entity = new T();
                    foreach (var item in entity.GetType().GetProperties())
                    {
                        item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                    }
                    entities.Add(entity);
                }
                return entities;
            }
            SymmetricAlgorithm mobjCryptoService;
            public Tools()
            {
                mobjCryptoService = new RijndaelManaged();
            }
            public static Object obj = new Object();
            public static void assignModel<T, F>(T enity, F model)
            {
                Type itemType = enity.GetType();
                var ModelType = model.GetType();
                foreach (PropertyInfo ModelInfo in ModelType.GetProperties())
                {
                    var ModelInfoName = ModelInfo.Name.Replace("_", "").ToLower();
                    foreach (PropertyInfo itemInfo in itemType.GetProperties())
                    {
                        if (itemInfo.Name.ToLower() == ModelInfoName)
                        {
                            ModelInfo.SetValue(model, itemInfo.GetValue(enity, null), null);
                        }
                    }
                }
            }
            #region log操作
            public static void SaveLog(string context)
            {
                //{
                //    Monitor.Enter(obj);
                //    StreamWriter sw;
                //    string dirpath = ConfigurationManager.AppSettings["log"];
                //    if (!Directory.Exists(dirpath))
                //    {
                //        Directory.CreateDirectory(dirpath);
                //    }
                //    string edilogfilepath = dirpath + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                //    if (!File.Exists(edilogfilepath))
                //    {
                //        sw = File.CreateText(edilogfilepath);
                //    }
                //    else
                //    {
                //        sw = File.AppendText(edilogfilepath);
                //    }
                //    try
                //    {
                //        sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  \"" + context + "\"");
                //    }
                //    catch { }
                //    finally
                //    {
                //        sw.Close();
                //        Monitor.Pulse(obj);
                //        Monitor.Exit(obj);
                //    }
            }
            #endregion
            public string StringToUnicode(string s)
            {
                char[] charbuffers = s.ToCharArray();
                byte[] buffer;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < charbuffers.Length; i++)
                {
                    buffer = System.Text.Encoding.Unicode.GetBytes(charbuffers[i].ToString());
                    sb.Append(String.Format("//u{0:X2}{1:X2}", buffer[1], buffer[0]));
                }
                return sb.ToString();
            }
            public static int ExecuteSql(string sql)
            {
                //var sqlconn = new OracleConnection();
                //sqlconn.Close();
                //try
                //{
                //    string connstr = ConfigurationManager.ConnectionStrings["OracleConn"].ToString();
                //    sqlconn = new OracleConnection(connstr);
                //    sqlconn.Open();
                //    OracleCommand sqlcommand = new OracleCommand();
                //    sqlcommand.Connection = sqlconn;
                //    sqlcommand.CommandText = sql;
                //    return sqlcommand.ExecuteNonQuery();
                //}
                //catch (Exception ex)
                //{
                //    throw ex;
                //}
                //finally
                //{
                //    sqlconn.Close();
                //}
                return 0;
            }
            /// <summary>  
            /// Unicode字符串转为正常字符串  
            /// </summary>  
            /// <param name="srcText"></param>  
            /// <returns></returns>  
            public string UnicodeToString(string srcText)
            {
                string dst = "";
                string src = srcText;
                int len = srcText.Length / 6;
                for (int i = 0; i <= len - 1; i++)
                {
                    string str = "";
                    str = src.Substring(0, 6).Substring(2);
                    src = src.Substring(6);
                    byte[] bytes = new byte[2];
                    bytes[1] = byte.Parse(int.Parse(str.Substring(0, 2), NumberStyles.HexNumber).ToString());
                    bytes[0] = byte.Parse(int.Parse(str.Substring(2, 2), NumberStyles.HexNumber).ToString());
                    dst += Encoding.Unicode.GetString(bytes);
                }
                return dst;
            }
            public string Decrypt(string Source)
            {
                byte[] buffer = Convert.FromBase64String(Source);
                MemoryStream stream = new MemoryStream(buffer, 0, buffer.Length);
                mobjCryptoService.Key = GetLegalKey();
                mobjCryptoService.IV = GetLegalIV();
                //mobjCryptoService.set_Key(GetLegalKey());
                //mobjCryptoService.set_IV(GetLegalIV());
                ICryptoTransform transform = mobjCryptoService.CreateDecryptor();
                CryptoStream stream2 = new CryptoStream(stream, transform, 0);
                StreamReader reader = new StreamReader(stream2);
                return reader.ReadToEnd();
            }

            public string Encrypt(string Source)
            {
                //byte[] bytes = Encoding.get_UTF8().GetBytes(Source);
                byte[] bytes = Encoding.UTF8.GetBytes(Source);
                MemoryStream stream = new MemoryStream();
                mobjCryptoService.Key = GetLegalKey();
                mobjCryptoService.IV = GetLegalIV();
                //mobjCryptoService.set_Key(GetLegalKey());
                //mobjCryptoService.set_IV(GetLegalIV());
                ICryptoTransform transform = mobjCryptoService.CreateEncryptor();
                CryptoStream stream2 = new System.Security.Cryptography.CryptoStream(stream, transform, CryptoStreamMode.Write);
                stream2.Write(bytes, 0, bytes.Length);
                stream2.FlushFinalBlock();
                stream.Close();
                return Convert.ToBase64String(stream.ToArray());
            }

            private byte[] GetLegalKey()
            {
                string key = "adgaw334^*^&#$#$W2343qwreqwr12"; ;
                mobjCryptoService.GenerateKey();
                //int length = mobjCryptoService.get_Key().Length;
                int length = mobjCryptoService.Key.Length;
                if (key.Length > length)
                {
                    key = key.Substring(0, length);
                }
                else if (key.Length < length)
                {
                    key = key.PadRight(length, ' ');
                }
                //return Encoding.get_ASCII().GetBytes(key);
                return Encoding.ASCII.GetBytes(key);
            }


            private byte[] GetLegalIV()
            {
                string str = "E4ghj*Ghg7!rNIfb&95GUY86GfghUb#er57HBh(u%g6HJ($jhWk7&!hg4ui%$hjk";

                mobjCryptoService.GenerateIV();
                int length = mobjCryptoService.IV.Length;
                if (str.Length > length)
                {
                    str = str.Substring(0, length);
                }
                else if (str.Length < length)
                {
                    str = str.PadRight(length, ' ');
                }
                //return Encoding.get_ASCII().GetBytes(str);
                return Encoding.ASCII.GetBytes(str);
            }

        }
    }

}
