<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="yinxiang.Web.yx_functionuser_new.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
    {
        height: 23px;
    }
    .style2
    {
        height: 27px;
    }
        .style4
        {
            width: 1277px;
        }
        .style5
        {
            height: 23px;
            width: 1277px;
        }
        .style6
        {
            height: 27px;
            width: 1277px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" align="right" class="style4">
		用户ID：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuserid" runat="server" Width="200px" 
            style="margin-left: 0px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" align="right" class="style4">
		用户名：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtusername" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" align="right" class="style5">
		功能ID：</td>
	<td height="25" width="*" align="left" class="style1">
		<asp:TextBox id="txtFUNCTIONID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" align="right" class="style6">
		功能名称：</td>
	<td height="25" width="*" align="left" class="style2">
		<asp:TextBox id="txtfunctionname" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
