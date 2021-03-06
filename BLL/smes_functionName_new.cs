﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using yinxiang.Model;
namespace yinxiang.BLL
{
	/// <summary>
	/// smes_functionName_new
	/// </summary>
	public partial class smes_functionName_new
	{
		private readonly yinxiang.DAL.smes_functionName_new dal=new yinxiang.DAL.smes_functionName_new();
		public smes_functionName_new()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string functionCode,long functionid)
		{
			return dal.Exists(functionCode,functionid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(yinxiang.Model.smes_functionName_new model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(yinxiang.Model.smes_functionName_new model)
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
		public bool Delete(string functionCode,long functionid)
		{
			
			return dal.Delete(functionCode,functionid);
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
		public yinxiang.Model.smes_functionName_new GetModel(long functionid)
		{
			
			return dal.GetModel(functionid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public yinxiang.Model.smes_functionName_new GetModelByCache(long functionid)
		{
			
			string CacheKey = "smes_functionName_newModel-" + functionid;
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
			return (yinxiang.Model.smes_functionName_new)objModel;
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
		public List<yinxiang.Model.smes_functionName_new> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<yinxiang.Model.smes_functionName_new> DataTableToList(DataTable dt)
		{
			List<yinxiang.Model.smes_functionName_new> modelList = new List<yinxiang.Model.smes_functionName_new>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yinxiang.Model.smes_functionName_new model;
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

