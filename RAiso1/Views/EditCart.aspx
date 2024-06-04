<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="EditCart.aspx.cs" Inherits="RAiso1.Views.EditCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="NameLabel" runat="server" Text=""></asp:Label>
    <asp:Label ID="PriceLabel" runat="server" Text=""></asp:Label>
    <div>
        <asp:Button ID="DecreaseButton" runat="server" Text="Decrease" OnClick="DecreaseButton_Click" />
        <asp:Label ID="Counter" runat="server" Text="0"></asp:Label>
        <asp:Button ID="IncreaseButton" runat="server" Text="Increase" OnClick="IncreaseButton_Click" />
    </div>

    <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    <asp:Button ID="UpdateButton" runat="server" Text="Update Cart" OnClick="UpdateButton_Click" />
</asp:Content>
