<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Cookiesdemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height:500px; width:200px">
<asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlItems_SelectedIndexChanged">
                <asp:ListItem onSelected="First">first</asp:ListItem>
                <asp:ListItem onSelected="Second">second</asp:ListItem>
                <asp:ListItem onSelected="Third">third</asp:ListItem>

            </asp:DropDownList>


        </div>
    </form>
</body>
</html>
