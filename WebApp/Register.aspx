<%@ Page Title="Register page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApp.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <label>Username</label>
    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="username"></asp:TextBox>


    <br />




    <label>Password</label>
    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>

    <br />


    <label>Email</label>
    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Email"></asp:TextBox>

    <br />


    <label>City</label>
    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="City"></asp:TextBox>

    <br />
    <label>DateOfBirth</label>
    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Date" TextMode="Date"></asp:TextBox>

    <br />




    <asp:Button Class="btn btn-success btn-block btn-lg " ID="Button1" runat="server" Text="Sign up" OnClick="Button1_Click" />



    <br />



    <asp:Label ID="Label4" runat="server" Font-Size="X-Large"></asp:Label>









</asp:Content>
