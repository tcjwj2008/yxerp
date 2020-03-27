using System;
namespace yinxiang.Model
{
	/// <summary>
	/// smes_functionName_new:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class smes_functionName_new
	{
		public smes_functionName_new()
		{}
		#region Model
		private long _functionid;
		private string _orgid;
		private string _functiongroup;
		private string _functioncode;
		private string _functionname;
		private string _functionpath;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public long functionid
		{
			set{ _functionid=value;}
			get{return _functionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orgId
		{
			set{ _orgid=value;}
			get{return _orgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string functionGroup
		{
			set{ _functiongroup=value;}
			get{return _functiongroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string functionCode
		{
			set{ _functioncode=value;}
			get{return _functioncode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string functionName
		{
			set{ _functionname=value;}
			get{return _functionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string functionPath
		{
			set{ _functionpath=value;}
			get{return _functionpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		#endregion Model

	}
}

