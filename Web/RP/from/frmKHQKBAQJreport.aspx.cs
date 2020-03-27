using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yinxiang.Web.RP.from
{
    public partial class frmKHQKBAQJreport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox1.Text = DateTime.Now.ToShortDateString();
            this.TextBox2.Text = DateTime.Now.ToShortDateString();
            this.GridView1.DataSource = BLL.frmKHQKBAQJreport.frmKHQKBAQJreportNew(Convert.ToDateTime(this.TextBox1.Text.ToString()), Convert.ToDateTime(this.TextBox2.Text.ToString()));
            this.GridView1.DataBind();
            this.Label4.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.GridView1.DataSource = BLL.frmKHQKBAQJreport.frmKHQKBAQJreportNew(Convert.ToDateTime(this.TextBox1.Text.ToString()), Convert.ToDateTime(this.TextBox2.Text.ToString()));
            this.GridView1.DataBind();
            this.Label4.Text = " 读取肉制品客户欠款表（按期间）数据完成.";
        }
    }
}