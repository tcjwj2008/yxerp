<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YXRY.aspx.cs" Inherits="yinxiang.Web.WebForm2" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style4
        {
            height: 36px;
        }
    </style>
</head>
<body style="height: 592px" bgcolor="#99ccff">
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style4">
                日期:<asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="296px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                收银员:&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; 仓库
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" onclick="Button1_Click" Text="查询" />
                &nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="查询" />
                &nbsp;<asp:Button ID="Button3" runat="server" onclick="Button1_Click" 
                    Text="查询" />
                <br />
&nbsp;</td>
        </tr>
        <tr>
            <td>
                <br />
                <br />
                <br />
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                    AutoDataBind="true" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
