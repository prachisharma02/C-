<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="VBCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
        <asp:Label runat="server">Num1</asp:Label>
        <asp:TextBox ID="txtNum1" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNum1" runat="server" ControlToValidate="txtNum1" ErrorMessage="Please enter a number for Num1." ForeColor="Red" />
        <%--<asp:RangeValidator ID="rvAge" runat="server" ControlToValidate="txtNum1" 
 MinimumValue="120" MaximumValue="18"                    
            ErrorMessage="num1 must be between 18 and 120." 
                    ForeColor="orange" />--%>
        <asp:Label runat="server">Num2</asp:Label>
        <asp:TextBox ID="txtNum2" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNum2" runat="server" ControlToValidate="txtNum2" ErrorMessage="Please enter a number for Num2." ForeColor="Red" />


      <br />
      <br />
      <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
         <br />
         <br />

      <asp:Button ID="Add" runat="server" onclick="Add_Click" Text="Add" />
      <asp:Button ID="Subtract" runat="server" onclick="Subtract_Click" Text="Subtract" />     
      <asp:Button ID="Multiply" runat="server" onclick="Multiply_Click" Text="Multiply" />
      <asp:Button ID="Divide" runat="server" onclick="Divide_Click" Text="Divide" />
      <asp:Button ID="Modulus" runat="server" onclick= "Modulus_Click" Text="Modulus" />
    </div>
    </form>
</body>
</html>
