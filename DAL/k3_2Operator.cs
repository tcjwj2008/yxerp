using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace yinxiang.DAL
{
	/// <summary>
	/// ���ݷ�����:k3_2Operator
	/// </summary>
	public partial class k3_2Operator
	{
		public k3_2Operator()
		{}
		#region  BasicMethod
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int UserID,string OperatorName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from k3_2Operator");
			strSql.Append(" where UserID=@UserID and OperatorName=@OperatorName ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50)			};
			parameters[0].Value = UserID;
			parameters[1].Value = OperatorName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}




        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists_new(string OperatorName ,string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from k3_2Operator");
            strSql.Append(" where password=@password and OperatorName=@OperatorName ");
            SqlParameter[] parameters = {
					new SqlParameter("@password", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50)			};
            parameters[0].Value = pwd;
            parameters[1].Value = OperatorName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(yinxiang.Model.k3_2Operator model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into k3_2Operator(");
			strSql.Append("OperatorName,PassWord,IsAdmin,Note)");
			strSql.Append(" values (");
			strSql.Append("@OperatorName,@PassWord,@IsAdmin,@Note)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@PassWord", SqlDbType.VarChar,20),
					new SqlParameter("@IsAdmin", SqlDbType.Char,1),
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
		/// ����һ������
		/// </summary>
		public bool Update(yinxiang.Model.k3_2Operator model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update k3_2Operator set ");
			strSql.Append("PassWord=@PassWord,");
			strSql.Append("IsAdmin=@IsAdmin,");
			strSql.Append("Note=@Note");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@PassWord", SqlDbType.VarChar,20),
					new SqlParameter("@IsAdmin", SqlDbType.Char,1),
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
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from k3_2Operator ");
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
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int UserID,string OperatorName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from k3_2Operator ");
			strSql.Append(" where UserID=@UserID and OperatorName=@OperatorName ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50)			};
			parameters[0].Value = UserID;
			parameters[1].Value = OperatorName;

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
		/// ����ɾ������
		/// </summary>
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from k3_2Operator ");
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
		/// �õ�һ������ʵ��
		/// </summary>
		public yinxiang.Model.k3_2Operator GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,OperatorName,PassWord,IsAdmin,Note from k3_2Operator ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			yinxiang.Model.k3_2Operator model=new yinxiang.Model.k3_2Operator();
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
		/// �õ�һ������ʵ��
		/// </summary>
		public yinxiang.Model.k3_2Operator DataRowToModel(DataRow row)
		{
			yinxiang.Model.k3_2Operator model=new yinxiang.Model.k3_2Operator();
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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select UserID,OperatorName,PassWord,IsAdmin,Note ");
			strSql.Append(" FROM k3_2Operator ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
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
			strSql.Append(" FROM k3_2Operator ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ��ȡ��¼����
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM k3_2Operator ");
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
		/// ��ҳ��ȡ�����б�
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
			strSql.Append(")AS Row, T.*  from k3_2Operator T ");
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
		/// ��ҳ��ȡ�����б�
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
			parameters[0].Value = "k3_2Operator";
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

