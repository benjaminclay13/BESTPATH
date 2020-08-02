<%@ Page Title="Focus Consolidation Worksheet" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="FocusConsolidationWorksheet.aspx.cs" Inherits="BESTPATH._FocusConsolidationWorksheet" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Focus Consolidation Worksheet</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <span class="instructions">Please review your selections for the 10 personal analyses involved in the <i>Focus on Purpose process</i>, then please select print directly from your web browser, then choose “save as PDF,” from the selection, choose the location where you would like to save this file, name it whatever you choose, then once you have it saved to your computer, please print this file for your records as well.</span>
        <br /><br />
        <table class="table">
            <tr>
                <td class="instructions2">1.</td>
                <td colspan="2"><b>From the Focus Analysis Worksheet page, the following are your top 6 most marketable skill groups:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>1)</b>&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>2)</b>&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>3)</b>&nbsp;<asp:Label ID="Label3" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>4)</b>&nbsp;<asp:Label ID="Label4" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>5)</b>&nbsp;<asp:Label ID="Label5" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>6)</b>&nbsp;<asp:Label ID="Label6" runat="server"></asp:Label><br /></td>
            </tr>
            <tr>
                <td class="instructions2">2.</td>
                <td colspan="2"><br /><b>From the Natural Talents page, the following are your top 3 natural talents that you have always enjoyed doing:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>1)</b>&nbsp;<asp:Label ID="Label7" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>2)</b>&nbsp;<asp:Label ID="Label8" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>3)</b>&nbsp;<asp:Label ID="Label9" runat="server"></asp:Label><br /></td>
            </tr>
            <tr>
                <td class="instructions2">3.</td>
                <td colspan="2"><br /><b>From the Total Spiritual Gifts page, the following are your top 3 spiritual gifts that you and others feel are your most evident, as well as your comments concerning how each of these gifts has most strongly manifested in you:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2">
                    <table class="table">
                        <tr>
                            <td class="auto-style1"><br /><b><u>Spiritual gifts:</u></b></td>
                            <td><br /><b><u>Your comments:</u></b></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>1)</b>&nbsp;<asp:Label ID="Label10" runat="server"></asp:Label></td>
                            <td><br /><asp:Label ID="Label11" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>2)</b>&nbsp;<asp:Label ID="Label12" runat="server"></asp:Label></td>
                            <td><br /><asp:Label ID="Label13" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>3)</b>&nbsp;<asp:Label ID="Label14" runat="server"></asp:Label><br /></td>
                            <td><br /><asp:Label ID="Label15" runat="server"></asp:Label><br /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="instructions2">4.</td>
                <td colspan="2"><br /><b>From the Personal Management Style page, the following is your personal management style as well as your comments concerning how this style is most true of you:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2">
                    <table class="table">
                        <tr>
                            <td class="auto-style1"><br /><b><u>Personal management style:</u></b></td>
                            <td><br /><b><u>Your comments:</u></b></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>1)</b>&nbsp;<asp:Label ID="Label16" runat="server"></asp:Label></td>
                            <td><br /><asp:Label ID="Label17" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>2)</b>&nbsp;<asp:Label ID="Label18" runat="server"></asp:Label></td>
                            <td><br /><asp:Label ID="Label19" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>3)</b>&nbsp;<asp:Label ID="Label20" runat="server"></asp:Label></td>
                            <td><br /><asp:Label ID="Label21" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>4)</b>&nbsp;<asp:Label ID="Label22" runat="server"></asp:Label><br /></td>
                            <td><br /><asp:Label ID="Label23" runat="server"></asp:Label><br /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="instructions2">5.</td>
                <td colspan="2"><br /><b>From the Perception Response Summary page, the following are the themes of the answers that others have provided to each of the following questions:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>1) What do you believe are the best situations or environments for me to work in?</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><asp:Label ID="Label24" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>2) What do you believe are the things that motivate me the most?</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><asp:Label ID="Label25" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>3) What do you believe are my best skills, qualities, and strong points?</b></td>
            </tr>
            <tr>
                <td></td>
                <td class="auto-style10" colspan="2"><br /><asp:Label ID="Label26" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>4) What do you believe are the things I should avoid in my next assignment?</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><asp:Label ID="Label27" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>5) What do you believe I should work on improving the most in my life?</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><asp:Label ID="Label28" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>6) In your opinion, what is the perfect assignment for me?</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><asp:Label ID="Label29" runat="server"></asp:Label><br /></td>
            </tr>
            <tr>
                <td class="instructions2">6.</td>
                <td colspan="2"><br /><b>From the Fundamental Life Motivators page, the following are your top 3 life motivators that are most important to you right now as you look down your life purpose path:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>1)</b>&nbsp;<asp:Label ID="Label30" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>2)</b>&nbsp;<asp:Label ID="Label31" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>3)</b>&nbsp;<asp:Label ID="Label32" runat="server"></asp:Label><br /></td>
            </tr>
            <tr>
                <td class="instructions2">7.</td>
                <td colspan="2"><br /><b>From the Education / Training Inventory page, the following are your top 3 responsibilities that you would like to be a part of your next assignment:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>1)</b>&nbsp;<asp:Label ID="Label33" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>2)</b>&nbsp;<asp:Label ID="Label34" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>3)</b>&nbsp;<asp:Label ID="Label35" runat="server"></asp:Label><br /></td>
            </tr>
            <tr>
                <td class="instructions2">8.</td>
                <td colspan="2"><br /><b>From the Practical Skills page, the following are your top 3 practical skills with which you have achieved the greatest level of skill and successful experience:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>1)</b>&nbsp;<asp:Label ID="Label36" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><strong>2)</strong>&nbsp;<asp:Label ID="Label37" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>3)</b>&nbsp;<asp:Label ID="Label38" runat="server"></asp:Label><br /></td>
            </tr>
            <tr>
                <td class="instructions2">9.</td>
                <td colspan="2"><br /><b>From the Expressing Your Personal Genius page, the following are your top 3 areas of personal genius as well as your comments concerning how each of these best relates to you:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2">
                    <table class="table">
                        <tr>
                            <td class="auto-style1"><br /><b><u>Personal genius areas:</u></b></td>
                            <td><br /><b><u>Your comments:</u></b></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>1)</b>&nbsp;<asp:Label ID="Label39" runat="server"></asp:Label></td>
                            <td><br /><asp:Label ID="Label40" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>2)</b>&nbsp;<asp:Label ID="Label41" runat="server"></asp:Label></td>
                            <td><br /><asp:Label ID="Label42" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><br /><b>3)</b>&nbsp;<asp:Label ID="Label43" runat="server"></asp:Label><br /></td>
                            <td><br /><asp:Label ID="Label44" runat="server"></asp:Label><br /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="instructions2">10.</td>
                <td colspan="2"><br /><b>From the Creativity Cycle page, the following is your top preference for contributing value in the creativity cycle:</b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><br /><b>1)</b>&nbsp;<asp:Label ID="Label45" runat="server"></asp:Label></td>
            </tr>
        </table>
        <br /><br /><br />
        <br /><br /><br />
        <div class="right-float">
            <asp:Button ID="btnContinue" runat="server" Text="Continue" CssClass="float-right" OnClick="btnContinue_Click" />
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
            width: 40%;
        }
    </style>
</asp:Content>

