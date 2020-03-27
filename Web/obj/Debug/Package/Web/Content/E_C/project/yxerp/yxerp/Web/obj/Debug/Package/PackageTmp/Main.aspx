<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="yinxiang.Web.Main"  EnableEventValidation="false"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="css/style.css">
<head runat="server">

    <title>厦门银祥K3辅助系统_主页</title>
    <style type="text/css">
        .style3
        {
            height: 27px;
            width: 1937px;
            text-align: center;
        }
        .style7
        {
            width: 1737px;
            height: 105px;
        }
        .style16
        {
            background-color: #FFFFFF;
        }
        .style17
        {
            font-family: 黑体;
            text-align: center;
            color: #003366;
        }
        .style18
        {
            width: 238px;
            height: 105px;
        }
        </style>
</head>
<body>



    <form id="form1" runat="server">
      <h3 class="style17">
          &nbsp;</h3>
      <table border=0>
                
      
          <tr>

           <td >

               &nbsp;</td>

           <td colspan="2" >

              <div id="nav-1">

    <ul class="nav">
        <li class="slide1"></li>
        <li class="slide2"></li>
        <li><a class="active" href="#/">辅助系统</a></li>
        <li><a href="#/">肉业产业</a></li>
        <li><a href="#/">食品产业</a></li>
        <li><a href="#/">油脂公司</a></li>
        <li><a href="#/">肉制品公司</a></li>
           <li><a href="#/">饲料公司</a></li>
             <li><a href="#/">其他公司</a></li>
              <li><a href="#/">管理员专用</a></li>
    </ul>

</div>

<script src='js/jquery.min.js'></script>
<script src="js/script.js"></script>
</td>
          </tr>      
      
      
          <tr>

           <td class="style18">

               &nbsp;</td>

           <td class="style18">

               </td>

           <td class="style7">
               <br />


              <asp:GridView 
                   ID="GridView1" runat="server" DataKeyNames="MediaTypeId" CellPadding="4" ForeColor="#333333" 
                   GridLines="None" Width="1284px" Height="233px" style="text-align: center" 
                   onrowcreated="GridView1_RowCreated" AutoGenerateColumns="False" 
                   onselectedindexchanged="GridView1_SelectedIndexChanged">
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
      
      
          </table>

      <hr style="height: 0px; width: 1774px;">
      <div class="style3">
        Copyright ©2019厦门银祥集团     
      </div>
    </form>
</body>
</html>
