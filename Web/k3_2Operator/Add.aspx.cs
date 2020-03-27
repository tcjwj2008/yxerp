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
namespace yinxiang.Web.k3_2Operator
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOperatorName.Text.Trim().Length==0)
			{
				strErr+="OperatorName不能为空！\\n";	
			}
			if(this.txtPassWord.Text.Trim().Length==0)
			{
				strErr+="PassWord不能为空！\\n";	
			}
			if(this.txtIsAdmin.Text.Trim().Length==0)
			{
				strErr+="IsAdmin不能为空！\\n";	
			}
			if(this.txtNote.Text.Trim().Length==0)
			{
				strErr+="Note不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string OperatorName=this.txtOperatorName.Text;
			string PassWord=this.txtPassWord.Text;
			string IsAdmin=this.txtIsAdmin.Text;
			string Note=this.txtNote.Text;

			yinxiang.Model.k3_2Operator model=new yinxiang.Model.k3_2Operator();
			model.OperatorName=OperatorName;
			model.PassWord=PassWord;
			model.IsAdmin=IsAdmin;
			model.Note=Note;

			yinxiang.BLL.k3_2Operator bll=new yinxiang.BLL.k3_2Operator();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
