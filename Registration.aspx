<%@ Page Title="Registration" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="BESTPATH._Registration" %>

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
                <td class="auto-style1"><b>Email Address (Username):</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtUsername" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style2"><asp:RegularExpressionValidator ID="revUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid email address required</asp:RegularExpressionValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Password:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtPassword" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" TextMode="Password" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td><b>Password must have at least eight characters: at least one uppercase letter, at least one lowercase letter, at least one number, and at least one special character.</b></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Confirm password:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtConfirmPassword" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" TextMode="Password" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:CompareValidator ID="cvPasswords" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Passwords do not match" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>First name:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtFirstName" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Last name:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtLastName" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>How young are you?</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtAge" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvAge" runat="server" ControlToValidate="txtAge" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Street address:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtStreetAddress" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvStreetAddress" runat="server" ControlToValidate="txtStreetAddress" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>City:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtCity" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black" ></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
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
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvState" runat="server" ControlToValidate="txtState" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Zip code:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtZipCode" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ControlToValidate="txtZipCode" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:CompareValidator ID="cvZipCode" runat="server" ControlToValidate="txtZipCode" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Invalid zip code</asp:CompareValidator></td>
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
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvCountry" runat="server" ControlToValidate="txtCountry" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Phone number:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtPhoneNumber" runat="server" MaxLength="100" AutoCompleteType="Disabled" Font-Size="Large" Width="100%" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                <td><b>Valid phone format:</b><br />1234567890</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RegularExpressionValidator ID="revPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$">Invalid phone number</asp:RegularExpressionValidator></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Security question:</b></td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlSecurityQuestion" runat="server" Width="100%" Font-Bold="True" Font-Size="Large" ForeColor="Black">
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
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvSecurityQuestion" runat="server" ControlToValidate="ddlSecurityQuestion" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Security answer:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtSecurityAnswer" runat="server" MaxLength="100" Width="100%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvSecurityAnswer" runat="server" ControlToValidate="txtSecurityAnswer" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Confirm security answer:</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtConfirmSecurityAnswer" runat="server" MaxLength="100" Width="100%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvConfirmSecurityAnswer" runat="server" ControlToValidate="txtConfirmSecurityAnswer" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:CompareValidator ID="cvSecurityAnswers" runat="server" ControlToCompare="txtSecurityAnswer" ControlToValidate="txtConfirmSecurityAnswer" ErrorMessage="Passwords do not match" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td class="auto-style1"><b>How have you been referred to our website?</b></td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlReferralSource" runat="server" Width="100%" AutoPostBack="True">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Referred by a past client who is a RUG Authorized Personal Counselor (APC)</asp:ListItem>
                    <asp:ListItem>Referred by a past client who made no mention of being a RUG APC</asp:ListItem>
                    <asp:ListItem>Church outreach</asp:ListItem>
                    <asp:ListItem>One of Jim Davis's books</asp:ListItem>
                    <asp:ListItem>Billboard</asp:ListItem>
                    <asp:ListItem>Radio</asp:ListItem>
                    <asp:ListItem>TV</asp:ListItem>
                    <asp:ListItem>None</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvReferralSource" runat="server" ControlToValidate="ddlReferralSource" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>If referred by another person, what is their name? If church outreach, what church are you from? If other, please explain.</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtReferralName" runat="server" MaxLength="900" Width="100%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvReferralName" runat="server" ControlToValidate="txtReferralName" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" Enabled="false">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>If referred by a RUG Authorized Personal Counselor, what is their email address (their username on the BPF website)?</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtRUGAPCEmailAddress" runat="server" MaxLength="900" Width="100%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style2"><asp:RequiredFieldValidator ID="rfvRUGAPCEmailAddress" runat="server" ControlToValidate="txtRUGAPCEmailAddress" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" Enabled="false">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style2"><asp:RegularExpressionValidator ID="revRUGAPCEmailAdress" runat="server" ControlToValidate="txtRUGAPCEmailAddress" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid email address required</asp:RegularExpressionValidator></td>
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
            width: 30%;
        }
        .auto-style2 {
            width: 50%;
        }
    </style>
</asp:Content>

