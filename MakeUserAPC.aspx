<%@ Page Title="Make User APC" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="MakeUserAPC.aspx.cs" Inherits="BESTPATH._MakeUserAPC" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Make User APC</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <table class="table">
            <tr>
                <td colspan="2"><span class="instructions">Make user a RUG APC:</span></td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Email address (username):</b></td>
                <td><asp:TextBox ID="txtIsRUGAPC" runat="server" Width="65%" Font-Names="Arial" ForeColor="Black" ></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2"><span class="instructions">Unmake user a RUG APC:</span></td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Email address (username):</b></td>
                <td><asp:TextBox ID="txtIsNotRUGAPC" runat="server" Width="65%" Font-Names="Arial" ForeColor="Black" ></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Button ID="btnSubmit2" runat="server" Text="Submit" OnClick="btnSubmit2_Click" /></td>
                <td></td>
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
            width: 25%;
        }
    </style>
</asp:Content>

