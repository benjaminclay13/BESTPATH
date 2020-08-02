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
    public partial class _Registration : Page
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

            if (ddlReferralSource.AutoPostBack)
            {
                string password = txtPassword.Text;
                txtPassword.Attributes.Add("value", password);

                string confirmPassword = txtConfirmPassword.Text;
                txtConfirmPassword.Attributes.Add("value", confirmPassword);

                string securityAnswer = txtSecurityAnswer.Text;
                txtSecurityAnswer.Attributes.Add("value", securityAnswer);

                string confirmSecurityAnswer = txtConfirmSecurityAnswer.Text;
                txtConfirmSecurityAnswer.Attributes.Add("value", confirmSecurityAnswer);

                string referralSource = ddlReferralSource.SelectedValue;

                if (referralSource == "Referred by a past client who is a RUG Authorized Personal Counselor (APC)")
                {
                    rfvReferralName.Enabled = true;
                    rfvRUGAPCEmailAddress.Enabled = true;

                }//end if

                else if (referralSource == "Referred by a past client who made no mention of being a RUG APC")
                {
                    rfvReferralName.Enabled = true;
                    rfvRUGAPCEmailAddress.Enabled = false;

                }//end else if

                else if (referralSource == "Church outreach")
                {
                    rfvReferralName.Enabled = true;
                    rfvRUGAPCEmailAddress.Enabled = false;

                }//else if

                else if (referralSource == "Other")
                {
                    rfvReferralName.Enabled = true;
                    rfvRUGAPCEmailAddress.Enabled = false;

                }//else if

                else
                {
                    rfvReferralName.Enabled = false;
                    rfvRUGAPCEmailAddress.Enabled = false;

                }//end else

                txtRUGAPCEmailAddress.Focus();

            }//end if

            if (IsPostBack == false)
            {
                txtUsername.Focus();

            }//end if

        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (PasswordPolicy.IsValid(txtPassword.Text) == false)
            {
                MsgBox("Invalid password. Password must be a strong password.");

            }//end if

            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string age = txtAge.Text;
                string streetAddress = txtStreetAddress.Text;
                string city = txtCity.Text;
                string state = txtState.Text;
                string zipCode = txtZipCode.Text;
                string country = txtCountry.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string securityQuestion = ddlSecurityQuestion.SelectedValue;
                string securityAnswer = txtSecurityAnswer.Text;
                string referralSource = ddlReferralSource.SelectedValue;
                string referralName = txtReferralName.Text;
                string RUGAPCEmailAddress = txtRUGAPCEmailAddress.Text;

                string role = "Client";
                string verified = "N";
                string counselor = "jdworktoworship@yahoo.com";
                int numberOfLogins = 0;
                DateTime dateCreated = DateTime.Today;

                if (RUGAPCEmailAddress != "")
                {
                    counselor = RUGAPCEmailAddress;

                    bool isRUGAPC;

                    string errorMessage30;

                    Select selectObject30 = new Select();

                    isRUGAPC = Select.Is_User_RUG_APC(RUGAPCEmailAddress);

                    errorMessage30 = selectObject30.getErrorMessage();

                    if(errorMessage30 != null)
                    {
                        lblError.Text = errorMessage30;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else if(isRUGAPC == false)
                    {
                        MsgBox("Invalid. User specified for RUG APC is not a RUG APC in the system. Please confer with Jim Davis, founder.");

                        return;

                    }//end else if

                }//end if

                Validate validationObject = new Validate();

                username = validationObject.Truncate(username, 100);
                password = validationObject.Truncate(password, 100);
                firstName = validationObject.Truncate(firstName, 100);
                lastName = validationObject.Truncate(lastName, 100);
                age = validationObject.Truncate(age, 100);
                streetAddress = validationObject.Truncate(streetAddress, 100);
                city = validationObject.Truncate(city, 100);
                state = validationObject.Truncate(state, 100);
                zipCode = validationObject.Truncate(zipCode, 100);
                country = validationObject.Truncate(country, 100);
                phoneNumber = validationObject.Truncate(phoneNumber, 100);
                securityQuestion = validationObject.Truncate(securityQuestion, 100);
                securityAnswer = validationObject.Truncate(securityAnswer, 100);
                referralSource = validationObject.Truncate(referralSource, 900);
                referralName = validationObject.Truncate(referralName, 900);
                RUGAPCEmailAddress = validationObject.Truncate(RUGAPCEmailAddress, 900);

                bool CLIENT_Exists_Counselor;

                string errorMessage20;

                Select selectObject20 = new Select();

                CLIENT_Exists_Counselor = Select.Client_Exists(counselor);

                errorMessage20 = selectObject20.getErrorMessage();

                if (errorMessage20 != null)
                {
                    lblError.Text = errorMessage20;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else if (CLIENT_Exists_Counselor == false)
                {
                    MsgBox("Invalid. The RUG Authorized Personal Counselor (APC) email address does not exist in the system. Please check the spelling of that email address. Thank you.");

                }//end else if

                else if (CLIENT_Exists_Counselor == true)
                {
                    bool BESTPATH_USER_Exists_Counselor;

                    string errorMessage21;

                    Select selectObject21 = new Select();

                    BESTPATH_USER_Exists_Counselor = Select.User_Exists(counselor);

                    errorMessage21 = selectObject21.getErrorMessage();

                    if (errorMessage21 != null)
                    {
                        lblError.Text = errorMessage21;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else if (BESTPATH_USER_Exists_Counselor == false)
                    {
                        MsgBox("Invalid. The RUG Authorized Personal Counselor (APC) email address does not exist in the system. Please check the spelling of that email address. Thank you.");

                    }//end else if

                    else if (BESTPATH_USER_Exists_Counselor == true)
                    {
                        string errorMessage;

                        Select selectObject = new Select();

                        ArrayList counselorData = new ArrayList();

                        counselorData = Select.Select_Counselor_Data(counselor);

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
                            string counselorName = counselorData[0].ToString();

                            string counselorPhoneNumber = counselorData[1].ToString();

                            bool CLIENT_Exists;

                            string errorMessage4;

                            Select selectObject4 = new Select();

                            CLIENT_Exists = Select.Client_Exists(username);

                            errorMessage4 = selectObject4.getErrorMessage();

                            if (errorMessage4 != null)
                            {
                                lblError.Text = errorMessage4;
                                lblError.Visible = true;

                                ErrorMessage message = new ErrorMessage();

                                MsgBox(message.SQLServerErrorMessage);

                            }//end if

                            else if (CLIENT_Exists == true)
                            {
                                MsgBox("Invalid. You have already registered. You may now login with your username and password that you created on this page previously.");

                            }//end else if

                            else if (CLIENT_Exists == false)
                            {
                                bool BESTPATH_USER_Exists;

                                string errorMessage5;

                                Select selectObject5 = new Select();

                                BESTPATH_USER_Exists = Select.User_Exists(username);

                                errorMessage5 = selectObject5.getErrorMessage();

                                if (errorMessage5 != null)
                                {
                                    lblError.Text = errorMessage5;
                                    lblError.Visible = true;

                                    ErrorMessage message = new ErrorMessage();

                                    MsgBox(message.SQLServerErrorMessage);

                                }//end if

                                else if (BESTPATH_USER_Exists == true)
                                {
                                    MsgBox("Invalid. You have already registered. You may now login with your username and password that you created on this page previously.");

                                }//end else if

                                else if (BESTPATH_USER_Exists == false)
                                {
                                    Aes encryptionObject = Aes.Create();

                                    byte[] AesKey = encryptionObject.Key;

                                    byte[] AesIV = encryptionObject.IV;

                                    string AesKeyString = Convert.ToBase64String(AesKey);

                                    string AesIVString = Convert.ToBase64String(AesIV);

                                    byte[] MasterKey = Encryption.GetMasterKey();

                                    byte[] MasterIV = Encryption.GetMasterIV();

                                    byte[] encryptedAesKey = Encryption.Encrypt_AES(AesKeyString, MasterKey, MasterIV);

                                    byte[] encryptedAesIV = Encryption.Encrypt_AES(AesIVString, MasterKey, MasterIV);

                                    string encryptedAesKeyString = Convert.ToBase64String(encryptedAesKey);

                                    string encryptedAesIVString = Convert.ToBase64String(encryptedAesIV);

                                    byte[] encryptedPassword = Encryption.Encrypt_AES(password, AesKey, AesIV);

                                    string encryptedPasswordString = Convert.ToBase64String(encryptedPassword);

                                    byte[] encryptedFirstName = Encryption.Encrypt_AES(firstName, AesKey, AesIV);

                                    string encryptedFirstNameString = Convert.ToBase64String(encryptedFirstName);

                                    byte[] encryptedLastName = Encryption.Encrypt_AES(lastName, AesKey, AesIV);

                                    string encryptedLastNameString = Convert.ToBase64String(encryptedLastName);

                                    byte[] encryptedAge = Encryption.Encrypt_AES(age, AesKey, AesIV);

                                    string encryptedAgeString = Convert.ToBase64String(encryptedAge);

                                    byte[] encryptedStreetAddress = Encryption.Encrypt_AES(streetAddress, AesKey, AesIV);

                                    string encryptedStreetAddressString = Convert.ToBase64String(encryptedStreetAddress);

                                    byte[] encryptedCity = Encryption.Encrypt_AES(city, AesKey, AesIV);

                                    string encryptedCityString = Convert.ToBase64String(encryptedCity);

                                    byte[] encryptedState = Encryption.Encrypt_AES(state, AesKey, AesIV);

                                    string encryptedStateString = Convert.ToBase64String(encryptedState);

                                    byte[] encryptedZipCode = Encryption.Encrypt_AES(zipCode, AesKey, AesIV);

                                    string encryptedZipCodeString = Convert.ToBase64String(encryptedZipCode);

                                    byte[] encryptedCountry = Encryption.Encrypt_AES(country, AesKey, AesIV);

                                    string encryptedCountryString = Convert.ToBase64String(encryptedCountry);

                                    byte[] encryptedPhoneNumber = Encryption.Encrypt_AES(phoneNumber, AesKey, AesIV);

                                    string encryptedPhoneNumberString = Convert.ToBase64String(encryptedPhoneNumber);

                                    byte[] encryptedSecurityQuestion = Encryption.Encrypt_AES(securityQuestion, AesKey, AesIV);

                                    string encryptedSecurityQuestionString = Convert.ToBase64String(encryptedSecurityQuestion);

                                    byte[] encryptedSecurityAnswer = Encryption.Encrypt_AES(securityAnswer, AesKey, AesIV);

                                    string encryptedSecurityAnswerString = Convert.ToBase64String(encryptedSecurityAnswer);

                                    byte[] encryptedRole = Encryption.Encrypt_AES(role, AesKey, AesIV);

                                    string encryptedRoleString = Convert.ToBase64String(encryptedRole);

                                    byte[] encryptedCounselorName = Encryption.Encrypt_AES(counselorName, AesKey, AesIV);

                                    string encryptedCounselorNameString = Convert.ToBase64String(encryptedCounselorName);

                                    string errorMessage7;

                                    errorMessage7 = Insert.Insert_Registration_Transaction(username, encryptedPasswordString, encryptedFirstNameString, encryptedLastNameString, encryptedAgeString, encryptedStreetAddressString, encryptedCityString, encryptedStateString, encryptedZipCodeString, encryptedCountryString, encryptedPhoneNumberString, encryptedAesKeyString, encryptedAesIVString, encryptedRoleString, verified, counselor, encryptedCounselorNameString, dateCreated, numberOfLogins, encryptedSecurityQuestionString, encryptedSecurityAnswerString, referralSource, referralName, RUGAPCEmailAddress);

                                    if (errorMessage7 != null)
                                    {
                                        lblError.Text = errorMessage7;
                                        lblError.Visible = true;

                                        ErrorMessage message = new ErrorMessage();

                                        MsgBox(message.SQLServerErrorMessage);

                                    }//end if

                                    else
                                    {
                                        string urlBase = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath;

                                        string verificationUrl = "PL/Membership/VerifyNewUser.aspx";

                                        string queryString = "?username=" + username;

                                        string fullPath = urlBase + verificationUrl + queryString;

                                        string appPath = Request.PhysicalApplicationPath;

                                        StreamReader sr = new StreamReader(appPath + "SA/Email_Templates/Verification.txt");

                                        string errorMessage8;

                                        errorMessage8 = Email.Email_Verification(username, firstName, fullPath, sr);

                                        if (errorMessage8 != null)
                                        {
                                            lblError.Text = errorMessage8;
                                            lblError.Visible = true;

                                            ErrorMessage message = new ErrorMessage();

                                            MsgBox(message.SQLServerErrorMessage);

                                        }//end if

                                        else
                                        {
                                            StreamReader sr2 = new StreamReader(appPath + "SA/Email_Templates/NewClient.txt");

                                            string date = String.Format(System.DateTime.Today.ToShortDateString());

                                            string errorMessage9;

                                            errorMessage9 = Email.Email_New_Client(date, username, firstName, lastName, phoneNumber, sr2, counselor, counselorName, counselorPhoneNumber);

                                            if (errorMessage9 != null)
                                            {
                                                lblError.Text = errorMessage9;
                                                lblError.Visible = true;

                                                ErrorMessage message = new ErrorMessage();

                                                MsgBox(message.SQLServerErrorMessage);

                                            }//end if

                                            else if(RUGAPCEmailAddress != "")
                                            {
                                                StreamReader sr3 = new StreamReader(appPath + "SA/Email_Templates/PayAPC.txt");

                                                string dateToday = String.Format(System.DateTime.Today.ToShortDateString());

                                                DateTime dateToPay = DateTime.Now.AddDays(4);

                                                string errorMessage40;

                                                errorMessage40 = Email.Email_Pay_APC(dateToday, username, firstName, lastName, phoneNumber, sr3, counselor, counselorName, counselorPhoneNumber, dateToPay);

                                                if (errorMessage40 != null)
                                                {
                                                    lblError.Text = errorMessage40;
                                                    lblError.Visible = true;

                                                    ErrorMessage message = new ErrorMessage();

                                                    MsgBox(message.SQLServerErrorMessage);

                                                }//end if

                                            }//end else

                                            MsgBox("Please check your email to complete the registration process.");

                                        }//end else

                                    }//end else

                                }//end else

                            }//end else

                        }//end else

                    }//end else

                }//end else if

            }//end else if

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