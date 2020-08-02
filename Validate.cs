using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BESTPATH
{
    public class Validate
    {
        public Validate()
        {
        }//end constructor

        public string Truncate(string Input, int MaxLength)
        {
            string truncated;

            if (Input.Length > MaxLength)
            {
                truncated = Input.Substring(0, MaxLength);

            }//end if

            else
            {
                truncated = Input;

            }//end else

            return truncated;

        }//end method

        public bool Required(string Input)
        {
            bool isValid = true;

            Input = Input.Trim();

            if ((Input == "") || (Input == null))
            {
                isValid = false;

            }//end if

            return isValid;

        }//end method

        public bool PhoneNumber(string PhoneNumber)
        {
            return Regex.Match(PhoneNumber, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}").Success;

        }//end method

        public bool EmailAddress(string EmailAddress)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(EmailAddress);

                return emailAddress.Address == EmailAddress;

            }//end try

            catch
            {
                return false;

            }//end catch

        }//end method

        public string ZipCode(string ZipCode)
        {
            ArrayList validationData = new ArrayList();

            string errorMessage = "";

            bool zipCodeValid = true;

            int testZipCode;

            zipCodeValid = Int32.TryParse(ZipCode, out testZipCode);

            if (zipCodeValid == false)
            {
                errorMessage = "Invalid Zip Code";

            }//end if

            else
            {
                int zipCodeLength = ZipCode.Length;

                if (zipCodeLength != 5)
                {
                    errorMessage = "Zip Code must be a valid 5 digit number";

                }//end if

            }//end else

            return errorMessage;

        }//end method

        public string CreditCardNumber(string CreditCardNumber)
        {
            string errorMessage = "";

            bool creditCardNumberValid = true;

            Int64 testCreditCardNumber;

            creditCardNumberValid = Int64.TryParse(CreditCardNumber, out testCreditCardNumber);

            if (creditCardNumberValid == false)
            {
                errorMessage = "Invalid Credit Card Number";

            }//end if

            else
            {
                int creditCardNumberLength = CreditCardNumber.Length;

                if (creditCardNumberLength != 16)
                {
                    errorMessage = "Credit Card Number must be a valid 16 digit number";

                }//end if

            }//end else

            return errorMessage;

        }//end method

    }//end class

}//end namespace