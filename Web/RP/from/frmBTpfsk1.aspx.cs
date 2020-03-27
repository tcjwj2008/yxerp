using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace yinxiang.Web.RP.from
{
    public partial class frmBTpfsk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.TextBox2.Text = DateTime.Now.ToShortDateString();
            this.TextBox1.Text = "";
            //  LoadCrystalReports();
        }

        private void LoadCrystalReports()
        {
            //DataSet ds = new DataSet();
            //string connStr = @"server=PC-201511211346\MSSQLSERVER2;database=Demo;uid=sa;pwd=123456";
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    conn.Open();
            //    string SQL = "select * from UserInfo";
            //    SqlDataAdapter sda = new SqlDataAdapter(SQL, conn);
            //    sda.Fill(ds, "UserInfo");
            //}
            //ReportDocument rd = new ReportDocument();
            ////获取报表路径
            //string reportPath = Server.MapPath("Reports/CrystalReport2.rpt");
            //rd.Load(reportPath);
            ////绑定数据集，注意一个表用一个数据集。
            //rd.SetDataSource(ds);
            //CrystalReportViewer1.ReportSource = rd;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {             
            ReportDocument rd = new ReportDocument();
            //获取报表路径
            string reportPath = Server.MapPath("RP/rpt/Btsk_d.rpt");
            rd.Load(reportPath);
            //绑定数据集，注意一个表用一个数据集。
            rd.SetDataSource(BLL.frmBTpfsk.frmBTpfskDO(this.TextBox2.Text, this.TextBox1.Text));
            CrystalReportViewer1.ReportSource = rd;
        }
    }
}