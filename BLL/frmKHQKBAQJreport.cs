using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Maticsoft.DBUtility;

namespace yinxiang.BLL
{
  public  class frmKHQKBAQJreport
    {

      public static DataSet frmKHQKBAQJreportNew(DateTime BegDate, DateTime EndDate)
        {
            DataSet ds = new DataSet();
            SqlParameter[] parameters = {			 
			 			 new SqlParameter("@begindate", SqlDbType.DateTime,50),
                    	 new SqlParameter("@enddate", SqlDbType.DateTime,50)
			 			 };
            parameters[0].Value = BegDate;
            parameters[1].Value = EndDate;
            DbHelperSQLP DbHelperSQLP = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString_RZP"));
            ds = DbHelperSQLP.RunProcedure("sp_getICCredit_new_qiu", parameters, "test");
            return ds;
        }
    }
}
