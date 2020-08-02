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
    public class Update
    {
        private string errorMessage;

        public string getErrorMessage()
        {
            return this.errorMessage;

        }//end property

        public void setErrorMessage(string ErrorMessage)
        {
            this.errorMessage = ErrorMessage;

        }//end property

        public Update()
        {
            this.errorMessage = null;

        }//end constructor

        public static string Update_Is_Not_RUG_APC(string Username)
        {
            string IsNotRUGAPC = "N";

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET IsRUGAPC = @IsRUGAPC WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@IsRUGAPC", SqlDbType.Char).Value = IsNotRUGAPC;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Is_RUG_APC(string Username)
        {
            string IsRUGAPC = "Y";

            string role = "Admin";

            ArrayList bestPathUserKeys = new ArrayList();

            bestPathUserKeys = Select.Select_BESTPATH_USER_Encryption_Keys(Username);

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

            byte[] encryptedRole = Encryption.Encrypt_AES(role, decrypted_BESTPATH_USER_Key_Array, decrypted_BESTPATH_USER_IV_Array);

            string encryptedRoleString = Convert.ToBase64String(encryptedRole);

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET IsRUGAPC = @IsRUGAPC, Role = @role WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@IsRUGAPC", SqlDbType.Char).Value = IsRUGAPC;

            updateCommand.Parameters.Add("@role", SqlDbType.Char).Value = encryptedRoleString;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_ClientName_BESTPATH_USER(string ClientUsername, string Encrypted_FirstName, string Encrypted_LastName)
        {
            string errorMessage = "";

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET FirstName = @firstName, LastName = @lastName WHERE Username = @clientUsername";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@clientUsername", SqlDbType.VarChar).Value = ClientUsername;

            updateCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = Encrypted_FirstName;

            updateCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = Encrypted_LastName;

            try
            {
                connection.Open();

                updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return errorMessage;

        }//end method

        public static string Update_CounselorName(string ClientUsername, string Encrypted_CounselorName)
        {
            string errorMessage = "";

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET CounselorName = @counselorName WHERE Username = @clientUsername";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@clientUsername", SqlDbType.VarChar).Value = ClientUsername;

            updateCommand.Parameters.Add("@counselorName", SqlDbType.VarChar).Value = Encrypted_CounselorName;

            try
            {
                connection.Open();

                updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return errorMessage;

        }//end method

        public static string Update_BeforeYouBegin_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET BeforeYouBegin = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Password_SecurityQuestion_SecurityAnswer(string Username, string Encrypted_Password, string Encrypted_SecurityQuestion, string Encrypted_SecurityAnswer)
        {
            string errorMessage = "";

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET Password = @password, SecurityQuestion = @securityQuestion, SecurityAnswer = @securityAnswer WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = Encrypted_Password;

            updateCommand.Parameters.Add("@securityQuestion", SqlDbType.VarChar).Value = Encrypted_SecurityQuestion;

            updateCommand.Parameters.Add("@securityAnswer", SqlDbType.VarChar).Value = Encrypted_SecurityAnswer;

            try
            {
                connection.Open();

                updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return errorMessage;

        }//end method

        public static string Update_SecurityAnswer(string Username, string Encrypted_Password)
        {
            string errorMessage = "";

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET SecurityAnswer = @password WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = Encrypted_Password;

            try
            {
                connection.Open();

                updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return errorMessage;

        }//end method

        public static string Update_Session_Data2(string Username, DateTime Expiration, bool Expired)
        {
            Insert updateObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE SESSION SET Expiration = @expiration, Expired = @expired WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@expiration", SqlDbType.DateTime).Value = Expiration;

            updateCommand.Parameters.Add("@expired", SqlDbType.VarChar).Value = Expired;

                connection.Open();

                updateCommand.ExecuteNonQuery();

                connection.Close();

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Session_Data(string Username, DateTime Expiration, bool Expired, DateTime IssueDate, string Role)
        {
            Insert updateObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE SESSION SET Expiration = @expiration, Expired = @expired, IssueDate = @issueDate, Role = @role WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@expiration", SqlDbType.DateTime).Value = Expiration;

            updateCommand.Parameters.Add("@expired", SqlDbType.VarChar).Value = Expired;

            updateCommand.Parameters.Add("@issueDate", SqlDbType.DateTime).Value = IssueDate;

            updateCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = Role;

            try
            {
                connection.Open();

                updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_CLIENT(string Username, string EncryptedFirstName, string EncryptedLastName, string EncryptedDOB, string EncryptedStreetAddress, string EncryptedCity, string EncryptedState, string EncryptedZipCode, string EncryptedPhone, string EmailAddress, string EncryptedKey, string EncryptedIV)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE CLIENT SET FirstName = @firstName, LastName = @lastName, DOB = @dob, StreetAddress = @streetAddress, City = @city, State = @state, ZipCode = @zipCode, Phone = @phone, _Key = @key, _IV = @iv WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = EncryptedFirstName;

            updateCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = EncryptedLastName;

            updateCommand.Parameters.Add("@dob", SqlDbType.VarChar).Value = EncryptedDOB;

            updateCommand.Parameters.Add("@streetAddress", SqlDbType.VarChar).Value = EncryptedStreetAddress;

            updateCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = EncryptedCity;

            updateCommand.Parameters.Add("@state", SqlDbType.VarChar).Value = EncryptedState;

            updateCommand.Parameters.Add("@zipCode", SqlDbType.VarChar).Value = EncryptedZipCode;

            updateCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = EncryptedPhone;

            updateCommand.Parameters.Add("@key", SqlDbType.VarChar).Value = EncryptedKey;

            updateCommand.Parameters.Add("@iv", SqlDbType.VarChar).Value = EncryptedIV;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Congratulations_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET Congratulations = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Password(string Username, byte[] Key, byte[] IV)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            CreatePassword passwordObject = new CreatePassword();

            string newPassword = passwordObject.Create_Password(8);

            byte[] encryptedPassword = Encryption.Encrypt_AES(newPassword, Key, IV);

            string encryptedPasswordString = Convert.ToBase64String(encryptedPassword);

            string updateStatement = "UPDATE BESTPATH_USER SET Password = @password WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = encryptedPasswordString;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return newPassword;

        }//end method

        public static string Update_Deliverable_Creation_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET MarketingDocumentsCreation = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Deliverable_Creation8(string Username, string Name1, string Title1, string Company1, string Relationship1, string Email1, string Phone1, string Name2, string Title2, string Company2, string Relationship2, string Email2, string Phone2, string Name3, string Title3, string Company3, string Relationship3, string Email3, string Phone3, string Name4, string Title4, string Company4, string Relationship4, string Email4, string Phone4, string Name5, string Title5, string Company5, string Relationship5, string Email5, string Phone5, string Name6, string Title6, string Company6, string Relationship6, string Email6, string Phone6, string Name7, string Title7, string Company7, string Relationship7, string Email7, string Phone7, string Name8, string Title8, string Company8, string Relationship8, string Email8, string Phone8)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE DELIVERABLE_CREATION SET Name1 = @name1, Title1 = @title1, Company1 = @company1, Relationship1 = @relationship1, Email1 = @email1, Phone1 = @phone1, Name2 = @name2, Title2 = @title2, Company2 = @company2, Relationship2 = @relationship2, Email2 = @email2, Phone2 = @phone2, Name3 = @name3, Title3 = @title3, Company3 = @company3, Relationship3 = @relationship3, Email3 = @email3, Phone3 = @phone3, Name4 = @name4, Title4 = @title4, Company4 = @company4, Relationship4 = @relationship4, Email4 = @email4, Phone4 = @phone4, Name5 = @name5, Title5 = @title5, Company5 = @company5, Relationship5 = @relationship5, Email5 = @email5, Phone5 = @phone5, Name6 = @name6, Title6 = @title6, Company6 = @company6, Relationship6 = @relationship6, Email6 = @email6, Phone6 = @phone6, Name7 = @name7, Title7 = @title7, Company7 = @company7, Relationship7 = @relationship7, Email7 = @email7, Phone7 = @phone7, Name8 = @name8, Title8 = @title8, Company8 = @company8, Relationship8 = @relationship8, Email8 = @email8, Phone8 = @phone8 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@name1", SqlDbType.VarChar).Value = Name1;

            updateCommand.Parameters.Add("@title1", SqlDbType.VarChar).Value = Title1;

            updateCommand.Parameters.Add("@company1", SqlDbType.VarChar).Value = Company1;

            updateCommand.Parameters.Add("@relationship1", SqlDbType.VarChar).Value = Relationship1;

            updateCommand.Parameters.Add("@email1", SqlDbType.VarChar).Value = Email1;

            updateCommand.Parameters.Add("@phone1", SqlDbType.Char).Value = Phone1;

            updateCommand.Parameters.Add("@name2", SqlDbType.VarChar).Value = Name2;

            updateCommand.Parameters.Add("@title2", SqlDbType.VarChar).Value = Title2;

            updateCommand.Parameters.Add("@company2", SqlDbType.VarChar).Value = Company2;

            updateCommand.Parameters.Add("@relationship2", SqlDbType.VarChar).Value = Relationship2;

            updateCommand.Parameters.Add("@email2", SqlDbType.VarChar).Value = Email2;

            updateCommand.Parameters.Add("@phone2", SqlDbType.Char).Value = Phone2;

            updateCommand.Parameters.Add("@name3", SqlDbType.VarChar).Value = Name3;

            updateCommand.Parameters.Add("@title3", SqlDbType.VarChar).Value = Title3;

            updateCommand.Parameters.Add("@company3", SqlDbType.VarChar).Value = Company3;

            updateCommand.Parameters.Add("@relationship3", SqlDbType.VarChar).Value = Relationship3;

            updateCommand.Parameters.Add("@email3", SqlDbType.VarChar).Value = Email3;

            updateCommand.Parameters.Add("@phone3", SqlDbType.Char).Value = Phone3;

            updateCommand.Parameters.Add("@name4", SqlDbType.VarChar).Value = Name4;

            updateCommand.Parameters.Add("@title4", SqlDbType.VarChar).Value = Title4;

            updateCommand.Parameters.Add("@company4", SqlDbType.VarChar).Value = Company4;

            updateCommand.Parameters.Add("@relationship4", SqlDbType.VarChar).Value = Relationship4;

            updateCommand.Parameters.Add("@email4", SqlDbType.VarChar).Value = Email4;

            updateCommand.Parameters.Add("@phone4", SqlDbType.Char).Value = Phone4;

            updateCommand.Parameters.Add("@name5", SqlDbType.VarChar).Value = Name5;

            updateCommand.Parameters.Add("@title5", SqlDbType.VarChar).Value = Title5;

            updateCommand.Parameters.Add("@company5", SqlDbType.VarChar).Value = Company5;

            updateCommand.Parameters.Add("@relationship5", SqlDbType.VarChar).Value = Relationship5;

            updateCommand.Parameters.Add("@email5", SqlDbType.VarChar).Value = Email5;

            updateCommand.Parameters.Add("@phone5", SqlDbType.Char).Value = Phone5;

            updateCommand.Parameters.Add("@name6", SqlDbType.VarChar).Value = Name6;

            updateCommand.Parameters.Add("@title6", SqlDbType.VarChar).Value = Title6;

            updateCommand.Parameters.Add("@company6", SqlDbType.VarChar).Value = Company6;

            updateCommand.Parameters.Add("@relationship6", SqlDbType.VarChar).Value = Relationship6;

            updateCommand.Parameters.Add("@email6", SqlDbType.VarChar).Value = Email6;

            updateCommand.Parameters.Add("@phone6", SqlDbType.Char).Value = Phone6;

            updateCommand.Parameters.Add("@name7", SqlDbType.VarChar).Value = Name7;

            updateCommand.Parameters.Add("@title7", SqlDbType.VarChar).Value = Title7;

            updateCommand.Parameters.Add("@company7", SqlDbType.VarChar).Value = Company7;

            updateCommand.Parameters.Add("@relationship7", SqlDbType.VarChar).Value = Relationship7;

            updateCommand.Parameters.Add("@email7", SqlDbType.VarChar).Value = Email7;

            updateCommand.Parameters.Add("@phone7", SqlDbType.Char).Value = Phone7;

            updateCommand.Parameters.Add("@name8", SqlDbType.VarChar).Value = Name8;

            updateCommand.Parameters.Add("@title8", SqlDbType.VarChar).Value = Title8;

            updateCommand.Parameters.Add("@company8", SqlDbType.VarChar).Value = Company8;

            updateCommand.Parameters.Add("@relationship8", SqlDbType.VarChar).Value = Relationship8;

            updateCommand.Parameters.Add("@email8", SqlDbType.VarChar).Value = Email8;

            updateCommand.Parameters.Add("@phone8", SqlDbType.Char).Value = Phone8;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Deliverable_Creation7(string Username, string Education, string Training, string HonorsAndAwards, string MilitaryService, string VoluntaryPositions, string Other)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE DELIVERABLE_CREATION SET Education = @education, Training = @training, HonorsAndAwards = @honorsAndAwards, MilitaryService = @militaryService, VoluntaryPositions = @voluntaryPositions, Other = @other WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@education", SqlDbType.VarChar).Value = Education;

            updateCommand.Parameters.Add("@training", SqlDbType.VarChar).Value = Training;

            updateCommand.Parameters.Add("@honorsAndAwards", SqlDbType.VarChar).Value = HonorsAndAwards;

            updateCommand.Parameters.Add("@militaryService", SqlDbType.VarChar).Value = MilitaryService;

            updateCommand.Parameters.Add("@voluntaryPositions", SqlDbType.VarChar).Value = VoluntaryPositions;

            updateCommand.Parameters.Add("@other", SqlDbType.VarChar).Value = Other;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Deliverable_Creation6(string Username, string JobTitle1, string CompanyName1, string Years1, string Narrative1, string JobTitle2, string CompanyName2, string Years2, string Narrative2, string JobTitle3, string CompanyName3, string Years3, string Narrative3, string JobTitle4, string CompanyName4, string Years4, string Narrative4, string JobTitle5, string CompanyName5, string Years5, string Narrative5)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE DELIVERABLE_CREATION SET JobTitle1 = @jobtitle1, CompanyName1 = @companyName1, Years1 = @years1, Narrative1 = @narrative1, JobTitle2 = @jobTitle2, CompanyName2 = @companyName2, Years2 = @years2, Narrative2 = @narrative2, JobTitle3 = @jobTitle3, CompanyName3 = @companyName3, Years3 = @years3, Narrative3 = @narrative3, JobTitle4 = @jobTitle4, CompanyName4 = @companyName4, Years4 = @years4, Narrative4 = @narrative4, JobTitle5 = @jobTitle5, CompanyName5 = @companyName5, Years5 = @years5, Narrative5 = @narrative5 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@jobTitle1", SqlDbType.VarChar).Value = JobTitle1;

            updateCommand.Parameters.Add("@companyName1", SqlDbType.VarChar).Value = CompanyName1;

            updateCommand.Parameters.Add("@years1", SqlDbType.Char).Value = Years1;

            updateCommand.Parameters.Add("@narrative1", SqlDbType.VarChar).Value = Narrative1;

            updateCommand.Parameters.Add("@jobTitle2", SqlDbType.VarChar).Value = JobTitle2;

            updateCommand.Parameters.Add("@companyName2", SqlDbType.VarChar).Value = CompanyName2;

            updateCommand.Parameters.Add("@years2", SqlDbType.Char).Value = Years2;

            updateCommand.Parameters.Add("@narrative2", SqlDbType.VarChar).Value = Narrative2;

            updateCommand.Parameters.Add("@jobTitle3", SqlDbType.VarChar).Value = JobTitle3;

            updateCommand.Parameters.Add("@companyName3", SqlDbType.VarChar).Value = CompanyName3;

            updateCommand.Parameters.Add("@years3", SqlDbType.Char).Value = Years3;

            updateCommand.Parameters.Add("@narrative3", SqlDbType.VarChar).Value = Narrative3;

            updateCommand.Parameters.Add("@jobTitle4", SqlDbType.VarChar).Value = JobTitle4;

            updateCommand.Parameters.Add("@companyName4", SqlDbType.VarChar).Value = CompanyName4;

            updateCommand.Parameters.Add("@years4", SqlDbType.Char).Value = Years4;

            updateCommand.Parameters.Add("@narrative4", SqlDbType.VarChar).Value = Narrative4;

            updateCommand.Parameters.Add("@jobTitle5", SqlDbType.VarChar).Value = JobTitle5;

            updateCommand.Parameters.Add("@companyName5", SqlDbType.VarChar).Value = CompanyName5;

            updateCommand.Parameters.Add("@years5", SqlDbType.Char).Value = Years5;

            updateCommand.Parameters.Add("@narrative5", SqlDbType.VarChar).Value = Narrative5;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Deliverable_Creation5(string Username, string Section4Title, string JobTitles)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE DELIVERABLE_CREATION SET Section4Title = @section4Title, JobTitles = @jobTitles WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@section4Title", SqlDbType.VarChar).Value = Section4Title;

            updateCommand.Parameters.Add("@jobTitles", SqlDbType.VarChar).Value = JobTitles;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Deliverable_Creation4(string Username, string Section3Title, string Achievement1, string Achievement2, string Achievement3, string Achievement4, string Achievement5, string Achievement6, string Achievement7, string Achievement8)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE DELIVERABLE_CREATION SET Section3Title = @section3Title, Achievement1 = @achievement1, Achievement2 = @achievement2, Achievement3 = @achievement3, Achievement4 = @achievement4, Achievement5 = @achievement5, Achievement6 = @achievement6, Achievement7 = @achievement7, Achievement8 = @achievement8 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@section3Title", SqlDbType.VarChar).Value = Section3Title;

            updateCommand.Parameters.Add("@achievement1", SqlDbType.VarChar).Value = Achievement1;

            updateCommand.Parameters.Add("@achievement2", SqlDbType.VarChar).Value = Achievement2;

            updateCommand.Parameters.Add("@achievement3", SqlDbType.VarChar).Value = Achievement3;

            updateCommand.Parameters.Add("@achievement4", SqlDbType.VarChar).Value = Achievement4;

            updateCommand.Parameters.Add("@achievement5", SqlDbType.VarChar).Value = Achievement5;

            updateCommand.Parameters.Add("@achievement6", SqlDbType.VarChar).Value = Achievement6;

            updateCommand.Parameters.Add("@achievement7", SqlDbType.VarChar).Value = Achievement7;

            updateCommand.Parameters.Add("@achievement8", SqlDbType.VarChar).Value = Achievement8;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Deliverable_Creation3(string Username, string Qualification1, string Qualification2, string Qualification3, string Qualification4, string Qualification5, string Qualification6, string Qualification7, string Qualification8, string Qualification9)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE DELIVERABLE_CREATION SET Qualification1 = @qualification1, Qualification2 = @qualification2, Qualification3 = @qualification3, Qualification4 = @qualification4, Qualification5 = @qualification5, Qualification6 = @qualification6, Qualification7 = @qualification7, Qualification8 = @qualification8, Qualification9 = @qualification9 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@qualification1", SqlDbType.VarChar).Value = Qualification1;

            updateCommand.Parameters.Add("@qualification2", SqlDbType.VarChar).Value = Qualification2;

            updateCommand.Parameters.Add("@qualification3", SqlDbType.VarChar).Value = Qualification3;

            updateCommand.Parameters.Add("@qualification4", SqlDbType.VarChar).Value = Qualification4;

            updateCommand.Parameters.Add("@qualification5", SqlDbType.VarChar).Value = Qualification5;

            updateCommand.Parameters.Add("@qualification6", SqlDbType.VarChar).Value = Qualification6;

            updateCommand.Parameters.Add("@qualification7", SqlDbType.VarChar).Value = Qualification7;

            updateCommand.Parameters.Add("@qualification8", SqlDbType.VarChar).Value = Qualification8;

            updateCommand.Parameters.Add("@qualification9", SqlDbType.VarChar).Value = Qualification9;






            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Deliverable_Creation2(string Username, string Section2Title, string PersonalDescriptor1, string PersonalDescriptor2, string PersonalDescriptor3)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE DELIVERABLE_CREATION SET Section2Title = @section2Title, PersonalDescriptor1 = @personalDescriptor1, PersonalDescriptor2 = @personalDescriptor2, PersonalDescriptor3 = @personalDescriptor3 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@section2Title", SqlDbType.VarChar).Value = Section2Title;

            updateCommand.Parameters.Add("@personalDescriptor1", SqlDbType.VarChar).Value = PersonalDescriptor1;

            updateCommand.Parameters.Add("@personalDescriptor2", SqlDbType.VarChar).Value = PersonalDescriptor2;

            updateCommand.Parameters.Add("@personalDescriptor3", SqlDbType.VarChar).Value = PersonalDescriptor3;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Deliverable_Creation(string Username, string Section1Title, string Focus, string Theme1, string Theme2, string Theme3)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE DELIVERABLE_CREATION SET Section1Title = @section1Title, Focus = @focus, Theme1 = @theme1, Theme2 = @theme2, Theme3 = @theme3 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@section1Title", SqlDbType.VarChar).Value = Section1Title;

            updateCommand.Parameters.Add("@focus", SqlDbType.VarChar).Value = Focus;

            updateCommand.Parameters.Add("@theme1", SqlDbType.VarChar).Value = Theme1;

            updateCommand.Parameters.Add("@theme2", SqlDbType.VarChar).Value = Theme2;

            updateCommand.Parameters.Add("@theme3", SqlDbType.VarChar).Value = Theme3;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Total_Spiritual_Gifts_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET TotalSpiritualGifts = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Total_Spiritual_Gifts(string Username, string Q22, string Q23, string Q24, string Q25, string Q26, string Q27)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE TOTAL_SPIRITUAL_GIFTS SET Q22 = @q22, Q23 = @q23, Q24 = @q24, Q25 = @q25, Q26 = @q26, Q27 = @q27 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q22", SqlDbType.VarChar).Value = Q22;

            updateCommand.Parameters.Add("@q23", SqlDbType.VarChar).Value = Q23;

            updateCommand.Parameters.Add("@q24", SqlDbType.VarChar).Value = Q24;

            updateCommand.Parameters.Add("@q25", SqlDbType.VarChar).Value = Q25;

            updateCommand.Parameters.Add("@q26", SqlDbType.VarChar).Value = Q26;

            updateCommand.Parameters.Add("@q27", SqlDbType.VarChar).Value = Q27;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Personal_Management_Style(string Username, string Q41, string Q44, string Q47, string Q50)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE PERSONAL_MANAGEMENT_STYLES SET Q41 = @q41, Q44 = @q44, Q47 = @q47, Q50 = @q50 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q41", SqlDbType.VarChar).Value = Q41;

            updateCommand.Parameters.Add("@q44", SqlDbType.VarChar).Value = Q44;

            updateCommand.Parameters.Add("@q47", SqlDbType.VarChar).Value = Q47;

            updateCommand.Parameters.Add("@q50", SqlDbType.VarChar).Value = Q50;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Personal_Management_Style_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET PersonalManagementStyle = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience12_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience12 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience11_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience11 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience10_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience10 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience9_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience9 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience8_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience8 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience7_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience7 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience6_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience6 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience5_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience5 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience4_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience4 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience3_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience3 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience2_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience2 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Experience1_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusExperience1 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Spiritual_Gifts_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET IdentifyingSpiritualGifts = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Expressing_Personal_Genius_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET ExpressingYourPersonalGenius = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Fundamental_Life_Motivators_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FundamentalLifeMotivators = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Perception_Response_Summary_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET PerceptionResponseSummary = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Creativity_Cycle_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET CreativityCycle = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Demonstration_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusDemonstrationWorksheet = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Consolidation_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusConsolidationWorksheet = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static bool Update_Number_Of_Logins(string Username, int NumberOfLogins)
        {
            bool updated = false;

            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET NumberOfLogins = @numberOfLogins WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@numberOfLogins", SqlDbType.Int).Value = NumberOfLogins;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows == 1)
                {
                    updated = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updated;

        }//end method

        public static bool Update_Date_Of_Last_Login(string Username)
        {
            bool updated = false;

            DateTime today = DateTime.Today;
            
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET DateOfLastLogin = @today WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows == 1)
                {
                    updated = true;

                }//end if

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updated;

        }//end method

        public static string Update_Verify_New_User(string Username)
        {
            string verified = "Y";
            
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET Verified = @verified WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@verified", SqlDbType.Char).Value = verified;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Change_Password(string Username, string NewPassword)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET Password = @password WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = NewPassword;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusAnalysisWorksheet = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet9(string Username, string Q9_1, string Q9_2, string Q9_3, string Q9_4, string Q9_5, string Q9_6, string Q9_7, string Q9_8, string Q9_9, string Q9_10, string Q9_11, string Q9_12, string Q9_13, string Q9_14, string Q9_15, string Q9_16, string Q9_17, string Q9_18, string Q9_19, string Q9_20, string Q9, string Q10, string Q11, string Q12, string Q13, string Q14)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q9_1 = @q9_1, Q9_2 = @q9_2, Q9_3 = @q9_3, Q9_4 = @q9_4, Q9_5 = @q9_5, Q9_6 = @q9_6, Q9_7 = @q9_7, Q9_8 = @q9_8, Q9_9 = @q9_9, Q9_10 = @q9_10, Q9_11 = @q9_11, Q9_12 = @q9_12, Q9_13 = @q9_13, Q9_14 = @q9_14, Q9_15 = @q9_15, Q9_16 = @q9_16, Q9_17 = @q9_17, Q9_18 = @q9_18, Q9_19 = @q9_19, Q9_20 = @q9_20, Q9 = @q9, Q10 = @q10, Q11 = @q11, Q12 = @q12, Q13 = @q13, Q14 = @q14 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q9_1", SqlDbType.VarChar).Value = Q9_1;

            updateCommand.Parameters.Add("@q9_2", SqlDbType.VarChar).Value = Q9_2;

            updateCommand.Parameters.Add("@q9_3", SqlDbType.VarChar).Value = Q9_3;

            updateCommand.Parameters.Add("@q9_4", SqlDbType.VarChar).Value = Q9_4;

            updateCommand.Parameters.Add("@q9_5", SqlDbType.VarChar).Value = Q9_5;

            updateCommand.Parameters.Add("@q9_6", SqlDbType.VarChar).Value = Q9_6;

            updateCommand.Parameters.Add("@q9_7", SqlDbType.VarChar).Value = Q9_7;

            updateCommand.Parameters.Add("@q9_8", SqlDbType.VarChar).Value = Q9_8;

            updateCommand.Parameters.Add("@q9_9", SqlDbType.VarChar).Value = Q9_9;

            updateCommand.Parameters.Add("@q9_10", SqlDbType.VarChar).Value = Q9_10;

            updateCommand.Parameters.Add("@q9_11", SqlDbType.VarChar).Value = Q9_11;

            updateCommand.Parameters.Add("@q9_12", SqlDbType.VarChar).Value = Q9_12;

            updateCommand.Parameters.Add("@q9_13", SqlDbType.VarChar).Value = Q9_13;

            updateCommand.Parameters.Add("@q9_14", SqlDbType.VarChar).Value = Q9_14;

            updateCommand.Parameters.Add("@q9_15", SqlDbType.VarChar).Value = Q9_15;

            updateCommand.Parameters.Add("@q9_16", SqlDbType.VarChar).Value = Q9_16;

            updateCommand.Parameters.Add("@q9_17", SqlDbType.VarChar).Value = Q9_17;

            updateCommand.Parameters.Add("@q9_18", SqlDbType.VarChar).Value = Q9_18;

            updateCommand.Parameters.Add("@q9_19", SqlDbType.VarChar).Value = Q9_19;

            updateCommand.Parameters.Add("@q9_20", SqlDbType.VarChar).Value = Q9_20;

            updateCommand.Parameters.Add("@q9", SqlDbType.VarChar).Value = Q9;

            updateCommand.Parameters.Add("@q10", SqlDbType.VarChar).Value = Q10;

            updateCommand.Parameters.Add("@q11", SqlDbType.VarChar).Value = Q11;

            updateCommand.Parameters.Add("@q12", SqlDbType.VarChar).Value = Q12;

            updateCommand.Parameters.Add("@q13", SqlDbType.VarChar).Value = Q13;

            updateCommand.Parameters.Add("@q14", SqlDbType.VarChar).Value = Q14;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet8(string Username, string Q8_1, string Q8_2, string Q8_3, string Q8_4, string Q8_5, string Q8_6, string Q8_7, string Q8_8, string Q8_9, string Q8_10, string Q8_11, string Q8_12, string Q8_13, string Q8_14, string Q8_15, string Q8_16, string Q8_17, string Q8_18, string Q8_19, string Q8_20)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q8_1 = @q8_1, Q8_2 = @q8_2, Q8_3 = @q8_3, Q8_4 = @q8_4, Q8_5 = @q8_5, Q8_6 = @q8_6, Q8_7 = @q8_7, Q8_8 = @q8_8, Q8_9 = @q8_9, Q8_10 = @q8_10, Q8_11 = @q8_11, Q8_12 = @q8_12, Q8_13 = @q8_13, Q8_14 = @q8_14, Q8_15 = @q8_15, Q8_16 = @q8_16, Q8_17 = @q8_17, Q8_18 = @q8_18, Q8_19 = @q8_19, Q8_20 = @q8_20 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q8_1", SqlDbType.VarChar).Value = Q8_1;

            updateCommand.Parameters.Add("@q8_2", SqlDbType.VarChar).Value = Q8_2;

            updateCommand.Parameters.Add("@q8_3", SqlDbType.VarChar).Value = Q8_3;

            updateCommand.Parameters.Add("@q8_4", SqlDbType.VarChar).Value = Q8_4;

            updateCommand.Parameters.Add("@q8_5", SqlDbType.VarChar).Value = Q8_5;

            updateCommand.Parameters.Add("@q8_6", SqlDbType.VarChar).Value = Q8_6;

            updateCommand.Parameters.Add("@q8_7", SqlDbType.VarChar).Value = Q8_7;

            updateCommand.Parameters.Add("@q8_8", SqlDbType.VarChar).Value = Q8_8;

            updateCommand.Parameters.Add("@q8_9", SqlDbType.VarChar).Value = Q8_9;

            updateCommand.Parameters.Add("@q8_10", SqlDbType.VarChar).Value = Q8_10;

            updateCommand.Parameters.Add("@q8_11", SqlDbType.VarChar).Value = Q8_11;

            updateCommand.Parameters.Add("@q8_12", SqlDbType.VarChar).Value = Q8_12;

            updateCommand.Parameters.Add("@q8_13", SqlDbType.VarChar).Value = Q8_13;

            updateCommand.Parameters.Add("@q8_14", SqlDbType.VarChar).Value = Q8_14;

            updateCommand.Parameters.Add("@q8_15", SqlDbType.VarChar).Value = Q8_15;

            updateCommand.Parameters.Add("@q8_16", SqlDbType.VarChar).Value = Q8_16;

            updateCommand.Parameters.Add("@q8_17", SqlDbType.VarChar).Value = Q8_17;

            updateCommand.Parameters.Add("@q8_18", SqlDbType.VarChar).Value = Q8_18;

            updateCommand.Parameters.Add("@q8_19", SqlDbType.VarChar).Value = Q8_19;

            updateCommand.Parameters.Add("@q8_20", SqlDbType.VarChar).Value = Q8_20;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet7(string Username, string Q7_1, string Q7_2, string Q7_3, string Q7_4, string Q7_5, string Q7_6, string Q7_7, string Q7_8, string Q7_9, string Q7_10, string Q7_11, string Q7_12, string Q7_13, string Q7_14, string Q7_15, string Q7_16, string Q7_17, string Q7_18, string Q7_19, string Q7_20)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q7_1= @q7_1, Q7_2 = @q7_2, Q7_3 = @q7_3, Q7_4 = @q7_4, Q7_5 = @q7_5, Q7_6 = @q7_6, Q7_7 = @q7_7, Q7_8 = @q7_8, Q7_9 = @q7_9, Q7_10 = @q7_10, Q7_11 = @q7_11, Q7_12 = @q7_12, Q7_13 = @q7_13, Q7_14 = @q7_14, Q7_15 = @q7_15, Q7_16 = @q7_16, Q7_17 = @q7_17, Q7_18 = @q7_18, Q7_19 = @q7_19, Q7_20 = @q7_20 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q7_1", SqlDbType.VarChar).Value = Q7_1;

            updateCommand.Parameters.Add("@q7_2", SqlDbType.VarChar).Value = Q7_2;

            updateCommand.Parameters.Add("@q7_3", SqlDbType.VarChar).Value = Q7_3;

            updateCommand.Parameters.Add("@q7_4", SqlDbType.VarChar).Value = Q7_4;

            updateCommand.Parameters.Add("@q7_5", SqlDbType.VarChar).Value = Q7_5;

            updateCommand.Parameters.Add("@q7_6", SqlDbType.VarChar).Value = Q7_6;

            updateCommand.Parameters.Add("@q7_7", SqlDbType.VarChar).Value = Q7_7;

            updateCommand.Parameters.Add("@q7_8", SqlDbType.VarChar).Value = Q7_8;

            updateCommand.Parameters.Add("@q7_9", SqlDbType.VarChar).Value = Q7_9;

            updateCommand.Parameters.Add("@q7_10", SqlDbType.VarChar).Value = Q7_10;

            updateCommand.Parameters.Add("@q7_11", SqlDbType.VarChar).Value = Q7_11;

            updateCommand.Parameters.Add("@q7_12", SqlDbType.VarChar).Value = Q7_12;

            updateCommand.Parameters.Add("@q7_13", SqlDbType.VarChar).Value = Q7_13;

            updateCommand.Parameters.Add("@q7_14", SqlDbType.VarChar).Value = Q7_14;

            updateCommand.Parameters.Add("@q7_15", SqlDbType.VarChar).Value = Q7_15;

            updateCommand.Parameters.Add("@q7_16", SqlDbType.VarChar).Value = Q7_16;

            updateCommand.Parameters.Add("@q7_17", SqlDbType.VarChar).Value = Q7_17;

            updateCommand.Parameters.Add("@q7_18", SqlDbType.VarChar).Value = Q7_18;

            updateCommand.Parameters.Add("@q7_19", SqlDbType.VarChar).Value = Q7_19;

            updateCommand.Parameters.Add("@q7_20", SqlDbType.VarChar).Value = Q7_20;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet6(string Username, string Q6_1, string Q6_2, string Q6_3, string Q6_4, string Q6_5, string Q6_6, string Q6_7, string Q6_8, string Q6_9, string Q6_10, string Q6_11, string Q6_12, string Q6_13, string Q6_14, string Q6_15, string Q6_16, string Q6_17, string Q6_18, string Q6_19, string Q6_20)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q6_1 = @q6_1, Q6_2 = @q6_2, Q6_3 = @q6_3, Q6_4 = @q6_4, Q6_5 = @q6_5, Q6_6 = @q6_6, Q6_7 = @q6_7, Q6_8 = @q6_8, Q6_9 = @q6_9, Q6_10 = @q6_10, Q6_11 = @q6_11, Q6_12 = @q6_12, Q6_13 = @q6_13, Q6_14 = @q6_14, Q6_15 = @q6_15, Q6_16 = @q6_16, Q6_17 = @q6_17, Q6_18 = @q6_18, Q6_19 = @q6_19, Q6_20 = @q6_20 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q6_1", SqlDbType.VarChar).Value = Q6_1;

            updateCommand.Parameters.Add("@q6_2", SqlDbType.VarChar).Value = Q6_2;

            updateCommand.Parameters.Add("@q6_3", SqlDbType.VarChar).Value = Q6_3;

            updateCommand.Parameters.Add("@q6_4", SqlDbType.VarChar).Value = Q6_4;

            updateCommand.Parameters.Add("@q6_5", SqlDbType.VarChar).Value = Q6_5;

            updateCommand.Parameters.Add("@q6_6", SqlDbType.VarChar).Value = Q6_6;

            updateCommand.Parameters.Add("@q6_7", SqlDbType.VarChar).Value = Q6_7;

            updateCommand.Parameters.Add("@q6_8", SqlDbType.VarChar).Value = Q6_8;

            updateCommand.Parameters.Add("@q6_9", SqlDbType.VarChar).Value = Q6_9;

            updateCommand.Parameters.Add("@q6_10", SqlDbType.VarChar).Value = Q6_10;

            updateCommand.Parameters.Add("@q6_11", SqlDbType.VarChar).Value = Q6_11;

            updateCommand.Parameters.Add("@q6_12", SqlDbType.VarChar).Value = Q6_12;

            updateCommand.Parameters.Add("@q6_13", SqlDbType.VarChar).Value = Q6_13;

            updateCommand.Parameters.Add("@q6_14", SqlDbType.VarChar).Value = Q6_14;

            updateCommand.Parameters.Add("@q6_15", SqlDbType.VarChar).Value = Q6_15;

            updateCommand.Parameters.Add("@q6_16", SqlDbType.VarChar).Value = Q6_16;

            updateCommand.Parameters.Add("@q6_17", SqlDbType.VarChar).Value = Q6_17;

            updateCommand.Parameters.Add("@q6_18", SqlDbType.VarChar).Value = Q6_18;

            updateCommand.Parameters.Add("@q6_19", SqlDbType.VarChar).Value = Q6_19;

            updateCommand.Parameters.Add("@q6_20", SqlDbType.VarChar).Value = Q6_20;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet5(string Username, string Q5_1, string Q5_2, string Q5_3, string Q5_4, string Q5_5, string Q5_6, string Q5_7, string Q5_8, string Q5_9, string Q5_10, string Q5_11, string Q5_12, string Q5_13, string Q5_14, string Q5_15, string Q5_16, string Q5_17, string Q5_18, string Q5_19, string Q5_20)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q5_1 = @q5_1, Q5_2 = @q5_2, Q5_3 = @q5_3, Q5_4 = @q5_4, Q5_5 = @q5_5, Q5_6 = @q5_6, Q5_7 = @q5_7, Q5_8 = @q5_8, Q5_9 = @q5_9, Q5_10 = @q5_10, Q5_11 = @q5_11, Q5_12 = @q5_12, Q5_13 = @q5_13, Q5_14 = @q5_14, Q5_15 = @q5_15, Q5_16 = @q5_16, Q5_17 = @q5_17, Q5_18 = @q5_18, Q5_19 = @q5_19, Q5_20 = @q5_20 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q5_1", SqlDbType.VarChar).Value = Q5_1;

            updateCommand.Parameters.Add("@q5_2", SqlDbType.VarChar).Value = Q5_2;

            updateCommand.Parameters.Add("@q5_3", SqlDbType.VarChar).Value = Q5_3;

            updateCommand.Parameters.Add("@q5_4", SqlDbType.VarChar).Value = Q5_4;

            updateCommand.Parameters.Add("@q5_5", SqlDbType.VarChar).Value = Q5_5;

            updateCommand.Parameters.Add("@q5_6", SqlDbType.VarChar).Value = Q5_6;

            updateCommand.Parameters.Add("@q5_7", SqlDbType.VarChar).Value = Q5_7;

            updateCommand.Parameters.Add("@q5_8", SqlDbType.VarChar).Value = Q5_8;

            updateCommand.Parameters.Add("@q5_9", SqlDbType.VarChar).Value = Q5_9;

            updateCommand.Parameters.Add("@q5_10", SqlDbType.VarChar).Value = Q5_10;

            updateCommand.Parameters.Add("@q5_11", SqlDbType.VarChar).Value = Q5_11;

            updateCommand.Parameters.Add("@q5_12", SqlDbType.VarChar).Value = Q5_12;

            updateCommand.Parameters.Add("@q5_13", SqlDbType.VarChar).Value = Q5_13;

            updateCommand.Parameters.Add("@q5_14", SqlDbType.VarChar).Value = Q5_14;

            updateCommand.Parameters.Add("@q5_15", SqlDbType.VarChar).Value = Q5_15;

            updateCommand.Parameters.Add("@q5_16", SqlDbType.VarChar).Value = Q5_16;

            updateCommand.Parameters.Add("@q5_17", SqlDbType.VarChar).Value = Q5_17;

            updateCommand.Parameters.Add("@q5_18", SqlDbType.VarChar).Value = Q5_18;

            updateCommand.Parameters.Add("@q5_19", SqlDbType.VarChar).Value = Q5_19;

            updateCommand.Parameters.Add("@q5_20", SqlDbType.VarChar).Value = Q5_20;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Perception_Response_Form_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET PerceptionResponse = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Ways_To_Evaluate_Your_Effect_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET WaysToEvaluateYourEffect = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Sample2_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusSample2 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Sample1_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET FocusSample1 = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Defining_Vision_And_Mission_Statements_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET DefiningVisionAndMissionStatements = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Building_Your_Mission_And_Action_Statement_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET BuildingYourMissionAndActionStatement = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Introduction_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET Introduction = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Overview_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET Overview = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Resources_Provided_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET ResourcesProvided = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet4(string Username, string Q4_1, string Q4_2, string Q4_3, string Q4_4, string Q4_5, string Q4_6, string Q4_7, string Q4_8, string Q4_9, string Q4_10, string Q4_11, string Q4_12, string Q4_13, string Q4_14, string Q4_15, string Q4_16, string Q4_17, string Q4_18, string Q4_19, string Q4_20)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q4_1 = @q4_1, Q4_2 = @q4_2, Q4_3 = @q4_3, Q4_4 = @q4_4, Q4_5 = @q4_5, Q4_6 = @q4_6, Q4_7 = @q4_7, Q4_8 = @q4_8, Q4_9 = @q4_9, Q4_10 = @q4_10, Q4_11 = @q4_11, Q4_12 = @q4_12, Q4_13 = @q4_13, Q4_14 = @q4_14, Q4_15 = @q4_15, Q4_16 = @q4_16, Q4_17 = @q4_17, Q4_18 = @q4_18, Q4_19 = @q4_19, Q4_20 = @q4_20 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q4_1", SqlDbType.VarChar).Value = Q4_1;

            updateCommand.Parameters.Add("@q4_2", SqlDbType.VarChar).Value = Q4_2;

            updateCommand.Parameters.Add("@q4_3", SqlDbType.VarChar).Value = Q4_3;

            updateCommand.Parameters.Add("@q4_4", SqlDbType.VarChar).Value = Q4_4;

            updateCommand.Parameters.Add("@q4_5", SqlDbType.VarChar).Value = Q4_5;

            updateCommand.Parameters.Add("@q4_6", SqlDbType.VarChar).Value = Q4_6;

            updateCommand.Parameters.Add("@q4_7", SqlDbType.VarChar).Value = Q4_7;

            updateCommand.Parameters.Add("@q4_8", SqlDbType.VarChar).Value = Q4_8;

            updateCommand.Parameters.Add("@q4_9", SqlDbType.VarChar).Value = Q4_9;

            updateCommand.Parameters.Add("@q4_10", SqlDbType.VarChar).Value = Q4_10;

            updateCommand.Parameters.Add("@q4_11", SqlDbType.VarChar).Value = Q4_11;

            updateCommand.Parameters.Add("@q4_12", SqlDbType.VarChar).Value = Q4_12;

            updateCommand.Parameters.Add("@q4_13", SqlDbType.VarChar).Value = Q4_13;

            updateCommand.Parameters.Add("@q4_14", SqlDbType.VarChar).Value = Q4_14;

            updateCommand.Parameters.Add("@q4_15", SqlDbType.VarChar).Value = Q4_15;

            updateCommand.Parameters.Add("@q4_16", SqlDbType.VarChar).Value = Q4_16;

            updateCommand.Parameters.Add("@q4_17", SqlDbType.VarChar).Value = Q4_17;

            updateCommand.Parameters.Add("@q4_18", SqlDbType.VarChar).Value = Q4_18;

            updateCommand.Parameters.Add("@q4_19", SqlDbType.VarChar).Value = Q4_19;

            updateCommand.Parameters.Add("@q4_20", SqlDbType.VarChar).Value = Q4_20;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet3(string Username, string Q3_1, string Q3_2, string Q3_3, string Q3_4, string Q3_5, string Q3_6, string Q3_7, string Q3_8, string Q3_9, string Q3_10, string Q3_11, string Q3_12, string Q3_13, string Q3_14, string Q3_15, string Q3_16, string Q3_17, string Q3_18, string Q3_19, string Q3_20)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q3_1 = @q3_1, Q3_2 = @q3_2, Q3_3 = @q3_3, Q3_4 = @q3_4, Q3_5 = @q3_5, Q3_6 = @q3_6, Q3_7 = @q3_7, Q3_8 = @q3_8, Q3_9 = @q3_9, Q3_10 = @q3_10, Q3_11 = @q3_11, Q3_12 = @q3_12, Q3_13 = @q3_13, Q3_14 = @q3_14, Q3_15 = @q3_15, Q3_16 = @q3_16, Q3_17 = @q3_17, Q3_18 = @q3_18, Q3_19 = @q3_19, Q3_20 = @q3_20 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q3_1", SqlDbType.VarChar).Value = Q3_1;

            updateCommand.Parameters.Add("@q3_2", SqlDbType.VarChar).Value = Q3_2;

            updateCommand.Parameters.Add("@q3_3", SqlDbType.VarChar).Value = Q3_3;

            updateCommand.Parameters.Add("@q3_4", SqlDbType.VarChar).Value = Q3_4;

            updateCommand.Parameters.Add("@q3_5", SqlDbType.VarChar).Value = Q3_5;

            updateCommand.Parameters.Add("@q3_6", SqlDbType.VarChar).Value = Q3_6;

            updateCommand.Parameters.Add("@q3_7", SqlDbType.VarChar).Value = Q3_7;

            updateCommand.Parameters.Add("@q3_8", SqlDbType.VarChar).Value = Q3_8;

            updateCommand.Parameters.Add("@q3_9", SqlDbType.VarChar).Value = Q3_9;

            updateCommand.Parameters.Add("@q3_10", SqlDbType.VarChar).Value = Q3_10;

            updateCommand.Parameters.Add("@q3_11", SqlDbType.VarChar).Value = Q3_11;

            updateCommand.Parameters.Add("@q3_12", SqlDbType.VarChar).Value = Q3_12;

            updateCommand.Parameters.Add("@q3_13", SqlDbType.VarChar).Value = Q3_13;

            updateCommand.Parameters.Add("@q3_14", SqlDbType.VarChar).Value = Q3_14;

            updateCommand.Parameters.Add("@q3_15", SqlDbType.VarChar).Value = Q3_15;

            updateCommand.Parameters.Add("@q3_16", SqlDbType.VarChar).Value = Q3_16;

            updateCommand.Parameters.Add("@q3_17", SqlDbType.VarChar).Value = Q3_17;

            updateCommand.Parameters.Add("@q3_18", SqlDbType.VarChar).Value = Q3_18;

            updateCommand.Parameters.Add("@q3_19", SqlDbType.VarChar).Value = Q3_19;

            updateCommand.Parameters.Add("@q3_20", SqlDbType.VarChar).Value = Q3_20;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet2(string Username, string Q2_1, string Q2_2, string Q2_3, string Q2_4, string Q2_5, string Q2_6, string Q2_7, string Q2_8, string Q2_9, string Q2_10, string Q2_11, string Q2_12, string Q2_13, string Q2_14, string Q2_15, string Q2_16, string Q2_17, string Q2_18, string Q2_19, string Q2_20)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q2_1 = @q2_1, Q2_2 = @q2_2, Q2_3 = @q2_3, Q2_4 = @q2_4, Q2_5 = @q2_5, Q2_6 = @q2_6, Q2_7 = @q2_7, Q2_8 = @q2_8, Q2_9 = @q2_9, Q2_10 = @q2_10, Q2_11 = @q2_11, Q2_12 = @q2_12, Q2_13 = @q2_13, Q2_14 = @q2_14, Q2_15 = @q2_15, Q2_16 = @q2_16, Q2_17 = @q2_17, Q2_18 = @q2_18, Q2_19 = @q2_19, Q2_20 = @q2_20 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q2_1", SqlDbType.VarChar).Value = Q2_1;

            updateCommand.Parameters.Add("@q2_2", SqlDbType.VarChar).Value = Q2_2;

            updateCommand.Parameters.Add("@q2_3", SqlDbType.VarChar).Value = Q2_3;

            updateCommand.Parameters.Add("@q2_4", SqlDbType.VarChar).Value = Q2_4;

            updateCommand.Parameters.Add("@q2_5", SqlDbType.VarChar).Value = Q2_5;

            updateCommand.Parameters.Add("@q2_6", SqlDbType.VarChar).Value = Q2_6;

            updateCommand.Parameters.Add("@q2_7", SqlDbType.VarChar).Value = Q2_7;

            updateCommand.Parameters.Add("@q2_8", SqlDbType.VarChar).Value = Q2_8;

            updateCommand.Parameters.Add("@q2_9", SqlDbType.VarChar).Value = Q2_9;

            updateCommand.Parameters.Add("@q2_10", SqlDbType.VarChar).Value = Q2_10;

            updateCommand.Parameters.Add("@q2_11", SqlDbType.VarChar).Value = Q2_11;

            updateCommand.Parameters.Add("@q2_12", SqlDbType.VarChar).Value = Q2_12;

            updateCommand.Parameters.Add("@q2_13", SqlDbType.VarChar).Value = Q2_13;

            updateCommand.Parameters.Add("@q2_14", SqlDbType.VarChar).Value = Q2_14;

            updateCommand.Parameters.Add("@q2_15", SqlDbType.VarChar).Value = Q2_15;

            updateCommand.Parameters.Add("@q2_16", SqlDbType.VarChar).Value = Q2_16;

            updateCommand.Parameters.Add("@q2_17", SqlDbType.VarChar).Value = Q2_17;

            updateCommand.Parameters.Add("@q2_18", SqlDbType.VarChar).Value = Q2_18;

            updateCommand.Parameters.Add("@q2_19", SqlDbType.VarChar).Value = Q2_19;

            updateCommand.Parameters.Add("@q2_20", SqlDbType.VarChar).Value = Q2_20;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Focus_Analysis_Worksheet(string Username, string Q1_1, string Q1_2, string Q1_3, string Q1_4, string Q1_5, string Q1_6, string Q1_7, string Q1_8, string Q1_9, string Q1_10,  string Q1_11, string Q1_12, string Q1_13, string Q1_14, string Q1_15, string Q1_16, string Q1_17, string Q1_18, string Q1_19, string Q1_20)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE FOCUS_ANALYSIS SET Q1_1 = @q1_1, Q1_2 = @q1_2, Q1_3 = @q1_3, Q1_4 = @q1_4, Q1_5 = @q1_5, Q1_6 = @q1_6, Q1_7 = @q1_7, Q1_8 = @q1_8, Q1_9 = @q1_9, Q1_10 = @q1_10, Q1_11 = @q1_11, Q1_12 = @q1_12, Q1_13 = @q1_13, Q1_14 = @q1_14, Q1_15 = @q1_15, Q1_16 = @q1_16, Q1_17 = @q1_17, Q1_18 = @q1_18, Q1_19 = @q1_19, Q1_20 = @q1_20 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q1_1", SqlDbType.VarChar).Value = Q1_1;

            updateCommand.Parameters.Add("@q1_2", SqlDbType.VarChar).Value = Q1_2;

            updateCommand.Parameters.Add("@q1_3", SqlDbType.VarChar).Value = Q1_3;

            updateCommand.Parameters.Add("@q1_4", SqlDbType.VarChar).Value = Q1_4;

            updateCommand.Parameters.Add("@q1_5", SqlDbType.VarChar).Value = Q1_5;

            updateCommand.Parameters.Add("@q1_6", SqlDbType.VarChar).Value = Q1_6;

            updateCommand.Parameters.Add("@q1_7", SqlDbType.VarChar).Value = Q1_7;

            updateCommand.Parameters.Add("@q1_8", SqlDbType.VarChar).Value = Q1_8;

            updateCommand.Parameters.Add("@q1_9", SqlDbType.VarChar).Value = Q1_9;

            updateCommand.Parameters.Add("@q1_10", SqlDbType.VarChar).Value = Q1_10;

            updateCommand.Parameters.Add("@q1_11", SqlDbType.VarChar).Value = Q1_11;

            updateCommand.Parameters.Add("@q1_12", SqlDbType.VarChar).Value = Q1_12;

            updateCommand.Parameters.Add("@q1_13", SqlDbType.VarChar).Value = Q1_13;

            updateCommand.Parameters.Add("@q1_14", SqlDbType.VarChar).Value = Q1_14;

            updateCommand.Parameters.Add("@q1_15", SqlDbType.VarChar).Value = Q1_15;

            updateCommand.Parameters.Add("@q1_16", SqlDbType.VarChar).Value = Q1_16;

            updateCommand.Parameters.Add("@q1_17", SqlDbType.VarChar).Value = Q1_17;

            updateCommand.Parameters.Add("@q1_18", SqlDbType.VarChar).Value = Q1_18;

            updateCommand.Parameters.Add("@q1_19", SqlDbType.VarChar).Value = Q1_19;

            updateCommand.Parameters.Add("@q1_20", SqlDbType.VarChar).Value = Q1_20;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Natural_Talents_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET NaturalTalents = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Education_Inventory_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET EducationTrainingInventory = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Password(string Username, string NewPassword)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_USER SET Password = @password WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = NewPassword;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Forgot_Password(string Username)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string newPassword = System.Web.Security.Membership.GeneratePassword(8, 0);

            string updateStatement = "UPDATE BESTPATH_USER SET Password = @password WHERE Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = newPassword;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return newPassword;

        }//end method

        public static string Update_Sharegiver_Talents(string Username, string Q77, string Q78, string Q79)
        {
            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE SHAREGIVER_TALENTS SET Q77 = @q77, Q78 = @q78, Q79 = @q79 WHERE CLIENT_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@q77", SqlDbType.VarChar).Value = Q77;

            updateCommand.Parameters.Add("@q78", SqlDbType.VarChar).Value = Q78;

            updateCommand.Parameters.Add("@q79", SqlDbType.VarChar).Value = Q79;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

        public static string Update_Sharegiver_Talents_Status(string Username)
        {
            DateTime today = DateTime.Today;

            Update updateObject = new Update();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string updateStatement = "UPDATE BESTPATH_STATUS SET PracticalSkills = @today WHERE BESTPATH_USER_Username = @username";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            updateCommand.Parameters.Add("@today", SqlDbType.VarChar).Value = today;

            try
            {
                connection.Open();

                int numRows = updateCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                updateObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return updateObject.getErrorMessage();

        }//end method

    }//end class

}//end namespace