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
    public partial class _FOP_ProgressMenu : Page
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

            HttpCookie _authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket _ticket = FormsAuthentication.Decrypt(_authCookie.Value);

            string username = _ticket.Name;

            Select selectObject = new Select();

            string errorMessage;

            ArrayList record = new ArrayList();

            record = Select.Select_Progress_Menu_Record(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError.Text = errorMessage;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                string overview = record[0].ToString();
                DateTime overviewDate;

                if (DateTime.TryParse(overview, out overviewDate))
                {
                    overview = overviewDate.ToString("d");

                    lblDate1.Text = overview;
                    lblDate1.Visible = true;

                    lblStatus1.Text = "Complete";

                }//end if


                string introduction = record[1].ToString();
                DateTime introductionDate;

                if (DateTime.TryParse(introduction, out introductionDate))
                {
                    introduction = introductionDate.ToString("d");

                    lblDate2.Text = introduction;
                    lblDate2.Visible = true;

                    lblStatus2.Text = "Complete";

                }//end if


                string resourcesProvided = record[2].ToString();
                DateTime resourcesProvidedDate;

                if (DateTime.TryParse(resourcesProvided, out resourcesProvidedDate))
                {
                    resourcesProvided = resourcesProvidedDate.ToString("d");

                    lblDate3.Text = resourcesProvided;
                    lblDate3.Visible = true;

                    lblStatus3.Text = "Complete";

                }//end if


                string beforeYouBegin = record[3].ToString();
                DateTime beforeYouBeginDate;

                if (DateTime.TryParse(beforeYouBegin, out beforeYouBeginDate))
                {
                    beforeYouBegin = beforeYouBeginDate.ToString("d");

                    lblDate4.Text = beforeYouBegin;
                    lblDate4.Visible = true;

                    lblStatus4.Text = "Complete";

                }//end if


                string naturalTalents = record[4].ToString();
                DateTime naturalTalentsDate;

                if (DateTime.TryParse(naturalTalents, out naturalTalentsDate))
                {
                    naturalTalents = naturalTalentsDate.ToString("d");

                    lblDate5.Text = naturalTalents;
                    lblDate5.Visible = true;

                    lblStatus5.Text = "Complete";

                }//end if


                string perceptionResponse = record[5].ToString();
                DateTime perceptionResponseDate;

                if (DateTime.TryParse(perceptionResponse, out perceptionResponseDate))
                {
                    perceptionResponse = perceptionResponseDate.ToString("d");

                    lblDate6.Text = perceptionResponse;
                    lblDate6.Visible = true;

                    lblStatus6.Text = "Complete";

                }//end if


                string identifyingSpiritualGifts = record[6].ToString();
                DateTime identifyingSpiritualGiftsDate;

                if (DateTime.TryParse(identifyingSpiritualGifts, out identifyingSpiritualGiftsDate))
                {
                    identifyingSpiritualGifts = identifyingSpiritualGiftsDate.ToString("d");

                    lblDate7.Text = identifyingSpiritualGifts;
                    lblDate7.Visible = true;

                    lblStatus7.Text = "Complete";

                }//end if


                string focusAnalysisWorksheet = record[7].ToString();
                DateTime focusAnalysisWorksheetDate;

                if (DateTime.TryParse(focusAnalysisWorksheet, out focusAnalysisWorksheetDate))
                {
                    focusAnalysisWorksheet = focusAnalysisWorksheetDate.ToString("d");

                    lblDate8.Text = focusAnalysisWorksheet;
                    lblDate8.Visible = true;

                    lblStatus8.Text = "Complete";

                }//end if


                string focusDemonstrationWorksheet = record[8].ToString();
                DateTime focusDemonstrationWorksheetDate;

                if (DateTime.TryParse(focusDemonstrationWorksheet, out focusDemonstrationWorksheetDate))
                {
                    focusDemonstrationWorksheet = focusDemonstrationWorksheetDate.ToString("d");

                    lblDate9.Text = focusDemonstrationWorksheet;
                    lblDate9.Visible = true;

                    lblStatus9.Text = "Complete";

                }//end if


                string waysToEvaluateYourEffect = record[9].ToString();
                DateTime waysToEvaluateYourEffectDate;

                if (DateTime.TryParse(waysToEvaluateYourEffect, out waysToEvaluateYourEffectDate))
                {
                    waysToEvaluateYourEffect = waysToEvaluateYourEffectDate.ToString("d");

                    lblDate10.Text = waysToEvaluateYourEffect;
                    lblDate10.Visible = true;

                    lblStatus10.Text = "Complete";

                }//end if


                string focusSample1 = record[10].ToString();
                DateTime focusSample1Date;

                if (DateTime.TryParse(focusSample1, out focusSample1Date))
                {
                    focusSample1 = focusSample1Date.ToString("d");

                    lblDate11.Text = focusSample1;
                    lblDate11.Visible = true;

                    lblStatus11.Text = "Complete";

                }//end if


                string focusSample2 = record[11].ToString();
                DateTime focusSample2Date;

                if (DateTime.TryParse(focusSample2, out focusSample2Date))
                {
                    focusSample2 = focusSample2Date.ToString("d");

                    lblDate12.Text = focusSample2;
                    lblDate12.Visible = true;

                    lblStatus12.Text = "Complete";

                }//end if


                string focusExperience1 = record[12].ToString();
                DateTime focusExperience1Date;

                if (DateTime.TryParse(focusExperience1, out focusExperience1Date))
                {
                    focusExperience1 = focusExperience1Date.ToString("d");

                    lblDate13.Text = focusExperience1;
                    lblDate13.Visible = true;

                    lblStatus13.Text = "Complete";

                }//end if


                string focusExperience2 = record[13].ToString();
                DateTime focusExperience2Date;

                if (DateTime.TryParse(focusExperience2, out focusExperience2Date))
                {
                    focusExperience2 = focusExperience2Date.ToString("d");

                    lblDate14.Text = focusExperience2;
                    lblDate14.Visible = true;

                    lblStatus14.Text = "Complete";

                }//end if


                string focusExperience3 = record[14].ToString();
                DateTime focusExperience3Date;

                if (DateTime.TryParse(focusExperience3, out focusExperience3Date))
                {
                    focusExperience3 = focusExperience3Date.ToString("d");

                    lblDate15.Text = focusExperience3;
                    lblDate15.Visible = true;

                    lblStatus15.Text = "Complete";

                }//end if


                string focusExperience4 = record[15].ToString();
                DateTime focusExperience4Date;

                if (DateTime.TryParse(focusExperience4, out focusExperience4Date))
                {
                    focusExperience4 = focusExperience4Date.ToString("d");

                    lblDate16.Text = focusExperience4;
                    lblDate16.Visible = true;

                    lblStatus16.Text = "Complete";

                }//end if


                string focusExperience5 = record[16].ToString();
                DateTime focusExperience5Date;

                if (DateTime.TryParse(focusExperience5, out focusExperience5Date))
                {
                    focusExperience5 = focusExperience5Date.ToString("d");

                    lblDate17.Text = focusExperience5;
                    lblDate17.Visible = true;

                    lblStatus17.Text = "Complete";

                }//end if


                string focusExperience6 = record[17].ToString();
                DateTime focusExperience6Date;

                if (DateTime.TryParse(focusExperience6, out focusExperience6Date))
                {
                    focusExperience6 = focusExperience6Date.ToString("d");

                    lblDate18.Text = focusExperience6;
                    lblDate18.Visible = true;

                    lblStatus18.Text = "Complete";

                }//end if


                string focusExperience7 = record[18].ToString();
                DateTime focusExperience7Date;

                if (DateTime.TryParse(focusExperience7, out focusExperience7Date))
                {
                    focusExperience7 = focusExperience7Date.ToString("d");

                    lblDate19.Text = focusExperience7;
                    lblDate19.Visible = true;

                    lblStatus19.Text = "Complete";

                }//end if


                string focusExperience8 = record[19].ToString();
                DateTime focusExperience8Date;

                if (DateTime.TryParse(focusExperience8, out focusExperience8Date))
                {
                    focusExperience8 = focusExperience8Date.ToString("d");

                    lblDate20.Text = focusExperience8;
                    lblDate20.Visible = true;

                    lblStatus20.Text = "Complete";

                }//end if


                string personalManagementStyle = record[20].ToString();
                DateTime personalManagementStyleDate;

                if (DateTime.TryParse(personalManagementStyle, out personalManagementStyleDate))
                {
                    personalManagementStyle = personalManagementStyleDate.ToString("d");

                    lblDate21.Text = personalManagementStyle;
                    lblDate21.Visible = true;

                    lblStatus21.Text = "Complete";

                }//end if


                string fundamentalLifeMotivators = record[21].ToString();
                DateTime fundamentalLifeMotivatorsDate;

                if (DateTime.TryParse(fundamentalLifeMotivators, out fundamentalLifeMotivatorsDate))
                {
                    fundamentalLifeMotivators = fundamentalLifeMotivatorsDate.ToString("d");

                    lblDate22.Text = fundamentalLifeMotivators;
                    lblDate22.Visible = true;

                    lblStatus22.Text = "Complete";

                }//end if


                string educationTrainingInventory = record[22].ToString();
                DateTime educationTrainingInventoryDate;

                if (DateTime.TryParse(educationTrainingInventory, out educationTrainingInventoryDate))
                {
                    educationTrainingInventory = educationTrainingInventoryDate.ToString("d");

                    lblDate23.Text = educationTrainingInventory;
                    lblDate23.Visible = true;

                    lblStatus23.Text = "Complete";

                }//end if


                string practicalSkills = record[23].ToString();
                DateTime practicalSkillsDate;

                if (DateTime.TryParse(practicalSkills, out practicalSkillsDate))
                {
                    practicalSkills = practicalSkillsDate.ToString("d");

                    lblDate24.Text = practicalSkills;
                    lblDate24.Visible = true;

                    lblStatus24.Text = "Complete";

                }//end if


                string expressingYourPersonalGenius = record[24].ToString();
                DateTime expressingYourPersonalGeniusDate;

                if (DateTime.TryParse(expressingYourPersonalGenius, out expressingYourPersonalGeniusDate))
                {
                    expressingYourPersonalGenius = expressingYourPersonalGeniusDate.ToString("d");

                    lblDate25.Text = expressingYourPersonalGenius;
                    lblDate25.Visible = true;

                    lblStatus25.Text = "Complete";

                }//end if


                string creativityCycle = record[25].ToString();
                DateTime creativityCycleDate;

                if (DateTime.TryParse(creativityCycle, out creativityCycleDate))
                {
                    creativityCycle = creativityCycleDate.ToString("d");

                    lblDate26.Text = creativityCycle;
                    lblDate26.Visible = true;

                    lblStatus26.Text = "Complete";

                }//end if


                string perceptionResponseSummary = record[26].ToString();
                DateTime perceptionResponseSummaryDate;

                if (DateTime.TryParse(perceptionResponseSummary, out perceptionResponseSummaryDate))
                {
                    perceptionResponseSummary = perceptionResponseSummaryDate.ToString("d");

                    lblDate27.Text = perceptionResponseSummary;
                    lblDate27.Visible = true;

                    lblStatus27.Text = "Complete";

                }//end if


                string totalSpiritualGifts = record[27].ToString();
                DateTime totalSpiritualGiftsDate;

                if (DateTime.TryParse(totalSpiritualGifts, out totalSpiritualGiftsDate))
                {
                    totalSpiritualGifts = totalSpiritualGiftsDate.ToString("d");

                    lblDate28.Text = totalSpiritualGifts;
                    lblDate28.Visible = true;

                    lblStatus28.Text = "Complete";

                }//end if


                string focusConsolidationWorksheet = record[28].ToString();
                DateTime focusConsolidationWorksheetDate;

                if (DateTime.TryParse(focusConsolidationWorksheet, out focusConsolidationWorksheetDate))
                {
                    focusConsolidationWorksheet = focusConsolidationWorksheetDate.ToString("d");

                    lblDate29.Text = focusConsolidationWorksheet;
                    lblDate29.Visible = true;

                    lblStatus29.Text = "Complete";

                }//end if


                string congratulations = record[29].ToString();
                DateTime congratulationsDate;

                if (DateTime.TryParse(congratulations, out congratulationsDate))
                {
                    congratulations = congratulationsDate.ToString("d");

                    lblDate30.Text = congratulations;
                    lblDate30.Visible = true;

                    lblStatus30.Text = "Complete";

                }//end if


                string marketingDocumentsCreation = record[30].ToString();
                DateTime marketingDocumentsCreationDate;

                if (DateTime.TryParse(marketingDocumentsCreation, out marketingDocumentsCreationDate))
                {
                    marketingDocumentsCreation = marketingDocumentsCreationDate.ToString("d");

                    lblDate31.Text = marketingDocumentsCreation;
                    lblDate31.Visible = true;

                    lblStatus31.Text = "Complete";

                }//end if

            }//end else

            FindNext();

            EnforceSequential();

        }//end event

        public void FindNext()
        {
            string indicator = ">";

            string val1 = lblStatus1.Text;
            string val2 = lblStatus2.Text;
            string val3 = lblStatus3.Text;
            string val4 = lblStatus4.Text;
            string val5 = lblStatus5.Text;
            string val6 = lblStatus6.Text;
            string val7 = lblStatus7.Text;
            string val8 = lblStatus8.Text;
            string val9 = lblStatus9.Text;
            string val10 = lblStatus10.Text;
            string val11 = lblStatus11.Text;
            string val12 = lblStatus12.Text;
            string val13 = lblStatus13.Text;
            string val14 = lblStatus14.Text;
            string val15 = lblStatus15.Text;
            string val16 = lblStatus16.Text;
            string val17 = lblStatus17.Text;
            string val18 = lblStatus18.Text;
            string val19 = lblStatus19.Text;
            string val20 = lblStatus20.Text;
            string val21 = lblStatus21.Text;
            string val22 = lblStatus22.Text;
            string val23 = lblStatus23.Text;
            string val24 = lblStatus24.Text;
            string val25 = lblStatus25.Text;
            string val26 = lblStatus26.Text;
            string val27 = lblStatus27.Text;
            string val28 = lblStatus28.Text;
            string val29 = lblStatus29.Text;
            string val30 = lblStatus30.Text;
            string val31 = lblStatus31.Text;

            if (val1 == "Incomplete")
            {
                Label1.Text = indicator;
                Label1.Visible = true;
                
                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = indicator;
                Label2.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = indicator;
                Label3.Visible = true;
                
                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = indicator;
                Label4.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = indicator;
                Label5.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = indicator;
                Label6.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = indicator;
                Label7.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = indicator;
                Label8.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = indicator;
                Label9.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = indicator;
                Label10.Visible = true;
                            
                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = indicator;
                Label11.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = indicator;
                Label12.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = indicator;
                Label13.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = indicator;
                Label14.Visible = true;

                return;

            }//end if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = indicator;
                Label15.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = indicator;
                Label16.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = indicator;
                Label17.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = indicator;
                Label18.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = indicator;
                Label19.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = indicator;
                Label20.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = indicator;
                Label21.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = indicator;
                Label22.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = indicator;
                Label23.Visible = true;

                return;

            }//end else if;

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = indicator;
                Label24.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Complete") && (val25 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = "";
                Label24.Visible = false;
                Label25.Text = indicator;
                Label25.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Complete") && (val25 == "Complete") && (val26 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = "";
                Label24.Visible = false;
                Label25.Text = "";
                Label25.Visible = false;
                Label26.Text = indicator;
                Label26.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Complete") && (val25 == "Complete") && (val26 == "Complete") && (val27 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = "";
                Label24.Visible = false;
                Label25.Text = "";
                Label25.Visible = false;
                Label26.Text = "";
                Label26.Visible = false;
                Label27.Text = indicator;
                Label27.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Complete") && (val25 == "Complete") && (val26 == "Complete") && (val27 == "Complete") && (val28 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = "";
                Label24.Visible = false;
                Label25.Text = "";
                Label25.Visible = false;
                Label26.Text = "";
                Label26.Visible = false;
                Label27.Text = "";
                Label27.Visible = false;
                Label28.Text = indicator;
                Label28.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Complete") && (val25 == "Complete") && (val26 == "Complete") && (val27 == "Complete") && (val28 == "Complete") && (val29 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = "";
                Label24.Visible = false;
                Label25.Text = "";
                Label25.Visible = false;
                Label26.Text = "";
                Label26.Visible = false;
                Label27.Text = "";
                Label27.Visible = false;
                Label28.Text = "";
                Label28.Visible = false;
                Label29.Text = indicator;
                Label29.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Complete") && (val25 == "Complete") && (val26 == "Complete") && (val27 == "Complete") && (val28 == "Complete") && (val29 == "Complete") && (val30 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = "";
                Label24.Visible = false;
                Label25.Text = "";
                Label25.Visible = false;
                Label26.Text = "";
                Label26.Visible = false;
                Label27.Text = "";
                Label27.Visible = false;
                Label28.Text = "";
                Label28.Visible = false;
                Label29.Text = "";
                Label29.Visible = false;
                Label30.Text = indicator;
                Label30.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Complete") && (val25 == "Complete") && (val26 == "Complete") && (val27 == "Complete") && (val28 == "Complete") && (val29 == "Complete") && (val30 == "Complete") && (val31 == "Incomplete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = "";
                Label24.Visible = false;
                Label25.Text = "";
                Label25.Visible = false;
                Label26.Text = "";
                Label26.Visible = false;
                Label27.Text = "";
                Label27.Visible = false;
                Label28.Text = "";
                Label28.Visible = false;
                Label29.Text = "";
                Label29.Visible = false;
                Label30.Text = "";
                Label30.Visible = false;
                Label31.Text = indicator;
                Label31.Visible = true;

                return;

            }//end else if

            else if ((val1 == "Complete") && (val2 == "Complete") && (val3 == "Complete") && (val4 == "Complete") && (val5 == "Complete") && (val6 == "Complete") && (val7 == "Complete") && (val8 == "Complete") && (val9 == "Complete") && (val10 == "Complete") && (val11 == "Complete") && (val12 == "Complete") && (val13 == "Complete") && (val14 == "Complete") && (val15 == "Complete") && (val16 == "Complete") && (val17 == "Complete") && (val18 == "Complete") && (val19 == "Complete") && (val20 == "Complete") && (val21 == "Complete") && (val22 == "Complete") && (val23 == "Complete") && (val24 == "Complete") && (val25 == "Complete") && (val26 == "Complete") && (val27 == "Complete") && (val28 == "Complete") && (val29 == "Complete") && (val30 == "Complete") && (val31 == "Complete"))
            {
                Label1.Text = "";
                Label1.Visible = false;
                Label2.Text = "";
                Label2.Visible = false;
                Label3.Text = "";
                Label3.Visible = false;
                Label4.Text = "";
                Label4.Visible = false;
                Label5.Text = "";
                Label5.Visible = false;
                Label6.Text = "";
                Label6.Visible = false;
                Label7.Text = "";
                Label7.Visible = false;
                Label8.Text = "";
                Label8.Visible = false;
                Label9.Text = "";
                Label9.Visible = false;
                Label10.Text = "";
                Label10.Visible = false;
                Label11.Text = "";
                Label11.Visible = false;
                Label12.Text = "";
                Label12.Visible = false;
                Label13.Text = "";
                Label13.Visible = false;
                Label14.Text = "";
                Label14.Visible = false;
                Label15.Text = "";
                Label15.Visible = false;
                Label16.Text = "";
                Label16.Visible = false;
                Label17.Text = "";
                Label17.Visible = false;
                Label18.Text = "";
                Label18.Visible = false;
                Label19.Text = "";
                Label19.Visible = false;
                Label20.Text = "";
                Label20.Visible = false;
                Label21.Text = "";
                Label21.Visible = false;
                Label22.Text = "";
                Label22.Visible = false;
                Label23.Text = "";
                Label23.Visible = false;
                Label24.Text = "";
                Label24.Visible = false;
                Label25.Text = "";
                Label25.Visible = false;
                Label26.Text = "";
                Label26.Visible = false;
                Label27.Text = "";
                Label27.Visible = false;
                Label28.Text = "";
                Label28.Visible = false;
                Label29.Text = "";
                Label29.Visible = false;
                Label30.Text = "";
                Label30.Visible = false;
                Label31.Text = "";
                Label31.Visible = false;

                return;

            }//end else if

        }//end method

        public void EnforceSequential()
        {
            string indicator = ">";

            if (Label1.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = false;
                HyperLink3.Enabled = false;
                HyperLink4.Enabled = false;
                HyperLink5.Enabled = false;
                HyperLink6.Enabled = false;
                HyperLink7.Enabled = false;
                HyperLink8.Enabled = false;
                HyperLink9.Enabled = false;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end if

            else if (Label2.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = false;
                HyperLink4.Enabled = false;
                HyperLink5.Enabled = false;
                HyperLink6.Enabled = false;
                HyperLink7.Enabled = false;
                HyperLink8.Enabled = false;
                HyperLink9.Enabled = false;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label3.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = false;
                HyperLink5.Enabled = false;
                HyperLink6.Enabled = false;
                HyperLink7.Enabled = false;
                HyperLink8.Enabled = false;
                HyperLink9.Enabled = false;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label4.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = false;
                HyperLink6.Enabled = false;
                HyperLink7.Enabled = false;
                HyperLink8.Enabled = false;
                HyperLink9.Enabled = false;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label5.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = false;
                HyperLink7.Enabled = false;
                HyperLink8.Enabled = false;
                HyperLink9.Enabled = false;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label6.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = false;
                HyperLink8.Enabled = false;
                HyperLink9.Enabled = false;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label7.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = false;
                HyperLink9.Enabled = false;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label8.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = false;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label9.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = false;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label10.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = false;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label11.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = false;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label12.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = false;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label13.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = false;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label14.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = false;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label15.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = false;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label16.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = false;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label17.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = false;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label18.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = false;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label19.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = false;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label20.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = false;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label21.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = false;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label22.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = false;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label23.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = false;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label24.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = true;
                HyperLink25.Enabled = false;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label25.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = true;
                HyperLink25.Enabled = true;
                HyperLink26.Enabled = false;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label26.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = true;
                HyperLink25.Enabled = true;
                HyperLink26.Enabled = true;
                HyperLink27.Enabled = false;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label27.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = true;
                HyperLink25.Enabled = true;
                HyperLink26.Enabled = true;
                HyperLink27.Enabled = true;
                HyperLink28.Enabled = false;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label28.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = true;
                HyperLink25.Enabled = true;
                HyperLink26.Enabled = true;
                HyperLink27.Enabled = true;
                HyperLink28.Enabled = true;
                HyperLink29.Enabled = false;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label29.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = true;
                HyperLink25.Enabled = true;
                HyperLink26.Enabled = true;
                HyperLink27.Enabled = true;
                HyperLink28.Enabled = true;
                HyperLink29.Enabled = true;
                HyperLink30.Enabled = false;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label30.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = true;
                HyperLink25.Enabled = true;
                HyperLink26.Enabled = true;
                HyperLink27.Enabled = true;
                HyperLink28.Enabled = true;
                HyperLink29.Enabled = true;
                HyperLink30.Enabled = true;
                HyperLink31.Enabled = false;

                return;

            }//end else if

            else if (Label31.Text == indicator)
            {
                HyperLink1.Enabled = true;
                HyperLink2.Enabled = true;
                HyperLink3.Enabled = true;
                HyperLink4.Enabled = true;
                HyperLink5.Enabled = true;
                HyperLink6.Enabled = true;
                HyperLink7.Enabled = true;
                HyperLink8.Enabled = true;
                HyperLink9.Enabled = true;
                HyperLink10.Enabled = true;
                HyperLink11.Enabled = true;
                HyperLink12.Enabled = true;
                HyperLink13.Enabled = true;
                HyperLink14.Enabled = true;
                HyperLink15.Enabled = true;
                HyperLink16.Enabled = true;
                HyperLink17.Enabled = true;
                HyperLink18.Enabled = true;
                HyperLink19.Enabled = true;
                HyperLink20.Enabled = true;
                HyperLink21.Enabled = true;
                HyperLink22.Enabled = true;
                HyperLink23.Enabled = true;
                HyperLink24.Enabled = true;
                HyperLink25.Enabled = true;
                HyperLink26.Enabled = true;
                HyperLink27.Enabled = true;
                HyperLink28.Enabled = true;
                HyperLink29.Enabled = true;
                HyperLink30.Enabled = true;
                HyperLink31.Enabled = true;

                return;

            }//end else if

        }//end method

        private void MsgBox(string sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            Response.Write(msg);

        }//end method

    }//end class

}//end namespace