using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Maticsoft.DBUtility;

namespace yinxiang.BLL
{
   public class frmYXCKreport
    {

       public static DataSet frmYXCKreportDO(string BegDate)
        {
            DataSet ds = new DataSet();
            SqlParameter[] parameters = {			 
			 			 new SqlParameter("@FBeginDate", SqlDbType.VarChar,50)
			 			 };
            parameters[0].Value = BegDate;

            DbHelperSQLP DbHelperSQLP = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString_DZP"));
            ds =    DbHelperSQLP.RunProcedure("sp_DzpChuiKuanBiao_czq_2018_qiu", parameters, "test");
            return ds;
        }
   
    }
}
