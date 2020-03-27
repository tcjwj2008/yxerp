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
namespace yinxiang.Web.smes_functionName
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtorgId.Text.Trim().Length==0)
			{
				strErr+="orgId不能为空！\\n";	
			}
			if(this.txtfunctionName.Text.Trim().Length==0)
			{
				strErr+="functionName不能为空！\\n";	
			}
			if(this.txtfunctionPath.Text.Trim().Length==0)
			{
				strErr+="functionPath不能为空！\\n";	
			}
			if(this.txtfunctionGroup.Text.Trim().Length==0)
			{
				strErr+="functionGroup不能为空！\\n";	
			}
			if(this.txtcreater.Text.Trim().Length==0)
			{
				strErr+="creater不能为空！\\n";	
			}
			if(this.txtuseNum.Text.Trim().Length==0)
			{
				strErr+="useNum不能为空！\\n";	
			}
			if(this.txtlastUser.Text.Trim().Length==0)
			{
				strErr+="lastUser不能为空！\\n";	
			}
			if(this.txtlastUseDate.Text.Trim().Length==0)
			{
				strErr+="lastUseDate不能为空！\\n";	
			}
			if(this.txtmemo.Text.Trim().Length==0)
			{
				strErr+="memo不能为空！\\n";	
			}
			if(this.txtfunctioncode.Text.Trim().Length==0)
			{
				strErr+="functioncode不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string orgId=this.txtorgId.Text;
			string functionName=this.txtfunctionName.Text;
			string functionPath=this.txtfunctionPath.Text;
			string functionGroup=this.txtfunctionGroup.Text;
			string creater=this.txtcreater.Text;
			string useNum=this.txtuseNum.Text;
			string lastUser=this.txtlastUser.Text;
			string lastUseDate=this.txtlastUseDate.Text;
			string memo=this.txtmemo.Text;
			string functioncode=this.txtfunctioncode.Text;

			yinxiang.Model.smes_functionName model=new yinxiang.Model.smes_functionName();
			model.orgId=orgId;
			model.functionName=functionName;
			model.functionPath=functionPath;
			model.functionGroup=functionGroup;
			model.creater=creater;
			model.useNum=1;
			model.lastUser=lastUser;
			model.lastUseDate=lastUseDate;
			model.memo=memo;
			model.functioncode=functioncode;

			yinxiang.BLL.smes_functionName bll=new yinxiang.BLL.smes_functionName();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
