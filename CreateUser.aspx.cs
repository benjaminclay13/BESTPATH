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
    public partial class _CreateUser : Page
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

            HttpCookie _authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket _ticket = FormsAuthentication.Decrypt(_authCookie.Value);

            string username = _ticket.Name;

            ddlCounselor.Items.Add(username);

            txtFirstName.Focus();

        }//end event

        protected void btnCreate_Click(object sender, EventArgs e)
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

            CreatePassword passwordObject = new CreatePassword();

            string password = passwordObject.Create_Password(8);

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string role = ddlRole.SelectedValue;
            string verified = "N";
            string counselor = ddlCounselor.SelectedValue;
            DateTime dateCreated = DateTime.Today;
            int numberOfLogins = 0;
            string securityQuestion = ddlSecurityQuestion.SelectedValue;
            string securityAnswer = txtSecurityAnswer.Text;

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            ddlSecurityQuestion.SelectedValue = string.Empty;
            txtSecurityAnswer.Text = string.Empty;
            txtConfirm.Text = string.Empty;

            if (role == "Counselor")
            {
                role = "Admin";

            }//end if

            string errorMessage;

            Select selectObject = new Select();

            string counselorName;

            counselorName = Select.Select_Counselor_Name(counselor);

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
                Validate validationObject = new Validate();

                username = validationObject.Truncate(username, 100);
                firstName = validationObject.Truncate(firstName, 100);
                lastName = validationObject.Truncate(lastName, 100);
                password = validationObject.Truncate(password, 100);
                role = validationObject.Truncate(role, 100);
                verified = validationObject.Truncate(verified, 900);
                counselor = validationObject.Truncate(counselor, 900);
                counselorName = validationObject.Truncate(counselorName, 100);
                securityQuestion = validationObject.Truncate(securityQuestion, 100);
                securityAnswer = validationObject.Truncate(securityAnswer, 100);

                Aes encryptionObject = Aes.Create();

                byte[] AesKey = encryptionObject.Key;

                byte[] AesIV = encryptionObject.IV;

                string AesKeyString = Convert.ToBase64String(AesKey);

                string AesIVString = Convert.ToBase64String(AesIV);

                byte[] MasterKey = Encryption.GetMasterKey();

                byte[] MasterIV = Encryption.GetMasterIV();

                byte[] encryptedFirstName = Encryption.Encrypt_AES(firstName, AesKey, AesIV);

                string encryptedFirstNameString = Convert.ToBase64String(encryptedFirstName);

                byte[] encryptedLastName = Encryption.Encrypt_AES(lastName, AesKey, AesIV);

                string encryptedLastNameString = Convert.ToBase64String(encryptedLastName);

                byte[] encryptedRole = Encryption.Encrypt_AES(role, AesKey, AesIV);

                string encryptedRoleString = Convert.ToBase64String(encryptedRole);

                byte[] encryptedPassword = Encryption.Encrypt_AES(password, AesKey, AesIV);

                string encryptedPasswordString = Convert.ToBase64String(encryptedPassword);

                byte[] encryptedSecurityQuestion = Encryption.Encrypt_AES(securityQuestion, AesKey, AesIV);

                string encryptedSecurityQuestionString = Convert.ToBase64String(encryptedSecurityQuestion);

                byte[] encryptedSecurityAnswer = Encryption.Encrypt_AES(securityAnswer, AesKey, AesIV);

                string encryptedSecurityAnswerString = Convert.ToBase64String(encryptedSecurityAnswer);

                byte[] encryptedAesKey = Encryption.Encrypt_AES(AesKeyString, MasterKey, MasterIV);

                byte[] encryptedAesIV = Encryption.Encrypt_AES(AesIVString, MasterKey, MasterIV);

                string encryptedAesKeyString = Convert.ToBase64String(encryptedAesKey);

                string encryptedAesIVString = Convert.ToBase64String(encryptedAesIV);

                byte[] encryptedCounselorName = Encryption.Encrypt_AES(counselorName, AesKey, AesIV);

                string encryptedCounselorNameString = Convert.ToBase64String(encryptedCounselorName);

                bool recordExists;

                string errorMessage2;

                Select selectObject2 = new Select();

                recordExists = Select.User_Exists(username);

                errorMessage2 = selectObject2.getErrorMessage();

                if (errorMessage2 != null)
                {
                    lblError.Text = errorMessage2;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                if (recordExists == true)
                {
                    MsgBox("Invalid username. An account for this username already exists. Please try again.");

                }//end if

                else if (recordExists == false)
                {
                    string errorMessage3;

                    errorMessage3 = Insert.Insert_BESTPATH_USER(encryptedFirstNameString, encryptedLastNameString, username, encryptedPasswordString, encryptedRoleString, verified, counselor, encryptedCounselorNameString, dateCreated, numberOfLogins, encryptedSecurityQuestionString, encryptedSecurityAnswerString, encryptedAesKeyString, encryptedAesIVString);

                    if (errorMessage3 != null)
                    {
                        lblError.Text = errorMessage3;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        string errorMessage4;

                        errorMessage4 = Insert.Insert_BESTPATH_STATUS(username);

                        if (errorMessage4 != null)
                        {
                            lblError.Text = errorMessage4;
                            lblError.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else
                        {
                            string urlBase = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath;
                            string registrationUrl = "/PL/Membership/Registration.aspx";
                            string fullPath = urlBase + registrationUrl;
                            string AppPath = Request.PhysicalApplicationPath;
                            StreamReader sr = new StreamReader(AppPath + "SA/Email_Templates/Welcome.txt");

                            Email emailObject = new Email();

                            string errorMessage5;

                            errorMessage5 = Email.Email_Welcome(counselor, firstName, username, password, fullPath, sr);

                            if (errorMessage5 != null)
                            {
                                lblError.Text = errorMessage5;
                                lblError.Visible = true;

                                ErrorMessage message = new ErrorMessage();

                                MsgBox(message.EmailErrorMessage);

                            }//end if

                            else
                            {
                                MsgBox("Account created successfully. An email has just been sent to the client who will need to check their email for his/her login credentials and further instructions, in order to login to the website.");

                            }//end else

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