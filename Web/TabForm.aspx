<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TabForm.aspx.cs" Inherits="yinxiang.Web.TabForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <STYLE type="text/css" >.aaa{ 
            BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; 

            BACKGROUND-COLOR: #ffcc33; BORDER-BOTTOM-STYLE: none 
        } 
        .bbb{ 
            BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; 

            BACKGROUND-COLOR: #99ffcc; BORDER-BOTTOM-STYLE: none 
        } 
    </STYLE> 

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:button id="Button1" 
            style="Z-INDEX: 101;  POSITION: absolute; TOP: 24px; width:100px; left: 10px; height: 23px; right: 921px;" runat="server" 
Text="WebFrom1Tab" CssClass="aaa" OnClick="Button1_Click"></asp:button> 
        <asp:Button id="Button2" 
            
            
            style="Z-INDEX: 102;  POSITION: absolute; TOP: 24px; width:100px; height: 23px; right: 708px; left: 223px;" runat="server" 
Text="WebFrom2Tab" CssClass="bbb" OnClick="Button2_Click"></asp:Button> 
<asp:Button id="Button3" 
            
            
            style="Z-INDEX: 103;  POSITION: absolute; TOP: 25px; left: 117px; width:100px; height: 22px; right: 825px;" runat="server" 
Text="WebFrom3Tab" CssClass="bbb" OnClick="Button3_Click"></asp:Button>
        <iframe id="IFRAME1" style="border-style: solid; border-color: inherit; border-width: 0px; Z-INDEX: 103; 
 LEFT: 11px; WIDTH: 1329px; POSITION: absolute; TOP: 47px; HEIGHT: 1039px" 
runat="server"></iframe> 
    </div>
    </form>
</body>
</html>
