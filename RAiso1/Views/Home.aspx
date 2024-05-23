<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RAiso1.Views.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%foreach (var s in stationeries){%>
        <div class="stationeryCard" >
            <h3><%=s.Name%></h3>
            <h4><%=s.Price %></h4>
            <%if (RAiso1.Handlers.UserHandler.loggedUser != null && RAiso1.Handlers.UserHandler.loggedUser.Role =="Admin"){  %>
                <asp:Button ID="Delete" runat="server" Text="Delete" />
                <asp:Button ID="Edit" runat="server" Text="Edit" />

            <%} %>

        </div>

    <%}%>

</asp:Content>
