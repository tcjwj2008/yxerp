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
namespace yinxiang.Web.smes_functionName
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
					long functionid=(Convert.ToInt64(strid));
					ShowInfo(functionid);
				}
			}
		}
		
	private void ShowInfo(long functionid)
	{
		yinxiang.BLL.smes_functionName bll=new yinxiang.BLL.smes_functionName();
		yinxiang.Model.smes_functionName model=bll.GetModel(functionid);
		this.lblfunctionid.Text=model.functionid.ToString();
		this.lblorgId.Text=model.orgId;
		this.lblfunctionName.Text=model.functionName;
		this.lblfunctionPath.Text=model.functionPath;
		this.lblfunctionGroup.Text=model.functionGroup;
		this.lblcreater.Text=model.creater;
		this.lbluseNum.Text=model.useNum.ToString();
		this.lbllastUser.Text=model.lastUser;
		this.lbllastUseDate.Text=model.lastUseDate;
		this.lblmemo.Text=model.memo;
		this.lblfunctioncode.Text=model.functioncode;

	}


    }
}
