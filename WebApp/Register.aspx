<%@ Page Title="Register page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApp.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="row">
                        <div class="col">
                            <center>
                                <img width="100px" src="imgs/login.jpg" />
                            </center>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>User Sign up</h3>
                            </center>
                            <br />

                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <hr>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div class="container">

                                <div class="form-group">

                                    <label>Username</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="username"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>Email</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
                                    <label>Password</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                                </div>
                                <br />
                                <div class="form-group">
                                    <label>DateOfBirth</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Date" TextMode="Date"></asp:TextBox>
                                </div>
                                <br />
                                <div class="form-group">
                                    <label>City</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="City"></asp:TextBox>

                                    <div class="col">
                                        <div class="form-group">
                                            <asp:Button Class="btn btn-success btn-block btn-lg " ID="Button1" runat="server" Text="Sign up" OnClick="Button1_Click" />
                                        </div>
                                    </div>
                                </div>
                                <br />
                                <asp:Label ID="Label4" runat="server" Font-Size="X-Large"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
                <a class="" href="Home.aspx"><< Back to Home </a>
            </div>
        </div>
    </div>
</asp:Content>
