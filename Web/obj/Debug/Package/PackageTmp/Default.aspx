<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="yinxiang.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>银祥ERP辅助系统--用户登录</title>
    <style type="text/css">
        #txtPass
        {
            width: 242px;
            height: 23px;
            margin-top: 13px;
        }
        #txtUsername
        {
            width: 245px;
            height: 25px;
            text-align: left;
        }
        .style3
        {
            height: 23px;
            text-align: left;
            width: 199px;
        }
        .style5
        {
            text-align: left;
            width: 315px;
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
        }
    </style>
</head>
<body bgcolor="#fefbc6">
    <form id="form1" runat="server">

           <table border="0" cellspacing="0" cellpadding="0" 
            align="center" 
               style="height: 554px; width: 574px; background-color: #FEFBC6;">
                                    <tr>
                                        <td align="center">
                                            <table cellspacing="0" cellpadding="0" border="0" style="width: 352px">
                                                <tr>
                                                    <td valign="top" class="style7" colspan="2" >
                                                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/login.png" 
                                                            Width="352px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="top" class="style7" >
                                                        <span class="style8">用 户 名:</span></td>
                                                    <td >
                                                        <input class="nemo01"  name="user1" id="txtUsername"
                                                            runat="server" >
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="style9"  >
                                                        密&nbsp; 码 : </td>
                                                    <td class="style9" >
                                                        <input name="user2" type="password" class="nemo01" 
                                                            id="txtPass" runat="server" 
                                                            ></td>
                                                </tr>
                                                <tr>
                                                    <td valign="bottom" class="style3">
                                                        &nbsp;</td>
                                                    <td valign="bottom" class="style5">
                                                        &nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                                            style="font-size: medium; text-align: right;" Text="登录" Height="24px" 
                                                            Width="55px" />
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
