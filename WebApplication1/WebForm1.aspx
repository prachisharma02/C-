<html>
    <head><title></title></head>
    <body>
        <h1>registration Forms</h1>
        <form runat="server">
        <asp:Label   runat="server" Text="Firstname"></asp:Label>
        <asp:TextBox runat="server"></asp:TextBox>
        <asp:Label   runat="server" Text="lastname"></asp:Label>
        <asp:TextBox runat="server"></asp:TextBox>
        <asp:Label   runat="server" Text="Email"></asp:Label>
        <asp:TextBox runat="server" TextMode="Email"></asp:TextBox>
        <asp:Label   runat="server" Text="Contact"></asp:Label>
        <asp:TextBox runat="server" Textmode="Number"></asp:TextBox>
        <asp:Label   runat="server" Text="Address"></asp:Label>
        <asp:TextBox runat="server"></asp:TextBox>
        <asp:Button  runat="server" Text="Submit"/>
        </form>
    </body>
</html>