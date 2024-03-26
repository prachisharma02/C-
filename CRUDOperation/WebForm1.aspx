
       

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
        <div>
            
            <asp:Label runat="server" Text="Enter name "></asp:Label> 
            <asp:TextBox runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Enter phone no  "></asp:Label> 
            <asp:TextBox runat="server" TextMode="Number"></asp:TextBox>
            <asp:Label runat="server" Text="Enter emailaddress "></asp:Label> 
            <asp:TextBox runat="server"TextMode="Email"></asp:TextBox>
            <asp:Label runat="server" Text="Enter passsowrd "></asp:Label>
            <asp:TextBox runat="server" TextMode="Password"></asp:TextBox>

</div>
        <div>&nbsp;</div>
        <div>&nbsp;</div>
        <div>
            <asp:Button runat="server" Text="craete"></asp:Button>
            <asp:Button runat="server" Text="insert"></asp:Button>
            <asp:Button runat="server" Text="update"></asp:Button>
            <asp:Button runat="server" Text="delete"></asp:Button>&nbsp;</div>
    </form>
</body>
</html>
