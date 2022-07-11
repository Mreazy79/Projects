<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Stylists.aspx.cs" Inherits="NewLateamFrontEnd.Stylists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <section class="hero-wrap hero-wrap-2" style="background-image: url('images/salon2.jpg');" data-stellar-background-ratio="0.5">
      <div class="overlay"></div>
      <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-center">
          <div class="col-md-9 ftco-animate pb-5 text-center">
            <h2 class="mb-0 bread">Stylists </h2>
            <p class="breadcrumbs"><span class="mr-2"><a href="Home.aspx">Home <i class="ion-ios-arrow-round-forward"></i></a></span> <span>Stylists <i class="ion-ios-arrow-round-forward"></i></span></p>
          </div>
        </div>
      </div>
    </section>
        <br />
    <br />
   <h1 id="salonName" runat="server" class='mb-4'></h1>
    <br />
    <pre>
    <input id="search" type="text" runat="server"   placeholder="Search Hair Style"/>
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="searchsALON" />
        </pre>
    <br />

    <div id="display" runat="server"></div>
</asp:Content>
