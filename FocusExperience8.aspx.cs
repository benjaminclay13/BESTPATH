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
    public partial class _FocusExperience8 : Page
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

            bool recordExists2;

            string errorMessage3;

            Select selectObject3 = new Select();

            recordExists2 = Select.Select_Focus_Demonstration_Worksheet(username);

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
                    if (!Page.IsPostBack)
                    {
                        string errorMessage4;

                        ArrayList record2 = new ArrayList();

                        Select selectObject4 = new Select();

                        record2 = Select.Select_Focus_Demonstration_Worksheet_Record(username);

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
                            lblExperienceTitle.Text = record2[7].ToString();

                        }//end else

                    }//end if

                }//end if

            }//end else

            bool recordExists3;

            string errorMessage5;

            Select selectObject5 = new Select();

            recordExists3 = Select.Select_Focus_Experience8(username);

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
                    if (!Page.IsPostBack)
                    {
                        btnSubmit.Visible = false;
                        btnContinue.Visible = true;

                        string errorMessage6;

                        ArrayList record3 = new ArrayList();

                        Select selectObject6 = new Select();

                        record3 = Select.Select_Focus_Experience8_Record(username);

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
                            txtQ1.InnerText = record3[0].ToString();
                            txtQ2.InnerText = record3[1].ToString();
                            txtQ3.InnerText = record3[2].ToString();
                            txtQ4.InnerText = record3[3].ToString();
                            txtQ5.InnerText = record3[4].ToString();
                            txtQ6.InnerText = record3[5].ToString();
                            txtQ7.InnerText = record3[6].ToString();
                            txtQ8.InnerText = record3[7].ToString();
                            txtQ9.InnerText = record3[8].ToString();
                            txtQ10.InnerText = record3[9].ToString();
                            txtQ11.InnerText = record3[10].ToString();
                            txtQ12.InnerText = record3[11].ToString();
                            txtQ13.InnerText = record3[12].ToString();

                        }//end else

                    }//end if

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

            string Q1 = txtQ1.InnerText;
            string Q2 = txtQ2.InnerText;
            string Q3 = txtQ3.InnerText;
            string Q4 = txtQ4.InnerText;
            string Q5 = txtQ5.InnerText;
            string Q6 = txtQ6.InnerText;
            string Q7 = txtQ7.InnerText;
            string Q8 = txtQ8.InnerText;
            string Q9 = txtQ9.InnerText;
            string Q10 = txtQ10.InnerText;
            string Q11 = txtQ11.InnerText;
            string Q12 = txtQ12.InnerText;
            string Q13 = txtQ13.InnerText;

            Validate validationObject = new Validate();

            Q1 = validationObject.Truncate(Q1, 900);
            Q2 = validationObject.Truncate(Q2, 900);
            Q3 = validationObject.Truncate(Q3, 900);
            Q4 = validationObject.Truncate(Q4, 900);
            Q5 = validationObject.Truncate(Q5, 900);
            Q6 = validationObject.Truncate(Q6, 900);
            Q7 = validationObject.Truncate(Q7, 900);
            Q8 = validationObject.Truncate(Q8, 900);
            Q9 = validationObject.Truncate(Q9, 900);
            Q10 = validationObject.Truncate(Q10, 900);
            Q11 = validationObject.Truncate(Q11, 900);
            Q12 = validationObject.Truncate(Q12, 900);
            Q13 = validationObject.Truncate(Q13, 900);

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Focus_Experience8(username);

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

                }//end if

                else if (recordExists == false)
                {
                    string errorMessage2;

                    errorMessage2 = Insert.Insert_Focus_Experience8(username, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13);

                    if (errorMessage2 != null)
                    {
                        lblError.Text = errorMessage2;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        string errorMessage3;

                        errorMessage3 = Update.Update_Focus_Experience8_Status(username);

                        if (errorMessage3 != null)
                        {
                            lblError.Text = errorMessage3;
                            lblError.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else
                        {
                            Response.Redirect("~/PL/FOP/FOP_ProgressMenu.aspx");

                        }//end else

                    }//end else

                }//end else if

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