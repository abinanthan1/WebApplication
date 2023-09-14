<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">

                <div class="card">
                    <div class="row">
                        <div class="col">
                            <center>
                                <img width="150px" src="imgs/login.jpg" />
                            </center>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>User Login</h3>
                            </center>

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

                                    <label>UserID</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="username"></asp:TextBox>
                                </div>


                                <div class="form-group">

                                    <label>Password</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                                </div>
                                <br />
                                <div class="row">

                               <div class="col">
                                <div class="form-group">
                                    <asp:Button Class="btn btn-success btn-block btn-lg " ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                                </div>
                                     </div>
                                    </div>
                                <br />
                                <div class="checkbox">
                                    <label>
                                        <input type="checkbox" name="remember">
                                        Remember me</label>
                                </div>

                                <asp:Label ID="Label4" runat="server" Font-Size="X-Large"></asp:Label>

                            </div>
                        </div>



                    </div>

                </div>

                <a class="" href="Home.aspx"> << Back to Home </a>
            </div>
        </div>
    </div>
</asp:Content>
