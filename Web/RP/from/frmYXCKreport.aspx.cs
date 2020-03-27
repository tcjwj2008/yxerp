using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Printing;

namespace yinxiang.Web.RP.from
{
    public partial class frmYXCKreport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox1.Text = DateTime.Now.ToShortDateString();
            //this.TextBox2.Text = DateTime.Now.ToShortDateString();
            this.GridView1.DataSource = BLL.frmYXCKreport.frmYXCKreportDO(DateTime.Now.ToShortDateString());
            this.GridView1.DataBind();
            this.Label4.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
            this.GridView1.DataSource = BLL.frmYXCKreport.frmYXCKreportDO(this.TextBox1.Text);
            this.GridView1.DataBind();
            this.Label4.Text = " 读取豆制品催款单数据完成.";
        }


        ///// <summary>
        ///// 打印功能
        ///// </summary>
        ///// <param name="panel">打印控件</param>
        ///// <param name="title">标题</param>
        ///// <param name="pageSize">纸张类型</param>
        ///// <param name="margins">边距</param>
        //public virtual void Print(IPrintable panel, string title = null, PaperKind pageSize = PaperKind.A4, System.Drawing.Printing.Margins margins        = null)
        //{
        //    PrintingSystem ps = new PrintingSystem();
        //    CompositeLink link = new CompositeLink(ps);
        //    PrintableComponentLink printableLink = new PrintableComponentLink() { Component = panel };
        //    ps.Links.Add(link);
        //    link.Links.Add(printableLink);
        //    //link.Landscape = false;//横向
        //    link.PaperKind = pageSize;//设置纸张大小
        //    if (margins == null)
        //        margins = new System.Drawing.Printing.Margins(0, 0, 10, 10);
        //    link.Margins = margins;
        //    ////判断是否有标题，有则设置
        //    //if (!string.IsNullOrEmpty(title))
        //    //{

        //    //    PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
        //    //    phf.Header.Content.Clear();
        //    //    phf.Header.Content.AddRange(new string[] { "", title, "" });
        //    //    phf.Header.Font = new System.Drawing.Font("宋体", 14, System.Drawing.FontStyle.Bold);
        //    //    phf.Header.LineAlignment = BrickAlignment.Center;

        //    //    //phf.Footer.Content.AddRange(new string[] { "", String.Format("打印时间: {0:g}", DateTime.Now), "" });
        //    //}
        //    link.CreateDocument(); //建立文档
        //    //ps.PreviewRibbonFormEx.Show();//进行预览 
        //    ps.Print();
        //}

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}