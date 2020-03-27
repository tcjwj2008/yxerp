using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using yinxiang.Model;
namespace yinxiang.BLL
{
	/// <summary>
	/// t_Item_XS_Base_New
	/// </summary>
	public partial class t_Item_XS_Base_New
	{
		private readonly yinxiang.DAL.t_Item_XS_Base_New dal=new yinxiang.DAL.t_Item_XS_Base_New();
		public t_Item_XS_Base_New()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(yinxiang.Model.t_Item_XS_Base_New model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(yinxiang.Model.t_Item_XS_Base_New model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int FID)
		{
			
			return dal.Delete(FID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string FIDlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(FIDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public yinxiang.Model.t_Item_XS_Base_New GetModel(int FID)
		{
			
			return dal.GetModel(FID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public yinxiang.Model.t_Item_XS_Base_New GetModelByCache(int FID)
		{
			
			string CacheKey = "t_Item_XS_Base_NewModel-" + FID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(FID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (yinxiang.Model.t_Item_XS_Base_New)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<yinxiang.Model.t_Item_XS_Base_New> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<yinxiang.Model.t_Item_XS_Base_New> DataTableToList(DataTable dt)
		{
			List<yinxiang.Model.t_Item_XS_Base_New> modelList = new List<yinxiang.Model.t_Item_XS_Base_New>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yinxiang.Model.t_Item_XS_Base_New model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

