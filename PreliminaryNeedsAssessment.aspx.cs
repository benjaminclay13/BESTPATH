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
using System.IO;

namespace BESTPATH
{
    public partial class _PreliminaryNeedsAssessment : Page
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

            if (ddlReferralSource.AutoPostBack)
            {
                string referralSource = ddlReferralSource.SelectedValue;

                if (referralSource == "Referred by a past client who is a RUG Authorized Personal Counselor (APC)")
                {
                    rfvReferralName.Enabled = true;
                    rfvRUGAPCEmailAddress.Enabled = true;

                }//end if

                else if (referralSource == "Referred by a past client who made no mention of being a RUG APC")
                {
                    rfvReferralName.Enabled = true;
                    rfvRUGAPCEmailAddress.Enabled = false;

                }//end else if

                else if (referralSource == "Church outreach")
                {
                    rfvReferralName.Enabled = true;
                    rfvRUGAPCEmailAddress.Enabled = false;

                }//else if

                else if (referralSource == "Other")
                {
                    rfvReferralName.Enabled = true;
                    rfvRUGAPCEmailAddress.Enabled = false;

                }//else if

                else
                {
                    rfvReferralName.Enabled = false;
                    rfvRUGAPCEmailAddress.Enabled = false;

                }//end else

                txtRUGAPCEmailAddress.Focus();

            }//end if

            if (IsPostBack == false)
            {
                txtFirstName.Focus();

            }//end if

        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string emailAddress = txtEmailAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string Q5 = rblQ5.SelectedValue;
            string Q6 = txtQ6.InnerText;
            string Q7 = txtQ7.InnerText;
            string Q8 = txtQ8.InnerText;
            string Q9 = rblQ9.SelectedValue;
            string Q10 = txtQ10.InnerText;
            string Q11 = rblQ11.SelectedValue;
            string Q12 = rblQ12.SelectedValue;
            string Q13 = txtQ13.InnerText;
            string Q14 = txtQ14.InnerText;
            string Q15 = txtQ15.InnerText;
            string Q16 = txtQ16.InnerText;
            string Q17 = txtQ17.InnerText;
            string Q18 = txtQ18.InnerText;
            string Q19 = txtQ19.InnerText;
            string Q20 = txtQ20.InnerText;
            string Q21 = txtQ21.InnerText;
            string Q22 = txtQ22.InnerText;
            string Q23 = txtQ23.InnerText;
            string Q24 = txtQ24.InnerText;
            string Q25 = txtQ25.InnerText;
            string Q26 = txtQ26.InnerText;
            string Q27 = txtQ27.InnerText;
            string Q28 = txtQ28.InnerText;
            string Q29 = txtQ29.InnerText;
            string Q30 = txtQ30.InnerText;
            string Q31 = txtQ31.InnerText;
            string Q32 = txtQ32.InnerText;
            string Q33 = txtQ33.InnerText;
            string Q34 = txtQ34.InnerText;
            string Q35 = txtQ35.InnerText;
            string Q36 = rblQ36.SelectedValue;
            string Q37 = txtQ37.InnerText;
            string Q38 = txtQ38.InnerText;
            string Q39 = txtQ39.InnerText;
            string Q40 = txtQ40.InnerText;
            string Q41 = txtQ41.InnerText;
            string Q42 = txtQ42.InnerText;
            string Q43 = txtQ43.InnerText;
            string Q44 = txtQ44.InnerText;
            string Q45 = txtQ45.InnerText;
            string Q46 = txtQ46.InnerText;
            string referralSource = ddlReferralSource.SelectedValue;
            string referralName = txtReferralName.Text;
            string RUGAPCEmailAddress = txtRUGAPCEmailAddress.Text;

            Validate validationObject = new Validate();

            firstName = validationObject.Truncate(firstName, 900);
            lastName = validationObject.Truncate(lastName, 900);
            emailAddress = validationObject.Truncate(emailAddress, 900);
            phoneNumber = validationObject.Truncate(phoneNumber, 900);
            Q5 = validationObject.Truncate(Q5, 900);
            Q6 = validationObject.Truncate(Q6, 900);
            Q7 = validationObject.Truncate(Q7, 900);
            Q8 = validationObject.Truncate(Q8, 900);
            Q9 = validationObject.Truncate(Q9, 900);
            Q10 = validationObject.Truncate(Q10, 900);
            Q11 = validationObject.Truncate(Q11, 900);
            Q12 = validationObject.Truncate(Q12, 900);
            Q13 = validationObject.Truncate(Q13, 900);
            Q14 = validationObject.Truncate(Q14, 900);
            Q15 = validationObject.Truncate(Q15, 900);
            Q16 = validationObject.Truncate(Q16, 900);
            Q17 = validationObject.Truncate(Q17, 900);
            Q18 = validationObject.Truncate(Q18, 900);
            Q19 = validationObject.Truncate(Q19, 900);
            Q20 = validationObject.Truncate(Q20, 900);
            Q21 = validationObject.Truncate(Q21, 900);
            Q22 = validationObject.Truncate(Q22, 900);
            Q23 = validationObject.Truncate(Q23, 900);
            Q24 = validationObject.Truncate(Q24, 900);
            Q25 = validationObject.Truncate(Q25, 900);
            Q26 = validationObject.Truncate(Q26, 900);
            Q27 = validationObject.Truncate(Q27, 900);
            Q28 = validationObject.Truncate(Q28, 900);
            Q29 = validationObject.Truncate(Q29, 900);
            Q30 = validationObject.Truncate(Q30, 900);
            Q31 = validationObject.Truncate(Q31, 900);
            Q32 = validationObject.Truncate(Q32, 900);
            Q33 = validationObject.Truncate(Q33, 900);
            Q34 = validationObject.Truncate(Q34, 900);
            Q35 = validationObject.Truncate(Q35, 900);
            Q36 = validationObject.Truncate(Q36, 900);
            Q37 = validationObject.Truncate(Q37, 900);
            Q38 = validationObject.Truncate(Q38, 900);
            Q39 = validationObject.Truncate(Q39, 900);
            Q40 = validationObject.Truncate(Q40, 900);
            Q41 = validationObject.Truncate(Q41, 900);
            Q42 = validationObject.Truncate(Q42, 900);
            Q43 = validationObject.Truncate(Q43, 900);
            Q44 = validationObject.Truncate(Q44, 900);
            Q45 = validationObject.Truncate(Q45, 900);
            Q46 = validationObject.Truncate(Q46, 900);
            referralSource = validationObject.Truncate(referralSource, 900);
            referralName = validationObject.Truncate(referralName, 900);
            RUGAPCEmailAddress = validationObject.Truncate(RUGAPCEmailAddress, 900);

            string errorMessage;

            Select selectObject = new Select();

            bool preliminaryNeedsAssessmentExists;

            preliminaryNeedsAssessmentExists = Select.Preliminary_Needs_Assessment_Exists(emailAddress);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError.Text = errorMessage;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end if

            else if (preliminaryNeedsAssessmentExists == true)
            {
                MsgBox("Invalid. This assessment has already been submitted.");

            }//end else if

            else if (preliminaryNeedsAssessmentExists == false)
            {
                if (RUGAPCEmailAddress != "")
                {
                    bool isRUGAPC;

                    string errorMessage30;

                    Select selectObject30 = new Select();

                    isRUGAPC = Select.Is_User_RUG_APC(RUGAPCEmailAddress);

                    errorMessage30 = selectObject30.getErrorMessage();

                    if (errorMessage30 != null)
                    {
                        lblError.Text = errorMessage30;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else if (isRUGAPC == false)
                    {
                        MsgBox("Invalid. User specified for RUG APC is not a RUG APC in the system. Please confer with Jim Davis, founder.");

                        return;

                    }//end else if

                }//end if

                string errorMessage2;

                errorMessage2 = Insert.Insert_Preliminary_Needs_Assessment(today, emailAddress, firstName, lastName, phoneNumber, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21, Q22, Q23, Q24, Q25, Q26, Q27, Q28, Q29, Q30, Q31, Q32, Q33, Q34, Q35, Q36, Q37, Q38, Q39, Q40, Q41, Q42, Q43, Q44, Q45, Q46, referralSource, referralName, RUGAPCEmailAddress);

                if (errorMessage2 != null)
                {
                    lblError.Text = errorMessage2;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.GenericErrorMessage);

                }//end if

                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Thank you very much for taking the time to share this information with us. Now, the next step for you is to complete the Career Marketability Assessment. May God richly bless you and your life path endeavors!');window.location ='../../Home.aspx';", true);

                }//end else

            }//end else if

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