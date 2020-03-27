using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

namespace yinxiang.Web.RP.from
{
    public partial class frmBTpfsk1 : System.Web.UI.Page
    {


        //获取报表路径
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox1.Text = DateTime.Now.ToShortDateString();
            this.TextBox2.Text = "A";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            ReportDocument rd = new ReportDocument();
            string reportPath = Server.MapPath("RP/rpt/Btsk_d.rpt"); //"./RP/rpt/Btsk_d.rpt";//Server.MapPath("RP/rpt/Btsk_d.rpt");
            rd.Load(reportPath);
            //绑定数据集，注意一个表用一个数据集。
            rd.SetDataSource(BLL.frmBTpfsk.frmBTpfskDO(this.TextBox1.Text, this.TextBox2.Text));
            CrystalReportViewer1.ReportSource = rd;
        }


    }
}