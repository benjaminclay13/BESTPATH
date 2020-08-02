using System;
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

namespace BESTPATH
{
    public class SMTP_Settings
    {
        private string Host;
        private int Port;
        private NetworkCredential Credentials;
        private bool UseDefaultCredentials;
        private bool EnableSSL;
        private string FromEmailAddress;

        public string getHost()
        {
            return this.Host;

        }//end property

        public int getPort()
        {
            return this.Port;

        }//end property

        public NetworkCredential getCredentials()
        {
            return this.Credentials;

        }//end property

        public bool getUseDefaultCredentials()
        {
            return this.UseDefaultCredentials;

        }//end property

        public bool getEnableSSL()
        {
            return this.EnableSSL;

        }//end property

        public string getFromEmailAddress()
        {
            return this.FromEmailAddress;

        }//end property

        public SMTP_Settings()
        {
            ////PRODUCTION SMTP SETTINGS
            //this.Host = "pss23mail.win.hostgator.com";
            //this.Port = 25;
            //this.Credentials = new NetworkCredential("admin@bestpathfoundation.com", "!!k%}yF+w^oj+>0D");
            //this.UseDefaultCredentials = false;
            //this.EnableSSL = true;
            //this.FromEmailAddress = "admin@bestpathfoundation.com";

            ////TEST SMTP SETTINGS
            this.Host = "hgws8.win.hostgator.com";
            this.Port = 25;
            this.Credentials = new NetworkCredential("bclay@bestpathfoundation2.com", "2xmui15VXTpL2GLs");
            this.UseDefaultCredentials = false;
            this.EnableSSL = false;
            this.FromEmailAddress = "bclay@bestpathfoundation2.com";

            ////LOCAL SMTP SETTINGS
            //this.Host = "smtp.gmail.com";
            //this.Port = 587;
            //this.Credentials = new NetworkCredential("benjaminpatrick12@gmail.com", "Patrick020811");
            //this.UseDefaultCredentials = false;
            //this.EnableSSL = false;
            //this.FromEmailAddress = "benjaminpatrick12@gmail.com";

        }//end constructor

    }//end class

}//end namespace