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
namespace yinxiang.Web.k3_2Operator_new
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int UserID=(Convert.ToInt32(strid));
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
		this.lblPassWord.Text=model.PassWord;
		this.lblIsAdmin.Text=model.IsAdmin;
		this.lblNote.Text=model.Note;

	}


    }
}
