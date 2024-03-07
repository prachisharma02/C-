<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SessionStateDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server"  PostBackUrl="WebForm3.aspx">Go to page3</asp:LinkButton>  
            <br />

            <%--<asp:Label ID="Label1" runat="server"></asp:Label>  
                <br />  
            <asp:Label ID="Label2" runat="server"></asp:Label> 
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>  --%>
        </div>
    </form>
</body>
</html>
