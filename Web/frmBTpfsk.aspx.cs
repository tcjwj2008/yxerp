using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yinxiang.Web
{
    public partial class frmBTpfsk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 实例化ReportDocument
        /// </summary>
        /// <param name="strReportFileName">报表文件的名称</param>
        /// <param name="strSql">查询SQL语句</param>
        /// <param name="strTable">数据表</param>
        /// <returns>ReportDocument对象的引用</returns>
        //public ReportDocument CrystalReports(string strReportFileName, string strSql, string strTable)
        //{
            ////获取报表路径
            //string strReportPath = Application.StartupPath;
            //// Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
            //// Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            ////strReportPath += @"\RP\RPT\" + strReportFileName;
            //strReportPath += @"\RPT\" + strReportFileName;
            ////得到dt数据源
            //DataTable dt = db.GetDataTable(strSql, strTable);
            ////ReportDocument对象加载rpt文件并绑定到数据源dt
            //ReportDocument reportDoc = new ReportDocument();
            //reportDoc.Load(strReportPath);
            //reportDoc.SetDataSource(dt.DefaultView); //DataView是接口IEnumerable的实现子类,此处使用了“接口”的多态特性

            ////水晶报表动态链接数据库
            //TableLogOnInfo logOnInfo = new TableLogOnInfo();
            //logOnInfo.ConnectionInfo.ServerName = OperatorFile.GetIniFileString("DataBase", "Server", "", Application.StartupPath + "\\SMALLERP.ini");
            //logOnInfo.ConnectionInfo.DatabaseName = "YXERP";
            //logOnInfo.ConnectionInfo.UserID = OperatorFile.GetIniFileString("DataBase", "UserID", "", Application.StartupPath + "\\SMALLERP.ini");
            //logOnInfo.ConnectionInfo.Password = OperatorFile.GetIniFileString("DataBase", "Pwd", "", Application.StartupPath + "\\SMALLERP.ini");

            //// 对报表中的每个表依次循环(把连接信息存入每一个Table中)
            //foreach (Table tb in reportDoc.Database.Tables)
            //{
            //    tb.ApplyLogOnInfo(logOnInfo);
            //}

            ////返回ReportDocument对象 
            //return reportDoc;
        //}


        protected void Button1_Click(object sender, EventArgs e)
        {
            //string strCondition = null;
            //strCondition = " SELECT 1 排序, * FROM BTSKBM WHERE fdate='" + this.dateTimePicker1.Value.ToShortDateString() +
            //"' AND 收银员 LIKE '%" + this.textBox1.Text.Trim() + "%' ";
            //strCondition += " UNION ALL ";
            //strCondition += " SELECT 2 排序, fdate, NULL 收银员, '合计' 市场,NULL K3代码,NULL 客户名称,SUM(ISNULL(前日累欠,0))前日累欠, ";
            //strCondition += " SUM(ISNULL(礼券,0))礼券 ,SUM(ISNULL(现金收款,0))现金收款,SUM(ISNULL(银行存款,0))银行存款, ";
            //strCondition += " SUM(ISNULL([余额(不含当天销售)],0)) [余额(不含当天销售)],SUM(ISNULL(差额,0))差额,  ";
            //strCondition += " SUM(ISNULL(头数1,0))头数1,SUM(ISNULL(重量1,0))重量1,SUM(ISNULL(金额1,0))金额1, ";
            //strCondition += " SUM(ISNULL(头数2,0))头数2,SUM(ISNULL(重量2,0))重量2,SUM(ISNULL(金额2,0))金额2, ";
            //strCondition += " SUM(ISNULL(头数3,0))头数3,SUM(ISNULL(重量3,0))重量3,SUM(ISNULL(金额3,0))金额3, ";
            //strCondition += " SUM(ISNULL(头数4,0))头数4,SUM(ISNULL(重量4,0))重量4,SUM(ISNULL(金额4,0))金额4, ";
            //strCondition += " SUM(ISNULL(头数5,0))头数5,SUM(ISNULL(重量5,0))重量5,SUM(ISNULL(金额5,0))金额5, ";
            //strCondition += " SUM(ISNULL(折让金额,0))折让金额,SUM(ISNULL(当日应付,0))当日应付,SUM(ISNULL(次日实收现金,0))次日实收现金,SUM(ISNULL(累计余额,0))累计余额, ";
            //strCondition += " NULL 欠款确认签名,NULL 内码,NULL 标记,NULL 账套 ";
            //strCondition += " FROM BTSKBM WHERE fdate='" + this.dateTimePicker1.Value.ToShortDateString() + "' ";
            //strCondition += " AND 收银员 LIKE '%" + this.textBox1.Text.Trim() + "%' ";
            //strCondition += " AND 标记='明细'  GROUP BY fdate";
            //strCondition += " ORDER BY 排序,市场,K3代码,标记";


            //dt = db.GetDataTable(strCondition, "exceltab");

        


            //if (this.radioButton1.Checked == true)
            //{
            //    crystalReportViewer1.ReportSource = commUse.CrystalReports("btpfsk.rpt", strCondition, "BTSKBM");
            //}
            //if (this.radioButton2.Checked == true)
            //{
            //    crystalReportViewer1.ReportSource = commUse.CrystalReports("Btsk_d.rpt", strCondition, "BTSKBM");
            //}
        }
    }
}