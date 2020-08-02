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
    public partial class _NaturalTalents : Page
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

            recordExists = Select.Select_Natural_Talents(username);

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
                    btnSubmit.Visible = false;
                    btnContinue.Visible = true;

                    ArrayList record = new ArrayList();

                    record = Select.Select_Natural_Talents_Record(username);

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
                        TextBox4.InnerText = record[0].ToString();
                        TextBox1.Text = record[1].ToString();
                        TextBox2.Text = record[2].ToString();
                        TextBox3.Text = record[3].ToString();

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

            string Q1 = TextBox4.InnerText;
            string Q2 = TextBox1.Text;
            string Q3 = TextBox2.Text;
            string Q4 = TextBox3.Text;

            Validate validationObject = new Validate();

            Q1 = validationObject.Truncate(Q1, 900);
            Q2 = validationObject.Truncate(Q2, 900);
            Q3 = validationObject.Truncate(Q3, 900);
            Q4 = validationObject.Truncate(Q4, 900);

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Natural_Talents(username);

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
                if (recordExists == false)
                {
                    string errorMessage2;

                    errorMessage2 = Insert.Insert_Natural_Talents(username, Q1, Q2, Q3, Q4);

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

                        errorMessage3 = Update.Update_Natural_Talents_Status(username);

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

                }//end if

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