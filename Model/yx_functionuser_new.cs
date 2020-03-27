using System;
namespace yinxiang.Model
{
	/// <summary>
	/// yx_functionuser_new:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class yx_functionuser_new
	{
		public yx_functionuser_new()
		{}
		#region Model
		private string _userid;
		private string _username;
		private string _functionid;
		private string _functionname;
		/// <summary>
		/// 
		/// </summary>
		public string userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FUNCTIONID
		{
			set{ _functionid=value;}
			get{return _functionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string functionname
		{
			set{ _functionname=value;}
			get{return _functionname;}
		}
		#endregion Model

	}
}

