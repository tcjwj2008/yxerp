using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace yinxiang.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            yinxiang.BLL.k3_2Operator bll = new yinxiang.BLL.k3_2Operator();
            string user_name = this.txtUsername.Value.Trim();
            string user_pwd = this.txtPass.Value.Trim();
            Boolean loginFlag ;

            loginFlag = bll.Exists_new(user_name, user_pwd);
            
            if (loginFlag==true)
            {
                User user = new User();
                user.Name = user_name;
                user.PassWord = user_pwd;
                Session["user"] = user;
                Session["username"]=user_name;
                Session["password"] = user_pwd;


                Response.Redirect("MainPage.aspx",false);
            }
            else
            {
                this.lblMsg.Text = "登录失败！";
            }

          
            

        }
    }
}
