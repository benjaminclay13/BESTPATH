<%@ Page Title="Career Marketability Assessment" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="CareerMarketabilityAssessment.aspx.cs" Inherits="BESTPATH._CareerMarketabilityAssessment" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Career Marketability Assessment</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View3" runat="server">
                <table class="table">
                    <tr>
                        <td><b>Email address:</b></td>
                        <td><asp:TextBox ID="txtEmailAddress" runat="server" MaxLength="900" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="rfvEmailAddress" runat="server" ErrorMessage="Required" ControlToValidate="txtEmailAddress" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="revEmailAddress" runat="server" ControlToValidate="txtEmailAddress" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid email address required</asp:RegularExpressionValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit2" runat="server" Text="Submit" OnClick="btnSubmit2_Click" />
                </div>
                <br /><br />
                <asp:Label ID="lblError2" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View1" runat="server">
                <span class="instructions2">Please honestly respond to the following statements as they relate to your current employment status and your level of preparedness for managing your career and potential upcoming job search:</span>
                <br /><br />
                <table class="table">
                    <tr>
                        <td colspan="2"><b>Please answer the following questions according to this scale: <br />1 – Strongly disagree, 2 – Disagree, 3 – Neutral, 4 – Agree, or 5 – Strongly agree.</b></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>1. I am very confident and clear about what I want to do regarding my life and career.</b></td>
                        <td><asp:TextBox ID="txtQ1" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ1" runat="server" ErrorMessage="Required" ControlToValidate="txtQ1" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ1" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ1" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>2. I and others believe that my focus and career objectives are well supported by my work experience and education, and I currently work in a field that I truly enjoy, am passionate about, and can perform effectively in.</b></td>
                        <td><asp:TextBox ID="txtQ2" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ2" runat="server" ErrorMessage="Required" ControlToValidate="txtQ2" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ2" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ2" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>3. I get very excited and am very passionate when speaking about what I currently do, my career goals, and, ultimately, my life’s work.</b></td>
                        <td><asp:TextBox ID="txtQ3" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ3" runat="server" ErrorMessage="Required" ControlToValidate="txtQ3" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ3" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ3" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>4. I am very comfortable with my current work assignments, and I believe that my current career path is in-line with God’s will for my life – I strongly believe that I am doing what I was truly created to do.</b></td>
                        <td><asp:TextBox ID="txtQ4" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ4" runat="server" ErrorMessage="Required" ControlToValidate="txtQ4" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ4" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ4" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>5. I strongly believe that my current resume states the value that I have to offer – effectively highlighting my past work experience, current skills base, and professional summary – and does a great job of projecting the correct impression of what I want to do, can do, and am very effective at doing.</b></td>
                        <td><asp:TextBox ID="txtQ5" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ5" runat="server" ErrorMessage="Required" ControlToValidate="txtQ5" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ5" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ5" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>6. I am totally confident that, if necessary, I can make a career change without any assistance.</b></td>
                        <td><asp:TextBox ID="txtQ6" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ6" runat="server" ErrorMessage="Required" ControlToValidate="txtQ6" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ6" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ6" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>7. I clearly understand how to compose and use letters effectively in my job search campaigns, including: cover letters, job interview thank you letters, resource interview request letters, resource interview thank you letters, Focus Piece letters, job offer acceptance letters, job offer counteroffer letters, position description confirmation letters, performance review letters, and resignation letters.</b></td>
                        <td><asp:TextBox ID="txtQ7" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ7" runat="server" ErrorMessage="Required" ControlToValidate="txtQ7" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ7" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ7" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>8. I understand how the marketplace really operates, the five ways to get a job, how to identify and penetrate the “unknown market,” and how to create my own position.</b></td>
                        <td><asp:TextBox ID="txtQ8" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ8" runat="server" ErrorMessage="Required" ControlToValidate="txtQ8" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ8" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ8" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>9. I am well prepared to make a good first impression with potential employers (both in writing and in person), am comfortable with and understand the correct protocol for interviewing, and know how to control and close an interview very effectively.</b></td>
                        <td><asp:TextBox ID="txtQ9" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ9" runat="server" ErrorMessage="Required" ControlToValidate="txtQ9" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ9" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ9" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>10. I am always confident and well prepared to answer the most common opening question of all job interviews: “Why don’t you tell me about yourself?”</b></td>
                        <td><asp:TextBox ID="txtQ10" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ10" runat="server" ErrorMessage="Required" ControlToValidate="txtQ10" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ10" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ10" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>11. I understand that there are really only six kinds of questions asked in all job interviews, and I am very confident that I can successfully answer any question that I’m asked.</b></td>
                        <td><asp:TextBox ID="txtQ11" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ11" runat="server" ErrorMessage="Required" ControlToValidate="txtQ11" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ11" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ11" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>12. When I receive job offers that are not right for me, I know how to negotiate salary very effectively and prepare counteroffer proposals that create a “win-win” for both parties.</b></td>
                        <td><asp:TextBox ID="txtQ12" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ12" runat="server" ErrorMessage="Required" ControlToValidate="txtQ12" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ12" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ12" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>13. I understand the difference between the lowest reasonable price that decision makers want to pay and the maximum value that I want to receive, and I know how to satisfy both parties.</b></td>
                        <td><asp:TextBox ID="txtQ13" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ13" runat="server" ErrorMessage="Required" ControlToValidate="txtQ13" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ13" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ13" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>14. While I realize that there is no real security in any job, career, or company, I clearly understand how to determine if a position is right for me and to negotiate an ideal salary, benefits package, and regular raises at review periods for good performance at 6 and 12 months, and do so prior to accepting any job offers.</b></td>
                        <td><asp:TextBox ID="txtQ14" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ14" runat="server" ErrorMessage="Required" ControlToValidate="txtQ14" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ14" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ14" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>15. I am fully aware of the value of a “network of employability” that extends far beyond any job or company, and I know how to build, utilize, and maintain this network to create the greatest amount of job security and control that exists in an uncertain world.</b></td>
                        <td><asp:TextBox ID="txtQ15" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ15" runat="server" ErrorMessage="Required" ControlToValidate="txtQ15" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ15" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ15" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>16. I understand how to and realize that it is in my best interests to write my own position description, performance standards, incentives criteria and schedule, and I am comfortable doing it and have done it before.</b></td>
                        <td><asp:TextBox ID="txtQ16" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ16" runat="server" ErrorMessage="Required" ControlToValidate="txtQ16" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ16" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ16" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>17. I know how important it is and am prepared to proactively insure that I receive positive and timely performance reviews, which significantly benefit the organization and myself.</b></td>
                        <td><asp:TextBox ID="txtQ17" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ17" runat="server" ErrorMessage="Required" ControlToValidate="txtQ17" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ17" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ17" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>18. I understand how to control my first level of responsibility on the job - managing my supervisor, and secondly managing my peers, and finally managing my subordinates.</b></td>
                        <td><asp:TextBox ID="txtQ18" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ18" runat="server" ErrorMessage="Required" ControlToValidate="txtQ18" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ18" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ18" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>19. I can see how career management principles applied to my job and work positively impact the balance and satisfaction in other areas of my life, and quality of life in general. I am well educated in these principles and understand their application day-to-day.</b></td>
                        <td><asp:TextBox ID="txtQ19" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ19" runat="server" ErrorMessage="Required" ControlToValidate="txtQ19" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ19" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ19" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><b>20. I believe that it is important to study and understand the Bible as it provides the foundation for all areas of my life, including: my career, leisure, calling, and service, and I am firmly grounded in this Truth as it relates and applies to these important areas of my life.</b></td>
                        <td><asp:TextBox ID="txtQ20" runat="server" MaxLength="1" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:RequiredFieldValidator ID="rfvQ20" runat="server" ErrorMessage="Required" ControlToValidate="txtQ20" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style3"></td>
                        <td><asp:CompareValidator ID="cvQ20" runat="server" ErrorMessage="Valid integer required" ControlToValidate="txtQ20" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                </div>
                <br /><br />
                <asp:Label ID="lblError" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <table class="table">
                    <tr>
                        <td class="auto-style2"><span class="instructions2"><b>Your score:</b></span></td>
                        <td><asp:Label ID="lblScore" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><span class="instructions"><b>Scale:</b></span></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">100 to 90</td>
                        <td>You have an excellent understanding of how to take control of and manage your career such that you have the career of your dreams. Additionally, you can probably give good advice to others in this area as well.</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">89 to 80</td>
                        <td>You are quite knowledgeable and effective in most respects with regards to your career; however, you could benefit considerably from career counseling assistance in the areas of your least effectiveness.</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">79 to 70</td>
                        <td>You have most likely been just surviving in your career and previous job searches in the marketplace, but not really thriving at all. Therefore, you could tremendously benefit from career counseling assistance in many areas.</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">69 and under</td>
                        <td>You are seriously struggling with nearly all of the important aspects of career and job self-management. You need to commit to a comprehensive program of guidance, equipping, and training in this area as soon as possible.</td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnContinue" runat="server" Text="Continue" PostBackUrl="~/Home.aspx" />
                </div>
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
        .auto-style2 {
            width: 25%;
        }
        .auto-style3 {
            width: 45%;
        }
    </style>
</asp:Content>

