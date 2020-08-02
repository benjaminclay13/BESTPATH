<%@ Page Title="Focus Experience #8" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="FocusExperience8.aspx.cs" Inherits="BESTPATH._FocusExperience8" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Focus Experience #8</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <span class="instructions">On the Focus Demonstration Worksheet page, you named eight different work experiences that you have had, which demonstrate that you have been successful using each of the six skill groups that you defined on the Focus Analysis Worksheet page. Now, on these Focus Experience pages, you will remember and describe those eight work experiences in as much detail as you can.</span>
        <br /><br />
        <p>These Focus Experience pages may take some time to complete. Therefore, we strongly recommend that you visit the Downloads page, where there is a Focus Experience form. Download this form to your computer, complete it in MS Word for each of your Focus Experiences, and save these to your computer. Then when you are finished with each, simply return to these pages, click the refresh button in your web browser if you have stayed on any of these pages while completing the Focus Experience form, and then simply copy and paste all of your answers into the corresponding textboxes on these pages. Additionally, as per our web host, only 900 characters are allowed for each of your answers, and therefore, if you find that any of your answers are truncated when copying and pasting these from the Focus Experience form, do not be concerned about this, because you will have saved all of your Focus Experiences to your computer using the Focus Experience form.</p>
        <p><b>IMPORTANT NOTE:</b> If you have stayed on any of these pages while completing the Focus Experience form, then you will need to click the refresh button in your web browser BEFORE you start completing these pages. This will ensure that you have the full 2 hours to complete these pages.</p>
        <p><b>REMEMBER: YOU WILL ONLY HAVE 2 HOURS TO COMPLETE EACH OF THESE PAGES!</b> If you do not, you will be timed out, and then have to complete them again!</p>
        <br />
        <table class="table">
            <tr>
                <td colspan="2"><b><u>*Wildcard*</u></b></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2"><b><u>Experience #8 title:</u></b>&nbsp;<asp:Label ID="lblExperienceTitle" runat="server" Font-Size="Large"></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2"><b><u>Meaningful experience explanation:</u></b></td>
            </tr>
            <tr>
                <td class="auto-style2"><b>Where:</b></td>
                <td class="auto-style3"><textarea id="txtQ1" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtQ1" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>Year and length of accomplishment:</b></td>
                <td class="auto-style5"><textarea id="txtQ2" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtQ2" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><b>My title and/or functional role:</b></td>
                <td class="auto-style7"><textarea id="txtQ3" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtQ3" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"><b>What was involved ($) and/or was at risk:</b></td>
                <td class="auto-style9"><textarea id="txtQ4" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtQ4" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><b>What was the problem, challenge, and/or opportunity faced:</b></td>
                <td class="auto-style7"><textarea id="txtQ5" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtQ5" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"><b>What skills, abilities, and/or talents did you specifically use:</b></td>
                <td class="auto-style3"><textarea id="txtQ6" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtQ6" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>Who else was closely involved and how well did you work with them:</b></td>
                <td class="auto-style5"><textarea id="txtQ7" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtQ7" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"><b>How did you feel as you were doing and completing this experience:</b></td>
                <td class="auto-style9"><textarea id="txtQ8" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtQ8" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                <td class="auto-style7"><textarea id="txtQ9" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtQ9" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"><b>Were there any awards and/or favorable comments received:</b></td>
                <td class="auto-style9"><textarea id="txtQ10" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtQ10" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>What changes and/or long-term impact did this have on the organization:</b></td>
                <td class="auto-style5"><textarea id="txtQ11" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtQ11" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                <td class="auto-style5"><textarea id="txtQ12" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtQ12" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"><b>Now, state in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE AT DOING in action terms:</b></td>
                <td class="auto-style11"><textarea id="txtQ13" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtQ13" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
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
        .auto-style1 {
            width: 50%;
        }
        textarea {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 75%;
            height: 100%
        }
        .auto-style2 {
            width: 50%;
            height: 150px;
        }
        .auto-style3 {
            height: 150px;
        }
        .auto-style4 {
            width: 50%;
            height: 152px;
        }
        .auto-style5 {
            height: 152px;
        }
        .auto-style6 {
            width: 50%;
            height: 153px;
        }
        .auto-style7 {
            height: 153px;
        }
        .auto-style8 {
            width: 50%;
            height: 149px;
        }
        .auto-style9 {
            height: 149px;
        }
        .auto-style10 {
            width: 50%;
            height: 159px;
        }
        .auto-style11 {
            height: 159px;
        }
    </style>
</asp:Content>

