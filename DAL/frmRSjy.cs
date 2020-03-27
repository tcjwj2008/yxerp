using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Maticsoft.DBUtility;

namespace yinxiang.DAL
{
    class frmRSjy
    {
        public frmRSjy()
		{}

        public DataSet GETSSSS(){
            string strSql="select *　from t_user";
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}
