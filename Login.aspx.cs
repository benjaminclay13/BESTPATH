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
    public partial class _Login : Page
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

            txtUsername.Focus();

            if (this.IsCookieDisabled())
            {
                Response.Redirect("~/PL/Utilities/EnableCookies.aspx");

            }//end if

            if (Session["JustRegistered"] == "true")
            {
                Session["JustRegistered"] = null;

                MsgBox("Registration is now complete. You may now login with your username and password that you just created on the Registration page.");

            }//end if

        }//end event

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            username = username.Trim();

            password = password.Trim();

            bool authenticated;

            string errorMessage;

            Select selectObject = new Select();

            authenticated = Select.Authenticate_User(username, password);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError.Text = errorMessage;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

                return;

            }//end if

            else if (authenticated == false)
            {
                lblError2.Text = "Invalid credentials. Please try again.";
                lblError2.Visible = true;

            }//end else if

            else
            {
                bool verified;

                string errorMessage2;

                Select selectObject2 = new Select();

                verified = Select.Is_User_Verified(username);

                errorMessage2 = selectObject2.getErrorMessage();

                if (errorMessage2 != null)
                {
                    lblError.Text = errorMessage2;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else if (verified == false)
                {
                    lblError2.Visible = false;
                    
                    MsgBox("Invalid. You must register before you can login to the website. Please complete registration.");

                }//end else if

                else if (verified == true)
                {
                    ArrayList roleData = new ArrayList();

                    string errorMessage3;

                    Select selectObject3 = new Select();

                    roleData = Select.Select_Role_Data(username);

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
                        string encryptedRole = roleData[0].ToString();
                        string encryptedKey = roleData[1].ToString();
                        string encryptedIV = roleData[2].ToString();

                        byte[] MasterKey = Encryption.GetMasterKey();

                        byte[] MasterIV = Encryption.GetMasterIV();

                        byte[] encryptedKeyArray = Convert.FromBase64String(encryptedKey);

                        byte[] encryptedIVArray = Convert.FromBase64String(encryptedIV);

                        byte[] encryptedRoleArray = Convert.FromBase64String(encryptedRole);

                        string decryptedKey = Encryption.Decrypt_AES(encryptedKeyArray, MasterKey, MasterIV);

                        string decryptedIV = Encryption.Decrypt_AES(encryptedIVArray, MasterKey, MasterIV);

                        byte[] decryptedKeyArray = Convert.FromBase64String(decryptedKey);

                        byte[] decryptedIVArray = Convert.FromBase64String(decryptedIV);

                        string decryptedRole = Encryption.Decrypt_AES(encryptedRoleArray, decryptedKeyArray, decryptedIVArray);

                        Session sessionObject = new Session();
                        HttpCookie authCookie = FormsAuthentication.GetAuthCookie(username, false);
                        FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                        FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, decryptedRole);
                        string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                        cookie.Expires = newTicket.Expiration;
                        Response.Cookies.Add(cookie);

                        bool updated = false;

                        string errorMessage4;

                        Update updateObject = new Update();

                        updated = Update.Update_Date_Of_Last_Login(username);

                        errorMessage4 = updateObject.getErrorMessage();

                        if (errorMessage4 != null)
                        {
                            lblError.Text = errorMessage4;
                            lblError.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else if (errorMessage4 == null)
                        {
                            int numberOfLogins;

                            string errorMessage5;

                            Select selectObject4 = new Select();

                            numberOfLogins = Select.Select_Number_Of_Logins(username);

                            errorMessage5 = selectObject4.getErrorMessage();

                            if (errorMessage5 != null)
                            {
                                lblError.Text = errorMessage5;
                                lblError.Visible = true;

                                ErrorMessage message = new ErrorMessage();

                                MsgBox(message.SQLServerErrorMessage);

                            }//end if

                            else
                            {
                                bool updated2 = false;

                                string errorMessage6;

                                Update updateObject2 = new Update();

                                updated2 = Update.Update_Number_Of_Logins(username, numberOfLogins);

                                errorMessage6 = updateObject2.getErrorMessage();

                                if (errorMessage6 != null)
                                {
                                    lblError.Text = errorMessage6;
                                    lblError.Visible = true;

                                    ErrorMessage message = new ErrorMessage();

                                    MsgBox(message.SQLServerErrorMessage);

                                }//end if

                                else if (errorMessage6 == null)
                                {
                                    if (decryptedRole == "Super Admin")
                                    {
                                        Response.Redirect("~/PL/Admin/AdminMenu.aspx");

                                    }//end if

                                    else if (decryptedRole == "Admin")
                                    {
                                        Response.Redirect("~/PL/Admin/CounselorMenu.aspx");

                                    }//end else if

                                    else if (decryptedRole == "Client")
                                    {
                                        Response.Redirect("~/PL/BLPDS/BPF_LifePurposeDevelopmentSeries.aspx");

                                    }//end else if

                                }//end else if

                            }//end else

                        }//end else if

                    }//end else

                }//end else if

            }//end else

        }//end event

        protected void lbForgotPassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblUsername.Visible = true;

            }//end if

            else
            {
                string username = txtUsername.Text;

                username = username.Trim();

                Session["Username"] = username;

                Response.Redirect("~/PL/Membership/ForgotPassword.aspx");

            }//end else

        }//end event

        private void MsgBox(string sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            Response.Write(msg);

        }//end method

        private bool IsCookieDisabled()
        {
            string currentUrl = Request.RawUrl;

            if (Request.QueryString["cookieCheck"] == null)
            {
                try
                {
                    HttpCookie c = new HttpCookie("SupportCookies", "true");
                    Response.Cookies.Add(c);

                    if (currentUrl.IndexOf("?") > 0)
                    {
                        currentUrl = currentUrl + "&cookieCheck=true";

                    }//end if

                    else
                    {
                        currentUrl = currentUrl + "?cookieCheck=true";

                    }//end else

                    Response.Redirect(currentUrl);

                }//end try

                catch (Exception ex)
                {
                    return false;

                }//end catch

            }//end if

            if (!Request.Browser.Cookies || Request.Cookies["SupportCookies"] == null)
            {
                return true;

            }//end if

            return false;

        }//end method

    }//end class

}//end namespace