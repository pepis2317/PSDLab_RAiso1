<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="tDetailsPage.aspx.cs" Inherits="RAiso1.Views.tDetailsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="CartRepeater" runat="server">
        <ItemTemplate>
            <div>
                <h4><%# GetStationeryName(Container.DataItem) %></h4>
                <h4><%# GetStationeryPrice(Container.DataItem) %></h4>
                <h4><%# Eval("Quantity") %></h4>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
