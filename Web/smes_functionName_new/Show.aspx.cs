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
namespace yinxiang.Web.smes_functionName_new
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
		yinxiang.BLL.smes_functionName_new bll=new yinxiang.BLL.smes_functionName_new();
		yinxiang.Model.smes_functionName_new model=bll.GetModel(functionid);
		this.lblfunctionid.Text=model.functionid.ToString();
		this.lblorgId.Text=model.orgId;
		this.lblfunctionGroup.Text=model.functionGroup;
		this.lblfunctionCode.Text=model.functionCode;
		this.lblfunctionName.Text=model.functionName;
		this.lblfunctionPath.Text=model.functionPath;
		this.lblmemo.Text=model.memo;

	}


    }
}
