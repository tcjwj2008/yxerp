<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="yinxiang.Web.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 48px;
        }
        .style2
        {
            height: 24px;
        }
        .style4
        {}
        .style5
        {
            width: 165px;
        }
        .style6
        {
            width: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 785px; width: 1530px;">
    
        <table class="style1" border=0>
            <tr>
                <td class="style2" colspan="2" style="background-color: #3333CC">
                    <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/QQ图片20200101160311.png" 
                        ClientIDMode="Predictable" Height="63px">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:TreeView ID="TreeView1" runat="server" ImageSet="Simple" NodeIndent="10" 
                        style="background-color: #FFFFFF" Width="306px" ExpandDepth="0" 
                        ShowLines="True">
                        <HoverNodeStyle Font-Underline="True" ForeColor="#DD5555" />
                        <Nodes>
                            <asp:TreeNode Text="新建节点" Value="新建节点">
                                <asp:TreeNode Text="新建节点" Value="新建节点">
                                    <asp:TreeNode Text="新建节点" Value="新建节点">
                                        <asp:TreeNode Text="新建节点" Value="新建节点">
                                            <asp:TreeNode Text="新建节点" Value="新建节点">
                                                <asp:TreeNode Text="新建节点" Value="新建节点">
                                                    <asp:TreeNode Text="新建节点" Value="新建节点">
                                                        <asp:TreeNode Text="新建节点" Value="新建节点">
                                                            <asp:TreeNode Text="新建节点" Value="新建节点">
                                                                <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                                                            </asp:TreeNode>
                                                        </asp:TreeNode>
                                                    </asp:TreeNode>
                                                </asp:TreeNode>
                                            </asp:TreeNode>
                                        </asp:TreeNode>
                                    </asp:TreeNode>
                                </asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="新建节点" Value="新建节点">
                                <asp:TreeNode Text="新建节点" Value="新建节点">
                                    <asp:TreeNode Text="新建节点" Value="新建节点">
                                        <asp:TreeNode Text="新建节点" Value="新建节点">
                                            <asp:TreeNode Text="新建节点" Value="新建节点">
                                                <asp:TreeNode Text="新建节点" Value="新建节点">
                                                    <asp:TreeNode Text="新建节点" Value="新建节点">
                                                        <asp:TreeNode Text="新建节点" Value="新建节点">
                                                            <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                                                        </asp:TreeNode>
                                                    </asp:TreeNode>
                                                </asp:TreeNode>
                                            </asp:TreeNode>
                                        </asp:TreeNode>
                                    </asp:TreeNode>
                                </asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="新建节点" Value="功能列表" ShowCheckBox="False"></asp:TreeNode>
                            <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                            <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                            <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                            <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                            <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                            <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                        </Nodes>
                        <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                            HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="0px" />
                        <ParentNodeStyle Font-Bold="False" />
                        <SelectedNodeStyle Font-Underline="True" ForeColor="#DD5555" 
                            HorizontalPadding="0px" VerticalPadding="0px" />
                    </asp:TreeView>
                </td>
                <td class="style4">
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                        GridLines="Horizontal" Height="27px" ShowFooter="True" Width="1218px">
                        <Columns>
                            <asp:BoundField />
                            <asp:BoundField />
                            <asp:BoundField />
                            <asp:BoundField />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
