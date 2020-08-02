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
    public partial class _SpiritualSupport : Page
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

            }//end if

            else
            {
                Response.Redirect("~/PL/Membership/Login.aspx");

            }//end else

        }//end event

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-1_Introduction_to_Module_5.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-1_Introduction_to_Module_5.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-2_RUG_statement_of_faith_and_operating_principles.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-2_RUG_statement_of_faith_and_operating_principles.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-3_Resources_provided_by_Module_5.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-3_Resources_provided_by_Module_5.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-4_Module_5_study_guides.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-4_Module_5_study_guides.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-5_Presenting_the_Gospel.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-5_Presenting_the_Gospel.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-6_Discovering_our_calling.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-6_Discovering_our_calling.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-7_Was_that_call_for_me.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-7_Was_that_call_for_me.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/doc";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-8_Models_of_discipleship_form.doc");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-8_Models_of_discipleship_form.doc"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-9_Product_definition_components.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-9_Product_definition_components.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/doc";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-10_God's_perspective_on_work_career_service_form.doc");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-10_God's_perspective_on_work_career_service_form.doc"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-11_God's_perspective_on_work_career_service_Answers.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-11_God's_perspective_on_work_career_service_Answers.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-12_The_call_of_God.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-12_The_call_of_God.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-13_Moving_from_work_to_worship.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-13_Moving_from_work_to_worship.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-14_Seeking_the_path_(God's_will).pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-14_Seeking_the_path_(God's_will).pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-15_Scriptures_to_support_your_life_path.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_1/Disc_1/1-15_Scriptures_to_support_your_life_path.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-1_Spiritual_law_of_maximum_growth.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-1_Spiritual_law_of_maximum_growth.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton17_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-2_The_need_for_accountability.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-2_The_need_for_accountability.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton18_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-3_The_need_for_integrity.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-3_The_need_for_integrity.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton19_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-4_The_need_for_creativity.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-4_The_need_for_creativity.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton20_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-5_Characteristics_of_powerful_people.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-5_Characteristics_of_powerful_people.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton21_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-6_Spiritual_gifts_from_the_Holy_Spirit.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-6_Spiritual_gifts_from_the_Holy_Spirit.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton22_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-7_Can_a_saint_falsely_accuse_God.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-7_Can_a_saint_falsely_accuse_God.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton23_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-8_Identifying_your_spiritual_gifts_extended.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-8_Identifying_your_spiritual_gifts_extended.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton24_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/doc";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-9_Identifying_your_spiritual_gifts_form.doc");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-9_Identifying_your_spiritual_gifts_form.doc"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton25_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-10_Your_work_matters_to_God.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-10_Your_work_matters_to_God.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton26_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-11_Seven_truths_of_experiencing_God.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-11_Seven_truths_of_experiencing_God.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton27_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-12_How_to_determine_God's_will.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-12_How_to_determine_God's_will.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton28_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/doc";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-13_Building_vision_and_mission_statements_form.doc");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-13_Building_vision_and_mission_statements_form.doc"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton29_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-14_Boundaries_in_the_workplace.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-14_Boundaries_in_the_workplace.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton30_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-15_How_to_be_successful_in_the_Lord.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-15_How_to_be_successful_in_the_Lord.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton31_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-16_Five_principles_for_prosperity.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-16_Five_principles_for_prosperity.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton32_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-17_Work_career_service_hope.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/Part_2/Disc_1/2-17_Work_career_service_hope.pdf"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

        }//end event

        protected void LinkButton33_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            try
            {
                Response.ContentType = "Application/zip";
                Response.AppendHeader("Content-Disposition", "attachment; filename=RUG_APC_package.zip");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_5/RUG_APC_package.zip"));
                Response.End();

            }//end try

            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end catch

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