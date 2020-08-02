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
    public partial class _OutstandingOrientation : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpContext.Current.Response.Cache.SetAllowResponseInBrowserHistory(false);
            //HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //HttpContext.Current.Response.Cache.SetNoStore();
            //Response.Cache.SetExpires(DateTime.Now);
            //Response.Cache.SetValidUntilExpires(true);
            //Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            //Response.Cache.SetNoStore();

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
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-1_Welcome_to_Resources_Unlimited_Group.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_1/Disc_2/1-1_Welcome_to_Resources_Unlimited_Group.pdf"));
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
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-2_Resources_provided_by_Outstanding_Orientation.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_1/Disc_2/1-2_Resources_provided_by_Outstanding_Orientation.pdf"));
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
                Response.ContentType = "Application/doc";
                Response.AppendHeader("Content-Disposition", "attachment; filename=1-3_Outstanding_Orientation_form.doc");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_1/Disc_2/1-3_Outstanding_Orientation_form.doc"));
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
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-1_Welcome_to_Resources_Unlimited_Group.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_2/Disc_4/2-1_Welcome_to_Resources_Unlimited_Group.pdf"));
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
                Response.ContentType = "Application/doc";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-2_Work_and_rest_questionnaire.doc");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_2/Disc_4/2-2_Work_and_rest_questionnaire.doc"));
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
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-3_What_So_what_Now_what.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_2/Disc_4/2-3_What_So_what_Now_what.pdf"));
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
                Response.ContentType = "Application/doc";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-4_Principles_governing_work_and_rest_form.doc");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_2/Disc_4/2-4_Principles_governing_work_and_rest_form.doc"));
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
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-5_Why_Go_To_Work_Scriptures.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_2/Disc_4/2-5_Why_Go_To_Work_Scriptures.pdf"));
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
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-6_What_are_your_life_priorities.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_2/Disc_4/2-6_What_are_your_life_priorities.pdf"));
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
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-7_Joseph's_career_path.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_2/Disc_4/2-7_Joseph's_career_path.pdf"));
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
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=2-8_God's_covenant_relationship.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Part_2/Disc_4/2-8_God's_covenant_relationship.pdf"));
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
                Response.AppendHeader("Content-Disposition", "attachment; filename=Moving_from_work_to_worship.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Module_1/Primer/Moving_from_work_to_worship.pdf"));
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