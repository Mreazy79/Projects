<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dummy.aspx.cs" Inherits="NewLateamFrontEnd.Dummy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add Hairstyle</h1>
    <br />
    <input id="styleName" type="text" placeholder="Hairstyle Name" runat="server"/>
    <br />
     <br />
    <input id="price" type="text" placeholder="price" runat="server"/>
    <br />
     <br />
    <input id="image" type="text" placeholder="Image" runat="server"/>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Add Style" OnClick="Add" />
    <br />
    <div id="display" runat="server"></div>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
</asp:Content>
