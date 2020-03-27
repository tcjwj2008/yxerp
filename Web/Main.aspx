<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="yinxiang.Web.Main"  EnableEventValidation="false"  %>

<!DOCTYPE html>
<!-- PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"-->

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>厦门银祥K3辅助系统_主页</title>
    <style>
    
        ul{

list-style-type:none;

margin:0;

padding:0;

overflow:hidden;
            width: 1543px;
            height: 111px;
            }

li{

float:left;
            width: 247px;
            height: 36px;
        }

a{

display:block;

background-color:green;

color:white;

width:191px;

text-align:center;

padding:4px 0px;

text-decoration:none;

}

a:hover,a:active{

background-color:gray;

}


    
    </style>
    <style type="text/css">
        .style22
        {
            height: 105px;
            width: 1341px;
            text-align: center;
        }
        .style24
        {
            width: 1341px;
            height: 85px;
        }
        .style25
        {
            width: 1341px;
            height: 116px;
        }
        .style27
        {
            width: 1341px;
            text-align: left;
        }
        .style29
        {
            width: 1341px;
            height: 82px;
        }
        </style>
</head>
<body bgcolor="#fef9c6">


    <form id="form1" runat="server">
      <table border=0 style="width: 1614px; height: 542px;" align="center">
                
      
          <tr>

           <td class="style29">

               <asp:Image ID="Image1" runat="server" Height="79px" 
                   ImageUrl="~/Images/loginsmall.png" Width="315px" />
               <br />
               <br />
               <br />
              </td>
          </tr>      
      
      
          <tr>

           <td class="style25">

               <ul>
<li><a href="">管理员专用</a></li>
<li><a href="frmRYmain.aspx">肉业公司</a></li>
<li><a href="">食品公司</a></li>
<li><a href="">肉制品公司</a></li>
<li><a href="">饲料公司</a></li>
<li><a href="">银祥油脂公司</a></li>
<li><a href="">东方银祥油脂公司</a></li>
<li><a href="">银祥豆制品公司</a></li>
<li><a href="">东方豆制品公司</a></li>
<li><a href="">云睿系统</a></li>
<li><a href="">其他产业</a></li>
<li><a href="">报表管理</a></li>
<li><a href="">单据导入模块</a></li>
<li><a href="">接口</a></li>
<li><a href="">定时作业</a></li>
</ul></td>
          </tr>      
      
      
          <tr>

           <td class="style24">

              <div id="nav-1" style="height: 550px; text-align: center; width: 1543px;">
              <asp:GridView 
                   ID="GridView2" runat="server" DataKeyNames="MediaTypeId" CellPadding="4" 
                      Width="1407px" Height="443px" 
                   onrowcreated="GridView2_RowCreated" AutoGenerateColumns="False" 
                   onselectedindexchanged="GridView2_SelectedIndexChanged" BackColor="White" 
                      BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Font-Bold="False" 
                      style="text-align: center" ForeColor="Black" GridLines="Horizontal">
                   <Columns> 
                      
                        <asp:BoundField DataField="产业公司" HeaderText="产业公司">
                        <HeaderStyle BackColor="Green" Width="115px" />
                        <ItemStyle BackColor="#FFCCCC" />
                        </asp:BoundField>
                      
                        <asp:BoundField DataField="功能名称" HeaderText="功能名称" >
                     
                        <HeaderStyle Width="300px" />
                     
                        <ItemStyle Width="200px" />
                        </asp:BoundField>
                      
                        <asp:TemplateField HeaderText="详情">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" Text="进入..." />
                            </ItemTemplate>
                            <ControlStyle BorderColor="#993366" BorderStyle="Double" Font-Bold="True" 
                                Font-Italic="True" Height="50px" Width="130px" />
                            <HeaderStyle Width="100px" />
                        </asp:TemplateField>                
                     
                        <asp:BoundField DataField="MediaTypeId" HeaderText="MediaTypeId" 
                            SortExpression="MediaTypeId" Visible="False" />
                     
                    </Columns>
                   <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                   <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" 
                       Font-Names="黑体" Font-Size="18pt" Height="50px" 
                       HorizontalAlign="Center" />
                   <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                   <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" 
                       Height="20px" />
                   <SortedAscendingCellStyle BackColor="#F7F7F7" />
                   <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                   <SortedDescendingCellStyle BackColor="#E5E5E5" />
                   <SortedDescendingHeaderStyle BackColor="#242121" />
               </asp:GridView>
                  <br />


        Copyright ©2019厦门银祥集团     
                  <br />
</div>


</td>
          </tr>      
      
      
          <tr>

           <td class="style27">


               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
               </td>
          </tr>      
      
      
          <tr>

           <td class="style22">


               &nbsp;</td>
          </tr>      
      
      
          </table>

    </form>
</body>
</html>
