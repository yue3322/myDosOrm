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
    /// 实体类Container_number。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Container_number")]
    [Serializable]
    public partial class Container_number : Entity
    {
        #region Model
		private string _pre_entry_id;
		private string _order_no;
		private string _container_no;
		private string _container_model;
		private string _container_wt;

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
		[Field("order_no")]
		public string order_no
		{
			get{ return _order_no; }
			set
			{
				this.OnPropertyValueChange("order_no");
				this._order_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("container_no")]
		public string container_no
		{
			get{ return _container_no; }
			set
			{
				this.OnPropertyValueChange("container_no");
				this._container_no = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("container_model")]
		public string container_model
		{
			get{ return _container_model; }
			set
			{
				this.OnPropertyValueChange("container_model");
				this._container_model = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("container_wt")]
		public string container_wt
		{
			get{ return _container_wt; }
			set
			{
				this.OnPropertyValueChange("container_wt");
				this._container_wt = value;
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
				_.pre_entry_id,
				_.order_no,
				_.container_no,
				_.container_model,
				_.container_wt,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._pre_entry_id,
				this._order_no,
				this._container_no,
				this._container_model,
				this._container_wt,
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
			public readonly static Field All = new Field("*", "Container_number");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field pre_entry_id = new Field("pre_entry_id", "Container_number", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field order_no = new Field("order_no", "Container_number", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field container_no = new Field("container_no", "Container_number", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field container_model = new Field("container_model", "Container_number", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field container_wt = new Field("container_wt", "Container_number", "");
        }
        #endregion
	}
}