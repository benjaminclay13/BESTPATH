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
    public partial class _ForgotPassword : Page
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
            
            if (Session["Username"] != null)
            {
                string username = Session["Username"].ToString();

                TextBox1.Text = username;

                string errorMessage;

                Select selectObject3 = new Select();

                bool userExists;

                userExists = Select.User_Exists(username);

                errorMessage = selectObject3.getErrorMessage();

                if (errorMessage != null)
                {
                    lblError.Text = errorMessage;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else if (userExists == false)
                {
                    MsgBox("Invalid username. No account exists for the username entered. Please try again from the Login page.");

                }//end else if

                else if (userExists == true)
                {
                    string errorMessage3;

                    Select selectObject2 = new Select();

                    ArrayList keys = new ArrayList();

                    keys = Select.Select_BESTPATH_USER_Encryption_Keys(username);

                    errorMessage3 = selectObject2.getErrorMessage();

                    if (errorMessage3 != null)
                    {
                        lblError.Text = errorMessage3;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        string encryptedKey = keys[0].ToString();

                        string encryptedIV = keys[1].ToString();

                        byte[] _encryptedKey = Convert.FromBase64String(encryptedKey);

                        byte[] _encryptedIV = Convert.FromBase64String(encryptedIV);

                        byte[] MasterKey = Encryption.GetMasterKey();

                        byte[] MasterIV = Encryption.GetMasterIV();

                        string _key = Encryption.Decrypt_AES(_encryptedKey, MasterKey, MasterIV);

                        string _IV = Encryption.Decrypt_AES(_encryptedIV, MasterKey, MasterIV);

                        byte[] Key = Convert.FromBase64String(_key);

                        byte[] IV = Convert.FromBase64String(_IV);

                        string encryptedSecurityQuestionString;

                        Select selectObject = new Select();

                        encryptedSecurityQuestionString = Select.Select_Security_Question(username);

                        if (selectObject.getErrorMessage() != null)
                        {
                            lblError.Text = selectObject.getErrorMessage();
                            lblError.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else
                        {
                            byte[] encryptedSecurityQuestion = Convert.FromBase64String(encryptedSecurityQuestionString);

                            string decryptedSecurityQuestion = Encryption.Decrypt_AES(encryptedSecurityQuestion, Key, IV);

                            TextBox2.Text = decryptedSecurityQuestion;

                        }//end else

                    }//end else

                }//end else if

            }//end if

        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string securityQuestion = TextBox2.Text;
            string securityAnswer = TextBox3.Text;

            username = username.Trim();

            securityQuestion = securityQuestion.Trim();

            securityAnswer = securityAnswer.Trim();

            string errorMessage4;

            Select selectObject4 = new Select();

            bool clientExists;

            clientExists = Select.Client_Exists(username);

            errorMessage4 = selectObject4.getErrorMessage();

            if (errorMessage4 != null)
            {
                lblError.Text = errorMessage4;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else if (clientExists == false)
            {
                MsgBox("Invalid. You must register before you can login to the website.");

            }//end else if

            else if (clientExists == true)
            {
                string errorMessage3;

                Select selectObject2 = new Select();

                ArrayList keys = new ArrayList();

                keys = Select.Select_BESTPATH_USER_Encryption_Keys(username);

                errorMessage3 = selectObject2.getErrorMessage();

                if (errorMessage3 != null)
                {
                    lblError.Text = errorMessage3;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    string encryptedKey = keys[0].ToString();

                    string encryptedIV = keys[1].ToString();

                    byte[] _encryptedKey = Convert.FromBase64String(encryptedKey);

                    byte[] _encryptedIV = Convert.FromBase64String(encryptedIV);

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    string _key = Encryption.Decrypt_AES(_encryptedKey, MasterKey, MasterIV);

                    string _IV = Encryption.Decrypt_AES(_encryptedIV, MasterKey, MasterIV);

                    byte[] Key = Convert.FromBase64String(_key);

                    byte[] IV = Convert.FromBase64String(_IV);

                    byte[] encryptedSecurityQuestion = Encryption.Encrypt_AES(securityQuestion, Key, IV);

                    byte[] encryptedSecurityAnswer = Encryption.Encrypt_AES(securityAnswer, Key, IV);

                    string _encryptedSecurityQuestion = Convert.ToBase64String(encryptedSecurityQuestion);

                    string _encryptedSecurityAnswer = Convert.ToBase64String(encryptedSecurityAnswer);

                    Select selectObject = new Select();

                    bool authenticated;

                    string errorMessage;

                    authenticated = Select.Authenticate_Security_Credentials(username, _encryptedSecurityQuestion, _encryptedSecurityAnswer);

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
                        if (authenticated == false)
                        {
                            MsgBox("Invalid credentials. Please try again.");

                        }//end if

                        else
                        {
                            string errorMessage2;

                            string newPassword;

                            Update updateObject = new Update();

                            newPassword = Update.Update_Password(username, Key, IV);

                            errorMessage2 = updateObject.getErrorMessage();

                            if (errorMessage2 != null)
                            {
                                lblError.Text = errorMessage2;
                                lblError.Visible = true;

                                ErrorMessage message = new ErrorMessage();

                                MsgBox(message.SQLServerErrorMessage);

                            }//end if

                            else
                            {
                                string errorMessage5;

                                Select selectObject5 = new Select();

                                ArrayList clientRecord = new ArrayList();

                                clientRecord = Select.Select_Client_Record(username);

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
                                    string clientFirstName = clientRecord[1].ToString();

                                    string urlBase = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath;
                                    string loginUrl = "/PL/Membership/Login.aspx";
                                    string fullPath = urlBase + loginUrl;
                                    string AppPath = Request.PhysicalApplicationPath;
                                    StreamReader sr = new StreamReader(AppPath + "SA/Email_Templates/NewPassword.txt");

                                    string errorMessage6;

                                    errorMessage6 = Email.Email_Forgot_Password(username, clientFirstName, newPassword, fullPath, sr);

                                    if (errorMessage6 != null)
                                    {
                                        lblError.Text = errorMessage6;
                                        lblError.Visible = true;

                                        ErrorMessage message = new ErrorMessage();

                                        MsgBox(message.EmailErrorMessage);

                                    }//end if

                                    else
                                    {
                                        MsgBox("Success! An email has just been sent to you with your new temporary password. Please check your email to complete the password reset process. Thank you.");

                                    }//end else

                                }//end else

                            }//end else if

                        }//end else

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