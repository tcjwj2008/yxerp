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
namespace yinxiang.Web.yx_functionuser_new
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		this.lblusername.Text=model.username;
		this.lblFUNCTIONID.Text=model.FUNCTIONID;
		this.lblfunctionname.Text=model.functionname;

	}


    }
}
