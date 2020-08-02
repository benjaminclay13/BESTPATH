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
    public partial class _Registration2 : Page
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

            TextBox1.Focus();
            
        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            string newPassword = TextBox3.Text;
            string firstName = TextBox5.Text;
            string lastName = TextBox6.Text;
            string DOB = TextBox7.Text;
            string streetAddress = TextBox8.Text;
            string city = TextBox9.Text;
            string state = txtState.Text;
            string zipCode = TextBox10.Text;
            string country = txtCountry.Text;
            string phone = TextBox11.Text;

            username = username.Trim();

            password = password.Trim();

            Validate validationObject = new Validate();

            newPassword = validationObject.Truncate(newPassword, 100);
            firstName = validationObject.Truncate(firstName, 100);
            lastName = validationObject.Truncate(lastName, 100);
            DOB = validationObject.Truncate(DOB, 100);
            streetAddress = validationObject.Truncate(streetAddress, 100);
            city = validationObject.Truncate(city, 100);
            state = validationObject.Truncate(state, 100);
            zipCode = validationObject.Truncate(zipCode, 100);
            country = validationObject.Truncate(country, 100);
            phone = validationObject.Truncate(phone, 100);

            if (PasswordPolicy.IsValid(newPassword) == false)
            {
                MsgBox("Invalid new password. New password must be a strong password.");

            }//end if

            else
            {
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

                }//end if

                else if (authenticated == false)
                {
                    MsgBox("Invalid credentials. Please try again.");

                }//end else if

                else if (authenticated == true)
                {
                    bool clientExists;
                    
                    string _errorMessage;

                    Select _selectObject = new Select();

                    clientExists = Select.Client_Exists(username);

                    _errorMessage = _selectObject.getErrorMessage();

                    if (_errorMessage != null)
                    {
                        lblError.Text = errorMessage;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else if (clientExists == true)
                    {
                        MsgBox("Invalid username. The client with the username you provided has already registered. If the username provided is correct, you may now login using your username and the password you created when you registered previously. Otherwise, please register with your correct username and password.");

                    }//end else if

                    else if (clientExists == false)
                    {
                        Aes encryptionObject = Aes.Create();

                        byte[] AesKey = encryptionObject.Key;

                        byte[] AesIV = encryptionObject.IV;

                        string AesKeyString = Convert.ToBase64String(AesKey);

                        string AesIVString = Convert.ToBase64String(AesIV);

                        byte[] MasterKey = Encryption.GetMasterKey();

                        byte[] MasterIV = Encryption.GetMasterIV();

                        ArrayList roleData = new ArrayList();

                        roleData = Select.Select_Role_Data(username);

                        string encryptedKey = roleData[1].ToString();

                        string encryptedIV = roleData[2].ToString();

                        byte[] encryptedKeyArray = Convert.FromBase64String(encryptedKey);

                        byte[] encryptedIVArray = Convert.FromBase64String(encryptedIV);

                        string decryptedKey = Encryption.Decrypt_AES(encryptedKeyArray, MasterKey, MasterIV);

                        string decryptedIV = Encryption.Decrypt_AES(encryptedIVArray, MasterKey, MasterIV);

                        byte[] decryptedKeyArray = Convert.FromBase64String(decryptedKey);

                        byte[] decryptedIVArray = Convert.FromBase64String(decryptedIV);

                        byte[] encryptedPassword = Encryption.Encrypt_AES(newPassword, decryptedKeyArray, decryptedIVArray);

                        string encryptedPasswordString = Convert.ToBase64String(encryptedPassword);

                        byte[] encryptedAesKey = Encryption.Encrypt_AES(AesKeyString, MasterKey, MasterIV);

                        byte[] encryptedAesIV = Encryption.Encrypt_AES(AesIVString, MasterKey, MasterIV);

                        string encryptedAesKeyString = Convert.ToBase64String(encryptedAesKey);

                        string encryptedAesIVString = Convert.ToBase64String(encryptedAesIV);

                        byte[] encryptedFirstName = Encryption.Encrypt_AES(firstName, AesKey, AesIV);

                        string encryptedFirstNameString = Convert.ToBase64String(encryptedFirstName);

                        byte[] encryptedLastName = Encryption.Encrypt_AES(lastName, AesKey, AesIV);

                        string encryptedLastNameString = Convert.ToBase64String(encryptedLastName);

                        byte[] encryptedDOB = Encryption.Encrypt_AES(DOB, AesKey, AesIV);

                        string encryptedDOBString = Convert.ToBase64String(encryptedDOB);

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

                        byte[] encryptedPhone = Encryption.Encrypt_AES(phone, AesKey, AesIV);

                        string encryptedPhoneString = Convert.ToBase64String(encryptedPhone);

                        string errorMessage2;

                        Insert insertObject = new Insert();

                        errorMessage2 = Insert.Insert_CLIENT(username, encryptedFirstNameString, encryptedLastNameString, encryptedDOBString, encryptedStreetAddressString, encryptedCityString, encryptedStateString, encryptedZipCodeString, encryptedCountryString, encryptedPhoneString, encryptedAesKeyString, encryptedAesIVString);

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

                            Update updateObject = new Update();

                            errorMessage3 = Update.Update_Password(username, encryptedPasswordString);

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

                                errorMessage4 = Update.Update_Verify_New_User(username);

                                errorMessage4 = selectObject.getErrorMessage();

                                if (errorMessage4 != null)
                                {
                                    lblError.Text = errorMessage4;
                                    lblError.Visible = true;

                                    ErrorMessage message = new ErrorMessage();

                                    MsgBox(message.SQLServerErrorMessage);

                                }//end if

                                else
                                {
                                    Session["JustRegistered"] = "true";

                                    Response.Redirect("~/PL/Membership/Login.aspx");

                                }//end else

                            }//end else

                        }//end else

                    }//end else if

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