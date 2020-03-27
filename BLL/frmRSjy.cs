using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Maticsoft.DBUtility;


namespace yinxiang.BLL
{
   public class frmRSjy
    {
      
        public static DataSet sp_sel_rsjyb(string BegDate, string EndDate, string fdepnumber, string fType)
        {
            DataSet ds = new DataSet();
            SqlParameter[] parameters = {			 
			 			 new SqlParameter("@BegDate", SqlDbType.VarChar,50), 
			 			 new SqlParameter("@EndDate", SqlDbType.VarChar,50), 
			 			 new SqlParameter("@fdepnumber", SqlDbType.VarChar,50), 
			 			 new SqlParameter("@fType", SqlDbType.VarChar,50) 
			 			 };
            parameters[0].Value = BegDate;
            parameters[1].Value = EndDate;
            parameters[2].Value = fdepnumber;
            parameters[3].Value = fType;
            ds= DbHelperSQL.RunProcedure("sp_sel_rsjyb", parameters, "test");
            return ds;
        }
   

    }
}
