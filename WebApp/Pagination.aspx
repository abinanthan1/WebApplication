<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagination.aspx.cs" Inherits="WebApp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div>
                    <asp:GridView ID="Gridview1" runat="server" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="true" OnPageIndexChanging="OnPageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" OnSorting="Gridview1_Sorting" style="border-top: none;">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
              
                        <Columns>
                            <asp:BoundField DataField="PersonId" HeaderText="PersonId" SortExpression="PersonID"/>
                            <asp:BoundField DataField="Firstname" HeaderText="Firstname" SortExpression="Firstname" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"/>
                            <asp:BoundField DataField="City" HeaderText="City"  SortExpression="City"/>
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerSettings Mode="NumericFirstLast" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
            </div>
     
</asp:Content>
