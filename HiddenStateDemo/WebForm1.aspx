<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HiddenStateDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Hit Count" OnClick="GenerateCount" />
            <asp:HiddenField ID="hidden" runat="server" Value="0" />
            <asp:Label runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="first" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="second" runat="server"></asp:TextBox>
            <asp:HiddenField ID="Hidden2" runat="server"  />
            <asp:HiddenField ID="Hidden3" runat="server"  />
            <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Generatedetails" />
            <asp:Button ID="Button3" runat="server" Text="Go to next page" PostBackUrl="~/WebForm2.aspx" OnClick="Generatedetails" />





        </div>
    </form>
</body>
</html>
