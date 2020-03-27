using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using yinxiang.Model;
namespace yinxiang.BLL
{
	/// <summary>
	/// smes_functionName
	/// </summary>
	public partial class smes_functionName
	{
		private readonly yinxiang.DAL.smes_functionName dal=new yinxiang.DAL.smes_functionName();
		public smes_functionName()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(yinxiang.Model.smes_functionName model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(yinxiang.Model.smes_functionName model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long functionid)
		{
			
			return dal.Delete(functionid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string functionidlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(functionidlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public yinxiang.Model.smes_functionName GetModel(long functionid)
		{
			
			return dal.GetModel(functionid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public yinxiang.Model.smes_functionName GetModelByCache(long functionid)
		{
			
			string CacheKey = "smes_functionNameModel-" + functionid;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(functionid);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (yinxiang.Model.smes_functionName)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        /// <summary>
        /// 获得功能数据列表
        /// </summary>
        public DataSet GetList_New(string strWhere)
        {
            return dal.GetList_New(strWhere);
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
		public List<yinxiang.Model.smes_functionName> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<yinxiang.Model.smes_functionName> DataTableToList(DataTable dt)
		{
			List<yinxiang.Model.smes_functionName> modelList = new List<yinxiang.Model.smes_functionName>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yinxiang.Model.smes_functionName model;
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

