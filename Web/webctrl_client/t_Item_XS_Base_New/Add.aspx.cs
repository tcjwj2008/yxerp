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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string 备注=this.txt备注.Text;
			decimal OrderID=decimal.Parse(this.txtOrderID.Text);
			decimal 气调系数=decimal.Parse(this.txt气调系数.Text);

			yinxiang.Model.t_Item_XS_Base_New model=new yinxiang.Model.t_Item_XS_Base_New();
			model.产品代码=产品代码;
			model.产品名称=产品名称;
			model.肉品系数=肉品系数;
			model.人工系数=人工系数;
			model.车间类别=车间类别;
			model.备注=备注;
			model.OrderID=OrderID;
			model.气调系数=气调系数;

			yinxiang.BLL.t_Item_XS_Base_New bll=new yinxiang.BLL.t_Item_XS_Base_New();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
