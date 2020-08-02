<%@ Page Title="Number of Users In The System" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="NumberOfUsers.aspx.cs" Inherits="BESTPATH._NumberOfUsersInTheSystem" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Number of Users In The System</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <table class="table">
            <tr>
                <td class="auto-style1"><b>Number of clients</b></td>
                <td><asp:Label ID="lblClients" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Number of administrative compensation users</b></td>
                <td><asp:Label ID="lblAdminCompUsers" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Number of Phase 2 beta testers and admin users</b></td>
                <td><asp:Label ID="lblBetaTesters" runat="server" Text="14"></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Number of test users</b></td>
                <td><asp:Label ID="lblTestUsers" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Total number of users in the system</b></td>
                <td><asp:Label ID="lblTotal" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <br /><br /><br />
        <br /><br /><br />
        <div class="float-right">
            <asp:Button ID="btnContinue" runat="server" CausesValidation="False" PostBackUrl="~/PL/Admin/AdminMenu.aspx" Text="Continue" CssClass="float-right" />
        </div>
        <br /><br />
        <asp:Label ID="lblError" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .body {
            font-family: "Segoe UI";
            font-size: large;
            color: black;
            line-height: 140%;
        }
        .instructions {
            font-family: "Segoe UI";
            font-size: x-large;
            color: black;
            line-height: 140%;
            font-weight: bold;
            text-decoration: underline;
        }
        .instructions2 {
            font-family: "Segoe UI";
            font-size: x-large;
            color: black;
            line-height: 140%;
            font-weight: bold;
        }
        .table {
            width: 100%;
        }
        .right-float {
            float: right;
        }
        .auto-style1 {
            width: 45%;
        }
    </style>
</asp:Content>

