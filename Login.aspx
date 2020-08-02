<%@ Page Title="Login" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BESTPATH._Login" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Login</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <span class="instructions2">Log in to the <i>BPF Life Purpose Development Series (BLPDS)</i>!</span>
        <br /><br />
        <table class="table">
            <tr>
                <td class="auto-style1"><b>Username:</b></td>
                <td><asp:TextBox ID="txtUsername" runat="server" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="lblUsername" runat="server" Font-Bold="True" ForeColor="Red" Text="Required" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Password:</b></td>
                <td><asp:TextBox ID="txtPassword" runat="server" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:LinkButton ID="lbForgotPassword" runat="server" CausesValidation="False" Font-Bold="True" Font-Underline="True" OnClick="lbForgotPassword_Click" ForeColor="Black">Forgot Password</asp:LinkButton></td>
                <td><asp:Label ID="lblError2" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log in" />
        <br /><br />
        <asp:Label ID="lblError" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    </div>
<noscript>
    <meta HTTP-EQUIV="REFRESH" content="0; url=http://www.bestpathfoundation.com/PL/Utilities/EnableJavascript.aspx">
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
        .auto-style1 {
            width: 25%;
        }
    </style>
</asp:Content>

