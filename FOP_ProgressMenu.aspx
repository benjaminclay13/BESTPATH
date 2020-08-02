<%@ Page Title="FOP Progress Menu" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="FOP_ProgressMenu.aspx.cs" Inherits="BESTPATH._FOP_ProgressMenu" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>FOP Progress Menu</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <span class="instructions2"><b>Welcome to <i>Focus on Purpose</i>!</b></span>
        <br /><br />
        <span><b><i>Focus on Purpose (FOP)</i></b> has been designed for you to complete at your own pace, one step at a time. It does not need to be completed quickly or all at once. Feel free to complete <b><i>Focus on Purpose</i></b> at your own pace, as much or as little as you can at a time, as you have time and energy to do so; however, it would be greatly to your advantage to commit to continuity in your efforts in order to reap the best benefits. May God richly bless you and your time invested here focusing on your God-given purpose for career and life!</span>
        <br />
        <table class="table">
            <tr>
                <td></td>
                <td class="auto-style1"><b><u><i>Focus on Purpose</i> (Module 2) - A process of Resources Unlimited Group:</u></b></td>
                <td><b><u>Status:</u></b></td>
                <td><b><u>Completion date:</u></b></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>1.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PL/FOP/Overview.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Overview</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus1" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate1" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>2.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/PL/FOP/Introduction.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Introduction</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus2" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate2" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>3.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/PL/FOP/ResourcesProvided.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Resources Provided</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus3" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate3" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>4.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/PL/FOP/BeforeYouBegin.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Before You Begin</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus4" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate4" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>5.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/PL/FOP/NaturalTalents.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Natural Talents</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus5" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate5" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label6" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>6.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/PL/FOP/PerceptionResponse.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Perception Response</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus6" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate6" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>7.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/PL/FOP/IdentifyingYourSpiritualGifts.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Identifying Your Spiritual Gifts</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus7" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate7" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label8" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>8.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/PL/FOP/FocusAnalysisWorksheet.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Analysis Worksheet</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus8" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate8" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label9" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>9.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/PL/FOP/FocusDemonstrationWorksheet.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Demonstration Worksheet</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus9" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate9" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label10" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>10.</b>&nbsp;<asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/PL/FOP/WaysToEvaluateYourEffect.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Ways To Evaluate Your Effect</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus10" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate10" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label11" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>11.</b>&nbsp;<asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/PL/FOP/FocusSample1.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Sample #1</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus11" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate11" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label12" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>12.</b>&nbsp;<asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/PL/FOP/FocusSample2.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Sample #2</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus12" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate12" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label13" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>13.</b>&nbsp;<asp:HyperLink ID="HyperLink13" runat="server" NavigateUrl="~/PL/FOP/FocusExperience1.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Experience #1</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus13" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate13" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label14" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>14.</b>&nbsp;<asp:HyperLink ID="HyperLink14" runat="server" NavigateUrl="~/PL/FOP/FocusExperience2.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Experience #2</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus14" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate14" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label15" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>15.</b>&nbsp;<asp:HyperLink ID="HyperLink15" runat="server" NavigateUrl="~/PL/FOP/FocusExperience3.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Experience #3</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus15" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate15" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label16" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>16.</b>&nbsp;<asp:HyperLink ID="HyperLink16" runat="server" NavigateUrl="~/PL/FOP/FocusExperience4.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Experience #4</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus16" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate16" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label17" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>17.</b>&nbsp;<asp:HyperLink ID="HyperLink17" runat="server" NavigateUrl="~/PL/FOP/FocusExperience5.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Experience #5</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus17" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate17" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label18" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>18.</b>&nbsp;<asp:HyperLink ID="HyperLink18" runat="server" NavigateUrl="~/PL/FOP/FocusExperience6.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Experience #6</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus18" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate18" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label19" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>19.</b>&nbsp;<asp:HyperLink ID="HyperLink19" runat="server" NavigateUrl="~/PL/FOP/FocusExperience7.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Experience #7</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus19" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate19" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label20" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>20.</b>&nbsp;<asp:HyperLink ID="HyperLink20" runat="server" NavigateUrl="~/PL/FOP/FocusExperience8.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Experience #8</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus20" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate20" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label21" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>21.</b>&nbsp;<asp:HyperLink ID="HyperLink21" runat="server" NavigateUrl="~/PL/FOP/PersonalManagementStyle.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Personal Management Style</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus21" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate21" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label22" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>22.</b>&nbsp;<asp:HyperLink ID="HyperLink22" runat="server" NavigateUrl="~/PL/FOP/FundamentalLifeMotivators.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Fundamental Life Motivators</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus22" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate22" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label23" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>23.</b>&nbsp;<asp:HyperLink ID="HyperLink23" runat="server" NavigateUrl="~/PL/FOP/EducationTrainingInventory.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Education / Training Inventory</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus23" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate23" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label24" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>24.</b>&nbsp;<asp:HyperLink ID="HyperLink24" runat="server" NavigateUrl="~/PL/FOP/PracticalSkills.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Practical Skills</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus24" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate24" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label25" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>25.</b>&nbsp;<asp:HyperLink ID="HyperLink25" runat="server" NavigateUrl="~/PL/FOP/ExpressingYourPersonalGenius.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Expressing Your Personal Genius</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus25" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate25" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label26" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>26.</b>&nbsp;<asp:HyperLink ID="HyperLink26" runat="server" NavigateUrl="~/PL/FOP/CreativityCycle.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Creativity Cycle</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus26" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate26" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label27" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>27.</b>&nbsp;<asp:HyperLink ID="HyperLink27" runat="server" NavigateUrl="~/PL/FOP/PerceptionResponseSummary.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Perception Response Summary</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus27" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate27" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label28" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>28.</b>&nbsp;<asp:HyperLink ID="HyperLink28" runat="server" NavigateUrl="~/PL/FOP/TotalSpiritualGifts.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Total Spiritual Gifts</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus28" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate28" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label29" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>29.</b>&nbsp;<asp:HyperLink ID="HyperLink29" runat="server" NavigateUrl="~/PL/FOP/FocusConsolidationWorksheet.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Focus Consolidation Worksheet</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus29" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate29" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label30" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>30.</b>&nbsp;<asp:HyperLink ID="HyperLink30" runat="server" NavigateUrl="~/PL/FOP/Congratulations.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Congratulations!</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus30" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate30" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label31" runat="server" Visible="False"></asp:Label></td>
                <td class="auto-style1"><b>31.</b>&nbsp;<asp:HyperLink ID="HyperLink31" runat="server" NavigateUrl="~/PL/FOP/MarketingDocumentsCreation.aspx" Font-Size="Large" ForeColor="Blue" Font-Bold="true">Marketing Documents Creation</asp:HyperLink></td>
                <td><asp:Label ID="lblStatus31" runat="server" Text="Incomplete"></asp:Label></td>
                <td><asp:Label ID="lblDate31" runat="server" Visible="False"></asp:Label></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td></td>
                <td colspan="3"><b><u>Supplementary pages:</u></b></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="3"><b>A.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink37" runat="server" NavigateUrl="~/PL/Membership/ChangePassword.aspx" Font-Size="Large" ForeColor="Blue"  Font-Bold="true">Change Password</asp:HyperLink></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="3"><b>B.</b>&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink38" runat="server" NavigateUrl="~/PL/FOP/Downloads.aspx" Font-Size="Large" ForeColor="Blue"  Font-Bold="true">Downloads</asp:HyperLink></td>
            </tr>
        </table>
        <br /><br /><br />
        <asp:Label ID="lblError" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    </div>
<noscript>
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
            width: 75%;
        }
    </style>
</asp:Content>

