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
    public partial class _NumberOfUsersInTheSystem : Page
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

            string totalNumberOfUsers;

            string errorMessage;

            Select selectObject = new Select();

            totalNumberOfUsers = Select.Select_Total_Number_Of_Users();

            errorMessage = selectObject.getErrorMessage();

            if(errorMessage != null)
            {
                lblError.Text = errorMessage;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);
            }

            else
            {
                lblTotal.Text = totalNumberOfUsers.ToString();

                string testUsers;

                string errorMessage2;

                Select selectObject2 = new Select();

                testUsers = Select.Select_Test_Users();

                errorMessage2 = selectObject2.getErrorMessage();

                if (errorMessage2 != null)
                {
                    lblError.Text = errorMessage2;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);
                }

                else
                {
                    lblTestUsers.Text = testUsers.ToString();

                    int adminCompUsers;

                    string errorMessage3;

                    Select selectObject3 = new Select();

                    adminCompUsers = Select.Select_Admin_Comp_Users();

                    errorMessage3 = selectObject3.getErrorMessage();

                    if (errorMessage3 != null)
                    {
                        lblError.Text = errorMessage3;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);
                    }

                    else
                    {
                        lblAdminCompUsers.Text = adminCompUsers.ToString();

                        int _testUsers = Convert.ToInt32(testUsers);

                        int _totalNumberOfUsers = Convert.ToInt32(totalNumberOfUsers);

                        int _adminCompUsers = Convert.ToInt32(adminCompUsers);

                        string clients = "0";

                        int _clients = Convert.ToInt32(clients);

                        _clients = _totalNumberOfUsers - _adminCompUsers - _testUsers - 14;

                        lblClients.Text = _clients.ToString();

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