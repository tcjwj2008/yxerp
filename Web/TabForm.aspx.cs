using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yinxiang.Web
{
    public partial class TabForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IFRAME1.Attributes.Add("src", "test.aspx"); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            IFRAME1.Attributes.Add("src", "main.aspx"); 
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            IFRAME1.Attributes.Add("src", "main.aspx"); 
        }
    }
}