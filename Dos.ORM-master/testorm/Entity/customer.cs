﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
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
    /// 实体类customer。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("customer")]
    [Serializable]
    public partial class customer : Entity
    {
        #region Model
		private string _name;
		private int _id;
		private int? _age;
		private string _tel;
		private string _email;
		private string _inputer;
		private string _updater;
		private DateTime? _input_tm;
		private DateTime? _update_tm;

		/// <summary>
		/// 
		/// </summary>
		[Field("name")]
		public string name
		{
			get{ return _name; }
			set
			{
				this.OnPropertyValueChange("name");
				this._name = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("id")]
		public int id
		{
			get{ return _id; }
			set
			{
				this.OnPropertyValueChange("id");
				this._id = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("age")]
		public int? age
		{
			get{ return _age; }
			set
			{
				this.OnPropertyValueChange("age");
				this._age = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("tel")]
		public string tel
		{
			get{ return _tel; }
			set
			{
				this.OnPropertyValueChange("tel");
				this._tel = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("email")]
		public string email
		{
			get{ return _email; }
			set
			{
				this.OnPropertyValueChange("email");
				this._email = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("inputer")]
		public string inputer
		{
			get{ return _inputer; }
			set
			{
				this.OnPropertyValueChange("inputer");
				this._inputer = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("updater")]
		public string updater
		{
			get{ return _updater; }
			set
			{
				this.OnPropertyValueChange("updater");
				this._updater = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("input_tm")]
		public DateTime? input_tm
		{
			get{ return _input_tm; }
			set
			{
				this.OnPropertyValueChange("input_tm");
				this._input_tm = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("update_tm")]
		public DateTime? update_tm
		{
			get{ return _update_tm; }
			set
			{
				this.OnPropertyValueChange("update_tm");
				this._update_tm = value;
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
				_.id,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.name,
				_.id,
				_.age,
				_.tel,
				_.email,
				_.inputer,
				_.updater,
				_.input_tm,
				_.update_tm,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._name,
				this._id,
				this._age,
				this._tel,
				this._email,
				this._inputer,
				this._updater,
				this._input_tm,
				this._update_tm,
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
			public readonly static Field All = new Field("*", "customer");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field name = new Field("name", "customer", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "customer", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field age = new Field("age", "customer", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field tel = new Field("tel", "customer", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field email = new Field("email", "customer", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field inputer = new Field("inputer", "customer", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field updater = new Field("updater", "customer", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field input_tm = new Field("input_tm", "customer", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field update_tm = new Field("update_tm", "customer", "");
        }
        #endregion
	}
}