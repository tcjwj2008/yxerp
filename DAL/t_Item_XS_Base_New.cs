using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace yinxiang.DAL
{
	/// <summary>
	/// 数据访问类:t_Item_XS_Base_New
	/// </summary>
	public partial class t_Item_XS_Base_New
	{
		public t_Item_XS_Base_New()
		{}
		#region  BasicMethod
        DbHelperSQLP DbHelperSQLP = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString_RY"));


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(yinxiang.Model.t_Item_XS_Base_New model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_Item_XS_Base_New(");
			strSql.Append("产品代码,产品名称,肉品系数,人工系数,车间类别,备注,OrderID,气调系数)");
			strSql.Append(" values (");
			strSql.Append("@产品代码,@产品名称,@肉品系数,@人工系数,@车间类别,@备注,@OrderID,@气调系数)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@产品代码", SqlDbType.VarChar,100),
					new SqlParameter("@产品名称", SqlDbType.VarChar,100),
					new SqlParameter("@肉品系数", SqlDbType.Float,8),
					new SqlParameter("@人工系数", SqlDbType.Float,8),
					new SqlParameter("@车间类别", SqlDbType.VarChar,50),
					new SqlParameter("@备注", SqlDbType.VarChar,500),
					new SqlParameter("@OrderID", SqlDbType.Float,8),
					new SqlParameter("@气调系数", SqlDbType.Float,8)};
			parameters[0].Value = model.产品代码;
			parameters[1].Value = model.产品名称;
			parameters[2].Value = model.肉品系数;
			parameters[3].Value = model.人工系数;
			parameters[4].Value = model.车间类别;
			parameters[5].Value = model.备注;
			parameters[6].Value = model.OrderID;
			parameters[7].Value = model.气调系数;


           // string A = PubConstant.GetConnectionString("ConnectionString_RY");
           // DbHelperSQLP DbHelperSQLP = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString_RY"));
            object obj = DbHelperSQLP.GetSingle(strSql.ToString(), parameters);
            //取代默认的ERP数据库20200119
			//object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(yinxiang.Model.t_Item_XS_Base_New model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_Item_XS_Base_New set ");
			strSql.Append("产品代码=@产品代码,");
			strSql.Append("产品名称=@产品名称,");
			strSql.Append("肉品系数=@肉品系数,");
			strSql.Append("人工系数=@人工系数,");
			strSql.Append("车间类别=@车间类别,");
			strSql.Append("备注=@备注,");
			strSql.Append("OrderID=@OrderID,");
			strSql.Append("气调系数=@气调系数");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@产品代码", SqlDbType.VarChar,100),
					new SqlParameter("@产品名称", SqlDbType.VarChar,100),
					new SqlParameter("@肉品系数", SqlDbType.Float,8),
					new SqlParameter("@人工系数", SqlDbType.Float,8),
					new SqlParameter("@车间类别", SqlDbType.VarChar,50),
					new SqlParameter("@备注", SqlDbType.VarChar,500),
					new SqlParameter("@OrderID", SqlDbType.Float,8),
					new SqlParameter("@气调系数", SqlDbType.Float,8),
					new SqlParameter("@FID", SqlDbType.Int,4)};
			parameters[0].Value = model.产品代码;
			parameters[1].Value = model.产品名称;
			parameters[2].Value = model.肉品系数;
			parameters[3].Value = model.人工系数;
			parameters[4].Value = model.车间类别;
			parameters[5].Value = model.备注;
			parameters[6].Value = model.OrderID;
			parameters[7].Value = model.气调系数;
			parameters[8].Value = model.FID;


            //DbHelperSQLP DbHelperSQLP = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString_RY"));
            int rows = DbHelperSQLP.ExecuteSql(strSql.ToString(), parameters);
			//int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_Item_XS_Base_New ");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@FID", SqlDbType.Int,4)
			};
			parameters[0].Value = FID;
           
            //int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

			int rows=DbHelperSQLP.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string FIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_Item_XS_Base_New ");
			strSql.Append(" where FID in ("+FIDlist + ")  ");

            int rows = DbHelperSQLP.ExecuteSql(strSql.ToString());
			//int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public yinxiang.Model.t_Item_XS_Base_New GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 产品代码,产品名称,肉品系数,人工系数,车间类别,FID,备注,OrderID,气调系数 from t_Item_XS_Base_New ");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@FID", SqlDbType.Int,4)
			};
			parameters[0].Value = FID;

			yinxiang.Model.t_Item_XS_Base_New model=new yinxiang.Model.t_Item_XS_Base_New();

            DataSet ds = DbHelperSQLP.Query(strSql.ToString(), parameters);
			//DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		public yinxiang.Model.t_Item_XS_Base_New DataRowToModel(DataRow row)
		{
			yinxiang.Model.t_Item_XS_Base_New model=new yinxiang.Model.t_Item_XS_Base_New();
			if (row != null)
			{
				if(row["产品代码"]!=null)
				{
					model.产品代码=row["产品代码"].ToString();
				}
				if(row["产品名称"]!=null)
				{
					model.产品名称=row["产品名称"].ToString();
				}
				if(row["肉品系数"]!=null && row["肉品系数"].ToString()!="")
				{
					model.肉品系数=decimal.Parse(row["肉品系数"].ToString());
				}
				if(row["人工系数"]!=null && row["人工系数"].ToString()!="")
				{
					model.人工系数=decimal.Parse(row["人工系数"].ToString());
				}
				if(row["车间类别"]!=null)
				{
					model.车间类别=row["车间类别"].ToString();
				}
				if(row["FID"]!=null && row["FID"].ToString()!="")
				{
					model.FID=int.Parse(row["FID"].ToString());
				}
				if(row["备注"]!=null)
				{
					model.备注=row["备注"].ToString();
				}
				if(row["OrderID"]!=null && row["OrderID"].ToString()!="")
				{
					model.OrderID=decimal.Parse(row["OrderID"].ToString());
				}
				if(row["气调系数"]!=null && row["气调系数"].ToString()!="")
				{
					model.气调系数=decimal.Parse(row["气调系数"].ToString());
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
			strSql.Append("select 产品代码,产品名称,肉品系数,人工系数,车间类别,FID,备注,OrderID,气调系数 ");
			strSql.Append(" FROM t_Item_XS_Base_New ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLP.Query(strSql.ToString());
            //return DbHelperSQL.Query(strSql.ToString());
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
			strSql.Append(" 产品代码,产品名称,肉品系数,人工系数,车间类别,FID,备注,OrderID,气调系数 ");
			strSql.Append(" FROM t_Item_XS_Base_New ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);

            return DbHelperSQLP.Query(strSql.ToString());
			//return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM t_Item_XS_Base_New ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = DbHelperSQLP.GetSingle(strSql.ToString());
			//object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.FID desc");
			}
			strSql.Append(")AS Row, T.*  from t_Item_XS_Base_New T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            return DbHelperSQLP.Query(strSql.ToString());
			//return DbHelperSQL.Query(strSql.ToString());
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
			parameters[0].Value = "t_Item_XS_Base_New";
			parameters[1].Value = "FID";
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

