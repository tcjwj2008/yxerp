<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="yinxiang.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="css/style.css">
<head runat="server">
    <title>银祥ERP辅助系统--用户登录</title>
    <style type="text/css">
        #form1
        {
            height: 582px;
        }
        
TD {
	FONT-SIZE: 9pt; COLOR: #818181; FONT-FAMILY: Verdana,Geneva,Arial,Helvetica,sans-serif
}
        .style3
        {
            width: 452px;
        }
    .nemo01 {
	    border: 1px solid #c5c5c5;
            FONT-SIZE: 9pt; COLOR: #2d2d2d; FONT-FAMILY: ""; BACKGROUND-COLOR: #f7f7f7;
            height: 28px;
            width: 197px;
        }
        .style2
        {
            width: 193px;
            text-align: left;
        }
        TD A:link {
	TEXT-DECORATION: none
}
A {
	COLOR: #818181
}
        .style4
        {
            width: 11px;
        }
        .style6
        {
            width: 452px;
            height: 39px;
        }
        .style8
        {
            font-size: medium;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">

                                <table border="0" cellspacing="0" cellpadding="0" 
            align="center" style="height: 554px; width: 431px">
                                    <tr>
                                        <td height="120" class="style4">
                                            &nbsp;</td>
                                        <td align="center">
                                            <table cellspacing="0" cellpadding="0" border="0">
                                                <tr>
                                                    <td valign="top" class="style6">
                                                        <span class="style8">用户名：</span>&nbsp;&nbsp;
                                                        <input class="nemo01" tabindex="1" maxlength="22" size="22" name="user1" id="txtUsername"
                                                            runat="server" onkeypress="return focusNext('txtPass', event,1,this,null)">
                                                    </td>
                                                    <td rowspan="2" align="right" valign="middle" class="style2">
                                                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                                            style="font-size: medium;" Text="登录" Height="35px" Width="68px" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="bottom" class="style3">
                                                        <span class="style8">密&nbsp;&nbsp; 码：</span>&nbsp;&nbsp;
                                                        <input name="user2" type="password" class="nemo01" tabindex="1" size="22" maxlength="22"
                                                            id="txtPass" runat="server" 
                                                            onkeypress="return focusNext('CheckCode', event,2,this,'txtUsername')">
                                                        <br />
                                                        <br />
                                                    </td>
                                                </tr>
                                                </table>
                                            <asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
    
    </form>
</body>
</html>
