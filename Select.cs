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
using System.Globalization;

namespace BESTPATH
{
    public class Select
    {
        private DataTable dataTable = new DataTable();

        private DataSet dataSet = new DataSet();

        private static string errorMessage;

        public string getErrorMessage()
        {
            return Select.errorMessage;

        }//end property

        public void setErrorMessage(string ErrorMessage)
        {
            Select.errorMessage = ErrorMessage;

        }//end property

        public Select()
        {
            Select.errorMessage = null;

        }//end constructor

        public static ArrayList Select_BESTPATH_USER_Data2(string Username)
        {
            ArrayList data = new ArrayList();

            string decryptedFirstName = "";

            string decryptedLastName = "";

            string counselor = "";

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string firstName = row["FirstName"].ToString();
                    string lastName = row["LastName"].ToString();
                    counselor = row["Counselor"].ToString();
                    string encryptedKey = row["_Key"].ToString();
                    string encryptedIV = row["_IV"].ToString();

                    byte[] _key = Convert.FromBase64String(encryptedKey);

                    byte[] _IV = Convert.FromBase64String(encryptedIV);

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    string decryptedKey = Encryption.Decrypt_AES(_key, MasterKey, MasterIV);

                    string decryptedIV = Encryption.Decrypt_AES(_IV, MasterKey, MasterIV);

                    byte[] _decryptedKey = Convert.FromBase64String(decryptedKey);

                    byte[] _decryptedIV = Convert.FromBase64String(decryptedIV);

                    string equalSymbol = "=";

                    if (firstName.Contains(equalSymbol))
                    {
                        byte[] encryptedFirstNameArray = Convert.FromBase64String(firstName);

                        decryptedFirstName = Encryption.Decrypt_AES(encryptedFirstNameArray, _decryptedKey, _decryptedIV);

                        byte[] encryptedLastNameArray = Convert.FromBase64String(lastName);

                        decryptedLastName = Encryption.Decrypt_AES(encryptedLastNameArray, _decryptedKey, _decryptedIV);

                    }//end if

                    data.Add(decryptedFirstName);

                    data.Add(decryptedLastName);

                    data.Add(counselor);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return data;

        }//end method

        public static bool Is_User_RUG_APC(string Username)
        {
            bool isRUGAPC = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT IsRUGAPC FROM BESTPATH_USER WHERE Username = @username AND IsRUGAPC = 'Y'";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    isRUGAPC = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return isRUGAPC;

        }//end method

        public static ArrayList Select_Counselor_Data(string Username)
        {
            string counselorName = "";

            ArrayList counselorData = new ArrayList();

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT CLIENT.Username, FirstName, LastName, Phone, CLIENT._Key AS 'CLIENT._Key', CLIENT._IV AS 'CLIENT._IV' FROM CLIENT WHERE CLIENT.Username = @Username;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string encrypted_CLIENT_FirstName = row["FirstName"].ToString();
                    string encrypted_CLIENT_LastName = row["LastName"].ToString();
                    string encrypted_CLIENT_PhoneNumber = row["Phone"].ToString();
                    string encrypted_CLIENT_Key = row["CLIENT._Key"].ToString();
                    string encrypted_CLIENT_IV = row["CLIENT._IV"].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_CLIENT_Key_Array = Convert.FromBase64String(encrypted_CLIENT_Key);

                    byte[] encrypted_CLIENT_IV_Array = Convert.FromBase64String(encrypted_CLIENT_IV);

                    string decrypted_CLIENT_Key = Encryption.Decrypt_AES(encrypted_CLIENT_Key_Array, MasterKey, MasterIV);

                    string decrypted_CLIENT_IV = Encryption.Decrypt_AES(encrypted_CLIENT_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_CLIENT_Key_Array = Convert.FromBase64String(decrypted_CLIENT_Key);

                    byte[] decrypted_CLIENT_IV_Array = Convert.FromBase64String(decrypted_CLIENT_IV);

                    byte[] encrypted_CLIENT_FirstName_Array = Convert.FromBase64String(encrypted_CLIENT_FirstName);

                    byte[] encrypted_CLIENT_LastName_Array = Convert.FromBase64String(encrypted_CLIENT_LastName);

                    byte[] encrypted_CLIENT_PhoneNumber_Array = Convert.FromBase64String(encrypted_CLIENT_PhoneNumber);

                    string decryptedFirstName = Encryption.Decrypt_AES(encrypted_CLIENT_FirstName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedLastName = Encryption.Decrypt_AES(encrypted_CLIENT_LastName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedPhoneNumber = Encryption.Decrypt_AES(encrypted_CLIENT_PhoneNumber_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    counselorName = decryptedLastName + ", " + decryptedFirstName;

                    counselorData.Add(counselorName);

                    counselorData.Add(decryptedPhoneNumber);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return counselorData;

        }//end method

        public static int Select_Admin_Comp_Users()
        {
            int adminCompUsers = 0;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT Username, Role, _Key, _IV FROM BESTPATH_USER";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string encrypted_BESTPATH_USER_Role = row["Role"].ToString();
                    string encrypted_BESTPATH_USER_Key = row["_Key"].ToString();
                    string encrypted_BESTPATH_USER_IV = row["_IV"].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Key);

                    byte[] encrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_IV);

                    string decrypted_BESTPATH_USER_Key = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Key_Array, MasterKey, MasterIV);

                    string decrypted_BESTPATH_USER_IV = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_Key);

                    byte[] decrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_IV);

                    byte[] encrypted_BESTPATH_USER_Role_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Role);

                    string decryptedRole = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Role_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                    if(decryptedRole == "Admin Comp")
                    {
                        adminCompUsers++;

                    }//end if

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return adminCompUsers;

        }//end method

        public static string Select_Test_Users()
        {
            string testUsers = "0";

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT COUNT(Username) AS 'TestUsers' FROM BESTPATH_USER WHERE Username='claypremierconsulting@hotmail.com' OR Username='ben@claypremierconsulting.com'";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    testUsers = row["TestUsers"].ToString();

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return testUsers;

        }//end method

        public static string Select_Total_Number_Of_Users()
        {
            string total = "0";

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT COUNT(Username) AS 'Total' FROM BESTPATH_USER";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    total = row["Total"].ToString();

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return total;

        }//end method

        public static ArrayList Select_COVENANT_PARTNERSHIP_AGREEMENT_Encryption_Keys(string Username)
        {
            ArrayList keys = new ArrayList();

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM COVENANT_PARTNERSHIP_AGREEMENT WHERE EmailAddress = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string _Key = row["_Key"].ToString();
                    string _IV = row["_IV"].ToString();

                    keys.Add(_Key);
                    keys.Add(_IV);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return keys;

        }//end method

        public static bool User_Exists_COVENANT_PARTNERSHIP_AGREEMENT(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM COVENANT_PARTNERSHIP_AGREEMENT WHERE EmailAddress = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static bool Client_Exists_COVENANT_PARTNERSHIP_AGREEMENT(string EmailAddress)
        {
            bool clientExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT EmailAddress FROM COVENANT_PARTNERSHIP_AGREEMENT WHERE EmailAddress = @emailAddress";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    clientExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return clientExists;

        }//end method

        public static ArrayList Select_CAREER_MARKETABILITY_ASSESSMENT_Data(string EmailAddress)
        {
            ArrayList data = new ArrayList();

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM CAREER_MARKETABILITY_ASSESSMENT WHERE EmailAddress = @emailAddress";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string emailAddress = row["EmailAddress"].ToString();
                    string dateCompleted = row["DateCompleted"].ToString();
                    string q1 = row["Q1"].ToString();
                    string q2 = row["Q2"].ToString();
                    string q3 = row["Q3"].ToString();
                    string q4 = row["Q4"].ToString();
                    string q5 = row["Q5"].ToString();
                    string q6 = row["Q6"].ToString();
                    string q7 = row["Q7"].ToString();
                    string q8 = row["Q8"].ToString();
                    string q9 = row["Q9"].ToString();
                    string q10 = row["Q10"].ToString();
                    string q11 = row["Q11"].ToString();
                    string q12 = row["Q12"].ToString();
                    string q13 = row["Q13"].ToString();
                    string q14 = row["Q14"].ToString();
                    string q15 = row["Q15"].ToString();
                    string q16 = row["Q16"].ToString();
                    string q17 = row["Q17"].ToString();
                    string q18 = row["Q18"].ToString();
                    string q19 = row["Q19"].ToString();
                    string q20 = row["Q20"].ToString();
                    string score = row["Score"].ToString();

                    data.Add(emailAddress);
                    data.Add(dateCompleted);
                    data.Add(q1);
                    data.Add(q2);
                    data.Add(q3);
                    data.Add(q4);
                    data.Add(q5);
                    data.Add(q6);
                    data.Add(q7);
                    data.Add(q8);
                    data.Add(q9);
                    data.Add(q10);
                    data.Add(q11);
                    data.Add(q12);
                    data.Add(q13);
                    data.Add(q14);
                    data.Add(q15);
                    data.Add(q16);
                    data.Add(q17);
                    data.Add(q18);
                    data.Add(q19);
                    data.Add(q20);
                    data.Add(score);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return data;

        }//end method

        public static ArrayList Select_PRELIMINARY_NEEDS_ASSESSMENT_Data(string EmailAddress)
        {
            ArrayList data = new ArrayList();

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM PRELIMINARY_NEEDS_ASSESSMENT WHERE EmailAddress = @emailAddress";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string emailAddress = row["EmailAddress"].ToString();
                    string dateCompleted = row["DateCompleted"].ToString();
                    string firstName = row["FirstName"].ToString();
                    string lastName = row["LastName"].ToString();
                    string phoneNumber = row["PhoneNumber"].ToString();
                    string q5 = row["Q5"].ToString();
                    string q6 = row["Q6"].ToString();
                    string q7 = row["Q7"].ToString();
                    string q8 = row["Q8"].ToString();
                    string q9 = row["Q9"].ToString();
                    string q10 = row["Q10"].ToString();
                    string q11 = row["Q11"].ToString();
                    string q12 = row["Q12"].ToString();
                    string q13 = row["Q13"].ToString();
                    string q14 = row["Q14"].ToString();
                    string q15 = row["Q15"].ToString();
                    string q16 = row["Q16"].ToString();
                    string q17 = row["Q17"].ToString();
                    string q18 = row["Q18"].ToString();
                    string q19 = row["Q19"].ToString();
                    string q20 = row["Q20"].ToString();
                    string q21 = row["Q21"].ToString();
                    string q22 = row["Q22"].ToString();
                    string q23 = row["Q23"].ToString();
                    string q24 = row["Q24"].ToString();
                    string q25 = row["Q25"].ToString();
                    string q26 = row["Q26"].ToString();
                    string q27 = row["Q27"].ToString();
                    string q28 = row["Q28"].ToString();
                    string q29 = row["Q29"].ToString();
                    string q30 = row["Q30"].ToString();
                    string q31 = row["Q31"].ToString();
                    string q32 = row["Q32"].ToString();
                    string q33 = row["Q33"].ToString();
                    string q34 = row["Q34"].ToString();
                    string q35 = row["Q35"].ToString();
                    string q36 = row["Q36"].ToString();
                    string q37 = row["Q37"].ToString();
                    string q38 = row["Q38"].ToString();
                    string q39 = row["Q39"].ToString();
                    string q40 = row["Q40"].ToString();
                    string q41 = row["Q41"].ToString();
                    string q42 = row["Q42"].ToString();
                    string q43 = row["Q43"].ToString();
                    string q44 = row["Q44"].ToString();
                    string q45 = row["Q45"].ToString();
                    string q46 = row["Q46"].ToString();
                    string referralSource = row["ReferralSource"].ToString();
                    string referralName = row["ReferralName"].ToString();
                    string RUGAPCEmailAddress = row["RUGAPCEmailAddress"].ToString();

                    data.Add(emailAddress);
                    data.Add(dateCompleted);
                    data.Add(firstName);
                    data.Add(lastName);
                    data.Add(phoneNumber);
                    data.Add(q5);
                    data.Add(q6);
                    data.Add(q7);
                    data.Add(q8);
                    data.Add(q9);
                    data.Add(q10);
                    data.Add(q11);
                    data.Add(q12);
                    data.Add(q13);
                    data.Add(q14);
                    data.Add(q15);
                    data.Add(q16);
                    data.Add(q17);
                    data.Add(q18);
                    data.Add(q19);
                    data.Add(q20);
                    data.Add(q21);
                    data.Add(q22);
                    data.Add(q23);
                    data.Add(q24);
                    data.Add(q25);
                    data.Add(q26);
                    data.Add(q27);
                    data.Add(q28);
                    data.Add(q29);
                    data.Add(q30);
                    data.Add(q31);
                    data.Add(q32);
                    data.Add(q33);
                    data.Add(q34);
                    data.Add(q35);
                    data.Add(q36);
                    data.Add(q37);
                    data.Add(q38);
                    data.Add(q39);
                    data.Add(q40);
                    data.Add(q41);
                    data.Add(q42);
                    data.Add(q43);
                    data.Add(q44);
                    data.Add(q45);
                    data.Add(q46);
                    data.Add(referralSource);
                    data.Add(referralName);
                    data.Add(RUGAPCEmailAddress);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return data;

        }//end method

        public static DataTable Select_Career_Marketability_Assessments()
        {
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT FirstName AS 'First Name', LastName AS 'Last Name', EmailAddress AS 'Email Address', PhoneNumber AS 'Phone Number', DateCompleted AS 'Date Completed' FROM CAREER_MARKETABILITY_ASSESSMENT ORDER BY DateCompleted DESC;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return selectObject.dataTable;

        }//end method

        public static DataTable Select_Preliminary_Needs_Assessments()
        {
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT FirstName AS 'First Name', LastName AS 'Last Name', EmailAddress AS 'Email Address', PhoneNumber AS 'Phone Number', DateCompleted AS 'Date Completed' FROM PRELIMINARY_NEEDS_ASSESSMENT ORDER BY DateCompleted DESC;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return selectObject.dataTable;

        }//end method

        public static bool Career_Marketability_Assessment_Exists(string EmailAddress)
        {
            bool careerMarketabilityAssessmentExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM CAREER_MARKETABILITY_ASSESSMENT WHERE EmailAddress = @emailAddress";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    careerMarketabilityAssessmentExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return careerMarketabilityAssessmentExists;

        }//end method

        public static bool Preliminary_Needs_Assessment_Exists(string EmailAddress)
        {
            bool preliminaryNeedsAssessmentExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM PRELIMINARY_NEEDS_ASSESSMENT WHERE EmailAddress = @emailAddress";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    preliminaryNeedsAssessmentExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return preliminaryNeedsAssessmentExists;

        }//end method

        public static string Select_Client_Phone_Number(string Username)
        {
            string clientPhoneNumber = "";

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT Phone, _Key, _IV FROM CLIENT WHERE Username = @Username;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string encrypted_CLIENT_PhoneNumber = row["Phone"].ToString();
                    string encrypted_CLIENT_Key = row["_Key"].ToString();
                    string encrypted_CLIENT_IV = row["_IV"].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_CLIENT_Key_Array = Convert.FromBase64String(encrypted_CLIENT_Key);

                    byte[] encrypted_CLIENT_IV_Array = Convert.FromBase64String(encrypted_CLIENT_IV);

                    string decrypted_CLIENT_Key = Encryption.Decrypt_AES(encrypted_CLIENT_Key_Array, MasterKey, MasterIV);

                    string decrypted_CLIENT_IV = Encryption.Decrypt_AES(encrypted_CLIENT_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_CLIENT_Key_Array = Convert.FromBase64String(decrypted_CLIENT_Key);

                    byte[] decrypted_CLIENT_IV_Array = Convert.FromBase64String(decrypted_CLIENT_IV);

                    byte[] encrypted_CLIENT_PhoneNumber_Array = Convert.FromBase64String(encrypted_CLIENT_PhoneNumber);

                    string decryptedPhoneNumber = Encryption.Decrypt_AES(encrypted_CLIENT_PhoneNumber_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    clientPhoneNumber = decryptedPhoneNumber;

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return clientPhoneNumber;

        }//end method

        public static DataTable Select_Counselor_Client_Information(string CounselorUsername, string ClientUsername)
        {
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT CLIENT.Username AS 'Username', Password, CLIENT.FirstName AS 'First name', CLIENT.LastName AS 'Last name', DOB AS 'Date of birth', StreetAddress AS 'Street address', City, State, ZipCode AS 'Zip code', Country, Phone AS 'Phone number', Role, Verified AS 'Registered', Counselor, CounselorName AS 'Counselor name', DateCreated AS 'Date created', DateOfLastLogin AS 'Date of last login', NumberOfLogins AS 'Number of logins', Overview, Introduction, ResourcesProvided AS 'Resources Provided', BeforeYouBegin AS 'Before You Begin', NaturalTalents AS 'Natural Talents', PerceptionResponse AS 'Perception Response', IdentifyingSpiritualGifts AS 'Identifying Your Spiritual Gifts', FocusAnalysisWorksheet AS 'FOCUS Analysis Worksheet', FocusDemonstrationWorksheet AS 'FOCUS Demonstration Worksheet', WaysToEvaluateYourEffect AS 'Ways To Evaluate Your Effect', FocusSample1 AS 'FOCUS Sample #1', FocusSample2 AS 'FOCUS Sample #2', FocusExperience1 AS 'FOCUS Experience #1', FocusExperience2 AS 'FOCUS Experience #2', FocusExperience3 AS 'FOCUS Experience #3', FocusExperience4 AS 'FOCUS Experience #4', FocusExperience5 AS 'FOCUS Experience #5', FocusExperience6 AS 'FOCUS Experience #6', FocusExperience7 AS 'FOCUS Experience #7', FocusExperience8 AS 'FOCUS Experience #8', PersonalManagementStyle AS 'Personal Management Style', FundamentalLifeMotivators AS 'Fundamental Life Motivators', EducationTrainingInventory AS 'Education/Training Inventory', PracticalSkills AS 'Practical Skills', ExpressingYourPersonalGenius AS 'Expressing Your Personal Genius', CreativityCycle AS 'Creativity Cycle', PerceptionResponseSummary AS 'Perception Response Summary', TotalSpiritualGifts AS 'Total Spiritual Gifts', FocusConsolidationWorksheet AS 'FOCUS Consolidation Worksheet', Congratulations AS 'Congratulations!', MarketingDocumentsCreation AS 'Marketing Documents Creation' FROM CLIENT INNER JOIN BESTPATH_USER ON CLIENT.Username = BESTPATH_USER.Username INNER JOIN BESTPATH_STATUS ON BESTPATH_USER.Username = BESTPATH_STATUS.BESTPATH_USER_Username WHERE BESTPATH_USER.Counselor = @counselorUsername AND CLIENT.Username = @clientUsername AND CLIENT.Username <> 'admin@bestpathfoundation.com' AND CLIENT.Username <> 'jdworktoworship@yahoo.com' AND CLIENT.Username <> 'clay.1@osu.edu'";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@counselorUsername", SqlDbType.VarChar).Value = CounselorUsername;

            da.SelectCommand.Parameters.Add("@clientUsername", SqlDbType.VarChar).Value = ClientUsername;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string username = row["Username"].ToString();

                    string encrypted_CLIENT_FirstName = row["First name"].ToString();
                    string encrypted_CLIENT_LastName = row["Last name"].ToString();
                    string encrypted_CLIENT_DOB = row["Date of birth"].ToString();
                    string encrypted_CLIENT_StreetAddress = row["Street address"].ToString();
                    string encrypted_CLIENT_City = row["City"].ToString();
                    string encrypted_CLIENT_State = row["State"].ToString();
                    string encrypted_CLIENT_ZipCode = row["Zip code"].ToString();
                    string encrypted_CLIENT_Country = row["Country"].ToString();
                    string encrypted_CLIENT_Phone = row["Phone number"].ToString();

                    string encrypted_BESTPATH_USER_Password = row["Password"].ToString();
                    string encrypted_BESTPATH_USER_Role = row["Role"].ToString();
                    string encrypted_BESTPATH_USER_CounselorName = row["Counselor name"].ToString();

                    ArrayList clientKeys = new ArrayList();
                    ArrayList bestPathUserKeys = new ArrayList();

                    clientKeys = Select.Select_CLIENT_Encryption_Keys(username);

                    string encrypted_CLIENT_Key = clientKeys[0].ToString();
                    string encrypted_CLIENT_IV = clientKeys[1].ToString();

                    bestPathUserKeys = Select.Select_BESTPATH_USER_Encryption_Keys(username);

                    string encrypted_BESTPATH_USER_Key = bestPathUserKeys[0].ToString();
                    string encrypted_BESTPATH_USER_IV = bestPathUserKeys[1].ToString();


                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_CLIENT_Key_Array = Convert.FromBase64String(encrypted_CLIENT_Key);

                    byte[] encrypted_CLIENT_IV_Array = Convert.FromBase64String(encrypted_CLIENT_IV);

                    string decrypted_CLIENT_Key = Encryption.Decrypt_AES(encrypted_CLIENT_Key_Array, MasterKey, MasterIV);

                    string decrypted_CLIENT_IV = Encryption.Decrypt_AES(encrypted_CLIENT_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_CLIENT_Key_Array = Convert.FromBase64String(decrypted_CLIENT_Key);

                    byte[] decrypted_CLIENT_IV_Array = Convert.FromBase64String(decrypted_CLIENT_IV);

                    byte[] encrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Key);

                    byte[] encrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_IV);

                    string decrypted_BESTPATH_USER_Key = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Key_Array, MasterKey, MasterIV);

                    string decrypted_BESTPATH_USER_IV = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_Key);

                    byte[] decrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_IV);

                    byte[] encrypted_BESTPATH_USER_Password_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Password);

                    byte[] encrypted_CLIENT_FirstName_Array = Convert.FromBase64String(encrypted_CLIENT_FirstName);

                    byte[] encrypted_CLIENT_LastName_Array = Convert.FromBase64String(encrypted_CLIENT_LastName);

                    byte[] encrypted_CLIENT_DOB_Array = Convert.FromBase64String(encrypted_CLIENT_DOB);

                    byte[] encrypted_CLIENT_StreetAddress_Array = Convert.FromBase64String(encrypted_CLIENT_StreetAddress);

                    byte[] encrypted_CLIENT_City_Array = Convert.FromBase64String(encrypted_CLIENT_City);

                    byte[] encrypted_CLIENT_State_Array = Convert.FromBase64String(encrypted_CLIENT_State);

                    byte[] encrypted_CLIENT_ZipCode_Array = Convert.FromBase64String(encrypted_CLIENT_ZipCode);

                    byte[] encrypted_CLIENT_Phone_Array = Convert.FromBase64String(encrypted_CLIENT_Phone);

                    byte[] encrypted_BESTPATH_USER_Role_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Role);

                    byte[] encrypted_BESTPATH_USER_CounselorName_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_CounselorName);

                    string decryptedPassword = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Password_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                    string decryptedFirstName = Encryption.Decrypt_AES(encrypted_CLIENT_FirstName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedLastName = Encryption.Decrypt_AES(encrypted_CLIENT_LastName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedDOB = Encryption.Decrypt_AES(encrypted_CLIENT_DOB_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedStreetAddress = Encryption.Decrypt_AES(encrypted_CLIENT_StreetAddress_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedCity = Encryption.Decrypt_AES(encrypted_CLIENT_City_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedState = Encryption.Decrypt_AES(encrypted_CLIENT_State_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedZipCode = Encryption.Decrypt_AES(encrypted_CLIENT_ZipCode_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedPhone = Encryption.Decrypt_AES(encrypted_CLIENT_Phone_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedRole = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Role_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                    string decryptedCounselorName = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_CounselorName_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);


                    string decryptedCountry = "";

                    if (encrypted_CLIENT_Country != "0")
                    {
                        byte[] encrypted_CLIENT_Country_Array = Convert.FromBase64String(encrypted_CLIENT_Country);

                        decryptedCountry = Encryption.Decrypt_AES(encrypted_CLIENT_Country_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    }//end if

                    selectObject.dataTable.Rows[0][1] = decryptedPassword;

                    selectObject.dataTable.Rows[0][2] = decryptedFirstName;

                    selectObject.dataTable.Rows[0][3] = decryptedLastName;

                    selectObject.dataTable.Rows[0][4] = decryptedDOB;

                    selectObject.dataTable.Rows[0][5] = decryptedStreetAddress;

                    selectObject.dataTable.Rows[0][6] = decryptedCity;

                    selectObject.dataTable.Rows[0][7] = decryptedState;

                    selectObject.dataTable.Rows[0][8] = decryptedZipCode;

                    selectObject.dataTable.Rows[0][9] = decryptedCountry;

                    selectObject.dataTable.Rows[0][10] = decryptedPhone;

                    selectObject.dataTable.Rows[0][11] = decryptedRole;

                    selectObject.dataTable.Rows[0][14] = decryptedCounselorName;


                    string dateCreated = row["Date created"].ToString();
                    string dateOfLastLogin = row["Date of last login"].ToString();
                    string overview = row["Overview"].ToString();
                    string introduction = row["Introduction"].ToString();
                    string resourcesProvided = row["Resources Provided"].ToString();
                    string beforeYouBegin = row["Before You Begin"].ToString();
                    string naturalTalents = row["Natural Talents"].ToString();
                    string perceptionResponse = row["Perception Response"].ToString();
                    string identifyingSpiritualGifts = row["Identifying Your Spiritual Gifts"].ToString();
                    string focusAnalysisWorksheet = row["FOCUS Analysis Worksheet"].ToString();
                    string focusDemonstrationWorksheet = row["FOCUS Demonstration Worksheet"].ToString();
                    string waysToEvaluateYourEffect = row["Ways To Evaluate Your Effect"].ToString();
                    string focusSample1 = row["FOCUS Sample #1"].ToString();
                    string focusSample2 = row["FOCUS Sample #2"].ToString();
                    string focusExperience1 = row["FOCUS Experience #1"].ToString();
                    string focusExperience2 = row["FOCUS Experience #2"].ToString();
                    string focusExperience3 = row["FOCUS Experience #3"].ToString();
                    string focusExperience4 = row["FOCUS Experience #4"].ToString();
                    string focusExperience5 = row["FOCUS Experience #5"].ToString();
                    string focusExperience6 = row["FOCUS Experience #6"].ToString();
                    string focusExperience7 = row["FOCUS Experience #7"].ToString();
                    string focusExperience8 = row["FOCUS Experience #8"].ToString();
                    string personalManagementStyle = row["Personal Management Style"].ToString();
                    string fundamentalLifeMotivators = row["Fundamental Life Motivators"].ToString();
                    string educationTrainingInventory = row["Education/Training Inventory"].ToString();
                    string practicalSkills = row["Practical Skills"].ToString();
                    string expressingYourPersonalGenius = row["Expressing Your Personal Genius"].ToString();
                    string creativityCycle = row["Creativity Cycle"].ToString();
                    string perceptionResponseSummary = row["Perception Response Summary"].ToString();
                    string totalSpiritualGifts = row["Total Spiritual Gifts"].ToString();
                    string focusConsolidationWorksheet = row["FOCUS Consolidation Worksheet"].ToString();
                    string congratulations = row["Congratulations!"].ToString();
                    string marketingDocumentsCreation = row["Marketing Documents Creation"].ToString();

                    DateTime checkVar;

                    DateTime _decryptedDOB, _dateCreated, _dateOfLastLogin, _overview, _introduction, _resourcesProvided, _beforeYouBegin, _naturalTalents, _perceptionResponse, _identifyingSpiritualGifts, _focusAnalysisWorksheet, _focusDemonstrationWorksheet, _waysToEvaluateYourEffect, _focusSample1, _focusSample2, _focusExperience1, _focusExperience2, _focusExperience3, _focusExperience4, _focusExperience5, _focusExperience6, _focusExperience7, _focusExperience8, _personalManagementStyle, _fundamentalLifeMotivators, _educationTrainingInventory, _practicalSkills, _expressingYourPersonalGenius, _creativityCycle, _perceptionResponseSummary, _totalSpiritualGifts, _focusConsolidationWorksheet, _congratulations, _marketingDocumentsCreation;

                    CultureInfo provider = CultureInfo.InvariantCulture;

                    checkVar = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _decryptedDOB = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _dateCreated = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _dateOfLastLogin = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _overview = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _introduction = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _resourcesProvided = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _beforeYouBegin = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _naturalTalents = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _perceptionResponse = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _identifyingSpiritualGifts = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusAnalysisWorksheet = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusDemonstrationWorksheet = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _waysToEvaluateYourEffect = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusSample1 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusSample2 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience1 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience2 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience3 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience4 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience5 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience6 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience7 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience8 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _personalManagementStyle = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _fundamentalLifeMotivators = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _educationTrainingInventory = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _practicalSkills = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _expressingYourPersonalGenius = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _creativityCycle = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _perceptionResponseSummary = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _totalSpiritualGifts = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusConsolidationWorksheet = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _congratulations = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _marketingDocumentsCreation = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    int _DOB;

                    Int32.TryParse(decryptedDOB, out _DOB);

                    if (_DOB != 0)
                    {
                        string[] formats = { "MMddyyyy", "MM/dd/yy" };
                        DateTime.TryParseExact(decryptedDOB, formats, CultureInfo.CurrentCulture, DateTimeStyles.None, out _decryptedDOB);

                        if (_decryptedDOB != checkVar)
                        {
                            decryptedDOB = _decryptedDOB.ToShortDateString();

                        }//end if

                    }//end if

                    else
                    {
                        DateTime.TryParse(decryptedDOB, out _decryptedDOB);

                        if (_decryptedDOB != checkVar)
                        {
                            decryptedDOB = _decryptedDOB.ToShortDateString();

                        }//end if

                    }//end else

                    DateTime.TryParse(dateCreated, out _dateCreated);

                    if (_dateCreated != checkVar)
                    {
                        dateCreated = _dateCreated.ToShortDateString();

                    }//end if

                    DateTime.TryParse(dateOfLastLogin, out _dateOfLastLogin);

                    if (_dateOfLastLogin != checkVar)
                    {
                        dateOfLastLogin = _dateOfLastLogin.ToShortDateString();

                    }//end if

                    if ((dateOfLastLogin == "") || (dateOfLastLogin == null))
                    {
                        dateOfLastLogin = "Never";

                    }//end else

                    DateTime.TryParse(overview, out _overview);

                    if (_overview != checkVar)
                    {
                        overview = _overview.ToShortDateString();

                    }//end if

                    DateTime.TryParse(introduction, out _introduction);

                    if (_introduction != checkVar)
                    {
                        introduction = _introduction.ToShortDateString();

                    }//end if

                    DateTime.TryParse(resourcesProvided, out _resourcesProvided);

                    if (_resourcesProvided != checkVar)
                    {
                        resourcesProvided = _resourcesProvided.ToShortDateString();

                    }//end if

                    DateTime.TryParse(beforeYouBegin, out _beforeYouBegin);

                    if (_beforeYouBegin != checkVar)
                    {
                        beforeYouBegin = _beforeYouBegin.ToShortDateString();

                    }//end if

                    DateTime.TryParse(naturalTalents, out _naturalTalents);

                    if (_naturalTalents != checkVar)
                    {
                        naturalTalents = _naturalTalents.ToShortDateString();

                    }//end if

                    DateTime.TryParse(perceptionResponse, out _perceptionResponse);

                    if (_perceptionResponse != checkVar)
                    {
                        perceptionResponse = _perceptionResponse.ToShortDateString();

                    }//end if

                    DateTime.TryParse(identifyingSpiritualGifts, out _identifyingSpiritualGifts);

                    if (_identifyingSpiritualGifts != checkVar)
                    {
                        identifyingSpiritualGifts = _identifyingSpiritualGifts.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusAnalysisWorksheet, out _focusAnalysisWorksheet);

                    if (_focusAnalysisWorksheet != checkVar)
                    {
                        focusAnalysisWorksheet = _focusAnalysisWorksheet.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusDemonstrationWorksheet, out _focusDemonstrationWorksheet);

                    if (_focusDemonstrationWorksheet != checkVar)
                    {
                        focusDemonstrationWorksheet = _focusDemonstrationWorksheet.ToShortDateString();

                    }//end if

                    DateTime.TryParse(waysToEvaluateYourEffect, out _waysToEvaluateYourEffect);

                    if (_waysToEvaluateYourEffect != checkVar)
                    {
                        waysToEvaluateYourEffect = _waysToEvaluateYourEffect.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusSample1, out _focusSample1);

                    if (_focusSample1 != checkVar)
                    {
                        focusSample1 = _focusSample1.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusSample2, out _focusSample2);

                    if (_focusSample2 != checkVar)
                    {
                        focusSample2 = _focusSample2.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience1, out _focusExperience1);

                    if (_focusExperience1 != checkVar)
                    {
                        focusExperience1 = _focusExperience1.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience2, out _focusExperience2);

                    if (_focusExperience2 != checkVar)
                    {
                        focusExperience2 = _focusExperience2.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience3, out _focusExperience3);

                    if (_focusExperience3 != checkVar)
                    {
                        focusExperience3 = _focusExperience3.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience4, out _focusExperience4);

                    if (_focusExperience4 != checkVar)
                    {
                        focusExperience4 = _focusExperience4.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience5, out _focusExperience5);

                    if (_focusExperience5 != checkVar)
                    {
                        focusExperience5 = _focusExperience5.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience6, out _focusExperience6);

                    if (_focusExperience6 != checkVar)
                    {
                        focusExperience6 = _focusExperience6.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience7, out _focusExperience7);

                    if (_focusExperience7 != checkVar)
                    {
                        focusExperience7 = _focusExperience7.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience8, out _focusExperience8);

                    if (_focusExperience8 != checkVar)
                    {
                        focusExperience8 = _focusExperience8.ToShortDateString();

                    }//end if

                    DateTime.TryParse(personalManagementStyle, out _personalManagementStyle);

                    if (_personalManagementStyle != checkVar)
                    {
                        personalManagementStyle = _personalManagementStyle.ToShortDateString();

                    }//end if

                    DateTime.TryParse(fundamentalLifeMotivators, out _fundamentalLifeMotivators);

                    if (_fundamentalLifeMotivators != checkVar)
                    {
                        fundamentalLifeMotivators = _fundamentalLifeMotivators.ToShortDateString();

                    }//end if

                    DateTime.TryParse(educationTrainingInventory, out _educationTrainingInventory);

                    if (_educationTrainingInventory != checkVar)
                    {
                        educationTrainingInventory = _educationTrainingInventory.ToShortDateString();

                    }//end if

                    DateTime.TryParse(practicalSkills, out _practicalSkills);

                    if (_practicalSkills != checkVar)
                    {
                        practicalSkills = _practicalSkills.ToShortDateString();

                    }//end if

                    DateTime.TryParse(expressingYourPersonalGenius, out _expressingYourPersonalGenius);

                    if (_expressingYourPersonalGenius != checkVar)
                    {
                        expressingYourPersonalGenius = _expressingYourPersonalGenius.ToShortDateString();

                    }//end if

                    DateTime.TryParse(creativityCycle, out _creativityCycle);

                    if (_creativityCycle != checkVar)
                    {
                        creativityCycle = _creativityCycle.ToShortDateString();

                    }//end if

                    DateTime.TryParse(perceptionResponseSummary, out _perceptionResponseSummary);

                    if (_perceptionResponseSummary != checkVar)
                    {
                        perceptionResponseSummary = _perceptionResponseSummary.ToShortDateString();

                    }//end if

                    DateTime.TryParse(totalSpiritualGifts, out _totalSpiritualGifts);

                    if (_totalSpiritualGifts != checkVar)
                    {
                        totalSpiritualGifts = _totalSpiritualGifts.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusConsolidationWorksheet, out _focusConsolidationWorksheet);

                    if (_focusConsolidationWorksheet != checkVar)
                    {
                        focusConsolidationWorksheet = _focusConsolidationWorksheet.ToShortDateString();

                    }//end if

                    DateTime.TryParse(congratulations, out _congratulations);

                    if (_congratulations != checkVar)
                    {
                        congratulations = _congratulations.ToShortDateString();

                    }//end if

                    DateTime.TryParse(marketingDocumentsCreation, out _marketingDocumentsCreation);

                    if (_marketingDocumentsCreation != checkVar)
                    {
                        marketingDocumentsCreation = _marketingDocumentsCreation.ToShortDateString();

                    }//end if

                    selectObject.dataTable.Rows[0][4] = decryptedDOB;

                    selectObject.dataTable.Rows[0][15] = dateCreated;

                    selectObject.dataTable.Rows[0][16] = dateOfLastLogin;

                    selectObject.dataTable.Rows[0][18] = overview;

                    selectObject.dataTable.Rows[0][19] = introduction;

                    selectObject.dataTable.Rows[0][20] = resourcesProvided;

                    selectObject.dataTable.Rows[0][21] = beforeYouBegin;

                    selectObject.dataTable.Rows[0][22] = naturalTalents;

                    selectObject.dataTable.Rows[0][23] = perceptionResponse;

                    selectObject.dataTable.Rows[0][24] = identifyingSpiritualGifts;

                    selectObject.dataTable.Rows[0][25] = focusAnalysisWorksheet;

                    selectObject.dataTable.Rows[0][26] = focusDemonstrationWorksheet;

                    selectObject.dataTable.Rows[0][27] = waysToEvaluateYourEffect;

                    selectObject.dataTable.Rows[0][28] = focusSample1;

                    selectObject.dataTable.Rows[0][29] = focusSample2;

                    selectObject.dataTable.Rows[0][30] = focusExperience1;

                    selectObject.dataTable.Rows[0][31] = focusExperience2;

                    selectObject.dataTable.Rows[0][32] = focusExperience3;

                    selectObject.dataTable.Rows[0][33] = focusExperience4;

                    selectObject.dataTable.Rows[0][34] = focusExperience5;

                    selectObject.dataTable.Rows[0][35] = focusExperience6;

                    selectObject.dataTable.Rows[0][36] = focusExperience7;

                    selectObject.dataTable.Rows[0][37] = focusExperience8;

                    selectObject.dataTable.Rows[0][38] = personalManagementStyle;

                    selectObject.dataTable.Rows[0][39] = fundamentalLifeMotivators;

                    selectObject.dataTable.Rows[0][40] = educationTrainingInventory;

                    selectObject.dataTable.Rows[0][41] = practicalSkills;

                    selectObject.dataTable.Rows[0][42] = expressingYourPersonalGenius;

                    selectObject.dataTable.Rows[0][43] = creativityCycle;

                    selectObject.dataTable.Rows[0][44] = perceptionResponseSummary;

                    selectObject.dataTable.Rows[0][45] = totalSpiritualGifts;

                    selectObject.dataTable.Rows[0][46] = focusConsolidationWorksheet;

                    selectObject.dataTable.Rows[0][47] = congratulations;

                    selectObject.dataTable.Rows[0][48] = marketingDocumentsCreation;

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return selectObject.dataTable;

        }//end method

        public static DataTable Select_Counselor_Client_Information(string CounselorUsername)
        {
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT FirstName AS 'First name', LastName AS 'Last name', Username, Verified AS 'Registered', DateCreated AS 'Date created', DateOfLastLogin AS 'Date of last login', NumberOfLogins AS 'Number of logins' FROM BESTPATH_USER WHERE Counselor = @counselorUsername AND Username <> 'admin@bestpathfoundation.com' AND Username <> 'jdworktoworship@yahoo.com' AND Username <> 'clay.1@osu.edu'";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@counselorUsername", SqlDbType.VarChar).Value = CounselorUsername;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string username = row["Username"].ToString();

                    string firstName = row["First name"].ToString();
                    string lastName = row["Last name"].ToString();
                    string dateCreated = row["Date created"].ToString();
                    string dateOfLastLogin = row["Date of last login"].ToString();

                    DateTime _dateCreated, _dateOfLastLogin, checkVar;

                    CultureInfo provider = CultureInfo.InvariantCulture;

                    _dateCreated = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _dateOfLastLogin = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    checkVar = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    DateTime.TryParse(dateCreated, out _dateCreated);

                    DateTime.TryParse(dateOfLastLogin, out _dateOfLastLogin);

                    if ((dateOfLastLogin == "") || (dateOfLastLogin == null))
                    {
                        dateOfLastLogin = "Never";

                    }//end else

                    if (_dateCreated != checkVar)
                    {
                        dateCreated = _dateCreated.ToShortDateString();

                    }//end if

                    if (_dateOfLastLogin != checkVar)
                    {
                        dateOfLastLogin = _dateOfLastLogin.ToShortDateString();

                    }//end if

                    ArrayList bestPathUserKeys = new ArrayList();

                    bestPathUserKeys = Select.Select_BESTPATH_USER_Encryption_Keys(username);

                    string encrypted_BESTPATH_USER_Key = bestPathUserKeys[0].ToString();
                    string encrypted_BESTPATH_USER_IV = bestPathUserKeys[1].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Key);

                    byte[] encrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_IV);

                    string decrypted_BESTPATH_USER_Key = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Key_Array, MasterKey, MasterIV);

                    string decrypted_BESTPATH_USER_IV = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_Key);

                    byte[] decrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_IV);

                    byte[] encrypted_BESTPATH_USER_FirstName_Array = Convert.FromBase64String(firstName);

                    byte[] encrypted_BESTPATH_USER_LastName_Array = Convert.FromBase64String(lastName);

                    string decryptedFirstName = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_FirstName_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                    string decryptedLastName = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_LastName_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                    row["First name"] = decryptedFirstName;

                    row["Last name"] = decryptedLastName;

                    row["Date created"] = dateCreated;

                    row["Date of last login"] = dateOfLastLogin;

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return selectObject.dataTable;

        }//end method

        public static ArrayList Select_Client_Name_BESTPATH_USER(string Username)
        {
            ArrayList clientName = new ArrayList();

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT FirstName, LastName FROM BESTPATH_USER WHERE Username = @username;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string firstName = row["FirstName"].ToString();
                    string lastName = row["LastName"].ToString();

                    clientName.Add(firstName);
                    clientName.Add(lastName);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return clientName;

        }//end method

        public static string Select_Counselor_Name(string Username)
        {
            string counselorName = "";

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT CLIENT.Username, FirstName, LastName, CLIENT._Key AS 'CLIENT._Key', CLIENT._IV AS 'CLIENT._IV' FROM CLIENT WHERE CLIENT.Username = @Username;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string encrypted_CLIENT_FirstName = row["FirstName"].ToString();
                    string encrypted_CLIENT_LastName = row["LastName"].ToString();
                    string encrypted_CLIENT_Key = row["CLIENT._Key"].ToString();
                    string encrypted_CLIENT_IV = row["CLIENT._IV"].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_CLIENT_Key_Array = Convert.FromBase64String(encrypted_CLIENT_Key);

                    byte[] encrypted_CLIENT_IV_Array = Convert.FromBase64String(encrypted_CLIENT_IV);

                    string decrypted_CLIENT_Key = Encryption.Decrypt_AES(encrypted_CLIENT_Key_Array, MasterKey, MasterIV);

                    string decrypted_CLIENT_IV = Encryption.Decrypt_AES(encrypted_CLIENT_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_CLIENT_Key_Array = Convert.FromBase64String(decrypted_CLIENT_Key);

                    byte[] decrypted_CLIENT_IV_Array = Convert.FromBase64String(decrypted_CLIENT_IV);

                    byte[] encrypted_CLIENT_FirstName_Array = Convert.FromBase64String(encrypted_CLIENT_FirstName);

                    byte[] encrypted_CLIENT_LastName_Array = Convert.FromBase64String(encrypted_CLIENT_LastName);

                    string decryptedFirstName = Encryption.Decrypt_AES(encrypted_CLIENT_FirstName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedLastName = Encryption.Decrypt_AES(encrypted_CLIENT_LastName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    counselorName = decryptedLastName + ", " + decryptedFirstName;

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return counselorName;

        }//end method

        public static string Select_Client_FirstName(string Username)
        {
            string clientFirstName = "";

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT CLIENT.Username, FirstName, CLIENT._Key AS 'CLIENT._Key', CLIENT._IV AS 'CLIENT._IV' FROM CLIENT WHERE CLIENT.Username = @Username;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string encrypted_CLIENT_FirstName = row["FirstName"].ToString();
                    string encrypted_CLIENT_Key = row["CLIENT._Key"].ToString();
                    string encrypted_CLIENT_IV = row["CLIENT._IV"].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_CLIENT_Key_Array = Convert.FromBase64String(encrypted_CLIENT_Key);

                    byte[] encrypted_CLIENT_IV_Array = Convert.FromBase64String(encrypted_CLIENT_IV);

                    string decrypted_CLIENT_Key = Encryption.Decrypt_AES(encrypted_CLIENT_Key_Array, MasterKey, MasterIV);

                    string decrypted_CLIENT_IV = Encryption.Decrypt_AES(encrypted_CLIENT_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_CLIENT_Key_Array = Convert.FromBase64String(decrypted_CLIENT_Key);

                    byte[] decrypted_CLIENT_IV_Array = Convert.FromBase64String(decrypted_CLIENT_IV);

                    byte[] encrypted_CLIENT_FirstName_Array = Convert.FromBase64String(encrypted_CLIENT_FirstName);

                    string decryptedFirstName = Encryption.Decrypt_AES(encrypted_CLIENT_FirstName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    clientFirstName = decryptedFirstName;

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return clientFirstName;

        }//end method

        public static bool Select_PASSWORD_HISTORY(string Username)
        {
            bool clientExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM PASSWORD_HISTORY WHERE BESTPATH_USER_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    clientExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return clientExists;

        }//end method

        public static ArrayList Select_PASSWORD_HISTORY_Record(string Username)
        {
            ArrayList passwords = new ArrayList();

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM PASSWORD_HISTORY WHERE BESTPATH_USER_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string oldPassword = row["042216_Password"].ToString();
                    string temporaryPassword = row["TemporaryPassword"].ToString();
                    string oldSecurityAnswer = row["042216_SecurityAnswer"].ToString();

                    passwords.Add(oldPassword);

                    passwords.Add(temporaryPassword);

                    passwords.Add(oldSecurityAnswer);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return passwords;

        }//end method

        public static ArrayList Select_BESTPATH_USER_Data(string Username)
        {
            ArrayList data = new ArrayList();
            
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string firstName = row["FirstName"].ToString();
                    string encryptedPassword = row["Password"].ToString();
                    string encryptedKey = row["_Key"].ToString();
                    string encryptedIV = row["_IV"].ToString();

                    byte[] _key = Convert.FromBase64String(encryptedKey);

                    byte[] _IV = Convert.FromBase64String(encryptedIV);

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    string decryptedKey = Encryption.Decrypt_AES(_key, MasterKey, MasterIV);

                    string decryptedIV = Encryption.Decrypt_AES(_IV, MasterKey, MasterIV);

                    byte[] _decryptedKey = Convert.FromBase64String(decryptedKey);

                    byte[] _decryptedIV = Convert.FromBase64String(decryptedIV);

                    byte[] encryptedPasswordArray = Convert.FromBase64String(encryptedPassword);

                    string decryptedPassword = Encryption.Decrypt_AES(encryptedPasswordArray, _decryptedKey, _decryptedIV);

                    string equalSymbol = "=";

                    if (firstName.Contains(equalSymbol))
                    {
                        byte[] encryptedFirstNameArray = Convert.FromBase64String(firstName);

                        firstName = Encryption.Decrypt_AES(encryptedFirstNameArray, _decryptedKey, _decryptedIV);

                    }//end if

                    data.Add(firstName);

                    data.Add(decryptedPassword);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return data;

        }//end method

        public static string Select_Client_Counselor(string Username)
        {
            string clientCounselor = "";
            
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT Counselor FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string counselor = row["Counselor"].ToString();

                    clientCounselor = counselor;

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return clientCounselor;

        }//end method

        public static bool Client_Exists(string Username)
        {
            bool clientExists = false;
            
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT Username FROM CLIENT WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    clientExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return clientExists;

        }//end method

        public static ArrayList Select_Client_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM CLIENT WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string username = row["Username"].ToString();
                    string encrypted_FirstName = row["FirstName"].ToString();
                    string encrypted_LastName = row["LastName"].ToString();
                    string encrypted_DOB = row["DOB"].ToString();
                    string encrypted_StreetAddress = row["StreetAddress"].ToString();
                    string encrypted_City = row["City"].ToString();
                    string encrypted_State = row["State"].ToString();
                    string encrypted_ZipCode = row["ZipCode"].ToString();
                    string encrypted_Country = row["Country"].ToString();
                    string encrypted_Phone = row["Phone"].ToString();
                    string encrypted_Key = row["_Key"].ToString();
                    string encrypted_IV = row["_IV"].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_Key_Array = Convert.FromBase64String(encrypted_Key);

                    byte[] encrypted_IV_Array = Convert.FromBase64String(encrypted_IV);

                    string decrypted_Key = Encryption.Decrypt_AES(encrypted_Key_Array, MasterKey, MasterIV);

                    string decrypted_IV = Encryption.Decrypt_AES(encrypted_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_Key_Array = Convert.FromBase64String(decrypted_Key);

                    byte[] decrypted_IV_Array = Convert.FromBase64String(decrypted_IV);

                    byte[] encrypted_FirstName_Array = Convert.FromBase64String(encrypted_FirstName);

                    byte[] encrypted_LastName_Array = Convert.FromBase64String(encrypted_LastName);

                    byte[] encrypted_DOB_Array = Convert.FromBase64String(encrypted_DOB);

                    byte[] encrypted_StreetAddress_Array = Convert.FromBase64String(encrypted_StreetAddress);

                    byte[] encrypted_City_Array = Convert.FromBase64String(encrypted_City);

                    byte[] encrypted_State_Array = Convert.FromBase64String(encrypted_State);

                    byte[] encrypted_ZipCode_Array = Convert.FromBase64String(encrypted_ZipCode);

                    byte[] encrypted_Phone_Array = Convert.FromBase64String(encrypted_Phone);

                    string decryptedFirstName = Encryption.Decrypt_AES(encrypted_FirstName_Array, decrypted_Key_Array, decrypted_IV_Array);

                    string decryptedLastName = Encryption.Decrypt_AES(encrypted_LastName_Array, decrypted_Key_Array, decrypted_IV_Array);

                    string decryptedDOB = Encryption.Decrypt_AES(encrypted_DOB_Array, decrypted_Key_Array, decrypted_IV_Array);

                    string decryptedStreetAddress = Encryption.Decrypt_AES(encrypted_StreetAddress_Array, decrypted_Key_Array, decrypted_IV_Array);

                    string decryptedCity = Encryption.Decrypt_AES(encrypted_City_Array, decrypted_Key_Array, decrypted_IV_Array);

                    string decryptedState = Encryption.Decrypt_AES(encrypted_State_Array, decrypted_Key_Array, decrypted_IV_Array);

                    string decryptedZipCode = Encryption.Decrypt_AES(encrypted_ZipCode_Array, decrypted_Key_Array, decrypted_IV_Array);

                    string decryptedPhone = Encryption.Decrypt_AES(encrypted_Phone_Array, decrypted_Key_Array, decrypted_IV_Array);


                    string decryptedCountry = "";

                    if (encrypted_Country != "0")
                    {
                        byte[] encrypted_Country_Array = Convert.FromBase64String(encrypted_Country);

                        decryptedCountry = Encryption.Decrypt_AES(encrypted_Country_Array, decrypted_Key_Array, decrypted_IV_Array);

                    }//end if

                    record.Add(username);
                    record.Add(decryptedFirstName);
                    record.Add(decryptedLastName);
                    record.Add(decryptedDOB);
                    record.Add(decryptedStreetAddress);
                    record.Add(decryptedCity);
                    record.Add(decryptedState);
                    record.Add(decryptedZipCode);
                    record.Add(decryptedCountry);
                    record.Add(decryptedPhone);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static string Select_Client_Name(string Username)
        {
            string clientName = "";
            
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT CLIENT.Username, FirstName, LastName, CLIENT._Key AS 'CLIENT._Key', CLIENT._IV AS 'CLIENT._IV' FROM CLIENT WHERE CLIENT.Username = @Username;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string encrypted_CLIENT_FirstName = row["FirstName"].ToString();
                    string encrypted_CLIENT_LastName = row["LastName"].ToString();
                    string encrypted_CLIENT_Key = row["CLIENT._Key"].ToString();
                    string encrypted_CLIENT_IV = row["CLIENT._IV"].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_CLIENT_Key_Array = Convert.FromBase64String(encrypted_CLIENT_Key);

                    byte[] encrypted_CLIENT_IV_Array = Convert.FromBase64String(encrypted_CLIENT_IV);

                    string decrypted_CLIENT_Key = Encryption.Decrypt_AES(encrypted_CLIENT_Key_Array, MasterKey, MasterIV);

                    string decrypted_CLIENT_IV = Encryption.Decrypt_AES(encrypted_CLIENT_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_CLIENT_Key_Array = Convert.FromBase64String(decrypted_CLIENT_Key);

                    byte[] decrypted_CLIENT_IV_Array = Convert.FromBase64String(decrypted_CLIENT_IV);

                    byte[] encrypted_CLIENT_FirstName_Array = Convert.FromBase64String(encrypted_CLIENT_FirstName);

                    byte[] encrypted_CLIENT_LastName_Array = Convert.FromBase64String(encrypted_CLIENT_LastName);

                    string decryptedFirstName = Encryption.Decrypt_AES(encrypted_CLIENT_FirstName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedLastName = Encryption.Decrypt_AES(encrypted_CLIENT_LastName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    clientName = decryptedFirstName + " " + decryptedLastName;

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return clientName;

        }//end method

        public static DataTable Select_Client_Overview_RLR(string Counselor)
        {
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT Username, Verified AS 'Registered', DateCreated, DateOfLastLogin, NumberOfLogins FROM BESTPATH_USER WHERE Username <> 'jdworktoworship@yahoo.com' AND Username <> 'admin@bestpathfoundation.com' AND Username <> 'clay.1@osu.edu' AND Counselor = @Counselor ORDER BY Username;";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@Counselor", SqlDbType.VarChar).Value = Counselor;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return selectObject.dataTable;

        }//end method

        public static DataTable Select_Client_Information()
        {
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT FirstName AS 'First name', LastName AS 'Last name', Username, Verified AS 'Registered', CounselorName AS 'Counselor name', DateCreated AS 'Date created', DateOfLastLogin AS 'Date of last login', NumberOfLogins AS 'Number of logins' FROM BESTPATH_USER WHERE Username <> 'admin@bestpathfoundation.com' AND Username <> 'jdworktoworship@yahoo.com' AND Username <> 'releasedgoddoer@gmail.com' AND Username <> 'benjaminclay13@hotmail.com' AND Username <> 'benjaminpatrick12@gmail.com' ORDER BY Username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string username = row["Username"].ToString();

                    string firstName = row["First name"].ToString();
                    string lastName = row["Last name"].ToString();
                    string counselorName = row["Counselor name"].ToString();
                    string dateCreated = row["Date created"].ToString();
                    string dateOfLastLogin = row["Date of last login"].ToString();

                    DateTime _dateCreated, _dateOfLastLogin, checkVar;

                    CultureInfo provider = CultureInfo.InvariantCulture;

                    _dateCreated = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);
                     
                    _dateOfLastLogin = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    checkVar = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    DateTime.TryParse(dateCreated, out _dateCreated);

                    DateTime.TryParse(dateOfLastLogin, out _dateOfLastLogin);

                    if ((dateOfLastLogin == "") || (dateOfLastLogin == null))
                    {
                        dateOfLastLogin = "Never";

                    }//end else

                    if (_dateCreated != checkVar)
                    {
                        dateCreated = _dateCreated.ToShortDateString();

                    }//end if

                    if (_dateOfLastLogin != checkVar)
                    {
                        dateOfLastLogin = _dateOfLastLogin.ToShortDateString();

                    }//end if

                        ArrayList bestPathUserKeys = new ArrayList();

                        bestPathUserKeys = Select.Select_BESTPATH_USER_Encryption_Keys(username);

                        string encrypted_BESTPATH_USER_Key = bestPathUserKeys[0].ToString();
                        string encrypted_BESTPATH_USER_IV = bestPathUserKeys[1].ToString();

                        byte[] MasterKey = Encryption.GetMasterKey();

                        byte[] MasterIV = Encryption.GetMasterIV();

                        byte[] encrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Key);

                        byte[] encrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_IV);

                        string decrypted_BESTPATH_USER_Key = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Key_Array, MasterKey, MasterIV);

                        string decrypted_BESTPATH_USER_IV = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_IV_Array, MasterKey, MasterIV);

                        byte[] decrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_Key);

                        byte[] decrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_IV);

                        byte[] encrypted_BESTPATH_USER_FirstName_Array = Convert.FromBase64String(firstName);

                        byte[] encrypted_BESTPATH_USER_LastName_Array = Convert.FromBase64String(lastName);

                        byte[] encrypted_BESTPATH_USER_CounselorName_Array = Convert.FromBase64String(counselorName);

                        string decryptedFirstName = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_FirstName_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                        string decryptedLastName = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_LastName_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                        string decryptedCounselorName = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_CounselorName_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                        row["First name"] = decryptedFirstName;

                        row["Last name"] = decryptedLastName;

                        row["Counselor name"] = decryptedCounselorName;

                        row["Date created"] = dateCreated;

                        row["Date of last login"] = dateOfLastLogin;

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return selectObject.dataTable;

        }//end method

        public static DataTable Select_Client_Information(string Username)
        {
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT CLIENT.Username AS 'Username', Password, CLIENT.FirstName AS 'First name', CLIENT.LastName AS 'Last name', DOB AS 'Age', StreetAddress AS 'Street address', City, State, ZipCode AS 'Zip code', Country, Phone AS 'Phone number', Role, Verified AS 'Registered', Counselor, CounselorName AS 'Counselor name', DateCreated AS 'Date created', DateOfLastLogin AS 'Date of last login', NumberOfLogins AS 'Number of logins', Overview, Introduction, ResourcesProvided AS 'Resources Provided', BeforeYouBegin AS 'Before You Begin', NaturalTalents AS 'Natural Talents', PerceptionResponse AS 'Perception Response', IdentifyingSpiritualGifts AS 'Identifying Your Spiritual Gifts', FocusAnalysisWorksheet AS 'Focus Analysis Worksheet', FocusDemonstrationWorksheet AS 'Focus Demonstration Worksheet', WaysToEvaluateYourEffect AS 'Ways To Evaluate Your Effect', FocusSample1 AS 'Focus Sample #1', FocusSample2 AS 'Focus Sample #2', FocusExperience1 AS 'Focus Experience #1', FocusExperience2 AS 'Focus Experience #2', FocusExperience3 AS 'Focus Experience #3', FocusExperience4 AS 'Focus Experience #4', FocusExperience5 AS 'Focus Experience #5', FocusExperience6 AS 'Focus Experience #6', FocusExperience7 AS 'Focus Experience #7', FocusExperience8 AS 'Focus Experience #8', PersonalManagementStyle AS 'Personal Management Style', FundamentalLifeMotivators AS 'Fundamental Life Motivators', EducationTrainingInventory AS 'Education / Training Inventory', PracticalSkills AS 'Practical Skills', ExpressingYourPersonalGenius AS 'Expressing Your Personal Genius', CreativityCycle AS 'Creativity Cycle', PerceptionResponseSummary AS 'Perception Response Summary', TotalSpiritualGifts AS 'Total Spiritual Gifts', FocusConsolidationWorksheet AS 'Focus Consolidation Worksheet', Congratulations AS 'Congratulations!', MarketingDocumentsCreation AS 'Marketing Documents Creation' FROM CLIENT INNER JOIN BESTPATH_USER ON CLIENT.Username = BESTPATH_USER.Username INNER JOIN BESTPATH_STATUS ON BESTPATH_USER.Username = BESTPATH_STATUS.BESTPATH_USER_Username WHERE CLIENT.Username <> 'admin@bestpathfoundation.com' AND CLIENT.Username <> 'jdworktoworship@yahoo.com' AND CLIENT.Username <> 'releasedgoddoer@gmail.com' AND CLIENT.Username <> 'benjaminclay13@hotmail.com' AND CLIENT.Username <> 'benjaminpatrick12@gmail.com' AND CLIENT.Username = @Username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            da.SelectCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string username = row["Username"].ToString();

                    string encrypted_CLIENT_FirstName = row["First name"].ToString();
                    string encrypted_CLIENT_LastName = row["Last name"].ToString();
                    string encrypted_CLIENT_DOB = row["Age"].ToString();
                    string encrypted_CLIENT_StreetAddress = row["Street address"].ToString();
                    string encrypted_CLIENT_City = row["City"].ToString();
                    string encrypted_CLIENT_State = row["State"].ToString();
                    string encrypted_CLIENT_ZipCode = row["Zip code"].ToString();
                    string encrypted_CLIENT_Country = row["Country"].ToString();
                    string encrypted_CLIENT_Phone = row["Phone number"].ToString();

                    string encrypted_BESTPATH_USER_Password = row["Password"].ToString();
                    string encrypted_BESTPATH_USER_Role = row["Role"].ToString();
                    string encrypted_BESTPATH_USER_CounselorName = row["Counselor name"].ToString();

                    ArrayList clientKeys = new ArrayList();
                    ArrayList bestPathUserKeys = new ArrayList();

                    clientKeys = Select.Select_CLIENT_Encryption_Keys(username);

                    string encrypted_CLIENT_Key = clientKeys[0].ToString();
                    string encrypted_CLIENT_IV = clientKeys[1].ToString();

                    bestPathUserKeys = Select.Select_BESTPATH_USER_Encryption_Keys(username);

                    string encrypted_BESTPATH_USER_Key = bestPathUserKeys[0].ToString();
                    string encrypted_BESTPATH_USER_IV = bestPathUserKeys[1].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encrypted_CLIENT_Key_Array = Convert.FromBase64String(encrypted_CLIENT_Key);

                    byte[] encrypted_CLIENT_IV_Array = Convert.FromBase64String(encrypted_CLIENT_IV);

                    string decrypted_CLIENT_Key = Encryption.Decrypt_AES(encrypted_CLIENT_Key_Array, MasterKey, MasterIV);

                    string decrypted_CLIENT_IV = Encryption.Decrypt_AES(encrypted_CLIENT_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_CLIENT_Key_Array = Convert.FromBase64String(decrypted_CLIENT_Key);

                    byte[] decrypted_CLIENT_IV_Array = Convert.FromBase64String(decrypted_CLIENT_IV);

                    byte[] encrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Key);

                    byte[] encrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_IV);

                    string decrypted_BESTPATH_USER_Key = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Key_Array, MasterKey, MasterIV);

                    string decrypted_BESTPATH_USER_IV = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_IV_Array, MasterKey, MasterIV);

                    byte[] decrypted_BESTPATH_USER_Key_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_Key);

                    byte[] decrypted_BESTPATH_USER_IV_Array = Convert.FromBase64String(decrypted_BESTPATH_USER_IV);

                    byte[] encrypted_BESTPATH_USER_Password_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Password);

                    byte[] encrypted_CLIENT_FirstName_Array = Convert.FromBase64String(encrypted_CLIENT_FirstName);

                    byte[] encrypted_CLIENT_LastName_Array = Convert.FromBase64String(encrypted_CLIENT_LastName);

                    byte[] encrypted_CLIENT_DOB_Array = Convert.FromBase64String(encrypted_CLIENT_DOB);

                    byte[] encrypted_CLIENT_StreetAddress_Array = Convert.FromBase64String(encrypted_CLIENT_StreetAddress);

                    byte[] encrypted_CLIENT_City_Array = Convert.FromBase64String(encrypted_CLIENT_City);

                    byte[] encrypted_CLIENT_State_Array = Convert.FromBase64String(encrypted_CLIENT_State);

                    byte[] encrypted_CLIENT_ZipCode_Array = Convert.FromBase64String(encrypted_CLIENT_ZipCode);

                    byte[] encrypted_CLIENT_Phone_Array = Convert.FromBase64String(encrypted_CLIENT_Phone);

                    byte[] encrypted_BESTPATH_USER_Role_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_Role);

                    byte[] encrypted_BESTPATH_USER_CounselorName_Array = Convert.FromBase64String(encrypted_BESTPATH_USER_CounselorName);

                    string decryptedPassword = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Password_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                    string decryptedFirstName = Encryption.Decrypt_AES(encrypted_CLIENT_FirstName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedLastName = Encryption.Decrypt_AES(encrypted_CLIENT_LastName_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedDOB = Encryption.Decrypt_AES(encrypted_CLIENT_DOB_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedStreetAddress = Encryption.Decrypt_AES(encrypted_CLIENT_StreetAddress_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedCity = Encryption.Decrypt_AES(encrypted_CLIENT_City_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedState = Encryption.Decrypt_AES(encrypted_CLIENT_State_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedZipCode = Encryption.Decrypt_AES(encrypted_CLIENT_ZipCode_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedPhone = Encryption.Decrypt_AES(encrypted_CLIENT_Phone_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    string decryptedRole = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_Role_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                    string decryptedCounselorName = Encryption.Decrypt_AES(encrypted_BESTPATH_USER_CounselorName_Array, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

                    string decryptedCountry = "";

                    if (encrypted_CLIENT_Country != "0")
                    {
                        byte[] encrypted_CLIENT_Country_Array = Convert.FromBase64String(encrypted_CLIENT_Country);

                        decryptedCountry = Encryption.Decrypt_AES(encrypted_CLIENT_Country_Array, decrypted_CLIENT_Key_Array, decrypted_CLIENT_IV_Array);

                    }//end if

                    selectObject.dataTable.Rows[0][1] = decryptedPassword;

                    selectObject.dataTable.Rows[0][2] = decryptedFirstName;

                    selectObject.dataTable.Rows[0][3] = decryptedLastName;

                    selectObject.dataTable.Rows[0][5] = decryptedStreetAddress;

                    selectObject.dataTable.Rows[0][6] = decryptedCity;

                    selectObject.dataTable.Rows[0][7] = decryptedState;

                    selectObject.dataTable.Rows[0][8] = decryptedZipCode;

                    selectObject.dataTable.Rows[0][9] = decryptedCountry;

                    selectObject.dataTable.Rows[0][10] = decryptedPhone;

                    selectObject.dataTable.Rows[0][11] = decryptedRole;

                    selectObject.dataTable.Rows[0][14] = decryptedCounselorName;


                    string dateCreated = row["Date created"].ToString();
                    string dateOfLastLogin = row["Date of last login"].ToString();
                    string overview = row["Overview"].ToString();
                    string introduction = row["Introduction"].ToString();
                    string resourcesProvided = row["Resources Provided"].ToString();
                    string beforeYouBegin = row["Before You Begin"].ToString();
                    string naturalTalents = row["Natural Talents"].ToString();
                    string perceptionResponse = row["Perception Response"].ToString();
                    string identifyingSpiritualGifts = row["Identifying Your Spiritual Gifts"].ToString();
                    string focusAnalysisWorksheet = row["Focus Analysis Worksheet"].ToString();
                    string focusDemonstrationWorksheet = row["Focus Demonstration Worksheet"].ToString();
                    string waysToEvaluateYourEffect = row["Ways To Evaluate Your Effect"].ToString();
                    string focusSample1 = row["Focus Sample #1"].ToString();
                    string focusSample2 = row["Focus Sample #2"].ToString();
                    string focusExperience1 = row["Focus Experience #1"].ToString();
                    string focusExperience2 = row["Focus Experience #2"].ToString();
                    string focusExperience3 = row["Focus Experience #3"].ToString();
                    string focusExperience4 = row["Focus Experience #4"].ToString();
                    string focusExperience5 = row["Focus Experience #5"].ToString();
                    string focusExperience6 = row["Focus Experience #6"].ToString();
                    string focusExperience7 = row["Focus Experience #7"].ToString();
                    string focusExperience8 = row["Focus Experience #8"].ToString();
                    string personalManagementStyle = row["Personal Management Style"].ToString();
                    string fundamentalLifeMotivators = row["Fundamental Life Motivators"].ToString();
                    string educationTrainingInventory = row["Education / Training Inventory"].ToString();
                    string practicalSkills = row["Practical Skills"].ToString();
                    string expressingYourPersonalGenius = row["Expressing Your Personal Genius"].ToString();
                    string creativityCycle = row["Creativity Cycle"].ToString();
                    string perceptionResponseSummary = row["Perception Response Summary"].ToString();
                    string totalSpiritualGifts = row["Total Spiritual Gifts"].ToString();
                    string focusConsolidationWorksheet = row["Focus Consolidation Worksheet"].ToString();
                    string congratulations = row["Congratulations!"].ToString();
                    string marketingDocumentsCreation = row["Marketing Documents Creation"].ToString();

                    DateTime checkVar;

                    DateTime _decryptedDOB, _dateCreated, _dateOfLastLogin, _overview, _introduction, _resourcesProvided, _beforeYouBegin, _naturalTalents, _perceptionResponse, _identifyingSpiritualGifts, _focusAnalysisWorksheet, _focusDemonstrationWorksheet, _waysToEvaluateYourEffect, _focusSample1, _focusSample2, _focusExperience1, _focusExperience2, _focusExperience3, _focusExperience4, _focusExperience5, _focusExperience6, _focusExperience7, _focusExperience8, _personalManagementStyle, _fundamentalLifeMotivators, _educationTrainingInventory, _practicalSkills, _expressingYourPersonalGenius, _creativityCycle, _perceptionResponseSummary, _totalSpiritualGifts, _focusConsolidationWorksheet, _congratulations, _marketingDocumentsCreation;

                    CultureInfo provider = CultureInfo.InvariantCulture;

                    checkVar = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _decryptedDOB = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _dateCreated = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _dateOfLastLogin = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _overview = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _introduction = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _resourcesProvided = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _beforeYouBegin = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _naturalTalents = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _perceptionResponse = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _identifyingSpiritualGifts = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusAnalysisWorksheet = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusDemonstrationWorksheet = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _waysToEvaluateYourEffect = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusSample1 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusSample2 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience1 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience2 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience3 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience4 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience5 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience6 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience7 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusExperience8 = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _personalManagementStyle = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _fundamentalLifeMotivators = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _educationTrainingInventory = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _practicalSkills = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _expressingYourPersonalGenius = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _creativityCycle = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _perceptionResponseSummary = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _totalSpiritualGifts = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _focusConsolidationWorksheet = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _congratulations = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    _marketingDocumentsCreation = DateTime.ParseExact("01/01/0001", "MM/dd/yyyy", provider);

                    int _DOB;

                    Int32.TryParse(decryptedDOB, out _DOB);

                    if (_DOB != 0)
                    {
                        string[] formats = { "MMddyyyy", "MM/dd/yy" };
                        DateTime.TryParseExact(decryptedDOB, formats, CultureInfo.CurrentCulture, DateTimeStyles.None, out _decryptedDOB);

                        if (_decryptedDOB != checkVar)
                        {
                            decryptedDOB = _decryptedDOB.ToShortDateString();

                        }//end if

                    }//end if

                    else
                    {
                        DateTime.TryParse(decryptedDOB, out _decryptedDOB);

                        if (_decryptedDOB != checkVar)
                        {
                            decryptedDOB = _decryptedDOB.ToShortDateString();

                        }//end if

                    }//end else

                    DateTime.TryParse(dateCreated, out _dateCreated);

                    if (_dateCreated != checkVar)
                    {
                        dateCreated = _dateCreated.ToShortDateString();

                    }//end if

                    DateTime.TryParse(dateOfLastLogin, out _dateOfLastLogin);

                    if (_dateOfLastLogin != checkVar)
                    {
                        dateOfLastLogin = _dateOfLastLogin.ToShortDateString();

                    }//end if

                    if ((dateOfLastLogin == "") || (dateOfLastLogin == null))
                    {
                        dateOfLastLogin = "Never";

                    }//end else

                    DateTime.TryParse(overview, out _overview);

                    if (_overview != checkVar)
                    {
                        overview = _overview.ToShortDateString();

                    }//end if

                    DateTime.TryParse(introduction, out _introduction);

                    if (_introduction != checkVar)
                    {
                        introduction = _introduction.ToShortDateString();

                    }//end if

                    DateTime.TryParse(resourcesProvided, out _resourcesProvided);

                    if (_resourcesProvided != checkVar)
                    {
                        resourcesProvided = _resourcesProvided.ToShortDateString();

                    }//end if

                    DateTime.TryParse(beforeYouBegin, out _beforeYouBegin);

                    if (_beforeYouBegin != checkVar)
                    {
                        beforeYouBegin = _beforeYouBegin.ToShortDateString();

                    }//end if

                    DateTime.TryParse(naturalTalents, out _naturalTalents);

                    if (_naturalTalents != checkVar)
                    {
                        naturalTalents = _naturalTalents.ToShortDateString();

                    }//end if

                    DateTime.TryParse(perceptionResponse, out _perceptionResponse);

                    if (_perceptionResponse != checkVar)
                    {
                        perceptionResponse = _perceptionResponse.ToShortDateString();

                    }//end if

                    DateTime.TryParse(identifyingSpiritualGifts, out _identifyingSpiritualGifts);

                    if (_identifyingSpiritualGifts != checkVar)
                    {
                        identifyingSpiritualGifts = _identifyingSpiritualGifts.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusAnalysisWorksheet, out _focusAnalysisWorksheet);

                    if (_focusAnalysisWorksheet != checkVar)
                    {
                        focusAnalysisWorksheet = _focusAnalysisWorksheet.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusDemonstrationWorksheet, out _focusDemonstrationWorksheet);

                    if (_focusDemonstrationWorksheet != checkVar)
                    {
                        focusDemonstrationWorksheet = _focusDemonstrationWorksheet.ToShortDateString();

                    }//end if

                    DateTime.TryParse(waysToEvaluateYourEffect, out _waysToEvaluateYourEffect);

                    if (_waysToEvaluateYourEffect != checkVar)
                    {
                        waysToEvaluateYourEffect = _waysToEvaluateYourEffect.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusSample1, out _focusSample1);

                    if (_focusSample1 != checkVar)
                    {
                        focusSample1 = _focusSample1.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusSample2, out _focusSample2);

                    if (_focusSample2 != checkVar)
                    {
                        focusSample2 = _focusSample2.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience1, out _focusExperience1);

                    if (_focusExperience1 != checkVar)
                    {
                        focusExperience1 = _focusExperience1.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience2, out _focusExperience2);

                    if (_focusExperience2 != checkVar)
                    {
                        focusExperience2 = _focusExperience2.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience3, out _focusExperience3);

                    if (_focusExperience3 != checkVar)
                    {
                        focusExperience3 = _focusExperience3.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience4, out _focusExperience4);

                    if (_focusExperience4 != checkVar)
                    {
                        focusExperience4 = _focusExperience4.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience5, out _focusExperience5);

                    if (_focusExperience5 != checkVar)
                    {
                        focusExperience5 = _focusExperience5.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience6, out _focusExperience6);

                    if (_focusExperience6 != checkVar)
                    {
                        focusExperience6 = _focusExperience6.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience7, out _focusExperience7);

                    if (_focusExperience7 != checkVar)
                    {
                        focusExperience7 = _focusExperience7.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusExperience8, out _focusExperience8);

                    if (_focusExperience8 != checkVar)
                    {
                        focusExperience8 = _focusExperience8.ToShortDateString();

                    }//end if

                    DateTime.TryParse(personalManagementStyle, out _personalManagementStyle);

                    if (_personalManagementStyle != checkVar)
                    {
                        personalManagementStyle = _personalManagementStyle.ToShortDateString();

                    }//end if

                    DateTime.TryParse(fundamentalLifeMotivators, out _fundamentalLifeMotivators);

                    if (_fundamentalLifeMotivators != checkVar)
                    {
                        fundamentalLifeMotivators = _fundamentalLifeMotivators.ToShortDateString();

                    }//end if

                    DateTime.TryParse(educationTrainingInventory, out _educationTrainingInventory);

                    if (_educationTrainingInventory != checkVar)
                    {
                        educationTrainingInventory = _educationTrainingInventory.ToShortDateString();

                    }//end if

                    DateTime.TryParse(practicalSkills, out _practicalSkills);

                    if (_practicalSkills != checkVar)
                    {
                        practicalSkills = _practicalSkills.ToShortDateString();

                    }//end if

                    DateTime.TryParse(expressingYourPersonalGenius, out _expressingYourPersonalGenius);

                    if (_expressingYourPersonalGenius != checkVar)
                    {
                        expressingYourPersonalGenius = _expressingYourPersonalGenius.ToShortDateString();

                    }//end if

                    DateTime.TryParse(creativityCycle, out _creativityCycle);

                    if (_creativityCycle != checkVar)
                    {
                        creativityCycle = _creativityCycle.ToShortDateString();

                    }//end if

                    DateTime.TryParse(perceptionResponseSummary, out _perceptionResponseSummary);

                    if (_perceptionResponseSummary != checkVar)
                    {
                        perceptionResponseSummary = _perceptionResponseSummary.ToShortDateString();

                    }//end if

                    DateTime.TryParse(totalSpiritualGifts, out _totalSpiritualGifts);

                    if (_totalSpiritualGifts != checkVar)
                    {
                        totalSpiritualGifts = _totalSpiritualGifts.ToShortDateString();

                    }//end if

                    DateTime.TryParse(focusConsolidationWorksheet, out _focusConsolidationWorksheet);

                    if (_focusConsolidationWorksheet != checkVar)
                    {
                        focusConsolidationWorksheet = _focusConsolidationWorksheet.ToShortDateString();

                    }//end if

                    DateTime.TryParse(congratulations, out _congratulations);

                    if (_congratulations != checkVar)
                    {
                        congratulations = _congratulations.ToShortDateString();

                    }//end if

                    DateTime.TryParse(marketingDocumentsCreation, out _marketingDocumentsCreation);

                    if (_marketingDocumentsCreation != checkVar)
                    {
                        marketingDocumentsCreation = _marketingDocumentsCreation.ToShortDateString();

                    }//end if

                    selectObject.dataTable.Rows[0][4] = decryptedDOB;

                    selectObject.dataTable.Rows[0][15] = dateCreated;

                    selectObject.dataTable.Rows[0][16] = dateOfLastLogin;

                    selectObject.dataTable.Rows[0][18] = overview;

                    selectObject.dataTable.Rows[0][19] = introduction;

                    selectObject.dataTable.Rows[0][20] = resourcesProvided;

                    selectObject.dataTable.Rows[0][21] = beforeYouBegin;

                    selectObject.dataTable.Rows[0][22] = naturalTalents;

                    selectObject.dataTable.Rows[0][23] = perceptionResponse;

                    selectObject.dataTable.Rows[0][24] = identifyingSpiritualGifts;

                    selectObject.dataTable.Rows[0][25] = focusAnalysisWorksheet;

                    selectObject.dataTable.Rows[0][26] = focusDemonstrationWorksheet;

                    selectObject.dataTable.Rows[0][27] = waysToEvaluateYourEffect;

                    selectObject.dataTable.Rows[0][28] = focusSample1;

                    selectObject.dataTable.Rows[0][29] = focusSample2;

                    selectObject.dataTable.Rows[0][30] = focusExperience1;

                    selectObject.dataTable.Rows[0][31] = focusExperience2;

                    selectObject.dataTable.Rows[0][32] = focusExperience3;

                    selectObject.dataTable.Rows[0][33] = focusExperience4;

                    selectObject.dataTable.Rows[0][34] = focusExperience5;

                    selectObject.dataTable.Rows[0][35] = focusExperience6;

                    selectObject.dataTable.Rows[0][36] = focusExperience7;

                    selectObject.dataTable.Rows[0][37] = focusExperience8;

                    selectObject.dataTable.Rows[0][38] = personalManagementStyle;

                    selectObject.dataTable.Rows[0][39] = fundamentalLifeMotivators;

                    selectObject.dataTable.Rows[0][40] = educationTrainingInventory;

                    selectObject.dataTable.Rows[0][41] = practicalSkills;

                    selectObject.dataTable.Rows[0][42] = expressingYourPersonalGenius;

                    selectObject.dataTable.Rows[0][43] = creativityCycle;

                    selectObject.dataTable.Rows[0][44] = perceptionResponseSummary;

                    selectObject.dataTable.Rows[0][45] = totalSpiritualGifts;

                    selectObject.dataTable.Rows[0][46] = focusConsolidationWorksheet;

                    selectObject.dataTable.Rows[0][47] = congratulations;

                    selectObject.dataTable.Rows[0][48] = marketingDocumentsCreation;

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return selectObject.dataTable;

        }//end method

        public static bool Authenticate_Security_Credentials(string Username, string EncryptedSecurityQuestion, string EncryptedSecurityAnswer)
        {
            bool authenticated = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username AND SecurityQuestion = @securityQuestion AND SecurityAnswer = @securityAnswer";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            selectCommand.Parameters.Add("@securityQuestion", SqlDbType.VarChar).Value = EncryptedSecurityQuestion;

            selectCommand.Parameters.Add("@securityAnswer", SqlDbType.VarChar).Value = EncryptedSecurityAnswer;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    authenticated = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return authenticated;

        }//end method

        public static String Select_Security_Question(string Username)
        {
            string securityQuestion = "";

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    securityQuestion = row["SecurityQuestion"].ToString();

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return securityQuestion;

        }//end method

        public static ArrayList Select_BESTPATH_USER_Encryption_Keys(string Username)
        {
            ArrayList keys = new ArrayList();

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string _Key = row["_Key"].ToString();
                    string _IV = row["_IV"].ToString();

                    keys.Add(_Key);
                    keys.Add(_IV);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return keys;

        }//end method

        public static ArrayList Select_CLIENT_Encryption_Keys(string Username)
        {
            ArrayList keys = new ArrayList();

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM CLIENT WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string _Key = row["_Key"].ToString();
                    string _IV = row["_IV"].ToString();

                    keys.Add(_Key);
                    keys.Add(_IV);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return keys;

        }//end method

        public static bool Authenticate_User(string Username, string Password)
        {
            bool authenticated = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string password = row["Password"].ToString();
                    string key = row["_Key"].ToString();
                    string IV = row["_IV"].ToString();

                    byte[] _key = Convert.FromBase64String(key);

                    byte[] _IV = Convert.FromBase64String(IV);

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    string decryptedKey = Encryption.Decrypt_AES(_key, MasterKey, MasterIV);

                    string decryptedIV = Encryption.Decrypt_AES(_IV, MasterKey, MasterIV);

                    byte[] _decryptedKey = Convert.FromBase64String(decryptedKey);

                    byte[] _decryptedIV = Convert.FromBase64String(decryptedIV);

                    byte[] encryptedPassword = Encryption.Encrypt_AES(Password, _decryptedKey, _decryptedIV);

                    string encryptedPasswordString = Convert.ToBase64String(encryptedPassword);

                    if (password == encryptedPasswordString)
                    {
                        authenticated = true;

                    }//end if

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return authenticated;

        }//end method

        public static ArrayList Select_Deliverable_Creation_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM DELIVERABLE_CREATION WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string username = row["CLIENT_Username"].ToString();
                    string fullName = row["FullName"].ToString();
                    string degrees = row["Degrees"].ToString();
                    string streetAddress = row["StreetAddress"].ToString();
                    string cityStateZip = row["CityStateZip"].ToString();
                    string emailAddress = row["EmailAddress"].ToString();
                    string phoneNumber = row["PhoneNumber"].ToString();
                    string section1Title = row["Section1Title"].ToString();
                    string focus = row["Focus"].ToString();
                    string theme1 = row["Theme1"].ToString();
                    string theme2 = row["Theme2"].ToString();
                    string theme3 = row["Theme3"].ToString();
                    string section2Title = row["Section2Title"].ToString();
                    string personalDescriptor1 = row["PersonalDescriptor1"].ToString();
                    string personalDescriptor2 = row["PersonalDescriptor2"].ToString();
                    string personalDescriptor3 = row["PersonalDescriptor3"].ToString();
                    string qualification1 = row["Qualification1"].ToString();
                    string qualification2 = row["Qualification2"].ToString();
                    string qualification3 = row["Qualification3"].ToString();
                    string qualification4 = row["Qualification4"].ToString();
                    string qualification5 = row["Qualification5"].ToString();
                    string qualification6 = row["Qualification6"].ToString();
                    string qualification7 = row["Qualification7"].ToString();
                    string qualification8 = row["Qualification8"].ToString();
                    string qualification9 = row["Qualification9"].ToString();
                    string section3Title = row["Section3Title"].ToString();
                    string achievement1 = row["Achievement1"].ToString();
                    string achievement2 = row["Achievement2"].ToString();
                    string achievement3 = row["Achievement3"].ToString();
                    string achievement4 = row["Achievement4"].ToString();
                    string achievement5 = row["Achievement5"].ToString();
                    string achievement6 = row["Achievement6"].ToString();
                    string achievement7 = row["Achievement7"].ToString();
                    string achievement8 = row["Achievement8"].ToString();
                    string section4Title = row["Section4Title"].ToString();
                    string jobTitles = row["JobTitles"].ToString();
                    string jobTitle1 = row["JobTitle1"].ToString();
                    string companyName1 = row["CompanyName1"].ToString();
                    string years1 = row["Years1"].ToString();
                    string narrative1 = row["Narrative1"].ToString();
                    string jobTitle2 = row["JobTitle2"].ToString();
                    string companyName2 = row["CompanyName2"].ToString();
                    string years2 = row["Years2"].ToString();
                    string narrative2 = row["Narrative2"].ToString();
                    string jobTitle3 = row["JobTitle3"].ToString();
                    string companyName3 = row["CompanyName3"].ToString();
                    string years3 = row["Years3"].ToString();
                    string narrative3 = row["Narrative3"].ToString();
                    string jobTitle4 = row["JobTitle4"].ToString();
                    string companyName4 = row["CompanyName4"].ToString();
                    string years4 = row["Years4"].ToString();
                    string narrative4 = row["Narrative4"].ToString();
                    string jobTitle5 = row["JobTitle5"].ToString();
                    string companyName5 = row["CompanyName5"].ToString();
                    string years5 = row["Years5"].ToString();
                    string narrative5 = row["Narrative5"].ToString();
                    string educationTitle = row["EducationTitle"].ToString();
                    string education = row["Education"].ToString();
                    string trainingTitle = row["TrainingTitle"].ToString();
                    string training = row["Training"].ToString();
                    string honorsAndAwardsTitle = row["HonorsAndAwardsTitle"].ToString();
                    string honorsAndAwards = row["HonorsAndAwards"].ToString();
                    string militaryServiceTitle = row["MilitaryServiceTitle"].ToString();
                    string militaryService = row["MilitaryService"].ToString();
                    string voluntaryPositionsTitle = row["VoluntaryPositionsTitle"].ToString();
                    string voluntaryPositions = row["VoluntaryPositions"].ToString();
                    string otherTitle = row["OtherTitle"].ToString();
                    string other = row["Other"].ToString();
                    string name1 = row["Name1"].ToString();
                    string title1 = row["Title1"].ToString();
                    string company1 = row["Company1"].ToString();
                    string relationship1 = row["Relationship1"].ToString();
                    string email1 = row["Email1"].ToString();
                    string phone1 = row["Phone1"].ToString();
                    string name2 = row["Name2"].ToString();
                    string title2 = row["Title2"].ToString();
                    string company2 = row["Company2"].ToString();
                    string relationship2 = row["Relationship2"].ToString();
                    string email2 = row["Email2"].ToString();
                    string phone2 = row["Phone2"].ToString();
                    string name3 = row["Name3"].ToString();
                    string title3 = row["Title3"].ToString();
                    string company3 = row["Company3"].ToString();
                    string relationship3 = row["Relationship3"].ToString();
                    string email3 = row["Email3"].ToString();
                    string phone3 = row["Phone3"].ToString();
                    string name4 = row["Name4"].ToString();
                    string title4 = row["Title4"].ToString();
                    string company4 = row["Company4"].ToString();
                    string relationship4 = row["Relationship4"].ToString();
                    string email4 = row["Email4"].ToString();
                    string phone4 = row["Phone4"].ToString();
                    string name5 = row["Name5"].ToString();
                    string title5 = row["Title5"].ToString();
                    string company5 = row["Company5"].ToString();
                    string relationship5 = row["Relationship5"].ToString();
                    string email5 = row["Email5"].ToString();
                    string phone5 = row["Phone5"].ToString();
                    string name6 = row["Name6"].ToString();
                    string title6 = row["Title6"].ToString();
                    string company6 = row["Company6"].ToString();
                    string relationship6 = row["Relationship6"].ToString();
                    string email6 = row["Email6"].ToString();
                    string phone6 = row["Phone6"].ToString();
                    string name7 = row["Name7"].ToString();
                    string title7 = row["Title7"].ToString();
                    string company7 = row["Company7"].ToString();
                    string relationship7 = row["Relationship7"].ToString();
                    string email7 = row["Email7"].ToString();
                    string phone7 = row["Phone7"].ToString();
                    string name8 = row["Name8"].ToString();
                    string title8 = row["Title8"].ToString();
                    string company8 = row["Company8"].ToString();
                    string relationship8 = row["Relationship8"].ToString();
                    string email8 = row["Email8"].ToString();
                    string phone8 = row["Phone8"].ToString();
                    string encryptedKey = row["_Key"].ToString();
                    string encryptedIV = row["_IV"].ToString();

                    byte[] MasterKey = Encryption.GetMasterKey();

                    byte[] MasterIV = Encryption.GetMasterIV();

                    byte[] encryptedKeyArray = Convert.FromBase64String(encryptedKey);

                    byte[] encryptedIVArray = Convert.FromBase64String(encryptedIV);

                    string decryptedKey = Encryption.Decrypt_AES(encryptedKeyArray, MasterKey, MasterIV);

                    string decryptedIV = Encryption.Decrypt_AES(encryptedIVArray, MasterKey, MasterIV);

                    byte[] decryptedKeyArray = Convert.FromBase64String(decryptedKey);

                    byte[] decryptedIVArray = Convert.FromBase64String(decryptedIV);

                    byte[] fullNameArray = Convert.FromBase64String(fullName);

                    byte[] degreesArray = Convert.FromBase64String(degrees);

                    byte[] streetAddressArray = Convert.FromBase64String(streetAddress);

                    byte[] cityStateZipArray = Convert.FromBase64String(cityStateZip);

                    byte[] emailAddressArray = Convert.FromBase64String(emailAddress);

                    byte[] phoneNumberArray = Convert.FromBase64String(phoneNumber);

                    string decryptedFullName = Encryption.Decrypt_AES(fullNameArray, decryptedKeyArray, decryptedIVArray);

                    string decryptedDegrees = Encryption.Decrypt_AES(degreesArray, decryptedKeyArray, decryptedIVArray);

                    string decryptedStreetAddress = Encryption.Decrypt_AES(streetAddressArray, decryptedKeyArray, decryptedIVArray);

                    string decryptedCityStateZip = Encryption.Decrypt_AES(cityStateZipArray, decryptedKeyArray, decryptedIVArray);

                    string decryptedEmailAddress = Encryption.Decrypt_AES(emailAddressArray, decryptedKeyArray, decryptedIVArray);

                    string decryptedPhoneNumber = Encryption.Decrypt_AES(phoneNumberArray, decryptedKeyArray, decryptedIVArray);

                    record.Add(username);
                    record.Add(decryptedFullName);
                    record.Add(decryptedDegrees);
                    record.Add(decryptedStreetAddress);
                    record.Add(decryptedCityStateZip);
                    record.Add(decryptedEmailAddress);
                    record.Add(decryptedPhoneNumber);
                    record.Add(section1Title);
                    record.Add(focus);
                    record.Add(theme1);
                    record.Add(theme2);
                    record.Add(theme3);
                    record.Add(section2Title);
                    record.Add(personalDescriptor1);
                    record.Add(personalDescriptor2);
                    record.Add(personalDescriptor3);
                    record.Add(qualification1);
                    record.Add(qualification2);
                    record.Add(qualification3);
                    record.Add(qualification4);
                    record.Add(qualification5);
                    record.Add(qualification6);
                    record.Add(qualification7);
                    record.Add(qualification8);
                    record.Add(qualification9);
                    record.Add(section3Title);
                    record.Add(achievement1);
                    record.Add(achievement2);
                    record.Add(achievement3);
                    record.Add(achievement4);
                    record.Add(achievement5);
                    record.Add(achievement6);
                    record.Add(achievement7);
                    record.Add(achievement8);
                    record.Add(section4Title);
                    record.Add(jobTitles);
                    record.Add(jobTitle1);
                    record.Add(companyName1);
                    record.Add(years1);
                    record.Add(narrative1);
                    record.Add(jobTitle2);
                    record.Add(companyName2);
                    record.Add(years2);
                    record.Add(narrative2);
                    record.Add(jobTitle3);
                    record.Add(companyName3);
                    record.Add(years3);
                    record.Add(narrative3);
                    record.Add(jobTitle4);
                    record.Add(companyName4);
                    record.Add(years4);
                    record.Add(narrative4);
                    record.Add(jobTitle5);
                    record.Add(companyName5);
                    record.Add(years5);
                    record.Add(narrative5);
                    record.Add(educationTitle);
                    record.Add(education);
                    record.Add(trainingTitle);
                    record.Add(training);
                    record.Add(honorsAndAwardsTitle);
                    record.Add(honorsAndAwards);
                    record.Add(militaryServiceTitle);
                    record.Add(militaryService);
                    record.Add(voluntaryPositionsTitle);
                    record.Add(voluntaryPositions);
                    record.Add(otherTitle);
                    record.Add(other);
                    record.Add(name1);
                    record.Add(title1);
                    record.Add(company1);
                    record.Add(relationship1);
                    record.Add(email1);
                    record.Add(phone1);
                    record.Add(name2);
                    record.Add(title2);
                    record.Add(company2);
                    record.Add(relationship2);
                    record.Add(email2);
                    record.Add(phone2);
                    record.Add(name3);
                    record.Add(title3);
                    record.Add(company3);
                    record.Add(relationship3);
                    record.Add(email3);
                    record.Add(phone3);
                    record.Add(name4);
                    record.Add(title4);
                    record.Add(company4);
                    record.Add(relationship4);
                    record.Add(email4);
                    record.Add(phone4);
                    record.Add(name5);
                    record.Add(title5);
                    record.Add(company5);
                    record.Add(relationship5);
                    record.Add(email5);
                    record.Add(phone5);
                    record.Add(name6);
                    record.Add(title6);
                    record.Add(company6);
                    record.Add(relationship6);
                    record.Add(email6);
                    record.Add(phone6);
                    record.Add(name7);
                    record.Add(title7);
                    record.Add(company7);
                    record.Add(relationship7);
                    record.Add(email7);
                    record.Add(phone7);
                    record.Add(name8);
                    record.Add(title8);
                    record.Add(company8);
                    record.Add(relationship8);
                    record.Add(email8);
                    record.Add(phone8);                   

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Deliverable_Creation(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM DELIVERABLE_CREATION WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Progress_Menu_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_STATUS WHERE BESTPATH_USER_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Overview = row["Overview"].ToString();
                    string Introduction = row["Introduction"].ToString();
                    string ResourcesProvided = row["ResourcesProvided"].ToString();
                    string BeforeYouBegin = row["BeforeYouBegin"].ToString();
                    string NaturalTalents = row["NaturalTalents"].ToString();
                    string PerceptionResponseForm = row["PerceptionResponse"].ToString();
                    string SpiritualGifts = row["IdentifyingSpiritualGifts"].ToString();
                    string FocusAnalysisWorksheet = row["FocusAnalysisWorksheet"].ToString();
                    string FocusDemonstrationWorksheet = row["FocusDemonstrationWorksheet"].ToString();
                    string WaysToEvaluateYourEffect = row["WaysToEvaluateYourEffect"].ToString();
                    string FocusSample1 = row["FocusSample1"].ToString();
                    string FocusSample2 = row["FocusSample2"].ToString();
                    string FocusExperience1 = row["FocusExperience1"].ToString();
                    string FocusExperience2 = row["FocusExperience2"].ToString();
                    string FocusExperience3 = row["FocusExperience3"].ToString();
                    string FocusExperience4 = row["FocusExperience4"].ToString();
                    string FocusExperience5 = row["FocusExperience5"].ToString();
                    string FocusExperience6 = row["FocusExperience6"].ToString();
                    string FocusExperience7 = row["FocusExperience7"].ToString();
                    string FocusExperience8 = row["FocusExperience8"].ToString();
                    string PersonalManagementStyle = row["PersonalManagementStyle"].ToString();
                    string FundamentalLifeMotivators = row["FundamentalLifeMotivators"].ToString();
                    string EducationTrainingInventory = row["EducationTrainingInventory"].ToString();
                    string PracticalSkills = row["PracticalSkills"].ToString();
                    string ExpressingYourPersonalGenius = row["ExpressingYourPersonalGenius"].ToString();
                    string CreativityCycle = row["CreativityCycle"].ToString();
                    string PerceptionResponseSummary = row["PerceptionResponseSummary"].ToString();
                    string TotalSpiritualGifts = row["TotalSpiritualGifts"].ToString();
                    string FocusConsolidationWorksheet = row["FocusConsolidationWorksheet"].ToString();
                    string Congratulations = row["Congratulations"].ToString();
                    string MarketingDocumentsCreation = row["MarketingDocumentsCreation"].ToString();

                    record.Add(Overview);
                    record.Add(Introduction);
                    record.Add(ResourcesProvided);
                    record.Add(BeforeYouBegin);
                    record.Add(NaturalTalents);
                    record.Add(PerceptionResponseForm);
                    record.Add(SpiritualGifts);
                    record.Add(FocusAnalysisWorksheet);
                    record.Add(FocusDemonstrationWorksheet);
                    record.Add(WaysToEvaluateYourEffect);
                    record.Add(FocusSample1);
                    record.Add(FocusSample2);
                    record.Add(FocusExperience1);
                    record.Add(FocusExperience2);
                    record.Add(FocusExperience3);
                    record.Add(FocusExperience4);
                    record.Add(FocusExperience5);
                    record.Add(FocusExperience6);
                    record.Add(FocusExperience7);
                    record.Add(FocusExperience8);
                    record.Add(PersonalManagementStyle);
                    record.Add(FundamentalLifeMotivators);
                    record.Add(EducationTrainingInventory);
                    record.Add(PracticalSkills);
                    record.Add(ExpressingYourPersonalGenius);
                    record.Add(CreativityCycle);
                    record.Add(PerceptionResponseSummary);
                    record.Add(TotalSpiritualGifts);
                    record.Add(FocusConsolidationWorksheet);
                    record.Add(Congratulations);
                    record.Add(MarketingDocumentsCreation);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static ArrayList Select_Focus_Experience12_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 12";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience12(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 12";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience11_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 11";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience11(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 11";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience10_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 10";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience10(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 10";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience3_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 3";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience9(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 9";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience4_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 4";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience8(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 8";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience7_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 7";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience7(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 7";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience6_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 6";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience6(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 6";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience5_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 5";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience5(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 5";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience2_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 2";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience4(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 4";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience8_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 8";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience3(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 3";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Experience1_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 1";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Experience2(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 2";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static bool Select_Focus_Experience1(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_EXPERIENCE WHERE CLIENT_Username = @username AND FOCUS_EXPERIENCE# = 1";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Spiritual_Gifts_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM SPIRITUAL_GIFTS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();
                    string Q14 = row["Q14"].ToString();
                    string Q15 = row["Q15"].ToString();
                    string Q16 = row["Q16"].ToString();
                    string Q17 = row["Q17"].ToString();
                    string Q18 = row["Q18"].ToString();
                    string Q19 = row["Q19"].ToString();
                    string Q20 = row["Q20"].ToString();
                    string Q21 = row["Q21"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);
                    record.Add(Q14);
                    record.Add(Q15);
                    record.Add(Q16);
                    record.Add(Q17);
                    record.Add(Q18);
                    record.Add(Q19);
                    record.Add(Q20);
                    record.Add(Q21);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Spiritual_Gifts(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM SPIRITUAL_GIFTS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Demonstration_Worksheet_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_DEMONSTRATION WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                            
                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Focus_Demonstration_Worksheet(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_DEMONSTRATION WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Role_Data(string Username)
        {
            ArrayList roleData = new ArrayList();
            
            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string role = row["Role"].ToString();
                    string key = row["_Key"].ToString();
                    string IV = row["_IV"].ToString();

                    roleData.Add(role);
                    roleData.Add(key);
                    roleData.Add(IV);

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return roleData;

        }//end method

        public static ArrayList Select_Creativity_Cycle_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM CREATIVITY_CYCLE WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Creativity_Cycle(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM CREATIVITY_CYCLE WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Expressing_Personal_Genius_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM EXPRESSING_PERSONAL_GENIUS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Expressing_Personal_Genius(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM EXPRESSING_PERSONAL_GENIUS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Fundamental_Life_Motivators_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FUNDAMENTAL_LIFE_MOTIVATORS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Fundamental_Life_Motivators(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FUNDAMENTAL_LIFE_MOTIVATORS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Perception_Response_Summary_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM PERCEPTION_RESPONSE_SUMMARY WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Perception_Response_Summary(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM PERCEPTION_RESPONSE_SUMMARY WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Personal_Management_Style_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM PERSONAL_MANAGEMENT_STYLES WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();
                    string Q14 = row["Q14"].ToString();
                    string Q15 = row["Q15"].ToString();
                    string Q16 = row["Q16"].ToString();
                    string Q17 = row["Q17"].ToString();
                    string Q18 = row["Q18"].ToString();
                    string Q19 = row["Q19"].ToString();
                    string Q20 = row["Q20"].ToString();
                    string Q21 = row["Q21"].ToString();
                    string Q22 = row["Q22"].ToString();
                    string Q23 = row["Q23"].ToString();
                    string Q24 = row["Q24"].ToString();
                    string Q25 = row["Q25"].ToString();
                    string Q26 = row["Q26"].ToString();
                    string Q27 = row["Q27"].ToString();
                    string Q28 = row["Q28"].ToString();
                    string Q29 = row["Q29"].ToString();
                    string Q30 = row["Q30"].ToString();
                    string Q31 = row["Q31"].ToString();
                    string Q32 = row["Q32"].ToString();
                    string Q33 = row["Q33"].ToString();
                    string Q34 = row["Q34"].ToString();
                    string Q35 = row["Q35"].ToString();
                    string Q36 = row["Q36"].ToString();
                    string Q37 = row["Q37"].ToString();
                    string Q38 = row["Q38"].ToString();
                    string Q39 = row["Q39"].ToString();
                    string Q40 = row["Q40"].ToString();
                    string Q41 = row["Q41"].ToString();
                    string Q42 = row["Q42"].ToString();
                    string Q43 = row["Q43"].ToString();
                    string Q44 = row["Q44"].ToString();
                    string Q45 = row["Q45"].ToString();
                    string Q46 = row["Q46"].ToString();
                    string Q47 = row["Q47"].ToString();
                    string Q48 = row["Q48"].ToString();
                    string Q49 = row["Q49"].ToString();
                    string Q50 = row["Q50"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);
                    record.Add(Q14);
                    record.Add(Q15);
                    record.Add(Q16);
                    record.Add(Q17);
                    record.Add(Q18);
                    record.Add(Q19);
                    record.Add(Q20);
                    record.Add(Q21);
                    record.Add(Q22);
                    record.Add(Q23);
                    record.Add(Q24);
                    record.Add(Q25);
                    record.Add(Q26);
                    record.Add(Q27);
                    record.Add(Q28);
                    record.Add(Q29);
                    record.Add(Q30);
                    record.Add(Q31);
                    record.Add(Q32);
                    record.Add(Q33);
                    record.Add(Q34);
                    record.Add(Q35);
                    record.Add(Q36);
                    record.Add(Q37);
                    record.Add(Q38);
                    record.Add(Q39);
                    record.Add(Q40);
                    record.Add(Q41);
                    record.Add(Q42);
                    record.Add(Q43);
                    record.Add(Q44);
                    record.Add(Q45);
                    record.Add(Q46);
                    record.Add(Q47);
                    record.Add(Q48);
                    record.Add(Q49);
                    record.Add(Q50);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Personal_Management_Style(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM PERSONAL_MANAGEMENT_STYLES WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Total_Spiritual_Gifts_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM TOTAL_SPIRITUAL_GIFTS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();
                    string Q14 = row["Q14"].ToString();
                    string Q15 = row["Q15"].ToString();
                    string Q16 = row["Q16"].ToString();
                    string Q17 = row["Q17"].ToString();
                    string Q18 = row["Q18"].ToString();
                    string Q19 = row["Q19"].ToString();
                    string Q20 = row["Q20"].ToString();
                    string Q21 = row["Q21"].ToString();
                    string Q22 = row["Q22"].ToString();
                    string Q23 = row["Q23"].ToString();
                    string Q24 = row["Q24"].ToString();
                    string Q25 = row["Q25"].ToString();
                    string Q26 = row["Q26"].ToString();
                    string Q27 = row["Q27"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);
                    record.Add(Q14);
                    record.Add(Q15);
                    record.Add(Q16);
                    record.Add(Q17);
                    record.Add(Q18);
                    record.Add(Q19);
                    record.Add(Q20);
                    record.Add(Q21);
                    record.Add(Q22);
                    record.Add(Q23);
                    record.Add(Q24);
                    record.Add(Q25);
                    record.Add(Q26);
                    record.Add(Q27);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Total_Spiritual_Gifts(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM TOTAL_SPIRITUAL_GIFTS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static int Select_Number_Of_Logins(string Username)
        {
            int val = 0;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            SqlDataAdapter da = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();

                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string numberOfLogins = row["NumberOfLogins"].ToString();

                    if (int.TryParse(numberOfLogins, out val))
                    {
                        val = val + 1;

                    }//end if

                }//end foreach

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return val;

        }//end method

        public static bool Is_User_Verified(string Username)
        {
            bool verified = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT Verified FROM BESTPATH_USER WHERE Username = @username AND Verified = 'Y'";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    verified = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return verified;

        }//end method

        public static bool User_Exists(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static bool Select_Focus_Analysis_Worksheet(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_ANALYSIS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Focus_Analysis_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM FOCUS_ANALYSIS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q1_1 = row["Q1_1"].ToString();
                    string Q1_2 = row["Q1_2"].ToString();
                    string Q1_3 = row["Q1_3"].ToString();
                    string Q1_4 = row["Q1_4"].ToString();
                    string Q1_5 = row["Q1_5"].ToString();
                    string Q1_6 = row["Q1_6"].ToString();
                    string Q1_7 = row["Q1_7"].ToString();
                    string Q1_8 = row["Q1_8"].ToString();
                    string Q1_9 = row["Q1_9"].ToString();
                    string Q1_10 = row["Q1_10"].ToString();
                    string Q1_11 = row["Q1_11"].ToString();
                    string Q1_12 = row["Q1_12"].ToString();
                    string Q1_13 = row["Q1_13"].ToString();
                    string Q1_14 = row["Q1_14"].ToString();
                    string Q1_15 = row["Q1_15"].ToString();
                    string Q1_16 = row["Q1_16"].ToString();
                    string Q1_17 = row["Q1_17"].ToString();
                    string Q1_18 = row["Q1_18"].ToString();
                    string Q1_19 = row["Q1_19"].ToString();
                    string Q1_20 = row["Q1_20"].ToString();
                    string Q2_1 = row["Q2_1"].ToString();
                    string Q2_2 = row["Q2_2"].ToString();
                    string Q2_3 = row["Q2_3"].ToString();
                    string Q2_4 = row["Q2_4"].ToString();
                    string Q2_5 = row["Q2_5"].ToString();
                    string Q2_6 = row["Q2_6"].ToString();
                    string Q2_7 = row["Q2_7"].ToString();
                    string Q2_8 = row["Q2_8"].ToString();
                    string Q2_9 = row["Q2_9"].ToString();
                    string Q2_10 = row["Q2_10"].ToString();
                    string Q2_11 = row["Q2_11"].ToString();
                    string Q2_12 = row["Q2_12"].ToString();
                    string Q2_13 = row["Q2_13"].ToString();
                    string Q2_14 = row["Q2_14"].ToString();
                    string Q2_15 = row["Q2_15"].ToString();
                    string Q2_16 = row["Q2_16"].ToString();
                    string Q2_17 = row["Q2_17"].ToString();
                    string Q2_18 = row["Q2_18"].ToString();
                    string Q2_19 = row["Q2_19"].ToString();
                    string Q2_20 = row["Q2_20"].ToString();
                    string Q3_1 = row["Q3_1"].ToString();
                    string Q3_2 = row["Q3_2"].ToString();
                    string Q3_3 = row["Q3_3"].ToString();
                    string Q3_4 = row["Q3_4"].ToString();
                    string Q3_5 = row["Q3_5"].ToString();
                    string Q3_6 = row["Q3_6"].ToString();
                    string Q3_7 = row["Q3_7"].ToString();
                    string Q3_8 = row["Q3_8"].ToString();
                    string Q3_9 = row["Q3_9"].ToString();
                    string Q3_10 = row["Q3_10"].ToString();
                    string Q3_11 = row["Q3_11"].ToString();
                    string Q3_12 = row["Q3_12"].ToString();
                    string Q3_13 = row["Q3_13"].ToString();
                    string Q3_14 = row["Q3_14"].ToString();
                    string Q3_15 = row["Q3_15"].ToString();
                    string Q3_16 = row["Q3_16"].ToString();
                    string Q3_17 = row["Q3_17"].ToString();
                    string Q3_18 = row["Q3_18"].ToString();
                    string Q3_19 = row["Q3_19"].ToString();
                    string Q3_20 = row["Q3_20"].ToString();
                    string Q4_1 = row["Q4_1"].ToString();
                    string Q4_2 = row["Q4_2"].ToString();
                    string Q4_3 = row["Q4_3"].ToString();
                    string Q4_4 = row["Q4_4"].ToString();
                    string Q4_5 = row["Q4_5"].ToString();
                    string Q4_6 = row["Q4_6"].ToString();
                    string Q4_7 = row["Q4_7"].ToString();
                    string Q4_8 = row["Q4_8"].ToString();
                    string Q4_9 = row["Q4_9"].ToString();
                    string Q4_10 = row["Q4_10"].ToString();
                    string Q4_11 = row["Q4_11"].ToString();
                    string Q4_12 = row["Q4_12"].ToString();
                    string Q4_13 = row["Q4_13"].ToString();
                    string Q4_14 = row["Q4_14"].ToString();
                    string Q4_15 = row["Q4_15"].ToString();
                    string Q4_16 = row["Q4_16"].ToString();
                    string Q4_17 = row["Q4_17"].ToString();
                    string Q4_18 = row["Q4_18"].ToString();
                    string Q4_19 = row["Q4_19"].ToString();
                    string Q4_20 = row["Q4_20"].ToString();
                    string Q5_1 = row["Q5_1"].ToString();
                    string Q5_2 = row["Q5_2"].ToString();
                    string Q5_3 = row["Q5_3"].ToString();
                    string Q5_4 = row["Q5_4"].ToString();
                    string Q5_5 = row["Q5_5"].ToString();
                    string Q5_6 = row["Q5_6"].ToString();
                    string Q5_7 = row["Q5_7"].ToString();
                    string Q5_8 = row["Q5_8"].ToString();
                    string Q5_9 = row["Q5_9"].ToString();
                    string Q5_10 = row["Q5_10"].ToString();
                    string Q5_11 = row["Q5_11"].ToString();
                    string Q5_12 = row["Q5_12"].ToString();
                    string Q5_13 = row["Q5_13"].ToString();
                    string Q5_14 = row["Q5_14"].ToString();
                    string Q5_15 = row["Q5_15"].ToString();
                    string Q5_16 = row["Q5_16"].ToString();
                    string Q5_17 = row["Q5_17"].ToString();
                    string Q5_18 = row["Q5_18"].ToString();
                    string Q5_19 = row["Q5_19"].ToString();
                    string Q5_20 = row["Q5_20"].ToString();
                    string Q6_1 = row["Q6_1"].ToString();
                    string Q6_2 = row["Q6_2"].ToString();
                    string Q6_3 = row["Q6_3"].ToString();
                    string Q6_4 = row["Q6_4"].ToString();
                    string Q6_5 = row["Q6_5"].ToString();
                    string Q6_6 = row["Q6_6"].ToString();
                    string Q6_7 = row["Q6_7"].ToString();
                    string Q6_8 = row["Q6_8"].ToString();
                    string Q6_9 = row["Q6_9"].ToString();
                    string Q6_10 = row["Q6_10"].ToString();
                    string Q6_11 = row["Q6_11"].ToString();
                    string Q6_12 = row["Q6_12"].ToString();
                    string Q6_13 = row["Q6_13"].ToString();
                    string Q6_14 = row["Q6_14"].ToString();
                    string Q6_15 = row["Q6_15"].ToString();
                    string Q6_16 = row["Q6_16"].ToString();
                    string Q6_17 = row["Q6_17"].ToString();
                    string Q6_18 = row["Q6_18"].ToString();
                    string Q6_19 = row["Q6_19"].ToString();
                    string Q6_20 = row["Q6_20"].ToString();
                    string Q7_1 = row["Q7_1"].ToString();
                    string Q7_2 = row["Q7_2"].ToString();
                    string Q7_3 = row["Q7_3"].ToString();
                    string Q7_4 = row["Q7_4"].ToString();
                    string Q7_5 = row["Q7_5"].ToString();
                    string Q7_6 = row["Q7_6"].ToString();
                    string Q7_7 = row["Q7_7"].ToString();
                    string Q7_8 = row["Q7_8"].ToString();
                    string Q7_9 = row["Q7_9"].ToString();
                    string Q7_10 = row["Q7_10"].ToString();
                    string Q7_11 = row["Q7_11"].ToString();
                    string Q7_12 = row["Q7_12"].ToString();
                    string Q7_13 = row["Q7_13"].ToString();
                    string Q7_14 = row["Q7_14"].ToString();
                    string Q7_15 = row["Q7_15"].ToString();
                    string Q7_16 = row["Q7_16"].ToString();
                    string Q7_17 = row["Q7_17"].ToString();
                    string Q7_18 = row["Q7_18"].ToString();
                    string Q7_19 = row["Q7_19"].ToString();
                    string Q7_20 = row["Q7_20"].ToString();
                    string Q8_1 = row["Q8_1"].ToString();
                    string Q8_2 = row["Q8_2"].ToString();
                    string Q8_3 = row["Q8_3"].ToString();
                    string Q8_4 = row["Q8_4"].ToString();
                    string Q8_5 = row["Q8_5"].ToString();
                    string Q8_6 = row["Q8_6"].ToString();
                    string Q8_7 = row["Q8_7"].ToString();
                    string Q8_8 = row["Q8_8"].ToString();
                    string Q8_9 = row["Q8_9"].ToString();
                    string Q8_10 = row["Q8_10"].ToString();
                    string Q8_11 = row["Q8_11"].ToString();
                    string Q8_12 = row["Q8_12"].ToString();
                    string Q8_13 = row["Q8_13"].ToString();
                    string Q8_14 = row["Q8_14"].ToString();
                    string Q8_15 = row["Q8_15"].ToString();
                    string Q8_16 = row["Q8_16"].ToString();
                    string Q8_17 = row["Q8_17"].ToString();
                    string Q8_18 = row["Q8_18"].ToString();
                    string Q8_19 = row["Q8_19"].ToString();
                    string Q8_20 = row["Q8_20"].ToString();
                    string Q9_1 = row["Q9_1"].ToString();
                    string Q9_2 = row["Q9_2"].ToString();
                    string Q9_3 = row["Q9_3"].ToString();
                    string Q9_4 = row["Q9_4"].ToString();
                    string Q9_5 = row["Q9_5"].ToString();
                    string Q9_6 = row["Q9_6"].ToString();
                    string Q9_7 = row["Q9_7"].ToString();
                    string Q9_8 = row["Q9_8"].ToString();
                    string Q9_9 = row["Q9_9"].ToString();
                    string Q9_10 = row["Q9_10"].ToString();
                    string Q9_11 = row["Q9_11"].ToString();
                    string Q9_12 = row["Q9_12"].ToString();
                    string Q9_13 = row["Q9_13"].ToString();
                    string Q9_14 = row["Q9_14"].ToString();
                    string Q9_15 = row["Q9_15"].ToString();
                    string Q9_16 = row["Q9_16"].ToString();
                    string Q9_17 = row["Q9_17"].ToString();
                    string Q9_18 = row["Q9_18"].ToString();
                    string Q9_19 = row["Q9_19"].ToString();
                    string Q9_20 = row["Q9_20"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();
                    string Q14 = row["Q14"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q1_1);
                    record.Add(Q1_2);
                    record.Add(Q1_3);
                    record.Add(Q1_4);
                    record.Add(Q1_5);
                    record.Add(Q1_6);
                    record.Add(Q1_7);
                    record.Add(Q1_8);
                    record.Add(Q1_9);
                    record.Add(Q1_10);
                    record.Add(Q1_11);
                    record.Add(Q1_12);
                    record.Add(Q1_13);
                    record.Add(Q1_14);
                    record.Add(Q1_15);
                    record.Add(Q1_16);
                    record.Add(Q1_17);
                    record.Add(Q1_18);
                    record.Add(Q1_19);
                    record.Add(Q1_20);
                    record.Add(Q2_1);
                    record.Add(Q2_2);
                    record.Add(Q2_3);
                    record.Add(Q2_4);
                    record.Add(Q2_5);
                    record.Add(Q2_6);
                    record.Add(Q2_7);
                    record.Add(Q2_8);
                    record.Add(Q2_9);
                    record.Add(Q2_10);
                    record.Add(Q2_11);
                    record.Add(Q2_12);
                    record.Add(Q2_13);
                    record.Add(Q2_14);
                    record.Add(Q2_15);
                    record.Add(Q2_16);
                    record.Add(Q2_17);
                    record.Add(Q2_18);
                    record.Add(Q2_19);
                    record.Add(Q2_20);
                    record.Add(Q3_1);
                    record.Add(Q3_2);
                    record.Add(Q3_3);
                    record.Add(Q3_4);
                    record.Add(Q3_5);
                    record.Add(Q3_6);
                    record.Add(Q3_7);
                    record.Add(Q3_8);
                    record.Add(Q3_9);
                    record.Add(Q3_10);
                    record.Add(Q3_11);
                    record.Add(Q3_12);
                    record.Add(Q3_13);
                    record.Add(Q3_14);
                    record.Add(Q3_15);
                    record.Add(Q3_16);
                    record.Add(Q3_17);
                    record.Add(Q3_18);
                    record.Add(Q3_19);
                    record.Add(Q3_20);
                    record.Add(Q4_1);
                    record.Add(Q4_2);
                    record.Add(Q4_3);
                    record.Add(Q4_4);
                    record.Add(Q4_5);
                    record.Add(Q4_6);
                    record.Add(Q4_7);
                    record.Add(Q4_8);
                    record.Add(Q4_9);
                    record.Add(Q4_10);
                    record.Add(Q4_11);
                    record.Add(Q4_12);
                    record.Add(Q4_13);
                    record.Add(Q4_14);
                    record.Add(Q4_15);
                    record.Add(Q4_16);
                    record.Add(Q4_17);
                    record.Add(Q4_18);
                    record.Add(Q4_19);
                    record.Add(Q4_20);
                    record.Add(Q5_1);
                    record.Add(Q5_2);
                    record.Add(Q5_3);
                    record.Add(Q5_4);
                    record.Add(Q5_5);
                    record.Add(Q5_6);
                    record.Add(Q5_7);
                    record.Add(Q5_8);
                    record.Add(Q5_9);
                    record.Add(Q5_10);
                    record.Add(Q5_11);
                    record.Add(Q5_12);
                    record.Add(Q5_13);
                    record.Add(Q5_14);
                    record.Add(Q5_15);
                    record.Add(Q5_16);
                    record.Add(Q5_17);
                    record.Add(Q5_18);
                    record.Add(Q5_19);
                    record.Add(Q5_20);
                    record.Add(Q6_1);
                    record.Add(Q6_2);
                    record.Add(Q6_3);
                    record.Add(Q6_4);
                    record.Add(Q6_5);
                    record.Add(Q6_6);
                    record.Add(Q6_7);
                    record.Add(Q6_8);
                    record.Add(Q6_9);
                    record.Add(Q6_10);
                    record.Add(Q6_11);
                    record.Add(Q6_12);
                    record.Add(Q6_13);
                    record.Add(Q6_14);
                    record.Add(Q6_15);
                    record.Add(Q6_16);
                    record.Add(Q6_17);
                    record.Add(Q6_18);
                    record.Add(Q6_19);
                    record.Add(Q6_20);
                    record.Add(Q7_1);
                    record.Add(Q7_2);
                    record.Add(Q7_3);
                    record.Add(Q7_4);
                    record.Add(Q7_5);
                    record.Add(Q7_6);
                    record.Add(Q7_7);
                    record.Add(Q7_8);
                    record.Add(Q7_9);
                    record.Add(Q7_10);
                    record.Add(Q7_11);
                    record.Add(Q7_12);
                    record.Add(Q7_13);
                    record.Add(Q7_14);
                    record.Add(Q7_15);
                    record.Add(Q7_16);
                    record.Add(Q7_17);
                    record.Add(Q7_18);
                    record.Add(Q7_19);
                    record.Add(Q7_20);
                    record.Add(Q8_1);
                    record.Add(Q8_2);
                    record.Add(Q8_3);
                    record.Add(Q8_4);
                    record.Add(Q8_5);
                    record.Add(Q8_6);
                    record.Add(Q8_7);
                    record.Add(Q8_8);
                    record.Add(Q8_9);
                    record.Add(Q8_10);
                    record.Add(Q8_11);
                    record.Add(Q8_12);
                    record.Add(Q8_13);
                    record.Add(Q8_14);
                    record.Add(Q8_15);
                    record.Add(Q8_16);
                    record.Add(Q8_17);
                    record.Add(Q8_18);
                    record.Add(Q8_19);
                    record.Add(Q8_20);
                    record.Add(Q9_1);
                    record.Add(Q9_2);
                    record.Add(Q9_3);
                    record.Add(Q9_4);
                    record.Add(Q9_5);
                    record.Add(Q9_6);
                    record.Add(Q9_7);
                    record.Add(Q9_8);
                    record.Add(Q9_9);
                    record.Add(Q9_10);
                    record.Add(Q9_11);
                    record.Add(Q9_12);
                    record.Add(Q9_13);
                    record.Add(Q9_14);
                    record.Add(Q9_15);
                    record.Add(Q9_16);
                    record.Add(Q9_17);
                    record.Add(Q9_18);
                    record.Add(Q9_19);
                    record.Add(Q9_20);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);
                    record.Add(Q14);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static ArrayList Select_Natural_Talents_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM NATURAL_TALENTS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Natural_Talents(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM NATURAL_TALENTS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Education_Inventory_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM EDUCATION_INVENTORY WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string undergraduateDegreeYN = row["UndergraduateDegreeYN"].ToString();
                    string undergraduateDegree = row["UndergraduateDegree"].ToString();
                    string undergraduateMajor = row["UndergraduateMajor"].ToString();
                    string undergraduateMinor = row["UndergraduateMinor"].ToString();
                    string graduateDegreeYN = row["GraduateDegreeYN"].ToString();
                    string graduateDegree = row["GraduateDegree"].ToString();
                    string graduateMajor = row["GraduateMajor"].ToString();
                    string collegeClasses = row["CollegeClasses"].ToString();
                    string classes = row["Classes"].ToString();
                    string hobbies = row["Hobbies"].ToString();
                    string fixingYN = row["FixingYN"].ToString();
                    string fixing = row["Fixing"].ToString();
                    string books = row["Books"].ToString();
                    string movies = row["Movies"].ToString();
                    string music = row["Music"].ToString();
                    string enjoyMost1 = row["EnjoyMost1"].ToString();
                    string enjoyMost2 = row["EnjoyMost2"].ToString();
                    string enjoyMost3 = row["EnjoyMost3"].ToString();

                    record.Add(undergraduateDegreeYN);
                    record.Add(undergraduateDegree);
                    record.Add(undergraduateMajor);
                    record.Add(undergraduateMinor);
                    record.Add(graduateDegreeYN);
                    record.Add(graduateDegree);
                    record.Add(graduateMajor);
                    record.Add(collegeClasses);
                    record.Add(classes);
                    record.Add(hobbies);
                    record.Add(fixingYN);
                    record.Add(fixing);
                    record.Add(books);
                    record.Add(movies);
                    record.Add(music);
                    record.Add(enjoyMost1);
                    record.Add(enjoyMost2);
                    record.Add(enjoyMost3);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

        public static bool Select_Education_Inventory(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM EDUCATION_INVENTORY WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static bool Select_Registration(string Username, string Password)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username AND Password = @password";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            selectCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static String Select_Forgot_Password_Record(string Username)
        {
            string securityQuestion = "";

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    securityQuestion = row["SecurityQuestion"].ToString();

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return securityQuestion;

        }//end method

        public static bool Select_Forgot_Password(string Username, string SecurityQuestion, string SecurityAnswer)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM BESTPATH_USER WHERE Username = @username AND SecurityQuestion = @securityQuestion AND SecurityAnswer = @securityAnswer";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            selectCommand.Parameters.Add("@securityQuestion", SqlDbType.VarChar).Value = SecurityQuestion;

            selectCommand.Parameters.Add("@securityAnswer", SqlDbType.VarChar).Value = SecurityAnswer;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static bool Select_Sharegiver_Talents(string Username)
        {
            bool recordExists = false;

            Select selectObject = new Select();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM SHAREGIVER_TALENTS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                object value = selectCommand.ExecuteScalar();

                if (value != null)
                {
                    recordExists = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return recordExists;

        }//end method

        public static ArrayList Select_Sharegiver_Talents_Record(string Username)
        {
            Select selectObject = new Select();

            ArrayList record = new ArrayList();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string selectStatement = "SELECT * FROM SHAREGIVER_TALENTS WHERE CLIENT_Username = @username";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(selectCommand);
                da.Fill(selectObject.dataTable);

                foreach (DataRow row in selectObject.dataTable.Rows)
                {
                    string Q1 = row["Q1"].ToString();
                    string Q2 = row["Q2"].ToString();
                    string Q3 = row["Q3"].ToString();
                    string Q4 = row["Q4"].ToString();
                    string Q5 = row["Q5"].ToString();
                    string Q6 = row["Q6"].ToString();
                    string Q7 = row["Q7"].ToString();
                    string Q8 = row["Q8"].ToString();
                    string Q9 = row["Q9"].ToString();
                    string Q10 = row["Q10"].ToString();
                    string Q11 = row["Q11"].ToString();
                    string Q12 = row["Q12"].ToString();
                    string Q13 = row["Q13"].ToString();
                    string Q14 = row["Q14"].ToString();
                    string Q15 = row["Q15"].ToString();
                    string Q16 = row["Q16"].ToString();
                    string Q17 = row["Q17"].ToString();
                    string Q18 = row["Q18"].ToString();
                    string Q19 = row["Q19"].ToString();
                    string Q20 = row["Q20"].ToString();
                    string Q21 = row["Q21"].ToString();
                    string Q22 = row["Q22"].ToString();
                    string Q23 = row["Q23"].ToString();
                    string Q24 = row["Q24"].ToString();
                    string Q25 = row["Q25"].ToString();
                    string Q26 = row["Q26"].ToString();
                    string Q27 = row["Q27"].ToString();
                    string Q28 = row["Q28"].ToString();
                    string Q29 = row["Q29"].ToString();
                    string Q30 = row["Q30"].ToString();
                    string Q31 = row["Q31"].ToString();
                    string Q32 = row["Q32"].ToString();
                    string Q33 = row["Q33"].ToString();
                    string Q34 = row["Q34"].ToString();
                    string Q35 = row["Q35"].ToString();
                    string Q36 = row["Q36"].ToString();
                    string Q37 = row["Q37"].ToString();
                    string Q38 = row["Q38"].ToString();
                    string Q39 = row["Q39"].ToString();
                    string Q40 = row["Q40"].ToString();
                    string Q41 = row["Q41"].ToString();
                    string Q42 = row["Q42"].ToString();
                    string Q43 = row["Q43"].ToString();
                    string Q44 = row["Q44"].ToString();
                    string Q45 = row["Q45"].ToString();
                    string Q46 = row["Q46"].ToString();
                    string Q47 = row["Q47"].ToString();
                    string Q48 = row["Q48"].ToString();
                    string Q49 = row["Q49"].ToString();
                    string Q50 = row["Q50"].ToString();
                    string Q51 = row["Q51"].ToString();
                    string Q52 = row["Q52"].ToString();
                    string Q53 = row["Q53"].ToString();
                    string Q54 = row["Q54"].ToString();
                    string Q55 = row["Q55"].ToString();
                    string Q56 = row["Q56"].ToString();
                    string Q57 = row["Q57"].ToString();
                    string Q58 = row["Q58"].ToString();
                    string Q59 = row["Q59"].ToString();
                    string Q60 = row["Q60"].ToString();
                    string Q61 = row["Q61"].ToString();
                    string Q62 = row["Q62"].ToString();
                    string Q63 = row["Q63"].ToString();
                    string Q64 = row["Q64"].ToString();
                    string Q65 = row["Q65"].ToString();
                    string Q66 = row["Q66"].ToString();
                    string Q67 = row["Q67"].ToString();
                    string Q68 = row["Q68"].ToString();
                    string Q69 = row["Q69"].ToString();
                    string Q70 = row["Q70"].ToString();
                    string Q71 = row["Q71"].ToString();
                    string Q72 = row["Q72"].ToString();
                    string Q73 = row["Q73"].ToString();
                    string Q74 = row["Q74"].ToString();
                    string Q75 = row["Q75"].ToString();
                    string Q76 = row["Q76"].ToString();
                    string Q77 = row["Q77"].ToString();
                    string Q78 = row["Q78"].ToString();
                    string Q79 = row["Q79"].ToString();

                    record.Add(Q1);
                    record.Add(Q2);
                    record.Add(Q3);
                    record.Add(Q4);
                    record.Add(Q5);
                    record.Add(Q6);
                    record.Add(Q7);
                    record.Add(Q8);
                    record.Add(Q9);
                    record.Add(Q10);
                    record.Add(Q11);
                    record.Add(Q12);
                    record.Add(Q13);
                    record.Add(Q14);
                    record.Add(Q15);
                    record.Add(Q16);
                    record.Add(Q17);
                    record.Add(Q18);
                    record.Add(Q19);
                    record.Add(Q20);
                    record.Add(Q21);
                    record.Add(Q22);
                    record.Add(Q23);
                    record.Add(Q24);
                    record.Add(Q25);
                    record.Add(Q26);
                    record.Add(Q27);
                    record.Add(Q28);
                    record.Add(Q29);
                    record.Add(Q30);
                    record.Add(Q31);
                    record.Add(Q32);
                    record.Add(Q33);
                    record.Add(Q34);
                    record.Add(Q35);
                    record.Add(Q36);
                    record.Add(Q37);
                    record.Add(Q38);
                    record.Add(Q39);
                    record.Add(Q40);
                    record.Add(Q41);
                    record.Add(Q42);
                    record.Add(Q43);
                    record.Add(Q44);
                    record.Add(Q45);
                    record.Add(Q46);
                    record.Add(Q47);
                    record.Add(Q48);
                    record.Add(Q49);
                    record.Add(Q50);
                    record.Add(Q51);
                    record.Add(Q52);
                    record.Add(Q53);
                    record.Add(Q54);
                    record.Add(Q55);
                    record.Add(Q56);
                    record.Add(Q57);
                    record.Add(Q58);
                    record.Add(Q59);
                    record.Add(Q60);
                    record.Add(Q61);
                    record.Add(Q62);
                    record.Add(Q63);
                    record.Add(Q64);
                    record.Add(Q65);
                    record.Add(Q66);
                    record.Add(Q67);
                    record.Add(Q68);
                    record.Add(Q69);
                    record.Add(Q70);
                    record.Add(Q71);
                    record.Add(Q72);
                    record.Add(Q73);
                    record.Add(Q74);
                    record.Add(Q75);
                    record.Add(Q76);
                    record.Add(Q77);
                    record.Add(Q78);
                    record.Add(Q79);

                }//end foreach

                da.Dispose();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                selectObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return record;

        }//end method

    }//end class

}//end namespace