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
namespace yinxiang.Web.t_Item_XS_Base_New
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(FID);
				}
			}
		}
			
	private void ShowInfo(int FID)
	{
		yinxiang.BLL.t_Item_XS_Base_New bll=new yinxiang.BLL.t_Item_XS_Base_New();
		yinxiang.Model.t_Item_XS_Base_New model=bll.GetModel(FID);
		this.txt产品代码.Text=model.产品代码;
		this.txt产品名称.Text=model.产品名称;
		this.txt肉品系数.Text=model.肉品系数.ToString();
		this.txt人工系数.Text=model.人工系数.ToString();
		this.txt车间类别.Text=model.车间类别;
		this.lblFID.Text=model.FID.ToString();
		this.txt备注.Text=model.备注;
		this.txtOrderID.Text=model.OrderID.ToString();
		this.txt气调系数.Text=model.气调系数.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txt产品代码.Text.Trim().Length==0)
			{
				strErr+="产品代码不能为空！\\n";	
			}
			if(this.txt产品名称.Text.Trim().Length==0)
			{
				strErr+="产品名称不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txt肉品系数.Text))
			{
				strErr+="肉品系数格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txt人工系数.Text))
			{
				strErr+="人工系数格式错误！\\n";	
			}
			if(this.txt车间类别.Text.Trim().Length==0)
			{
				strErr+="车间类别不能为空！\\n";	
			}
			if(this.txt备注.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOrderID.Text))
			{
				strErr+="OrderID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txt气调系数.Text))
			{
				strErr+="气调系数格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string 产品代码=this.txt产品代码.Text;
			string 产品名称=this.txt产品名称.Text;
			decimal 肉品系数=decimal.Parse(this.txt肉品系数.Text);
			decimal 人工系数=decimal.Parse(this.txt人工系数.Text);
			string 车间类别=this.txt车间类别.Text;
			int FID=int.Parse(this.lblFID.Text);
			string 备注=this.txt备注.Text;
			decimal OrderID=decimal.Parse(this.txtOrderID.Text);
			decimal 气调系数=decimal.Parse(this.txt气调系数.Text);


			yinxiang.Model.t_Item_XS_Base_New model=new yinxiang.Model.t_Item_XS_Base_New();
			model.产品代码=产品代码;
			model.产品名称=产品名称;
			model.肉品系数=肉品系数;
			model.人工系数=人工系数;
			model.车间类别=车间类别;
			model.FID=FID;
			model.备注=备注;
			model.OrderID=OrderID;
			model.气调系数=气调系数;

			yinxiang.BLL.t_Item_XS_Base_New bll=new yinxiang.BLL.t_Item_XS_Base_New();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
