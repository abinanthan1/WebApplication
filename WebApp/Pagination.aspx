<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagination.aspx.cs" Inherits="WebApp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <div class="table-responsive">
                    <asp:GridView ID="Gridview1" runat="server" AutoGenerateColumns="false" AllowPaging="false" OnPageIndexChanging="OnPageIndexChanging" PageSize="10" CssClass="table table-bordered table-striped table-hover">
                        <Columns>
                            <asp:BoundField DataField="PersonId" HeaderText="PersonId" />
                            <asp:BoundField DataField="Firstname" HeaderText="Firstname" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="City" HeaderText="City" />
                        </Columns>
                    </asp:GridView>
                </div>

                <div class="pagination text-center">
                    <asp:Button ID="btnPrev" runat="server" Text="Previous" OnClick="btnPrev_Click" CssClass="btn btn-default" />
            
                    <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" CssClass="btn btn-default" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
