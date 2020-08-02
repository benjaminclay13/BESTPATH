<%@ Page Title="Personal Management Style" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="PersonalManagementStyle.aspx.cs" Inherits="BESTPATH._PersonalManagementStyle" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Personal Management Style</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <span class="instructions">In order to determine your Personal Management Style, please select your preferences for each question pair below then click the submit button.</span>
                <br /><br />
                <table class="table">
                    <tr>
                        <td><b>1. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet1" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList" ForeColor="Black" >
                                <asp:ListItem>Action and variety</asp:ListItem>
                                <asp:ListItem>Quiet for concentration</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="QuestionSet1" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>2. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet2" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Greeting new people</asp:ListItem>
                                <asp:ListItem>Close contact with only a few people</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="QuestionSet2" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>3. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet3" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Getting tasks done quickly and moving on</asp:ListItem>
                                <asp:ListItem>Working on one thing at length without interruption</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="QuestionSet3" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>4. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet4" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Finding out how others do their jobs</asp:ListItem>
                                <asp:ListItem>Finding out about the idea behind a job</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="QuestionSet4" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>5. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet5" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Talking on the phone</asp:ListItem>
                                <asp:ListItem>Not having telephone interruptions and unplanned visits</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="QuestionSet5" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>6. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet6" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Acting quickly and decisively</asp:ListItem>
                                <asp:ListItem>Thinking before action, sometimes not acting at all as a result</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="QuestionSet6" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>7. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet7" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Interacting with others at work</asp:ListItem>
                                <asp:ListItem>Working alone</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="QuestionSet7" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>8. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet8" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Communicating by talking rather than writing</asp:ListItem>
                                <asp:ListItem>Communications in writing</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="QuestionSet8" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>9. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet9" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Learning new tasks by discussing them with others</asp:ListItem>
                                <asp:ListItem>Learning by reading</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="QuestionSet9" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>10. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet10" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Exploring the unique aspects of each event</asp:ListItem>
                                <asp:ListItem>Exploring new challenges and possibilities</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="QuestionSet10" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>11. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet11" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Focusing on what works well now</asp:ListItem>
                                <asp:ListItem>Thinking of how to improve things</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="QuestionSet11" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>12. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet12" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Tried and true ways of doing things</asp:ListItem>
                                <asp:ListItem>Doing things in new ways</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="QuestionSet12" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>13. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet13" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Applying what is learned</asp:ListItem>
                                <asp:ListItem>Learning new skills</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="QuestionSet13" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>14. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet14" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Working towards goals knowing how long they will take</asp:ListItem>
                                <asp:ListItem>Working in bursts of energy with slack periods in between</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="QuestionSet14" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>15. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet15" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Reaching conclusions step by step</asp:ListItem>
                                <asp:ListItem>Arriving at conclusions quickly</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="QuestionSet15" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>16. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet16" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Trusting my senses and the facts</asp:ListItem>
                                <asp:ListItem>Following my inspirations and hunches</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="QuestionSet16" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>17. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet17" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Having a clearly laid out plan to follow</asp:ListItem>
                                <asp:ListItem>Having only a rough outline to get started</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="QuestionSet17" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>18. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet18" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Precise work</asp:ListItem>
                                <asp:ListItem>Great flexibility in my work</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="QuestionSet18" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>19. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet19" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Not overcomplicating a task</asp:ListItem>
                                <asp:ListItem>Not oversimplifying a task</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="QuestionSet19" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>20. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet20" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Accepting current reality as a given to work with</asp:ListItem>
                                <asp:ListItem>Discovering why things are the way they are</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="QuestionSet20" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>21. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet21" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Putting things in logical order</asp:ListItem>
                                <asp:ListItem>Promoting harmony and working to make it happen</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ControlToValidate="QuestionSet21" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>22. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet22" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Responding more to people's ideas than feelings</asp:ListItem>
                                <asp:ListItem>Responding to others' feelings as well as thoughts</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="QuestionSet22" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>23. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet23" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Anticipating or predicting logical outcomes of choices</asp:ListItem>
                                <asp:ListItem>Recognizing the effects of choices on people</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ControlToValidate="QuestionSet23" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>24. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet24" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Being treated fairly</asp:ListItem>
                                <asp:ListItem>Receiving occasional praise</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator24" runat="server" ControlToValidate="QuestionSet24" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>25. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet25" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Being firm and tough minded</asp:ListItem>
                                <asp:ListItem>Being sympathetic</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" ControlToValidate="QuestionSet25" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>26. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet26" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Reprimanding people when necessary</asp:ListItem>
                                <asp:ListItem>Not having to tell people unpleasant things</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" ControlToValidate="QuestionSet26" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>27. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet27" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Telling it how it really is</asp:ListItem>
                                <asp:ListItem>Maintaining harmony as much as possible</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" ControlToValidate="QuestionSet27" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>28. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet28" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Analyzing problems</asp:ListItem>
                                <asp:ListItem>Finding out about the person behind a problem</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" ControlToValidate="QuestionSet28" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>29. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet29" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Making decisions and then informing others</asp:ListItem>
                                <asp:ListItem>Including others in the decision making process</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ControlToValidate="QuestionSet29" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>30. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet30" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Planning my work and following the plan</asp:ListItem>
                                <asp:ListItem>Leaving things open for last minute changes</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ControlToValidate="QuestionSet30" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>31. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet31" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Not leaving things unfinished or open</asp:ListItem>
                                <asp:ListItem>Leaving things open to change</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ControlToValidate="QuestionSet31" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>32. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet32" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Deciding actions very quickly</asp:ListItem>
                                <asp:ListItem>Gathering as much information as possible before making decisions</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" ControlToValidate="QuestionSet32" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>33. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet33" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Finishing projects one at a time</asp:ListItem>
                                <asp:ListItem>Having many projects going at once</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" ControlToValidate="QuestionSet33" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>34. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet34" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Being satisfied once I reach a conclusion</asp:ListItem>
                                <asp:ListItem>Postponing unpleasant jobs</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ControlToValidate="QuestionSet34" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>35. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet35" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Getting only essentials to begin a project</asp:ListItem>
                                <asp:ListItem>Knowing everything about a new task</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" ControlToValidate="QuestionSet35" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>36. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet36" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Scheduling projects so that each step gets done in order and on time</asp:ListItem>
                                <asp:ListItem>Getting a lot accomplished at the last minute under pressure of a deadline</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator36" runat="server" ControlToValidate="QuestionSet36" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>37. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet37" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Using lists or agendas to promote action</asp:ListItem>
                                <asp:ListItem>Using lists only as reminders of things to do someday</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator37" runat="server" ControlToValidate="QuestionSet37" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td><b>38. Whether at work or in service, I tend to prefer the following:</b></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="QuestionSet38" runat="server" RepeatDirection="Vertical" TextAlign="Right" CssClass="radioButtonList">
                                <asp:ListItem>Arranging activities well in advance</asp:ListItem>
                                <asp:ListItem>Remaining free to do what seems right at the time</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator38" runat="server" ControlToValidate="QuestionSet38" ErrorMessage="Required" Font-Bold="True" Font-Size="large" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
                        <td></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="float-right" OnClick="btnSubmit_Click" Text="Submit" />
                    <asp:Button ID="Button1" runat="server" CssClass="float-right" OnClick="Button1_Click" Text="Continue" Visible="False" />
                </div>
                <br /><br />
                <asp:Label ID="lblError" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <span class="instructions">Based on your selections, your Personal Management Style has been identified as the following:</span>
                <br /><br />
                <table class="table">
                    <tr>
                        <td colspan="2"><b><u>Focus preference:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblSection1Score" runat="server" Text="Label" Font-Underline="False" Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="Label1" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b>How is this preference true of you:</b></td>
                    </tr>
                    <tr>
                        <td colspan="2" class="auto-style1"><textarea id="TextBox1" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator39" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Information gathering preference:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblSection2Score" runat="server" Text="Label" Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="Label2" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b>How is this preference true of you:</b></td>
                    </tr>
                    <tr>
                        <td colspan="2" class="auto-style2"><textarea id="TextBox2" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator40" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Decision making preference:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblSection3Score" runat="server" Text="Label" Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="Label3" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b>How is this preference true of you:</b></td>
                    </tr>
                    <tr>
                        <td colspan="2" class="auto-style3"><textarea id="TextBox3" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator41" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b><u>Implementation and closure preference:</u></b>&nbsp;&nbsp;&nbsp;<asp:Label ID="lblSection4Score" runat="server" Text="Label" Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:Label ID="Label4" runat="server" style="font-size: large" Text="Label"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2"><b>How is this preference true of you:</b></td>
                    </tr>
                    <tr>
                        <td colspan="2" class="auto-style4"><textarea id="TextBox4" runat="server" maxLength="900" style="font-family:'Arial';color:#000000"></textarea></td>
                    </tr>
                    <tr>
                        <td colspan="2"><asp:RequiredFieldValidator ID="RequiredFieldValidator42" runat="server" ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator></td>
                    </tr>
                </table>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnContinue2" runat="server" CssClass="float-right" OnClick="btnContinue2_Click" Text="Continue" Visible="False" />
                    <asp:Button ID="btnSubmit2" runat="server" OnClick="btnSubmit2_Click" Text="Submit" CssClass="float-right" />
                </div>
                <br /><br />
                <asp:Label ID="lblError2" runat="server" Visible="False" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <span class="instructions">Explanation of all 16 different specific Personal Management Styles:</span>
                <br /><br />
                <p>Please use these personality type preference indicators to guide your focusing and understanding of how you most prefer to work. Now that you have this better understanding of yourself, please use this knowledge to: <br />(1) help to better define your “product,” (2) better describe your personal management style in interviews, and <br />(3) better recognize the exact types of positions and the exact environments where you will be most comfortable and energized for effectiveness in your work. Please be advised of these general cautions: (1) there are no "good" or "bad" personality type preferences, and (2) we have all been uniquely created and gifted by God for His specific life and work purposes. We may have certain tendencies, which we might like to modify, but all members of the body of Christ are precious in His sight. Please use this information to better help you describe the value that you have to offer others in your life and work, as well as how you are most comfortable in doing so. If you are very interested in exploring this subject further, do some research on Myers-Briggs, Social Styles, and DISC.</p>
                <p class="instructions">Distribution in the general population by personality type preference subtypes:</p>                  
                <table class="table">
                    <tr>
                        <td><b>1. Outwardly social (75%)</b></td>
                        <td><b>2. Inwardly reflective (25%)</b></td>
                    </tr>
                    <tr>
                        <td><b>3. Sensory-grounded realism (75%)</b></td>
                        <td><b>4. Big-picture possibilities (25%)</b></td>
                    </tr>
                    <tr>
                        <td><b>5. Rationally logical (50%) 6 out of 10 men</b></td>
                        <td><b>6. Person-centered values (50%) 6 out of 10 women</b></td>
                    </tr>
                    <tr>
                        <td><b>7. Orderly-controlled closure (50%)</b></td>
                        <td><b>8. Openly-spontaneous flexibility (50%)</b></td>
                    </tr>
                </table>
                <p><b><u>Remember:</u></b></p>
                <p>Your personality preferences do not set in stone what you can and cannot do, they only indicate your current personality preferences. Your personality preference subtypes are very important and need to be taken into account with regards to your life and work, but only God knows what you can and cannot ultimately do!</p>
                <p>We recommend that you use this information to record in your own words your own definition of your product’s preferred personal management style in more detail if necessary. Please take what resonates from this inventory of your personality type’s preferences, and use it to emphasize in your interactions with prospective employers the exact positive qualities that you exhibit when you have been working at your best!</p>
                <br /><br /><br />
                <br /><br /><br />
                <div class="right-float">
                    <asp:Button ID="btnContinue" runat="server" PostBackUrl="~/PL/FOP/FOP_ProgressMenu.aspx" Text="Continue" CssClass="float-right" />
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
        .radioButtonList {
            list-style: none;
            margin: 0;
            padding: 0;
        }
        textarea {
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
            width: 75%;
            height: 100%
        }
        .auto-style1 {
            height: 157px;
        }
        .auto-style2 {
            height: 154px;
        }
        .auto-style3 {
            height: 156px;
        }
        .auto-style4 {
            height: 158px;
        }
    </style>
</asp:Content>

