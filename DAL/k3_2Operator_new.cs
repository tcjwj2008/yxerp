using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace yinxiang.DAL
{
	/// <summary>
	/// 数据访问类:k3_2Operator_new
	/// </summary>
	public partial class k3_2Operator_new
	{
		public k3_2Operator_new()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserID", "k3_2Operator_new"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OperatorName,int UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from k3_2Operator_new");
			strSql.Append(" where OperatorName=@OperatorName and UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4)			};
			parameters[0].Value = OperatorName;
			parameters[1].Value = UserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(yinxiang.Model.k3_2Operator_new model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into k3_2Operator_new(");
			strSql.Append("OperatorName,PassWord,IsAdmin,Note)");
			strSql.Append(" values (");
			strSql.Append("@OperatorName,@PassWord,@IsAdmin,@Note)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@PassWord", SqlDbType.VarChar,20),
					new SqlParameter("@IsAdmin", SqlDbType.VarChar,20),
					new SqlParameter("@Note", SqlDbType.VarChar,200)};
			parameters[0].Value = model.OperatorName;
			parameters[1].Value = model.PassWord;
			parameters[2].Value = model.IsAdmin;
			parameters[3].Value = model.Note;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(yinxiang.Model.k3_2Operator_new model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update k3_2Operator_new set ");
			strSql.Append("PassWord=@PassWord,");
			strSql.Append("IsAdmin=@IsAdmin,");
			strSql.Append("Note=@Note");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@PassWord", SqlDbType.VarChar,20),
					new SqlParameter("@IsAdmin", SqlDbType.VarChar,20),
					new SqlParameter("@Note", SqlDbType.VarChar,200),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.PassWord;
			parameters[1].Value = model.IsAdmin;
			parameters[2].Value = model.Note;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.OperatorName;

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
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from k3_2Operator_new ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

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
		public bool Delete(string OperatorName,int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from k3_2Operator_new ");
			strSql.Append(" where OperatorName=@OperatorName and UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4)			};
			parameters[0].Value = OperatorName;
			parameters[1].Value = UserID;

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
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from k3_2Operator_new ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
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
		public yinxiang.Model.k3_2Operator_new GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,OperatorName,PassWord,IsAdmin,Note from k3_2Operator_new ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			yinxiang.Model.k3_2Operator_new model=new yinxiang.Model.k3_2Operator_new();
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
		public yinxiang.Model.k3_2Operator_new DataRowToModel(DataRow row)
		{
			yinxiang.Model.k3_2Operator_new model=new yinxiang.Model.k3_2Operator_new();
			if (row != null)
			{
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["OperatorName"]!=null)
				{
					model.OperatorName=row["OperatorName"].ToString();
				}
				if(row["PassWord"]!=null)
				{
					model.PassWord=row["PassWord"].ToString();
				}
				if(row["IsAdmin"]!=null)
				{
					model.IsAdmin=row["IsAdmin"].ToString();
				}
				if(row["Note"]!=null)
				{
					model.Note=row["Note"].ToString();
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
			strSql.Append("select UserID,OperatorName,PassWord,IsAdmin,Note ");
			strSql.Append(" FROM k3_2Operator_new ");
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
			strSql.Append(" UserID,OperatorName,PassWord,IsAdmin,Note ");
			strSql.Append(" FROM k3_2Operator_new ");
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
			strSql.Append("select count(1) FROM k3_2Operator_new ");
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
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from k3_2Operator_new T ");
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
			parameters[0].Value = "k3_2Operator_new";
			parameters[1].Value = "UserID";
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

