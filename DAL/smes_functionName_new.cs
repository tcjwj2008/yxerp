using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace yinxiang.DAL
{
	/// <summary>
	/// 数据访问类:smes_functionName_new
	/// </summary>
	public partial class smes_functionName_new
	{
		public smes_functionName_new()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string functionCode,long functionid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from smes_functionName_new");
			strSql.Append(" where functionCode=@functionCode and functionid=@functionid ");
			SqlParameter[] parameters = {
					new SqlParameter("@functionCode", SqlDbType.VarChar,50),
					new SqlParameter("@functionid", SqlDbType.BigInt,8)			};
			parameters[0].Value = functionCode;
			parameters[1].Value = functionid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(yinxiang.Model.smes_functionName_new model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into smes_functionName_new(");
			strSql.Append("orgId,functionGroup,functionCode,functionName,functionPath,memo)");
			strSql.Append(" values (");
			strSql.Append("@orgId,@functionGroup,@functionCode,@functionName,@functionPath,@memo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@orgId", SqlDbType.VarChar,50),
					new SqlParameter("@functionGroup", SqlDbType.VarChar,50),
					new SqlParameter("@functionCode", SqlDbType.VarChar,50),
					new SqlParameter("@functionName", SqlDbType.VarChar,50),
					new SqlParameter("@functionPath", SqlDbType.VarChar,250),
					new SqlParameter("@memo", SqlDbType.VarChar,500)};
			parameters[0].Value = model.orgId;
			parameters[1].Value = model.functionGroup;
			parameters[2].Value = model.functionCode;
			parameters[3].Value = model.functionName;
			parameters[4].Value = model.functionPath;
			parameters[5].Value = model.memo;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(yinxiang.Model.smes_functionName_new model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update smes_functionName_new set ");
			strSql.Append("orgId=@orgId,");
			strSql.Append("functionGroup=@functionGroup,");
			strSql.Append("functionName=@functionName,");
			strSql.Append("functionPath=@functionPath,");
			strSql.Append("memo=@memo");
			strSql.Append(" where functionid=@functionid");
			SqlParameter[] parameters = {
					new SqlParameter("@orgId", SqlDbType.VarChar,50),
					new SqlParameter("@functionGroup", SqlDbType.VarChar,50),
					new SqlParameter("@functionName", SqlDbType.VarChar,50),
					new SqlParameter("@functionPath", SqlDbType.VarChar,250),
					new SqlParameter("@memo", SqlDbType.VarChar,500),
					new SqlParameter("@functionid", SqlDbType.BigInt,8),
					new SqlParameter("@functionCode", SqlDbType.VarChar,50)};
			parameters[0].Value = model.orgId;
			parameters[1].Value = model.functionGroup;
			parameters[2].Value = model.functionName;
			parameters[3].Value = model.functionPath;
			parameters[4].Value = model.memo;
			parameters[5].Value = model.functionid;
			parameters[6].Value = model.functionCode;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long functionid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from smes_functionName_new ");
			strSql.Append(" where functionid=@functionid");
			SqlParameter[] parameters = {
					new SqlParameter("@functionid", SqlDbType.BigInt)
			};
			parameters[0].Value = functionid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string functionCode,long functionid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from smes_functionName_new ");
			strSql.Append(" where functionCode=@functionCode and functionid=@functionid ");
			SqlParameter[] parameters = {
					new SqlParameter("@functionCode", SqlDbType.VarChar,50),
					new SqlParameter("@functionid", SqlDbType.BigInt,8)			};
			parameters[0].Value = functionCode;
			parameters[1].Value = functionid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string functionidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from smes_functionName_new ");
			strSql.Append(" where functionid in ("+functionidlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public yinxiang.Model.smes_functionName_new GetModel(long functionid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 functionid,orgId,functionGroup,functionCode,functionName,functionPath,memo from smes_functionName_new ");
			strSql.Append(" where functionid=@functionid");
			SqlParameter[] parameters = {
					new SqlParameter("@functionid", SqlDbType.BigInt)
			};
			parameters[0].Value = functionid;

			yinxiang.Model.smes_functionName_new model=new yinxiang.Model.smes_functionName_new();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public yinxiang.Model.smes_functionName_new DataRowToModel(DataRow row)
		{
			yinxiang.Model.smes_functionName_new model=new yinxiang.Model.smes_functionName_new();
			if (row != null)
			{
				if(row["functionid"]!=null && row["functionid"].ToString()!="")
				{
					model.functionid=long.Parse(row["functionid"].ToString());
				}
				if(row["orgId"]!=null)
				{
					model.orgId=row["orgId"].ToString();
				}
				if(row["functionGroup"]!=null)
				{
					model.functionGroup=row["functionGroup"].ToString();
				}
				if(row["functionCode"]!=null)
				{
					model.functionCode=row["functionCode"].ToString();
				}
				if(row["functionName"]!=null)
				{
					model.functionName=row["functionName"].ToString();
				}
				if(row["functionPath"]!=null)
				{
					model.functionPath=row["functionPath"].ToString();
				}
				if(row["memo"]!=null)
				{
					model.memo=row["memo"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select functionid,orgId,functionGroup,functionCode,functionName,functionPath,memo ");
			strSql.Append(" FROM smes_functionName_new ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" functionid,orgId,functionGroup,functionCode,functionName,functionPath,memo ");
			strSql.Append(" FROM smes_functionName_new ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM smes_functionName_new ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.functionid desc");
			}
			strSql.Append(")AS Row, T.*  from smes_functionName_new T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "smes_functionName_new";
			parameters[1].Value = "functionid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

