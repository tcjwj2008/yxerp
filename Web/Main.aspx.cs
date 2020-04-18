using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Text;

namespace yinxiang.Web
{
    public partial class Main : System.Web.UI.Page
    {
       
      
        protected void Page_Load(object sender, EventArgs e)
        {
            form1.Target = "_blank";
            BLL.smes_functionName functionList = new yinxiang.BLL.smes_functionName();
            DataSet ds = new DataSet();
            ds = functionList.GetList_New(@"yx_functionuser_new.username ='" + Session["username"]+"'");
            this.GridView2.DataSource = ds.Tables[0];
            this.GridView2.DataBind();

           
               // this.Label1.Text = "当前用户为:" + Session["username"];
         
                
        }

        private void CtlButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GridViewRow gvr = (GridViewRow)button.Parent.Parent;
            string pk = GridView2.DataKeys[gvr.RowIndex].Value.ToString();
            Response.Redirect(pk);

         
        }


 

        protected void GridView2_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.DataRow) return;

            if (e.Row.FindControl("Button1") != null)
            {
                Button CtlButton = (Button)e.Row.FindControl("Button1");
                CtlButton.Click += new EventHandler(CtlButton_Click);
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       

 

    }
}