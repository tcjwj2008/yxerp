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
        .style18
        {
            width: 1066px;
            height: 18px;
            text-align: left;
        }
        .style19
        {
            height: 18px;
            text-align: left;
        }
        .style7
        {
            text-align: center;
            width: 1468px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
      <table border=0>
          <tr>

           <td class="style7">

               肉业经营表</td>
          </tr>      
      
      
          <tr>

           <td class="style7">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 104%; height: 8px;" cellpadding="2" cellspacing="1" 
                   class="border">
                <tr>
                    <td class="style18">                       
                        <asp:Label ID="Label1" runat="server" Text="开始日期"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" Text="结束日期"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server" Text="部门代码"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                            style="text-align: left" Text="查询" Height="27px" Width="47px" />
                        &nbsp;<br />
                        &nbsp;&nbsp;                    
                        
                    </td>
                    <td class="style19">
                        &nbsp;</td>
                </tr>
            </table>
            <!--Search end-->
               <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                   GridLines="None" Width="1524px" EmptyDataText="无数据">
                   <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                   <Columns>
                       <asp:BoundField DataField="日期" HeaderText="日期" />
                       <asp:BoundField DataField="部门代码" HeaderText="部门代码" />
                       <asp:BoundField DataField="部门名称" HeaderText="部门名称" />
                       <asp:BoundField />
                       <asp:BoundField />
                       <asp:BoundField />
                       <asp:BoundField />
                   </Columns>
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
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
            <br />
               <table border="0" cellpadding="0" cellspacing="1" 
                   style="width: 100%; height: 0px;">
                <tr>
                    <td align="left">
                        <asp:Label ID="Label4" runat="server" style="color: #FF0000"></asp:Label>
                    </td>
                </tr>
            </table>
              </td>
          </tr>      
      
      
          <tr>

           <td class="style7">

          <span style="color: rgb(77, 77, 77); font-family: &quot;Microsoft YaHei&quot;, &quot;SF Pro Display&quot;, Roboto, Noto, Arial, &quot;PingFang SC&quot;, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
          <span class="style16" 
              style="color: rgb(0, 0, 0); font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
          Copyright </span>©2019</span>厦门银祥集团</td>
          </tr>      
      
      
          </table>

      <div class="style3">
          &nbsp;</div>
    </form>
</body>
</html>
