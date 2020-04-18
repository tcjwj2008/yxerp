using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yinxiang.Web
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             this.Label1.Text = "当前用户为:" + Session["username"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}