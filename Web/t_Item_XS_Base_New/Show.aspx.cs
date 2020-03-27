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
namespace yinxiang.Web.t_Item_XS_Base_New
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
					int FID=(Convert.ToInt32(strid));
					ShowInfo(FID);
				}
			}
		}
		
	private void ShowInfo(int FID)
	{
		yinxiang.BLL.t_Item_XS_Base_New bll=new yinxiang.BLL.t_Item_XS_Base_New();
		yinxiang.Model.t_Item_XS_Base_New model=bll.GetModel(FID);
		this.lbl产品代码.Text=model.产品代码;
		this.lbl产品名称.Text=model.产品名称;
		this.lbl肉品系数.Text=model.肉品系数.ToString();
		this.lbl人工系数.Text=model.人工系数.ToString();
		this.lbl车间类别.Text=model.车间类别;
		this.lblFID.Text=model.FID.ToString();
		this.lbl备注.Text=model.备注;
		this.lblOrderID.Text=model.OrderID.ToString();
		this.lbl气调系数.Text=model.气调系数.ToString();

	}


    }
}
