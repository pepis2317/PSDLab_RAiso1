<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="InsertStationery.aspx.cs" Inherits="RAiso1.Views.InsertStationery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="NameLabel" runat="server" Text="Stationery name"></asp:Label>
        <asp:TextBox ID="NameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="PriceLabel" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="PriceTB" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="InsertButton" runat="server" Text="Insert" OnClick="InsertButton_Click" />
    <asp:Label ID="Message" runat="server" Text=""></asp:Label>
</asp:Content>
