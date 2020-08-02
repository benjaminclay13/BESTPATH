using System;
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

namespace BESTPATH
{
    public partial class _Help : Page
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

            if (!Page.IsPostBack)
            {
                MultiView1.SetActiveView(View1);

            }//end if

            if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
            {
                HttpCookie _authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket _ticket = FormsAuthentication.Decrypt(_authCookie.Value);

                string username = _ticket.Name;

                TextBox1.Text = username;

            }//end if

            TextBox5.Text = String.Format(System.DateTime.Today.ToShortDateString());

        }//end event

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
            {
                HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                Session sessionObject = new Session();
                FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
                string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                cookie.Expires = newTicket.Expiration;
                Response.Cookies.Add(cookie);

            }//end if
            
            MultiView1.SetActiveView(View2);

        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
            {
                HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                Session sessionObject = new Session();
                FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
                string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                cookie.Expires = newTicket.Expiration;
                Response.Cookies.Add(cookie);

            }//end if
            
            string username = TextBox1.Text;
            string _dateOfIncident = TextBox5.Text;
            DateTime dateOfIncident = Convert.ToDateTime(_dateOfIncident);
            string descriptionOfProblem = TextBox3.InnerText;

            Validate validationObject = new Validate();

            descriptionOfProblem = validationObject.Truncate(descriptionOfProblem, 900);

            string clientName = "";

            string errorMessage3;

            Select selectObject = new Select();

            if (username != "")
            {
                clientName = Select.Select_Client_Name(username);

            }//end if

            errorMessage3 = selectObject.getErrorMessage();

            if (errorMessage3 != null)
            {
                lblError.Text = errorMessage3;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                string errorMessage;

                errorMessage = Insert.Insert_Help_Log(username, clientName, dateOfIncident, descriptionOfProblem);

                if (errorMessage != null)
                {
                    lblError.Text = errorMessage;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    string AppPath = Request.PhysicalApplicationPath;
                    StreamReader sr = new StreamReader(AppPath + "SA/Email_Templates/NewHelpRequest.txt");

                    Email emailObject = new Email();

                    string errorMessage2;

                    errorMessage2 = Email.Email_Help(username, clientName, _dateOfIncident, descriptionOfProblem, sr);

                    if (errorMessage2 != null)
                    {
                        lblError.Text = errorMessage2;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.EmailErrorMessage);

                    }//end if

                    else
                    {
                        MsgBox("This form has been submitted to the System Administrator. We will respond to your request as soon as we are able. Thank you.");

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