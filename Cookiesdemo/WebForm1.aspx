<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cookiesdemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            <asp:Label runat="server" Text="Username:"></asp:Label><asp:TextBox runat="server" ID="first"></asp:TextBox>
        </div>
        </br>
        <div>
        <asp:Label runat="server" Text="Password: " ></asp:Label> <asp:TextBox runat="server" ID="second"></asp:TextBox>
           </br> </br><asp:Button runat="server" ID="button1" OnClick="Button1" Text="Button"></asp:Button>              
        </div>
    </form>
</body>
</html>
