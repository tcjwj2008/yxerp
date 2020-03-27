<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="yinxiang.Web.UserList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 1065px;
        }
        .style2
        {
            height: 25px;
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

           <td class="style5">
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
           <td class="style1">
               <!--******************************显示页面代码********************************-->

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td width="30%" align="right" class="style2">
		UserID
	：</td>
	<td width="*" align="left" class="style2">
		<asp:Label id="lblUserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperatorName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PassWord
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPassWord" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsAdmin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsAdmin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Note
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNote" runat="server"></asp:Label>
	</td></tr>
</table>
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
