<%@ Page Title="Total Spiritual Gifts" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="TotalSpiritualGifts.aspx.cs" Inherits="BESTPATH._TotalSpiritualGifts" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Total Spiritual Gifts</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <span class="instructions2">Please total all of your Identifying Your Spiritual Gifts forms that you distributed to at least <u>four</u> others who know you very well, which hopefully have now been returned to you (otherwise, again, you will need to contact these friends and family members, because you will now need these for this webpage), and then when returned, read them, total each spiritual gift below, and then enter those totals in the corresponding textboxes below for each spiritual gift under the total column. If nobody said that you have a particular spiritual gift, then you will need to enter a zero in that gift's textbox. Then click the submit button below.</span>
                <br /><br />
                <table class="table">
                    <tr>
                        <td class="auto-style1"><b><u>Total:</u></b></td>
                        <td class="auto-style2"><b><u>Service gifts:</u></b></td>
                        <td><b><u>Description:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Mercy</b></td>
                        <td>Spiritual ability to show sympathy to people in need – Sending meals to the sick, visiting those in the hospital, calling those who are hurting, praying with others, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox2" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Service</b></td>
                        <td>Spiritual ability to joyfully serve behind the scenes – Setting up chairs, ushering, assisting leaders, cleaning up, doing whatever is necessary and helpful, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox3" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Hospitality</b></td>
                        <td>Spiritual desire and ability to offer home, food, and/or lodging – Welcoming new friends or strangers into home, offering food or lodging, hosting gatherings for missionaries, Bible studies, singles, or widows, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox4" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Giving</b></td>
                        <td>Spiritual desire and ability to give above and beyond the tithe – Providing for youth missions, deacon funds, gifts for the pastor, gifts for the homeless, special offerings, faith promises, supporting para-church ministries, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox5" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Administration</b></td>
                        <td>Spiritual ability to orchestrate program details – Committee work, volunteering for church office, conference supervisions, event management, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox6" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Leadership</b></td>
                        <td>Spiritual ability to preside or govern wisely – Serving on boards of Christian ministries, running programs, raising funds, etc. Visible roles: elders, deacons, trustees, committee chairpersons, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox7" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Faith</b></td>
                        <td>Spiritual vision for new projects that need doing and perseverance to see them through – Building programs, new ministries, and/or businesses, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox8" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Discernment</b></td>
                        <td>Spiritual ability to detect Biblical error – Detecting errors in Biblical interpretations, meeting with teachers who may be teaching incorrectly, writing letters to the editor, gently rebuking or correcting false doctrines, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator8" runat="server" ControlToValidate="TextBox8" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox21" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Intercession (praying for others)</b></td>
                        <td>Special ability to be persistent and consistent in praying for others, seeking the mind of God about the person or issue, and persisting in praying for God’s will as specific and timely answers are received to a degree beyond that expected by the average Christian – Prayer warriors, prayer ministry leaders, intercessors, those who readily support others in prayer, intentionally interacting with others in prayer, prayer chain members, maintaining prayer lists and journals, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="TextBox21" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator21" runat="server" ControlToValidate="TextBox21" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Total:</u></b></td>
                        <td class="auto-style2"><b><u>Speaking gifts:</u></b></td>
                        <td><b><u>Description:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox9" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Knowledge</b></td>
                        <td>Spiritual ability to search for and acquire Scriptural Truths – Academic pursuits, teaching, writing, diligently studying and reading the Word, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox9" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator9" runat="server" ControlToValidate="TextBox9" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" style="font-size: large">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox10" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Wisdom</b></td>
                        <td>Spiritual insight into applications of knowledge – Providing wise counsel, teaching, discussion group leaders, accountability groups, close friendships, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox10" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator10" runat="server" ControlToValidate="TextBox10" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox11" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Preaching</b></td>
                        <td class="auto-style68">Spiritual ability to rightly proclaim and expound God's Truth – Preaching, lay preaching, evangelizing, motivating others to embrace Christ-like changes leading to others’ involvement and commitment, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBox11" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator11" runat="server" ControlToValidate="TextBox11" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox12" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Teaching</b></td>
                        <td>Spiritual ability to explain Scripture in edifying ways – Sunday school teachers, Bible study leaders, facilitating home groups, children’s groups, youth programs, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox12" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator12" runat="server" ControlToValidate="TextBox12" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox13" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Evangelism</b></td>
                        <td>Spiritual ability to clearly present the Gospel to nonbelievers – After-service programs, workplace witnessing, sponsoring outreach events, inviting others to church and evangelistic gatherings, giving out books and other materials that clearly present the Gospel, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="TextBox13" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator13" runat="server" ControlToValidate="TextBox13" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox14" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Apostleship</b></td>
                        <td>Spiritual ability to begin new works – Church planters, missionaries, Christian service organizations, international missions groups, witnessing trips, fearlessly going out into the world to proclaim the Gospel to nonbelievers, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="TextBox14" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator14" runat="server" ControlToValidate="TextBox14" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox15" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Shepherding</b></td>
                        <td>Spiritual ability to care for a flock of believers over the long haul – Pastors, lay leaders, elders, nursery workers, special needs workers, senior care workers, prison ministries, intervention counselors, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="TextBox15" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator15" runat="server" ControlToValidate="TextBox15" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox16" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Encouragement</b></td>
                        <td>Spiritual ability to inspire, encourage, and comfort – Being a trusted friend, keeping confidences, sincerely listening, counseling others, writing letters, helping others pray, sending thoughtful notes, making phone calls, etc.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="TextBox16" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator16" runat="server" ControlToValidate="TextBox16" ErrorMessage="CompareValidator" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><b><u>Total:</u></b></td>
                        <td class="auto-style2"><b><u>Signifying gifts:</u></b></td>
                        <td><b><u>Description:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox17" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Tongues</b></td>
                        <td>Spiritual ability to speak in a known language that is foreign to the speaker – Speaking in a language foreign to the speaker and delivering an immediate message from God.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="TextBox17" ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator17" runat="server" ControlToValidate="TextBox17" ErrorMessage="CompareValidator" Font-Bold="True" Font-Underline="False" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox18" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Interpretation of tongues</b></td>
                        <td>Spiritual ability to interpret the message of one speaking in tongues.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="TextBox18" ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator18" runat="server" ControlToValidate="TextBox18" ErrorMessage="CompareValidator" Font-Bold="True" Font-Underline="False" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox19" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Miracles</b></td>
                        <td>Spiritual ability to actuate the supernatural intervention of God in ways beyond His ordinary workings through the laws of nature – Being used by God to perform miracles outside of the laws of nature.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="TextBox19" ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" style="font-size: large">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator19" runat="server" ControlToValidate="TextBox19" ErrorMessage="CompareValidator" Font-Bold="True" Font-Underline="False" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" style="font-size: large" Type="Integer">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1"><asp:TextBox ID="TextBox20" runat="server" AutoCompleteType="Disabled" Width="100%" MaxLength="3" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
                        <td class="auto-style2"><b>Healing</b></td>
                        <td>Spiritual agency of God in curing illnesses and diseases, and restoring others to health supernaturally – The laying on of hands and anointing others to perform miracles, perhaps performed on others who may be praying and confessing their sins.</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="TextBox20" ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" CssClass="auto-style20">Required</asp:RequiredFieldValidator>
                            <br />
                            <asp:CompareValidator ID="CompareValidator20" runat="server" ControlToValidate="TextBox20" ErrorMessage="CompareValidator" Font-Bold="True" Font-Underline="False" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer" CssClass="auto-style20">Input must be an integer</asp:CompareValidator>
                        </td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnContinue" runat="server" OnClick="btnContinue_Click" Text="Continue" Visible="False" />
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                </div>
                <br /><br />
                <asp:Label ID="lblError" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <span class="instructions2">Now, considering the total number of people whom have indicated that you have the following spiritual gifts (including your own selections), please select your top <u>three</u> spiritual gifts that you believe the Holy Spirit has most clearly manifested in you.</span>
                <br /><br />
                <table class="table">
                    <tr>
                        <td class="auto-style4"><b><u>Total:</u></b></td>
                        <td class="auto-style2"><b><u>Service gifts:</u></b></td>
                        <td><b><u>Description:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label1" runat="server" style="font-size: large">Label</asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox1" runat="server" Text="Mercy" AutoPostBack="True" Font-Bold="False" OnCheckedChanged="CheckBox1_CheckedChanged" /></td>
                        <td><asp:Label ID="Label27" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to show sympathy to people in need – Sending meals to the sick, visiting those in the hospital, calling those who are hurting, praying with others, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label2" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox2" runat="server" Text="Service" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" /></td>
                        <td><asp:Label ID="Label28" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to joyfully serve behind the scenes – Setting up chairs, ushering, assisting leaders, cleaning up, doing whatever is necessary and helpful, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label3" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox3" runat="server" Text="Hospitality" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" /></td>
                        <td><asp:Label ID="Label29" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual desire and ability to offer home, food, and/or lodging – Welcoming new friends or strangers into home, offering food or lodging, hosting gatherings for missionaries, Bible studies, singles, or widows, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label4" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox4" runat="server" Text="Giving" AutoPostBack="True" OnCheckedChanged="CheckBox4_CheckedChanged" /></td>
                        <td><asp:Label ID="Label30" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual desire and ability to give above and beyond the tithe – Providing for youth missions, deacon funds, gifts for the pastor, gifts for the homeless, special offerings, faith promises, supporting para-church ministries, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label5" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox5" runat="server" Text="Administration" AutoPostBack="True" OnCheckedChanged="CheckBox5_CheckedChanged" /></td>
                        <td><asp:Label ID="Label31" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to orchestrate program details – Committee work, volunteering for church office, conference supervisions, event management, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label6" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox6" runat="server" Text="Leadership" AutoPostBack="True" OnCheckedChanged="CheckBox6_CheckedChanged" /></td>
                        <td><asp:Label ID="Label32" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to preside or govern wisely – Serving on boards of Christian ministries, running programs, raising funds, etc. Visible roles: elders, deacons, trustees, committee chairpersons, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label7" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox7" runat="server" Text="Faith" AutoPostBack="True" OnCheckedChanged="CheckBox7_CheckedChanged" /></td>
                        <td><asp:Label ID="Label33" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual vision for new projects that need doing and perseverance to see them through – Building programs, new ministries, and/or businesses, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label8" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox8" runat="server" Text="Discernment" AutoPostBack="True" OnCheckedChanged="CheckBox8_CheckedChanged" /></td>
                        <td><asp:Label ID="Label34" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to detect Biblical error – Detecting errors in Biblical interpretations, meeting with teachers who may be teaching incorrectly, writing letters to the editor, gently rebuking or correcting false doctrines, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label49" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox21" runat="server" Text="Intercession (praying for others)" AutoPostBack="True" OnCheckedChanged="CheckBox8_CheckedChanged" /></td>
                        <td><asp:Label ID="Label50" runat="server" Font-Bold="False" style="font-size: large" Text="Special ability to be persistent and consistent in praying for others, seeking the mind of God about the person or issue, and persisting in praying for God’s will as specific and timely answers are received to a degree beyond that expected by the average Christian – Prayer warriors, prayer ministry leaders, intercessors, those who readily support others in prayer, intentionally interacting with others in prayer, prayer chain members, maintaining prayer lists and journals, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><b><u>Total:</u></b></td>
                        <td class="auto-style2"><b><u>Speaking gifts:</u></b></td>
                        <td><b><u>Description:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label9" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox9" runat="server" Text="Knowledge" AutoPostBack="True" OnCheckedChanged="CheckBox9_CheckedChanged" /></td>
                        <td><asp:Label ID="Label35" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to search for and acquire Scriptural Truths – Academic pursuits, teaching, writing, diligently studying and reading the Word, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label10" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox10" runat="server" Text="Wisdom" AutoPostBack="True" OnCheckedChanged="CheckBox10_CheckedChanged" /></td>
                        <td><asp:Label ID="Label36" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual insight into applications of knowledge – Providing wise counsel, teaching, discussion group leaders, accountability groups, close friendships, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label11" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox11" runat="server" Text="Preaching" AutoPostBack="True" OnCheckedChanged="CheckBox11_CheckedChanged" /></td>
                        <td><asp:Label ID="Label37" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to rightly proclaim and expound God's Truth – Preaching, lay preaching, evangelizing, motivating others to embrace Christ-like changes leading to others’ involvement and commitment, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label12" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox12" runat="server" Text="Teaching" AutoPostBack="True" OnCheckedChanged="CheckBox12_CheckedChanged" /></td>
                        <td><asp:Label ID="Label38" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to explain Scripture in edifying ways – Sunday school teachers, Bible study leaders, facilitating home groups, children’s groups, youth programs, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label13" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox13" runat="server" Text="Evangelism" AutoPostBack="True" OnCheckedChanged="CheckBox13_CheckedChanged" /></td>
                        <td><asp:Label ID="Label39" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to clearly present the Gospel to nonbelievers – After-service programs, workplace witnessing, sponsoring outreach events, inviting others to church and evangelistic gatherings, giving out books and other materials that clearly present the Gospel, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label14" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox14" runat="server" Text="Apostleship" AutoPostBack="True" OnCheckedChanged="CheckBox14_CheckedChanged" /></td>
                        <td><asp:Label ID="Label40" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to begin new works – Church planters, missionaries, Christian service organizations, international missions groups, witnessing trips, fearlessly going out into the world to proclaim the Gospel to nonbelievers, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label15" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox15" runat="server" Text="Shepherding" AutoPostBack="True" OnCheckedChanged="CheckBox15_CheckedChanged" /></td>
                        <td><asp:Label ID="Label41" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to care for a flock of believers over the long haul – Pastors, lay leaders, elders, nursery workers, special needs workers, senior care workers, prison ministries, intervention counselors, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label16" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox16" runat="server" Text="Encouragement" AutoPostBack="True" OnCheckedChanged="CheckBox16_CheckedChanged" /></td>
                        <td><asp:Label ID="Label42" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to inspire, encourage, and comfort – Being a trusted friend, keeping confidences, sincerely listening, counseling others, writing letters, helping others pray, sending thoughtful notes, making phone calls, etc."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><b><u>Total:</u></b></td>
                        <td class="auto-style2"><b><u>Signifying gifts:</u></b></td>
                        <td><b><u>Description:</u></b></td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label17" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox17" runat="server" Text="Tongues" AutoPostBack="True" OnCheckedChanged="CheckBox17_CheckedChanged" /></td>
                        <td><asp:Label ID="Label43" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to speak in a known language that is foreign to the speaker – Speaking in a language foreign to the speaker and delivering an immediate message from God."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label18" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox18" runat="server" Text="Interpretation of tongues" AutoPostBack="True" OnCheckedChanged="CheckBox18_CheckedChanged" /></td>
                        <td><asp:Label ID="Label44" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to interpret the message of one speaking in tongues."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label19" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox19" runat="server" Text="Miracles" AutoPostBack="True" OnCheckedChanged="CheckBox19_CheckedChanged" /></td>
                        <td><asp:Label ID="Label45" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual ability to actuate the supernatural intervention of God in ways beyond His ordinary workings through the laws of nature – Being used by God to perform miracles outside of the laws of nature."></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"><asp:Label ID="Label20" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                        <td class="auto-style2"><asp:CheckBox ID="CheckBox20" runat="server" Text="Healing" AutoPostBack="True" OnCheckedChanged="CheckBox20_CheckedChanged" /></td>
                        <td><asp:Label ID="Label46" runat="server" Font-Bold="False" style="font-size: large" Text="Spiritual agency of God in curing illnesses and diseases, and restoring others to health supernaturally – The laying on of hands and anointing others to perform miracles, perhaps performed on others who may be praying and confessing their sins."></asp:Label></td>
                    </tr>
                </table>
                <br /><br />
                <table class="table">
                    <tr>
                        <td class="instructions" colspan="2">Finally, how do these spiritual gifts that you have selected manifest most clearly in your life?</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><asp:Label ID="Label47" runat="server" Text="Spiritual gift:" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="Black"></asp:Label></td>
                        <td><asp:Label ID="Label48" runat="server" style="font-size: large" Text="Description:" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="Black"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b>1.</b>&nbsp;<asp:Label ID="Label21" runat="server" CssClass="auto-style20" Text="Label" Visible="False"></asp:Label></td>
                        <td><asp:Label ID="Label24" runat="server" style="font-size: large" Text="Label" Visible="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style6"></td>
                        <td class="auto-style7"><textarea id="TextBox50" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="TextBox50" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b>2.</b>&nbsp;<asp:Label ID="Label22" runat="server" CssClass="auto-style20" Text="Label" Visible="False"></asp:Label></td>
                        <td><asp:Label ID="Label25" runat="server" style="font-size: large" Text="Label" Visible="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style8"></td>
                        <td class="auto-style9"><textarea id="TextBox51" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="TextBox51" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><b>3.</b>&nbsp;<asp:Label ID="Label23" runat="server" CssClass="auto-style20" Text="Label" Visible="False"></asp:Label></td>
                        <td><asp:Label ID="Label26" runat="server" style="font-size: large" Text="Label" Visible="False"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style10"></td>
                        <td class="auto-style11"><textarea id="TextBox52" runat="server" maxlength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="TextBox52" ErrorMessage="Required" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnContinue2" runat="server" PostBackUrl="~/PL/FOP/FOP_ProgressMenu.aspx" Text="Continue" Visible="False" />
                    <asp:Button ID="btnSubmit2" runat="server" OnClick="btnSubmit2_Click" Text="Submit" />
                </div>
                <br /><br />
                <asp:Label ID="lblError2" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
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
            width: 20%
        }
        .auto-style2 {
            width: 25%;
        }
        .auto-style4 {
            width: 15%;
        }
        .auto-style5 {
            width: 30%;
        }
        textarea {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 75%;
            height: 100%
        }
        .auto-style6 {
            width: 30%;
            height: 156px;
        }
        .auto-style7 {
            height: 156px;
        }
        .auto-style8 {
            width: 30%;
            height: 151px;
        }
        .auto-style9 {
            height: 151px;
        }
        .auto-style10 {
            width: 30%;
            height: 155px;
        }
        .auto-style11 {
            height: 155px;
        }
    </style>
</asp:Content>

