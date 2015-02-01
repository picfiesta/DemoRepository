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
        <asp:DataGrid ID="dgOrders" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateColumn HeaderText="OrderId">
                    <ItemTemplate>
                        <asp:Label ID="lblOrderId" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "OrderId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="CompanyName">
                         <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "CompanyName") %>'></asp:Label>
                    </ItemTemplate>
               
                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Country">
                         <ItemTemplate>
                        <asp:Label ID="Label2"  runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Country") %>'></asp:Label>
                    </ItemTemplate>
               
                </asp:TemplateColumn>
            </Columns>
        </asp:DataGrid>

    </p>
    </asp:Content>