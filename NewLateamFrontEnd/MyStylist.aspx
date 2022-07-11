<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MyStylist.aspx.cs" Inherits="NewLateamFrontEnd.MyStylist" %>
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
    <pre>
    <input id="search" type="text" runat="server"   placeholder="Search Salon"/>
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="searchHairstyle" />
        </pre>

    <div id="showImage" runat="server"></div>
</asp:Content>
