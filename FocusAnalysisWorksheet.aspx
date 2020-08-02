<%@ Page Title="Focus Analysis Worksheet" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="FocusAnalysisWorksheet.aspx.cs" Inherits="BESTPATH._FocusAnalysisWorksheet" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Focus Analysis Worksheet</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View10" runat="server">
                <span class="instructions2">Please choose <u>eight</u> of the most meaningful experiences from your life that required you to use a variety of skills, then enter a title for each experience below.</span>
                <br /><br />
                <table class="table">
                    <tr>
                        <td class="auto-style1"><b><u>Experience #1 title:</u></b></td>
                        <td><asp:TextBox ID="TextBox23" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="TextBox23" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Experience #2 title:</u></b></td>
                        <td><asp:TextBox ID="TextBox24" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="TextBox24" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Experience #3 title:</u></b></td>
                        <td><asp:TextBox ID="TextBox25" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="TextBox25" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Experience #4 title:</u></b></td>
                        <td><asp:TextBox ID="TextBox26" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="TextBox26" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Experience #5 title:</u></b></td>
                        <td><asp:TextBox ID="TextBox27" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="TextBox27" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Experience #6 title:</u></b></td>
                        <td><asp:TextBox ID="TextBox28" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="TextBox28" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Experience #7 title:</u></b></td>
                        <td><asp:TextBox ID="TextBox29" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="TextBox29" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Experience #8 title:</u></b></td>
                        <td><asp:TextBox ID="TextBox30" runat="server" MaxLength="900" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="TextBox30" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit10" runat="server" OnClick="btnSubmit10_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue10" runat="server" CausesValidation="False" CssClass="float-right" OnClick="btnContinue10_Click" Text="Continue" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError10" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View1" runat="server">
                <span class="instructions">Please select all skill groups containing any skills used in a significant manner to successfully complete this experience.</span>
                <br /><br />
                <p><b><u>Experience #1 title:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblExample1" runat="server" Font-Bold="True"></asp:Label></p>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." />
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." />
                <br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." />
                <br />
                <asp:CheckBox ID="CheckBox4" runat="server" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." />
                <br />
                <asp:CheckBox ID="CheckBox5" runat="server" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." />
                <br />
                <asp:CheckBox ID="CheckBox6" runat="server" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." />
                <br />
                <asp:CheckBox ID="CheckBox7" runat="server" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." />
                <br />
                <asp:CheckBox ID="CheckBox8" runat="server" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." />
                <br />
                <asp:CheckBox ID="CheckBox9" runat="server" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." />
                <br />
                <asp:CheckBox ID="CheckBox10" runat="server" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." />
                <br />
                <asp:CheckBox ID="CheckBox11" runat="server" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." />
                <br />
                <asp:CheckBox ID="CheckBox12" runat="server" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." />
                <br />
                <asp:CheckBox ID="CheckBox13" runat="server" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." />
                <br />
                <asp:CheckBox ID="CheckBox14" runat="server" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." />
                <br />
                <asp:CheckBox ID="CheckBox15" runat="server" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." />
                <br />
                <asp:CheckBox ID="CheckBox16" runat="server" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." />
                <br />
                <asp:CheckBox ID="CheckBox17" runat="server" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." />
                <br />
                <asp:CheckBox ID="CheckBox18" runat="server" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." />
                <br />
                <asp:CheckBox ID="CheckBox19" runat="server" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." />
                <br />
                <asp:CheckBox ID="CheckBox20" runat="server" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." />
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="float-right" OnClick="btnSubmit_Click" Text="Submit" />
                    <asp:Button ID="btnContinue" runat="server" OnClick="btnContinue_Click" Text="Continue" Visible="False" CssClass="float-right" />
                </div>
                <br /><br />
                <asp:Label ID="lblError" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <span class="instructions">Please select all skill groups containing any skills used in a significant manner to successfully complete this experience.</span>
                <br /><br />
                <p><b><u>Experience #2 title:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblExample2" runat="server" Font-Bold="True"></asp:Label></p>
                <asp:CheckBox ID="CheckBox21" runat="server" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." />
                <br />
                <asp:CheckBox ID="CheckBox22" runat="server" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." />
                <br />
                <asp:CheckBox ID="CheckBox23" runat="server" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." />
                <br />
                <asp:CheckBox ID="CheckBox24" runat="server" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." />
                <br />
                <asp:CheckBox ID="CheckBox25" runat="server" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." />
                <br />
                <asp:CheckBox ID="CheckBox26" runat="server" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." />
                <br />
                <asp:CheckBox ID="CheckBox27" runat="server" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." />
                <br />
                <asp:CheckBox ID="CheckBox28" runat="server" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." />
                <br />
                <asp:CheckBox ID="CheckBox29" runat="server" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." />
                <br />
                <asp:CheckBox ID="CheckBox30" runat="server" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." />
                <br />
                <asp:CheckBox ID="CheckBox31" runat="server" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." />
                <br />
                <asp:CheckBox ID="CheckBox32" runat="server" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." />
                <br />
                <asp:CheckBox ID="CheckBox33" runat="server" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." />
                <br />
                <asp:CheckBox ID="CheckBox34" runat="server" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." />
                <br />
                <asp:CheckBox ID="CheckBox35" runat="server" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." />
                <br />
                <asp:CheckBox ID="CheckBox36" runat="server" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." />
                <br />
                <asp:CheckBox ID="CheckBox37" runat="server" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." />
                <br />
                <asp:CheckBox ID="CheckBox38" runat="server" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." />
                <br />
                <asp:CheckBox ID="CheckBox39" runat="server" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." />
                <br />
                <asp:CheckBox ID="CheckBox40" runat="server" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." />
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit2" runat="server" OnClick="btnSubmit2_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue2" runat="server" OnClick="btnContinue2_Click" Text="Continue" CssClass="float-right" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError2" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <span class="instructions">Please select all skill groups containing any skills used in a significant manner to successfully complete this experience.</span>
                <br /><br />
                <p><b><u>Experience #3 title:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblExample3" runat="server" Font-Bold="True"></asp:Label></p>
                <asp:CheckBox ID="CheckBox41" runat="server" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." />
                <br />
                <asp:CheckBox ID="CheckBox42" runat="server" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." />
                <br />
                <asp:CheckBox ID="CheckBox43" runat="server" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." />
                <br />
                <asp:CheckBox ID="CheckBox44" runat="server" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." />
                <br />
                <asp:CheckBox ID="CheckBox45" runat="server" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." />
                <br />
                <asp:CheckBox ID="CheckBox46" runat="server" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." />
                <br />
                <asp:CheckBox ID="CheckBox47" runat="server" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." />
                <br />
                <asp:CheckBox ID="CheckBox48" runat="server" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." />
                <br />
                <asp:CheckBox ID="CheckBox49" runat="server" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." />
                <br />
                <asp:CheckBox ID="CheckBox50" runat="server" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." />
                <br />
                <asp:CheckBox ID="CheckBox51" runat="server" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." />
                <br />
                <asp:CheckBox ID="CheckBox52" runat="server" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." />
                <br />
                <asp:CheckBox ID="CheckBox53" runat="server" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." />
                <br />
                <asp:CheckBox ID="CheckBox54" runat="server" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." />
                <br />
                <asp:CheckBox ID="CheckBox55" runat="server" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." />
                <br />
                <asp:CheckBox ID="CheckBox56" runat="server" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." />
                <br />
                <asp:CheckBox ID="CheckBox57" runat="server" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." />
                <br />
                <asp:CheckBox ID="CheckBox58" runat="server" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." />
                <br />
                <asp:CheckBox ID="CheckBox59" runat="server" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." />
                <br />
                <asp:CheckBox ID="CheckBox60" runat="server" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." />
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit3" runat="server" OnClick="btnSubmit3_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue3" runat="server" OnClick="btnContinue3_Click" Text="Continue" CssClass="float-right" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError3" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View4" runat="server">
                <span class="instructions">Please select all skill groups containing any skills used in a significant manner to successfully complete this experience.</span>
                <br /><br />
                <p><b><u>Experience #4 title:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblExample4" runat="server" Font-Bold="True"></asp:Label></p>
                <asp:CheckBox ID="CheckBox61" runat="server" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." />
                <br />
                <asp:CheckBox ID="CheckBox62" runat="server" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." />
                <br />
                <asp:CheckBox ID="CheckBox63" runat="server" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." />
                <br />
                <asp:CheckBox ID="CheckBox64" runat="server" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." />
                <br />
                <asp:CheckBox ID="CheckBox65" runat="server" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." />
                <br />
                <asp:CheckBox ID="CheckBox66" runat="server" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." />
                <br />
                <asp:CheckBox ID="CheckBox67" runat="server" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." />
                <br />
                <asp:CheckBox ID="CheckBox68" runat="server" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." />
                <br />
                <asp:CheckBox ID="CheckBox69" runat="server" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." />
                <br />
                <asp:CheckBox ID="CheckBox70" runat="server" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." />
                <br />
                <asp:CheckBox ID="CheckBox71" runat="server" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." />
                <br />
                <asp:CheckBox ID="CheckBox72" runat="server" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." />
                <br />
                <asp:CheckBox ID="CheckBox73" runat="server" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." />
                <br />
                <asp:CheckBox ID="CheckBox74" runat="server" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." />
                <br />
                <asp:CheckBox ID="CheckBox75" runat="server" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." />
                <br />
                <asp:CheckBox ID="CheckBox76" runat="server" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." />
                <br />
                <asp:CheckBox ID="CheckBox77" runat="server" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." />
                <br />
                <asp:CheckBox ID="CheckBox78" runat="server" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." />
                <br />
                <asp:CheckBox ID="CheckBox79" runat="server" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." />
                <br />
                <asp:CheckBox ID="CheckBox80" runat="server" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." />
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit4" runat="server" OnClick="btnSubmit4_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue4" runat="server" OnClick="btnContinue4_Click" Text="Continue" CssClass="float-right" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError4" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View5" runat="server">
                <span class="instructions">Please select all skill groups containing any skills used in a significant manner to successfully complete this experience.</span>
                <br /><br />
                <p><b><u>Experience #5 title:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblExample5" runat="server" Font-Bold="True"></asp:Label></p>
                <asp:CheckBox ID="CheckBox81" runat="server" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." />
                <br />
                <asp:CheckBox ID="CheckBox82" runat="server" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." />
                <br />
                <asp:CheckBox ID="CheckBox83" runat="server" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." />
                <br />
                <asp:CheckBox ID="CheckBox84" runat="server" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." />
                <br />
                <asp:CheckBox ID="CheckBox85" runat="server" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." />
                <br />
                <asp:CheckBox ID="CheckBox86" runat="server" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." />
                <br />
                <asp:CheckBox ID="CheckBox87" runat="server" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." />
                <br />
                <asp:CheckBox ID="CheckBox88" runat="server" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." />
                <br />
                <asp:CheckBox ID="CheckBox89" runat="server" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." />
                <br />
                <asp:CheckBox ID="CheckBox90" runat="server" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." />
                <br />
                <asp:CheckBox ID="CheckBox91" runat="server" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." />
                <br />
                <asp:CheckBox ID="CheckBox92" runat="server" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." />
                <br />
                <asp:CheckBox ID="CheckBox93" runat="server" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." />
                <br />
                <asp:CheckBox ID="CheckBox94" runat="server" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." />
                <br />
                <asp:CheckBox ID="CheckBox95" runat="server" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." />
                <br />
                <asp:CheckBox ID="CheckBox96" runat="server" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." />
                <br />
                <asp:CheckBox ID="CheckBox97" runat="server" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." />
                <br />
                <asp:CheckBox ID="CheckBox98" runat="server" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." />
                <br />
                <asp:CheckBox ID="CheckBox99" runat="server" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." />
                <br />
                <asp:CheckBox ID="CheckBox100" runat="server" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." />
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit5" runat="server" OnClick="btnSubmit5_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue5" runat="server" OnClick="btnContinue5_Click" Text="Continue" CssClass="float-right" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError5" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View6" runat="server">
                <span class="instructions">Please select all skill groups containing any skills used in a significant manner to successfully complete this experience.</span>
                <br /><br />
                <p><b><u>Experience #6 title:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblExample6" runat="server" Font-Bold="True"></asp:Label></p>
                <asp:CheckBox ID="CheckBox101" runat="server" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." />
                <br />
                <asp:CheckBox ID="CheckBox102" runat="server" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." />
                <br />
                <asp:CheckBox ID="CheckBox103" runat="server" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." />
                <br />
                <asp:CheckBox ID="CheckBox104" runat="server" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." />
                <br />
                <asp:CheckBox ID="CheckBox105" runat="server" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." />
                <br />
                <asp:CheckBox ID="CheckBox106" runat="server" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." />
                <br />
                <asp:CheckBox ID="CheckBox107" runat="server" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." />
                <br />
                <asp:CheckBox ID="CheckBox108" runat="server" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." />
                <br />
                <asp:CheckBox ID="CheckBox109" runat="server" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." />
                <br />
                <asp:CheckBox ID="CheckBox110" runat="server" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." />
                <br />
                <asp:CheckBox ID="CheckBox111" runat="server" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." />
                <br />
                <asp:CheckBox ID="CheckBox112" runat="server" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." />
                <br />
                <asp:CheckBox ID="CheckBox113" runat="server" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." />
                <br />
                <asp:CheckBox ID="CheckBox114" runat="server" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." />
                <br />
                <asp:CheckBox ID="CheckBox115" runat="server" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." />
                <br />
                <asp:CheckBox ID="CheckBox116" runat="server" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." />
                <br />
                <asp:CheckBox ID="CheckBox117" runat="server" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." />
                <br />
                <asp:CheckBox ID="CheckBox118" runat="server" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." />
                <br />
                <asp:CheckBox ID="CheckBox119" runat="server" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." />
                <br />
                <asp:CheckBox ID="CheckBox120" runat="server" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." />
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit6" runat="server" OnClick="btnSubmit6_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue6" runat="server" OnClick="btnContinue6_Click" Text="Continue" CssClass="float-right" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError6" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View7" runat="server">
                <span class="instructions">Please select all skill groups containing any skills used in a significant manner to successfully complete this experience.</span>
                <br /><br />
                <p><b><u>Experience #7 title:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblExample7" runat="server" Font-Bold="True"></asp:Label></p>
                <asp:CheckBox ID="CheckBox121" runat="server" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." />
                <br />
                <asp:CheckBox ID="CheckBox122" runat="server" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." />
                <br />
                <asp:CheckBox ID="CheckBox123" runat="server" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." />
                <br />
                <asp:CheckBox ID="CheckBox124" runat="server" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." />
                <br />
                <asp:CheckBox ID="CheckBox125" runat="server" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." />
                <br />
                <asp:CheckBox ID="CheckBox126" runat="server" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." />
                <br />
                <asp:CheckBox ID="CheckBox127" runat="server" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." />
                <br />
                <asp:CheckBox ID="CheckBox128" runat="server" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." />
                <br />
                <asp:CheckBox ID="CheckBox129" runat="server" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." />
                <br />
                <asp:CheckBox ID="CheckBox130" runat="server" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." />
                <br />
                <asp:CheckBox ID="CheckBox131" runat="server" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." />
                <br />
                <asp:CheckBox ID="CheckBox132" runat="server" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." />
                <br />
                <asp:CheckBox ID="CheckBox133" runat="server" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." />
                <br />
                <asp:CheckBox ID="CheckBox134" runat="server" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." />
                <br />
                <asp:CheckBox ID="CheckBox135" runat="server" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." />
                <br />
                <asp:CheckBox ID="CheckBox136" runat="server" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." />
                <br />
                <asp:CheckBox ID="CheckBox137" runat="server" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." />
                <br />
                <asp:CheckBox ID="CheckBox138" runat="server" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." />
                <br />
                <asp:CheckBox ID="CheckBox139" runat="server" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." />
                <br />
                <asp:CheckBox ID="CheckBox140" runat="server" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." />
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit7" runat="server" OnClick="btnSubmit7_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue7" runat="server" OnClick="btnContinue7_Click" Text="Continue" CssClass="float-right" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError7" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View8" runat="server">
                <span class="instructions">Please select all skill groups containing any skills used in a significant manner to successfully complete this experience.</span>
                <br /><br />
                <p><b><u>Experience #8 title:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblExample8" runat="server" Font-Bold="True"></asp:Label></p>
                <asp:CheckBox ID="CheckBox141" runat="server" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." />
                <br />
                <asp:CheckBox ID="CheckBox142" runat="server" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." />
                <br />
                <asp:CheckBox ID="CheckBox143" runat="server" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." />
                <br />
                <asp:CheckBox ID="CheckBox144" runat="server" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." />
                <br />
                <asp:CheckBox ID="CheckBox145" runat="server" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." />
                <br />
                <asp:CheckBox ID="CheckBox146" runat="server" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." />
                <br />
                <asp:CheckBox ID="CheckBox147" runat="server" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." />
                <br />
                <asp:CheckBox ID="CheckBox148" runat="server" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." />
                <br />
                <asp:CheckBox ID="CheckBox149" runat="server" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." />
                <br />
                <asp:CheckBox ID="CheckBox150" runat="server" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." />
                <br />
                <asp:CheckBox ID="CheckBox151" runat="server" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." />
                <br />
                <asp:CheckBox ID="CheckBox152" runat="server" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." />
                <br />
                <asp:CheckBox ID="CheckBox153" runat="server" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." />
                <br />
                <asp:CheckBox ID="CheckBox154" runat="server" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." />
                <br />
                <asp:CheckBox ID="CheckBox155" runat="server" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." />
                <br />
                <asp:CheckBox ID="CheckBox156" runat="server" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." />
                <br />
                <asp:CheckBox ID="CheckBox157" runat="server" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." />
                <br />
                <asp:CheckBox ID="CheckBox158" runat="server" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." />
                <br />
                <asp:CheckBox ID="CheckBox159" runat="server" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." />
                <br />
                <asp:CheckBox ID="CheckBox160" runat="server" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." />
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit8" runat="server" OnClick="btnSubmit8_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue8" runat="server" OnClick="btnContinue8_Click" Text="Continue" CssClass="float-right" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError8" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View9" runat="server">
                <span class="instructions2">Now, the number of times you selected each skill group has been totaled next to each skill group in the total column. Please select the <u>six</u> skill groups that you most enjoy and are most effective at using. Obviously, the ones that you used the most should be considered carefully.</span>
                <br /><br />
                <table class="table">
                    <tr>
                        <td class="auto-style2"><b><u>Total:</u></b></td>
                        <td><b><u>Skill group:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox161" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox161_CheckedChanged" Text="Directing, supervising, managing others, leading, controlling, guiding, authorizing, approving, and/or administration." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label2" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox162" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox162_CheckedChanged" Text="Planning, organizing, coordinating details, reorganizing, goal setting, restructuring, prioritizing, scheduling, systematizing, developing processes or procedures, strategic planning, forecasting, designing programs, establishing steps or actions, operations management, arranging, and/or event management." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label3" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox163" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox163_CheckedChanged" Text="Communicating, addressing, speaking, encouraging, motivating, persuading, inspiring, influencing, briefing, enlightening, informing, explaining, telecommunications, and/or leading group discussions." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label4" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox164" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox164_CheckedChanged" Text="Decision making, independent management, change management, risk taking, self-directed actions, determining direction, formulating, initiating, implementing, multi-task management, and/or project management." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label5" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox165" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox165_CheckedChanged" Text="Teaching, instructing, training, clarifying, informing, interpreting, familiarizing, learning, designing audio/visual aids, and/or developing training programs, materials, or manuals." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label6" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox166" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox166_CheckedChanged" Text="Promoting teamwork, unifying, creating harmony, coordinating team efforts, growing teams, assembling, group dynamics, participating, cooperating, delegating, and/or following others' orders." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label7" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox167" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox167_CheckedChanged" Text="Coaching, consulting, advising, recommending, suggesting, prescribing, counseling, empathic understanding and response, active listening, and/or stimulating action." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label8" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox168" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox168_CheckedChanged" Text="Supporting, assisting, aiding, serving, helping, building trust, establishing interpersonal relationships and rapport, customer relations, and/or providing service." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label9" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox169" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox169_CheckedChanged" Text="Collecting information, keeping records, compiling, statistics, organizing materials, grouping, simplifying, learning new information, operating computers, computer programming, calculating, and/or number crunching." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label10" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox170" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox170_CheckedChanged" Text="Writing, composing, describing, reviewing, rewriting, revising, summarizing, preparing written reports, writing concise briefings, editing, proofreading, comparing, and/or publishing." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label11" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox171" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox171_CheckedChanged" Text="Representing, liaison, conferring, providing feedback, bargaining, negotiating, arbitrating, mediating, resolving conflict, and/or employee relations." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label12" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox172" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox172_CheckedChanged" Text="Analyzing, evaluating, critiquing, verifying, validating, monitoring, inspecting, justifying, establishing criteria or standards, observing, conducting detailed follow-up, testing, and/or quality assurance (QA)." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label13" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox173" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox173_CheckedChanged" Text="Interviewing, inquiring, soliciting, surveying, assessing talent, appraising quality, screening, selecting, hiring, matching skills and tasks, and/or human resources (HR) management." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label14" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox174" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox174_CheckedChanged" Text="Sales, direct selling, presenting, demonstrating products or services, territory or account management, marketing, promoting, advertising, public relations (PR), developing products, and/or building markets or entrepreneurial enterprises." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label15" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox175" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox175_CheckedChanged" Text="Researching, investigating, clarifying problems, being resourceful, troubleshooting, resolving situations, issues, or problems, and/or problem solving." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label16" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox176" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox176_CheckedChanged" Text="Creating, innovating, improvising, experimenting, inventing, generating ideas, conceiving, conceptualizing, improving, consolidating, reducing, streamlining, and/or merging." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label17" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox177" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox177_CheckedChanged" Text="Financial planning, fiscal management, budgeting, controlling costs, monitoring budgets, estimating, projecting, performing cost analyses, bookkeeping, accounting, auditing, and/or developing internal controls." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label18" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox178" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox178_CheckedChanged" Text="Purchasing, ordering, buying, procuring, classifying, checking, specifying, shipping, receiving, inventory management, stocking, warehousing, issuing, distribution, transmitting, handling, sending, delivering, facilitating, expediting, vendor relations, and/or contracting." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label19" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox179" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox179_CheckedChanged" Text="Machine or manual skills, operating machinery, fabricating, building, constructing, making, engineering, layout, installation, production management, and/or manufacturing." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><asp:Label ID="Label20" runat="server" Font-Bold="True"></asp:Label></td>
                        <td><asp:CheckBox ID="CheckBox180" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox180_CheckedChanged" Text="Special talents: being artistic, drawing, drafting, illustrating, designing graphics, crafting, hands-on skills, music, singing, performing, and/or entertaining." /></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="instructions" colspan="2">Now, for the six skill groups you selected that are redisplayed below, please delete everything other than the skills that demonstrate your highest level of effectiveness. Feel free to rearrange skill groups in any way that helps to better represent your skills.</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b><u>Skill group #1:</u></b></td>
                        <td class="auto-style4"><textarea id="TextBox17" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox17" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Skill group #2:</u></b></td>
                        <td class="auto-style6"><textarea id="TextBox18" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox18" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b><u>Skill group #3:</u></b></td>
                        <td class="auto-style8"><textarea id="TextBox19" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBox19" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9"><b><u>Skill group #4:</u></b></td>
                        <td class="auto-style10"><textarea id="TextBox20" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox20" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><b><u>Skill group #5:</u></b></td>
                        <td class="auto-style12"><textarea id="TextBox21" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="TextBox21" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style13"><b><u>Skill group #6:</u></b></td>
                        <td class="auto-style14"><textarea id="TextBox22" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="TextBox22" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit9" runat="server" OnClick="btnSubmit9_Click" Text="Submit" CssClass="float-right" />
                    <asp:Button ID="btnContinue9" runat="server" OnClick="btnContinue9_Click" Text="Continue" CausesValidation="False" CssClass="float-right" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError9" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
        </asp:MultiView>
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
            width: 30%
        }
        .auto-style2 {
            width: 20%;
        }
        textarea {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 75%;
            height: 100%
        }
        .auto-style3 {
            width: 20%;
            height: 151px;
        }
        .auto-style4 {
            height: 151px;
        }
        .auto-style5 {
            width: 20%;
            height: 155px;
        }
        .auto-style6 {
            height: 155px;
        }
        .auto-style7 {
            width: 20%;
            height: 152px;
        }
        .auto-style8 {
            height: 152px;
        }
        .auto-style9 {
            width: 20%;
            height: 156px;
        }
        .auto-style10 {
            height: 156px;
        }
        .auto-style11 {
            width: 20%;
            height: 154px;
        }
        .auto-style12 {
            height: 154px;
        }
        .auto-style13 {
            width: 20%;
            height: 157px;
        }
        .auto-style14 {
            height: 157px;
        }
    </style>
</asp:Content>

