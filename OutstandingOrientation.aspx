<%@ Page Title="Outstanding Orientation (Module 1)" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="OutstandingOrientation.aspx.cs" Inherits="BESTPATH._OutstandingOrientation" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Outstanding Orientation (Module 1)</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <span class="instructions">Primer:</span>
        <br />
        <p class="instructions2">Please click on the supporting document's link below to download this document to your computer. Then open this document, so as to follow along while listening to the "Moving from work to worship" audio below. Once completed, continue on to Module 1 part 1 - the "Outstanding Orientation" career seminar video below.</p>
        <p class="instructions">Supporting document:</p>
        <p><b>Please click on the link below to download this document to your computer. It will be downloaded to the Downloads folder on your computer (unless you have changed your web browser's default settings). If asked whether to open or save, choose save.</b></p>
        <asp:LinkButton ID="LinkButton12" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton12_Click">Moving from work to worship.pdf</asp:LinkButton>
        <br />
        <p class="instructions"><b>Moving from work to worship.mp3 (about 33 minutes)</b></p>
        <div id="player1">
            <audio src="/Docs/BLPDS/Module_1/Primer/Moving_from_work_to_worship.mp3" controls preload="auto">
                Your web browser does not support HTML5 media player.
            </audio>
        </div>
        <br /><br />
        <span class="instructions">Part 1:</span>
        <p>This educational encounter will help you to recognize that most of the things you have been told about how the marketplace really operates are lies and are keeping you in bondage. You will learn that you have been looking for your next work assignment in the wrong places and in the wrong ways. There are truths in the marketplace that come from God’s order of things, and if you follow these proven ways, marketing yourself is not what someone else will do for you, but what God will do through you. This truth of how the marketplace really operates is practically explained and applied relating to the real world issues of discovering your calling, defining your focus, building your resume and professional advertisement, finding jobs in the known and unknown markets, creating positions around your unique combination of skills, talents, and gifts, interviewing, negotiating salary, and a myriad of other issues. Jim Davis, Owner of Resources Unlimited Group and BestPath Foundation, who has been leading these career seminars to small groups for over 25 years, presents this journey to help move you from work to worship!</p>
        <p class="instructions2">Please click on all of the supporting documents' links below to download these documents to your computer. Read these documents and print the "1-3 Outstanding Orientation form.doc" document, so that you can complete this form while following along in the "Outstanding Orientation" video below. However, if you do not have a printer, you can also complete this form digitally as well. Finally, after watching the "Outstanding Orientation" video below and reading through all documents, continue on to Module 1 part 2.</p>
        <p class="instructions">Supporting documents:</p>
        <p><b>Please click on all of the links below to download these documents to your computer. They will be downloaded to the Downloads folder on your computer (unless you have changed your web browser's default settings). If asked whether to open or save, choose save.</b></p>
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton1_Click">1-1 Welcome to Resources Unlimited Group.pdf</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton11" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton11_Click">1-2 Resources provided by Outstanding Orientation.pdf</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton2_Click">1-3 Outstanding Orientation form.doc</asp:LinkButton>
        <br />
        <p class="instructions">Outstanding Orientation.mp4 (about 2 hours)</p>
        <video id="Outstanding_Orientation" controls preload="auto" oncanplaythrough="true">
            <source src="/Docs/BLPDS/Module_1/Part_1/Disc_1/Outstanding_Orientation.mp4" type="video/mp4" />
            <source src="/Docs/BLPDS/Module_1/Part_1/Disc_1/Outstanding_Orientation.webm" type="video/webm" />
            <source src="/Docs/BLPDS/Module_1/Part_1/Disc_1/Outstanding_Orientation.ogv" type="video/ogv" />
            Your web browser does not support HTML5 media player.
        </video>
        <p><b><u>Disclaimer:</u></b> Currently, this website needs to be accessed from a computer only in order for streaming video to work correctly. Thank you and God bless! Additionally, in order to stream this video, you will need to have high speed Internet (cable or similar approx. 300 Mbps connection type) in order to do so. If you do not, please visit any public location which does, i.e. Starbucks, Panera, your local library, etc. Thank you.</p>
        <br />
        <span class="instructions">Part 2:</span>
        <p>This seminar is a Biblically-based overview of the entire arena of work from a Christ-centered world-view consisting of understanding the balance and meaning of work and rest, learning how to establish and maintain balanced life priorities, and a Biblical model of calling, purpose, and provision in "Joseph’s career path," which tells how God faithfully guides and provides for His children. Both of these seminars provide an essential foundation of practical and spiritual wisdom on which to build. May God bless you in education, application, and edification, and may you bless God by worshiping Him in and through your work!</p>
        <p class="instructions2">Please click on all of the supporting documents' links below to download these documents to your computer. Read these documents, complete the "2-2 Work and rest questionnaire.doc" document prior to watching the "Why Go to Work?" video below, and then print the "2-4 Principles governing work and rest form.doc" document to complete while following along in "Why Go to Work?" However, if you do not have a printer, you can also complete these forms digitally as well. Finally, after watching both videos and reading through all documents in Module 1, continue on to Module 2 - Focus on Purpose.</p>
        <p class="instructions">Supporting documents:</p>
        <p><b>Please click on all of the links below to download these documents to your computer. They will be downloaded to the Downloads folder on your computer (unless you have changed your web browser's default settings). If asked whether to open or save, choose save.</b></p>
        <asp:LinkButton ID="LinkButton3" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton3_Click">2-1 Welcome to Resources Unlimited Group.pdf</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton4" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton4_Click">2-2 Work and rest questionnaire.doc</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton5" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton5_Click">2-3 What?, So what?, Now what?.pdf</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton6" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton6_Click">2-4 Principles governing work and rest form.doc</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton7" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton7_Click">2-5 Why Go to Work? Scriptures.pdf</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton8" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton8_Click">2-6 What are your life priorities?.pdf</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton9" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton9_Click">2-7 Joseph's career path.pdf</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="LinkButton10" runat="server" Font-Size="Large" ForeColor="Blue" Font-Bold="true" OnClick="LinkButton10_Click">2-8 God's covenant relationship.pdf</asp:LinkButton>
        <br />
        <p class="instructions">Why Go to Work?.mp4 (about 2 hours)</p>
        <video id="Why_Go_To_Work" controls preload="auto" oncanplaythrough="true">
            <source src="/Docs/BLPDS/Module_1/Part_2/Disc_3/Why_Go_To_Work.mp4" type="video/mp4" />
            <source src="/Docs/BLPDS/Module_1/Part_2/Disc_3/Why_Go_To_Work.webm" type="video/webm" />
            <source src="/Docs/BLPDS/Module_1/Part_2/Disc_3/Why_Go_To_Work.ogv" type="video/ogv" />
            Your web browser does not support HTML5 media player.
        </video>
        <p><b><u>Disclaimer:</u></b> Currently, this website needs to be accessed from a computer only in order for streaming video to work correctly. Thank you and God bless! Additionally, in order to stream this video, you will need to have high speed Internet (cable or similar approx. 300 Mbps connection type) in order to do so. If you do not, please visit any public location which does, i.e. Starbucks, Panera, your local library, etc. Thank you.</p>
        <br /><br /><br />
        <br /><br /><br />
        <div class="right-float">
            <asp:Button ID="btnContinue" runat="server" Text="Continue" PostBackUrl="~/PL/BLPDS/BPF_LifePurposeDevelopmentSeries.aspx" />
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
        video::-webkit-media-controls {
            overflow: hidden !important
        }
        video::-webkit-media-controls-enclosure {
            width: calc(100% + 32px);
            margin-left: auto;
        }
        audio::-internal-media-controls-download-button {
            display: none;
        }
        audio::-webkit-media-controls-enclosure {
            overflow: hidden;
        }
        audio::-webkit-media-controls-panel {
            width: calc(100% + 30px);
        }
        #player1 > audio { width: 100% }
        @media screen and (-webkit-min-device-pixel-ratio:0) and (min-resolution:.001dpcm) {
            #player1 {
                overflow: hidden;width: 390px; 
            }

            #player1 > audio { 
                width: 420px; 
            }
        }
        @media screen and (-webkit-min-device-pixel-ratio:0)
        {
            #player1 {
                overflow: hidden;width: 390px; 
            }

            #player1 > audio { width: 420px; }
        }
    </style>
</asp:Content>

