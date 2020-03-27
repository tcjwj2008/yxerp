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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				string userid = "";
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					userid= Request.Params["id0"];
				}
				string FUNCTIONID = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					FUNCTIONID= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(userid,FUNCTIONID);
			}
		}
			
	private void ShowInfo(string userid,string FUNCTIONID)
	{
		yinxiang.BLL.yx_functionuser_new bll=new yinxiang.BLL.yx_functionuser_new();
		yinxiang.Model.yx_functionuser_new model=bll.GetModel(userid,FUNCTIONID);
		this.lbluserid.Text=model.userid;
		this.txtusername.Text=model.username;
		this.lblFUNCTIONID.Text=model.FUNCTIONID;
		this.txtfunctionname.Text=model.functionname;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
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
			string userid=this.lbluserid.Text;
			string username=this.txtusername.Text;
			string FUNCTIONID=this.lblFUNCTIONID.Text;
			string functionname=this.txtfunctionname.Text;


			yinxiang.Model.yx_functionuser_new model=new yinxiang.Model.yx_functionuser_new();
			model.userid=userid;
			model.username=username;
			model.FUNCTIONID=FUNCTIONID;
			model.functionname=functionname;

			yinxiang.BLL.yx_functionuser_new bll=new yinxiang.BLL.yx_functionuser_new();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
