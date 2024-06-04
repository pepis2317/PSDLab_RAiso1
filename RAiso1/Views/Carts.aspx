<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="Carts.aspx.cs" Inherits="RAiso1.Views.Carts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="CartRepeater" runat="server">
        <ItemTemplate>
            <div>
                <h4><%# Eval("Stationery.Name") %></h4>
                <h4><%# Eval("Stationery.Price") %></h4>
                <h4><%# Eval("Quantity") %></h4>
                <asp:Button ID="UpdateButton" runat="server" Text="Update" CommandName="Update" CommandArgument='<%# Eval("Stationery.StationeryID") %>' OnCommand="Cart_Command"/>
                <asp:Button ID="RemoveButton" runat="server" Text="Remove" />
            </div>

        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
