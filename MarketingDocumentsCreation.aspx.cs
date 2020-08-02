using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.IO;
using System.Web.Security;
using System.Net;
using System.Data.SqlClient;
using System.Net.Security;
using System.Data;
using System.Collections;
using System.Security.Cryptography;

namespace BESTPATH
{
    public partial class _MarketingDocumentsCreation : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpContext.Current.Response.Cache.SetAllowResponseInBrowserHistory(false);
            //HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //HttpContext.Current.Response.Cache.SetNoStore();
            //Response.Cache.SetExpires(DateTime.Now);
            //Response.Cache.SetValidUntilExpires(true);
            //Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            //Response.Cache.SetNoStore();

            if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
            {
                HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);

                if (ticket.Expiration <= DateTime.Now)
                {
                    Response.Redirect("~/PL/Membership/Login.aspx");

                }//end if

                else
                {
                    Session sessionObject = new Session();
                    FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
                    string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    cookie.Expires = newTicket.Expiration;
                    Response.Cookies.Add(cookie);

                }//end else

            }//end if

            else
            {
                Response.Redirect("~/PL/Membership/Login.aspx");

            }//end else

            HttpCookie _authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket _ticket = FormsAuthentication.Decrypt(_authCookie.Value);

            string username = _ticket.Name;

            if (!Page.IsPostBack)
            {
                MultiView1.SetActiveView(View1);

            }//end if

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Focus_Analysis_Worksheet(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError.Text = errorMessage;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists == true)
                {
                    string errorMessage2;

                    ArrayList record = new ArrayList();

                    Select selectObject2 = new Select();

                    record = Select.Select_Focus_Analysis_Record(username);

                    errorMessage2 = selectObject2.getErrorMessage();

                    if (errorMessage2 != null)
                    {
                        lblError.Text = errorMessage2;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblSkillGroup1.Text = record[188].ToString();
                        lblSkillGroup11.Text = record[188].ToString();

                        lblSkillGroup2.Text = record[189].ToString();
                        lblSkillGroup12.Text = record[189].ToString();

                        lblSkillGroup3.Text = record[190].ToString();
                        lblSkillGroup13.Text = record[190].ToString();

                        lblSkillGroup4.Text = record[191].ToString();
                        lblSkillGroup14.Text = record[191].ToString();

                        lblSkillGroup5.Text = record[192].ToString();
                        lblSkillGroup15.Text = record[192].ToString();

                        lblSkillGroup6.Text = record[193].ToString();
                        lblSkillGroup16.Text = record[193].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists100;

            string errorMessage100;

            Select selectObject100 = new Select();

            recordExists100 = Select.Select_Focus_Demonstration_Worksheet(username);

            errorMessage100 = selectObject100.getErrorMessage();

            if (errorMessage100 != null)
            {
                lblError.Text = errorMessage100;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists100 == true)
                {
                    string errorMessage101;

                    ArrayList record101 = new ArrayList();

                    Select selectObject101 = new Select();

                    record101 = Select.Select_Focus_Demonstration_Worksheet_Record(username);

                    errorMessage101 = selectObject101.getErrorMessage();

                    if (errorMessage101 != null)
                    {
                        lblError.Text = errorMessage101;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience1Title.Text = record101[0].ToString();
                        lblExperience2Title.Text = record101[1].ToString();
                        lblExperience3Title.Text = record101[2].ToString();
                        lblExperience4Title.Text = record101[3].ToString();
                        lblExperience5Title.Text = record101[4].ToString();
                        lblExperience6Title.Text = record101[5].ToString();
                        lblExperience7Title.Text = record101[6].ToString();
                        lblExperience8Title.Text = record101[7].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists102;

            string errorMessage102;

            Select selectObject102 = new Select();

            recordExists102 = Select.Select_Focus_Experience1(username);

            errorMessage102 = selectObject102.getErrorMessage();

            if (errorMessage102 != null)
            {
                lblError.Text = errorMessage102;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists102 == true)
                {
                    string errorMessage103;

                    ArrayList record103 = new ArrayList();

                    Select selectObject103 = new Select();

                    record103 = Select.Select_Focus_Experience1_Record(username);

                    errorMessage103 = selectObject103.getErrorMessage();

                    if (errorMessage103 != null)
                    {
                        lblError.Text = errorMessage103;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience1Q9.Text = record103[8].ToString();
                        lblExperience1Q13.Text = record103[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists104;

            string errorMessage104;

            Select selectObject104 = new Select();

            recordExists104 = Select.Select_Focus_Experience2(username);

            errorMessage104 = selectObject104.getErrorMessage();

            if (errorMessage104 != null)
            {
                lblError.Text = errorMessage104;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists104 == true)
                {
                    string errorMessage105;

                    ArrayList record105 = new ArrayList();

                    Select selectObject105 = new Select();

                    record105 = Select.Select_Focus_Experience2_Record(username);

                    errorMessage105 = selectObject105.getErrorMessage();

                    if (errorMessage105 != null)
                    {
                        lblError.Text = errorMessage105;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience2Q9.Text = record105[8].ToString();
                        lblExperience2Q13.Text = record105[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists106;

            string errorMessage106;

            Select selectObject106 = new Select();

            recordExists106 = Select.Select_Focus_Experience3(username);

            errorMessage106 = selectObject106.getErrorMessage();

            if (errorMessage106 != null)
            {
                lblError.Text = errorMessage106;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists106 == true)
                {
                    string errorMessage107;

                    ArrayList record107 = new ArrayList();

                    Select selectObject107 = new Select();

                    record107 = Select.Select_Focus_Experience3_Record(username);

                    errorMessage107 = selectObject107.getErrorMessage();

                    if (errorMessage107 != null)
                    {
                        lblError.Text = errorMessage107;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience3Q9.Text = record107[8].ToString();
                        lblExperience3Q13.Text = record107[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists108;

            string errorMessage108;

            Select selectObject108 = new Select();

            recordExists108 = Select.Select_Focus_Experience4(username);

            errorMessage108 = selectObject108.getErrorMessage();

            if (errorMessage108 != null)
            {
                lblError.Text = errorMessage108;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists108 == true)
                {
                    string errorMessage109;

                    ArrayList record109 = new ArrayList();

                    Select selectObject109 = new Select();

                    record109 = Select.Select_Focus_Experience4_Record(username);

                    errorMessage109 = selectObject109.getErrorMessage();

                    if (errorMessage109 != null)
                    {
                        lblError.Text = errorMessage109;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience4Q9.Text = record109[8].ToString();
                        lblExperience4Q13.Text = record109[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists110;

            string errorMessage110;

            Select selectObject110 = new Select();

            recordExists110 = Select.Select_Focus_Experience5(username);

            errorMessage110 = selectObject110.getErrorMessage();

            if (errorMessage110 != null)
            {
                lblError.Text = errorMessage110;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists110 == true)
                {
                    string errorMessage111;

                    ArrayList record111 = new ArrayList();

                    Select selectObject111 = new Select();

                    record111 = Select.Select_Focus_Experience5_Record(username);

                    errorMessage111 = selectObject111.getErrorMessage();

                    if (errorMessage111 != null)
                    {
                        lblError.Text = errorMessage111;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience5Q9.Text = record111[8].ToString();
                        lblExperience5Q13.Text = record111[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists112;

            string errorMessage112;

            Select selectObject112 = new Select();

            recordExists112 = Select.Select_Focus_Experience6(username);

            errorMessage112 = selectObject112.getErrorMessage();

            if (errorMessage112 != null)
            {
                lblError.Text = errorMessage112;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists112 == true)
                {
                    string errorMessage113;

                    ArrayList record113 = new ArrayList();

                    Select selectObject113 = new Select();

                    record113 = Select.Select_Focus_Experience6_Record(username);

                    errorMessage113 = selectObject113.getErrorMessage();

                    if (errorMessage113 != null)
                    {
                        lblError.Text = errorMessage113;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience6Q9.Text = record113[8].ToString();
                        lblExperience6Q13.Text = record113[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists114;

            string errorMessage114;

            Select selectObject114 = new Select();

            recordExists114 = Select.Select_Focus_Experience7(username);

            errorMessage114 = selectObject114.getErrorMessage();

            if (errorMessage114 != null)
            {
                lblError.Text = errorMessage114;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists114 == true)
                {
                    string errorMessage115;

                    ArrayList record115 = new ArrayList();

                    Select selectObject115 = new Select();

                    record115 = Select.Select_Focus_Experience7_Record(username);

                    errorMessage115 = selectObject115.getErrorMessage();

                    if (errorMessage115 != null)
                    {
                        lblError.Text = errorMessage115;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience7Q9.Text = record115[8].ToString();
                        lblExperience7Q13.Text = record115[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists116;

            string errorMessage116;

            Select selectObject116 = new Select();

            recordExists116 = Select.Select_Focus_Experience8(username);

            errorMessage116 = selectObject116.getErrorMessage();

            if (errorMessage116 != null)
            {
                lblError.Text = errorMessage116;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists116 == true)
                {
                    string errorMessage117;

                    ArrayList record117 = new ArrayList();

                    Select selectObject117 = new Select();

                    record117 = Select.Select_Focus_Experience8_Record(username);

                    errorMessage117 = selectObject117.getErrorMessage();

                    if (errorMessage117 != null)
                    {
                        lblError.Text = errorMessage117;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience8Q9.Text = record117[8].ToString();
                        lblExperience8Q13.Text = record117[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists2;

            string errorMessage3;

            Select selectObject3 = new Select();

            recordExists2 = Select.Select_Total_Spiritual_Gifts(username);

            errorMessage3 = selectObject3.getErrorMessage();

            if (errorMessage3 != null)
            {
                lblError.Text = errorMessage3;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists2 == true)
                {
                    string errorMessage4;

                    ArrayList record2 = new ArrayList();

                    Select selectObject4 = new Select();

                    record2 = Select.Select_Total_Spiritual_Gifts_Record(username);

                    errorMessage4 = selectObject4.getErrorMessage();

                    if (errorMessage4 != null)
                    {
                        lblError.Text = errorMessage4;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblSpiritualGift1.Text = record2[21].ToString();
                        lblSpiritualGift1Comments.Text = record2[24].ToString();
                        lblSpiritualGift2.Text = record2[22].ToString();
                        lblSpiritualGift2Comments.Text = record2[25].ToString();
                        lblSpiritualGift3.Text = record2[23].ToString();
                        lblSpiritualGift3Comments.Text = record2[26].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists3;

            string errorMessage5;

            Select selectObject5 = new Select();

            recordExists3 = Select.Select_Personal_Management_Style(username);

            errorMessage5 = selectObject5.getErrorMessage();

            if (errorMessage5 != null)
            {
                lblError.Text = errorMessage5;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists3 == true)
                {
                    string errorMessage6;

                    ArrayList record3 = new ArrayList();

                    Select selectObject6 = new Select();

                    record3 = Select.Select_Personal_Management_Style_Record(username);

                    errorMessage6 = selectObject6.getErrorMessage();

                    if (errorMessage6 != null)
                    {
                        lblError.Text = errorMessage6;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblPersonalManagementStyle1.Text = record3[38].ToString();
                        lblPMS1Comments.Text = record3[40].ToString();
                        lblPersonalManagementStyle2.Text = record3[41].ToString();
                        lblPMS2Comments.Text = record3[43].ToString();
                        lblPersonalManagementStyle3.Text = record3[44].ToString();
                        lblPMS3Comments.Text = record3[46].ToString();
                        lblPersonalManagementStyle4.Text = record3[47].ToString();
                        lblPMS4Comments.Text = record3[49].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists4;

            string errorMessage7;

            Select selectObject7 = new Select();

            recordExists4 = Select.Select_Focus_Demonstration_Worksheet(username);

            errorMessage7 = selectObject7.getErrorMessage();

            if (errorMessage7 != null)
            {
                lblError.Text = errorMessage7;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists4 == true)
                {
                    string errorMessage8;

                    ArrayList record4 = new ArrayList();

                    Select selectObject8 = new Select();

                    record4 = Select.Select_Focus_Demonstration_Worksheet_Record(username);

                    errorMessage8 = selectObject8.getErrorMessage();

                    if (errorMessage8 != null)
                    {
                        lblError.Text = errorMessage8;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience1Title2.Text = record4[0].ToString();
                        lblExperience2Title2.Text = record4[1].ToString();
                        lblExperience3Title2.Text = record4[2].ToString();
                        lblExperience4Title2.Text = record4[3].ToString();
                        lblExperience5Title2.Text = record4[4].ToString();
                        lblExperience6Title2.Text = record4[5].ToString();
                        lblExperience7Title2.Text = record4[6].ToString();
                        lblExperience8Title2.Text = record4[7].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists200;

            string errorMessage200;

            Select selectObject200 = new Select();

            recordExists200 = Select.Select_Focus_Experience1(username);

            errorMessage200 = selectObject200.getErrorMessage();

            if (errorMessage200 != null)
            {
                lblError.Text = errorMessage200;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists200 == true)
                {
                    string errorMessage201;

                    ArrayList record201 = new ArrayList();

                    Select selectObject201 = new Select();

                    record201 = Select.Select_Focus_Experience1_Record(username);

                    errorMessage201 = selectObject201.getErrorMessage();

                    if (errorMessage201 != null)
                    {
                        lblError.Text = errorMessage201;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience1Q12.Text = record201[11].ToString();
                        lblExperience1Q132.Text = record201[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists202;

            string errorMessage202;

            Select selectObject202 = new Select();

            recordExists202 = Select.Select_Focus_Experience2(username);

            errorMessage202 = selectObject202.getErrorMessage();

            if (errorMessage202 != null)
            {
                lblError.Text = errorMessage202;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists202 == true)
                {
                    string errorMessage203;

                    ArrayList record203 = new ArrayList();

                    Select selectObject203 = new Select();

                    record203 = Select.Select_Focus_Experience2_Record(username);

                    errorMessage203 = selectObject203.getErrorMessage();

                    if (errorMessage203 != null)
                    {
                        lblError.Text = errorMessage203;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience2Q12.Text = record203[11].ToString();
                        lblExperience2Q132.Text = record203[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists204;

            string errorMessage204;

            Select selectObject204 = new Select();

            recordExists204 = Select.Select_Focus_Experience3(username);

            errorMessage204 = selectObject204.getErrorMessage();

            if (errorMessage204 != null)
            {
                lblError.Text = errorMessage204;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists204 == true)
                {
                    string errorMessage205;

                    ArrayList record205 = new ArrayList();

                    Select selectObject205 = new Select();

                    record205 = Select.Select_Focus_Experience3_Record(username);

                    errorMessage205 = selectObject205.getErrorMessage();

                    if (errorMessage205 != null)
                    {
                        lblError.Text = errorMessage205;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience3Q12.Text = record205[11].ToString();
                        lblExperience3Q132.Text = record205[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists206;

            string errorMessage206;

            Select selectObject206 = new Select();

            recordExists206 = Select.Select_Focus_Experience4(username);

            errorMessage206 = selectObject206.getErrorMessage();

            if (errorMessage206 != null)
            {
                lblError.Text = errorMessage206;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists206 == true)
                {
                    string errorMessage207;

                    ArrayList record207 = new ArrayList();

                    Select selectObject207 = new Select();

                    record207 = Select.Select_Focus_Experience4_Record(username);

                    errorMessage207 = selectObject207.getErrorMessage();

                    if (errorMessage207 != null)
                    {
                        lblError.Text = errorMessage207;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience4Q12.Text = record207[11].ToString();
                        lblExperience4Q132.Text = record207[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists208;

            string errorMessage208;

            Select selectObject208 = new Select();

            recordExists208 = Select.Select_Focus_Experience5(username);

            errorMessage208 = selectObject208.getErrorMessage();

            if (errorMessage208 != null)
            {
                lblError.Text = errorMessage208;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists208 == true)
                {
                    string errorMessage209;

                    ArrayList record209 = new ArrayList();

                    Select selectObject209 = new Select();

                    record209 = Select.Select_Focus_Experience5_Record(username);

                    errorMessage209 = selectObject209.getErrorMessage();

                    if (errorMessage209 != null)
                    {
                        lblError.Text = errorMessage209;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience5Q12.Text = record209[11].ToString();
                        lblExperience5Q132.Text = record209[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists210;

            string errorMessage210;

            Select selectObject210 = new Select();

            recordExists210 = Select.Select_Focus_Experience6(username);

            errorMessage210 = selectObject210.getErrorMessage();

            if (errorMessage210 != null)
            {
                lblError.Text = errorMessage210;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists210 == true)
                {
                    string errorMessage211;

                    ArrayList record211 = new ArrayList();

                    Select selectObject211 = new Select();

                    record211 = Select.Select_Focus_Experience6_Record(username);

                    errorMessage211 = selectObject211.getErrorMessage();

                    if (errorMessage211 != null)
                    {
                        lblError.Text = errorMessage211;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience6Q12.Text = record211[11].ToString();
                        lblExperience6Q132.Text = record211[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists212;

            string errorMessage212;

            Select selectObject212 = new Select();

            recordExists212 = Select.Select_Focus_Experience7(username);

            errorMessage212 = selectObject212.getErrorMessage();

            if (errorMessage212 != null)
            {
                lblError.Text = errorMessage212;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists212 == true)
                {
                    string errorMessage213;

                    ArrayList record213 = new ArrayList();

                    Select selectObject213 = new Select();

                    record213 = Select.Select_Focus_Experience7_Record(username);

                    errorMessage213 = selectObject213.getErrorMessage();

                    if (errorMessage213 != null)
                    {
                        lblError.Text = errorMessage213;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience7Q12.Text = record213[11].ToString();
                        lblExperience7Q132.Text = record213[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists214;

            string errorMessage214;

            Select selectObject214 = new Select();

            recordExists214 = Select.Select_Focus_Experience8(username);

            errorMessage214 = selectObject214.getErrorMessage();

            if (errorMessage214 != null)
            {
                lblError.Text = errorMessage214;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists214 == true)
                {
                    string errorMessage215;

                    ArrayList record215 = new ArrayList();

                    Select selectObject215 = new Select();

                    record215 = Select.Select_Focus_Experience8_Record(username);

                    errorMessage215 = selectObject215.getErrorMessage();

                    if (errorMessage215 != null)
                    {
                        lblError.Text = errorMessage215;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        lblExperience8Q12.Text = record215[11].ToString();
                        lblExperience8Q132.Text = record215[12].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists5;

            string errorMessage9;

            Select selectObject9 = new Select();

            recordExists5 = Select.Select_Deliverable_Creation(username);

            errorMessage9 = selectObject9.getErrorMessage();

            if (errorMessage9 != null)
            {
                lblError.Text = errorMessage9;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists5 == true)
                {
                    string errorMessage10;

                    ArrayList record5 = new ArrayList();

                    Select selectObject10 = new Select();

                    record5 = Select.Select_Deliverable_Creation_Record(username);

                    errorMessage10 = selectObject10.getErrorMessage();

                    if (errorMessage10 != null)
                    {
                        lblError.Text = errorMessage10;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        if (!Page.IsPostBack)
                        {
                            string nothing = "";

                            if ((record5[0] != nothing) && (record5[1] != nothing) && (record5[2] != nothing) && (record5[3] != nothing) && (record5[4] != nothing) && (record5[5] != nothing) && (record5[6] != nothing))
                            {
                                btnSubmit.Visible = false;
                                btnContinue.Visible = true;

                            }//end if

                            if ((record5[7] != nothing) && (record5[8] != nothing) && (record5[9] != nothing) && (record5[10] != nothing) && (record5[11] != nothing))
                            {
                                btnSubmit2.Visible = false;
                                btnContinue2.Visible = true;

                            }//end if

                            if ((record5[12] != nothing) && (record5[13] != nothing) && (record5[14] != nothing) && (record5[15] != nothing))
                            {
                                btnSubmit3.Visible = false;
                                btnContinue3.Visible = true;

                            }//end if

                            if ((record5[16] != nothing) && (record5[17] != nothing) && (record5[18] != nothing) && (record5[19] != nothing) && (record5[20] != nothing) && (record5[21] != nothing) && (record5[22] != nothing) && (record5[23] != nothing) && (record5[24] != nothing))
                            {
                                btnSubmit4.Visible = false;
                                btnContinue4.Visible = true;

                            }//end if

                            if ((record5[25] != nothing) && (record5[26] != nothing) && (record5[27] != nothing) && (record5[28] != nothing) && (record5[29] != nothing) && (record5[30] != nothing) && (record5[31] != nothing) && (record5[32] != nothing) && (record5[33] != nothing))
                            {
                                btnSubmit5.Visible = false;
                                btnContinue5.Visible = true;

                            }//end if

                            if ((record5[34] != nothing) && (record5[35] != nothing))
                            {
                                btnSubmit6.Visible = false;
                                btnContinue6.Visible = true;

                            }//end if

                            if ((record5[36] != nothing) && (record5[37] != nothing) && (record5[38] != nothing) && (record5[39] != nothing))
                            {
                                btnSubmit7.Visible = false;
                                btnContinue7.Visible = true;

                            }//end if

                            if ((record5[68] != nothing) && (record5[69] != nothing) && (record5[70] != nothing) && (record5[71] != nothing) && (record5[72] != nothing) && (record5[73] != nothing) && (record5[74] != nothing) && (record5[75] != nothing) && (record5[76] != nothing) && (record5[77] != nothing) && (record5[78] != nothing) && (record5[79] != nothing) && (record5[80] != nothing) && (record5[81] != nothing) && (record5[82] != nothing) && (record5[83] != nothing) && (record5[84] != nothing) && (record5[85] != nothing) && (record5[86] != nothing) && (record5[87] != nothing) && (record5[88] != nothing) && (record5[89] != nothing) && (record5[90] != nothing) && (record5[91] != nothing) && (record5[92] != nothing) && (record5[93] != nothing) && (record5[94] != nothing) && (record5[95] != nothing) && (record5[96] != nothing) && (record5[97] != nothing) && (record5[98] != nothing) && (record5[99] != nothing) && (record5[100] != nothing) && (record5[101] != nothing) && (record5[102] != nothing) && (record5[103] != nothing) && (record5[104] != nothing) && (record5[105] != nothing) && (record5[106] != nothing) && (record5[107] != nothing) && (record5[108] != nothing) && (record5[109] != nothing) && (record5[110] != nothing) && (record5[111] != nothing) && (record5[112] != nothing) && (record5[113] != nothing) && (record5[114] != nothing) && (record5[115] != nothing))
                            {
                                btnSubmit9.Visible = false;
                                btnContinue9.Visible = true;

                            }//end if

                            txtFullName.Text = record5[1].ToString();
                            txtDegrees.Text = record5[2].ToString();
                            txtStreetAddress.Text = record5[3].ToString();
                            txtCityStateZip.Text = record5[4].ToString();
                            txtEmail.Text = record5[5].ToString();
                            txtPhone.Text = record5[6].ToString();

                            rblSection1Title.SelectedValue = record5[7].ToString();
                            txtFocus.Text = record5[8].ToString();
                            txtTheme1.InnerText = record5[9].ToString();
                            txtTheme2.InnerText = record5[10].ToString();
                            txtTheme3.InnerText = record5[11].ToString();

                            rblSection2Title.SelectedValue = record5[12].ToString();
                            txtDescriptor1.Text = record5[13].ToString();
                            txtDescriptor2.Text = record5[14].ToString();
                            txtDescriptor3.Text = record5[15].ToString();

                            txtQualification1.Text = record5[16].ToString();
                            txtQualification2.Text = record5[17].ToString();
                            txtQualification3.Text = record5[18].ToString();
                            txtQualification4.Text = record5[19].ToString();
                            txtQualification5.Text = record5[20].ToString();
                            txtQualification6.Text = record5[21].ToString();
                            txtQualification7.Text = record5[22].ToString();
                            txtQualification8.Text = record5[23].ToString();
                            txtQualification9.Text = record5[24].ToString();

                            rblSection3Title.SelectedValue = record5[25].ToString();
                            txtAchievement1.InnerText = record5[26].ToString();
                            txtAchievement2.InnerText = record5[27].ToString();
                            txtAchievement3.InnerText = record5[28].ToString();
                            txtAchievement4.InnerText = record5[29].ToString();
                            txtAchievement5.InnerText = record5[30].ToString();
                            txtAchievement6.InnerText = record5[31].ToString();
                            txtAchievement7.InnerText = record5[32].ToString();
                            txtAchievement8.InnerText = record5[33].ToString();

                            lblAchievement1.Text = record5[26].ToString();
                            lblAchievement2.Text = record5[27].ToString();
                            lblAchievement3.Text = record5[28].ToString();
                            lblAchievement4.Text = record5[29].ToString();
                            lblAchievement5.Text = record5[30].ToString();
                            lblAchievement6.Text = record5[31].ToString();
                            lblAchievement7.Text = record5[32].ToString();
                            lblAchievement8.Text = record5[33].ToString();

                            rblSection4Title.SelectedValue = record5[34].ToString();
                            txtJobTitles.InnerText = record5[35].ToString();

                            txtTitle1.Text = record5[36].ToString();
                            txtCompanyName1.Text = record5[37].ToString();
                            txtYears1.Text = record5[38].ToString();
                            txtNarrative1.InnerText = record5[39].ToString();
                            txtTitle2.Text = record5[40].ToString();
                            txtCompanyName2.Text = record5[41].ToString();
                            txtYears2.Text = record5[42].ToString();
                            txtNarrative2.InnerText = record5[43].ToString();
                            txtTitle3.Text = record5[44].ToString();
                            txtCompanyName3.Text = record5[45].ToString();
                            txtYears3.Text = record5[46].ToString();
                            txtNarrative3.InnerText = record5[47].ToString();
                            txtTitle4.Text = record5[48].ToString();
                            txtCompanyName4.Text = record5[49].ToString();
                            txtYears4.Text = record5[50].ToString();
                            txtNarrative4.InnerText = record5[51].ToString();
                            txtTitle5.Text = record5[52].ToString();
                            txtCompanyName5.Text = record5[53].ToString();
                            txtYears5.Text = record5[54].ToString();
                            txtNarrative5.InnerText = record5[55].ToString();

                            txtEducation.InnerText = record5[57].ToString();
                            txtTraining.InnerText = record5[59].ToString();
                            txtHonorsAndAwards.InnerText = record5[61].ToString();
                            txtMilitaryService.InnerText = record5[63].ToString();
                            txtVoluntaryPositions.InnerText = record5[65].ToString();
                            txtOther.InnerText = record5[67].ToString();

                            txtName1.Text = record5[68].ToString();
                            txtJobTitle1.Text = record5[69].ToString();
                            txtCompany1.Text = record5[70].ToString();
                            txtRelationship1.Text = record5[71].ToString();
                            txtEmailAddress1.Text = record5[72].ToString();
                            txtPhoneNumber1.Text = record5[73].ToString();
                            txtName2.Text = record5[74].ToString();
                            txtJobTitle2.Text = record5[75].ToString();
                            txtCompany2.Text = record5[76].ToString();
                            txtRelationship2.Text = record5[77].ToString();
                            txtEmailAddress2.Text = record5[78].ToString();
                            txtPhoneNumber2.Text = record5[79].ToString();
                            txtName3.Text = record5[80].ToString();
                            txtJobTitle3.Text = record5[81].ToString();
                            txtCompany3.Text = record5[82].ToString();
                            txtRelationship3.Text = record5[83].ToString();
                            txtEmailAddress3.Text = record5[84].ToString();
                            txtPhoneNumber3.Text = record5[85].ToString();
                            txtName4.Text = record5[86].ToString();
                            txtJobTitle4.Text = record5[87].ToString();
                            txtCompany4.Text = record5[88].ToString();
                            txtRelationship4.Text = record5[89].ToString();
                            txtEmailAddress4.Text = record5[90].ToString();
                            txtPhoneNumber4.Text = record5[91].ToString();
                            txtName5.Text = record5[92].ToString();
                            txtJobTitle5.Text = record5[93].ToString();
                            txtCompany5.Text = record5[94].ToString();
                            txtRelationship5.Text = record5[95].ToString();
                            txtEmailAddress5.Text = record5[96].ToString();
                            txtPhoneNumber5.Text = record5[97].ToString();
                            txtName6.Text = record5[98].ToString();
                            txtJobTitle6.Text = record5[99].ToString();
                            txtCompany6.Text = record5[100].ToString();
                            txtRelationship6.Text = record5[101].ToString();
                            txtEmailAddress6.Text = record5[102].ToString();
                            txtPhoneNumber6.Text = record5[103].ToString();
                            txtName7.Text = record5[104].ToString();
                            txtJobTitle7.Text = record5[105].ToString();
                            txtCompany7.Text = record5[106].ToString();
                            txtRelationship7.Text = record5[107].ToString();
                            txtEmailAddress7.Text = record5[108].ToString();
                            txtPhoneNumber7.Text = record5[109].ToString();
                            txtName8.Text = record5[110].ToString();
                            txtJobTitle8.Text = record5[111].ToString();
                            txtCompany8.Text = record5[112].ToString();
                            txtRelationship8.Text = record5[113].ToString();
                            txtEmailAddress8.Text = record5[114].ToString();
                            txtPhoneNumber8.Text = record5[115].ToString();

                        }//end if

                    }//end else

                }//end if

            }//end else

        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string fullName = txtFullName.Text;
            string _fullName = fullName.ToUpper();
            string degrees = txtDegrees.Text;
            string streetAddress = txtStreetAddress.Text;
            string cityStateZip = txtCityStateZip.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            Validate validationObject = new Validate();

            _fullName = validationObject.Truncate(_fullName, 40);
            degrees = validationObject.Truncate(degrees, 35);
            streetAddress = validationObject.Truncate(streetAddress, 40);
            cityStateZip = validationObject.Truncate(cityStateZip, 40);
            email = validationObject.Truncate(email, 40);
            phone = validationObject.Truncate(phone, 14);

            Aes encryptionObject = Aes.Create();

            byte[] AesKey = encryptionObject.Key;

            byte[] AesIV = encryptionObject.IV;

            string AesKeyString = Convert.ToBase64String(AesKey);

            string AesIVString = Convert.ToBase64String(AesIV);

            byte[] MasterKey = Encryption.GetMasterKey();

            byte[] MasterIV = Encryption.GetMasterIV();

            byte[] encryptedAesKey = Encryption.Encrypt_AES(AesKeyString, MasterKey, MasterIV);

            byte[] encryptedAesIV = Encryption.Encrypt_AES(AesIVString, MasterKey, MasterIV);

            string encryptedAesKeyString = Convert.ToBase64String(encryptedAesKey);

            string encryptedAesIVString = Convert.ToBase64String(encryptedAesIV);

            byte[] encryptedFullName = Encryption.Encrypt_AES(_fullName, AesKey, AesIV);

            string encryptedFullNameString = Convert.ToBase64String(encryptedFullName);

            byte[] encryptedDegrees = Encryption.Encrypt_AES(degrees, AesKey, AesIV);

            string encryptedDegreesString = Convert.ToBase64String(encryptedDegrees);

            byte[] encryptedStreetAddress = Encryption.Encrypt_AES(streetAddress, AesKey, AesIV);

            string encryptedStreetAddressString = Convert.ToBase64String(encryptedStreetAddress);

            byte[] encryptedCityStateZip = Encryption.Encrypt_AES(cityStateZip, AesKey, AesIV);

            string encryptedCityStateZipString = Convert.ToBase64String(encryptedCityStateZip);

            byte[] encryptedEmail = Encryption.Encrypt_AES(email, AesKey, AesIV);

            string encryptedEmailString = Convert.ToBase64String(encryptedEmail);

            byte[] encryptedPhone = Encryption.Encrypt_AES(phone, AesKey, AesIV);

            string encryptedPhoneString = Convert.ToBase64String(encryptedPhone);
            
            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Deliverable_Creation(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError.Text = errorMessage;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else if (recordExists == true)
            {

            }//end else if

            else if (recordExists == false)
            {
                string errorMessage2;

                errorMessage2 = Insert.Insert_Deliverable_Creation(username, encryptedFullNameString, encryptedDegreesString, encryptedStreetAddressString, encryptedCityStateZipString, encryptedEmailString, encryptedPhoneString, encryptedAesKeyString, encryptedAesIVString);

                if (errorMessage2 != null)
                {
                    lblError.Text = errorMessage2;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View2);

                }//end else

            }//end else if

        }//end event

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View2);

        }//end event

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string section1Title = rblSection1Title.SelectedValue;
            string _focus = txtFocus.Text;
            string focus = _focus.ToUpper();
            string theme1 = txtTheme1.InnerText;
            string theme2 = txtTheme2.InnerText;
            string theme3 = txtTheme3.InnerText;

            Validate validationObject = new Validate();

            section1Title = validationObject.Truncate(section1Title, 25);
            focus = validationObject.Truncate(focus, 80);
            theme1 = validationObject.Truncate(theme1, 75);
            theme2 = validationObject.Truncate(theme2, 75);
            theme3 = validationObject.Truncate(theme3, 75);

            string errorMessage;

            errorMessage = Update.Update_Deliverable_Creation(username, section1Title, focus, theme1, theme2, theme3);

            if (errorMessage != null)
            {
                lblError2.Text = errorMessage;
                lblError2.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                MultiView1.SetActiveView(View3);

            }//end else

        }//end event

        protected void btnContinue2_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View3);

        }//end event

        protected void btnSubmit3_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string section2Title = rblSection2Title.SelectedValue;
            string descriptor1 = txtDescriptor1.Text;
            string descriptor2 = txtDescriptor2.Text;
            string descriptor3 = txtDescriptor3.Text;

            Validate validationObject = new Validate();

            section2Title = validationObject.Truncate(section2Title, 25);
            descriptor1 = validationObject.Truncate(descriptor1, 60);
            descriptor2 = validationObject.Truncate(descriptor2, 60);
            descriptor3 = validationObject.Truncate(descriptor3, 60);

            string errorMessage;

            errorMessage = Update.Update_Deliverable_Creation2(username, section2Title, descriptor1, descriptor2, descriptor3);

            if (errorMessage != null)
            {
                lblError3.Text = errorMessage;
                lblError3.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                MultiView1.SetActiveView(View4);

            }//end else

        }//end event

        protected void btnContinue3_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View4);

        }//end event

        protected void btnSubmit4_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

                string qualification1 = txtQualification1.Text;
                string qualification2 = txtQualification2.Text;
                string qualification3 = txtQualification3.Text;
                string qualification4 = txtQualification4.Text;
                string qualification5 = txtQualification5.Text;
                string qualification6 = txtQualification6.Text;
                string qualification7 = txtQualification7.Text;
                string qualification8 = txtQualification8.Text;
                string qualification9 = txtQualification9.Text;

                Validate validationObject = new Validate();

                qualification1 = validationObject.Truncate(qualification1, 34);
                qualification2 = validationObject.Truncate(qualification2, 34);
                qualification3 = validationObject.Truncate(qualification3, 34);
                qualification4 = validationObject.Truncate(qualification4, 34);
                qualification5 = validationObject.Truncate(qualification5, 32);
                qualification6 = validationObject.Truncate(qualification6, 32);
                qualification7 = validationObject.Truncate(qualification7, 32);
                qualification8 = validationObject.Truncate(qualification8, 34);
                qualification9 = validationObject.Truncate(qualification9, 34);

                string errorMessage;

                errorMessage = Update.Update_Deliverable_Creation3(username, qualification1, qualification2, qualification3, qualification4, qualification5, qualification6, qualification7, qualification8, qualification9);

                if (errorMessage != null)
                {
                    lblError4.Text = errorMessage;
                    lblError4.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View5);

                }//end else

        }//end event

        protected void btnContinue4_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View5);

        }//end event

        protected void btnSubmit5_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string section3Title = rblSection3Title.SelectedValue;
            string achievement1 = txtAchievement1.InnerText;
            string achievement2 = txtAchievement2.InnerText;
            string achievement3 = txtAchievement3.InnerText;
            string achievement4 = txtAchievement4.InnerText;
            string achievement5 = txtAchievement5.InnerText;
            string achievement6 = txtAchievement6.InnerText;
            string achievement7 = txtAchievement7.InnerText;
            string achievement8 = txtAchievement8.InnerText;

            Validate validationObject = new Validate();

            section3Title = validationObject.Truncate(section3Title, 75);
            achievement1 = validationObject.Truncate(achievement1, 900);
            achievement2 = validationObject.Truncate(achievement2, 900);
            achievement3 = validationObject.Truncate(achievement3, 900);
            achievement4 = validationObject.Truncate(achievement4, 900);
            achievement5 = validationObject.Truncate(achievement5, 900);
            achievement6 = validationObject.Truncate(achievement6, 900);
            achievement7 = validationObject.Truncate(achievement7, 900);
            achievement8 = validationObject.Truncate(achievement8, 900);

            lblAchievement1.Text = achievement1;
            lblAchievement2.Text = achievement2;
            lblAchievement3.Text = achievement3;
            lblAchievement4.Text = achievement4;
            lblAchievement5.Text = achievement5;
            lblAchievement6.Text = achievement6;
            lblAchievement7.Text = achievement7;
            lblAchievement8.Text = achievement8;

            string errorMessage;

            errorMessage = Update.Update_Deliverable_Creation4(username, section3Title, achievement1, achievement2, achievement3, achievement4, achievement5, achievement6, achievement7, achievement8);

            if (errorMessage != null)
            {
                lblError5.Text = errorMessage;
                lblError5.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                MultiView1.SetActiveView(View6);

            }//end else

        }//end event

        protected void btnContinue5_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View6);

        }//end event

        protected void btnSubmit6_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string section4Title = rblSection4Title.SelectedValue;
            string jobTitles = txtJobTitles.InnerText;

            Validate validationObject = new Validate();

            section4Title = validationObject.Truncate(section4Title, 75);
            jobTitles = validationObject.Truncate(jobTitles, 420);

            string errorMessage;

            errorMessage = Update.Update_Deliverable_Creation5(username, section4Title, jobTitles);

            if (errorMessage != null)
            {
                lblError6.Text = errorMessage;
                lblError6.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                MultiView1.SetActiveView(View7);

            }//end else

        }//end event

        protected void btnContinue6_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View7);

        }//end event

        protected void btnSubmit7_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string title1 = txtTitle1.Text;
            string companyName1 = txtCompanyName1.Text;
            string years1 = txtYears1.Text;
            string narrative1 = txtNarrative1.InnerText;

            string title2 = txtTitle2.Text;
            string companyName2 = txtCompanyName2.Text;
            string years2 = txtYears2.Text;
            string narrative2 = txtNarrative2.InnerText;

            string title3 = txtTitle3.Text;
            string companyName3 = txtCompanyName3.Text;
            string years3 = txtYears3.Text;
            string narrative3 = txtNarrative3.InnerText;

            string title4 = txtTitle4.Text;
            string companyName4 = txtCompanyName4.Text;
            string years4 = txtYears4.Text;
            string narrative4 = txtNarrative4.InnerText;

            string title5 = txtTitle5.Text;
            string companyName5 = txtCompanyName5.Text;
            string years5 = txtYears5.Text;
            string narrative5 = txtNarrative5.InnerText;

            Validate validationObject = new Validate();

            title1 = validationObject.Truncate(title1, 40);
            companyName1 = validationObject.Truncate(companyName1, 35);
            years1 = validationObject.Truncate(years1, 14);
            narrative1 = validationObject.Truncate(narrative1, 900);

            title2 = validationObject.Truncate(title2, 40);
            companyName2 = validationObject.Truncate(companyName2, 35);
            years2 = validationObject.Truncate(years2, 14);
            narrative2 = validationObject.Truncate(narrative2, 900);

            title3 = validationObject.Truncate(title3, 40);
            companyName3 = validationObject.Truncate(companyName3, 35);
            years3 = validationObject.Truncate(years3, 14);
            narrative3 = validationObject.Truncate(narrative3, 900);

            title4 = validationObject.Truncate(title4, 40);
            companyName4 = validationObject.Truncate(companyName4, 35);
            years4 = validationObject.Truncate(years4, 14);
            narrative4 = validationObject.Truncate(narrative4, 900);

            title5 = validationObject.Truncate(title5, 40);
            companyName5 = validationObject.Truncate(companyName5, 35);
            years5 = validationObject.Truncate(years5, 14);
            narrative5 = validationObject.Truncate(narrative5, 900);

            string errorMessage;

            errorMessage = Update.Update_Deliverable_Creation6(username, title1, companyName1, years1, narrative1, title2, companyName2, years2, narrative2, title3, companyName3, years3, narrative3, title4, companyName4, years4, narrative4, title5, companyName5, years5, narrative5);

            if (errorMessage != null)
            {
                lblError7.Text = errorMessage;
                lblError7.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                MultiView1.SetActiveView(View8);

            }//end else

        }//end event

        protected void btnContinue7_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View8);

        }//end event

        protected void btnSubmit8_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string education = txtEducation.InnerText;
            string training = txtTraining.InnerText;
            string honorsAndAwards = txtHonorsAndAwards.InnerText;
            string militaryService = txtMilitaryService.InnerText;
            string voluntaryPositions = txtVoluntaryPositions.InnerText;
            string other = txtOther.InnerText;

            Validate validationObject = new Validate();

            education = validationObject.Truncate(education, 900);
            training = validationObject.Truncate(training, 900);
            honorsAndAwards = validationObject.Truncate(honorsAndAwards, 900);
            militaryService = validationObject.Truncate(militaryService, 900);
            voluntaryPositions = validationObject.Truncate(voluntaryPositions, 900);
            other = validationObject.Truncate(other, 900);

            string errorMessage;

            errorMessage = Update.Update_Deliverable_Creation7(username, education, training, honorsAndAwards, militaryService, voluntaryPositions, other);

            if (errorMessage != null)
            {
                lblError8.Text = errorMessage;
                lblError8.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                MultiView1.SetActiveView(View9);

            }//end else

        }//end event

        protected void btnContinue8_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View9);

        }//end event

        protected void btnSubmit9_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string name1 = txtName1.Text;
            string title1 = txtJobTitle1.Text;
            string company1 = txtCompany1.Text;
            string relationship1 = txtRelationship1.Text;
            string email1 = txtEmailAddress1.Text;
            string phone1 = txtPhoneNumber1.Text;

            string name2 = txtName2.Text;
            string title2 = txtJobTitle2.Text;
            string company2 = txtCompany2.Text;
            string relationship2 = txtRelationship2.Text;
            string email2 = txtEmailAddress2.Text;
            string phone2 = txtPhoneNumber2.Text;

            string name3 = txtName3.Text;
            string title3 = txtJobTitle3.Text;
            string company3 = txtCompany3.Text;
            string relationship3 = txtRelationship3.Text;
            string email3 = txtEmailAddress3.Text;
            string phone3 = txtPhoneNumber3.Text;

            string name4 = txtName4.Text;
            string title4 = txtJobTitle4.Text;
            string company4 = txtCompany4.Text;
            string relationship4 = txtRelationship4.Text;
            string email4 = txtEmailAddress4.Text;
            string phone4 = txtPhoneNumber4.Text;

            string name5 = txtName5.Text;
            string title5 = txtJobTitle5.Text;
            string company5 = txtCompany5.Text;
            string relationship5 = txtRelationship5.Text;
            string email5 = txtEmailAddress5.Text;
            string phone5 = txtPhoneNumber5.Text;

            string name6 = txtName6.Text;
            string title6 = txtJobTitle6.Text;
            string company6 = txtCompany6.Text;
            string relationship6 = txtRelationship6.Text;
            string email6 = txtEmailAddress6.Text;
            string phone6 = txtPhoneNumber6.Text;

            string name7 = txtName7.Text;
            string title7 = txtJobTitle7.Text;
            string company7 = txtCompany7.Text;
            string relationship7 = txtRelationship7.Text;
            string email7 = txtEmailAddress7.Text;
            string phone7 = txtPhoneNumber7.Text;

            string name8 = txtName8.Text;
            string title8 = txtJobTitle8.Text;
            string company8 = txtCompany8.Text;
            string relationship8 = txtRelationship8.Text;
            string email8 = txtEmailAddress8.Text;
            string phone8 = txtPhoneNumber8.Text;

            Validate validationObject = new Validate();

            name1 = validationObject.Truncate(name1, 35);
            title1 = validationObject.Truncate(title1, 35);
            company1 = validationObject.Truncate(company1, 35);
            relationship1 = validationObject.Truncate(relationship1, 35);
            email1 = validationObject.Truncate(email1, 40);
            phone1 = validationObject.Truncate(phone1, 14);

            name2 = validationObject.Truncate(name2, 35);
            title2 = validationObject.Truncate(title2, 35);
            company2 = validationObject.Truncate(company2, 35);
            relationship2 = validationObject.Truncate(relationship2, 35);
            email2 = validationObject.Truncate(email2, 40);
            phone2 = validationObject.Truncate(phone2, 14);

            name3 = validationObject.Truncate(name3, 35);
            title3 = validationObject.Truncate(title3, 35);
            company3 = validationObject.Truncate(company3, 35);
            relationship3 = validationObject.Truncate(relationship3, 35);
            email3 = validationObject.Truncate(email3, 40);
            phone3 = validationObject.Truncate(phone3, 14);

            name4 = validationObject.Truncate(name4, 35);
            title4 = validationObject.Truncate(title4, 35);
            company4 = validationObject.Truncate(company4, 35);
            relationship4 = validationObject.Truncate(relationship4, 35);
            email4 = validationObject.Truncate(email4, 40);
            phone4 = validationObject.Truncate(phone4, 14);

            name5 = validationObject.Truncate(name5, 35);
            title5 = validationObject.Truncate(title5, 35);
            company5 = validationObject.Truncate(company5, 35);
            relationship5 = validationObject.Truncate(relationship5, 35);
            email5 = validationObject.Truncate(email5, 40);
            phone5 = validationObject.Truncate(phone5, 14);

            name6 = validationObject.Truncate(name6, 35);
            title6 = validationObject.Truncate(title6, 35);
            company6 = validationObject.Truncate(company6, 35);
            relationship6 = validationObject.Truncate(relationship6, 35);
            email6 = validationObject.Truncate(email6, 40);
            phone6 = validationObject.Truncate(phone6, 14);

            name7 = validationObject.Truncate(name7, 35);
            title7 = validationObject.Truncate(title7, 35);
            company7 = validationObject.Truncate(company7, 35);
            relationship7 = validationObject.Truncate(relationship7, 35);
            email7 = validationObject.Truncate(email7, 40);
            phone7 = validationObject.Truncate(phone7, 14);

            name8 = validationObject.Truncate(name8, 35);
            title8 = validationObject.Truncate(title8, 35);
            company8 = validationObject.Truncate(company8, 35);
            relationship8 = validationObject.Truncate(relationship8, 35);
            email8 = validationObject.Truncate(email8, 40);
            phone8 = validationObject.Truncate(phone8, 14);

            string errorMessage;

            errorMessage = Update.Update_Deliverable_Creation8(username, name1, title1, company1, relationship1, email1, phone1, name2, title2, company2, relationship2, email2, phone2, name3, title3, company3, relationship3, email3, phone3, name4, title4, company4, relationship4, email4, phone4, name5, title5, company5, relationship5, email5, phone5, name6, title6, company6, relationship6, email6, phone6, name7, title7, company7, relationship7, email7, phone7, name8, title8, company8, relationship8, email8, phone8);

            if (errorMessage != null)
            {
                lblError9.Text = errorMessage;
                lblError9.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                string clientCounselor;

                string errorMessage4;

                Select selectObject4 = new Select();

                clientCounselor = Select.Select_Client_Counselor(username);

                errorMessage4 = selectObject4.getErrorMessage();

                if (errorMessage4 != null)
                {
                    lblError9.Text = errorMessage4;
                    lblError9.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    string counselorFirstName;

                    string errorMessage5;

                    Select selectObject5 = new Select();

                    counselorFirstName = Select.Select_Client_FirstName(clientCounselor);

                    errorMessage5 = selectObject5.getErrorMessage();

                    if (errorMessage5 != null)
                    {
                        lblError9.Text = errorMessage5;
                        lblError9.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        DateTime date = DateTime.Today;

                        string _date = date.ToString("MM/dd/yyyy");

                        string clientName;

                        string errorMessage3;

                        Select selectObject = new Select();

                        clientName = Select.Select_Client_Name(username);

                        errorMessage3 = selectObject.getErrorMessage();

                        if (errorMessage3 != null)
                        {
                            lblError9.Text = errorMessage3;
                            lblError9.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else
                        {
                            string clientPhoneNumber;

                            string errorMessage10;

                            Select selectObject2 = new Select();

                            clientPhoneNumber = Select.Select_Client_Phone_Number(username);

                            errorMessage10 = selectObject2.getErrorMessage();

                            if (errorMessage10 != null)
                            {
                                lblError9.Text = errorMessage10;
                                lblError9.Visible = true;

                                ErrorMessage message = new ErrorMessage();

                                MsgBox(message.SQLServerErrorMessage);

                            }//end if

                            else
                            {
                                string AppPath = Request.PhysicalApplicationPath;
                                StreamReader sr = new StreamReader(AppPath + "SA/Email_Templates/MDC_Complete.txt");

                                Email emailObject = new Email();

                                string errorMessage2;

                                errorMessage2 = Email.Email_MDC_Complete(username, clientCounselor, counselorFirstName, clientName, clientPhoneNumber, _date, sr);

                                if (errorMessage2 != null)
                                {
                                    lblError9.Text = errorMessage2;
                                    lblError9.Visible = true;

                                    ErrorMessage message = new ErrorMessage();

                                    MsgBox(message.EmailErrorMessage);

                                }//end if

                            }//end else

                        }//end else

                    }//end else

                }//end else

                MultiView1.SetActiveView(View10);

            }//end else

        }//end event

        protected void btnContinue9_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View10);

        }//end event

        protected void btnContinue10_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;
            
            string errorMessage;

            errorMessage = Update.Update_Deliverable_Creation_Status(username);

            if (errorMessage != null)
            {
                lblError10.Text = errorMessage;
                lblError10.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                Response.Redirect("~/PL/FOP/FOP_ProgressMenu.aspx");

            }//end else

        }//end event

        protected void lbStatementOfValue_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            ArrayList deliverableCreationRecord = new ArrayList();

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Deliverable_Creation(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError10.Text = errorMessage;
                lblError10.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else if (recordExists == true)
            {
                string errorMessage2;

                Select selectObject2 = new Select();

                deliverableCreationRecord = Select.Select_Deliverable_Creation_Record(username);

                errorMessage2 = selectObject2.getErrorMessage();

                if (errorMessage2 != null)
                {
                    lblError10.Text = errorMessage2;
                    lblError10.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    string appPath = Request.PhysicalApplicationPath;
                    string templatePath = Server.MapPath("~/Docs/FOP/Marketing_Documents_Templates/Statement_of_Value.xml");
                    string savePath = appPath + "/App_Data/Statement_of_Value.xml";

                    string errorMessage3;

                    errorMessage3 = DeliverableCreation.Create_Statement_Of_Value(deliverableCreationRecord, savePath, templatePath);

                    if (errorMessage3 != null)
                    {
                        lblError10.Text = errorMessage3;
                        lblError10.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.DeliverableCreationErrorMessage);

                    }//end if

                    else
                    {
                        Response.ContentType = "Application/xml";
                        Response.AppendHeader("Content-Disposition", "attachment; filename=Statement_of_Value.xml");
                        Response.TransmitFile(Server.MapPath("~/App_Data/Statement_of_Value.xml"));
                        Response.End();

                    }//end else

                }//end else

            }//end else if

        }//end event

        protected void lbExpandedExperienceProfile_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            ArrayList deliverableCreationRecord = new ArrayList();

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Deliverable_Creation(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError10.Text = errorMessage;
                lblError10.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else if (recordExists == true)
            {
                string errorMessage2;

                Select selectObject2 = new Select();

                deliverableCreationRecord = Select.Select_Deliverable_Creation_Record(username);

                errorMessage2 = selectObject2.getErrorMessage();

                if (errorMessage2 != null)
                {
                    lblError10.Text = errorMessage2;
                    lblError10.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    string appPath = Request.PhysicalApplicationPath;
                    string templatePath = Server.MapPath("~/Docs/FOP/Marketing_Documents_Templates/Expanded_Experience_Profile.xml");
                    string savePath = appPath + "/App_Data/Expanded_Experience_Profile.xml";

                    string errorMessage3;

                    errorMessage3 = DeliverableCreation.Create_Expanded_Experience_Profile(deliverableCreationRecord, savePath, templatePath);

                    if (errorMessage3 != null)
                    {
                        lblError10.Text = errorMessage3;
                        lblError10.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.DeliverableCreationErrorMessage);

                    }//end if

                    else
                    {
                        Response.ContentType = "Application/xml";
                        Response.AppendHeader("Content-Disposition", "attachment; filename=Expanded_Experience_Profile.xml");
                        Response.TransmitFile(Server.MapPath("~/App_Data/Expanded_Experience_Profile.xml"));
                        Response.End();

                    }//end else

                }//end else

            }//end else if

        }//end event

        protected void lbReferences_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            ArrayList deliverableCreationRecord = new ArrayList();

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Deliverable_Creation(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError10.Text = errorMessage;
                lblError10.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else if (recordExists == true)
            {
                string errorMessage2;

                Select selectObject2 = new Select();

                deliverableCreationRecord = Select.Select_Deliverable_Creation_Record(username);

                errorMessage2 = selectObject2.getErrorMessage();

                if (errorMessage2 != null)
                {
                    lblError10.Text = errorMessage2;
                    lblError10.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    string appPath = Request.PhysicalApplicationPath;
                    string templatePath = Server.MapPath("~/Docs/FOP/Marketing_Documents_Templates/References_list.xml");
                    string savePath = appPath + "/App_Data/References_list.xml";

                    string errorMessage3;

                    errorMessage3 = DeliverableCreation.Create_References(deliverableCreationRecord, savePath, templatePath);

                    if (errorMessage3 != null)
                    {
                        lblError10.Text = errorMessage3;
                        lblError10.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.DeliverableCreationErrorMessage);

                    }//end if

                    else
                    {
                        Response.ContentType = "Application/xml";
                        Response.AppendHeader("Content-Disposition", "attachment; filename=References_list.xml");
                        Response.TransmitFile(Server.MapPath("~/App_Data/References_list.xml"));
                        Response.End();

                    }//end else

                }//end else

            }//end else if

        }//end event

        private void MsgBox(string sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            Response.Write(msg);

        }//end method

    }//end class

}//end namespace