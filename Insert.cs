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
    public class Insert
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

        public Insert()
        {
            this.errorMessage = null;

        }//end constructor

        public static string Insert_Registration_Transaction(string Username, string EncryptedPassword, string EncryptedFirstName, string EncryptedLastName, string EncryptedAge, string EncryptedStreetAddress, string EncryptedCity, string EncryptedState, string EncryptedZipCode, string EncryptedCountry, string EncryptedPhoneNumber, string EncryptedKey, string EncryptedIV, string EncryptedRole, string Verified, string Counselor, string EncryptedCounselorName, DateTime DateCreated, int NumberOfLogins, string EncryptedSecurityQuestion, string EncryptedSecurityAnswer, string ReferralSource, string ReferralName, string RUGAPCEmailAddress)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING))
            {
                connection.Open();

                SqlTransaction sqlTran = connection.BeginTransaction();

                try
                {
                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.CommandText = "INSERT INTO BESTPATH_USER(FirstName, LastName, Username, Password, Role, Verified, Counselor, CounselorName, DateCreated, NumberOfLogins, SecurityQuestion, SecurityAnswer, ReferralSource, ReferralName, RUGAPCEmailAddress, _Key, _IV) VALUES(@firstName1, @lastName1, @username1, @password, @role, @verified, @counselor, @counselorName, @dateCreated, @numberOfLogins, @securityQuestion, @securityAnswer, @referralSource, @referralName, @RUGAPCEmailAddress, @key, @iv)";

                    command.Parameters.Add("@firstName1", SqlDbType.VarChar).Value = EncryptedFirstName;

                    command.Parameters.Add("@lastName1", SqlDbType.VarChar).Value = EncryptedLastName;

                    command.Parameters.Add("@username1", SqlDbType.VarChar).Value = Username;

                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = EncryptedPassword;

                    command.Parameters.Add("@role", SqlDbType.VarChar).Value = EncryptedRole;

                    command.Parameters.Add("@verified", SqlDbType.Char).Value = Verified;

                    command.Parameters.Add("@counselor", SqlDbType.VarChar).Value = Counselor;

                    command.Parameters.Add("@counselorName", SqlDbType.VarChar).Value = EncryptedCounselorName;

                    command.Parameters.Add("@dateCreated", SqlDbType.Date).Value = DateCreated;

                    command.Parameters.Add("@numberOfLogins", SqlDbType.Int).Value = NumberOfLogins;

                    command.Parameters.Add("@securityQuestion", SqlDbType.VarChar).Value = EncryptedSecurityQuestion;

                    command.Parameters.Add("@securityAnswer", SqlDbType.VarChar).Value = EncryptedSecurityAnswer;

                    command.Parameters.Add("@referralSource", SqlDbType.VarChar).Value = ReferralSource;

                    command.Parameters.Add("@referralName", SqlDbType.VarChar).Value = ReferralName;

                    command.Parameters.Add("@RUGAPCEmailAddress", SqlDbType.VarChar).Value = RUGAPCEmailAddress;

                    command.Parameters.Add("@key", SqlDbType.VarChar).Value = EncryptedKey;

                    command.Parameters.Add("@iv", SqlDbType.VarChar).Value = EncryptedIV;

                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO BESTPATH_STATUS (BESTPATH_USER_Username) VALUES (@username2)";

                    command.Parameters.Add("@username2", SqlDbType.VarChar).Value = Username;

                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO CLIENT (Username, FirstName, LastName, DOB, StreetAddress, City, State, ZipCode, Country, Phone, _Key, _IV) VALUES (@username3, @firstName2, @lastName2, @dob, @streetAddress, @city, @state, @zipCode, @country, @phone, @encryptedKey, @encryptedIV)";

                    command.Parameters.Add("@username3", SqlDbType.VarChar).Value = Username;

                    command.Parameters.Add("@firstName2", SqlDbType.VarChar).Value = EncryptedFirstName;

                    command.Parameters.Add("@lastName2", SqlDbType.VarChar).Value = EncryptedLastName;

                    command.Parameters.Add("@dob", SqlDbType.VarChar).Value = EncryptedAge;

                    command.Parameters.Add("@streetAddress", SqlDbType.VarChar).Value = EncryptedStreetAddress;

                    command.Parameters.Add("@city", SqlDbType.VarChar).Value = EncryptedCity;

                    command.Parameters.Add("@state", SqlDbType.VarChar).Value = EncryptedState;

                    command.Parameters.Add("@zipCode", SqlDbType.VarChar).Value = EncryptedZipCode;

                    command.Parameters.Add("@country", SqlDbType.VarChar).Value = EncryptedCountry;

                    command.Parameters.Add("@phone", SqlDbType.VarChar).Value = EncryptedPhoneNumber;

                    command.Parameters.Add("@encryptedKey", SqlDbType.VarChar).Value = EncryptedKey;

                    command.Parameters.Add("@encryptedIV", SqlDbType.VarChar).Value = EncryptedIV;

                    command.ExecuteNonQuery();

                    sqlTran.Commit();

                }//end try

                catch(SqlException ex)
                {
                    insertObject.setErrorMessage("SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString());

                    try
                    {
                        sqlTran.Rollback();

                    }//end try

                    catch(Exception exRollback)
                    {
                        string errorMessage2 = exRollback.Message.ToString();

                    }//end catch

                }//end catch

                finally
                {
                    connection.Close();

                }//end finally

            }//end using

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_COVENANT_PARTNERSHIP_AGREEMENT(string EmailAddress, string EncryptedFullName, string EncryptedDate, string EncryptedPhoneNumber, string EncryptedKey, string EncryptedIV)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO COVENANT_PARTNERSHIP_AGREEMENT (EmailAddress, FullName, Date, PhoneNumber, _Key, _IV) VALUES (@emailAddress, @fullName, @date, @phoneNumber, @encryptedKey, @encryptedIV)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            insertCommand.Parameters.Add("@fullName", SqlDbType.VarChar).Value = EncryptedFullName;

            insertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = EncryptedDate;

            insertCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = EncryptedPhoneNumber;

            insertCommand.Parameters.Add("@encryptedKey", SqlDbType.VarChar).Value = EncryptedKey;

            insertCommand.Parameters.Add("@encryptedIV", SqlDbType.VarChar).Value = EncryptedIV;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Needs_Assessment_Package(DateTime DateCompleted, string FirstName, string LastName, string EmailAddress, string PhoneNumber, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13, string Q14, string Q15, string Q16, string Q17, string Q18, string Q19, string Q20, string Q21, string Q22, string Q23, string Q24, string Q25, string Q26, string Q27, string Q28, string Q29, string Q30, string Q31, string Q32, string Q33, string Q34, string Q35, string Q36, string Q37, string Q38, string Q39, string Q40, string Q41, string Q42, string Q43, string Q44, string Q45, string Q46, string ReferralSource, string ReferralName, string RUGAPCEmailAddress, DateTime DateCompleted2, long Q2_1, long Q2_2, long Q2_3, long Q2_4, long Q2_5, long Q2_6, long Q2_7, long Q2_8, long Q2_9, long Q2_10, long Q2_11, long Q2_12, long Q2_13, long Q2_14, long Q2_15, long Q2_16, long Q2_17, long Q2_18, long Q2_19, long Q2_20, long Score)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO NEEDS_ASSESSMENTS (DateCompleted, FirstName, LastName, EmailAddress, PhoneNumber, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21, Q22, Q23, Q24, Q25, Q26, Q27, Q28, Q29, Q30, Q31, Q32, Q33, Q34, Q35, Q36, Q37, Q38, Q39, Q40, Q41, Q42, Q43, Q44, Q45, Q46, ReferralSource, ReferralName, RUGAPCEmailAddress, DateCompleted2, Q2_1, Q2_2, Q2_3, Q2_4, Q2_5, Q2_6, Q2_7, Q2_8, Q2_9, Q2_10, Q2_11, Q2_12, Q2_13, Q2_14, Q2_15, Q2_16, Q2_17, Q2_18, Q2_19, Q2_20, Score) VALUES (@dateCompleted, @firstName, @lastName, @emailAddress, @phoneNumber, @q5, @q6, @q7, @q8, @q9, @q10, @q11, @q12, @q13, @q14, @q15, @q16, @q17, @q18, @q19, @q20, @q21, @q22, @q23, @q24, @q25, @q26, @q27, @q28, @q29, @q30, @q31, @q32, @q33, @q34, @q35, @q36, @q37, @q38, @q39, @q40, @q41, @q42, @q43, @q44, @q45, @q46, @referralSource, @referralName, @RUGAPCEmailAddress, @dateCompleted2, @q2_1, @q2_2, @q2_3, @q2_4, @q2_5, @q2_6, @q2_7, @q2_8, @q2_9, @q2_10, @q2_11, @q2_12, @q2_13, @q2_14, @q2_15, @q2_16, @q2_17, @q2_18, @q2_19, @q2_20, @score)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@dateCompleted", SqlDbType.DateTime).Value = DateCompleted;

            insertCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = FirstName;

            insertCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = LastName;

            insertCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            insertCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = PhoneNumber;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@q13", SqlDbType.VarChar).Value = Q13;

            insertCommand.Parameters.Add("@q14", SqlDbType.VarChar).Value = Q14;

            insertCommand.Parameters.Add("@q15", SqlDbType.VarChar).Value = Q15;

            insertCommand.Parameters.Add("@q16", SqlDbType.VarChar).Value = Q16;

            insertCommand.Parameters.Add("@q17", SqlDbType.VarChar).Value = Q17;

            insertCommand.Parameters.Add("@q18", SqlDbType.VarChar).Value = Q18;

            insertCommand.Parameters.Add("@q19", SqlDbType.VarChar).Value = Q19;

            insertCommand.Parameters.Add("@q20", SqlDbType.VarChar).Value = Q20;

            insertCommand.Parameters.Add("@q21", SqlDbType.VarChar).Value = Q21;

            insertCommand.Parameters.Add("@q22", SqlDbType.VarChar).Value = Q22;

            insertCommand.Parameters.Add("@q23", SqlDbType.VarChar).Value = Q23;

            insertCommand.Parameters.Add("@q24", SqlDbType.VarChar).Value = Q24;

            insertCommand.Parameters.Add("@q25", SqlDbType.VarChar).Value = Q25;

            insertCommand.Parameters.Add("@q26", SqlDbType.VarChar).Value = Q26;

            insertCommand.Parameters.Add("@q27", SqlDbType.VarChar).Value = Q27;

            insertCommand.Parameters.Add("@q28", SqlDbType.VarChar).Value = Q28;

            insertCommand.Parameters.Add("@q29", SqlDbType.VarChar).Value = Q29;

            insertCommand.Parameters.Add("@q30", SqlDbType.VarChar).Value = Q30;

            insertCommand.Parameters.Add("@q31", SqlDbType.VarChar).Value = Q31;

            insertCommand.Parameters.Add("@q32", SqlDbType.VarChar).Value = Q32;

            insertCommand.Parameters.Add("@q33", SqlDbType.VarChar).Value = Q33;

            insertCommand.Parameters.Add("@q34", SqlDbType.VarChar).Value = Q34;

            insertCommand.Parameters.Add("@q35", SqlDbType.VarChar).Value = Q35;

            insertCommand.Parameters.Add("@q36", SqlDbType.VarChar).Value = Q36;

            insertCommand.Parameters.Add("@q37", SqlDbType.VarChar).Value = Q37;

            insertCommand.Parameters.Add("@q38", SqlDbType.VarChar).Value = Q38;

            insertCommand.Parameters.Add("@q39", SqlDbType.VarChar).Value = Q39;

            insertCommand.Parameters.Add("@q40", SqlDbType.VarChar).Value = Q40;

            insertCommand.Parameters.Add("@q41", SqlDbType.VarChar).Value = Q41;

            insertCommand.Parameters.Add("@q42", SqlDbType.VarChar).Value = Q42;

            insertCommand.Parameters.Add("@q43", SqlDbType.VarChar).Value = Q43;

            insertCommand.Parameters.Add("@q44", SqlDbType.VarChar).Value = Q44;

            insertCommand.Parameters.Add("@q45", SqlDbType.VarChar).Value = Q45;

            insertCommand.Parameters.Add("@q46", SqlDbType.VarChar).Value = Q46;

            insertCommand.Parameters.Add("@referralSource", SqlDbType.VarChar).Value = ReferralSource;

            insertCommand.Parameters.Add("@referralName", SqlDbType.VarChar).Value = ReferralName;

            insertCommand.Parameters.Add("@RUGAPCEmailAddress", SqlDbType.VarChar).Value = RUGAPCEmailAddress;

            insertCommand.Parameters.Add("@dateCompleted2", SqlDbType.DateTime).Value = DateCompleted2;

            insertCommand.Parameters.Add("@q2_1", SqlDbType.Int).Value = Q2_1;

            insertCommand.Parameters.Add("@q2_2", SqlDbType.Int).Value = Q2_2;

            insertCommand.Parameters.Add("@q2_3", SqlDbType.Int).Value = Q2_3;

            insertCommand.Parameters.Add("@q2_4", SqlDbType.Int).Value = Q2_4;

            insertCommand.Parameters.Add("@q2_5", SqlDbType.Int).Value = Q2_5;

            insertCommand.Parameters.Add("@q2_6", SqlDbType.Int).Value = Q2_6;

            insertCommand.Parameters.Add("@q2_7", SqlDbType.Int).Value = Q2_7;

            insertCommand.Parameters.Add("@q2_8", SqlDbType.Int).Value = Q2_8;

            insertCommand.Parameters.Add("@q2_9", SqlDbType.Int).Value = Q2_9;

            insertCommand.Parameters.Add("@q2_10", SqlDbType.Int).Value = Q2_10;

            insertCommand.Parameters.Add("@q2_11", SqlDbType.Int).Value = Q2_11;

            insertCommand.Parameters.Add("@q2_12", SqlDbType.Int).Value = Q2_12;

            insertCommand.Parameters.Add("@q2_13", SqlDbType.Int).Value = Q2_13;

            insertCommand.Parameters.Add("@q2_14", SqlDbType.Int).Value = Q2_14;

            insertCommand.Parameters.Add("@q2_15", SqlDbType.Int).Value = Q2_15;

            insertCommand.Parameters.Add("@q2_16", SqlDbType.Int).Value = Q2_16;

            insertCommand.Parameters.Add("@q2_17", SqlDbType.Int).Value = Q2_17;

            insertCommand.Parameters.Add("@q2_18", SqlDbType.Int).Value = Q2_18;

            insertCommand.Parameters.Add("@q2_19", SqlDbType.Int).Value = Q2_19;

            insertCommand.Parameters.Add("@q2_20", SqlDbType.Int).Value = Q2_20;

            insertCommand.Parameters.Add("@score", SqlDbType.Int).Value = Score;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Career_Marketability_Assessment(string EmailAddress, DateTime DateCompleted, long Q1, long Q2, long Q3, long Q4, long Q5, long Q6, long Q7, long Q8, long Q9, long Q10, long Q11, long Q12, long Q13, long Q14, long Q15, long Q16, long Q17, long Q18, long Q19, long Q20, long Score)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO CAREER_MARKETABILITY_ASSESSMENT (EmailAddress, DateCompleted, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Score) VALUES (@emailAddress, @dateCompleted, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, @q9, @q10, @q11, @q12, @q13, @q14, @q15, @q16, @q17, @q18, @q19, @q20, @score)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            insertCommand.Parameters.Add("@dateCompleted", SqlDbType.DateTime).Value = DateCompleted;

            insertCommand.Parameters.Add("@q1", SqlDbType.Int).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.Int).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.Int).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.Int).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.Int).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.Int).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.Int).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.Int).Value = Q8;

            insertCommand.Parameters.Add("@q9", SqlDbType.Int).Value = Q9;

            insertCommand.Parameters.Add("@q10", SqlDbType.Int).Value = Q10;

            insertCommand.Parameters.Add("@q11", SqlDbType.Int).Value = Q11;

            insertCommand.Parameters.Add("@q12", SqlDbType.Int).Value = Q12;

            insertCommand.Parameters.Add("@q13", SqlDbType.Int).Value = Q13;

            insertCommand.Parameters.Add("@q14", SqlDbType.Int).Value = Q14;

            insertCommand.Parameters.Add("@q15", SqlDbType.Int).Value = Q15;

            insertCommand.Parameters.Add("@q16", SqlDbType.Int).Value = Q16;

            insertCommand.Parameters.Add("@q17", SqlDbType.Int).Value = Q17;

            insertCommand.Parameters.Add("@q18", SqlDbType.Int).Value = Q18;

            insertCommand.Parameters.Add("@q19", SqlDbType.Int).Value = Q19;

            insertCommand.Parameters.Add("@q20", SqlDbType.Int).Value = Q20;

            insertCommand.Parameters.Add("@score", SqlDbType.Int).Value = Score;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Preliminary_Needs_Assessment(DateTime DateCompleted, string EmailAddress, string FirstName, string LastName, string PhoneNumber, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13, string Q14, string Q15, string Q16, string Q17, string Q18, string Q19, string Q20, string Q21, string Q22, string Q23, string Q24, string Q25, string Q26, string Q27, string Q28, string Q29, string Q30, string Q31, string Q32, string Q33, string Q34, string Q35, string Q36, string Q37, string Q38, string Q39, string Q40, string Q41, string Q42, string Q43, string Q44, string Q45, string Q46, string ReferralSource, string ReferralName, string RUGAPCEmailAddress)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO PRELIMINARY_NEEDS_ASSESSMENT (DateCompleted, EmailAddress, FirstName, LastName, PhoneNumber, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21, Q22, Q23, Q24, Q25, Q26, Q27, Q28, Q29, Q30, Q31, Q32, Q33, Q34, Q35, Q36, Q37, Q38, Q39, Q40, Q41, Q42, Q43, Q44, Q45, Q46, ReferralSource, ReferralName, RUGAPCEmailAddress) VALUES (@dateCompleted, @emailAddress, @firstName, @lastName, @phoneNumber, @q5, @q6, @q7, @q8, @q9, @q10, @q11, @q12, @q13, @q14, @q15, @q16, @q17, @q18, @q19, @q20, @q21, @q22, @q23, @q24, @q25, @q26, @q27, @q28, @q29, @q30, @q31, @q32, @q33, @q34, @q35, @q36, @q37, @q38, @q39, @q40, @q41, @q42, @q43, @q44, @q45, @q46, @referralSource, @referralName, @RUGAPCEmailAddress)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@dateCompleted", SqlDbType.DateTime).Value = DateCompleted;

            insertCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EmailAddress;

            insertCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = FirstName;

            insertCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = LastName;

            insertCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = PhoneNumber;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@q13", SqlDbType.VarChar).Value = Q13;

            insertCommand.Parameters.Add("@q14", SqlDbType.VarChar).Value = Q14;

            insertCommand.Parameters.Add("@q15", SqlDbType.VarChar).Value = Q15;

            insertCommand.Parameters.Add("@q16", SqlDbType.VarChar).Value = Q16;

            insertCommand.Parameters.Add("@q17", SqlDbType.VarChar).Value = Q17;

            insertCommand.Parameters.Add("@q18", SqlDbType.VarChar).Value = Q18;

            insertCommand.Parameters.Add("@q19", SqlDbType.VarChar).Value = Q19;

            insertCommand.Parameters.Add("@q20", SqlDbType.VarChar).Value = Q20;

            insertCommand.Parameters.Add("@q21", SqlDbType.VarChar).Value = Q21;

            insertCommand.Parameters.Add("@q22", SqlDbType.VarChar).Value = Q22;

            insertCommand.Parameters.Add("@q23", SqlDbType.VarChar).Value = Q23;

            insertCommand.Parameters.Add("@q24", SqlDbType.VarChar).Value = Q24;

            insertCommand.Parameters.Add("@q25", SqlDbType.VarChar).Value = Q25;

            insertCommand.Parameters.Add("@q26", SqlDbType.VarChar).Value = Q26;

            insertCommand.Parameters.Add("@q27", SqlDbType.VarChar).Value = Q27;

            insertCommand.Parameters.Add("@q28", SqlDbType.VarChar).Value = Q28;

            insertCommand.Parameters.Add("@q29", SqlDbType.VarChar).Value = Q29;

            insertCommand.Parameters.Add("@q30", SqlDbType.VarChar).Value = Q30;

            insertCommand.Parameters.Add("@q31", SqlDbType.VarChar).Value = Q31;

            insertCommand.Parameters.Add("@q32", SqlDbType.VarChar).Value = Q32;

            insertCommand.Parameters.Add("@q33", SqlDbType.VarChar).Value = Q33;

            insertCommand.Parameters.Add("@q34", SqlDbType.VarChar).Value = Q34;

            insertCommand.Parameters.Add("@q35", SqlDbType.VarChar).Value = Q35;

            insertCommand.Parameters.Add("@q36", SqlDbType.VarChar).Value = Q36;

            insertCommand.Parameters.Add("@q37", SqlDbType.VarChar).Value = Q37;

            insertCommand.Parameters.Add("@q38", SqlDbType.VarChar).Value = Q38;

            insertCommand.Parameters.Add("@q39", SqlDbType.VarChar).Value = Q39;

            insertCommand.Parameters.Add("@q40", SqlDbType.VarChar).Value = Q40;

            insertCommand.Parameters.Add("@q41", SqlDbType.VarChar).Value = Q41;

            insertCommand.Parameters.Add("@q42", SqlDbType.VarChar).Value = Q42;

            insertCommand.Parameters.Add("@q43", SqlDbType.VarChar).Value = Q43;

            insertCommand.Parameters.Add("@q44", SqlDbType.VarChar).Value = Q44;

            insertCommand.Parameters.Add("@q45", SqlDbType.VarChar).Value = Q45;

            insertCommand.Parameters.Add("@q46", SqlDbType.VarChar).Value = Q46;

            insertCommand.Parameters.Add("@referralSource", SqlDbType.VarChar).Value = ReferralSource;

            insertCommand.Parameters.Add("@referralName", SqlDbType.VarChar).Value = ReferralName;

            insertCommand.Parameters.Add("@RUGAPCEmailAddress", SqlDbType.VarChar).Value = RUGAPCEmailAddress;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Error_Log(string Username, DateTime Now, string PageOccurred, string ErrorMessage)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO ERROR_LOG (Username, Date, PageOccurred, ErrorMessage) VALUES (@username, @date, @pageOccurred, @errorMessage)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = Now;

            insertCommand.Parameters.Add("@pageOccurred", SqlDbType.VarChar).Value = PageOccurred;

            insertCommand.Parameters.Add("@errorMessage", SqlDbType.VarChar).Value = ErrorMessage;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Session_Data(string Username, DateTime Expiration, bool Expired, DateTime IssueDate, string Role)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO SESSION VALUES (@username, @expiration, @expired, @issueDate, @role)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@expiration", SqlDbType.DateTime).Value = Expiration;

            insertCommand.Parameters.Add("@expired", SqlDbType.VarChar).Value = Expired;

            insertCommand.Parameters.Add("@issueDate", SqlDbType.DateTime).Value = IssueDate;

            insertCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = Role;

            try
            {
                connection.Open();

                insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Client(string Username, string FirstName, string LastName, string DOB, string StreetAddress, string City, string State, string ZipCode, string Country, string Phone)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO CLIENT (Username, FirstName, LastName, DOB, StreetAddress, City, State, ZipCode, Country, Phone) VALUES (@username, @firstName, @lastName, @dob, @streetAddress, @city, @state, @zipCode, @country, @phone)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = FirstName;

            insertCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = LastName;

            insertCommand.Parameters.Add("@dob", SqlDbType.VarChar).Value = DOB;

            insertCommand.Parameters.Add("@streetAddress", SqlDbType.VarChar).Value = StreetAddress;

            insertCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = City;

            insertCommand.Parameters.Add("@state", SqlDbType.VarChar).Value = State;

            insertCommand.Parameters.Add("@zipCode", SqlDbType.VarChar).Value = ZipCode;

            insertCommand.Parameters.Add("@country", SqlDbType.VarChar).Value = Country;

            insertCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Counseling_Log(string Username, string ClientCounselor, string ClientName, DateTime Date, string DescriptionOfIssue)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO COUNSELING_LOG (CLIENT_Username, Counselor, FullName, Date, DescriptionOfIssue) VALUES (@username, @clientCounselor, @clientName, @date, @descriptionOfIssue)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@clientCounselor", SqlDbType.VarChar).Value = ClientCounselor;

            insertCommand.Parameters.Add("@clientName", SqlDbType.VarChar).Value = ClientName;

            insertCommand.Parameters.Add("@date", SqlDbType.Date).Value = Date;

            insertCommand.Parameters.Add("@descriptionOfIssue", SqlDbType.VarChar).Value = DescriptionOfIssue;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Deliverable_Creation(string Username, string EncryptedFullName, string EncryptedDegrees, string EncryptedStreetAddress, string EncryptedCityStateZip, string EncryptedEmailAddress, string EncryptedPhoneNumber, string EncryptedKey, string EncryptedIV)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO DELIVERABLE_CREATION (CLIENT_Username, FullName, Degrees, StreetAddress, CityStateZip, EmailAddress, PhoneNumber, _Key, _IV) VALUES (@username, @fullName, @degrees, @streetAddress, @cityStateZip, @emailAddress, @phoneNumber, @key, @iv)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@fullName", SqlDbType.VarChar).Value = EncryptedFullName;

            insertCommand.Parameters.Add("@degrees", SqlDbType.VarChar).Value = EncryptedDegrees;

            insertCommand.Parameters.Add("@streetAddress", SqlDbType.VarChar).Value = EncryptedStreetAddress;

            insertCommand.Parameters.Add("@cityStateZip", SqlDbType.VarChar).Value = EncryptedCityStateZip;

            insertCommand.Parameters.Add("@emailAddress", SqlDbType.VarChar).Value = EncryptedEmailAddress;

            insertCommand.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = EncryptedPhoneNumber;

            insertCommand.Parameters.Add("@key", SqlDbType.VarChar).Value = EncryptedKey;

            insertCommand.Parameters.Add("@iv", SqlDbType.VarChar).Value = EncryptedIV;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Total_Spiritual_Gifts(string Username, int Q1, int Q2, int Q3, int Q4, int Q5, int Q6, int Q7, int Q8, int Q9, int Q10, int Q11, int Q12, int Q13, int Q14, int Q15, int Q16, int Q17, int Q18, int Q19, int Q20, int Q21)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO TOTAL_SPIRITUAL_GIFTS (CLIENT_Username, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21) VALUES (@username, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, @q9, @q10, @q11, @q12, @q13, @q14, @q15, @q16, @q17, @q18, @q19, @q20, @q21)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.Int).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.Int).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.Int).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.Int).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.Int).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.Int).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.Int).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.Int).Value = Q8;

            insertCommand.Parameters.Add("@q9", SqlDbType.Int).Value = Q9;

            insertCommand.Parameters.Add("@q10", SqlDbType.Int).Value = Q10;

            insertCommand.Parameters.Add("@q11", SqlDbType.Int).Value = Q11;

            insertCommand.Parameters.Add("@q12", SqlDbType.Int).Value = Q12;

            insertCommand.Parameters.Add("@q13", SqlDbType.Int).Value = Q13;

            insertCommand.Parameters.Add("@q14", SqlDbType.Int).Value = Q14;

            insertCommand.Parameters.Add("@q15", SqlDbType.Int).Value = Q15;

            insertCommand.Parameters.Add("@q16", SqlDbType.Int).Value = Q16;

            insertCommand.Parameters.Add("@q17", SqlDbType.Int).Value = Q17;

            insertCommand.Parameters.Add("@q18", SqlDbType.Int).Value = Q18;

            insertCommand.Parameters.Add("@q19", SqlDbType.Int).Value = Q19;

            insertCommand.Parameters.Add("@q20", SqlDbType.Int).Value = Q20;

            insertCommand.Parameters.Add("@q21", SqlDbType.Int).Value = Q21;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Personal_Management_Style(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13, string Q14, string Q15, string Q16, string Q17, string Q18, string Q19, string Q20,  string Q21,  string Q22,  string Q23,  string Q24,  string Q25,  string Q26,  string Q27,  string Q28,  string Q29,  string Q30,  string Q31,  string Q32,  string Q33,  string Q34,  string Q35,  string Q36,  string Q37,  string Q38,  string Q39,  string Q40,  string Q42,  string Q43,  string Q45,  string Q46,  string Q48,  string Q49)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO PERSONAL_MANAGEMENT_STYLES (CLIENT_Username, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21, Q22, Q23, Q24, Q25, Q26, Q27, Q28, Q29, Q30, Q31, Q32, Q33, Q34, Q35, Q36, Q37, Q38, Q39, Q40, Q42, Q43, Q45, Q46, Q48, Q49) VALUES (@username, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, @q9, @q10, @q11, @q12, @q13, @q14, @q15, @q16, @q17, @q18, @q19, @q20, @q21, @q22, @q23, @q24, @q25, @q26, @q27, @q28, @q29, @q30, @q31, @q32, @q33, @q34, @q35, @q36, @q37, @q38, @q39, @q40, @q42, @q43, @q45, @q46, @q48, @q49)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@q13", SqlDbType.VarChar).Value = Q13;

            insertCommand.Parameters.Add("@q14", SqlDbType.VarChar).Value = Q14;

            insertCommand.Parameters.Add("@q15", SqlDbType.VarChar).Value = Q15;

            insertCommand.Parameters.Add("@q16", SqlDbType.VarChar).Value = Q16;

            insertCommand.Parameters.Add("@q17", SqlDbType.VarChar).Value = Q17;

            insertCommand.Parameters.Add("@q18", SqlDbType.VarChar).Value = Q18;

            insertCommand.Parameters.Add("@q19", SqlDbType.VarChar).Value = Q19;

            insertCommand.Parameters.Add("@q20", SqlDbType.VarChar).Value = Q20;

            insertCommand.Parameters.Add("@q21", SqlDbType.VarChar).Value = Q21;

            insertCommand.Parameters.Add("@q22", SqlDbType.VarChar).Value = Q22;

            insertCommand.Parameters.Add("@q23", SqlDbType.VarChar).Value = Q23;

            insertCommand.Parameters.Add("@q24", SqlDbType.VarChar).Value = Q24;

            insertCommand.Parameters.Add("@q25", SqlDbType.VarChar).Value = Q25;

            insertCommand.Parameters.Add("@q26", SqlDbType.VarChar).Value = Q26;

            insertCommand.Parameters.Add("@q27", SqlDbType.VarChar).Value = Q27;

            insertCommand.Parameters.Add("@q28", SqlDbType.VarChar).Value = Q28;

            insertCommand.Parameters.Add("@q29", SqlDbType.VarChar).Value = Q29;

            insertCommand.Parameters.Add("@q30", SqlDbType.VarChar).Value = Q30;

            insertCommand.Parameters.Add("@q31", SqlDbType.VarChar).Value = Q31;

            insertCommand.Parameters.Add("@q32", SqlDbType.VarChar).Value = Q32;

            insertCommand.Parameters.Add("@q33", SqlDbType.VarChar).Value = Q33;

            insertCommand.Parameters.Add("@q34", SqlDbType.VarChar).Value = Q34;

            insertCommand.Parameters.Add("@q35", SqlDbType.VarChar).Value = Q35;

            insertCommand.Parameters.Add("@q36", SqlDbType.VarChar).Value = Q36;

            insertCommand.Parameters.Add("@q37", SqlDbType.VarChar).Value = Q37;

            insertCommand.Parameters.Add("@q38", SqlDbType.VarChar).Value = Q38;

            insertCommand.Parameters.Add("@q39", SqlDbType.VarChar).Value = Q39;

            insertCommand.Parameters.Add("@q40", SqlDbType.VarChar).Value = Q40;

            insertCommand.Parameters.Add("@q42", SqlDbType.VarChar).Value = Q42;

            insertCommand.Parameters.Add("@q43", SqlDbType.VarChar).Value = Q43;

            insertCommand.Parameters.Add("@q45", SqlDbType.VarChar).Value = Q45;

            insertCommand.Parameters.Add("@q46", SqlDbType.VarChar).Value = Q46;

            insertCommand.Parameters.Add("@q48", SqlDbType.VarChar).Value = Q48;

            insertCommand.Parameters.Add("@q49", SqlDbType.VarChar).Value = Q49;


            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience6(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13) VALUES (@username, 6, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@Q13", SqlDbType.VarChar).Value = Q13;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience11(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12) VALUES (@username, 11, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience5(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13) VALUES (@username, 5, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@Q13", SqlDbType.VarChar).Value = Q13;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience8(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13) VALUES (@username, 8, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@Q13", SqlDbType.VarChar).Value = Q13;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience4(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13) VALUES (@username, 4, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@Q13", SqlDbType.VarChar).Value = Q13;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience7(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13) VALUES (@username, 7, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@Q13", SqlDbType.VarChar).Value = Q13;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience3(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13) VALUES (@username, 3, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@Q13", SqlDbType.VarChar).Value = Q13;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience2(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13) VALUES (@username, 2, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@Q13", SqlDbType.VarChar).Value = Q13;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Experience1(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_EXPERIENCE(CLIENT_Username, FOCUS_EXPERIENCE#, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13) VALUES (@username, 1, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12, @Q13)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@Q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@Q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@Q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@Q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@Q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@Q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@Q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@Q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@Q13", SqlDbType.VarChar).Value = Q13;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Spiritual_Gifts(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13, string Q14, string Q15, string Q16, string Q17, string Q18, string Q19, string Q20, string Q21)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO SPIRITUAL_GIFTS VALUES (@username, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, @q9, @q10, @q11, @q12, @q13, @q14, @q15, @q16, @q17, @q18, @q19, @q20, @q21)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@q13", SqlDbType.VarChar).Value = Q13;

            insertCommand.Parameters.Add("@q14", SqlDbType.VarChar).Value = Q14;

            insertCommand.Parameters.Add("@q15", SqlDbType.VarChar).Value = Q15;

            insertCommand.Parameters.Add("@q16", SqlDbType.VarChar).Value = Q16;

            insertCommand.Parameters.Add("@q17", SqlDbType.VarChar).Value = Q17;

            insertCommand.Parameters.Add("@q18", SqlDbType.VarChar).Value = Q18;

            insertCommand.Parameters.Add("@q19", SqlDbType.VarChar).Value = Q19;

            insertCommand.Parameters.Add("@q20", SqlDbType.VarChar).Value = Q20;

            insertCommand.Parameters.Add("@q21", SqlDbType.VarChar).Value = Q21;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Expressing_Personal_Genius(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO EXPRESSING_PERSONAL_GENIUS VALUES (@username, @q1, @q2, @q3, @q4, @q5, @q6)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Fundamental_Life_Motivators(string Username, string Q1, string Q2, string Q3)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FUNDAMENTAL_LIFE_MOTIVATORS VALUES (@username, @q1, @q2, @q3)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.VarChar).Value = Q3;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Perception_Response_Summary(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO PERCEPTION_RESPONSE_SUMMARY VALUES (@username, @q1, @q2, @q3, @q4, @q5, @q6)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Creativity_Cycle(string Username, string Q1, string Q2)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO CREATIVITY_CYCLE VALUES (@username, @q1, @q2)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Demonstration_Worksheet(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_DEMONSTRATION VALUES (@username, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.VarChar).Value = Q8;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_BESTPATH_STATUS(string Username)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO BESTPATH_STATUS (BESTPATH_USER_Username) VALUES (@username)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_BESTPATH_USER(string EncryptedFirstName, string EncryptedLastName, string Username, string EncryptedPassword, string EncryptedRole, string Verified, string Counselor, string EncryptedCounselorName, DateTime DateCreated, int NumberOfLogins, string EncryptedSecurityQuestion, string EncryptedSecurityAnswer, string EncryptedKey, string EncryptedIV)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO BESTPATH_USER (FirstName, LastName, Username, Password, Role, Verified, Counselor, CounselorName, DateCreated, NumberOfLogins, SecurityQuestion, SecurityAnswer, _Key, _IV) VALUES (@firstName, @lastName, @username, @password, @role, @verified, @counselor, @counselorName, @dateCreated, @numberOfLogins, @securityQuestion, @securityAnswer, @key, @iv)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = EncryptedFirstName;

            insertCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = EncryptedLastName;

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = EncryptedPassword;

            insertCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = EncryptedRole;

            insertCommand.Parameters.Add("@verified", SqlDbType.Char).Value = Verified;

            insertCommand.Parameters.Add("@counselor", SqlDbType.VarChar).Value = Counselor;

            insertCommand.Parameters.Add("@counselorName", SqlDbType.VarChar).Value = EncryptedCounselorName;

            insertCommand.Parameters.Add("@dateCreated", SqlDbType.Date).Value = DateCreated;

            insertCommand.Parameters.Add("@numberOfLogins", SqlDbType.Int).Value = NumberOfLogins;

            insertCommand.Parameters.Add("@securityQuestion", SqlDbType.VarChar).Value = EncryptedSecurityQuestion;

            insertCommand.Parameters.Add("@securityAnswer", SqlDbType.VarChar).Value = EncryptedSecurityAnswer;

            insertCommand.Parameters.Add("@key", SqlDbType.VarChar).Value = EncryptedKey;

            insertCommand.Parameters.Add("@iv", SqlDbType.VarChar).Value = EncryptedIV;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Focus_Analysis_Worksheet(string Username, string Q1, string Q2, string Q3, string Q4, string Q5, string Q6, string Q7, string Q8)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO FOCUS_ANALYSIS (CLIENT_Username, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8) VALUES (@username, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.VarChar).Value = Q8;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Natural_Talents(string Username, string Q1, string Q2, string Q3, string Q4)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO NATURAL_TALENTS VALUES (@Username, @Q1, @Q2, @Q3, @Q4)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@Q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@Q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@Q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@Q4", SqlDbType.VarChar).Value = Q4;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Education_Inventory(string Username, string UndergraduateDegreeYN, string UndergraduateDegree, string UndergraduateMajor, string UndergraduateMinor, string GraduateDegreeYN, string GraduateDegree, string GraduateMajor, string CollegeClasses, string Classes, string Hobbies, string FixingYN, string Fixing, string Books, string Movies, string Music, string EnjoyMost1, string EnjoyMost2, string EnjoyMost3)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO EDUCATION_INVENTORY VALUES (@username, @undergraduateDegreeYN, @undergraduateDegree, @undergraduateMajor, @undergraduateMinor, @graduateDegreeYN, @graduateDegree, @graduateMajor, @collegeClasses, @classes, @hobbies, @fixingYN, @fixing, @books, @movies, @music, @enjoyMost1, @enjoyMost2, @enjoyMost3);";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@undergraduateDegreeYN", SqlDbType.Char).Value = UndergraduateDegreeYN;

            insertCommand.Parameters.Add("@undergraduateDegree", SqlDbType.VarChar).Value = UndergraduateDegree;

            insertCommand.Parameters.Add("@undergraduateMajor", SqlDbType.VarChar).Value = UndergraduateMajor;

            insertCommand.Parameters.Add("@undergraduateMinor", SqlDbType.VarChar).Value = UndergraduateMinor;

            insertCommand.Parameters.Add("@graduateDegreeYN", SqlDbType.Char).Value = GraduateDegreeYN;

            insertCommand.Parameters.Add("@graduateDegree", SqlDbType.VarChar).Value = GraduateDegree;

            insertCommand.Parameters.Add("@graduateMajor", SqlDbType.VarChar).Value = GraduateMajor;

            insertCommand.Parameters.Add("@collegeClasses", SqlDbType.VarChar).Value = CollegeClasses;

            insertCommand.Parameters.Add("@classes", SqlDbType.VarChar).Value = Classes;

            insertCommand.Parameters.Add("@hobbies", SqlDbType.VarChar).Value = Hobbies;

            insertCommand.Parameters.Add("@fixingYN", SqlDbType.Char).Value = FixingYN;

            insertCommand.Parameters.Add("@fixing", SqlDbType.VarChar).Value = Fixing;

            insertCommand.Parameters.Add("@books", SqlDbType.VarChar).Value = Books;

            insertCommand.Parameters.Add("@movies", SqlDbType.VarChar).Value = Movies;

            insertCommand.Parameters.Add("@music", SqlDbType.VarChar).Value = Music;

            insertCommand.Parameters.Add("@enjoyMost1", SqlDbType.VarChar).Value = EnjoyMost1;

            insertCommand.Parameters.Add("@enjoyMost2", SqlDbType.VarChar).Value = EnjoyMost2;

            insertCommand.Parameters.Add("@enjoyMost3", SqlDbType.VarChar).Value = EnjoyMost3;           

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_CLIENT(string Username, string EncryptedFirstName, string EncryptedLastName, string EncryptedDOB, string EncryptedStreetAddress, string EncryptedCity, string EncryptedState, string EncryptedZipCode, string EncryptedCountry, string EncryptedPhone, string EncryptedKey, string EncryptedIV)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO CLIENT (Username, FirstName, LastName, DOB, StreetAddress, City, State, ZipCode, Country, Phone, _Key, _IV) VALUES (@username, @firstName, @lastName, @dob, @streetAddress, @city, @state, @zipCode, @country, @phone, @encryptedKey, @encryptedIV)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = EncryptedFirstName;

            insertCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = EncryptedLastName;

            insertCommand.Parameters.Add("@dob", SqlDbType.VarChar).Value = EncryptedDOB;

            insertCommand.Parameters.Add("@streetAddress", SqlDbType.VarChar).Value = EncryptedStreetAddress;

            insertCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = EncryptedCity;

            insertCommand.Parameters.Add("@state", SqlDbType.VarChar).Value = EncryptedState;

            insertCommand.Parameters.Add("@zipCode", SqlDbType.VarChar).Value = EncryptedZipCode;

            insertCommand.Parameters.Add("@country", SqlDbType.VarChar).Value = EncryptedCountry;

            insertCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = EncryptedPhone;

            insertCommand.Parameters.Add("@encryptedKey", SqlDbType.VarChar).Value = EncryptedKey;

            insertCommand.Parameters.Add("@encryptedIV", SqlDbType.VarChar).Value = EncryptedIV;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Help_Log(string Username, string ClientName, DateTime DateOfIncident, string DescriptionOfProblem)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO HELP_LOG (CLIENT_Username, FullName, DateOfIncident, DescriptionOfProblem) VALUES (@username, @clientName, @dateOfIncident, @descriptionOfProblem)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@clientName", SqlDbType.VarChar).Value = ClientName;

            insertCommand.Parameters.Add("@dateOfIncident", SqlDbType.DateTime).Value = DateOfIncident;

            insertCommand.Parameters.Add("@descriptionOfProblem", SqlDbType.VarChar).Value = DescriptionOfProblem;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

        public static string Insert_Sharegiver_Talents(string Username, string Q1, string Q2, string Q3, string Q4, string Q5,
                                                       string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, 
                                                       string Q12, string Q13, string Q14, string Q15, string Q16, string Q17,
                                                       string Q18, string Q19, string Q20, string Q21, string Q22, string Q23,
                                                       string Q24, string Q25, string Q26, string Q27, string Q28, string Q29,
                                                       string Q30, string Q31, string Q32, string Q33, string Q34, string Q35,
                                                       string Q36, string Q37, string Q38, string Q39, string Q40, string Q41,
                                                       string Q42, string Q43, string Q44, string Q45, string Q46, string Q47,
                                                       string Q48, string Q49, string Q50, string Q51, string Q52, string Q53,
                                                       string Q54, string Q55, string Q56, string Q57, string Q58, string Q59,
                                                       string Q60, string Q61, string Q62, string Q63, string Q64, string Q65,
                                                       string Q66, string Q67, string Q68, string Q69, string Q70, string Q71,
                                                       string Q72, string Q73, string Q74, string Q75, string Q76)
        {
            Insert insertObject = new Insert();

            ConnectionString connectionString = new ConnectionString();

            SqlConnection connection = new SqlConnection(connectionString.CONNECTION_STRING);

            string insertStatement = "INSERT INTO SHAREGIVER_TALENTS (CLIENT_Username, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21, Q22, Q23, Q24, Q25, Q26, Q27, Q28, Q29, Q30, Q31, Q32, Q33, Q34, Q35, Q36, Q37, Q38, Q39, Q40, Q41, Q42, Q43, Q44, Q45, Q46, Q47, Q48, Q49, Q50, Q51, Q52, Q53, Q54, Q55, Q56, Q57, Q58, Q59, Q60, Q61, Q62, Q63, Q64, Q65, Q66, Q67, Q68, Q69, Q70, Q71, Q72, Q73, Q74, Q75, Q76) VALUES (@username, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, @q9, @q10, @q11, @q12, @q13, @q14, @q15, @q16, @q17, @q18, @q19, @q20, @q21, @q22, @q23, @q24, @q25, @q26, @q27, @q28, @q29, @q30, @q31, @q32, @q33, @q34, @q35, @q36, @q37, @q38, @q39, @q40, @q41, @q42, @q43, @q44, @q45, @q46, @q47, @q48, @q49, @q50, @q51, @q52, @q53, @q54, @q55, @q56, @q57, @q58, @q59, @q60, @q61, @q62, @q63, @q64, @q65, @q66, @q67, @q68, @q69, @q70, @q71, @q72, @q73, @q74, @q75, @q76)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = Username;

            insertCommand.Parameters.Add("@q1", SqlDbType.VarChar).Value = Q1;

            insertCommand.Parameters.Add("@q2", SqlDbType.VarChar).Value = Q2;

            insertCommand.Parameters.Add("@q3", SqlDbType.VarChar).Value = Q3;

            insertCommand.Parameters.Add("@q4", SqlDbType.VarChar).Value = Q4;

            insertCommand.Parameters.Add("@q5", SqlDbType.VarChar).Value = Q5;

            insertCommand.Parameters.Add("@q6", SqlDbType.VarChar).Value = Q6;

            insertCommand.Parameters.Add("@q7", SqlDbType.VarChar).Value = Q7;

            insertCommand.Parameters.Add("@q8", SqlDbType.VarChar).Value = Q8;

            insertCommand.Parameters.Add("@q9", SqlDbType.VarChar).Value = Q9;

            insertCommand.Parameters.Add("@q10", SqlDbType.VarChar).Value = Q10;

            insertCommand.Parameters.Add("@q11", SqlDbType.VarChar).Value = Q11;

            insertCommand.Parameters.Add("@q12", SqlDbType.VarChar).Value = Q12;

            insertCommand.Parameters.Add("@q13", SqlDbType.VarChar).Value = Q13;

            insertCommand.Parameters.Add("@q14", SqlDbType.VarChar).Value = Q14;

            insertCommand.Parameters.Add("@q15", SqlDbType.VarChar).Value = Q15;

            insertCommand.Parameters.Add("@q16", SqlDbType.VarChar).Value = Q16;

            insertCommand.Parameters.Add("@q17", SqlDbType.VarChar).Value = Q17;

            insertCommand.Parameters.Add("@q18", SqlDbType.VarChar).Value = Q18;

            insertCommand.Parameters.Add("@q19", SqlDbType.VarChar).Value = Q19;

            insertCommand.Parameters.Add("@q20", SqlDbType.VarChar).Value = Q20;

            insertCommand.Parameters.Add("@q21", SqlDbType.VarChar).Value = Q21;

            insertCommand.Parameters.Add("@q22", SqlDbType.VarChar).Value = Q22;

            insertCommand.Parameters.Add("@q23", SqlDbType.VarChar).Value = Q23;

            insertCommand.Parameters.Add("@q24", SqlDbType.VarChar).Value = Q24;

            insertCommand.Parameters.Add("@q25", SqlDbType.VarChar).Value = Q25;

            insertCommand.Parameters.Add("@q26", SqlDbType.VarChar).Value = Q26;

            insertCommand.Parameters.Add("@q27", SqlDbType.VarChar).Value = Q27;

            insertCommand.Parameters.Add("@q28", SqlDbType.VarChar).Value = Q28;

            insertCommand.Parameters.Add("@q29", SqlDbType.VarChar).Value = Q29;

            insertCommand.Parameters.Add("@q30", SqlDbType.VarChar).Value = Q30;

            insertCommand.Parameters.Add("@q31", SqlDbType.VarChar).Value = Q31;

            insertCommand.Parameters.Add("@q32", SqlDbType.VarChar).Value = Q32;

            insertCommand.Parameters.Add("@q33", SqlDbType.VarChar).Value = Q33;

            insertCommand.Parameters.Add("@q34", SqlDbType.VarChar).Value = Q34;

            insertCommand.Parameters.Add("@q35", SqlDbType.VarChar).Value = Q35;

            insertCommand.Parameters.Add("@q36", SqlDbType.VarChar).Value = Q36;

            insertCommand.Parameters.Add("@q37", SqlDbType.VarChar).Value = Q37;

            insertCommand.Parameters.Add("@q38", SqlDbType.VarChar).Value = Q38;

            insertCommand.Parameters.Add("@q39", SqlDbType.VarChar).Value = Q39;

            insertCommand.Parameters.Add("@q40", SqlDbType.VarChar).Value = Q40;

            insertCommand.Parameters.Add("@q41", SqlDbType.VarChar).Value = Q41;

            insertCommand.Parameters.Add("@q42", SqlDbType.VarChar).Value = Q42;

            insertCommand.Parameters.Add("@q43", SqlDbType.VarChar).Value = Q43;

            insertCommand.Parameters.Add("@q44", SqlDbType.VarChar).Value = Q44;

            insertCommand.Parameters.Add("@q45", SqlDbType.VarChar).Value = Q45;

            insertCommand.Parameters.Add("@q46", SqlDbType.VarChar).Value = Q46;

            insertCommand.Parameters.Add("@q47", SqlDbType.VarChar).Value = Q47;

            insertCommand.Parameters.Add("@q48", SqlDbType.VarChar).Value = Q48;

            insertCommand.Parameters.Add("@q49", SqlDbType.VarChar).Value = Q49;

            insertCommand.Parameters.Add("@q50", SqlDbType.VarChar).Value = Q50;

            insertCommand.Parameters.Add("@q51", SqlDbType.VarChar).Value = Q51;

            insertCommand.Parameters.Add("@q52", SqlDbType.VarChar).Value = Q52;

            insertCommand.Parameters.Add("@q53", SqlDbType.VarChar).Value = Q53;

            insertCommand.Parameters.Add("@q54", SqlDbType.VarChar).Value = Q54;

            insertCommand.Parameters.Add("@q55", SqlDbType.VarChar).Value = Q55;

            insertCommand.Parameters.Add("@q56", SqlDbType.VarChar).Value = Q56;

            insertCommand.Parameters.Add("@q57", SqlDbType.VarChar).Value = Q57;

            insertCommand.Parameters.Add("@q58", SqlDbType.VarChar).Value = Q58;

            insertCommand.Parameters.Add("@q59", SqlDbType.VarChar).Value = Q59;

            insertCommand.Parameters.Add("@q60", SqlDbType.VarChar).Value = Q60;

            insertCommand.Parameters.Add("@q61", SqlDbType.VarChar).Value = Q61;

            insertCommand.Parameters.Add("@q62", SqlDbType.VarChar).Value = Q62;

            insertCommand.Parameters.Add("@q63", SqlDbType.VarChar).Value = Q63;

            insertCommand.Parameters.Add("@q64", SqlDbType.VarChar).Value = Q64;

            insertCommand.Parameters.Add("@q65", SqlDbType.VarChar).Value = Q65;

            insertCommand.Parameters.Add("@q66", SqlDbType.VarChar).Value = Q66;

            insertCommand.Parameters.Add("@q67", SqlDbType.VarChar).Value = Q67;

            insertCommand.Parameters.Add("@q68", SqlDbType.VarChar).Value = Q68;

            insertCommand.Parameters.Add("@q69", SqlDbType.VarChar).Value = Q69;

            insertCommand.Parameters.Add("@q70", SqlDbType.VarChar).Value = Q70;

            insertCommand.Parameters.Add("@q71", SqlDbType.VarChar).Value = Q71;

            insertCommand.Parameters.Add("@q72", SqlDbType.VarChar).Value = Q72;

            insertCommand.Parameters.Add("@q73", SqlDbType.VarChar).Value = Q73;

            insertCommand.Parameters.Add("@q74", SqlDbType.VarChar).Value = Q74;

            insertCommand.Parameters.Add("@q75", SqlDbType.VarChar).Value = Q75;

            insertCommand.Parameters.Add("@q76", SqlDbType.VarChar).Value = Q76;

            try
            {
                connection.Open();

                int numRows = insertCommand.ExecuteNonQuery();

            }//end try

            catch (SqlException ex)
            {
                string errorMessage = "SQL Server Error #" + ex.Number.ToString() + ": " + ex.Message.ToString();

                insertObject.setErrorMessage(errorMessage);

            }//end catch

            finally
            {
                connection.Close();

            }//end finally

            return insertObject.getErrorMessage();

        }//end method

    }//end class

}//end namespace