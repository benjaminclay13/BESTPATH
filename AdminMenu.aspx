<%@ Page Title="Admin Menu" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="AdminMenu.aspx.cs" Inherits="BESTPATH._AdminMenu" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Admin Menu</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <p><b>1.</b>&nbsp;&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/PL/Admin/CreateUser.aspx" Font-Bold="True" ForeColor="Blue">Create User</asp:HyperLink></p>
        <p><b>2.</b>&nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PL/Admin/ClientStatus.aspx" Font-Bold="True" ForeColor="Blue">Client Status</asp:HyperLink></p>
        <p><b>3.</b>&nbsp;&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/PL/Admin/NeedsAssessments.aspx" Font-Bold="True" ForeColor="Blue">Needs Assessments</asp:HyperLink></p>
        <p><b>4.</b>&nbsp;&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/PL/Admin/EmailHub.aspx" Font-Bold="True" ForeColor="Blue">Email Hub</asp:HyperLink></p>
        <p><b>5.</b>&nbsp;&nbsp;<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/PL/Admin/NumberOfUsers.aspx" Font-Bold="True" ForeColor="Blue">Number of Users</asp:HyperLink></p>
        <p><b>6.</b>&nbsp;&nbsp;<asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/PL/Admin/MakeUserAPC.aspx" Font-Bold="True" ForeColor="Blue">Make User RUG APC</asp:HyperLink></p>
    </div>
    </div>
<noscript>
</noscript>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .body {
            font-family: "Segoe UI";
            font-size: large;
            color: black;
            line-height: 140%;
        }
    </style>
</asp:Content>

