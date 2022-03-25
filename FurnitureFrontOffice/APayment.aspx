<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APayment.aspx.cs" Inherits="FurnitureFrontOffice.APayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 124px;
        }
        .auto-style2 {
            width: 184px;
        }
        .auto-style3 {
            height: 30px;
            width: 436px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body style="height: 535px; width: 1110px;">
    <form id="form1" runat="server">
       <table class="auto-style3">
           <tr>
               <td class="auto-style1"> 
                   <asp:Label ID="Label1" runat="server" Text="Payment ID:" BackColor="#FFFF66"></asp:Label>
               </td>
               <td class="auto-style2"> 
                   <asp:TextBox ID="txtPaymentID" runat="server" Width="168px"></asp:TextBox>
               </td>
               <td> 
                   <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" BackColor="#3399FF" Font-Bold="True" Height="25px" Width="61px" />
               </td>
           </tr>
           <tr>
               <td class="auto-style1"> 
                   <asp:Label ID="Label2" runat="server" Text="CustomerUserID:" BackColor="#FFFF66"></asp:Label>
               </td>
               <td class="auto-style2"> 
                   <asp:TextBox ID="txtCustomerUserID" runat="server" Width="165px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="auto-style1"> 
                   <asp:Label ID="Label3" runat="server" Text="EmailAddress:" BackColor="#FFFF66"></asp:Label>
               </td>
               <td class="auto-style2"> 
                   <asp:TextBox ID="txtEmailAddress" runat="server" Width="162px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="auto-style1"> 
                   <asp:Label ID="Label4" runat="server" Text="Amount:" BackColor="#FFFF66"></asp:Label>
               </td>
               <td class="auto-style2"> 
                   <asp:TextBox ID="txtAmount" runat="server" Width="159px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="auto-style1"> 
                   <asp:Label ID="Label5" runat="server" Text="DateOfPayment:" BackColor="#FFFF66"></asp:Label>
               </td>
               <td class="auto-style2"> 
                   <asp:TextBox ID="txtDateOfPayment" runat="server" Width="154px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="auto-style1"> 
                   <asp:Label ID="Label6" runat="server" Text="TypeOfPayment:" BackColor="#FFFF66"></asp:Label>
               </td>
               <td class="auto-style2"> 
                   <asp:TextBox ID="txtTypeOfPayment" runat="server" Width="156px"></asp:TextBox>
               </td>
           </tr>
           <tr> 
               <td class="auto-style4"> &nbsp;</td>
                <td class="auto-style4"> &nbsp;</td>
           </tr>

       </table>
    </form>
</body>
</html>
