<%@ Page Title="Natural Talents" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="NaturalTalents.aspx.cs" Inherits="BESTPATH._NaturalTalents" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Natural Talents</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <p>God has hard-wired each of us physically and chemically to serve His purpose, and these natural talents come to us so readily that we sometimes overlook or ignore their importance. If we embrace who we are in this area of great enjoyment and passion, we will delight ourselves in the Lord and He will give us the desires of our hearts (Psalm 37:4).</p>
        <p>This exercise calls for you to start a "journey of enjoyment" back over your life. Begin with your current or most recent assignment and go back in time as far as you can remember, listing only those things that you have always "really enjoyed doing" in your life. Include all of the hobbies that you have ever had, what you tend to do in your leisure time, how you like to spend your vacations, and anything else that reveals one of your natural and long-standing enjoyments, and therefore, possibly one of your natural talents.</p>
        <table class="table">
            <tr>
                <td class="auto-style3"><b><u>Life experience title:</u></b></td>
                <td><b><u>Really enjoyed doing:</u></b></td>
            </tr>
            <tr>
                <td class="auto-style3">1. Local trash route at 12</td>
                <td>Organizing a business</td>
            </tr>
            <tr>
                <td class="auto-style3">2. Golf club caddy every summer</td>
                <td>Playing golf with my friends</td>
            </tr>
            <tr>
                <td class="auto-style3">3. Taking my first computer class</td>
                <td>Working in MS Excel</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" class="instructions">Please choose some experiences like these from your own life that you have really enjoyed doing and list them below following the format above.</td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style5"><textarea id="TextBox4" runat="server" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style6"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
        </table>
        <br />
        <span class="instructions2">Considering all of these enjoyable experiences that you have ever had, please look for the themes of natural interest (talent) that have run throughout your life. Then, enter your top <u>three</u> natural talents below.</span>
        <br /><br />
        <table class="table">
            <tr>
                <td class="auto-style4"><b>Natural talent #1:</b></td>
                <td><asp:TextBox ID="TextBox1" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>Natural talent #2:</b></td>
                <td><asp:TextBox ID="TextBox2" runat="server"  MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>Natural talent #3:</b></td>
                <td><asp:TextBox ID="TextBox3" runat="server"  MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
        </table>
        <br /><br /><br />
        <br /><br /><br />
        <div class="right-float">
            <asp:Button ID="btnContinue" runat="server" Font-Bold="True" Font-Size="Large" PostBackUrl="~/PL/FOP/FOP_ProgressMenu.aspx" Text="Continue" Visible="False" />
            <asp:Button ID="btnSubmit" runat="server" Font-Bold="True" Font-Size="Large" OnClick="btnSubmit_Click" Text="Submit" />
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
        .auto-style3 {
            width: 50%;
        }
        .auto-style4 {
            width: 25%;
        }
        textarea {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 65%;
            height: 100%
        }
        .auto-style5 {
            height: 150px;
        }
    </style>
</asp:Content>

