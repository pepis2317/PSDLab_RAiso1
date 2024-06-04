<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RAiso1.Views.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="StationeryRepeater" runat="server">
        <ItemTemplate>
            <div class="stationeryCard">
                <h3><%# Eval("Name") %></h3>
                <h4><%# Eval("Price") %></h4>
                <asp:Button ID="Button1" runat="server" Text="Details" CommandName="Details" CommandArgument='<%# Eval("StationeryID") %>' OnCommand="Stationery_Command" />
                <asp:PlaceHolder ID="AdminButtonsPlaceholder" runat="server" Visible='<%# IsAdmin %>'>
                    <asp:Button ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("StationeryID") %>' OnCommand="Stationery_Command" />
                    <asp:Button ID="EditButton" runat="server" Text="Edit" CommandName="Edit" CommandArgument='<%# Eval("StationeryID") %>' OnCommand="Stationery_Command" />
                </asp:PlaceHolder>
            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>
