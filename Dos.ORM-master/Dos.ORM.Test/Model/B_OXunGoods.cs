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

namespace WD.Model
{
    /// <summary>
    /// 实体类B_OXunGoods。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("B_OXunGoods")]
    [Serializable]
    public partial class B_OXunGoods : Entity
    {
        #region Model
        private int _Id;
        private string _OXunGoodsName;
        private int? _RetailerID;
        private string _RetailerName;
        private string _IndustryCode;
        private string _IndustryCode2;
        private string _BussAreaCode;
        private decimal? _ConsumeIntegal;
        private DateTime? _CreateTime;
        private DateTime? _UpdateTime;
        private int? _OXunGoodsState;
        private string _Describe;
        private string _RetailerAdd;
        private string _GoodsImage;
        private int? _GoodsType;
        private decimal? _Price;
        private decimal? _MemPrice;
        private decimal? _Factorge;
        private decimal? _Postage;
        private int? _ValidDays;
        private int? _DeleteState;
        private int? _OxunID;
        private int? _TotalNum;
        private int? _SaleNum;
        private int? _RetailerType;
        private DateTime? _BuyStartTime;
        private DateTime? _BuyEndTime;
        private DateTime? _ValidStatTime;
        private DateTime? _ValidEndTime;
        private int? _MaxCount;
        private int? _Cycle;
        private int? _CycleType;
        private int? _RetailerCycle;
        private int? _RetailerMaxCount;
        private int? _AutoConfirmDay;
        private decimal? _OneFee;
        private decimal? _Fee;
        private int? _Sort;
        private int? _ConsumeType;
        private decimal? _CashKickback;
        private int? _PayoffState;
        private int? _FastState;
        private string _Dispatching;
        private string _Instruction;
        private string _Location;
        private int? _Express;
        private decimal? _GoodsKG;
        private decimal? _GoodsM3;
        private string _GpsAddress;
        private string _GpsLat;
        private string _GpsLng;
        private int? _ColorEnable;
        private string _Color;
        private int? _SizeEnable;
        private string _Size;
        private int? _RetOnlyEnable;
        private int? _RetOnlyID;
        private string _RetOnlyName;
        private decimal? _TwoFee;
        private int? _SubsidyEnable;
        private int? _SubsidyRetID;
        private string _SubsidyRetName;
        private decimal? _SubsidyCash;

        /// <summary>
        /// 
        /// </summary>
        [Field("Id")]
        public int Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange("Id");
                this._Id = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("OXunGoodsName")]
        public string OXunGoodsName
        {
            get { return _OXunGoodsName; }
            set
            {
                this.OnPropertyValueChange("OXunGoodsName");
                this._OXunGoodsName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetailerID")]
        public int? RetailerID
        {
            get { return _RetailerID; }
            set
            {
                this.OnPropertyValueChange("RetailerID");
                this._RetailerID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetailerName")]
        public string RetailerName
        {
            get { return _RetailerName; }
            set
            {
                this.OnPropertyValueChange("RetailerName");
                this._RetailerName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("IndustryCode")]
        public string IndustryCode
        {
            get { return _IndustryCode; }
            set
            {
                this.OnPropertyValueChange("IndustryCode");
                this._IndustryCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("IndustryCode2")]
        public string IndustryCode2
        {
            get { return _IndustryCode2; }
            set
            {
                this.OnPropertyValueChange("IndustryCode2");
                this._IndustryCode2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("BussAreaCode")]
        public string BussAreaCode
        {
            get { return _BussAreaCode; }
            set
            {
                this.OnPropertyValueChange("BussAreaCode");
                this._BussAreaCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ConsumeIntegal")]
        public decimal? ConsumeIntegal
        {
            get { return _ConsumeIntegal; }
            set
            {
                this.OnPropertyValueChange("ConsumeIntegal");
                this._ConsumeIntegal = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("CreateTime")]
        public DateTime? CreateTime
        {
            get { return _CreateTime; }
            set
            {
                this.OnPropertyValueChange("CreateTime");
                this._CreateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("UpdateTime")]
        public DateTime? UpdateTime
        {
            get { return _UpdateTime; }
            set
            {
                this.OnPropertyValueChange("UpdateTime");
                this._UpdateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("OXunGoodsState")]
        public int? OXunGoodsState
        {
            get { return _OXunGoodsState; }
            set
            {
                this.OnPropertyValueChange("OXunGoodsState");
                this._OXunGoodsState = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Describe")]
        public string Describe
        {
            get { return _Describe; }
            set
            {
                this.OnPropertyValueChange("Describe");
                this._Describe = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetailerAdd")]
        public string RetailerAdd
        {
            get { return _RetailerAdd; }
            set
            {
                this.OnPropertyValueChange("RetailerAdd");
                this._RetailerAdd = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("GoodsImage")]
        public string GoodsImage
        {
            get { return _GoodsImage; }
            set
            {
                this.OnPropertyValueChange("GoodsImage");
                this._GoodsImage = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("GoodsType")]
        public int? GoodsType
        {
            get { return _GoodsType; }
            set
            {
                this.OnPropertyValueChange("GoodsType");
                this._GoodsType = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Price")]
        public decimal? Price
        {
            get { return _Price; }
            set
            {
                this.OnPropertyValueChange("Price");
                this._Price = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("MemPrice")]
        public decimal? MemPrice
        {
            get { return _MemPrice; }
            set
            {
                this.OnPropertyValueChange("MemPrice");
                this._MemPrice = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Factorge")]
        public decimal? Factorge
        {
            get { return _Factorge; }
            set
            {
                this.OnPropertyValueChange("Factorge");
                this._Factorge = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Postage")]
        public decimal? Postage
        {
            get { return _Postage; }
            set
            {
                this.OnPropertyValueChange("Postage");
                this._Postage = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ValidDays")]
        public int? ValidDays
        {
            get { return _ValidDays; }
            set
            {
                this.OnPropertyValueChange("ValidDays");
                this._ValidDays = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DeleteState")]
        public int? DeleteState
        {
            get { return _DeleteState; }
            set
            {
                this.OnPropertyValueChange("DeleteState");
                this._DeleteState = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("OxunID")]
        public int? OxunID
        {
            get { return _OxunID; }
            set
            {
                this.OnPropertyValueChange("OxunID");
                this._OxunID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("TotalNum")]
        public int? TotalNum
        {
            get { return _TotalNum; }
            set
            {
                this.OnPropertyValueChange("TotalNum");
                this._TotalNum = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("SaleNum")]
        public int? SaleNum
        {
            get { return _SaleNum; }
            set
            {
                this.OnPropertyValueChange("SaleNum");
                this._SaleNum = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetailerType")]
        public int? RetailerType
        {
            get { return _RetailerType; }
            set
            {
                this.OnPropertyValueChange("RetailerType");
                this._RetailerType = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("BuyStartTime")]
        public DateTime? BuyStartTime
        {
            get { return _BuyStartTime; }
            set
            {
                this.OnPropertyValueChange("BuyStartTime");
                this._BuyStartTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("BuyEndTime")]
        public DateTime? BuyEndTime
        {
            get { return _BuyEndTime; }
            set
            {
                this.OnPropertyValueChange("BuyEndTime");
                this._BuyEndTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ValidStatTime")]
        public DateTime? ValidStatTime
        {
            get { return _ValidStatTime; }
            set
            {
                this.OnPropertyValueChange("ValidStatTime");
                this._ValidStatTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ValidEndTime")]
        public DateTime? ValidEndTime
        {
            get { return _ValidEndTime; }
            set
            {
                this.OnPropertyValueChange("ValidEndTime");
                this._ValidEndTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("MaxCount")]
        public int? MaxCount
        {
            get { return _MaxCount; }
            set
            {
                this.OnPropertyValueChange("MaxCount");
                this._MaxCount = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Cycle")]
        public int? Cycle
        {
            get { return _Cycle; }
            set
            {
                this.OnPropertyValueChange("Cycle");
                this._Cycle = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("CycleType")]
        public int? CycleType
        {
            get { return _CycleType; }
            set
            {
                this.OnPropertyValueChange("CycleType");
                this._CycleType = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetailerCycle")]
        public int? RetailerCycle
        {
            get { return _RetailerCycle; }
            set
            {
                this.OnPropertyValueChange("RetailerCycle");
                this._RetailerCycle = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetailerMaxCount")]
        public int? RetailerMaxCount
        {
            get { return _RetailerMaxCount; }
            set
            {
                this.OnPropertyValueChange("RetailerMaxCount");
                this._RetailerMaxCount = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AutoConfirmDay")]
        public int? AutoConfirmDay
        {
            get { return _AutoConfirmDay; }
            set
            {
                this.OnPropertyValueChange("AutoConfirmDay");
                this._AutoConfirmDay = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("OneFee")]
        public decimal? OneFee
        {
            get { return _OneFee; }
            set
            {
                this.OnPropertyValueChange("OneFee");
                this._OneFee = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Fee")]
        public decimal? Fee
        {
            get { return _Fee; }
            set
            {
                this.OnPropertyValueChange("Fee");
                this._Fee = value;
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        [Field("Sort")]
        public int? Sort
        {
            get { return _Sort; }
            set
            {
                this.OnPropertyValueChange("Sort");
                this._Sort = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ConsumeType")]
        public int? ConsumeType
        {
            get { return _ConsumeType; }
            set
            {
                this.OnPropertyValueChange("ConsumeType");
                this._ConsumeType = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("CashKickback")]
        public decimal? CashKickback
        {
            get { return _CashKickback; }
            set
            {
                this.OnPropertyValueChange("CashKickback");
                this._CashKickback = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("PayoffState")]
        public int? PayoffState
        {
            get { return _PayoffState; }
            set
            {
                this.OnPropertyValueChange("PayoffState");
                this._PayoffState = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("FastState")]
        public int? FastState
        {
            get { return _FastState; }
            set
            {
                this.OnPropertyValueChange("FastState");
                this._FastState = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Dispatching")]
        public string Dispatching
        {
            get { return _Dispatching; }
            set
            {
                this.OnPropertyValueChange("Dispatching");
                this._Dispatching = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Instruction")]
        public string Instruction
        {
            get { return _Instruction; }
            set
            {
                this.OnPropertyValueChange("Instruction");
                this._Instruction = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Location")]
        public string Location
        {
            get { return _Location; }
            set
            {
                this.OnPropertyValueChange("Location");
                this._Location = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Express")]
        public int? Express
        {
            get { return _Express; }
            set
            {
                this.OnPropertyValueChange("Express");
                this._Express = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("GoodsKG")]
        public decimal? GoodsKG
        {
            get { return _GoodsKG; }
            set
            {
                this.OnPropertyValueChange("GoodsKG");
                this._GoodsKG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("GoodsM3")]
        public decimal? GoodsM3
        {
            get { return _GoodsM3; }
            set
            {
                this.OnPropertyValueChange("GoodsM3");
                this._GoodsM3 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("GpsAddress")]
        public string GpsAddress
        {
            get { return _GpsAddress; }
            set
            {
                this.OnPropertyValueChange("GpsAddress");
                this._GpsAddress = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("GpsLat")]
        public string GpsLat
        {
            get { return _GpsLat; }
            set
            {
                this.OnPropertyValueChange("GpsLat");
                this._GpsLat = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("GpsLng")]
        public string GpsLng
        {
            get { return _GpsLng; }
            set
            {
                this.OnPropertyValueChange("GpsLng");
                this._GpsLng = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ColorEnable")]
        public int? ColorEnable
        {
            get { return _ColorEnable; }
            set
            {
                this.OnPropertyValueChange("ColorEnable");
                this._ColorEnable = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Color")]
        public string Color
        {
            get { return _Color; }
            set
            {
                this.OnPropertyValueChange("Color");
                this._Color = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("SizeEnable")]
        public int? SizeEnable
        {
            get { return _SizeEnable; }
            set
            {
                this.OnPropertyValueChange("SizeEnable");
                this._SizeEnable = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Size")]
        public string Size
        {
            get { return _Size; }
            set
            {
                this.OnPropertyValueChange("Size");
                this._Size = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetOnlyEnable")]
        public int? RetOnlyEnable
        {
            get { return _RetOnlyEnable; }
            set
            {
                this.OnPropertyValueChange("RetOnlyEnable");
                this._RetOnlyEnable = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetOnlyID")]
        public int? RetOnlyID
        {
            get { return _RetOnlyID; }
            set
            {
                this.OnPropertyValueChange("RetOnlyID");
                this._RetOnlyID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("RetOnlyName")]
        public string RetOnlyName
        {
            get { return _RetOnlyName; }
            set
            {
                this.OnPropertyValueChange("RetOnlyName");
                this._RetOnlyName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("TwoFee")]
        public decimal? TwoFee
        {
            get { return _TwoFee; }
            set
            {
                this.OnPropertyValueChange("TwoFee");
                this._TwoFee = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("SubsidyEnable")]
        public int? SubsidyEnable
        {
            get { return _SubsidyEnable; }
            set
            {
                this.OnPropertyValueChange("SubsidyEnable");
                this._SubsidyEnable = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("SubsidyRetID")]
        public int? SubsidyRetID
        {
            get { return _SubsidyRetID; }
            set
            {
                this.OnPropertyValueChange("SubsidyRetID");
                this._SubsidyRetID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("SubsidyRetName")]
        public string SubsidyRetName
        {
            get { return _SubsidyRetName; }
            set
            {
                this.OnPropertyValueChange("SubsidyRetName");
                this._SubsidyRetName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("SubsidyCash")]
        public decimal? SubsidyCash
        {
            get { return _SubsidyCash; }
            set
            {
                this.OnPropertyValueChange("SubsidyCash");
                this._SubsidyCash = value;
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
                _.Id,
            };
        }
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.Id;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.Id,
                _.OXunGoodsName,
                _.RetailerID,
                _.RetailerName,
                _.IndustryCode,
                _.IndustryCode2,
                _.BussAreaCode,
                _.ConsumeIntegal,
                _.CreateTime,
                _.UpdateTime,
                _.OXunGoodsState,
                _.Describe,
                _.RetailerAdd,
                _.GoodsImage,
                _.GoodsType,
                _.Price,
                _.MemPrice,
                _.Factorge,
                _.Postage,
                _.ValidDays,
                _.DeleteState,
                _.OxunID,
                _.TotalNum,
                _.SaleNum,
                _.RetailerType,
                _.BuyStartTime,
                _.BuyEndTime,
                _.ValidStatTime,
                _.ValidEndTime,
                _.MaxCount,
                _.Cycle,
                _.CycleType,
                _.RetailerCycle,
                _.RetailerMaxCount,
                _.AutoConfirmDay,
                _.OneFee,
                _.Fee,
                _.Sort,
                _.ConsumeType,
                _.CashKickback,
                _.PayoffState,
                _.FastState,
                _.Dispatching,
                _.Instruction,
                _.Location,
                _.Express,
                _.GoodsKG,
                _.GoodsM3,
                _.GpsAddress,
                _.GpsLat,
                _.GpsLng,
                _.ColorEnable,
                _.Color,
                _.SizeEnable,
                _.Size,
                _.RetOnlyEnable,
                _.RetOnlyID,
                _.RetOnlyName,
                _.TwoFee,
                _.SubsidyEnable,
                _.SubsidyRetID,
                _.SubsidyRetName,
                _.SubsidyCash,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Id,
                this._OXunGoodsName,
                this._RetailerID,
                this._RetailerName,
                this._IndustryCode,
                this._IndustryCode2,
                this._BussAreaCode,
                this._ConsumeIntegal,
                this._CreateTime,
                this._UpdateTime,
                this._OXunGoodsState,
                this._Describe,
                this._RetailerAdd,
                this._GoodsImage,
                this._GoodsType,
                this._Price,
                this._MemPrice,
                this._Factorge,
                this._Postage,
                this._ValidDays,
                this._DeleteState,
                this._OxunID,
                this._TotalNum,
                this._SaleNum,
                this._RetailerType,
                this._BuyStartTime,
                this._BuyEndTime,
                this._ValidStatTime,
                this._ValidEndTime,
                this._MaxCount,
                this._Cycle,
                this._CycleType,
                this._RetailerCycle,
                this._RetailerMaxCount,
                this._AutoConfirmDay,
                this._OneFee,
                this._Fee,
                this._Sort,
                this._ConsumeType,
                this._CashKickback,
                this._PayoffState,
                this._FastState,
                this._Dispatching,
                this._Instruction,
                this._Location,
                this._Express,
                this._GoodsKG,
                this._GoodsM3,
                this._GpsAddress,
                this._GpsLat,
                this._GpsLng,
                this._ColorEnable,
                this._Color,
                this._SizeEnable,
                this._Size,
                this._RetOnlyEnable,
                this._RetOnlyID,
                this._RetOnlyName,
                this._TwoFee,
                this._SubsidyEnable,
                this._SubsidyRetID,
                this._SubsidyRetName,
                this._SubsidyCash,
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
            public readonly static Field All = new Field("*", "B_OXunGoods");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OXunGoodsName = new Field("OXunGoodsName", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetailerID = new Field("RetailerID", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetailerName = new Field("RetailerName", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IndustryCode = new Field("IndustryCode", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IndustryCode2 = new Field("IndustryCode2", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BussAreaCode = new Field("BussAreaCode", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ConsumeIntegal = new Field("ConsumeIntegal", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OXunGoodsState = new Field("OXunGoodsState", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Describe = new Field("Describe", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetailerAdd = new Field("RetailerAdd", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GoodsImage = new Field("GoodsImage", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GoodsType = new Field("GoodsType", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Price = new Field("Price", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MemPrice = new Field("MemPrice", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Factorge = new Field("Factorge", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Postage = new Field("Postage", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ValidDays = new Field("ValidDays", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DeleteState = new Field("DeleteState", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OxunID = new Field("OxunID", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TotalNum = new Field("TotalNum", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SaleNum = new Field("SaleNum", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetailerType = new Field("RetailerType", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BuyStartTime = new Field("BuyStartTime", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field BuyEndTime = new Field("BuyEndTime", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ValidStatTime = new Field("ValidStatTime", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ValidEndTime = new Field("ValidEndTime", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MaxCount = new Field("MaxCount", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Cycle = new Field("Cycle", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CycleType = new Field("CycleType", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetailerCycle = new Field("RetailerCycle", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetailerMaxCount = new Field("RetailerMaxCount", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AutoConfirmDay = new Field("AutoConfirmDay", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OneFee = new Field("OneFee", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Fee = new Field("Fee", "B_OXunGoods", "");
            /// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort", "B_OXunGoods", "排序");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ConsumeType = new Field("ConsumeType", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CashKickback = new Field("CashKickback", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PayoffState = new Field("PayoffState", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FastState = new Field("FastState", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Dispatching = new Field("Dispatching", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Instruction = new Field("Instruction", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Location = new Field("Location", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Express = new Field("Express", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GoodsKG = new Field("GoodsKG", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GoodsM3 = new Field("GoodsM3", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GpsAddress = new Field("GpsAddress", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GpsLat = new Field("GpsLat", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field GpsLng = new Field("GpsLng", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ColorEnable = new Field("ColorEnable", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Color = new Field("Color", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SizeEnable = new Field("SizeEnable", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Size = new Field("Size", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetOnlyEnable = new Field("RetOnlyEnable", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetOnlyID = new Field("RetOnlyID", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RetOnlyName = new Field("RetOnlyName", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TwoFee = new Field("TwoFee", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SubsidyEnable = new Field("SubsidyEnable", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SubsidyRetID = new Field("SubsidyRetID", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SubsidyRetName = new Field("SubsidyRetName", "B_OXunGoods", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SubsidyCash = new Field("SubsidyCash", "B_OXunGoods", "");
        }
        #endregion
    }
}