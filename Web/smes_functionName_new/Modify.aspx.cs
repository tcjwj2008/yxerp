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
namespace yinxiang.Web.smes_functionName_new
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
		yinxiang.BLL.smes_functionName_new bll=new yinxiang.BLL.smes_functionName_new();
		yinxiang.Model.smes_functionName_new model=bll.GetModel(functionid);
		this.lblfunctionid.Text=model.functionid.ToString();
		this.txtorgId.Text=model.orgId;
		this.txtfunctionGroup.Text=model.functionGroup;
		this.lblfunctionCode.Text=model.functionCode;
		this.txtfunctionName.Text=model.functionName;
		this.txtfunctionPath.Text=model.functionPath;
		this.txtmemo.Text=model.memo;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtorgId.Text.Trim().Length==0)
			{
				strErr+="orgId不能为空！\\n";	
			}
			if(this.txtfunctionGroup.Text.Trim().Length==0)
			{
				strErr+="functionGroup不能为空！\\n";	
			}
			if(this.txtfunctionName.Text.Trim().Length==0)
			{
				strErr+="functionName不能为空！\\n";	
			}
			if(this.txtfunctionPath.Text.Trim().Length==0)
			{
				strErr+="functionPath不能为空！\\n";	
			}
			if(this.txtmemo.Text.Trim().Length==0)
			{
				strErr+="memo不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long functionid=long.Parse(this.lblfunctionid.Text);
			string orgId=this.txtorgId.Text;
			string functionGroup=this.txtfunctionGroup.Text;
			string functionCode=this.lblfunctionCode.Text;
			string functionName=this.txtfunctionName.Text;
			string functionPath=this.txtfunctionPath.Text;
			string memo=this.txtmemo.Text;


			yinxiang.Model.smes_functionName_new model=new yinxiang.Model.smes_functionName_new();
			model.functionid=functionid;
			model.orgId=orgId;
			model.functionGroup=functionGroup;
			model.functionCode=functionCode;
			model.functionName=functionName;
			model.functionPath=functionPath;
			model.memo=memo;

			yinxiang.BLL.smes_functionName_new bll=new yinxiang.BLL.smes_functionName_new();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
