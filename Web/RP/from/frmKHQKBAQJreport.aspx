<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmKHQKBAQJreport.aspx.cs" Inherits="yinxiang.Web.RP.from.frmKHQKBAQJreport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style21
        {
            text-align: left;
            width: 561px;
        }
        .style19
        {
            text-align: left;
        }
        #Button6
        {
            width: 52px;
            height: 28px;
        }
        .style3
        {
            text-align: center;
        }
        </style>
</head>
<body bgcolor="#99ccff">
    <form id="form1" runat="server">
    <div>
    
            <table style="width: 115%; height: 36px;" cellpadding="2" cellspacing="1" 
                   class="border">
                <tr>
                    <td align="right" class="style21">
                        开始日期：&nbsp;
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" Text="截止日期："></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        &nbsp;</td>
                    <td class="style19">
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                            style="text-align: left" Text="查询" Height="28px" Width="51px" />
                    &nbsp;
                        <input id="Button6" type="button" value="打印" onclick="printPage()" />
                    </td>
                </tr>
            </table>
               <h4 style="width: 1414px; text-align:center"> 客户欠款表（按期间）</h4>
               <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
            Width="2107px" Height="153px" BackColor="White" BorderColor="#3366CC" 
            BorderStyle="None" BorderWidth="1px">
                   <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                   <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                   <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                   <RowStyle BackColor="White" ForeColor="#003399" />
                   <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                   <SortedAscendingCellStyle BackColor="#EDF6F6" />
                   <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                   <SortedDescendingCellStyle BackColor="#D6DFDF" />
                   <SortedDescendingHeaderStyle BackColor="#002876" />
               </asp:GridView>
               
               <table border="0" cellpadding="0" cellspacing="1" 
                   style="width: 100%; height: 0px;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Label ID="Label4" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
      <div class="style3">
          &nbsp;Copyright(C) 2020 厦门银祥集团
     
      </div>
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
    
    </div>
    </form>
</body>
</html>
