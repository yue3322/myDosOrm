﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;

namespace Dos.Model
{
    /// <summary>
    /// 实体类Service_Form_Head。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Form_Head")]
    [Serializable]
    public partial class Service_Form_Head : Entity
    {
        #region Model
		private string _ie_flag;
		private string _pre_entry_id;
		private string _customs_id;
		private string _manual_no;
		private string _contr_no;
		private string _i_e_date;
		private string _d_date;
		private string _trade_co;
		private string _trade_name;
		private string _owner_code;
		private string _owner_name;
		private string _agent_code;
		private string _agent_name;
		private string _traf_mode;
		private string _traf_name;
		private string _voyage_no;
		private string _bill_no;
		private string _trade_mode;
		private string _cut_mode;
		private string _in_ratio;
		private string _pay_way;
		private string _lisence_no;
		private string _trade_country;
		private string _distinate_port;
		private string _district_code;
		private string _appr_no;
		private string _trans_mode;
		private string _fee_mark;
		private string _fee_rate;
		private string _fee_curr;
		private string _insur_mark;
		private string _insur_rate;
		private string _insur_curr;
		private string _other_mark;
		private string _other_rate;
		private string _other_curr;
		private string _pack_no;
		private string _wrap_type;
		private string _gross_wt;
		private string _net_wt;
		private string _ex_source;
		private string _type_er;
		private string _entry_group;
		private string _is_status;
		private string _username;
		private string _create_date;
		private string _del_flag;
		private string _RaDeclNo;
		private string _RaManualNo;
		private string _StoreNo;
		private string _PrdtID;
		private string _i_e_port;
		private string _note_s;
		private string _print_date;
		private string _SUP_FLAG;
		private string _CollectTax;
		private string _Two_Audit;
		private string _chk_surety;
		private string _BILL_TYPE;
		private string _PaperLessTax;
		private string _Tax_Amount;
		private string _is_status_old;
		private string _Tax_No;
		private string _CBE;
		private string _TRADE_CO_SCC;
		private string _AGENT_CODE_SCC;
		private string _OWNER_CODE_SCC;
		private string _PROMISE_ITMES;
		private string _TRADE_AREA_CODE;
		private string _EDI_REMARK_2;
		private string _EDI_NO;
		private string _COP_NO;
		private string _DECL_PORT;
		private string _IS_EXPORT;
		private string _IS_IMPORT;
		private string _JOB_NO;
		private string _CLIENT_NO;
		private string _CheckFlow;
		private string _ENTRY_ID;

		/// <summary>
		/// 
		/// </summary>
		[Field("ie_flag")]
		public string ie_flag
		{
			get{ return _ie_flag; }
			set
			{
				this.OnPropertyValueChange("ie_flag");
				this._ie_flag = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("pre_entry_id")]
		public string pre_entry_id
		{
			get{ return _pre_entry_id; }
			set
			{
				this.OnPropertyValueChange("pre_entry_id");
				this._pre_entry_id = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("customs_id")]
		public string customs_id
		{
			get{ return _customs_id; }
			set
			{
				this.OnPropertyValueChange("customs_id");
				this._customs_id = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("manual_no")]
		public string manual_no
		{
			get{ return _manual_no; }
			set
			{
				this.OnPropertyValueChange("manual_no");
				this._manual_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("contr_no")]
		public string contr_no
		{
			get{ return _contr_no; }
			set
			{
				this.OnPropertyValueChange("contr_no");
				this._contr_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("i_e_date")]
		public string i_e_date
		{
			get{ return _i_e_date; }
			set
			{
				this.OnPropertyValueChange("i_e_date");
				this._i_e_date = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("d_date")]
		public string d_date
		{
			get{ return _d_date; }
			set
			{
				this.OnPropertyValueChange("d_date");
				this._d_date = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("trade_co")]
		public string trade_co
		{
			get{ return _trade_co; }
			set
			{
				this.OnPropertyValueChange("trade_co");
				this._trade_co = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("trade_name")]
		public string trade_name
		{
			get{ return _trade_name; }
			set
			{
				this.OnPropertyValueChange("trade_name");
				this._trade_name = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("owner_code")]
		public string owner_code
		{
			get{ return _owner_code; }
			set
			{
				this.OnPropertyValueChange("owner_code");
				this._owner_code = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("owner_name")]
		public string owner_name
		{
			get{ return _owner_name; }
			set
			{
				this.OnPropertyValueChange("owner_name");
				this._owner_name = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("agent_code")]
		public string agent_code
		{
			get{ return _agent_code; }
			set
			{
				this.OnPropertyValueChange("agent_code");
				this._agent_code = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("agent_name")]
		public string agent_name
		{
			get{ return _agent_name; }
			set
			{
				this.OnPropertyValueChange("agent_name");
				this._agent_name = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("traf_mode")]
		public string traf_mode
		{
			get{ return _traf_mode; }
			set
			{
				this.OnPropertyValueChange("traf_mode");
				this._traf_mode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("traf_name")]
		public string traf_name
		{
			get{ return _traf_name; }
			set
			{
				this.OnPropertyValueChange("traf_name");
				this._traf_name = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("voyage_no")]
		public string voyage_no
		{
			get{ return _voyage_no; }
			set
			{
				this.OnPropertyValueChange("voyage_no");
				this._voyage_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("bill_no")]
		public string bill_no
		{
			get{ return _bill_no; }
			set
			{
				this.OnPropertyValueChange("bill_no");
				this._bill_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("trade_mode")]
		public string trade_mode
		{
			get{ return _trade_mode; }
			set
			{
				this.OnPropertyValueChange("trade_mode");
				this._trade_mode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("cut_mode")]
		public string cut_mode
		{
			get{ return _cut_mode; }
			set
			{
				this.OnPropertyValueChange("cut_mode");
				this._cut_mode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("in_ratio")]
		public string in_ratio
		{
			get{ return _in_ratio; }
			set
			{
				this.OnPropertyValueChange("in_ratio");
				this._in_ratio = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("pay_way")]
		public string pay_way
		{
			get{ return _pay_way; }
			set
			{
				this.OnPropertyValueChange("pay_way");
				this._pay_way = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("lisence_no")]
		public string lisence_no
		{
			get{ return _lisence_no; }
			set
			{
				this.OnPropertyValueChange("lisence_no");
				this._lisence_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("trade_country")]
		public string trade_country
		{
			get{ return _trade_country; }
			set
			{
				this.OnPropertyValueChange("trade_country");
				this._trade_country = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("distinate_port")]
		public string distinate_port
		{
			get{ return _distinate_port; }
			set
			{
				this.OnPropertyValueChange("distinate_port");
				this._distinate_port = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("district_code")]
		public string district_code
		{
			get{ return _district_code; }
			set
			{
				this.OnPropertyValueChange("district_code");
				this._district_code = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("appr_no")]
		public string appr_no
		{
			get{ return _appr_no; }
			set
			{
				this.OnPropertyValueChange("appr_no");
				this._appr_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("trans_mode")]
		public string trans_mode
		{
			get{ return _trans_mode; }
			set
			{
				this.OnPropertyValueChange("trans_mode");
				this._trans_mode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("fee_mark")]
		public string fee_mark
		{
			get{ return _fee_mark; }
			set
			{
				this.OnPropertyValueChange("fee_mark");
				this._fee_mark = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("fee_rate")]
		public string fee_rate
		{
			get{ return _fee_rate; }
			set
			{
				this.OnPropertyValueChange("fee_rate");
				this._fee_rate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("fee_curr")]
		public string fee_curr
		{
			get{ return _fee_curr; }
			set
			{
				this.OnPropertyValueChange("fee_curr");
				this._fee_curr = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("insur_mark")]
		public string insur_mark
		{
			get{ return _insur_mark; }
			set
			{
				this.OnPropertyValueChange("insur_mark");
				this._insur_mark = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("insur_rate")]
		public string insur_rate
		{
			get{ return _insur_rate; }
			set
			{
				this.OnPropertyValueChange("insur_rate");
				this._insur_rate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("insur_curr")]
		public string insur_curr
		{
			get{ return _insur_curr; }
			set
			{
				this.OnPropertyValueChange("insur_curr");
				this._insur_curr = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("other_mark")]
		public string other_mark
		{
			get{ return _other_mark; }
			set
			{
				this.OnPropertyValueChange("other_mark");
				this._other_mark = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("other_rate")]
		public string other_rate
		{
			get{ return _other_rate; }
			set
			{
				this.OnPropertyValueChange("other_rate");
				this._other_rate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("other_curr")]
		public string other_curr
		{
			get{ return _other_curr; }
			set
			{
				this.OnPropertyValueChange("other_curr");
				this._other_curr = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("pack_no")]
		public string pack_no
		{
			get{ return _pack_no; }
			set
			{
				this.OnPropertyValueChange("pack_no");
				this._pack_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("wrap_type")]
		public string wrap_type
		{
			get{ return _wrap_type; }
			set
			{
				this.OnPropertyValueChange("wrap_type");
				this._wrap_type = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("gross_wt")]
		public string gross_wt
		{
			get{ return _gross_wt; }
			set
			{
				this.OnPropertyValueChange("gross_wt");
				this._gross_wt = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("net_wt")]
		public string net_wt
		{
			get{ return _net_wt; }
			set
			{
				this.OnPropertyValueChange("net_wt");
				this._net_wt = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ex_source")]
		public string ex_source
		{
			get{ return _ex_source; }
			set
			{
				this.OnPropertyValueChange("ex_source");
				this._ex_source = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("type_er")]
		public string type_er
		{
			get{ return _type_er; }
			set
			{
				this.OnPropertyValueChange("type_er");
				this._type_er = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("entry_group")]
		public string entry_group
		{
			get{ return _entry_group; }
			set
			{
				this.OnPropertyValueChange("entry_group");
				this._entry_group = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("is_status")]
		public string is_status
		{
			get{ return _is_status; }
			set
			{
				this.OnPropertyValueChange("is_status");
				this._is_status = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("username")]
		public string username
		{
			get{ return _username; }
			set
			{
				this.OnPropertyValueChange("username");
				this._username = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("create_date")]
		public string create_date
		{
			get{ return _create_date; }
			set
			{
				this.OnPropertyValueChange("create_date");
				this._create_date = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("del_flag")]
		public string del_flag
		{
			get{ return _del_flag; }
			set
			{
				this.OnPropertyValueChange("del_flag");
				this._del_flag = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("RaDeclNo")]
		public string RaDeclNo
		{
			get{ return _RaDeclNo; }
			set
			{
				this.OnPropertyValueChange("RaDeclNo");
				this._RaDeclNo = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("RaManualNo")]
		public string RaManualNo
		{
			get{ return _RaManualNo; }
			set
			{
				this.OnPropertyValueChange("RaManualNo");
				this._RaManualNo = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("StoreNo")]
		public string StoreNo
		{
			get{ return _StoreNo; }
			set
			{
				this.OnPropertyValueChange("StoreNo");
				this._StoreNo = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("PrdtID")]
		public string PrdtID
		{
			get{ return _PrdtID; }
			set
			{
				this.OnPropertyValueChange("PrdtID");
				this._PrdtID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("i_e_port")]
		public string i_e_port
		{
			get{ return _i_e_port; }
			set
			{
				this.OnPropertyValueChange("i_e_port");
				this._i_e_port = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("note_s")]
		public string note_s
		{
			get{ return _note_s; }
			set
			{
				this.OnPropertyValueChange("note_s");
				this._note_s = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("print_date")]
		public string print_date
		{
			get{ return _print_date; }
			set
			{
				this.OnPropertyValueChange("print_date");
				this._print_date = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("SUP_FLAG")]
		public string SUP_FLAG
		{
			get{ return _SUP_FLAG; }
			set
			{
				this.OnPropertyValueChange("SUP_FLAG");
				this._SUP_FLAG = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CollectTax")]
		public string CollectTax
		{
			get{ return _CollectTax; }
			set
			{
				this.OnPropertyValueChange("CollectTax");
				this._CollectTax = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Two_Audit")]
		public string Two_Audit
		{
			get{ return _Two_Audit; }
			set
			{
				this.OnPropertyValueChange("Two_Audit");
				this._Two_Audit = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("chk_surety")]
		public string chk_surety
		{
			get{ return _chk_surety; }
			set
			{
				this.OnPropertyValueChange("chk_surety");
				this._chk_surety = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("BILL_TYPE")]
		public string BILL_TYPE
		{
			get{ return _BILL_TYPE; }
			set
			{
				this.OnPropertyValueChange("BILL_TYPE");
				this._BILL_TYPE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("PaperLessTax")]
		public string PaperLessTax
		{
			get{ return _PaperLessTax; }
			set
			{
				this.OnPropertyValueChange("PaperLessTax");
				this._PaperLessTax = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Tax_Amount")]
		public string Tax_Amount
		{
			get{ return _Tax_Amount; }
			set
			{
				this.OnPropertyValueChange("Tax_Amount");
				this._Tax_Amount = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("is_status_old")]
		public string is_status_old
		{
			get{ return _is_status_old; }
			set
			{
				this.OnPropertyValueChange("is_status_old");
				this._is_status_old = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Tax_No")]
		public string Tax_No
		{
			get{ return _Tax_No; }
			set
			{
				this.OnPropertyValueChange("Tax_No");
				this._Tax_No = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CBE")]
		public string CBE
		{
			get{ return _CBE; }
			set
			{
				this.OnPropertyValueChange("CBE");
				this._CBE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TRADE_CO_SCC")]
		public string TRADE_CO_SCC
		{
			get{ return _TRADE_CO_SCC; }
			set
			{
				this.OnPropertyValueChange("TRADE_CO_SCC");
				this._TRADE_CO_SCC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("AGENT_CODE_SCC")]
		public string AGENT_CODE_SCC
		{
			get{ return _AGENT_CODE_SCC; }
			set
			{
				this.OnPropertyValueChange("AGENT_CODE_SCC");
				this._AGENT_CODE_SCC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OWNER_CODE_SCC")]
		public string OWNER_CODE_SCC
		{
			get{ return _OWNER_CODE_SCC; }
			set
			{
				this.OnPropertyValueChange("OWNER_CODE_SCC");
				this._OWNER_CODE_SCC = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("PROMISE_ITMES")]
		public string PROMISE_ITMES
		{
			get{ return _PROMISE_ITMES; }
			set
			{
				this.OnPropertyValueChange("PROMISE_ITMES");
				this._PROMISE_ITMES = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TRADE_AREA_CODE")]
		public string TRADE_AREA_CODE
		{
			get{ return _TRADE_AREA_CODE; }
			set
			{
				this.OnPropertyValueChange("TRADE_AREA_CODE");
				this._TRADE_AREA_CODE = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("EDI_REMARK_2")]
		public string EDI_REMARK_2
		{
			get{ return _EDI_REMARK_2; }
			set
			{
				this.OnPropertyValueChange("EDI_REMARK_2");
				this._EDI_REMARK_2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("EDI_NO")]
		public string EDI_NO
		{
			get{ return _EDI_NO; }
			set
			{
				this.OnPropertyValueChange("EDI_NO");
				this._EDI_NO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("COP_NO")]
		public string COP_NO
		{
			get{ return _COP_NO; }
			set
			{
				this.OnPropertyValueChange("COP_NO");
				this._COP_NO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DECL_PORT")]
		public string DECL_PORT
		{
			get{ return _DECL_PORT; }
			set
			{
				this.OnPropertyValueChange("DECL_PORT");
				this._DECL_PORT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("IS_EXPORT")]
		public string IS_EXPORT
		{
			get{ return _IS_EXPORT; }
			set
			{
				this.OnPropertyValueChange("IS_EXPORT");
				this._IS_EXPORT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("IS_IMPORT")]
		public string IS_IMPORT
		{
			get{ return _IS_IMPORT; }
			set
			{
				this.OnPropertyValueChange("IS_IMPORT");
				this._IS_IMPORT = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("JOB_NO")]
		public string JOB_NO
		{
			get{ return _JOB_NO; }
			set
			{
				this.OnPropertyValueChange("JOB_NO");
				this._JOB_NO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CLIENT_NO")]
		public string CLIENT_NO
		{
			get{ return _CLIENT_NO; }
			set
			{
				this.OnPropertyValueChange("CLIENT_NO");
				this._CLIENT_NO = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CheckFlow")]
		public string CheckFlow
		{
			get{ return _CheckFlow; }
			set
			{
				this.OnPropertyValueChange("CheckFlow");
				this._CheckFlow = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ENTRY_ID")]
		public string ENTRY_ID
		{
			get{ return _ENTRY_ID; }
			set
			{
				this.OnPropertyValueChange("ENTRY_ID");
				this._ENTRY_ID = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ie_flag,
				_.pre_entry_id,
				_.customs_id,
				_.manual_no,
				_.contr_no,
				_.i_e_date,
				_.d_date,
				_.trade_co,
				_.trade_name,
				_.owner_code,
				_.owner_name,
				_.agent_code,
				_.agent_name,
				_.traf_mode,
				_.traf_name,
				_.voyage_no,
				_.bill_no,
				_.trade_mode,
				_.cut_mode,
				_.in_ratio,
				_.pay_way,
				_.lisence_no,
				_.trade_country,
				_.distinate_port,
				_.district_code,
				_.appr_no,
				_.trans_mode,
				_.fee_mark,
				_.fee_rate,
				_.fee_curr,
				_.insur_mark,
				_.insur_rate,
				_.insur_curr,
				_.other_mark,
				_.other_rate,
				_.other_curr,
				_.pack_no,
				_.wrap_type,
				_.gross_wt,
				_.net_wt,
				_.ex_source,
				_.type_er,
				_.entry_group,
				_.is_status,
				_.username,
				_.create_date,
				_.del_flag,
				_.RaDeclNo,
				_.RaManualNo,
				_.StoreNo,
				_.PrdtID,
				_.i_e_port,
				_.note_s,
				_.print_date,
				_.SUP_FLAG,
				_.CollectTax,
				_.Two_Audit,
				_.chk_surety,
				_.BILL_TYPE,
				_.PaperLessTax,
				_.Tax_Amount,
				_.is_status_old,
				_.Tax_No,
				_.CBE,
				_.TRADE_CO_SCC,
				_.AGENT_CODE_SCC,
				_.OWNER_CODE_SCC,
				_.PROMISE_ITMES,
				_.TRADE_AREA_CODE,
				_.EDI_REMARK_2,
				_.EDI_NO,
				_.COP_NO,
				_.DECL_PORT,
				_.IS_EXPORT,
				_.IS_IMPORT,
				_.JOB_NO,
				_.CLIENT_NO,
				_.CheckFlow,
				_.ENTRY_ID,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ie_flag,
				this._pre_entry_id,
				this._customs_id,
				this._manual_no,
				this._contr_no,
				this._i_e_date,
				this._d_date,
				this._trade_co,
				this._trade_name,
				this._owner_code,
				this._owner_name,
				this._agent_code,
				this._agent_name,
				this._traf_mode,
				this._traf_name,
				this._voyage_no,
				this._bill_no,
				this._trade_mode,
				this._cut_mode,
				this._in_ratio,
				this._pay_way,
				this._lisence_no,
				this._trade_country,
				this._distinate_port,
				this._district_code,
				this._appr_no,
				this._trans_mode,
				this._fee_mark,
				this._fee_rate,
				this._fee_curr,
				this._insur_mark,
				this._insur_rate,
				this._insur_curr,
				this._other_mark,
				this._other_rate,
				this._other_curr,
				this._pack_no,
				this._wrap_type,
				this._gross_wt,
				this._net_wt,
				this._ex_source,
				this._type_er,
				this._entry_group,
				this._is_status,
				this._username,
				this._create_date,
				this._del_flag,
				this._RaDeclNo,
				this._RaManualNo,
				this._StoreNo,
				this._PrdtID,
				this._i_e_port,
				this._note_s,
				this._print_date,
				this._SUP_FLAG,
				this._CollectTax,
				this._Two_Audit,
				this._chk_surety,
				this._BILL_TYPE,
				this._PaperLessTax,
				this._Tax_Amount,
				this._is_status_old,
				this._Tax_No,
				this._CBE,
				this._TRADE_CO_SCC,
				this._AGENT_CODE_SCC,
				this._OWNER_CODE_SCC,
				this._PROMISE_ITMES,
				this._TRADE_AREA_CODE,
				this._EDI_REMARK_2,
				this._EDI_NO,
				this._COP_NO,
				this._DECL_PORT,
				this._IS_EXPORT,
				this._IS_IMPORT,
				this._JOB_NO,
				this._CLIENT_NO,
				this._CheckFlow,
				this._ENTRY_ID,
			};
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "Form_Head");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ie_flag = new Field("ie_flag", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field pre_entry_id = new Field("pre_entry_id", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field customs_id = new Field("customs_id", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field manual_no = new Field("manual_no", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field contr_no = new Field("contr_no", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field i_e_date = new Field("i_e_date", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field d_date = new Field("d_date", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field trade_co = new Field("trade_co", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field trade_name = new Field("trade_name", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field owner_code = new Field("owner_code", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field owner_name = new Field("owner_name", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field agent_code = new Field("agent_code", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field agent_name = new Field("agent_name", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field traf_mode = new Field("traf_mode", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field traf_name = new Field("traf_name", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field voyage_no = new Field("voyage_no", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field bill_no = new Field("bill_no", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field trade_mode = new Field("trade_mode", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field cut_mode = new Field("cut_mode", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field in_ratio = new Field("in_ratio", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field pay_way = new Field("pay_way", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field lisence_no = new Field("lisence_no", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field trade_country = new Field("trade_country", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field distinate_port = new Field("distinate_port", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field district_code = new Field("district_code", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field appr_no = new Field("appr_no", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field trans_mode = new Field("trans_mode", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field fee_mark = new Field("fee_mark", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field fee_rate = new Field("fee_rate", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field fee_curr = new Field("fee_curr", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field insur_mark = new Field("insur_mark", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field insur_rate = new Field("insur_rate", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field insur_curr = new Field("insur_curr", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field other_mark = new Field("other_mark", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field other_rate = new Field("other_rate", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field other_curr = new Field("other_curr", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field pack_no = new Field("pack_no", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field wrap_type = new Field("wrap_type", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field gross_wt = new Field("gross_wt", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field net_wt = new Field("net_wt", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ex_source = new Field("ex_source", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field type_er = new Field("type_er", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field entry_group = new Field("entry_group", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field is_status = new Field("is_status", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field username = new Field("username", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field create_date = new Field("create_date", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field del_flag = new Field("del_flag", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RaDeclNo = new Field("RaDeclNo", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RaManualNo = new Field("RaManualNo", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field StoreNo = new Field("StoreNo", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PrdtID = new Field("PrdtID", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field i_e_port = new Field("i_e_port", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field note_s = new Field("note_s", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field print_date = new Field("print_date", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SUP_FLAG = new Field("SUP_FLAG", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CollectTax = new Field("CollectTax", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Two_Audit = new Field("Two_Audit", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field chk_surety = new Field("chk_surety", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BILL_TYPE = new Field("BILL_TYPE", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PaperLessTax = new Field("PaperLessTax", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Tax_Amount = new Field("Tax_Amount", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field is_status_old = new Field("is_status_old", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Tax_No = new Field("Tax_No", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CBE = new Field("CBE", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_CO_SCC = new Field("TRADE_CO_SCC", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AGENT_CODE_SCC = new Field("AGENT_CODE_SCC", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OWNER_CODE_SCC = new Field("OWNER_CODE_SCC", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PROMISE_ITMES = new Field("PROMISE_ITMES", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TRADE_AREA_CODE = new Field("TRADE_AREA_CODE", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EDI_REMARK_2 = new Field("EDI_REMARK_2", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field EDI_NO = new Field("EDI_NO", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field COP_NO = new Field("COP_NO", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DECL_PORT = new Field("DECL_PORT", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_EXPORT = new Field("IS_EXPORT", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IS_IMPORT = new Field("IS_IMPORT", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field JOB_NO = new Field("JOB_NO", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CLIENT_NO = new Field("CLIENT_NO", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CheckFlow = new Field("CheckFlow", "Form_Head", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ENTRY_ID = new Field("ENTRY_ID", "Form_Head", "");
        }
        #endregion
	}
}