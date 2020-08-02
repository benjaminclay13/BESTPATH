using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;
using System.Collections;

namespace BESTPATH
{
    public partial class _FocusConsolidationWorksheet : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Cache.SetAllowResponseInBrowserHistory(false);
            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            HttpContext.Current.Response.Cache.SetNoStore();
            Response.Cache.SetExpires(DateTime.Now);
            Response.Cache.SetValidUntilExpires(true);
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

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
                            Label1.Text = record[188].ToString();
                            Label2.Text = record[189].ToString();
                            Label3.Text = record[190].ToString();
                            Label4.Text = record[191].ToString();
                            Label5.Text = record[192].ToString();
                            Label6.Text = record[193].ToString();

                        }//end else

                    }//end if

            }//end else

            bool recordExists2;

            string errorMessage3;

            Select selectObject3 = new Select();

            recordExists2 = Select.Select_Education_Inventory(username);

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

                    record2 = Select.Select_Education_Inventory_Record(username);

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
                        Label33.Text = record2[15].ToString();
                        Label34.Text = record2[16].ToString();
                        Label35.Text = record2[17].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists3;

            string errorMessage5;

            Select selectObject5 = new Select();

            recordExists3 = Select.Select_Natural_Talents(username);

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

                    record3 = Select.Select_Natural_Talents_Record(username);

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
                        Label7.Text = record3[1].ToString();
                        Label8.Text = record3[2].ToString();
                        Label9.Text = record3[3].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists4;

            string errorMessage7;

            Select selectObject7 = new Select();

            recordExists4 = Select.Select_Sharegiver_Talents(username);

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

                    record4 = Select.Select_Sharegiver_Talents_Record(username);

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
                        Label36.Text = record4[76].ToString();
                        Label37.Text = record4[77].ToString();
                        Label38.Text = record4[78].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists5;

            string errorMessage9;

            Select selectObject9 = new Select();

            recordExists5 = Select.Select_Total_Spiritual_Gifts(username);

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

                    record5 = Select.Select_Total_Spiritual_Gifts_Record(username);

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
                        Label10.Text = record5[21].ToString();
                        Label11.Text = record5[24].ToString();
                        Label12.Text = record5[22].ToString();
                        Label13.Text = record5[25].ToString();
                        Label14.Text = record5[23].ToString();
                        Label15.Text = record5[26].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists6;

            string errorMessage11;

            Select selectObject11 = new Select();

            recordExists6 = Select.Select_Personal_Management_Style(username);

            errorMessage11 = selectObject11.getErrorMessage();

            if (errorMessage11 != null)
            {
                lblError.Text = errorMessage11;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists6 == true)
                {
                    string errorMessage12;

                    ArrayList record6 = new ArrayList();

                    Select selectObject12 = new Select();

                    record6 = Select.Select_Personal_Management_Style_Record(username);

                    errorMessage12 = selectObject12.getErrorMessage();

                    if (errorMessage12 != null)
                    {
                        lblError.Text = errorMessage12;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        Label16.Text = record6[38].ToString();
                        Label17.Text = record6[40].ToString();
                        Label18.Text = record6[41].ToString();
                        Label19.Text = record6[43].ToString();
                        Label20.Text = record6[44].ToString();
                        Label21.Text = record6[46].ToString();
                        Label22.Text = record6[47].ToString();
                        Label23.Text = record6[49].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists7;

            string errorMessage13;

            Select selectObject13 = new Select();

            recordExists7 = Select.Select_Perception_Response_Summary(username);

            errorMessage13 = selectObject13.getErrorMessage();

            if (errorMessage13 != null)
            {
                lblError.Text = errorMessage13;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists7 == true)
                {
                    string errorMessage14;

                    ArrayList record7 = new ArrayList();

                    Select selectObject14 = new Select();

                    record7 = Select.Select_Perception_Response_Summary_Record(username);

                    errorMessage14 = selectObject14.getErrorMessage();

                    if (errorMessage14 != null)
                    {
                        lblError.Text = errorMessage14;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        Label24.Text = record7[0].ToString();
                        Label25.Text = record7[1].ToString();
                        Label26.Text = record7[2].ToString();
                        Label27.Text = record7[3].ToString();
                        Label28.Text = record7[4].ToString();
                        Label29.Text = record7[5].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists8;

            string errorMessage15;

            Select selectObject15 = new Select();

            recordExists8 = Select.Select_Fundamental_Life_Motivators(username);

            errorMessage15 = selectObject15.getErrorMessage();

            if (errorMessage15 != null)
            {
                lblError.Text = errorMessage15;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists8 == true)
                {
                    string errorMessage16;

                    ArrayList record8 = new ArrayList();

                    Select selectObject16 = new Select();

                    record8 = Select.Select_Fundamental_Life_Motivators_Record(username);

                    errorMessage16 = selectObject16.getErrorMessage();

                    if (errorMessage16 != null)
                    {
                        lblError.Text = errorMessage16;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        Label30.Text = record8[0].ToString();
                        Label31.Text = record8[1].ToString();
                        Label32.Text = record8[2].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists9;

            string errorMessage17;

            Select selectObject17 = new Select();

            recordExists9 = Select.Select_Expressing_Personal_Genius(username);

            errorMessage17 = selectObject17.getErrorMessage();

            if (errorMessage17 != null)
            {
                lblError.Text = errorMessage17;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists9 == true)
                {
                    string errorMessage18;

                    ArrayList record9 = new ArrayList();

                    Select selectObject18 = new Select();

                    record9 = Select.Select_Expressing_Personal_Genius_Record(username);

                    errorMessage18 = selectObject18.getErrorMessage();

                    if (errorMessage18 != null)
                    {
                        lblError.Text = errorMessage18;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        Label39.Text = record9[0].ToString();
                        Label40.Text = record9[3].ToString();
                        Label41.Text = record9[1].ToString();
                        Label42.Text = record9[4].ToString();
                        Label43.Text = record9[2].ToString();
                        Label44.Text = record9[5].ToString();

                    }//end else

                }//end if

            }//end else

            bool recordExists10;

            string errorMessage19;

            Select selectObject19 = new Select();

            recordExists10 = Select.Select_Creativity_Cycle(username);

            errorMessage19 = selectObject19.getErrorMessage();

            if (errorMessage19 != null)
            {
                lblError.Text = errorMessage19;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists10 == true)
                {
                    string errorMessage20;

                    ArrayList record10 = new ArrayList();

                    Select selectObject20 = new Select();

                    record10 = Select.Select_Creativity_Cycle_Record(username);

                    errorMessage20 = selectObject20.getErrorMessage();

                    if (errorMessage20 != null)
                    {
                        lblError.Text = errorMessage20;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        Label45.Text = record10[0].ToString();

                    }//end else

                }//end if

            }//end else

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

            string errorMessage;

            errorMessage = Update.Update_Focus_Consolidation_Status(username);

            if (errorMessage != null)
            {
                lblError.Text = errorMessage;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                Response.Redirect("~/PL/FOP/FOP_ProgressMenu.aspx");

            }//end else

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