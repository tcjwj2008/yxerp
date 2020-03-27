using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Maticsoft.DBUtility;


namespace yinxiang.BLL
{
    public  class frmBTpfsk
    {

        public static DataSet frmBTpfskDO(string fDate,string syy)
        {
            DataSet ds = new DataSet();
            SqlParameter[] parameters = {			 
			 			 new SqlParameter("@fdate", SqlDbType.VarChar,50),
                         new SqlParameter("@syy", SqlDbType.VarChar,50)
			 			 };
            parameters[0].Value = fDate;
            parameters[1].Value = syy;
            DbHelperSQLP DbHelperSQLP = new DbHelperSQLP(PubConstant.GetConnectionString("ConnectionString_ERP"));
            ds = DbHelperSQLP.RunProcedure("frmbtskb", parameters, "test");
            return ds;
        }
    }
}
