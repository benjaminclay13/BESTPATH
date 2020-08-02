<%@ Page Title="Marketing Documents Creation" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="MarketingDocumentsCreation.aspx.cs" Inherits="BESTPATH._MarketingDocumentsCreation" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Marketing Documents Creation</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">    
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <span class="instructions">Instructions for building your Statement of Value:</span>
                <br /><br />
                <table class="table">
                    <tr>
                        <td class="auto-style9">Please enter your name as you would like to be called in an interview with no middle initial – personal and professional, i.e. Jim Davis.</td>
                        <td><asp:TextBox ID="txtFullName" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFullName" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left" style="text-align: left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9">Please enter your college degrees and/or certifications from the highest degree down. Show school letters if important to the area, i.e. M.A., B.S., A.A. (OSU), or if relevant, B.S. (Business Administration / Marketing) OSU, or MBA / CPA, etc.</td>
                        <td><asp:TextBox ID="txtDegrees" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDegrees" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9">Please enter your street mailing address with street or road spelled out, no abbreviations (only use another address if you are fully in control of your mail and can check it often). Try not to use a P.O. Box (it may cause the impression that you are transient or not established).</td>
                        <td><asp:TextBox ID="txtStreetAddress" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtStreetAddress" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9">Please enter your city, state, and zip code.</td>
                        <td><asp:TextBox ID="txtCityStateZip" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator89" runat="server" ControlToValidate="txtCityStateZip" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9">Please enter your professional email address (no business email addresses). This email address reflects on you, so choose one with care and good judgment.</td>
                        <td><asp:TextBox ID="txtEmail" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="float-left">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style9">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style9">Please enter your cell phone number with area code. Only use another phone number if you are fully in control of answering and getting your voice mail messages, and can check your phone often. Include your name and phone number in your voice mail greeting, nothing cutesy or long winded. Be sure to check your voice mail messages often, and always respond to these timely and professionally.</td>
                        <td><asp:TextBox ID="txtPhone" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="80%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><b>Valid phone format:</b> 1234567890</td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPhone" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPhone" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$" CssClass="float-left">Valid Phone Number Required</asp:RegularExpressionValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style29" OnClick="btnSubmit_Click" Text="Submit" />
                    <asp:Button ID="btnContinue" runat="server" CssClass="auto-style29" OnClick="btnContinue_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <span class="instructions">Instructions for building your Statement of Value continued:</span>
                <br /><br />
                <p>Some of these Marketing Documents Creation pages may take some time to complete; therefore, we strongly recommend that you visit the Downloads page, where there is a MDC form for the three pages that have been identified that could possibly take you longer than 2 hours to complete, which are the achievements, Expanded Experience Profile, and Expanded Experience Profile expanded information pages. For these, download this form to your computer and complete it in MS Word, then when you are finished, return to these pages, click the refresh button in your web browser if you have stayed on any of these pages while completing the MDC form, and then simply copy and paste all of your answers into the corresponding textboxes on these pages.</p>
                <p><b>IMPORTANT NOTE:</b> If you have stayed on any page while completing your work in MS Word, then you will need to click the refresh button in your web browser BEFORE you start completing that page. This will ensure that you have not already been timed out.</p>
                <p><b>REMEMBER: YOU WILL ONLY HAVE 2 HOURS TO COMPLETE EACH PAGE!</b> If you do not, you will be timed out, and then have to complete it again from the beginning!</p>
                <p>Additionally, on the pages that follow, your relevant past work in <b><i>Focus on Purpose (FOP)</i></b> will be imported as necessary to help you to create your marketing documents on these pages; however, if at any time you desire to review anything else that you previously completed in FOP, you can easily do so by scrolling to the top of any page, right clicking the "FOP" link, and selecting "open link in new tab." This will create a second session for you on the <b><i>BestPath Foundation website</i></b>. Then, simply navigate to any page that you desire, and you can easily review your past work on that page, which will be populated in that page's associated textboxes. Then, simply switch back to your original tab in your web browser to complete your work on these Marketing Documents Creation pages.</p>
                <br />
                <p>Here is an example of what the first section of your Statement of Value might look like:</p>
                <table class="table">
                    <tr>
                        <td class="auto-style1"><b><u>Focus:</u></b></td>
                        <td><b>SALES / MARKETING MANAGEMENT</b></td>
                    </tr>
                    <tr>
                        <td colspan="2">• Consistently develop new business, improve market share, and maximize profits.</td>
                    </tr>
                    <tr>
                        <td colspan="2">• Establish and maintain strong customer relations, loyalty, and repeat business.</td>
                    </tr>
                    <tr>
                        <td colspan="2">• Coordinate successful market research, team efforts, and training programs.</td>
                    </tr>
                </table>
                <p>Please don't use this example as your own, instead create your own using this example as a guide.</p>
                <table class="table">
                    <tr>
                        <td class="auto-style11">We have selected the label for the first section of your Statement of Value to be the following:</td>
                        <td>
                            <asp:RadioButtonList ID="rblSection1Title" runat="server">
                                <asp:ListItem Selected="True">Focus</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="rblSection1Title" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Please enter your objective <b>focus</b>, i.e. Career Counseling / Life Coaching, or choose one or two from the nine major functional areas of any organization, which are listed below, that you want to focus on and enter them in this textbox.</td>
                        <td><asp:TextBox ID="txtFocus" runat="server" maxLength="80" Font-Size="Large" ForeColor="Black" Width="100%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFocus" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">1. &nbsp;&nbsp;  Management</td>
                    </tr>
                    <tr>
                        <td colspan="2">2. &nbsp;&nbsp; Sales</td>
                    </tr>
                    <tr>
                        <td colspan="2">3. &nbsp;&nbsp; Marketing</td>
                    </tr>
                    <tr>
                        <td colspan="2">4. &nbsp;&nbsp; Customer Service</td>
                    </tr>
                    <tr>
                        <td colspan="2">5. &nbsp;&nbsp; Manufacturing</td>
                    </tr>
                    <tr>
                        <td colspan="2">6. &nbsp;&nbsp; Operations</td>
                    </tr>
                    <tr>
                        <td colspan="2">7. &nbsp;&nbsp; Accounting</td>
                    </tr>
                    <tr>
                        <td colspan="2">8. &nbsp;&nbsp; Finance</td>
                    </tr>
                    <tr>
                        <td colspan="2">9. &nbsp;&nbsp; Information Technology</td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">Please enter your <u>three</u> <b>themes of value</b> from your six skill groups on the Focus Analysis Worksheet page, which have been imported below. Additionally, the titles and the final question of each of your eight Focus Experiences have been imported below also. First, combine the six skill groups that you defined separately into <u>three</u> <b>themes</b> (combining two skill groupings that function best together into a new group - <b>theme</b>). State in an action sequence, in the present tense, and in at most <u>eight</u> to <u>ten</u> words what you want to do for someone else that will be the most significant and most valuable to them. These <b>themes of value</b> should reflect the results of all of the analyses of the <b><i>Focus on Purpose process</i></b>. If necessary, review anything else in FOP that has not been imported below using the instructions above to see if there is anything else that is important that needs to be included. Craft each <b>theme</b> so that it reflects what you are most passionate about doing and ideally want to do. This is where you indicate, “Here is what I want to do!”</td>
                        <td rowspan="7">
                            <table class="table">
                                <tr>
                                    <td class="auto-style14"><b><u>Theme #1:</u></b></td>
                                </tr>
                                <tr>
                                    <td class="auto-style15"><textarea id="txtTheme1" runat="server" class="textarea1" style="font-family:'Arial';color:#000000" maxLength="75" ></textarea></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14"><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtTheme1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14"><b><u>Theme #2:</u></b></td>
                                </tr>
                                <tr>
                                    <td class="auto-style16"><textarea id="txtTheme2" runat="server" class="textarea1" style="font-family:'Arial';color:#000000" maxLength="75" ></textarea></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14"><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtTheme2" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style14"><b><u>Theme #3:</u></b></td>
                                </tr>
                                <tr>
                                    <td class="auto-style15"><textarea id="txtTheme3" runat="server" class="textarea1" style="font-family:'Arial';color:#000000" maxLength="75" ></textarea></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14"><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtTheme3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #1:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup1" runat="server" Font-Underline="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #2:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup2" runat="server" Font-Underline="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #3:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup3" runat="server" Font-Underline="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #4:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup4" runat="server" Font-Underline="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #5:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup5" runat="server" Font-Underline="False" CssClass="float-left" style="text-align: left"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style11">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #6:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup6" runat="server" Font-Underline="False" CssClass="float-left"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><b><u>Experience title:</u></b></td>
                        <td><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Experience #1:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><asp:Label ID="lblExperience1Title" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblExperience1Q13" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Experience #2:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><asp:Label ID="lblExperience2Title" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblExperience2Q13" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Experience #3:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><asp:Label ID="lblExperience3Title" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblExperience3Q13" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Experience #4:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><asp:Label ID="lblExperience4Title" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblExperience4Q13" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Experience #5:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><asp:Label ID="lblExperience5Title" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblExperience5Q13" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Experience #6:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><asp:Label ID="lblExperience6Title" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblExperience6Q13" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Experience #7:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><asp:Label ID="lblExperience7Title" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblExperience7Q13" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Experience #8:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style11"><asp:Label ID="lblExperience8Title" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblExperience8Q13" runat="server"></asp:Label></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit2" runat="server" CssClass="auto-style29" OnClick="btnSubmit2_Click" Text="Submit" />
                    <asp:Button ID="btnContinue2" runat="server" CssClass="auto-style29" OnClick="btnContinue2_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError2" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <span class="instructions">Instructions for building your Statement of Value continued:</span>
                <br /><br />
                <p>Here is an example of what the next section of your Statement of Value might look like:</p>
                <table class="table">
                    <tr>
                        <td class="auto-style1"><b><u>Qualifications:</u></b></td>
                        <td>A <b>resourceful</b>, <b>organized</b>, and <b>highly-motivated professional</b> with a unique ability to find and fill a need offering proven experience encompassing:</td>
                    </tr>
                </table>
                <p>Please don't use this example as your own, instead create your own using this example as a guide.</p>
                <table class="table">
                    <tr>
                        <td class="auto-style19">Please select the label for this section of your Statement of Value from the following:</td>
                        <td>
                            <asp:RadioButtonList ID="rblSection2Title" runat="server" Font-Bold="False" CssClass="auto-style17">
                                <asp:ListItem>Qualifications</asp:ListItem>
                                <asp:ListItem>Strengths</asp:ListItem>
                                <asp:ListItem>Supporting skills</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style19"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="rblSection2Title" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td rowspan="5" class="auto-style19">Using your pertinent information from the Total Spiritual Gifts and Personal Management Style pages, which have been imported below, please enter <u>three</u> one-word <b>personal descriptors</b> that tell what kind of person you are and communicate your unique desires and abilities. This is where you indicate, “This is the kind of professional that I am!”</td>
                        <td rowspan="9">
                            <table>
                                <tr>
                                    <td><b><u>Personal descriptor #1:</u></b></td>
                                </tr>
                                <tr>
                                    <td class="style1"><asp:TextBox ID="txtDescriptor1" runat="server" maxLength="60" Font-Size="Large" ForeColor="Black" Width="100%"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtDescriptor1" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td><b><u>Personal descriptor #2:</u></b></td>
                                </tr>
                                <tr>
                                    <td><asp:TextBox ID="txtDescriptor2" runat="server" maxLength="60" Font-Size="Large" ForeColor="Black" Width="100%"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtDescriptor2" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td><b><u>Personal descriptor #3:</u></b></td>
                                </tr>
                                <tr>
                                    <td><asp:TextBox ID="txtDescriptor3" runat="server" maxLength="60" Font-Size="Large" ForeColor="Black" Width="100%"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator90" runat="server" ControlToValidate="txtDescriptor3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">From the Total Spiritual Gifts page, the following are your top three spiritual gifts that you and others believe are the most evident in you, as well as your comments regarding how each of these has most strongly manifested in you:</td>
                    </tr>
                    <tr>
                        <td class="auto-style19"><b><u>Spiritual gifts:</u></b></td>
                        <td><b><u>Your comments:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">1. &nbsp;<asp:Label ID="lblSpiritualGift1" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSpiritualGift1Comments" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">2. &nbsp;<asp:Label ID="lblSpiritualGift2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSpiritualGift2Comments" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">3. &nbsp;<asp:Label ID="lblSpiritualGift3" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSpiritualGift3Comments" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">From the Personal Management Style page, the following are your preferences of your personal management style, as well as your comments regarding how this style is most true of you:</td>
                    </tr>
                    <tr>
                        <td class="auto-style19"><b><u>Personal management style preferences:</u></b></td>
                        <td><b><u>Your comments:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">1. &nbsp;<asp:Label ID="lblPersonalManagementStyle1" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblPMS1Comments" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">2. &nbsp;<asp:Label ID="lblPersonalManagementStyle2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblPMS2Comments" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">3. &nbsp;<asp:Label ID="lblPersonalManagementStyle3" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblPMS3Comments" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style19">4. &nbsp;<asp:Label ID="lblPersonalManagementStyle4" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblPMS4Comments" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style19">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">This section of your Statement of Value is continued on the next page.</td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit3" runat="server" CssClass="auto-style29" OnClick="btnSubmit3_Click" Text="Submit" />
                    <asp:Button ID="btnContinue3" runat="server" CssClass="auto-style29" OnClick="btnContinue3_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError3" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View4" runat="server">
                <span class="instructions">Instructions for building your Statement of Value continued:</span>
                <br /><br />
                <p>Here is an example of what the second part of this section of your Statement of Value might look like:</p>
                <table class="table">
                    <tr>
                        <td>• Developing new business</td>
                        <td>• Customer relations / service</td>
                        <td>• Negotiating / Contracting</td>
                    </tr>
                    <tr>
                        <td>• Marketing / Cross-selling</td>
                        <td>• Territory / Time management</td>
                        <td>• Training / Motivating teams</td>
                    </tr>
                    <tr>
                        <td>• Presenting / Demonstrating</td>
                        <td>• Planning / Implementing goals</td>
                        <td>• Troubleshooting / Resolving</td>
                    </tr>
                </table>
                <p>Please don't use this example as your own, instead create your own using this example as a guide.</p>
                <br />
                <table class="table">
                    <tr>
                        <td colspan="2">From the Focus Analysis Worksheet page, your six most effective skill groups have been imported below. Please choose from these to create your top <u>nine</u> <b>qualifications</b>, and then enter them into the textboxes below. You can combine any two skill groups together into one <b>qualification</b> if you feel that it is appropriate. Also, feel free to add anything else that you feel is appropriate to add to this list of <b>qualifications</b> now. This is where you indicate that, “I am qualified to do what I said I can do for you!” Please enter the <u>most important first</u>, and keep entering the <u>next most important</u> until you have <u>nine</u> <b>qualifications</b>, and then we will place them in the order that gets the most attention on your Statement of Value.</td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #1:</u></b></td>
                        <td><asp:TextBox ID="txtQualification1" runat="server" maxLength="34" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator91" runat="server" ControlToValidate="txtQualification1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #2:</u></b></td>
                        <td><asp:TextBox ID="txtQualification2" runat="server" maxLength="34" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator92" runat="server" ControlToValidate="txtQualification2" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #3:</u></b></td>
                        <td><asp:TextBox ID="txtQualification3" runat="server" maxLength="34" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator93" runat="server" ControlToValidate="txtQualification3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #4:</u></b></td>
                        <td><asp:TextBox ID="txtQualification4" runat="server" maxLength="34" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator94" runat="server" ControlToValidate="txtQualification4" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #5:</u></b></td>
                        <td><asp:TextBox ID="txtQualification5" runat="server" maxLength="32" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator95" runat="server" ControlToValidate="txtQualification5" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #6:</u></b></td>
                        <td><asp:TextBox ID="txtQualification6" runat="server" maxLength="32" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator96" runat="server" ControlToValidate="txtQualification6" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #7:</u></b></td>
                        <td><asp:TextBox ID="txtQualification7" runat="server" maxLength="32" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator97" runat="server" ControlToValidate="txtQualification7" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #8:</u></b></td>
                        <td><asp:TextBox ID="txtQualification8" runat="server" maxLength="34" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator98" runat="server" ControlToValidate="txtQualification8" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style20"><b><u>Qualification #9:</u></b></td>
                        <td><asp:TextBox ID="txtQualification9" runat="server" maxLength="34" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style20"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator99" runat="server" ControlToValidate="txtQualification9" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style20">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #1:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup11" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #2:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #3:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup13" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #4:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup14" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #5:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup15" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Skill group #6:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="lblSkillGroup16" runat="server"></asp:Label></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit4" runat="server" CssClass="auto-style29" OnClick="btnSubmit4_Click" Text="Submit" />
                    <asp:Button ID="btnContinue4" runat="server" CssClass="auto-style29" OnClick="btnContinue4_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError4" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View5" runat="server">
                <span class="instructions">Instructions for building your Statement of Value continued:</span>
                <br /><br />
                <p>Here is an example of what the next section of your Statement of Value might look like:</p>
                <p><b>Please note:</b> We have provided numerous example achievements below, more than you will need to complete; however, you will only need to complete eight achievements below for your Statement of Value. The additional examples provided below are only given to better help you to write your eight achievements on this page.</p>
                <p><b><u>Achievements:</u></b></p>
                <p>COMMUNICATED VISION for <i>“Freedom from Marketplace Bondage”</i> by hosting <b>50</b> weekly live radio programs with on-air callers, monthly “Marketing Reality Check” seminars (to <b>5 to 50</b>), presentations before international audiences at national Christian men’s conferences, and authored the definitive work on work, <i>Being About My Father’s Business</i>.</p>
                <p>DESIGNED PROGRAMS, HANDOUTS, AND PROCEDURES for assisting over <b>2,000</b> professionals and managers over <b>7</b> years in a personalized counseling program designed to empower and motivate others.</p>
                <p>CHAIRED <b>2</b> NATIONAL TASK FORCE TEAMS specifically charged to formulate sound recommendations for controlling a <b>$3B</b> debt and develop underwriting guidelines for <b>200,000</b> loans.</p>
                <p>MASTERED <b>15</b> SEPARATE FUNCTIONS AND CONSISTENTLY DEMONSTRATED PERFORMANCE IMPROVEMENT earning an unprecedented <b>10 promotions over the course of 12 years</b> (capped as Acting Director of the largest Veterans’ Administration regional office in the nation – Los Angeles, California), where we managed <b>8%</b> of all veterans’ services nationwide.</p>
                <p>WROTE MONTHLY NEWSLETTERS for <b>2</b> years and several <i>“White Papers”</i> requested for Congressional testimony and development of federal legislative regulations (were also circulated to a staff of <b>570</b>).</p>
                <p>ASSISTED <b>75</b> SERIOUSLY DISABLED VETERANS by managing construction, remodeling, and adaptation of homes to meet vocational and residential needs, and supervised the program nationally helping <b>1,500</b> veterans in total.</p>
                <p>DEVELOPED INNOVATIVE INCENTIVE AND TRAINING PROGRAMS (as Division Manager) enabling a <b>170</b> member and <b>4</b> function division to cope with a <b>700%</b> workload increase and <b>15%</b> staffing decrease at the same time within a <b>120</b> day period.</p>
                <p>DEMONSTRATED EXCELLENCE AND SERVICE by being selected as <b>1 of 60</b> (from a master pool of <b>45,000</b>) to be trained for a full year of leadership and management development, while also receiving <b>3</b> “Superior Performance” awards and <b>2</b> “National Public Service” awards during the same <b>4</b> year period.</p>
                <p>EDUCATED AND RECOMMENDED POSITIVE OPTIONS to over <b>150</b> (achieving a <b>1 in 3</b> influence rate), in order to reach the <b>$2MM club</b>, amongst <b>100</b> peers <b>(top 10)</b>.</p>
                <p>LED A DIVERSE TEAM of <b>13</b> from <b>11</b> different departments, in order to convert <b>$2B</b> in loans into borrowing capacity, which produced a <b>40%</b> increase that significantly reduced the funding cost basis.</p>
                <p>QUICKLY NAVIGATED NEW DEPARTMENT with a team of <b>5</b> over the course of <b>4</b> months originally with a <b>60%</b> turnover, replacing all open positions, which resulted in an, “upgraded talent pool" – a very noteworthy managerial accomplishment.</p>
                <p>DEVELOPED EXCEPTIONAL RAPPORT AND TRUST by hand-feeding a new customer away from an established competitor, which increased sales <b>400%</b> over the course of <b>9</b> months to <b>$145K</b>.</p>
                <p>CREATED AN INNOVATIVE TEAM FORMAT by recommending the realignment of a <b>35</b> member Sales / Support staff, to escalate morale, motivation, and sales, in order to generate an annual increase of <b>15%</b> to <b>$3.5MM</b>.</p>
                <p>IMPROVED CUSTOMER SATISFACTION INDEX <b>85%</b> by instituting and conducting daily control meetings for a staff of <b>25</b>, which significantly improved harmony, and facilitated a <b>35%</b> increase in peak-time business.</p>
                <p>EXCEEDED ALL SALES GOALS consistently for <b>18</b> months (exploding new business sales from <b>$1.8MM</b> to <b>$2.75MM</b>), in order to reach the <b>top 1/2%</b> amongst <b>250</b> peers.</p>
                <p>OPENED MOST NEW SALES ACCOUNTS (<b>40</b> within the first <b>60</b> days in new position), amongst <b>14</b> veteran sales representatives, and was District Leader for the first <b>3</b> quarters (these new accounts represented <b>37%</b> of all sales during this time period).</p>
                <p>INCREASED REVENUE AND PROFIT MARGINS for <b>8</b> area offices by recruiting a team of business development managers, who escalated the regional average to the <b>#1 position</b> amongst <b>200</b> offices nationwide.</p>
                <p>FACILITATED A DIVERSE INTERCULTURAL CONFERENCE with <b>3</b> different language groups present, representing <b>7</b> different countries, over the course of <b>5</b> days, with <b>275</b> attending, which resulted in solid agreements, in order to guide a <b>32,000</b> member organization.</p>
                <p>PREACHED THE WORD OF GOD proudly and influentially throughout the world on <b>3</b> separate missionary journeys, where I visited over <b>18</b> different countries and <b>43</b> different cities over the course of <b>12</b> years.</p>
                <p>DEMONSTRATED LIFESTYLE QUALITY by successfully competing against <b>75</b> other athletes in a <b>100</b> mile road race (finished <b>5th</b>), and became a <b>national qualifier</b>.</p>
                <p>Please don't use this example as your own, instead create your own using this example as a guide.</p>
                <table class="table">
                    <tr>
                        <td colspan="2" class="auto-style6">Please select the label for this section of your Statement of Value from the following:</td>
                        <td>
                            <asp:RadioButtonList ID="rblSection3Title" runat="server" Font-Bold="False" CssClass="float-left">
                                <asp:ListItem>Achievements</asp:ListItem>
                                <asp:ListItem>Past successes</asp:ListItem>
                                <asp:ListItem>Demonstrated value</asp:ListItem>
                                <asp:ListItem>Examples of success</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="auto-style6"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="rblSection3Title" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" CssClass="float-left">Required</asp:RequiredFieldValidator></td>
                    </tr>
                </table>
                <br />
                <table class="table">
                    <tr>
                        <td colspan="3">Using your eight most meaningful past work experiences that you used to define and defend your product on the Focus Experience pages, please enter <u>eight</u> <b>achievements</b> that most support your objective <b>focus</b>. This is where you indicate, “I can prove it with these examples!” The titles and three most relevant questions for each of your Focus Experiences have been imported below. Please review the examples listed above and build your own <b>achievements</b> in the same style and format. The first two that you create should be reasonably recent (within the last two years), and be from your current or last assignment if possible, and that have the most impact on and support for your objective <b>focus</b>. Keep entering the <u>next most supportive</u> until you have <u>eight</u> <b>achievements</b>, and we will arrange them in the most impactful order on your Statement of Value. Start each <b>achievement</b> with a strong past-tense action phrase that supports your <b>themes of value</b> (ideally you should try to use <u>two</u> or <u>three</u> <b>achievements</b> to support each of your <b>themes</b>). Use numbers to show the scope of the problem and the impact of the results – using rankings, changes, sizes, and quantifications; numbers and measurements convey a strong sense of successful results! Measure with numbers everything that can be measured within reason! Use all capital letters for the action phrase that begins each <b>achievement</b>, and use parentheses and double quotations when it is appropriate and will make more of an impact. Look at the examples above for proper formatting of your <b>achievements</b>.</td>
                    </tr>
                    <tr>
                        <td colspan="3"><br />All eight of your <b>achievements</b> (and more if you have them) will be listed again on the second document of your marketing documents (on your Expanded Experience Profile) under the associated assignment positions. On your Expanded Experience Profile that you will be creating shortly, you will list your current and previous assignments in order from the present to the earliest, in reverse-chronological order. Your Expanded Experience Profile will serve as your resume, but you should only give it out after you have given them your Statement of Value first, and are able to control the interview.</td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style41"><b><u>Achievement #1:</u></b></td>
                        <td colspan="2" class="auto-style21"><textarea id="txtAchievement1" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style42"></td>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtAchievement1" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style33"><b><u>Achievement #2:</u></b></td>
                        <td colspan="2" class="auto-style23"><textarea id="txtAchievement2" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style42"></td>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txtAchievement2" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style34"><b><u>Achievement #3:</u></b></td>
                        <td colspan="2" class="auto-style24"><textarea id="txtAchievement3" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style42"></td>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txtAchievement3" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style35"><b><u>Achievement #4:</u></b></td>
                        <td colspan="2" class="auto-style26"><textarea id="txtAchievement4" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style42"></td>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="txtAchievement4" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style36"><b><u>Achievement #5:</u></b></td>
                        <td colspan="2" class="auto-style27"><textarea id="txtAchievement5" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style42"></td>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="txtAchievement5" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style37"><b><u>Achievement #6:</u></b></td>
                        <td colspan="2" class="auto-style28"><textarea id="txtAchievement6" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style42"></td>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="txtAchievement6" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style38"><b><u>Achievement #7:</u></b></td>
                        <td colspan="2" class="auto-style30"><textarea id="txtAchievement7" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style42"></td>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="txtAchievement7" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style39"><b><u>Achievement #8:</u></b></td>
                        <td colspan="2" class="auto-style31"><textarea id="txtAchievement8" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style42"></td>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="txtAchievement8" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">From the Focus Experience pages, the following are the titles and three most relevant questions for all eight of your Focus Experiences:</td>
                    </tr>
                </table>
                <table class="table">
                    <tr>
                        <td class="auto-style7"><b><u>Experience #1 title:</u></b></td>
                        <td colspan="2"><asp:Label ID="lblExperience1Title2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                        <td><asp:Label ID="lblExperience1Q9" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience1Q12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience1Q132" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b><u>Experience #2 title:</u></b></td>
                        <td colspan="2"><asp:Label ID="lblExperience2Title2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                        <td><asp:Label ID="lblExperience2Q9" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience2Q12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience2Q132" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b><u>Experience #3 title:</u></b></td>
                        <td colspan="2"><asp:Label ID="lblExperience3Title2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                        <td><asp:Label ID="lblExperience3Q9" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience3Q12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience3Q132" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b><u>Experience #4 title:</u></b></td>
                        <td colspan="2"><asp:Label ID="lblExperience4Title2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                        <td><asp:Label ID="lblExperience4Q9" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience4Q12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience4Q132" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b><u>Experience #5 title:</u></b></td>
                        <td colspan="2"><asp:Label ID="lblExperience5Title2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                        <td><asp:Label ID="lblExperience5Q9" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience5Q12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience5Q132" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b><u>Experience #6 title:</u></b></td>
                        <td colspan="2"><asp:Label ID="lblExperience6Title2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                        <td><asp:Label ID="lblExperience6Q9" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience6Q12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience6Q132" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b><u>Experience #7 title:</u></b></td>
                        <td colspan="2"><asp:Label ID="lblExperience7Title2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                        <td><asp:Label ID="lblExperience7Q9" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience7Q12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience7Q132" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b><u>Experience #8 title:</u></b></td>
                        <td colspan="2"><asp:Label ID="lblExperience8Title2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>What were the results (qualify, quantify, measure, rank, and/or compare):</b></td>
                        <td><asp:Label ID="lblExperience8Q9" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State the most valuable thing you feel you did for the organization (and/or for someone else):</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience8Q12" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7"><b>State in 10 words or less what you did in this experience that best describes the combination of WHAT YOU MOST ENJOY and are MOST EFFECTIVE DOING in action terms:</b></td>
                        <td colspan="2"><asp:Label ID="lblExperience8Q132" runat="server"></asp:Label></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit5" runat="server" CssClass="float-right" OnClick="btnSubmit5_Click" Text="Submit" />
                    <asp:Button ID="btnContinue5" runat="server" CssClass="float-right" OnClick="btnContinue5_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError5" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View6" runat="server">
                <span class="instructions">Instructions for building your Statement of Value continued:</span>
                <br /><br />
                <p>Here is an example of what the final section of your Statement of Value might look like:</p>
                <p><b><u>Professional Experience:</u></b></p>
                <p>Excellent background in <b>SALES / MARKETING MANAGEMENT</b> developed over 20 years in highly successful leadership positions as: VP Corporate Sales, Regional Sales Director, Marketing Manager, Customer Service Manager, Technical Liaison, Sales Representative, and (while attending college full-time) Sales Clerk.</p>
                <p>Please don't use this example as your own, instead create your own using this example as a guide.</p>
                <table class="table">
                    <tr>
                        <td>Please select the label for the final section of your Statement of Value from the following:</td>
                        <td>
                            <asp:RadioButtonList ID="rblSection4Title" runat="server" Font-Bold="False">
                                <asp:ListItem>Professional Experience</asp:ListItem>
                                <asp:ListItem>Relevant Experience</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="rblSection4Title" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">Please enter a listing of your meaningful (actual or functional) <b>job assignment titles</b> without the company names, other information, and so forth. Start the listing with the <u>most important</u> <b>job assignment position</b> that you have held, regardless of the chronological order, and then continue on down to the least important last. Include voluntary positions if supportive to your objective <b>focus</b> by any means. Include only your meaningful <b>job assignment titles</b>, and we will automatically precede this listing by restating your objective <b>focus</b> that you defined earlier, as is done in the example above. This is where you indicate that, “This is where I did it!”</td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Meaningful job assignment titles:</u></b></td>
                    </tr>
                    <tr>
                        <td colspan="2" class="auto-style40"><textarea id="txtJobTitles" runat="server" class="textarea2" maxLength="420" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="txtJobTitles" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit6" runat="server" CssClass="float-right" OnClick="btnSubmit6_Click" Text="Submit" />
                    <asp:Button ID="btnContinue6" runat="server" CssClass="float-right" OnClick="btnContinue6_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError6" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View7" runat="server">
                <span class="instructions">Instructions for building your Expanded Experience Profile (resume):</span>
                <br /><br />
                <p>Here is an example of what the first section of your Expanded Experience Profile might look like:</p>
                <table class="table">
                    <tr>
                        <td class="auto-style3"><b><u>Loan Guaranty Officer</u></b></td>
                        <td class="auto-style4">Veterans Administration</td>
                        <td>1976 - 1988</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <ul>
                                <li>Developed innovative incentive and training programs (as Division Manager), which enabled a 170 member and 4 function division to cope with a 700% workload increase and 15% staffing decrease at the same time within a 120 day period. Earned a “Superior Performance” award for this effort, the first one awarded in the history of the Los Angeles, California regional office.</li>
                                <br />
                                <li>Demonstrated excellence in service by being selected as 1 of 60 (from a master pool of 45,000 eligible), to be trained for a full year of leadership and management development, while also receiving 3 “Superior Performance” awards and 2 “National Public Service” awards during the same 4 year period.</li>
                                <br />
                                <li>Wrote a monthly newsletter and several “White Papers,” which were requested for Congressional testimony and development of federal legislative regulations (were also circulated to a staff of 570).</li>
                                <br />
                                <li>Prepared and delivered speeches and presentations (35 annually for 5 years) to numerous national, state, and local audiences from 50 to 2,200, and designed a format for a 30 minute, personal briefing delivered to the Secretary of the V.A. (this member of President Reagan’s Cabinet, a 4-star General said, “Exceptional”).</li>
                                <br />
                                <li>Chaired 2 National Task Force teams, which were specifically charged to formulate sound recommendations for the purpose of controlling a $3B debt, and developing underwriting guidelines for 200,000 loans annually.</li>
                                <br />
                                <li>Mastered 15 separate functions and consistently demonstrated performance improvement, by earning an unprecedented 10 promotions over 12 years with the Veterans Administration, which was capped by serving as Acting Director of the largest regional office in the U.S. – Los Angeles, California – where we managed 8% of all veterans’ services nationwide.</li>
                                <br />
                                <li>Moreover, also held a position as Assistant Chief of Specially Adapted Housing in Washington D.C.</li>
                            </ul>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">Please don't use this example as your own, instead create your own using this example as a guide.</td>
                    </tr>
                </table>
                <br />
                <table class="table">
                    <tr>
                        <td colspan="2">Now, please begin a chronology of your past work history – detailing each of your <b>job assignment positions</b> from the present back <u>20</u> years or your past <u>five</u> <b>job assignment positions</b>, whichever comes first.</td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">All of your <b>achievements</b> that you included on your Statement of Value have been imported below. Please copy and paste each of your <b>achievements</b> into the associated <b>job assignment positions</b> below (adding more information, if necessary, and making these flow as a narrative). Include as much information about each <b>job assignment position</b> and its corresponding <b>achievements</b> as you would like, such as information about the company, there is no limitation. You should include all of your <b>achievements</b> that are displayed below somewhere in this chronology under the corresponding <b>job assignment positions</b> that you have held. Add wording to each of your <b>achievements</b> as necessary, so that your narrative for each <b>job assignment position</b> flows smoothly. Then on the next page, you will also add a section that will follow this listing with expanded information on your education, additional training, honors and awards, military service, voluntary positions, and anything else that you’d like to include. When completed, your Expanded Experience Profile will serve as your resume!</td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Achievement #1:</u></b></td>
                        <td><asp:Label ID="lblAchievement1" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Achievement #2:</u></b></td>
                        <td><asp:Label ID="lblAchievement2" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Achievement #3:</u></b></td>
                        <td><asp:Label ID="lblAchievement3" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Achievement #4:</u></b></td>
                        <td><asp:Label ID="lblAchievement4" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Achievement #5:</u></b></td>
                        <td><asp:Label ID="lblAchievement5" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Achievement #6:</u></b></td>
                        <td><asp:Label ID="lblAchievement6" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Achievement #7:</u></b></td>
                        <td><asp:Label ID="lblAchievement7" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Achievement #8:</u></b></td>
                        <td><asp:Label ID="lblAchievement8" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Job assignment position #1:</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtTitle1" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="txtTitle1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompanyName1" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="txtCompanyName1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Years employed:</u></b></td>
                        <td><asp:TextBox ID="txtYears1" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="txtYears1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style58"><b><u>Narrative including your achievements:</u></b></td>
                        <td class="auto-style59"><textarea id="txtNarrative1" runat="server" class="textarea3" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="txtNarrative1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Job assignment position #2:</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtTitle2" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompanyName2" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Years employed:</u></b></td>
                        <td><asp:TextBox ID="txtYears2" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style58"><b><u>Narrative including your achievements:</u></b></td>
                        <td class="auto-style59"><textarea id="txtNarrative2" runat="server" class="textarea3" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Job assignment position #3:</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtTitle3" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompanyName3" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Years employed:</u></b></td>
                        <td><asp:TextBox ID="txtYears3" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style60"><b><u>Narrative including your achievements:</u></b></td>
                        <td class="auto-style62"><textarea id="txtNarrative3" runat="server" class="textarea3" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Job assignment position #4:</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtTitle4" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompanyName4" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Years employed:</u></b></td>
                        <td><asp:TextBox ID="txtYears4" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style63"><b><u>Narrative including your achievements:</u></b></td>
                        <td class="auto-style64"><textarea id="txtNarrative4" runat="server" class="textarea3" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Job assignment position #5:</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtTitle5" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompanyName5" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b><u>Years employed:</u></b></td>
                        <td><asp:TextBox ID="txtYears5" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="65%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style65"><b><u>Narrative including your achievements:</u></b></td>
                        <td class="auto-style67"><textarea id="txtNarrative5" runat="server" class="textarea3" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">Building your Expanded Experience Profile is continued on the next page.</td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit7" runat="server" CssClass="auto-style29" OnClick="btnSubmit7_Click" Text="Submit" />
                    <asp:Button ID="btnContinue7" runat="server" CssClass="auto-style29" OnClick="btnContinue7_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError7" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View8" runat="server">
                <span class="instructions">Instructions for building your Expanded Experience Profile (resume) continued:</span>
                <br /><br />
                <p>Here is an example of what this section of your Expanded Experience Profile might look like:</p>
                <p><b><u>Education / Training:</u></b></p>
                <p>Master's of Administration in Criminology in 1979, Bachelor's of Administration in Psychology in 1975, and a Bachelor's of Science in the Administration of Justice in 1975 (all Summa Cum Laude) from the Wichita State University. Associate's of Arts in Nuclear Weapons Electronics and Guidance Systems from the College of the Air Force in 1968. Counseling God’s Way from the American Association of Christian Counselors and the Light Institute in 2007.</p>
                <p>Please don't use this example as your own, instead create your own using this example as a guide.</p>
                <br />
                <p>For this section of your Expanded Experience Profile, we encourage you to include expanded information on any of the following areas: your 1) <b>education</b>, 2) <b>additional training</b>, 3) <b>honors and awards</b>, 4) <b>military service</b>, 5) <b>voluntary positions</b>, and/or 6) anything else that you'd like to include. This section is optional; however, if you have any degrees, certifications, additional training, and so forth that is relevant and noteworthy, we encourage you to include it here on your own Expanded Experience Profile.</p>
                <table class="auto-style56">
                    <tr>
                        <td class="auto-style44"><b><u>Education:</u></b></td>
                        <td class="auto-style28"><textarea id="txtEducation" runat="server" cols="60" class="textarea2" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style45"><b><u>Additional training:</u></b></td>
                        <td class="auto-style46"><textarea id="txtTraining" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style49"><b><u>Honors and awards:</u></b></td>
                        <td class="auto-style50"><textarea id="txtHonorsAndAwards" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style53"><b><u>Military service:</u></b></td>
                        <td class="auto-style54"><textarea id="txtMilitaryService" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style55"><b><u>Voluntary positions:</u></b></td>
                        <td class="auto-style52"><textarea id="txtVoluntaryPositions" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style43"><b><u>Other:</u></b></td>
                        <td class="auto-style57"><textarea id="txtOther" runat="server" class="textarea2" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit8" runat="server" CssClass="auto-style29" OnClick="btnSubmit8_Click" Text="Submit" />
                    <asp:Button ID="btnContinue8" runat="server" CssClass="auto-style29" OnClick="btnContinue8_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError8" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View9" runat="server">
                <span class="instructions">Instructions for building your References list:</span>
                <br /><br />
                <p>Here is an example of what the first section of your References list might look like:</p>
                <span>Pat Big</span>
                <br />
                <span>Executive Manager</span>
                <br />
                <span>XYZ Widget Inc.</span>
                <br />
                <span>Direct Supervisor for 4 years</span>
                <br />
                <span>callmeplease@whatup.com</span>
                <br />
                <span>(123) 456-7890</span>
                <br /><br />
                <p>Please build your <b>References list</b> by including: 1) professional, 2) personal, and 3) character <b>references</b> with the information indicated below. You should have at least <u>two</u> of each of these for a total of <u>eight</u> <b>references</b>.</p>
                <table class="table">
                    <tr>
                        <td colspan="2" class="instructions">Reference #1:</td>
                    </tr>
                    <tr>
                        <td><b><u>Name:</u></b></td>
                        <td><asp:TextBox ID="txtName1" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="txtName1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtJobTitle1" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="txtJobTitle1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompany1" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" ControlToValidate="txtCompany1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Relationship:</u></b></td>
                        <td><asp:TextBox ID="txtRelationship1" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" ControlToValidate="txtRelationship1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Email address:</u></b></td>
                        <td><asp:TextBox ID="txtEmailAddress1" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ControlToValidate="txtEmailAddress1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtEmailAddress1" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Phone number:</u></b></td>
                        <td><asp:TextBox ID="txtPhoneNumber1" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" ControlToValidate="txtPhoneNumber1" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtPhoneNumber1" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Valid Phone Format: (123) 456-7890</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Reference #2:</td>
                    </tr>
                    <tr>
                        <td><b><u>Name:</u></b></td>
                        <td><asp:TextBox ID="txtName2" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator36" runat="server" ControlToValidate="txtName2" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtJobTitle2" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator37" runat="server" ControlToValidate="txtJobTitle2" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompany2" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator38" runat="server" ControlToValidate="txtCompany2" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Relationship:</u></b></td>
                        <td><asp:TextBox ID="txtRelationship2" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator39" runat="server" ControlToValidate="txtRelationship2" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Email address:</u></b></td>
                        <td><asp:TextBox ID="txtEmailAddress2" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator40" runat="server" ControlToValidate="txtEmailAddress2" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtEmailAddress2" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Phone number:</u></b></td>
                        <td><asp:TextBox ID="txtPhoneNumber2" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator41" runat="server" ControlToValidate="txtPhoneNumber2" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txtPhoneNumber2" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Valid Phone Format: (123) 456-7890</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Reference #3:</td>
                    </tr>
                    <tr>
                        <td><b><u>Name:</u></b></td>
                        <td><asp:TextBox ID="txtName3" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator42" runat="server" ControlToValidate="txtName3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtJobTitle3" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator43" runat="server" ControlToValidate="txtJobTitle3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompany3" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator44" runat="server" ControlToValidate="txtCompany3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Relationship:</u></b></td>
                        <td><asp:TextBox ID="txtRelationship3" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator45" runat="server" ControlToValidate="txtRelationship3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Email address:</u></b></td>
                        <td><asp:TextBox ID="txtEmailAddress3" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator46" runat="server" ControlToValidate="txtEmailAddress3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtEmailAddress3" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Phone number:</u></b></td>
                        <td><asp:TextBox ID="txtPhoneNumber3" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator47" runat="server" ControlToValidate="txtPhoneNumber3" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txtPhoneNumber3" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Valid Phone Format: (123) 456-7890</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Reference #4:</td>
                    </tr>
                    <tr>
                        <td><b><u>Name:</u></b></td>
                        <td><asp:TextBox ID="txtName4" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator58" runat="server" ControlToValidate="txtName4" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtJobTitle4" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator57" runat="server" ControlToValidate="txtJobTitle4" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompany4" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator56" runat="server" ControlToValidate="txtCompany4" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Relationship:</u></b></td>
                        <td><asp:TextBox ID="txtRelationship4" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator55" runat="server" ControlToValidate="txtRelationship4" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Email address:</u></b></td>
                        <td><asp:TextBox ID="txtEmailAddress4" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator54" runat="server" ControlToValidate="txtEmailAddress4" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="txtEmailAddress4" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Phone number:</u></b></td>
                        <td><asp:TextBox ID="txtPhoneNumber4" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator53" runat="server" ControlToValidate="txtPhoneNumber4" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ControlToValidate="txtPhoneNumber4" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Valid Phone Format: (123) 456-7890</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Reference #5:</td>
                    </tr>
                    <tr>
                        <td><b><u>Name:</u></b></td>
                        <td><asp:TextBox ID="txtName5" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator59" runat="server" ControlToValidate="txtName5" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtJobTitle5" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator60" runat="server" ControlToValidate="txtJobTitle5" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompany5" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator61" runat="server" ControlToValidate="txtCompany5" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Relationship:</u></b></td>
                        <td><asp:TextBox ID="txtRelationship5" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator62" runat="server" ControlToValidate="txtRelationship5" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Email address:</u></b></td>
                        <td><asp:TextBox ID="txtEmailAddress5" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator63" runat="server" ControlToValidate="txtEmailAddress5" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="txtEmailAddress5" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Phone number:</u></b></td>
                        <td><asp:TextBox ID="txtPhoneNumber5" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator64" runat="server" ControlToValidate="txtPhoneNumber5" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" ControlToValidate="txtPhoneNumber5" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Valid Phone Format: (123) 456-7890</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Reference #6:</td>
                    </tr>
                    <tr>
                        <td><b><u>Name:</u></b></td>
                        <td><asp:TextBox ID="txtName6" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator65" runat="server" ControlToValidate="txtName6" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtJobTitle6" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator66" runat="server" ControlToValidate="txtJobTitle6" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompany6" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator67" runat="server" ControlToValidate="txtCompany6" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Relationship:</u></b></td>
                        <td><asp:TextBox ID="txtRelationship6" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator68" runat="server" ControlToValidate="txtRelationship6" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Email address:</u></b></td>
                        <td><asp:TextBox ID="txtEmailAddress6" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator69" runat="server" ControlToValidate="txtEmailAddress6" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator13" runat="server" ControlToValidate="txtEmailAddress6" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Phone number:</u></b></td>
                        <td><asp:TextBox ID="txtPhoneNumber6" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator70" runat="server" ControlToValidate="txtPhoneNumber6" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator14" runat="server" ControlToValidate="txtPhoneNumber6" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Valid Phone Format: (123) 456-7890</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Reference #7:</td>
                    </tr>
                    <tr>
                        <td><b><u>Name:</u></b></td>
                        <td><asp:TextBox ID="txtName7" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator71" runat="server" ControlToValidate="txtName7" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtJobTitle7" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator72" runat="server" ControlToValidate="txtJobTitle7" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompany7" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator73" runat="server" ControlToValidate="txtCompany7" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Relationship:</u></b></td>
                        <td><asp:TextBox ID="txtRelationship7" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator74" runat="server" ControlToValidate="txtRelationship7" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Email address:</u></b></td>
                        <td><asp:TextBox ID="txtEmailAddress7" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator75" runat="server" ControlToValidate="txtEmailAddress7" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator15" runat="server" ControlToValidate="txtEmailAddress7" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Phone number:</u></b></td>
                        <td><asp:TextBox ID="txtPhoneNumber7" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator76" runat="server" ControlToValidate="txtPhoneNumber7" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator16" runat="server" ControlToValidate="txtPhoneNumber7" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Valid Phone Format: (123) 456-7890</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2" class="instructions">Reference #8:</td>
                    </tr>
                    <tr>
                        <td><b><u>Name:</u></b></td>
                        <td><asp:TextBox ID="txtName8" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator77" runat="server" ControlToValidate="txtName8" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Job assignment title:</u></b></td>
                        <td><asp:TextBox ID="txtJobTitle8" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator78" runat="server" ControlToValidate="txtJobTitle8" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Company name:</u></b></td>
                        <td><asp:TextBox ID="txtCompany8" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator79" runat="server" ControlToValidate="txtCompany8" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Relationship:</u></b></td>
                        <td><asp:TextBox ID="txtRelationship8" runat="server" maxLength="35" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator80" runat="server" ControlToValidate="txtRelationship8" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Email address:</u></b></td>
                        <td><asp:TextBox ID="txtEmailAddress8" runat="server" maxLength="40" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator81" runat="server" ControlToValidate="txtEmailAddress8" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator17" runat="server" ControlToValidate="txtEmailAddress8" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Valid Email Address Required</asp:RegularExpressionValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b><u>Phone number:</u></b></td>
                        <td><asp:TextBox ID="txtPhoneNumber8" runat="server" maxLength="14" Font-Size="Large" ForeColor="Black" Width="70%"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator82" runat="server" ControlToValidate="txtPhoneNumber8" CssClass="float-left" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator18" runat="server" ControlToValidate="txtPhoneNumber8" CssClass="float-left" ErrorMessage="RegularExpressionValidator" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Valid Phone Format: (123) 456-7890</asp:RegularExpressionValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit9" runat="server" CssClass="auto-style29" OnClick="btnSubmit9_Click" Text="Submit" />
                    <asp:Button ID="btnContinue9" runat="server" CssClass="auto-style29" OnClick="btnContinue9_Click" Text="Continue" Visible="False" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError9" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View10" runat="server">
                <span class="instructions">Please click on all of the links below to download your marketing documents package. These files will be downloaded to the Downloads folder on your computer (unless you have changed your web browser's default settings). If asked whether to open or save, please choose save.</span>
                <br /><br />
                <p>These three documents, your <b>Statement of Value</b>, <b>Expanded Experience Profile</b>, and <b>References list</b>, complete your <b>marketing documents package</b>, which is necessary for an effective career marketing campaign. Now that you have completed this page, your RUG Authorized Personal Counselor (APC) has been notified, and he/she will be reaching out to you as soon as they are able by phone, in order to advise you regarding your polished edit of your <b>marketing documents</b>. This is an optional service that we offer to our clients, to ensure that you are market ready. Once these are finalized, we recommend that you print these documents on good quality bond paper. These are “living documents,” so always keep them updated and current – always be ready for your next assignment on your <b><i>BestPath</i></b>. Finally, it has been an honor to work with you and to serve you in this <b><i>Focus on Purpose process</i></b>! May God richly bless you and your family!</p>
                <br />
                <asp:LinkButton ID="lbStatementOfValue" runat="server" Font-Bold="True" OnClick="lbStatementOfValue_Click" Font-Size="Large" ForeColor="Black">Statement of Value</asp:LinkButton>
                <br /><br />
                <asp:LinkButton ID="lbExpandedExperienceProfile" runat="server" Font-Bold="True" OnClick="lbExpandedExperienceProfile_Click" Font-Size="Large" ForeColor="Black">Expanded Experience Profile</asp:LinkButton>
                <br /><br />
                <asp:LinkButton ID="lbReferences" runat="server" Font-Bold="True" OnClick="lbReferences_Click" Font-Size="Large" ForeColor="Black">References list</asp:LinkButton>
                <br /><br />
                <p class="instructions">After downloading your marketing documents, it is very important that your Statement of Value is only one page, and if it is not, that it is edited down to one page.</p>
                <p class="instructions">Please see the FAQs on the Help or Before You Begin pages for instructions to convert your marketing documents to either Microsoft Word .doc or .docx file formats.</p>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnContinue10" runat="server" CssClass="auto-style29" OnClick="btnContinue10_Click" Text="Continue" CausesValidation="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError10" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
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
            width: 15%;
        }
        .auto-style3 {
            width: 40%;
        }
        .auto-style4 {
            width: 50%;
        }
        .auto-style5 {
            width: 30%;
        }
        .auto-style6 {
            width: 35%;
        }
        .auto-style7 {
            width: 40%;
        }
        .textarea1 {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 100%;
            height: 100%
        }
        .textarea2 {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 70%;
            height: 100%
        }
        .textarea3 {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 85%;
            height: 100%
        }
        .auto-style9 {
            width: 50%;
        }
        .auto-style11 {
            width: 65%;
        }
        .auto-style14 {
            width: 500%;
        }
        .auto-style15 {
            width: 500%;
            height: 160px;
        }
        .auto-style16 {
            width: 500%;
            height: 165px;
        }
        .style1 {
            width: 30%;
        }
        .auto-style17 {
            float: left;
            margin-left: 0px;
        }
        .auto-style19 {
            width: 293px;
        }
        .auto-style20 {
            width: 30%;
        }
        .auto-style21 {
            width: 30%;
            height: 160px;
        }
        .auto-style23 {
            height: 155px;
        }
        .auto-style24 {
            height: 145px;
        }
        .auto-style26 {
            height: 161px;
        }
        .auto-style27 {
            height: 151px;
        }
        .auto-style28 {
            height: 148px;
        }
        .auto-style29 {
            height: 66px;
        }
        .auto-style30 {
            height: 159px;
        }
        .auto-style31 {
            height: 152px;
        }
        .auto-style33 {
            height: 155px;
            width: 9%;
        }
        .auto-style34 {
            height: 145px;
            width: 9%;
        }
        .auto-style35 {
            height: 161px;
            width: 9%;
        }
        .auto-style36 {
            height: 151px;
            width: 9%;
        }
        .auto-style37 {
            height: 148px;
            width: 9%;
        }
        .auto-style38 {
            height: 159px;
            width: 9%;
        }
        .auto-style39 {
            height: 152px;
            width: 9%;
        }
        .auto-style40 {
            height: 164px;
        }
        .auto-style41 {
            width: 9%;
            height: 160px;
        }
        .auto-style42 {
            width: 9%;
        }
        .auto-style43 {
            width: 20%;
            height: 140px;
        }
        .auto-style44 {
            width: 20%;
            height: 148px;
        }
        .auto-style45 {
            width: 20%;
            height: 146px;
        }
        .auto-style46 {
            height: 146px;
        }
        .auto-style49 {
            width: 20%;
            height: 149px;
        }
        .auto-style50 {
            height: 149px;
        }
        .auto-style52 {
            height: 157px;
        }
        .auto-style53 {
            width: 20%;
            height: 169px;
        }
        .auto-style54 {
            height: 169px;
        }
        .auto-style55 {
            width: 20%;
            height: 157px;
        }
        .auto-style56 {
            width: 100%;
            margin-bottom: 21px;
        }
        .auto-style57 {
            height: 140px;
        }
        .auto-style58 {
            width: 30%;
            height: 156px;
        }
        .auto-style59 {
            height: 156px;
        }
        .auto-style60 {
            width: 30%;
            height: 153px;
        }
        .auto-style62 {
            height: 153px;
        }
        .auto-style63 {
            width: 30%;
            height: 144px;
        }
        .auto-style64 {
            height: 144px;
        }
        .auto-style65 {
            width: 30%;
            height: 150px;
        }
        .auto-style66 {
            height: 143px;
        }
        .auto-style67 {
            height: 150px;
        }
    </style>
</asp:Content>

