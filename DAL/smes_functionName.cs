using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace yinxiang.DAL
{
	/// <summary>
	/// 数据访问类:smes_functionName
	/// </summary>
	public partial class smes_functionName
	{
		public smes_functionName()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(yinxiang.Model.smes_functionName model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into smes_functionName(");
			strSql.Append("orgId,functionName,functionPath,functionGroup,creater,useNum,lastUser,lastUseDate,memo,functioncode)");
			strSql.Append(" values (");
			strSql.Append("@orgId,@functionName,@functionPath,@functionGroup,@creater,@useNum,@lastUser,@lastUseDate,@memo,@functioncode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@orgId", SqlDbType.VarChar,50),
					new SqlParameter("@functionName", SqlDbType.VarChar,50),
					new SqlParameter("@functionPath", SqlDbType.VarChar,250),
					new SqlParameter("@functionGroup", SqlDbType.VarChar,50),
					new SqlParameter("@creater", SqlDbType.VarChar,50),
					new SqlParameter("@useNum", SqlDbType.BigInt,8),
					new SqlParameter("@lastUser", SqlDbType.VarChar,50),
					new SqlParameter("@lastUseDate", SqlDbType.VarChar,50),
					new SqlParameter("@memo", SqlDbType.VarChar,500),
					new SqlParameter("@functioncode", SqlDbType.VarChar,50)};
			parameters[0].Value = model.orgId;
			parameters[1].Value = model.functionName;
			parameters[2].Value = model.functionPath;
			parameters[3].Value = model.functionGroup;
			parameters[4].Value = model.creater;
			parameters[5].Value = model.useNum;
			parameters[6].Value = model.lastUser;
			parameters[7].Value = model.lastUseDate;
			parameters[8].Value = model.memo;
			parameters[9].Value = model.functioncode;

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
		public bool Update(yinxiang.Model.smes_functionName model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update smes_functionName set ");
			strSql.Append("orgId=@orgId,");
			strSql.Append("functionName=@functionName,");
			strSql.Append("functionPath=@functionPath,");
			strSql.Append("functionGroup=@functionGroup,");
			strSql.Append("creater=@creater,");
			strSql.Append("useNum=@useNum,");
			strSql.Append("lastUser=@lastUser,");
			strSql.Append("lastUseDate=@lastUseDate,");
			strSql.Append("memo=@memo,");
			strSql.Append("functioncode=@functioncode");
			strSql.Append(" where functionid=@functionid");
			SqlParameter[] parameters = {
					new SqlParameter("@orgId", SqlDbType.VarChar,50),
					new SqlParameter("@functionName", SqlDbType.VarChar,50),
					new SqlParameter("@functionPath", SqlDbType.VarChar,250),
					new SqlParameter("@functionGroup", SqlDbType.VarChar,50),
					new SqlParameter("@creater", SqlDbType.VarChar,50),
					new SqlParameter("@useNum", SqlDbType.BigInt,8),
					new SqlParameter("@lastUser", SqlDbType.VarChar,50),
					new SqlParameter("@lastUseDate", SqlDbType.VarChar,50),
					new SqlParameter("@memo", SqlDbType.VarChar,500),
					new SqlParameter("@functioncode", SqlDbType.VarChar,50),
					new SqlParameter("@functionid", SqlDbType.BigInt,8)};
			parameters[0].Value = model.orgId;
			parameters[1].Value = model.functionName;
			parameters[2].Value = model.functionPath;
			parameters[3].Value = model.functionGroup;
			parameters[4].Value = model.creater;
			parameters[5].Value = model.useNum;
			parameters[6].Value = model.lastUser;
			parameters[7].Value = model.lastUseDate;
			parameters[8].Value = model.memo;
			parameters[9].Value = model.functioncode;
			parameters[10].Value = model.functionid;

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
			strSql.Append("delete from smes_functionName ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string functionidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from smes_functionName ");
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
		public yinxiang.Model.smes_functionName GetModel(long functionid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 functionid,orgId,functionName,functionPath,functionGroup,creater,useNum,lastUser,lastUseDate,memo,functioncode from smes_functionName ");
			strSql.Append(" where functionid=@functionid");
			SqlParameter[] parameters = {
					new SqlParameter("@functionid", SqlDbType.BigInt)
			};
			parameters[0].Value = functionid;

			yinxiang.Model.smes_functionName model=new yinxiang.Model.smes_functionName();
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
		public yinxiang.Model.smes_functionName DataRowToModel(DataRow row)
		{
			yinxiang.Model.smes_functionName model=new yinxiang.Model.smes_functionName();
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
				if(row["functionName"]!=null)
				{
					model.functionName=row["functionName"].ToString();
				}
				if(row["functionPath"]!=null)
				{
					model.functionPath=row["functionPath"].ToString();
				}
				if(row["functionGroup"]!=null)
				{
					model.functionGroup=row["functionGroup"].ToString();
				}
				if(row["creater"]!=null)
				{
					model.creater=row["creater"].ToString();
				}
				if(row["useNum"]!=null && row["useNum"].ToString()!="")
				{
					model.useNum=long.Parse(row["useNum"].ToString());
				}
				if(row["lastUser"]!=null)
				{
					model.lastUser=row["lastUser"].ToString();
				}
				if(row["lastUseDate"]!=null)
				{
					model.lastUseDate=row["lastUseDate"].ToString();
				}
				if(row["memo"]!=null)
				{
					model.memo=row["memo"].ToString();
				}
				if(row["functioncode"]!=null)
				{
					model.functioncode=row["functioncode"].ToString();
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
			strSql.Append("select functionid,orgId,functionName,functionPath,functionGroup,creater,useNum,lastUser,lastUseDate,memo,functioncode ");
			strSql.Append(" FROM smes_functionName ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_New(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TOP 1000 smes_functionName_new.functionid ,orgId 产业公司 ,functionGroup  ,functionCode    ,smes_functionName_new.functionName  功能名称 ,functionPath  as MediaTypeId  ,memo");
            strSql.Append(" FROM YXERP.dbo.smes_functionName_new inner join yx_functionuser_new on   yx_functionuser_new.functionid=smes_functionName_new.functioncode");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append(" order by smes_functionName_new.orgId,smes_functionName_new.functionGroup,smes_functionName_new.functioncode");
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
			strSql.Append(" functionid,orgId,functionName,functionPath,functionGroup,creater,useNum,lastUser,lastUseDate,memo,functioncode ");
			strSql.Append(" FROM smes_functionName ");
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
			strSql.Append("select count(1) FROM smes_functionName ");
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
			strSql.Append(")AS Row, T.*  from smes_functionName T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

        
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
            parameters[0].Value = "smes_functionName";
            parameters[1].Value = "functionid";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

