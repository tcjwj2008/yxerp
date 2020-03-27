using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace yinxiang.Web
{
    public partial class frmRYmain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BLL.smes_functionName functionList = new yinxiang.BLL.smes_functionName();
            DataSet ds = new DataSet();
            ds = functionList.GetList_New("");
            this.GridView2.DataSource = ds.Tables[0];
            this.GridView2.DataBind();
        }
        private void CtlButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GridViewRow gvr = (GridViewRow)button.Parent.Parent;
            string pk = GridView2.DataKeys[gvr.RowIndex].Value.ToString();
            Response.Redirect(pk);


        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}