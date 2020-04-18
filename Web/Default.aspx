<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="yinxiang.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>银祥ERP辅助系统--用户登录</title>
    <style type="text/css">
        #txtPass
        {
            width: 217px;
            height: 23px;
            margin-top: 13px;
            text-align: left;
            margin-left: 0px;
        }
        #txtUsername
        {
            width: 218px;
            height: 25px;
            }
        .style3
        {
            height: 23px;
            text-align: left;
            }
        .style5
        {
            text-align: left;
            width: 330px;
        }
        .style7
        {
        }
        .style8
        {
            height: 38px;
        }
        .style9
        {
            height: 56px;
            width: 330px;
            text-align: left;
        }
        .style10
        {
            width: 79px;
        }
        .style11
        {
            height: 56px;
            width: 79px;
        }
        .style12
        {
            height: 23px;
            text-align: left;
            width: 79px;
        }
        .style13
        {
            width: 330px;
            text-align: left;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server"  target=_blank>

           <table border="0" cellspacing="0" cellpadding="0" 
            align="center" 
               style="height: 554px; width: 574px; ">
                                    <tr>
                                        <td align="center">
                                            <table cellspacing="0" cellpadding="0" border="0" style="width: 320px">
                                                <tr>
                                                    <td valign="top" class="style7" colspan="2" >
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" class="style10" >
                                                        &nbsp;</td>
                                                    <td class="style13" >
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" class="style10" >
                                                        <span class="style8">用 户 名</span></td>
                                                    <td class="style13" >
                                                        <input class="nemo01"  name="user1" id="txtUsername"
                                                            runat="server" >
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style11"  >
                                                        密&nbsp; 码&nbsp; </td>
                                                    <td class="style9" >
                                                        <input name="user2" type="password" class="nemo01" 
                                                            id="txtPass" runat="server" 
                                                            ></td>
                                                </tr>
                                                <tr>
                                                    <td valign="bottom" class="style12">
                                                        &nbsp;</td>
                                                    <td valign="bottom" class="style5">
                                                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                                            style="font-size: medium; text-align: right;" Text="登 录" Height="31px" 
                                                            Width="61px" Font-Bold="False" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="bottom" class="style3" colspan="2">
                                            <asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red" 
                                                            style="text-align: left"></asp:Label>
                                                    </td>
                                                </tr>
                                                </table>
                                        </td>
                                    </tr>
                                </table>
    
    </form>
</body>
</html>
