<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="contact page.aspx.cs" Inherits="MasterPageDemo.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">
    <h2 >this is the gallery  page</h2>
    <a  href="aboutpage.aspx">Back to about page</a>
        <div class="container" style="height:500px; width:1000px">
        <div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">

  <div class="carousel-inner" >
    <div class="carousel-item active">
      <img src="Images/google1.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="Images/img2.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="Images/img3.png" class="d-block w-100" alt="...">
    </div>
  </div>
            </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span >Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleControls" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span >Next</span>
  </button>
</div>
        <div class="card">
  <div class="card-body">
    This is some text within a card body.
  </div>
</div>
        <div class="card">
  <div class="card-body">
    This is some text within a card body.
  </div>
</div>
        <div class="card">
  <div class="card-body">
    This is some text within a card body.
  </div>
</div>
        <div class="card">
  <div class="card-body">
    This is some text within a card body.
  </div>
</div>
        <div class="card">
  <div class="card-body">
    This is some text within a card body.
  </div>
</div>
        </div>
</asp:Content>
