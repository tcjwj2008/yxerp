<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRYmain.aspx.cs" Inherits="yinxiang.Web.frmRYmain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
    
        ul{

list-style-type:none;

margin:0;

padding:0;

overflow:hidden;
            width: 1467px;
            height: 109px;
            text-align: center;
        }

li{

float:left;
            width: 247px;
            height: 36px;
        }

a{

display:block;

background-color:pink;

color:white;

width:156px;

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
            width: 1400px;
            text-align: center;
        }
        .style24
        {
            width: 1400px;
            height: 85px;
        }
        .style25
        {
            width: 1400px;
            height: 116px;
        }
        </style>
</head>
<body bgcolor="#99ccff">

    <form id="form1" runat="server">
      <table border=0 style="width: 1475px; height: 542px;" align="center">
                
      
          <tr>

           <td class="style25">

               <ul>
<li><a herf="">管理员专用</a></li>
<li><a herf="">肉业公司</a></li>
<li><a herf="">食品公司</a></li>
<li><a herf="">肉制品公司</a></li>
<li><a herf="">饲料公司</a></li>
<li><a herf="">银祥油脂公司</a></li>
<li><a herf="">东方银祥油脂公司</a></li>
<li><a herf="">银祥豆制品公司</a></li>
<li><a herf="">东方豆制品公司</a></li>
<li><a herf="">云睿系统</a></li>
<li><a herf="">其他产业</a></li>
</ul></td>
          </tr>      
      
      
          <tr>

           <td class="style24">

              <div id="nav-1" style="height: 252px">
              <asp:GridView 
                   ID="GridView2" runat="server" DataKeyNames="MediaTypeId" CellPadding="4" ForeColor="#333333" 
                   GridLines="None" Width="1464px" Height="233px" 
                   onrowcreated="GridView2_RowCreated" AutoGenerateColumns="False" 
                   onselectedindexchanged="GridView2_SelectedIndexChanged">
                   <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                   <Columns> 
                      
                        <asp:BoundField DataField="产业公司" HeaderText="产业公司" />
                        <asp:BoundField DataField="功能组" HeaderText="功能组" />
                        <asp:BoundField DataField="功能代码" HeaderText="功能代码" />
                        <asp:BoundField DataField="功能名称" HeaderText="功能名称" />
                     
                        <asp:BoundField DataField="MediaTypeId" HeaderText="MediaTypeId" 
                            SortExpression="MediaTypeId" />
                     
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" Text="选择" />
                            </ItemTemplate>
                        </asp:TemplateField>                
                     
                    </Columns>
                   <EditRowStyle BackColor="#999999" />
                   <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                   <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                   <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                   <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                   <SortedAscendingCellStyle BackColor="#E9E7E2" />
                   <SortedAscendingHeaderStyle BackColor="#506C8C" />
                   <SortedDescendingCellStyle BackColor="#FFFDF8" />
                   <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
               </asp:GridView>
                  <br />
</div>


</td>
          </tr>      
      
      
          <tr>

           <td class="style22">


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
               <br />
               <br />
               <br />


        Copyright ©2019厦门银祥集团     
               </td>
          </tr>      
      
      
          </table>

    </form>
</body>
</html>
