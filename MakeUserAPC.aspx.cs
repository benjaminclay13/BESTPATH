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
    public partial class _MakeUserAPC : Page
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

                if (ticket.UserData != "Super Admin")
                {
                    Response.Redirect("~/PL/Membership/Login.aspx");

                }//end if

            }//end if

            else
            {
                Response.Redirect("~/PL/Membership/Login.aspx");

            }//end else

        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtIsRUGAPC.Text;

            bool CLIENT_Exists;

            string errorMessage20;

            Select selectObject20 = new Select();

            CLIENT_Exists = Select.Client_Exists(username);

            errorMessage20 = selectObject20.getErrorMessage();

            if (errorMessage20 != null)
            {
                lblError.Text = errorMessage20;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else if (CLIENT_Exists == false)
            {
                MsgBox("Invalid. No such user exists in the system. Please check your spelling of the client's username.");

            }//end else if

            else if (CLIENT_Exists == true)
            {
                bool BESTPATH_USER_Exists;

                string errorMessage21;

                Select selectObject21 = new Select();

                BESTPATH_USER_Exists = Select.User_Exists(username);

                errorMessage21 = selectObject21.getErrorMessage();

                if (errorMessage21 != null)
                {
                    lblError.Text = errorMessage21;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else if (BESTPATH_USER_Exists == false)
                {
                    MsgBox("Invalid. No such user exists in the system. Please check your spelling of the client's username.");

                }//end else if

                else if (BESTPATH_USER_Exists == true)
                {
                    string errorMessage;

                    errorMessage = Update.Update_Is_RUG_APC(username);

                    if (errorMessage != null)
                    {
                        lblError.Text = errorMessage;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        string appPath = Request.PhysicalApplicationPath;

                        StreamReader sr = new StreamReader(appPath + "SA/Email_Templates/RUG_APC.txt");

                        string errorMessage8;

                        errorMessage8 = Email.Email_RUG_APC(username, sr);

                        if (errorMessage8 != null)
                        {
                            lblError.Text = errorMessage8;
                            lblError.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else
                        {
                            MsgBox("That user is now a RUG APC in the system, and is now able to be a RUG APC when other clients reference them on the Registration and Preliminary Needs Assessment pages.");

                        }//end else

                    }//end else

                }//end else

            }//end else

        }//end event

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            string username = txtIsNotRUGAPC.Text;

            bool CLIENT_Exists;

            string errorMessage20;

            Select selectObject20 = new Select();

            CLIENT_Exists = Select.Client_Exists(username);

            errorMessage20 = selectObject20.getErrorMessage();

            if (errorMessage20 != null)
            {
                lblError.Text = errorMessage20;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else if (CLIENT_Exists == false)
            {
                MsgBox("Invalid. No such user exists in the system. Please check your spelling of the client's username.");

            }//end else if

            else if (CLIENT_Exists == true)
            {
                bool BESTPATH_USER_Exists;

                string errorMessage21;

                Select selectObject21 = new Select();

                BESTPATH_USER_Exists = Select.User_Exists(username);

                errorMessage21 = selectObject21.getErrorMessage();

                if (errorMessage21 != null)
                {
                    lblError.Text = errorMessage21;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else if (BESTPATH_USER_Exists == false)
                {
                    MsgBox("Invalid. No such user exists in the system. Please check your spelling of the client's username.");

                }//end else if

                else if (BESTPATH_USER_Exists == true)
                {
                    string errorMessage;

                    errorMessage = Update.Update_Is_Not_RUG_APC(username);

                    if (errorMessage != null)
                    {
                        lblError.Text = errorMessage;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        MsgBox("That user is now NOT a RUG APC in the system, and is no longer able to be a RUG APC when other clients reference them on the Registration and Preliminary Needs Assessment pages.");

                    }//end else

                }//end else

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