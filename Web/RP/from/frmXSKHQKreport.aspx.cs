using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yinxiang.Web.RP.from
{
    public partial class frmXSKHQKreport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.GridView1.DataSource = BLL.frmYXCKreport.frmYXCKreportDO(this.TextBox1.Text);
            this.GridView1.DataBind();
            this.Label4.Text = " 读取销售客户欠款单数据完成.";
        }
    }
}