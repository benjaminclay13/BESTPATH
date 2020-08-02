<%@ Page Title="Needs Assessments" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="NeedsAssessments.aspx.cs" Inherits="BESTPATH._NeedsAssessments" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Needs Assessments</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <asp:GridView ID="gvNeedsAssessments" runat="server" ShowHeaderWhenEmpty="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" AllowPaging="True" PageSize="25" OnPageIndexChanging="gvNeedsAssessments_PageIndexChanging" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" OnRowUpdated="gvNeedsAssessments_RowUpdated" OnRowUpdating="gvNeedsAssessments_RowUpdating">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="DateCompleted2" HeaderText="Date completed" ReadOnly="True" SortExpression="DateCompleted2" DataFormatString="{0:d}" />
                <asp:BoundField DataField="FirstName" HeaderText="First name" ReadOnly="True" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="Last name" ReadOnly="True" SortExpression="LastName" />
                <asp:BoundField DataField="EmailAddress" HeaderText="Email address" ReadOnly="True" SortExpression="EmailAddress" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Phone number" ReadOnly="True" SortExpression="PhoneNumber" />
                <asp:TemplateField HeaderText="Responded to" SortExpression="RespondedTo">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtRespondedTo" runat="server" Text='<%# Bind("RespondedTo") %>'></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvRespondedTo" runat="server" ErrorMessage="Required" ControlToValidate="txtRespondedTo" Font-Bold="True" Font-Size="Large" ForeColor="Red" SetFocusOnError="True">Required</asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="revRespondedTo" runat="server" ControlToValidate="txtRespondedTo" ErrorMessage="Yes or No Required" ValidationExpression="^(?:Yes|No|Y|N|yes|no|y|n)$" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">Yes or No Required</asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("RespondedTo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Responded date" SortExpression="RespondedDate">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtRespondedDate" runat="server" Text='<%# Bind("RespondedDate", "{0:d}") %>'></asp:TextBox>
                        <br />
                        <asp:CompareValidator ID="cvRespondedDate" runat="server" ControlToValidate="txtRespondedDate" ErrorMessage="Valid Date Required" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" SetFocusOnError="True" Type="Date">Valid Date Required</asp:CompareValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("RespondedDate", "{0:d}") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerSettings Mode="NumericFirstLast" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:sabclay2_BESTPATH %>" DeleteCommand="DELETE FROM [NEEDS_ASSESSMENTS] WHERE [ID] = @original_ID AND [DateCompleted] = @original_DateCompleted AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [EmailAddress] = @original_EmailAddress AND [PhoneNumber] = @original_PhoneNumber AND [Q5] = @original_Q5 AND [Q6] = @original_Q6 AND [Q7] = @original_Q7 AND [Q8] = @original_Q8 AND [Q9] = @original_Q9 AND [Q10] = @original_Q10 AND [Q11] = @original_Q11 AND [Q12] = @original_Q12 AND (([Q13] = @original_Q13) OR ([Q13] IS NULL AND @original_Q13 IS NULL)) AND [Q14] = @original_Q14 AND [Q15] = @original_Q15 AND [Q16] = @original_Q16 AND [Q17] = @original_Q17 AND [Q18] = @original_Q18 AND [Q19] = @original_Q19 AND [Q20] = @original_Q20 AND [Q21] = @original_Q21 AND [Q22] = @original_Q22 AND [Q23] = @original_Q23 AND [Q24] = @original_Q24 AND [Q25] = @original_Q25 AND [Q26] = @original_Q26 AND [Q27] = @original_Q27 AND [Q28] = @original_Q28 AND [Q29] = @original_Q29 AND [Q30] = @original_Q30 AND [Q31] = @original_Q31 AND [Q32] = @original_Q32 AND [Q33] = @original_Q33 AND [Q34] = @original_Q34 AND [Q35] = @original_Q35 AND [Q36] = @original_Q36 AND [Q37] = @original_Q37 AND [Q38] = @original_Q38 AND [Q39] = @original_Q39 AND [Q40] = @original_Q40 AND [Q41] = @original_Q41 AND [Q42] = @original_Q42 AND [Q43] = @original_Q43 AND [Q44] = @original_Q44 AND [Q45] = @original_Q45 AND [Q46] = @original_Q46 AND [DateCompleted2] = @original_DateCompleted2 AND [Q2_1] = @original_Q2_1 AND [Q2_2] = @original_Q2_2 AND [Q2_3] = @original_Q2_3 AND [Q2_4] = @original_Q2_4 AND [Q2_5] = @original_Q2_5 AND [Q2_6] = @original_Q2_6 AND [Q2_7] = @original_Q2_7 AND [Q2_8] = @original_Q2_8 AND [Q2_9] = @original_Q2_9 AND [Q2_10] = @original_Q2_10 AND [Q2_11] = @original_Q2_11 AND [Q2_12] = @original_Q2_12 AND [Q2_13] = @original_Q2_13 AND [Q2_14] = @original_Q2_14 AND [Q2_15] = @original_Q2_15 AND [Q2_16] = @original_Q2_16 AND [Q2_17] = @original_Q2_17 AND [Q2_18] = @original_Q2_18 AND [Q2_19] = @original_Q2_19 AND [Q2_20] = @original_Q2_20 AND [Score] = @original_Score AND [RespondedTo] = @original_RespondedTo AND (([RespondedDate] = @original_RespondedDate) OR ([RespondedDate] IS NULL AND @original_RespondedDate IS NULL))" InsertCommand="INSERT INTO [NEEDS_ASSESSMENTS] ([DateCompleted], [FirstName], [LastName], [EmailAddress], [PhoneNumber], [Q5], [Q6], [Q7], [Q8], [Q9], [Q10], [Q11], [Q12], [Q13], [Q14], [Q15], [Q16], [Q17], [Q18], [Q19], [Q20], [Q21], [Q22], [Q23], [Q24], [Q25], [Q26], [Q27], [Q28], [Q29], [Q30], [Q31], [Q32], [Q33], [Q34], [Q35], [Q36], [Q37], [Q38], [Q39], [Q40], [Q41], [Q42], [Q43], [Q44], [Q45], [Q46], [DateCompleted2], [Q2_1], [Q2_2], [Q2_3], [Q2_4], [Q2_5], [Q2_6], [Q2_7], [Q2_8], [Q2_9], [Q2_10], [Q2_11], [Q2_12], [Q2_13], [Q2_14], [Q2_15], [Q2_16], [Q2_17], [Q2_18], [Q2_19], [Q2_20], [Score], [RespondedTo], [RespondedDate]) VALUES (@DateCompleted, @FirstName, @LastName, @EmailAddress, @PhoneNumber, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13, @Q14, @Q15, @Q16, @Q17, @Q18, @Q19, @Q20, @Q21, @Q22, @Q23, @Q24, @Q25, @Q26, @Q27, @Q28, @Q29, @Q30, @Q31, @Q32, @Q33, @Q34, @Q35, @Q36, @Q37, @Q38, @Q39, @Q40, @Q41, @Q42, @Q43, @Q44, @Q45, @Q46, @DateCompleted2, @Q2_1, @Q2_2, @Q2_3, @Q2_4, @Q2_5, @Q2_6, @Q2_7, @Q2_8, @Q2_9, @Q2_10, @Q2_11, @Q2_12, @Q2_13, @Q2_14, @Q2_15, @Q2_16, @Q2_17, @Q2_18, @Q2_19, @Q2_20, @Score, @RespondedTo, @RespondedDate)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [NEEDS_ASSESSMENTS] ORDER BY DateCompleted2 DESC" UpdateCommand="UPDATE [NEEDS_ASSESSMENTS] SET [RespondedTo] = @RespondedTo, [RespondedDate] = @RespondedDate WHERE [ID] = @original_ID">
            <DeleteParameters>
                <asp:Parameter Name="original_ID" Type="Int32" />
                <asp:Parameter Name="original_DateCompleted" Type="DateTime" />
                <asp:Parameter Name="original_FirstName" Type="String" />
                <asp:Parameter Name="original_LastName" Type="String" />
                <asp:Parameter Name="original_EmailAddress" Type="String" />
                <asp:Parameter Name="original_PhoneNumber" Type="String" />
                <asp:Parameter Name="original_Q5" Type="String" />
                <asp:Parameter Name="original_Q6" Type="String" />
                <asp:Parameter Name="original_Q7" Type="String" />
                <asp:Parameter Name="original_Q8" Type="String" />
                <asp:Parameter Name="original_Q9" Type="String" />
                <asp:Parameter Name="original_Q10" Type="String" />
                <asp:Parameter Name="original_Q11" Type="String" />
                <asp:Parameter Name="original_Q12" Type="String" />
                <asp:Parameter Name="original_Q13" Type="String" />
                <asp:Parameter Name="original_Q14" Type="String" />
                <asp:Parameter Name="original_Q15" Type="String" />
                <asp:Parameter Name="original_Q16" Type="String" />
                <asp:Parameter Name="original_Q17" Type="String" />
                <asp:Parameter Name="original_Q18" Type="String" />
                <asp:Parameter Name="original_Q19" Type="String" />
                <asp:Parameter Name="original_Q20" Type="String" />
                <asp:Parameter Name="original_Q21" Type="String" />
                <asp:Parameter Name="original_Q22" Type="String" />
                <asp:Parameter Name="original_Q23" Type="String" />
                <asp:Parameter Name="original_Q24" Type="String" />
                <asp:Parameter Name="original_Q25" Type="String" />
                <asp:Parameter Name="original_Q26" Type="String" />
                <asp:Parameter Name="original_Q27" Type="String" />
                <asp:Parameter Name="original_Q28" Type="String" />
                <asp:Parameter Name="original_Q29" Type="String" />
                <asp:Parameter Name="original_Q30" Type="String" />
                <asp:Parameter Name="original_Q31" Type="String" />
                <asp:Parameter Name="original_Q32" Type="String" />
                <asp:Parameter Name="original_Q33" Type="String" />
                <asp:Parameter Name="original_Q34" Type="String" />
                <asp:Parameter Name="original_Q35" Type="String" />
                <asp:Parameter Name="original_Q36" Type="String" />
                <asp:Parameter Name="original_Q37" Type="String" />
                <asp:Parameter Name="original_Q38" Type="String" />
                <asp:Parameter Name="original_Q39" Type="String" />
                <asp:Parameter Name="original_Q40" Type="String" />
                <asp:Parameter Name="original_Q41" Type="String" />
                <asp:Parameter Name="original_Q42" Type="String" />
                <asp:Parameter Name="original_Q43" Type="String" />
                <asp:Parameter Name="original_Q44" Type="String" />
                <asp:Parameter Name="original_Q45" Type="String" />
                <asp:Parameter Name="original_Q46" Type="String" />
                <asp:Parameter Name="original_DateCompleted2" Type="DateTime" />
                <asp:Parameter Name="original_Q2_1" Type="Int32" />
                <asp:Parameter Name="original_Q2_2" Type="Int32" />
                <asp:Parameter Name="original_Q2_3" Type="Int32" />
                <asp:Parameter Name="original_Q2_4" Type="Int32" />
                <asp:Parameter Name="original_Q2_5" Type="Int32" />
                <asp:Parameter Name="original_Q2_6" Type="Int32" />
                <asp:Parameter Name="original_Q2_7" Type="Int32" />
                <asp:Parameter Name="original_Q2_8" Type="Int32" />
                <asp:Parameter Name="original_Q2_9" Type="Int32" />
                <asp:Parameter Name="original_Q2_10" Type="Int32" />
                <asp:Parameter Name="original_Q2_11" Type="Int32" />
                <asp:Parameter Name="original_Q2_12" Type="Int32" />
                <asp:Parameter Name="original_Q2_13" Type="Int32" />
                <asp:Parameter Name="original_Q2_14" Type="Int32" />
                <asp:Parameter Name="original_Q2_15" Type="Int32" />
                <asp:Parameter Name="original_Q2_16" Type="Int32" />
                <asp:Parameter Name="original_Q2_17" Type="Int32" />
                <asp:Parameter Name="original_Q2_18" Type="Int32" />
                <asp:Parameter Name="original_Q2_19" Type="Int32" />
                <asp:Parameter Name="original_Q2_20" Type="Int32" />
                <asp:Parameter Name="original_Score" Type="Int32" />
                <asp:Parameter Name="original_RespondedTo" Type="String" />
                <asp:Parameter Name="original_RespondedDate" Type="DateTime" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="DateCompleted" Type="DateTime" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="EmailAddress" Type="String" />
                <asp:Parameter Name="PhoneNumber" Type="String" />
                <asp:Parameter Name="Q5" Type="String" />
                <asp:Parameter Name="Q6" Type="String" />
                <asp:Parameter Name="Q7" Type="String" />
                <asp:Parameter Name="Q8" Type="String" />
                <asp:Parameter Name="Q9" Type="String" />
                <asp:Parameter Name="Q10" Type="String" />
                <asp:Parameter Name="Q11" Type="String" />
                <asp:Parameter Name="Q12" Type="String" />
                <asp:Parameter Name="Q13" Type="String" />
                <asp:Parameter Name="Q14" Type="String" />
                <asp:Parameter Name="Q15" Type="String" />
                <asp:Parameter Name="Q16" Type="String" />
                <asp:Parameter Name="Q17" Type="String" />
                <asp:Parameter Name="Q18" Type="String" />
                <asp:Parameter Name="Q19" Type="String" />
                <asp:Parameter Name="Q20" Type="String" />
                <asp:Parameter Name="Q21" Type="String" />
                <asp:Parameter Name="Q22" Type="String" />
                <asp:Parameter Name="Q23" Type="String" />
                <asp:Parameter Name="Q24" Type="String" />
                <asp:Parameter Name="Q25" Type="String" />
                <asp:Parameter Name="Q26" Type="String" />
                <asp:Parameter Name="Q27" Type="String" />
                <asp:Parameter Name="Q28" Type="String" />
                <asp:Parameter Name="Q29" Type="String" />
                <asp:Parameter Name="Q30" Type="String" />
                <asp:Parameter Name="Q31" Type="String" />
                <asp:Parameter Name="Q32" Type="String" />
                <asp:Parameter Name="Q33" Type="String" />
                <asp:Parameter Name="Q34" Type="String" />
                <asp:Parameter Name="Q35" Type="String" />
                <asp:Parameter Name="Q36" Type="String" />
                <asp:Parameter Name="Q37" Type="String" />
                <asp:Parameter Name="Q38" Type="String" />
                <asp:Parameter Name="Q39" Type="String" />
                <asp:Parameter Name="Q40" Type="String" />
                <asp:Parameter Name="Q41" Type="String" />
                <asp:Parameter Name="Q42" Type="String" />
                <asp:Parameter Name="Q43" Type="String" />
                <asp:Parameter Name="Q44" Type="String" />
                <asp:Parameter Name="Q45" Type="String" />
                <asp:Parameter Name="Q46" Type="String" />
                <asp:Parameter Name="DateCompleted2" Type="DateTime" />
                <asp:Parameter Name="Q2_1" Type="Int32" />
                <asp:Parameter Name="Q2_2" Type="Int32" />
                <asp:Parameter Name="Q2_3" Type="Int32" />
                <asp:Parameter Name="Q2_4" Type="Int32" />
                <asp:Parameter Name="Q2_5" Type="Int32" />
                <asp:Parameter Name="Q2_6" Type="Int32" />
                <asp:Parameter Name="Q2_7" Type="Int32" />
                <asp:Parameter Name="Q2_8" Type="Int32" />
                <asp:Parameter Name="Q2_9" Type="Int32" />
                <asp:Parameter Name="Q2_10" Type="Int32" />
                <asp:Parameter Name="Q2_11" Type="Int32" />
                <asp:Parameter Name="Q2_12" Type="Int32" />
                <asp:Parameter Name="Q2_13" Type="Int32" />
                <asp:Parameter Name="Q2_14" Type="Int32" />
                <asp:Parameter Name="Q2_15" Type="Int32" />
                <asp:Parameter Name="Q2_16" Type="Int32" />
                <asp:Parameter Name="Q2_17" Type="Int32" />
                <asp:Parameter Name="Q2_18" Type="Int32" />
                <asp:Parameter Name="Q2_19" Type="Int32" />
                <asp:Parameter Name="Q2_20" Type="Int32" />
                <asp:Parameter Name="Score" Type="Int32" />
                <asp:Parameter Name="RespondedTo" Type="String" />
                <asp:Parameter Name="RespondedDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="RespondedTo" Type="String" />
                <asp:Parameter Name="RespondedDate" Type="DateTime" />
                <asp:Parameter Name="original_ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br /><br /><br />
        <br /><br /><br />
        <div class="float-right">
            <asp:Button ID="btnContinue" runat="server" CausesValidation="False" PostBackUrl="~/PL/Admin/AdminMenu.aspx" Text="Continue" CssClass="float-right" />
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
    </style>
</asp:Content>

