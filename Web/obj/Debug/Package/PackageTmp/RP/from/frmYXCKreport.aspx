<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmYXCKreport.aspx.cs" Inherits="yinxiang.Web.RP.from.frmYXCKreport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="css/style.css">
<script type="text/javascript">
    function printPage() {
        var newWin = window.open('printer', '', '');
        var titleHTML = document.getElementById("printdiv").innerHTML;
        newWin.document.write(titleHTML);
        newWin.document.location.reload();
        newWin.print();
        newWin.close();
    }
</script>


<head runat="server">
    <title>营销催款表</title>
    <style type="text/css">
        .style17
        {
            text-align: center;
        }
        .style3
        {
            text-align: center;
        }
        .style19
        {
            text-align: left;
        }
        .style20
        {
            width: 1201px;
        }
        .style21
        {
            text-align: left;
            width: 391px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h3 class="style17">
          厦门银祥K3辅助系统</h3>
      <hr style="width: 1399px">
      <table border=0>
          <tr>

           <td class="style5">
               &nbsp;</td>
           <td class="style20">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%; height: 36px;" cellpadding="2" cellspacing="1" 
                   class="border">
                <tr>
                    <td align="right" class="style21">
                        <asp:Label ID="Label1" runat="server" Text="截止日期："></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;                    
                        
                    </td>
                    <td class="style19">
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                            style="text-align: left" Text="查询" />
                    &nbsp;
                        <asp:Button ID="Button2" runat="server" onclick="Button1_Click" 
                            style="text-align: left" Text="导出" />
                    &nbsp;
                       <input id="Button6" type="button" value="打印" onclick="printPage()" />
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <div id="printdiv">
               <h4 style="width: 1196px; text-align:Center"> 营销催款表</h4>
               <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                   GridLines="None" Width="1197px" Height="153px">
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
               
             </div>
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

      <hr style="height: -12px; width: 1393px;">
      <div class="style3">
          <span style="color: rgb(77, 77, 77); font-family: &quot;Microsoft YaHei&quot;, &quot;SF Pro Display&quot;, Roboto, Noto, Arial, &quot;PingFang SC&quot;, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
          <span class="style16" 
              style="color: rgb(0, 0, 0); font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
          Copyright </span>©2019</span>厦门银祥集团
     
      </div>

    </form>
          <script src='js/jquery.min.js'></script>
          <script src="js/script.js"></script>
</body>
</html>
