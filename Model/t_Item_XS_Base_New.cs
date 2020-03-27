using System;
namespace yinxiang.Model
{
	/// <summary>
	/// t_Item_XS_Base_New:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_Item_XS_Base_New
	{
		public t_Item_XS_Base_New()
		{}
		#region Model
		private string _产品代码;
		private string _产品名称;
		private decimal? _肉品系数;
		private decimal? _人工系数;
		private string _车间类别;
		private int _fid;
		private string _备注;
		private decimal? _orderid;
		private decimal? _气调系数;
		/// <summary>
		/// 
		/// </summary>
		public string 产品代码
		{
			set{ _产品代码=value;}
			get{return _产品代码;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 产品名称
		{
			set{ _产品名称=value;}
			get{return _产品名称;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 肉品系数
		{
			set{ _肉品系数=value;}
			get{return _肉品系数;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 人工系数
		{
			set{ _人工系数=value;}
			get{return _人工系数;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 车间类别
		{
			set{ _车间类别=value;}
			get{return _车间类别;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FID
		{
			set{ _fid=value;}
			get{return _fid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 备注
		{
			set{ _备注=value;}
			get{return _备注;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 气调系数
		{
			set{ _气调系数=value;}
			get{return _气调系数;}
		}
		#endregion Model

	}
}

