<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="RAiso1.Views.TransactionHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="CartRepeater" runat="server">
        <ItemTemplate>
            <div>
                <h4><%# Eval("TransactionID") %></h4>
                <h4><%# Eval("TransactionDate") %></h4>
                <h4><%# Eval("User.Username") %></h4>
                <asp:Button ID="DetailsButton" runat="server" Text="Details" CommandName="Details" CommandArgument='<%# Eval("TransactionID") %>' OnCommand="DetailsButton_Command" />
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
