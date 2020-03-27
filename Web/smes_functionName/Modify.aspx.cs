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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					long functionid=(Convert.ToInt64(Request.Params["id"]));
					ShowInfo(functionid);
				}
			}
		}
			
	private void ShowInfo(long functionid)
	{
		yinxiang.BLL.smes_functionName bll=new yinxiang.BLL.smes_functionName();
		yinxiang.Model.smes_functionName model=bll.GetModel(functionid);
		this.lblfunctionid.Text=model.functionid.ToString();
		this.txtorgId.Text=model.orgId;
		this.txtfunctionName.Text=model.functionName;
		this.txtfunctionPath.Text=model.functionPath;
		this.txtfunctionGroup.Text=model.functionGroup;
		this.txtcreater.Text=model.creater;
		this.txtuseNum.Text=model.useNum.ToString();
		this.txtlastUser.Text=model.lastUser;
		this.txtlastUseDate.Text=model.lastUseDate;
		this.txtmemo.Text=model.memo;
		this.txtfunctioncode.Text=model.functioncode;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			if(!PageValidate.IsNumber(txtuseNum.Text))
			{
				strErr+="useNum格式错误！\\n";	
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
			long functionid=long.Parse(this.lblfunctionid.Text);
			string orgId=this.txtorgId.Text;
			string functionName=this.txtfunctionName.Text;
			string functionPath=this.txtfunctionPath.Text;
			string functionGroup=this.txtfunctionGroup.Text;
			string creater=this.txtcreater.Text;
			long useNum=long.Parse(this.txtuseNum.Text);
			string lastUser=this.txtlastUser.Text;
			string lastUseDate=this.txtlastUseDate.Text;
			string memo=this.txtmemo.Text;
			string functioncode=this.txtfunctioncode.Text;


			yinxiang.Model.smes_functionName model=new yinxiang.Model.smes_functionName();
			model.functionid=functionid;
			model.orgId=orgId;
			model.functionName=functionName;
			model.functionPath=functionPath;
			model.functionGroup=functionGroup;
			model.creater=creater;
			model.useNum=useNum;
			model.lastUser=lastUser;
			model.lastUseDate=lastUseDate;
			model.memo=memo;
			model.functioncode=functioncode;

			yinxiang.BLL.smes_functionName bll=new yinxiang.BLL.smes_functionName();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
