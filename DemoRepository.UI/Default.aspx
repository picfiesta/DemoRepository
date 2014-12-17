<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Testing Repository Pattern</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Orders</h3>
    <p>
        <asp:DataGrid ID="dgOrders" runat="server">
            <Columns>
                <asp:TemplateColumn HeaderText="OrderId"></asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="CompanyName"></asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Country"></asp:TemplateColumn>
            </Columns>
        </asp:DataGrid>

    </p>
    </asp:Content>