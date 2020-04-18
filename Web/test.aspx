
<%@ Page Language="C#" AutoEventWireup="true" %> 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"> 
<script runat="server"> 
protected void Page_Load(object sender, EventArgs e) 
    { 
        Button1.Attributes.Add("onclick", "this.form.target='_newName'"); 
    } 
protected void Button1_Click(object sender, EventArgs e) 
    { 
        Response.Redirect("main.aspx"); 
    } 
</script> 
<html xmlns="http://www.w3.org/1999/xhtml"> 
<head id="Head1" runat="server"> 
<title></title> 
</head> 
<body id="b" runat="server"> 
<form id="form1" runat="server"> 
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="打开新窗口或者新 Tab " /> 
</form> 
</body> 
