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

namespace BESTPATH
{
    public class Email
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

        public Email()
        {
            this.errorMessage = null;

        }//end constructor

        public static string Email_RUG_APC(string Username, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());
                message.To.Add(Username);

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                message.Attachments.Add(new Attachment(HttpContext.Current.Server.MapPath("~/Docs/BLPDS/Home/6/BestPath_Foundation_Resource_Tools.pdf")));

                message.Subject = "Welcome to being a RUG APC on the BPF website!";
                message.Body = SR.ReadToEnd();
                SR.Close();

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_Pay_APC(string Date, string EmailAddress, string FirstName, string LastName, string PhoneNumber, StreamReader SR, string Counselor, string CounselorName, string CounselorPhoneNumber, DateTime DateToPay)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());

                JimEmail jimEmailAddress = new JimEmail();

                message.To.Add(new MailAddress(jimEmailAddress.getJimEmailAddress()));

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                AccountantsEmail accountantsEmailAddress = new AccountantsEmail();

                message.To.Add(accountantsEmailAddress.getAccountantsEmailAddress());

                message.Subject = "RUG APC needs paid the $300 fee in 72 hours";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%EmailAddress%>", EmailAddress);
                message.Body = message.Body.Replace("<%FirstName%>", FirstName);
                message.Body = message.Body.Replace("<%LastName%>", LastName);
                message.Body = message.Body.Replace("<%PhoneNumber%>", PhoneNumber);
                message.Body = message.Body.Replace("<%Date%>", Date);
                message.Body = message.Body.Replace("<%Counselor%>", Counselor);
                message.Body = message.Body.Replace("<%CounselorName%>", CounselorName);
                message.Body = message.Body.Replace("<%CounselorPhoneNumber%>", CounselorPhoneNumber);
                message.Body = message.Body.Replace("<%DatePaid%>", DateToPay.ToString());


                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_New_Client(string Date, string EmailAddress, string FirstName, string LastName, string PhoneNumber, StreamReader SR, string Counselor, string CounselorName, string CounselorPhoneNumber)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());

                JimEmail jimEmailAddress = new JimEmail();

                message.To.Add(new MailAddress(jimEmailAddress.getJimEmailAddress()));

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                message.To.Add(Counselor);

                AccountantsEmail accountantsEmailAddress = new AccountantsEmail();

                message.To.Add(accountantsEmailAddress.getAccountantsEmailAddress());

                message.Subject = "New client on the BPF website";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%EmailAddress%>", EmailAddress);
                message.Body = message.Body.Replace("<%FirstName%>", FirstName);
                message.Body = message.Body.Replace("<%LastName%>", LastName);
                message.Body = message.Body.Replace("<%PhoneNumber%>", PhoneNumber);
                message.Body = message.Body.Replace("<%Date%>", Date);
                message.Body = message.Body.Replace("<%Counselor%>", Counselor);
                message.Body = message.Body.Replace("<%CounselorName%>", CounselorName);
                message.Body = message.Body.Replace("<%CounselorPhoneNumber%>", CounselorPhoneNumber);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_Verification(string Username, string FirstName, string FullPath, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());
                message.To.Add(Username);

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                message.Subject = "Welcome to the BPF Life Purpose Development Series!";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%FirstName%>", FirstName);
                message.Body = message.Body.Replace("<%VerificationUrl%>", FullPath);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_Career_Marketability_Assessment(string DateCompleted, string EmailAddress, string FirstName, string LastName, string PhoneNumber, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13, string Q14, string Q15, string Q16, string Q17, string Q18, string Q19, string Q20, string Q21, string Q22, string Q23, string Q24, string Score, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());

                JimEmail jimEmailAddress = new JimEmail();

                message.To.Add(new MailAddress(jimEmailAddress.getJimEmailAddress()));

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                message.Subject = "New Career Marketability Assessment";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%EmailAddress%>", EmailAddress);
                message.Body = message.Body.Replace("<%FirstName%>", FirstName);
                message.Body = message.Body.Replace("<%LastName%>", LastName);
                message.Body = message.Body.Replace("<%PhoneNumber%>", PhoneNumber);
                message.Body = message.Body.Replace("<%DateCompleted%>", DateCompleted);
                message.Body = message.Body.Replace("<%Q5%>", Q5);
                message.Body = message.Body.Replace("<%Q6%>", Q6);
                message.Body = message.Body.Replace("<%Q7%>", Q7);
                message.Body = message.Body.Replace("<%Q8%>", Q8);
                message.Body = message.Body.Replace("<%Q9%>", Q9);
                message.Body = message.Body.Replace("<%Q10%>", Q10);
                message.Body = message.Body.Replace("<%Q11%>", Q11);
                message.Body = message.Body.Replace("<%Q12%>", Q12);
                message.Body = message.Body.Replace("<%Q13%>", Q13);
                message.Body = message.Body.Replace("<%Q14%>", Q14);
                message.Body = message.Body.Replace("<%Q15%>", Q15);
                message.Body = message.Body.Replace("<%Q16%>", Q16);
                message.Body = message.Body.Replace("<%Q17%>", Q17);
                message.Body = message.Body.Replace("<%Q18%>", Q18);
                message.Body = message.Body.Replace("<%Q19%>", Q19);
                message.Body = message.Body.Replace("<%Q20%>", Q20);
                message.Body = message.Body.Replace("<%Q21%>", Q21);
                message.Body = message.Body.Replace("<%Q22%>", Q22);
                message.Body = message.Body.Replace("<%Q23%>", Q23);
                message.Body = message.Body.Replace("<%Q24%>", Q24);
                message.Body = message.Body.Replace("<%Score%>", Score);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_Needs_Assessment_Package(string DateCompleted, string FirstName, string LastName, string EmailAddress, string PhoneNumber, string Q5, string Q6, string Q7, string Q8, string Q9, string Q10, string Q11, string Q12, string Q13, string Q14, string Q15, string Q16, string Q17, string Q18, string Q19, string Q20, string Q21, string Q22, string Q23, string Q24, string Q25, string Q26, string Q27, string Q28, string Q29, string Q30, string Q31, string Q32, string Q33, string Q34, string Q35, string Q36, string Q37, string Q38, string Q39, string Q40, string Q41, string Q42, string Q43, string Q44, string Q45, string Q46, string ReferralSource, string ReferralName, string RUGAPCEmailAddress, string DateCompleted2, string Q2_1, string Q2_2, string Q2_3, string Q2_4, string Q2_5, string Q2_6, string Q2_7, string Q2_8, string Q2_9, string Q2_10, string Q2_11, string Q2_12, string Q2_13, string Q2_14, string Q2_15, string Q2_16, string Q2_17, string Q2_18, string Q2_19, string Q2_20, string Score, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());

                if (RUGAPCEmailAddress == "")
                {
                    JimEmail jimEmailAddress = new JimEmail();

                    message.To.Add(new MailAddress(jimEmailAddress.getJimEmailAddress()));

                }//end if

                else
                {
                    JimEmail jimEmailAddress = new JimEmail();

                    message.CC.Add(new MailAddress(jimEmailAddress.getJimEmailAddress()));

                    message.To.Add(new MailAddress(RUGAPCEmailAddress));

                }//end else

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                message.Subject = "New Needs Assessment package";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%DateCompleted%>", DateCompleted);
                message.Body = message.Body.Replace("<%FirstName%>", FirstName);
                message.Body = message.Body.Replace("<%LastName%>", LastName);
                message.Body = message.Body.Replace("<%EmailAddress%>", EmailAddress);
                message.Body = message.Body.Replace("<%PhoneNumber%>", PhoneNumber);
                message.Body = message.Body.Replace("<%Q5%>", Q5);
                message.Body = message.Body.Replace("<%Q6%>", Q6);
                message.Body = message.Body.Replace("<%Q7%>", Q7);
                message.Body = message.Body.Replace("<%Q8%>", Q8);
                message.Body = message.Body.Replace("<%Q9%>", Q9);
                message.Body = message.Body.Replace("<%Q10%>", Q10);
                message.Body = message.Body.Replace("<%Q11%>", Q11);
                message.Body = message.Body.Replace("<%Q12%>", Q12);
                message.Body = message.Body.Replace("<%Q13%>", Q13);
                message.Body = message.Body.Replace("<%Q14%>", Q14);
                message.Body = message.Body.Replace("<%Q15%>", Q15);
                message.Body = message.Body.Replace("<%Q16%>", Q16);
                message.Body = message.Body.Replace("<%Q17%>", Q17);
                message.Body = message.Body.Replace("<%Q18%>", Q18);
                message.Body = message.Body.Replace("<%Q19%>", Q19);
                message.Body = message.Body.Replace("<%Q20%>", Q20);
                message.Body = message.Body.Replace("<%Q21%>", Q21);
                message.Body = message.Body.Replace("<%Q22%>", Q22);
                message.Body = message.Body.Replace("<%Q23%>", Q23);
                message.Body = message.Body.Replace("<%Q24%>", Q24);
                message.Body = message.Body.Replace("<%Q25%>", Q25);
                message.Body = message.Body.Replace("<%Q26%>", Q26);
                message.Body = message.Body.Replace("<%Q27%>", Q27);
                message.Body = message.Body.Replace("<%Q28%>", Q28);
                message.Body = message.Body.Replace("<%Q29%>", Q29);
                message.Body = message.Body.Replace("<%Q30%>", Q30);
                message.Body = message.Body.Replace("<%Q31%>", Q31);
                message.Body = message.Body.Replace("<%Q32%>", Q32);
                message.Body = message.Body.Replace("<%Q33%>", Q33);
                message.Body = message.Body.Replace("<%Q34%>", Q34);
                message.Body = message.Body.Replace("<%Q35%>", Q35);
                message.Body = message.Body.Replace("<%Q36%>", Q36);
                message.Body = message.Body.Replace("<%Q37%>", Q37);
                message.Body = message.Body.Replace("<%Q38%>", Q38);
                message.Body = message.Body.Replace("<%Q39%>", Q39);
                message.Body = message.Body.Replace("<%Q40%>", Q40);
                message.Body = message.Body.Replace("<%Q41%>", Q41);
                message.Body = message.Body.Replace("<%Q42%>", Q42);
                message.Body = message.Body.Replace("<%Q43%>", Q43);
                message.Body = message.Body.Replace("<%Q44%>", Q44);
                message.Body = message.Body.Replace("<%Q45%>", Q45);
                message.Body = message.Body.Replace("<%Q46%>", Q46);
                message.Body = message.Body.Replace("<%ReferralSource%>", ReferralSource);
                message.Body = message.Body.Replace("<%ReferralName%>", ReferralName);
                message.Body = message.Body.Replace("<%RUGAPCEmailAddress%>", RUGAPCEmailAddress);
                message.Body = message.Body.Replace("<%DateCompleted2%>", DateCompleted2);
                message.Body = message.Body.Replace("<%Q2_1%>", Q2_1);
                message.Body = message.Body.Replace("<%Q2_2%>", Q2_2);
                message.Body = message.Body.Replace("<%Q2_3%>", Q2_3);
                message.Body = message.Body.Replace("<%Q2_4%>", Q2_4);
                message.Body = message.Body.Replace("<%Q2_5%>", Q2_5);
                message.Body = message.Body.Replace("<%Q2_6%>", Q2_6);
                message.Body = message.Body.Replace("<%Q2_7%>", Q2_7);
                message.Body = message.Body.Replace("<%Q2_8%>", Q2_8);
                message.Body = message.Body.Replace("<%Q2_9%>", Q2_9);
                message.Body = message.Body.Replace("<%Q2_10%>", Q2_10);
                message.Body = message.Body.Replace("<%Q2_11%>", Q2_11);
                message.Body = message.Body.Replace("<%Q2_12%>", Q2_12);
                message.Body = message.Body.Replace("<%Q2_13%>", Q2_13);
                message.Body = message.Body.Replace("<%Q2_14%>", Q2_14);
                message.Body = message.Body.Replace("<%Q2_15%>", Q2_15);
                message.Body = message.Body.Replace("<%Q2_16%>", Q2_16);
                message.Body = message.Body.Replace("<%Q2_17%>", Q2_17);
                message.Body = message.Body.Replace("<%Q2_18%>", Q2_18);
                message.Body = message.Body.Replace("<%Q2_19%>", Q2_19);
                message.Body = message.Body.Replace("<%Q2_20%>", Q2_20);
                message.Body = message.Body.Replace("<%Score%>", Score);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_MDC_Complete(string Username, string ClientCounselor, string CounselorFirstName, string ClientName, string ClientPhoneNumber, string Date, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());

                message.To.Add(new MailAddress(ClientCounselor));

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                //message.Attachments.Add(new Attachment(HttpContext.Current.Server.MapPath("~/Docs/FOP/Statement_of_Value_JD.pdf")));
                //message.Attachments.Add(new Attachment(HttpContext.Current.Server.MapPath("~/Docs/FOP/Expanded_Experience_Profile_JD.pdf")));

                message.Subject = "One of your clients has just completed FOP!";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%CounselorFirstName%>", CounselorFirstName);
                message.Body = message.Body.Replace("<%UserName%>", Username);
                message.Body = message.Body.Replace("<%ClientName%>", ClientName);
                message.Body = message.Body.Replace("<%PhoneNumber%>", ClientPhoneNumber);
                message.Body = message.Body.Replace("<%Date%>", Date);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_Counseling(string Username, string ClientCounselor, string CounselorFirstName, string ClientName, string Date, string DescriptionOfIssue, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());

                message.To.Add(new MailAddress(ClientCounselor));

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                message.Subject = "New BestPath Foundation client counseling request";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%CounselorFirstName%>", CounselorFirstName);
                message.Body = message.Body.Replace("<%UserName%>", Username);
                message.Body = message.Body.Replace("<%ClientName%>", ClientName);
                message.Body = message.Body.Replace("<%Date%>", Date);
                message.Body = message.Body.Replace("<%DescriptionOfIssue%>", DescriptionOfIssue);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_Welcome(string Counselor, string FirstName, string Username, string Password, string FullPath, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());
                message.To.Add(Username);

                message.CC.Add(new MailAddress(Counselor));

                SA_Email sa_email = new SA_Email();

                message.CC.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                message.Subject = "Welcome to the BPF Life Purpose Development Series!";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%FirstName%>", FirstName);
                message.Body = message.Body.Replace("<%UserName%>", Username);
                message.Body = message.Body.Replace("<%Password%>", Password);
                message.Body = message.Body.Replace("<%RegistrationUrl%>", FullPath);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_Help(string Username, string ClientName, string DateOfIncident, string DescriptionOfProblem, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());

                SA_Email sa_email = new SA_Email();
                message.To.Add(new MailAddress(sa_email.getSA_EmailAddress()));

                message.Subject = "New BestPath Foundation client help request";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%UserName%>", Username);
                message.Body = message.Body.Replace("<%ClientName%>", ClientName);
                message.Body = message.Body.Replace("<%DateOfIncident%>", DateOfIncident);
                message.Body = message.Body.Replace("<%DescriptionOfProblem%>", DescriptionOfProblem);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

        public static string Email_Forgot_Password(string Username, string ClientFirstName, string NewPassword, string FullPath, StreamReader SR)
        {
            Email emailObject = new Email();

            try
            {
                SMTP_Settings SMTP_Client = new SMTP_Settings();
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(SMTP_Client.getFromEmailAddress());
                message.To.Add(new MailAddress(Username));
                message.Subject = "Password reset";
                message.Body = SR.ReadToEnd();
                SR.Close();

                message.Body = message.Body.Replace("<%FirstName%>", ClientFirstName);
                message.Body = message.Body.Replace("<%NewPassword%>", NewPassword);
                message.Body = message.Body.Replace("<%LoginPage%>", FullPath);

                SmtpClient client = new SmtpClient();
                client.EnableSsl = SMTP_Client.getEnableSSL();
                client.UseDefaultCredentials = SMTP_Client.getUseDefaultCredentials();
                client.Credentials = SMTP_Client.getCredentials();
                client.Host = SMTP_Client.getHost();
                client.Port = SMTP_Client.getPort();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                client.Send(message);
                client.Send(message);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Email Error: " + ex.Message.ToString();

                emailObject.setErrorMessage(errorMessage);

            }//end catch

            return emailObject.getErrorMessage();

        }//end method

    }//end class

}//end namespace