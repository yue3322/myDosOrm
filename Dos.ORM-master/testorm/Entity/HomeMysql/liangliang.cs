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
    /// 实体类liangliang。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("liangliang")]
    [Serializable]
    public partial class liangliang : Entity
    {
        #region Model
		private int _id;
		private string _title;
		private DateTime? _time;
		private string _url;
		private string _html;

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
		[Field("title")]
		public string title
		{
			get{ return _title; }
			set
			{
				this.OnPropertyValueChange("title");
				this._title = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("time")]
		public DateTime? time
		{
			get{ return _time; }
			set
			{
				this.OnPropertyValueChange("time");
				this._time = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("url")]
		public string url
		{
			get{ return _url; }
			set
			{
				this.OnPropertyValueChange("url");
				this._url = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("html")]
		public string html
		{
			get{ return _html; }
			set
			{
				this.OnPropertyValueChange("html");
				this._html = value;
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
				_.id,
				_.title,
				_.time,
				_.url,
				_.html,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._id,
				this._title,
				this._time,
				this._url,
				this._html,
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
			public readonly static Field All = new Field("*", "liangliang");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "liangliang", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field title = new Field("title", "liangliang", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field time = new Field("time", "liangliang", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field url = new Field("url", "liangliang", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field html = new Field("html", "liangliang", "");
        }
        #endregion
	}
}