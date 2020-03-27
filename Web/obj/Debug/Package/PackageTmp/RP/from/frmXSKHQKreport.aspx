<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmXSKHQKreport.aspx.cs" Inherits="yinxiang.Web.RP.from.frmXSKHQKreport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<script type="text/javascript">
    function printPage() {
        var newWin = window.open('printer', '', '');
        var titleHTML = document.getElementById("printdiv").innerHTML;
        newWin.document.write(titleHTML);
        newWin.document.location.reload();
        newWin.print();
        newWin.close();
    }
</script>
<head runat="server">
    <title>销售客户欠款表</title>
        <style>
    
            ul{

list-style-type:none;

margin:0;

padding:0;

overflow:hidden;
            width: 1472px;
            height: 101px;
            text-align: center;
        }

li{

float:left;
            width: 322px;
            height: 36px;
        }

a{

display:block;

background-color:pink;

color:white;

width:222px;

text-align:center;

padding:4px 0px;

text-decoration:none;

}

a:hover,a:active{

background-color:gray;

}


    
    </style>
    <style type="text/css">
        #printdiv
        {
            text-align: center;
        }
        .style23
        {
            width: 874px;
            height: 34px;
        }
        .style25
        {
            width: 874px;
            text-align: center;
            height: 62px;
        }
        .style26
        {
            width: 874px;
            text-align: center;
            height: 24px;
        }
        .style27
        {
            width: 874px;
            text-align: center;
            height: 22px;
        }
    </style>
</head>
<body bgcolor="#99ccff">
    <form id="form1" runat="server">
      <table border=0>
          <tr>

           <td class="style23">

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

           <td class="style27">


            
               *销售客户欠款表*&nbsp;


            
             <asp:Label ID="Label1" runat="server" Text="截止日期："></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;                    
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                            style="text-align: left" Text="查询" Height="28px" Width="61px" />
                    &nbsp;&nbsp;
                      <input id="Button6" type="button" value="打印" onclick="printPage()" />&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label4" runat="server" 
                   style="color: #FF0000; text-align: left;" Text="Label"></asp:Label>
              </td>
          </tr>      
      
      
          <tr>

           <td class="style25">


            
             <div  id="printdiv">
                 <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
                   GridLines="None" Width="1481px" Height="153px">
                   <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
               </div> 


            
              </td>
          </tr>      
      
      
          <tr>

           <td class="style26">


            
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
               <br />
               <br />
               <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Copyright ©2019厦门银祥集团</td>
          </tr>      
      
      
          </table>

    </form>

</body>
</html>
