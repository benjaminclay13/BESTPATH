<%@ Page Title="Preliminary Needs Assessment" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="PreliminaryNeedsAssessment.aspx.cs" Inherits="BESTPATH._PreliminaryNeedsAssessment" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Preliminary Needs Assessment</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <span class="instructions2">Please tell us about yourself!</span>
        <table class="table">
            <tr>
                <td class="auto-style3"><b>1. First name:</b></td>
                <td><asp:TextBox ID="txtFirstName" runat="server" MaxLength="900" Font-Size="Large" ForeColor="Black" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ErrorMessage="Required" ControlToValidate="txtFirstName" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><b>2. Last name:</b></td>
                <td><asp:TextBox ID="txtLastName" runat="server" MaxLength="900" Font-Size="Large" ForeColor="Black" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvLastName" runat="server" ErrorMessage="Required" ControlToValidate="txtLastName" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><b>3. Email address:</b></td>
                <td><asp:TextBox ID="txtEmailAddress" runat="server" MaxLength="900" Font-Size="Large" ForeColor="Black" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvEmailAddress" runat="server" ErrorMessage="Required" ControlToValidate="txtEmailAddress" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RegularExpressionValidator ID="revEmailAddress" runat="server" ControlToValidate="txtEmailAddress" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid email address required</asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><b>4. Phone number:</b></td>
                <td><asp:TextBox ID="txtPhoneNumber" runat="server" MaxLength="900" Font-Size="Large" ForeColor="Black" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style3"><b>Valid phone format:</b> 1234567890</td>
                <td><asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server" ErrorMessage="Required" ControlToValidate="txtPhoneNumber" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RegularExpressionValidator ID="revPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$">Invalid phone number</asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><b>5. Are you currently employed?</b></td>
                <td>
                    <asp:RadioButtonList ID="rblQ5" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" RepeatDirection="Horizontal">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ5" runat="server" ErrorMessage="Required" ControlToValidate="rblQ5" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>6. If currently employed, where do you work? If not, where were you last employed?</b></td>
                <td class="auto-style2"><textarea id="txtQ6" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ6" runat="server" ErrorMessage="Required" ControlToValidate="txtQ6" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>7. If currently employed, what is your current position title? If not, what was your last position title?</b></td>
                <td class="auto-style2"><textarea id="txtQ7" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ7" runat="server" ErrorMessage="Required" ControlToValidate="txtQ7" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>8. Are you satisfied with your current employment status? If not, please explain:</b></td>
                <td class="auto-style2"><textarea id="txtQ8" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ8" runat="server" ErrorMessage="Required" ControlToValidate="txtQ8" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><b>9. Are you interested in continuing working in that same career field?</b></td>
                <td>
                    <asp:RadioButtonList ID="rblQ9" runat="server" AutoPostBack="False" Font-Bold="True" Font-Size="Large" ForeColor="Black" RepeatDirection="Horizontal">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ9" runat="server" ErrorMessage="Required" ControlToValidate="rblQ9" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><b>10. How firm are you in your desire to improve your current employment status and take control of your career path? Please explain:</b></td>
                <td class="auto-style6"><textarea id="txtQ10" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ10" runat="server" ErrorMessage="Required" ControlToValidate="txtQ10" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><b>11. Are you married?</b></td>
                <td>
                    <asp:RadioButtonList ID="rblQ11" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" RepeatDirection="Horizontal">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ11" runat="server" ErrorMessage="Required" ControlToValidate="rblQ11" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><b>12. Do you have any children?</b></td>
                <td>
                    <asp:RadioButtonList ID="rblQ12" runat="server" AutoPostBack="False" Font-Bold="True" Font-Size="Large" ForeColor="Black" RepeatDirection="Horizontal">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ12" runat="server" ErrorMessage="Required" ControlToValidate="rblQ12" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"><b>13. If married, how supportive is your spouse about this change that you desire to make? If not married, skip to next question.</b></td>
                <td class="auto-style8"><textarea id="txtQ13" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>14. How long have you been considering making this change, and what has prompted you to take action now?</b></td>
                <td class="auto-style10"><textarea id="txtQ14" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ14" runat="server" ErrorMessage="Required" ControlToValidate="txtQ14" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"><b>15. What do you believe are your three most marketable skills or abilities?</b></td>
                <td class="auto-style12"><textarea id="txtQ15" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ15" runat="server" ErrorMessage="Required" ControlToValidate="txtQ15" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"><b>16. If there were no restraints on your time, talents, and treasure, what would you like to do with your life?</b></td>
                <td class="auto-style8"><textarea id="txtQ16" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ16" runat="server" ErrorMessage="Required" ControlToValidate="txtQ16" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13"><b>17. Has there ever been a time in your life when you partnered with God to truly make a difference in someone else’s life? If so, please explain:</b></td>
                <td class="auto-style14"><textarea id="txtQ17" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ17" runat="server" ErrorMessage="Required" ControlToValidate="txtQ17" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13"><b>18. If currently employed, what do you most enjoy about your current position? If not, what did you most enjoy about your last position?</b></td>
                <td class="auto-style14"><textarea id="txtQ18" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ18" runat="server" ErrorMessage="Required" ControlToValidate="txtQ18" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><b>19. If currently employed, what do you like the least about your current position? If not, what did you like the least about your last position?</b></td>
                <td class="auto-style6"><textarea id="txtQ19" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ19" runat="server" ErrorMessage="Required" ControlToValidate="txtQ19" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15"><b>20. If not currently employed, how long can you financially afford to search for the right position? If currently employed, are finances still an issue affecting your ability to take the time to search for the right position?</b></td>
                <td class="auto-style16"><textarea id="txtQ20" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td><asp:RequiredFieldValidator ID="rfvQ20" runat="server" ErrorMessage="Required" ControlToValidate="txtQ20" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13"><b>21. Do you believe that there will be any obstacles that you will need to overcome in order to be successful in your job search? If so, please explain:</b></td>
                <td class="auto-style14"><textarea id="txtQ21" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ21" runat="server" ErrorMessage="Required" ControlToValidate="txtQ21" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>22. Are you looking forward to this search as an exciting opportunity or do you see it as an unpleasant necessity? Please honestly describe your current attitude:</b></td>
                <td class="auto-style10"><textarea id="txtQ22" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ22" runat="server" ErrorMessage="Required" ControlToValidate="txtQ22" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><b>23. List the five most important things that you desire to be a part of your ideal job. Do not put any limitations on yourself or your possible career; please just honestly describe what you want to do:</b></td>
                <td class="auto-style6"><textarea id="txtQ23" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ23" runat="server" ErrorMessage="Required" ControlToValidate="txtQ23" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"><b>24. More than anything else, what do you long to do that you know would please God?</b></td>
                <td class="auto-style12"><textarea id="txtQ24" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ24" runat="server" ErrorMessage="Required" ControlToValidate="txtQ24" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>25. What do you most enjoy doing aside from work? (i.e. hobbies, any other activities, etc.)</b></td>
                <td class="auto-style10"><textarea id="txtQ25" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ25" runat="server" ErrorMessage="Required" ControlToValidate="txtQ25" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>26. Starting right now, what are you prepared to do differently than you have done in the past in order to take positive steps towards making this change?</b></td>
                <td class="auto-style10"><textarea id="txtQ26" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ26" runat="server" ErrorMessage="Required" ControlToValidate="txtQ26" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>27. What salary level would you like to be making when you start this new position?</b></td>
                <td class="auto-style10"><textarea id="txtQ27" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ27" runat="server" ErrorMessage="Required" ControlToValidate="txtQ27" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>28. What about in five years?</b></td>
                <td class="auto-style10"><textarea id="txtQ28" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ28" runat="server" ErrorMessage="Required" ControlToValidate="txtQ28" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"><b>29. What about in 10 years?</b></td>
                <td class="auto-style8"><textarea id="txtQ29" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ29" runat="server" ErrorMessage="Required" ControlToValidate="txtQ29" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>30. What is the highest annual salary that you have ever made to date?</b></td>
                <td class="auto-style10"><textarea id="txtQ30" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ30" runat="server" ErrorMessage="Required" ControlToValidate="txtQ30" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>31. In what year did you make that salary?</b></td>
                <td class="auto-style10"><textarea id="txtQ31" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ31" runat="server" ErrorMessage="Required" ControlToValidate="txtQ31" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"><b>32. What were you doing at that time?</b></td>
                <td class="auto-style8"><textarea id="txtQ32" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ32" runat="server" ErrorMessage="Required" ControlToValidate="txtQ32" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"><b>33. What was your position title at that time?</b></td>
                <td class="auto-style12"><textarea id="txtQ33" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ33" runat="server" ErrorMessage="Required" ControlToValidate="txtQ33" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"><b>34. Did you enjoy that position? Please explain:</b></td>
                <td class="auto-style8"><textarea id="txtQ34" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ34" runat="server" ErrorMessage="Required" ControlToValidate="txtQ34" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>35. Please describe the quality and effectiveness of your current resume:</b></td>
                <td class="auto-style10"><textarea id="txtQ35" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ35" runat="server" ErrorMessage="Required" ControlToValidate="txtQ35" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><b>36. Do you believe that your resume will need to be improved prior to your job search in order for you to be successful?</b></td>
                <td>
                    <asp:RadioButtonList ID="rblQ36" runat="server" AutoPostBack="False" Font-Bold="True" Font-Size="Large" ForeColor="Black" RepeatDirection="Horizontal">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ36" runat="server" ErrorMessage="Required" ControlToValidate="rblQ36" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17"><b>37. Do you believe that the ability to negotiate salary is an important part of a successful job search as well as the life of any career? Please explain:</b></td>
                <td class="auto-style18"><textarea id="txtQ37" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ37" runat="server" ErrorMessage="Required" ControlToValidate="txtQ37" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"><b>38. How do you think most people find good jobs in today’s job marketplace?</b></td>
                <td class="auto-style8"><textarea id="txtQ38" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ38" runat="server" ErrorMessage="Required" ControlToValidate="txtQ38" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style19"><b>39. How long do you think your job search is going to take?</b></td>
                <td class="auto-style20"><textarea id="txtQ39" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ39" runat="server" ErrorMessage="Required" ControlToValidate="txtQ39" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style19"><b>40. What do you honestly believe is a reasonable timeframe for a successful job search?</b></td>
                <td class="auto-style20"><textarea id="txtQ40" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ40" runat="server" ErrorMessage="Required" ControlToValidate="txtQ40" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><b>41. How important is spiritual support and development to you on this journey? If important, please elaborate:</b></td>
                <td class="auto-style10"><textarea id="txtQ41" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ41" runat="server" ErrorMessage="Required" ControlToValidate="txtQ41" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11"><b>42. On what days and at what times are your best availability?</b></td>
                <td class="auto-style12"><textarea id="txtQ42" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ42" runat="server" ErrorMessage="Required" ControlToValidate="txtQ42" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"><b>43. What amount of time per week are you committed to be involved in your job search?</b></td>
                <td class="auto-style8"><textarea id="txtQ43" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ43" runat="server" ErrorMessage="Required" ControlToValidate="txtQ43" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><b>44. Please describe your current health:</b></td>
                <td class="auto-style6"><textarea id="txtQ44" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ44" runat="server" ErrorMessage="Required" ControlToValidate="txtQ44" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><b>45. What is your current age?</b></td>
                <td class="auto-style2"><textarea id="txtQ45" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ45" runat="server" ErrorMessage="Required" ControlToValidate="txtQ45" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><b>46. Is there anything else that you believe would be pertinent for us to know in order for us to best help you to get where you want to be in your career pursuits?</b></td>
                <td class="auto-style6"><textarea id="txtQ46" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvQ46" runat="server" ErrorMessage="Required" ControlToValidate="txtQ46" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>How have you been referred to our website?</b></td>
                <td>
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
                <td><asp:RequiredFieldValidator ID="rfvReferralSource" runat="server" ControlToValidate="ddlReferralSource" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>If referred by another person, what is their name? If church outreach, what church are you from? If other, please explain.</b></td>
                <td><asp:TextBox ID="txtReferralName" runat="server" MaxLength="900" Width="100%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvReferralName" runat="server" ControlToValidate="txtReferralName" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" Enabled="false">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><b>If referred by a RUG Authorized Personal Counselor, what is their email address (their username on the BPF website)?</b></td>
                <td><asp:TextBox ID="txtRUGAPCEmailAddress" runat="server" MaxLength="900" Width="100%" Font-Size="Large" Font-Names="Arial" ForeColor="Black" AutoCompleteType="Disabled"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td><asp:RequiredFieldValidator ID="rfvRUGAPCEmailAddress" runat="server" ControlToValidate="txtRUGAPCEmailAddress" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" Enabled="false">Required</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:RegularExpressionValidator ID="revRUGAPCEmailAdress" runat="server" ControlToValidate="txtRUGAPCEmailAddress" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid email address required</asp:RegularExpressionValidator></td>
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
        textarea {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 100%;
            height: 100%
        }
        .auto-style1 {
            width: 50%;
        }
        .auto-style2 {
            height: 150px;
        }
        .auto-style3 {
            width: 50%
        }
        .auto-style4 {
            height: 150px;
            width: 50%
        }
        .auto-style5 {
            height: 151px;
            width: 50%;
        }
        .auto-style6 {
            height: 151px;
        }
        .auto-style7 {
            width: 50%;
            height: 149px;
        }
        .auto-style8 {
            height: 149px;
        }
        .auto-style9 {
            width: 50%;
            height: 147px;
        }
        .auto-style10 {
            height: 147px;
        }
        .auto-style11 {
            height: 152px;
            width: 50%;
        }
        .auto-style12 {
            height: 152px;
        }
        .auto-style13 {
            width: 50%;
            height: 146px;
        }
        .auto-style14 {
            height: 146px;
        }
        .auto-style15 {
            width: 50%;
            height: 148px;
        }
        .auto-style16 {
            height: 148px;
        }
        .auto-style17 {
            height: 154px;
            width: 50%;
        }
        .auto-style18 {
            height: 154px;
        }
        .auto-style19 {
            width: 50%;
            height: 145px;
        }
        .auto-style20 {
            height: 145px;
        }
    </style>
</asp:Content>

