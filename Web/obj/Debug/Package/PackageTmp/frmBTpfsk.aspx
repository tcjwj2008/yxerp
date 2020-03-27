<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBTpfsk.aspx.cs" Inherits="yinxiang.Web.frmBTpfsk" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style17
        {
            text-align: center;
            background-color: #003366;
        }
        .style3
        {
            text-align: center;
        }
        .style18
        {
            width: 1291px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <h3 class="style17">
          厦门银祥K3辅助系统</h3>
      <hr>
      <table border=0>
          <tr>

           <td class="style5" rowspan="2">
               <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" 
                   ShowLines="True" style="font-family: 黑体">
                   <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                   <Nodes>
                       <asp:TreeNode Text="肉业公司" Value="肉业公司">
                           <asp:TreeNode Text="日成本管理" Value="新建节点">
                               <asp:TreeNode Text="系数设置" Value="系数设置"></asp:TreeNode>
                               <asp:TreeNode Text="每天数据录入" Value="每天数据录入"></asp:TreeNode>
                               <asp:TreeNode Text="每月数据录入" Value="每月数据录入"></asp:TreeNode>
                               <asp:TreeNode NavigateUrl="/frmCostQueryForm.aspx" Text="成本查询" Value="成本查询">
                               </asp:TreeNode>
                               <asp:TreeNode Text="数据汇总查询" Value="数据汇总查询"></asp:TreeNode>
                               <asp:TreeNode Text="肉业公司日成本分析" Value="肉业公司日成本分析"></asp:TreeNode>
                           </asp:TreeNode>
                           <asp:TreeNode Text="白条收款表" Value="白条收款表"></asp:TreeNode>
                       </asp:TreeNode>
                       <asp:TreeNode Text="食品公司" Value="食品公司"></asp:TreeNode>
                       <asp:TreeNode Text="肉制品公司" Value="肉制品公司"></asp:TreeNode>
                   </Nodes>
                   <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
                       HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                   <ParentNodeStyle Font-Bold="False" />
                   <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                       HorizontalPadding="0px" VerticalPadding="0px" />
               </asp:TreeView>
           
           
           
           
           </td>
           <td class="style18">
               <br />
               <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
              </td>
          </tr>      
      
      
          <tr>

           <td class="style18">
               <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                   AutoDataBind="true" ReuseParameterValuesOnRefresh="True" />
              </td>
          </tr>      
      
      
          </table>

      <hr style="height: -12px">
      <div class="style3">
          <span style="color: rgb(77, 77, 77); font-family: &quot;Microsoft YaHei&quot;, &quot;SF Pro Display&quot;, Roboto, Noto, Arial, &quot;PingFang SC&quot;, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
          <span class="style16" 
              style="color: rgb(0, 0, 0); font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
          Copyright </span>©2019</span>厦门银祥集团
     
      </div>
    </form>
</body>
</html>
