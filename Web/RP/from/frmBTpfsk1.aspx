<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBTpfsk1.aspx.cs" Inherits="yinxiang.Web.RP.from.frmBTpfsk" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>   
</head>
<body bgcolor="#99ccff">
    <form id="form2" runat="server">
      <table border=0>
          <tr>

           <td class="style20">

            <table style="width: 100%; height: 36px;" cellpadding="2" cellspacing="1" 
                   class="border">
                <tr>
                    <td align="right" class="style21">
                        日期:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        收银员:
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;                    
                        
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                            style="text-align: left" Text="计算" Height="34px" Width="63px" />
                    &nbsp;
                        <asp:Button ID="Button2" runat="server" onclick="Button1_Click" 
                            style="text-align: left" Text="查询" Height="34px" Width="57px" />
                    &nbsp;
                       <input id="Button6" type="button" value="导出" onclick="printPage()" />
                                            
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <div id="printdiv">
               <h4 style="width: 1197px; text-align:center"> 白条收款表</h4>
               
             </div>
               <br />
               <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                   AutoDataBind="true" />
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
               <table border="0" cellpadding="0" cellspacing="1" 
                   style="width: 100%; height: 0px;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Label ID="Label4" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
              </td>
          </tr>      
      
      
          </table>

      <hr style="height: -12px; width: 1393px;">
      <div class="style3">
          Copyright厦门银祥集团
     
      </div>

    </form>

 
</body>
</html>
