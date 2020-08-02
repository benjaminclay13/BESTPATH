<%@ Page Title="Registration" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="Registration2.aspx.cs" Inherits="BESTPATH._Registration2" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Registration</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <span class="instructions2">Get registered.</span>
        <br /><br />
        <table class="table">
            <tr>
                <td class="auto-style1"><b>Username:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox1" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Current password:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox2" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" TextMode="Password" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>New password:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox3" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" TextMode="Password" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td><b>Password must have at least eight characters: at least one uppercase letter, at least one lowercase letter, at least one number, and at least one special character.</b></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Confirm password:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox4" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" TextMode="Password" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="TextBox4" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="Passwords do not match" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>First name:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox5" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Last name:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox6" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>How young are you?</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox7" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox7" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Street address:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox8" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox8" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>City:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox9" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black" ></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox9" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>State:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtState" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtState" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Zip code:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox10" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox10" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style2"><asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TextBox10" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Invalid zip code</asp:CompareValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Country:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtCountry" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtCountry" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Phone number:</b></td>
                <td class="auto-style2"><asp:TextBox ID="TextBox11" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td><b>Valid phone format:</b><br />1234567890</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBox11" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox11" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$">Invalid phone number</asp:RegularExpressionValidator></td>
                <td></td>
            </tr>
        </table>
        <br /><br /><br />
        <br /><br /><br />
        <div class="right-float">
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
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
        .right-float {
            float: right;
        }
        .auto-style1 {
            width: 25%;
        }
        .auto-style2 {
            width: 50%;
        }
    </style>
</asp:Content>

