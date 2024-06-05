<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="RAiso1.Views.UpdateProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="NameLabel" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="GenderLabel" runat="server" Text="Gender"></asp:Label>
        <asp:DropDownList ID="GenderDD" runat="server">
            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="DobLabel" runat="server" Text="Date of Birth"></asp:Label>
        <asp:Calendar ID="DobCalendar" runat="server"></asp:Calendar>
    </div>
    <div>
        <asp:Label ID="AddressLabel" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="AddressTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="PhoneLabel" runat="server" Text="Phone"></asp:Label>
        <asp:TextBox ID="PhoneTB" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="RememberLabel" runat="server" Text="Remember me"></asp:Label>
        <asp:CheckBox ID="Remember" runat="server" />
    </div>
    <div>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
    </div>
</asp:Content>
