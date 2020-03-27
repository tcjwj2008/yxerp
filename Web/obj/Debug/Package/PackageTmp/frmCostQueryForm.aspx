<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCostQueryForm.aspx.cs" Inherits="yinxiang.Web.frmCostQueryForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style3
        {
            text-align: center;
        }
        .style4
        {
            width: 134px;
            background-color: #66CCFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <h3>厦门银祥K3辅助系统</h3>
      <hr>
      <table border=0 style="width: 1360px">
      <tr>
          <td style="background-color: #003300">
          </td>
          <td class="style4">银祥肉业</td><td style="background-color: #003366"></td>
          <td style="text-align: center; background-color: #66CCFF">银祥食品</td>
          <td style="background-color: #FF9900"></td>
          <td style="text-align: center; background-color: #66CCFF">银祥肉制品</td>
          <td style="background-color: #FF5050"></td><td class="style8" 
              style="text-align: center; background-color: #66CCFF">银祥油脂</td>
          <td style="background-color: #9933FF">
          </td>
          <td style="text-align: center; background-color: #66CCFF">
              银祥豆制品</td>
          <td style="background-color: #993333">
          </td>
          <td style="text-align: center; background-color: #66CCFF">
              银祥饲料</td>
          <td class="style9" style="background-color: #006600">
          </td>
          </tr>
      
      </table>
      <table border=0>
          <tr>

           <td class="style5" rowspan="2">
               <asp:TreeView ID="TreeView1" runat="server" ImageSet="Simple" NodeIndent="10" 
                   ShowLines="True">
                   <HoverNodeStyle Font-Underline="True" ForeColor="#DD5555" />
                   <Nodes>
                       <asp:TreeNode Text="日成本管理" Value="新建节点">
                           <asp:TreeNode Text="系数设置" Value="系数设置"></asp:TreeNode>
                           <asp:TreeNode Text="每天数据录入" Value="每天数据录入"></asp:TreeNode>
                           <asp:TreeNode Text="每月数据录入" Value="每月数据录入"></asp:TreeNode>
                           <asp:TreeNode Text="成本查询" Value="成本查询"></asp:TreeNode>
                           <asp:TreeNode Text="数据汇总查询" Value="数据汇总查询"></asp:TreeNode>
                           <asp:TreeNode Text="肉业公司日成本分析" Value="肉业公司日成本分析"></asp:TreeNode>
                       </asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点">
                           <asp:TreeNode Text="新建节点" Value="新建节点">
                               <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                           </asp:TreeNode>
                       </asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点">
                           <asp:TreeNode Text="新建节点" Value="新建节点">
                               <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                           </asp:TreeNode>
                       </asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点">
                           <asp:TreeNode Text="新建节点" Value="新建节点">
                               <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                           </asp:TreeNode>
                       </asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                       <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                   </Nodes>
                   <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                       HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="0px" />
                   <ParentNodeStyle Font-Bold="False" />
                   <SelectedNodeStyle Font-Underline="True" ForeColor="#DD5555" 
                       HorizontalPadding="0px" VerticalPadding="0px" />
               </asp:TreeView>
           
           
           
           
           </td>
           <td class="style7">
               <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                   DataSourceID="SqlDataSource1" Width="794px">
                   <Columns>
                       <asp:BoundField DataField="functionid" HeaderText="functionid" 
                           InsertVisible="False" ReadOnly="True" SortExpression="functionid" />
                       <asp:BoundField DataField="orgId" HeaderText="orgId" SortExpression="orgId" />
                       <asp:BoundField DataField="functionName" HeaderText="functionName" 
                           SortExpression="functionName" />
                       <asp:BoundField DataField="functionPath" HeaderText="functionPath" 
                           SortExpression="functionPath" />
                       <asp:BoundField DataField="functionGroup" HeaderText="functionGroup" 
                           SortExpression="functionGroup" />
                       <asp:BoundField DataField="creater" HeaderText="creater" 
                           SortExpression="creater" />
                       <asp:BoundField DataField="useNum" HeaderText="useNum" 
                           SortExpression="useNum" />
                       <asp:BoundField DataField="lastUser" HeaderText="lastUser" 
                           SortExpression="lastUser" />
                       <asp:BoundField DataField="lastUseDate" HeaderText="lastUseDate" 
                           SortExpression="lastUseDate" />
                       <asp:BoundField DataField="memo" HeaderText="memo" SortExpression="memo" />
                       <asp:BoundField DataField="functioncode" HeaderText="functioncode" 
                           SortExpression="functioncode" />
                   </Columns>
               </asp:GridView>
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                   ConnectionString="<%$ ConnectionStrings:YXERPConnectionString2 %>" 
                   SelectCommand="SELECT * FROM [smes_functionName]"></asp:SqlDataSource>
              </td>
          </tr>      
      
      
          <tr>

           <td class="style6">&nbsp;</td>
          </tr>      
      
      
          <tr>

           <td class="style2">
               &nbsp;</td>
           <td class="style1">&nbsp;</td>
          </tr>      
      
      
      </table>

      <hr>
      <div class="style3">
     厦门银祥集团
     
      </div>
    </form>
</body>
</html>
