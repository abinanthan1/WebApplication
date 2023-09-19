<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



                              

                                    <label>UserID</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="username"></asp:TextBox>
                               


                                

                                    <label>Password</label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                               
                                <br />
                                
                               
                                    <asp:Button Class="btn btn-success btn-block btn-lg " ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                              
                                <br />


                                <asp:Label ID="Label4" runat="server" Font-Size="X-Large"></asp:Label>

</asp:Content>
