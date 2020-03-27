<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="yinxiang.Web.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

TD {
	FONT-SIZE: 9pt; COLOR: #818181; FONT-FAMILY: Verdana,Geneva,Arial,Helvetica,sans-serif
}
.nemo01 {
	BORDER-RIGHT: #c5c5c5 1px solid; BORDER-TOP: #c5c5c5 1px solid; FONT-SIZE: 9pt; BORDER-LEFT: #c5c5c5 1px solid; COLOR: #2d2d2d; BORDER-BOTTOM: #c5c5c5 1px solid; FONT-FAMILY: ""; BACKGROUND-COLOR: #f7f7f7
}
TD A:link {
	TEXT-DECORATION: none
}
A {
	COLOR: #818181
}
        .style1
        {
            height: 12px;
            width: 299px;
        }
        .style2
        {
            width: 193px;
            text-align: left;
        }
        .style3
        {
            width: 299px;
        }
    </style>
</head>
<body style="height: 390px">
    <form id="form1" runat="server">
    <div style="height: 386px">
    
                                <table border="0" cellspacing="0" cellpadding="0" 
            align="center" style="height: 315px; width: 663px">
                                    <tr>
                                        <td width="123" height="120">
                                            <img height="95" src="Admin/images/login_p_img05.gif" width="123" border="0">
                                        </td>
                                        <td align="center">
                                            <table cellspacing="0" cellpadding="0" border="0">
                                                <tr>
                                                    <td height="25" valign="top" class="style3">
                                                        用户名：
                                                        <input class="nemo01" tabindex="1" maxlength="22" size="22" name="user1" id="txtUsername"
                                                            runat="server" onkeypress="return focusNext('txtPass', event,1,this,null)">
                                                    </td>
                                                    <td rowspan="3" align="right" valign="middle" class="style2">
                                                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                                            style="text-align: left" Text="登录" />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="bottom" height="12" class="style3">
                                                        密&nbsp;&nbsp; 码：
                                                        <input name="user2" type="password" class="nemo01" tabindex="1" size="22" maxlength="22"
                                                            id="txtPass" runat="server" 
                                                            onkeypress="return focusNext('CheckCode', event,2,this,'txtUsername')">
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="bottom" class="style1">
                                                        <table border="0" cellpadding="0" cellspacing="0" 
                                                            style="height: 20px; width: 239px">
                                                            <tr>
                                                                <td width="70%" align="left">
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                    验证码：
                                                                    <input class="nemo01" id="CheckCode" tabindex="3" maxlength="22" size="11" name="user"
                                                                        runat="server">
                                                                    <br />
                                                                </td>
                                                                <td width="30%" align="left">
                                                                    <a id="A2" href="" onclick="ChangeCode();return false;">
                                                                        <asp:Image ID="ImageCheck" runat="server" ImageUrl="../ValidateCode.aspx?GUID=GUID"
                                                                            ImageAlign="AbsMiddle" ToolTip="看不清，换一个"></asp:Image></a>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                            <asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
    
    </div>
    </form>
</body>
</html>
