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
    public partial class _ClientStatus : Page
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

            string errorMessage;

            DataTable dataTable = new DataTable();

            Select selectObject = new Select();

            dataTable = Select.Select_Client_Information();

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
                var newDataTable = dataTable.AsEnumerable()
                   .OrderBy(r => r.Field<string>("Counselor name"))
                   .ThenBy(r => r.Field<string>("Last name"))
                   .CopyToDataTable();

                gvClientInformation.DataSource = newDataTable;

                gvClientInformation.DataBind();

                gvClientInformation.Visible = true;

            }//end else

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

            btnSubmit.Focus();

            string username = txtUsername.Text;

            string errorMessage2;

            DataTable dataTable = new DataTable();

            Select selectObject = new Select();

            dataTable = Select.Select_Client_Information(username);

            errorMessage2 = selectObject.getErrorMessage();

            if (errorMessage2 != null)
            {
                lblError.Text = errorMessage2;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                dvClientInformation.DataSource = dataTable;

                dvClientInformation.DataBind();

                dvClientInformation.Visible = true;

            }//end else

            if (dvClientInformation.DataItem == null)
            {
                dvClientInformation.Visible = false;

                MsgBox("Invalid username. No matching user was found for the username provided. Please try again.");

            }//end if

        }//end event

        protected void gvClientInformation_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvClientInformation.PageIndex = e.NewPageIndex;
            gvClientInformation.DataBind();

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