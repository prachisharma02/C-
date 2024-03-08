<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="aboutpage.aspx.cs" Inherits="MasterPageDemo.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center" ><h1>About page</h1>
   
    
    <p> showing master demo which have same layout throughout the application </p>
   
        <div class="card" style="width: 18rem;">
  <img src="Images/img1.jpg" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Card title</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <a href="contact page.aspx" class="btn btn-primary">Go to Gallary page </a>
  </div>
</div>

        </div>
</asp:Content>
