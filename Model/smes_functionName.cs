using System;
namespace yinxiang.Model
{
	/// <summary>
	/// smes_functionName:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class smes_functionName
	{
		public smes_functionName()
		{}
		#region Model
		private long _functionid;
		private string _orgid;
		private string _functionname;
		private string _functionpath;
		private string _functiongroup;
		private string _creater;
		private long? _usenum;
		private string _lastuser;
		private string _lastusedate;
		private string _memo;
		private string _functioncode;
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
		public string functionGroup
		{
			set{ _functiongroup=value;}
			get{return _functiongroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string creater
		{
			set{ _creater=value;}
			get{return _creater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? useNum
		{
			set{ _usenum=value;}
			get{return _usenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lastUser
		{
			set{ _lastuser=value;}
			get{return _lastuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lastUseDate
		{
			set{ _lastusedate=value;}
			get{return _lastusedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string functioncode
		{
			set{ _functioncode=value;}
			get{return _functioncode;}
		}
		#endregion Model

	}
}

