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
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace yinxiang.Web.yx_functionuser_new
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuserid.Text.Trim().Length==0)
			{
				strErr+="userid不能为空！\\n";	
			}
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
			}
			if(this.txtFUNCTIONID.Text.Trim().Length==0)
			{
				strErr+="FUNCTIONID不能为空！\\n";	
			}
			if(this.txtfunctionname.Text.Trim().Length==0)
			{
				strErr+="functionname不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string userid=this.txtuserid.Text;
			string username=this.txtusername.Text;
			string FUNCTIONID=this.txtFUNCTIONID.Text;
			string functionname=this.txtfunctionname.Text;

			yinxiang.Model.yx_functionuser_new model=new yinxiang.Model.yx_functionuser_new();
			model.userid=userid;
			model.username=username;
			model.FUNCTIONID=FUNCTIONID;
			model.functionname=functionname;

			yinxiang.BLL.yx_functionuser_new bll=new yinxiang.BLL.yx_functionuser_new();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
