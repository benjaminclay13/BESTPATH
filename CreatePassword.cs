using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BESTPATH
{
    public class CreatePassword
    {
        private string password;

        public CreatePassword()
        {
            this.password = "";

        }//end constructor

        public string Create_Password(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder res = new StringBuilder();

            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);

            }//end while

            return res.ToString();

        }//end method

    }//end class

}//end namespace