<%@ Page Title="Client Status" Language="C#" MasterPageFile="~/PL/Site.Master" AutoEventWireup="true" CodeBehind="ClientStatus.aspx.cs" Inherits="BESTPATH._ClientStatus" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Client Status</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="container">
    <div class="body">
        <span class="instructions">All clients:</span>
        <asp:GridView ID="gvClientInformation" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" AllowPaging="True" PageSize="25" OnPageIndexChanging="gvClientInformation_PageIndexChanging">
            <AlternatingRowStyle BackColor="#CCCCCC" />
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
        <br />
        <p class="instructions">Get all information on any registered client:</p>
        <table class="table">
            <tr>
                <td class="auto-style2"><b>Username:</b></td>
                <td><asp:TextBox ID="txtUsername" runat="server" Width="65%" Font-Size="Large" Font-Names="Arial" ForeColor="Black"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Required" Font-Bold="True" ForeColor="Red" SetFocusOnError="True" style="font-size: large"></asp:RequiredFieldValidator></td>
            </tr>
            <td colspan="2">&nbsp;</td>
            <tr>
                <td class="auto-style2"><asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" /></td>
                <td></td>
            </tr>
        </table>
        <br />
        <asp:DetailsView ID="dvClientInformation" runat="server" Width="75%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Visible="False">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <FieldHeaderStyle Font-Bold="True" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerSettings PageButtonCount="100" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        </asp:DetailsView>
        <br /><br /><br />
        <br /><br /><br />
        <div class="float-right">
            <asp:Button ID="btnContinue" runat="server" PostBackUrl="~/PL/Admin/AdminMenu.aspx" Text="Continue" CausesValidation="False" />
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
        .auto-style2 {
            width: 25%;
        }
    </style>
</asp:Content>

