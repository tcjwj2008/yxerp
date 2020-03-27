<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="yinxiang.Web.smes_functionName.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		functionid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfunctionid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orgId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorgId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		functionName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfunctionName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		functionPath
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfunctionPath" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		functionGroup
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfunctionGroup" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		creater
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcreater" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		useNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluseNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lastUser
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllastUser" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lastUseDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllastUseDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		memo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmemo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		functioncode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfunctioncode" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




