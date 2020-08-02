<%@ Page Title="Covenant Partnership Agreement" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="CovenantPartnershipAgreement.aspx.cs" Inherits="BESTPATH._CovenantPartnershipAgreement" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Covenant Partnership Agreement</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <p><b><u>Introduction:</u></b> This Covenant Partnership Agreement hereby entered into by BestPath Foundation (BPF) / Resources Unlimited Group (RUG) and the Covenant Partner (CP) named below is considered to be a Covenant with and unto the Lord Jesus Christ. The purpose of this Covenant Partnership Agreement is to set out and clarify the conditions, services, commitments, and expectations of the parties involved.</p>
        <p><b><u>Preamble:</u></b> Whereas, the CP desires to glorify God through a firm grounding in the Biblical and practical aspects of life-path management, focusing on purpose, and life-skills application; and whereas, BPF / RUG desires to glorify God through a prayerful process of professional consultation in these areas of need through Personal Life Purpose Coaching & Personal Counseling; now, therefore, do these two parties mutually agree to submit to God’s will and way in fulfilling this Covenant Partnership Agreement.</p>
        <p><b><u>Part I. Covenant services:</u></b> Within the context of this Covenant Partnership Agreement, BPF / RUG shall provide the following services:</p>
        <ol>
            <li>Develop and implement individualized counseling analyses and processes for CP, as defined in the BPF Life Purpose Development Series (BLPDS) found in BestPath Resource Tools at BestPathFoundation.com Home Page,</li>
            <br />
            <li>Facilitate any and all Modules of the O-P-E-N-S Program to CP as needed via streaming video, audio, webpages, and downloadable documents,</li>
            <br />
            <li>Provide a Biblical foundation for all teachings and counsel (both overt and covert) with prayer, and</li>
            <br />
            <li>Provide ongoing / timely follow-up with CP for a period of one year via Authorized Personal Counsel.</li>
        </ol>
        <p><b><u>Part II. Time and compensation:</u></b> This Covenant Partnership Agreement shall commence 72 hours after the below affirmed date and continue for one calendar year. For the most part, these services will be delivered unlimited to the CP via the BestPath Foundation website (BestPathFoundation.com), in the form of streaming video, audio, webpages, and downloadable documents, as well as guided counsel via phone and/or email by your APC. BPF / RUG offers a 100% money back satisfaction guarantee so long as a good faith effort has been made by the CP to complete a review of all of the BLPDS website and the materials contained therein, and CP to complete a review of all of the BLPDS website and the materials contained therein, and take the appropriate actions as directed. If still so desired, and the CP submits a written declaration that this investment was of no value to the CP, then the CP will receive a refund at that time.</p>  
        <p><b><u>Part III. Payment covenant:</u></b> It is believed to be God’s will that BPF / RUG services are being provided to the CP, and as such, it is also believed that God will provide the CP with the resources for payment according to His will, in His way, and in His time! The specific payment for these BPF / RUG services will be a good faith commitment given at the start of this agreement of $1,500.00 (U.S.). It is believed that the best use and delivery of BPF / RUG services are on a consistent, but also on an as-needed and just-in-time basis, and the best benefits will be realized in an active Personal Life Purpose Coach mentoring relationship with your APC, so frequent and timely contact is encouraged.</p>
        <p><b><u>Part IV. Good faith clause:</u></b> Parties agree to resolve all matters of disagreement between them through prayer and discussion, foregoing litigation or other adversarial means. It is also understood, that on successful completion of the 24 hours of training, CP has the opportunity to establish his/her own Business Profit Center as a RUG Authorized Personal Counselor. BPF / RUG will assist in this good endeavor as explained in the program.</p>
        <p><b><u>Part V. Execution:</u></b> This agreement is executed as the sole and binding agreement of the parties so named below:</p> 
        <table class="table">
            <tr>
                <td class="auto-style1"><b>First and last name (digital signature):</b></td>
                <td><asp:TextBox ID="txtFullName" runat="server" MaxLength="100" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="rfvFullName" runat="server" ControlToValidate="txtFullName" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>Date:</b></td>
                <td><asp:TextBox ID="txtDate" runat="server" MaxLength="100" Width="65%" ReadOnly="True" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RequiredFieldValidator ID="rfvDate" runat="server" ControlToValidate="txtDate" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td><b>BPF / RUG Owner:</b></td>
                <td><span style="font-family: Brush Script MT; font-size: xx-large;">James W. Davis affirmation</span></td>
            </tr>
        </table>
        <br />
        <p><b>In correspondence with the Consumer Protection Buyer’s Remorse, within 72 hours, we will refund your money 100% with no questions asked if desired.</b></p>
        <br />
        </form>
        <form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top">
            <input type="hidden" name="cmd" value="_s-xclick">
            <input type="hidden" name="hosted_button_id" value="8A29E6CRZRJHY">
            <input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_buynowCC_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
            <img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1">
        </form>
        <br />
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
            width: 40%;
        }
    </style>
</asp:Content>

