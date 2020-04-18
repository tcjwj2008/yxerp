using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yinxiang.Web.RP.from
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.TextBox1.Text = DateTime.Now.ToShortDateString();
            //this.TextBox2.Text = DateTime.Now.ToShortDateString();
            this.GridView1.DataSource = BLL.frmRSjy.sp_sel_rsjyb("2099-01-01", "2099-01-01", "9999", "0");
            this.GridView1.DataBind();
           // this.Label4.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          this.GridView1.DataSource= BLL.frmRSjy.sp_sel_rsjyb(this.TextBox1.Text, this.TextBox2.Text, this.TextBox3.Text, "0");
         
          for (int i = 0; i < GridView1.Columns.Count; i++)
          {
              if (GridView1.Columns[i].HeaderText == "当天屠宰头数" || GridView1.Columns[i].HeaderText == "当月屠宰头数")
              {
                  GridView1.Columns[i].Visible = false; //隐藏当列
              }
          }
          this.GridView1.DataBind();

          //this.Label4.Text = " 读取经营数据完成.";
        }
    }
}