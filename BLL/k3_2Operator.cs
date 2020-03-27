using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using yinxiang.Model;
namespace yinxiang.BLL
{
	/// <summary>
	/// k3_2Operator
	/// </summary>
	public  class k3_2Operator
	{
		private readonly yinxiang.DAL.k3_2Operator dal=new yinxiang.DAL.k3_2Operator();
		public k3_2Operator()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int UserID,string OperatorName)
		{
			return dal.Exists(UserID,OperatorName);
		}

        public bool Exists_new(string OperatorName, string password)
        {
            return dal.Exists_new(OperatorName, password);
        }


		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(yinxiang.Model.k3_2Operator model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(yinxiang.Model.k3_2Operator model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int UserID)
		{
			
			return dal.Delete(UserID);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int UserID,string OperatorName)
		{
			
			return dal.Delete(UserID,OperatorName);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string UserIDlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(UserIDlist,0) );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public yinxiang.Model.k3_2Operator GetModel(int UserID)
		{
			
			return dal.GetModel(UserID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public yinxiang.Model.k3_2Operator GetModelByCache(int UserID)
		{
			
			string CacheKey = "k3_2OperatorModel-" + UserID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(UserID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (yinxiang.Model.k3_2Operator)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<yinxiang.Model.k3_2Operator> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<yinxiang.Model.k3_2Operator> DataTableToList(DataTable dt)
		{
			List<yinxiang.Model.k3_2Operator> modelList = new List<yinxiang.Model.k3_2Operator>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yinxiang.Model.k3_2Operator model;
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
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// ��ҳ��ȡ�����б�
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

