<%@ Page Title="Create User" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="BESTPATH._CreateUser" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Create User</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <table class="table">
            <tr>
                <td class="auto-style1"><b>First name:</b></td>
                <td><asp:TextBox ID="txtFirstName" runat="server" MaxLength="100" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Last name:</b></td>
                <td><asp:TextBox ID="txtLastName" runat="server" MaxLength="100" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtLastName" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Username:</b></td>
                <td><asp:TextBox ID="txtUsername" runat="server" MaxLength="100" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid email address required</asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>User type:</b></td>
                <td>
                    <asp:DropDownList ID="ddlRole" runat="server" Width="65%" Font-Bold="True" Font-Size="Large" ForeColor="Black">
                        <asp:ListItem>Client</asp:ListItem>
                        <asp:ListItem>Admin Comp</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Counselor:</b></td>
                <td><asp:DropDownList ID="ddlCounselor" runat="server" Width="65%" Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Security question:</b></td>
                <td>
                    <asp:DropDownList ID="ddlSecurityQuestion" runat="server" Width="65%" Font-Bold="True" Font-Size="Large" ForeColor="Black">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>What is your mother's maiden name?</asp:ListItem>
                        <asp:ListItem>What is your pet's name?</asp:ListItem>
                        <asp:ListItem>In what city were you born?</asp:ListItem>
                        <asp:ListItem>What is the name of your first school?</asp:ListItem>
                        <asp:ListItem>On what street did you grow up on?</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlSecurityQuestion" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Security answer:</b></td>
                <td><asp:TextBox ID="txtSecurityAnswer" runat="server" MaxLength="100" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSecurityAnswer" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Confirm security answer:</b></td>
                <td><asp:TextBox ID="txtConfirm" runat="server" MaxLength="100" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtConfirm" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtSecurityAnswer" ControlToValidate="txtConfirm" ErrorMessage="Passwords do not match" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Button ID="btnCreate" runat="server" Font-Bold="True" Font-Size="Large" OnClick="btnCreate_Click" Text="Create" /></td>
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

