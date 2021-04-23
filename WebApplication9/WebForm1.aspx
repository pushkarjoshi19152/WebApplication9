<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Online Test </title>
    <script src="reqjs.js"></script>       
    <script type="text/javascript">
            function StartTest(popUpPage) {
                window.open(popUpPage, 'null', 'toolbar=0,scrollbars=1,location=0,statusbar=0,menubar=0,resizable=0,fullscreen=yes');
                }  

            </script>


</head>
<body>
    <form id="form1" runat="server">
         <div style=" text-align :center; width:100%">  
                
                        <table width="1000" border="2" cellpadding="10" style="height: 272px" >  
                            <tr>  
                                <td style="text-align:center;">  
                                    <b>  
                                       <asp:Label ID="lbstatus" runat="server" 
                                       BackColor="Black" BorderColor="Red" Font-Bold="True" 
                                       Font-Size="16pt" 
                                        ForeColor="#0066FF">CODER BABA Online Test</asp:Label>  
                                      </b>  
                                </td>  
                            </tr>  
                            <tr>  
                                <td style="text-align:center;"><b>Start You online Asp.Net Test</b></td>  
                            </tr>  
                            <tr>  
                                <td style="text-align: center;">  
                                    <asp:Button ID="btnStartTest" Text="Start Test" runat="server" 
                                        OnClientClick="return StartTest('WebForm2.aspx');"
                                         BorderColor="#FF6600" BorderWidth="4px" Height="43px" Width="142px" />  
                                </td>  
                            </tr>  
                        </table>  
                  
            </div>  
    </form>
</body>
</html>

