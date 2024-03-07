<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PostBackDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="First" runat="server" Text="Submit Button"/> 
            <asp:ListBox ID="List" runat="server" Width="100px">
                <%--<asp:ListItem>Item 1</asp:ListItem>
             <asp:ListItem>Item 2</asp:ListItem>
             <asp:ListItem>Item 3</asp:ListItem>--%>
            </asp:ListBox>
        </div>
    </form>
</body>
</html>
