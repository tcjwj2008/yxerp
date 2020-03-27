<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRSjy.aspx.cs" Inherits="yinxiang.Web.RP.from.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>肉业食品经营表</title>
    <style type="text/css">
        .style3
        {
            text-align: center;
        }
        .style17
        {
            text-align: center;
        }
        .style18
        {
            width: 779px;
            height: 18px;
        }
        .style19
        {
            height: 18px;
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
           <td class="style7">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%; height: 8px;" cellpadding="2" cellspacing="1" 
                   class="border">
                <tr>
                    <td align="right" class="style19">
                         &nbsp;</td>
                    <td class="style18">                       
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;                    
                        
                    </td>
                    <td class="style19">
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                            style="text-align: left" Text="Button" />
                    </td>
                </tr>
            </table>
            <!--Search end-->
               <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                   GridLines="None" Width="1064px">
                   <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                   <EditRowStyle BackColor="#999999" />
                   <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                   <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                   <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                   <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                   <SortedAscendingCellStyle BackColor="#E9E7E2" />
                   <SortedAscendingHeaderStyle BackColor="#506C8C" />
                   <SortedDescendingCellStyle BackColor="#FFFDF8" />
                   <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
               </asp:GridView>
            <br />
               <table border="0" cellpadding="0" cellspacing="1" 
                   style="width: 100%; height: 0px;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Label ID="Label4" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                    </td>
                </tr>
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
