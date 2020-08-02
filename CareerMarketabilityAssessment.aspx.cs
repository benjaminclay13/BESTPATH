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
using System.Globalization;

namespace BESTPATH
{
    public partial class _CareerMarketabilityAssessment : Page
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

            if (Page.IsPostBack == false)
            {
                MultiView1.SetActiveView(View3);

            }//end if

            txtEmailAddress.Focus();

        }//end event

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            string emailAddress = txtEmailAddress.Text;

            string errorMessage4;

            Select selectObject2 = new Select();

            bool preliminaryNeedsAssessmentExists;

            preliminaryNeedsAssessmentExists = Select.Preliminary_Needs_Assessment_Exists(emailAddress);

            errorMessage4 = selectObject2.getErrorMessage();

            if (errorMessage4 != null)
            {
                lblError2.Text = errorMessage4;
                lblError2.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.GenericErrorMessage);

            }//end if

            else if (preliminaryNeedsAssessmentExists == false)
            {
                MsgBox("Invalid. You must complete the Preliminary Needs Assessment first prior to completing this Career Marketability Assessment.");

            }//end else if

            else if (preliminaryNeedsAssessmentExists == true)
            {
                MultiView1.SetActiveView(View1);

            }//end else if

        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime dateCompleted2 = DateTime.Today;

            string emailAddress = txtEmailAddress.Text;
            string Q1 = txtQ1.Text;
            string Q2 = txtQ2.Text;
            string Q3 = txtQ3.Text;
            string Q4 = txtQ4.Text;
            string Q5 = txtQ5.Text;
            string Q6 = txtQ6.Text;
            string Q7 = txtQ7.Text;
            string Q8 = txtQ8.Text;
            string Q9 = txtQ9.Text;
            string Q10 = txtQ10.Text;
            string Q11 = txtQ11.Text;
            string Q12 = txtQ12.Text;
            string Q13 = txtQ13.Text;
            string Q14 = txtQ14.Text;
            string Q15 = txtQ15.Text;
            string Q16 = txtQ16.Text;
            string Q17 = txtQ17.Text;
            string Q18 = txtQ18.Text;
            string Q19 = txtQ19.Text;
            string Q20 = txtQ20.Text;

            Validate validationObject = new Validate();

            emailAddress = validationObject.Truncate(emailAddress, 900);
            Q1= validationObject.Truncate(Q1, 1);
            Q2 = validationObject.Truncate(Q2, 1);
            Q3 = validationObject.Truncate(Q3, 1);
            Q4 = validationObject.Truncate(Q4, 1);
            Q5 = validationObject.Truncate(Q5, 1);
            Q6 = validationObject.Truncate(Q6, 1);
            Q7 = validationObject.Truncate(Q7, 1);
            Q8 = validationObject.Truncate(Q8, 1);
            Q9 = validationObject.Truncate(Q9, 1);
            Q10 = validationObject.Truncate(Q10, 1);
            Q11 = validationObject.Truncate(Q11, 1);
            Q12 = validationObject.Truncate(Q12, 1);
            Q13 = validationObject.Truncate(Q13, 1);
            Q14 = validationObject.Truncate(Q14, 1);
            Q15 = validationObject.Truncate(Q15, 1);
            Q16 = validationObject.Truncate(Q16, 1);
            Q17 = validationObject.Truncate(Q17, 1);
            Q18 = validationObject.Truncate(Q18, 1);
            Q19 = validationObject.Truncate(Q19, 1);
            Q20 = validationObject.Truncate(Q20, 1);

            long _Q1 = Convert.ToInt64(Q1);
            long _Q2 = Convert.ToInt64(Q2);
            long _Q3 = Convert.ToInt64(Q3);
            long _Q4 = Convert.ToInt64(Q4);
            long _Q5 = Convert.ToInt64(Q5);
            long _Q6 = Convert.ToInt64(Q6);
            long _Q7 = Convert.ToInt64(Q7);
            long _Q8 = Convert.ToInt64(Q8);
            long _Q9 = Convert.ToInt64(Q9);
            long _Q10 = Convert.ToInt64(Q10);
            long _Q11 = Convert.ToInt64(Q11);
            long _Q12 = Convert.ToInt64(Q12);
            long _Q13 = Convert.ToInt64(Q13);
            long _Q14 = Convert.ToInt64(Q14);
            long _Q15 = Convert.ToInt64(Q15);
            long _Q16 = Convert.ToInt64(Q16);
            long _Q17 = Convert.ToInt64(Q17);
            long _Q18 = Convert.ToInt64(Q18);
            long _Q19 = Convert.ToInt64(Q19);
            long _Q20 = Convert.ToInt64(Q20);

            long score = _Q1 + _Q2 + _Q3 + _Q4 + _Q5 + _Q6 + _Q7 + _Q8 + _Q9 + _Q10 + _Q11 + _Q12 + _Q13 + _Q14 + _Q15 + _Q16 + _Q17 + _Q18 + _Q19 + _Q20;

            lblScore.Text = score.ToString();

            string errorMessage5;

            Select selectObject5 = new Select();

            ArrayList data = new ArrayList();

            data = Select.Select_PRELIMINARY_NEEDS_ASSESSMENT_Data(emailAddress);

            errorMessage5 = selectObject5.getErrorMessage();

            if (errorMessage5 != null)
            {
                lblError.Text = errorMessage5;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                string dateCompleted = data[1].ToString();
                string firstName = data[2].ToString();
                string lastName = data[3].ToString();
                string phoneNumber = data[4].ToString();
                string q5 = data[5].ToString();
                string q6 = data[6].ToString();
                string q7 = data[7].ToString();
                string q8 = data[8].ToString();
                string q9 = data[9].ToString();
                string q10 = data[10].ToString();
                string q11 = data[11].ToString();
                string q12 = data[12].ToString();
                string q13 = data[13].ToString();
                string q14 = data[14].ToString();
                string q15 = data[15].ToString();
                string q16 = data[16].ToString();
                string q17 = data[17].ToString();
                string q18 = data[18].ToString();
                string q19 = data[19].ToString();
                string q20 = data[20].ToString();
                string q21 = data[21].ToString();
                string q22 = data[22].ToString();
                string q23 = data[23].ToString();
                string q24 = data[24].ToString();
                string q25 = data[25].ToString();
                string q26 = data[26].ToString();
                string q27 = data[27].ToString();
                string q28 = data[28].ToString();
                string q29 = data[29].ToString();
                string q30 = data[30].ToString();
                string q31 = data[31].ToString();
                string q32 = data[32].ToString();
                string q33 = data[33].ToString();
                string q34 = data[34].ToString();
                string q35 = data[35].ToString();
                string q36 = data[36].ToString();
                string q37 = data[37].ToString();
                string q38 = data[38].ToString();
                string q39 = data[39].ToString();
                string q40 = data[40].ToString();
                string q41 = data[41].ToString();
                string q42 = data[42].ToString();
                string q43 = data[43].ToString();
                string q44 = data[44].ToString();
                string q45 = data[45].ToString();
                string q46 = data[46].ToString();
                string referralSource = data[47].ToString();
                string referralName = data[48].ToString();
                string RUGAPCEmailAddress = data[49].ToString();

                string counselor = "jdworktoworship@yahoo.com";

                if (RUGAPCEmailAddress != "")
                {
                    counselor = RUGAPCEmailAddress;

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

                        string errorMessage;

                        Select selectObject = new Select();

                        bool careerMarketabilityAssessmentExists;

                        careerMarketabilityAssessmentExists = Select.Career_Marketability_Assessment_Exists(emailAddress);

                        errorMessage = selectObject.getErrorMessage();

                        if (errorMessage != null)
                        {
                            lblError.Text = errorMessage;
                            lblError.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.GenericErrorMessage);

                        }//end if

                        else if (careerMarketabilityAssessmentExists == true)
                        {
                            MsgBox("Invalid. This assessment has already been submitted.");

                        }//end else if

                        else if (careerMarketabilityAssessmentExists == false)
                        {
                            string errorMessage2;

                            errorMessage2 = Insert.Insert_Career_Marketability_Assessment(emailAddress, dateCompleted2, _Q1, _Q2, _Q3, _Q4, _Q5, _Q6, _Q7, _Q8, _Q9, _Q10, _Q11, _Q12, _Q13, _Q14, _Q15, _Q16, _Q17, _Q18, _Q19, _Q20, score);

                            if (errorMessage2 != null)
                            {
                                lblError.Text = errorMessage2;
                                lblError.Visible = true;

                                ErrorMessage message = new ErrorMessage();

                                MsgBox(message.GenericErrorMessage);

                            }//end if

                            else
                            {
                                string AppPath = Request.PhysicalApplicationPath;
                                StreamReader sr = new StreamReader(AppPath + "SA/Email_Templates/NeedsAssessmentPackage.txt");

                                string errorMessage3;

                                string _dateCompleted2 = dateCompleted2.ToString();

                                string _score = score.ToString();

                                errorMessage3 = Email.Email_Needs_Assessment_Package(dateCompleted, firstName, lastName, emailAddress, phoneNumber, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23, q24, q25, q26, q27, q28, q29, q30, q31, q32, q33, q34, q35, q36, q37, q38, q39, q40, q41, q42, q43, q44, q45, q46, referralSource, referralName, RUGAPCEmailAddress, _dateCompleted2, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, _score, sr);

                                if (errorMessage3 != null)
                                {
                                    lblError.Text = errorMessage3;
                                    lblError.Visible = true;

                                    ErrorMessage message = new ErrorMessage();

                                    MsgBox(message.GenericErrorMessage);

                                }//end if

                                else
                                {
                                    DateTime _dateCompleted;

                                    DateTime.TryParse(dateCompleted, out _dateCompleted);

                                    string errorMessage4;

                                    errorMessage4 = Insert.Insert_Needs_Assessment_Package(_dateCompleted, firstName, lastName, emailAddress, phoneNumber, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23, q24, q25, q26, q27, q28, q29, q30, q31, q32, q33, q34, q35, q36, q37, q38, q39, q40, q41, q42, q43, q44, q45, q46, referralSource, referralName, RUGAPCEmailAddress, dateCompleted2, _Q1, _Q2, _Q3, _Q4, _Q5, _Q6, _Q7, _Q8, _Q9, _Q10, _Q11, _Q12, _Q13, _Q14, _Q15, _Q16, _Q17, _Q18, _Q19, _Q20, score);

                                    if (errorMessage4 != null)
                                    {
                                        lblError.Text = errorMessage4;
                                        lblError.Visible = true;

                                        ErrorMessage message = new ErrorMessage();

                                        MsgBox(message.GenericErrorMessage);

                                    }//end if

                                    else
                                    {
                                        MsgBox("Thank you very much for taking the time to share this information with us. We have now received both your Preliminary Needs and Career Marketability Assessments, and these have been emailed to Jim Davis, or your RUG APC, and we will get back with you as soon as we are able. May God richly bless you and your life path endeavors!");

                                        MultiView1.SetActiveView(View2);

                                    }//end else

                                }//end else

                            }//end else

                        }//end else if

                    }//end else

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