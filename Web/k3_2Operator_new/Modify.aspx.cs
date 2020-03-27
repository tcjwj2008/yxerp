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
namespace yinxiang.Web.k3_2Operator_new
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UserID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(UserID);
				}
			}
		}
			
	private void ShowInfo(int UserID)
	{
		yinxiang.BLL.k3_2Operator_new bll=new yinxiang.BLL.k3_2Operator_new();
		yinxiang.Model.k3_2Operator_new model=bll.GetModel(UserID);
		this.lblUserID.Text=model.UserID.ToString();
		this.lblOperatorName.Text=model.OperatorName;
		this.txtPassWord.Text=model.PassWord;
		this.txtIsAdmin.Text=model.IsAdmin;
		this.txtNote.Text=model.Note;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			int UserID=int.Parse(this.lblUserID.Text);
			string OperatorName=this.lblOperatorName.Text;
			string PassWord=this.txtPassWord.Text;
			string IsAdmin=this.txtIsAdmin.Text;
			string Note=this.txtNote.Text;


			yinxiang.Model.k3_2Operator_new model=new yinxiang.Model.k3_2Operator_new();
			model.UserID=UserID;
			model.OperatorName=OperatorName;
			model.PassWord=PassWord;
			model.IsAdmin=IsAdmin;
			model.Note=Note;

			yinxiang.BLL.k3_2Operator_new bll=new yinxiang.BLL.k3_2Operator_new();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
