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
    public partial class _PersonalManagementStyle : Page
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

            HttpCookie _authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket _ticket = FormsAuthentication.Decrypt(_authCookie.Value);

            string username = _ticket.Name;

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Personal_Management_Style(username);

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
                if (recordExists == true)
                {
                    string errorMessage2;

                    ArrayList record = new ArrayList();

                    Select selectObject2 = new Select();

                    record = Select.Select_Personal_Management_Style_Record(username);

                    errorMessage2 = selectObject2.getErrorMessage();

                    if (errorMessage2 != null)
                    {
                        lblError.Text = errorMessage2;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        if (Page.IsPostBack == false)
                        {
                            string nothing = "";

                            if ((record[0] != nothing) && (record[1] != nothing) && (record[2] != nothing) && (record[3] != nothing) && (record[4] != nothing) && (record[5] != nothing) && (record[6] != nothing) && (record[7] != nothing) && (record[8] != nothing) && (record[9] != nothing) && (record[10] != nothing) && (record[11] != nothing) && (record[12] != nothing) && (record[13] != nothing) && (record[14] != nothing) && (record[15] != nothing) && (record[16] != nothing) && (record[17] != nothing) && (record[18] != nothing) && (record[19] != nothing) && (record[20] != nothing) && (record[21] != nothing) && (record[22] != nothing) && (record[23] != nothing) && (record[24] != nothing) && (record[25] != nothing) && (record[26] != nothing) && (record[27] != nothing) && (record[28] != nothing) && (record[29] != nothing) && (record[30] != nothing) && (record[31] != nothing) && (record[32] != nothing) && (record[33] != nothing) && (record[34] != nothing) && (record[35] != nothing) && (record[36] != nothing) && (record[37] != nothing))
                            {
                                btnSubmit.Visible = false;
                                Button1.Visible = true;

                            }//end if

                            if ((record[38] != nothing) && (record[39] != nothing) && (record[40] != nothing) && (record[41] != nothing) && (record[42] != nothing) && (record[43] != nothing) && (record[44] != nothing) && (record[45] != nothing) && (record[46] != nothing) && (record[47] != nothing) && (record[48] != nothing) && (record[49] != nothing))
                            {
                                btnSubmit2.Visible = false;
                                btnContinue2.Visible = true;

                            }//end if

                        }//end if

                        lblSection1Score.Text = record[38].ToString();
                        Label1.Text = record[39].ToString();

                        if (record[40].ToString() != "")
                            TextBox1.InnerText = record[40].ToString();

                        lblSection2Score.Text = record[41].ToString();
                        Label2.Text = record[42].ToString();

                        if (record[43].ToString() != "")
                            TextBox2.InnerText = record[43].ToString();

                        lblSection3Score.Text = record[44].ToString();
                        Label3.Text = record[45].ToString();

                        if (record[46].ToString() != "")
                            TextBox3.InnerText = record[46].ToString();

                        lblSection4Score.Text = record[47].ToString();
                        Label4.Text = record[48].ToString();

                        if (record[49].ToString() != "")
                            TextBox4.InnerText = record[49].ToString();

                        for (int i = 0; i < 38; i++)
                        {
                            string value = (string)record[i];

                            if (value == QuestionSet1.Items[0].Text)
                                QuestionSet1.Items[0].Selected = true;

                            if (value == QuestionSet1.Items[1].Text)
                                QuestionSet1.Items[1].Selected = true;

                            if (value == QuestionSet2.Items[0].Text)
                                QuestionSet2.Items[0].Selected = true;

                            if (value == QuestionSet2.Items[1].Text)
                                QuestionSet2.Items[1].Selected = true;

                            if (value == QuestionSet3.Items[0].Text)
                                QuestionSet3.Items[0].Selected = true;

                            if (value == QuestionSet3.Items[1].Text)
                                QuestionSet3.Items[1].Selected = true;

                            if (value == QuestionSet4.Items[0].Text)
                                QuestionSet4.Items[0].Selected = true;

                            if (value == QuestionSet4.Items[1].Text)
                                QuestionSet4.Items[1].Selected = true;

                            if (value == QuestionSet5.Items[0].Text)
                                QuestionSet5.Items[0].Selected = true;

                            if (value == QuestionSet5.Items[1].Text)
                                QuestionSet5.Items[1].Selected = true;

                            if (value == QuestionSet6.Items[0].Text)
                                QuestionSet6.Items[0].Selected = true;

                            if (value == QuestionSet6.Items[1].Text)
                                QuestionSet6.Items[1].Selected = true;

                            if (value == QuestionSet7.Items[0].Text)
                                QuestionSet7.Items[0].Selected = true;

                            if (value == QuestionSet7.Items[1].Text)
                                QuestionSet7.Items[1].Selected = true;

                            if (value == QuestionSet8.Items[0].Text)
                                QuestionSet8.Items[0].Selected = true;

                            if (value == QuestionSet8.Items[1].Text)
                                QuestionSet8.Items[1].Selected = true;

                            if (value == QuestionSet9.Items[0].Text)
                                QuestionSet9.Items[0].Selected = true;

                            if (value == QuestionSet9.Items[1].Text)
                                QuestionSet9.Items[1].Selected = true;

                            if (value == QuestionSet10.Items[0].Text)
                                QuestionSet10.Items[0].Selected = true;

                            if (value == QuestionSet10.Items[1].Text)
                                QuestionSet10.Items[1].Selected = true;

                            if (value == QuestionSet11.Items[0].Text)
                                QuestionSet11.Items[0].Selected = true;

                            if (value == QuestionSet11.Items[1].Text)
                                QuestionSet11.Items[1].Selected = true;

                            if (value == QuestionSet12.Items[0].Text)
                                QuestionSet12.Items[0].Selected = true;

                            if (value == QuestionSet12.Items[1].Text)
                                QuestionSet12.Items[1].Selected = true;

                            if (value == QuestionSet13.Items[0].Text)
                                QuestionSet13.Items[0].Selected = true;

                            if (value == QuestionSet13.Items[1].Text)
                                QuestionSet13.Items[1].Selected = true;

                            if (value == QuestionSet14.Items[0].Text)
                                QuestionSet14.Items[0].Selected = true;

                            if (value == QuestionSet14.Items[1].Text)
                                QuestionSet14.Items[1].Selected = true;

                            if (value == QuestionSet15.Items[0].Text)
                                QuestionSet15.Items[0].Selected = true;

                            if (value == QuestionSet15.Items[1].Text)
                                QuestionSet15.Items[1].Selected = true;

                            if (value == QuestionSet16.Items[0].Text)
                                QuestionSet16.Items[0].Selected = true;

                            if (value == QuestionSet16.Items[1].Text)
                                QuestionSet16.Items[1].Selected = true;

                            if (value == QuestionSet17.Items[0].Text)
                                QuestionSet17.Items[0].Selected = true;

                            if (value == QuestionSet17.Items[1].Text)
                                QuestionSet17.Items[1].Selected = true;

                            if (value == QuestionSet18.Items[0].Text)
                                QuestionSet18.Items[0].Selected = true;

                            if (value == QuestionSet18.Items[1].Text)
                                QuestionSet18.Items[1].Selected = true;

                            if (value == QuestionSet19.Items[0].Text)
                                QuestionSet19.Items[0].Selected = true;

                            if (value == QuestionSet19.Items[1].Text)
                                QuestionSet19.Items[1].Selected = true;

                            if (value == QuestionSet20.Items[0].Text)
                                QuestionSet20.Items[0].Selected = true;

                            if (value == QuestionSet20.Items[1].Text)
                                QuestionSet20.Items[1].Selected = true;

                            if (value == QuestionSet21.Items[0].Text)
                                QuestionSet21.Items[0].Selected = true;

                            if (value == QuestionSet21.Items[1].Text)
                                QuestionSet21.Items[1].Selected = true;

                            if (value == QuestionSet22.Items[0].Text)
                                QuestionSet22.Items[0].Selected = true;

                            if (value == QuestionSet22.Items[1].Text)
                                QuestionSet22.Items[1].Selected = true;

                            if (value == QuestionSet23.Items[0].Text)
                                QuestionSet23.Items[0].Selected = true;

                            if (value == QuestionSet23.Items[1].Text)
                                QuestionSet23.Items[1].Selected = true;

                            if (value == QuestionSet24.Items[0].Text)
                                QuestionSet24.Items[0].Selected = true;

                            if (value == QuestionSet24.Items[1].Text)
                                QuestionSet24.Items[1].Selected = true;

                            if (value == QuestionSet25.Items[0].Text)
                                QuestionSet25.Items[0].Selected = true;

                            if (value == QuestionSet25.Items[1].Text)
                                QuestionSet25.Items[1].Selected = true;

                            if (value == QuestionSet26.Items[0].Text)
                                QuestionSet26.Items[0].Selected = true;

                            if (value == QuestionSet26.Items[1].Text)
                                QuestionSet26.Items[1].Selected = true;

                            if (value == QuestionSet27.Items[0].Text)
                                QuestionSet27.Items[0].Selected = true;

                            if (value == QuestionSet27.Items[1].Text)
                                QuestionSet27.Items[1].Selected = true;

                            if (value == QuestionSet28.Items[0].Text)
                                QuestionSet28.Items[0].Selected = true;

                            if (value == QuestionSet28.Items[1].Text)
                                QuestionSet28.Items[1].Selected = true;

                            if (value == QuestionSet29.Items[0].Text)
                                QuestionSet29.Items[0].Selected = true;

                            if (value == QuestionSet29.Items[1].Text)
                                QuestionSet29.Items[1].Selected = true;

                            if (value == QuestionSet30.Items[0].Text)
                                QuestionSet30.Items[0].Selected = true;

                            if (value == QuestionSet30.Items[1].Text)
                                QuestionSet30.Items[1].Selected = true;

                            if (value == QuestionSet31.Items[0].Text)
                                QuestionSet31.Items[0].Selected = true;

                            if (value == QuestionSet31.Items[1].Text)
                                QuestionSet31.Items[1].Selected = true;

                            if (value == QuestionSet32.Items[0].Text)
                                QuestionSet32.Items[0].Selected = true;

                            if (value == QuestionSet32.Items[1].Text)
                                QuestionSet32.Items[1].Selected = true;

                            if (value == QuestionSet33.Items[0].Text)
                                QuestionSet33.Items[0].Selected = true;

                            if (value == QuestionSet33.Items[1].Text)
                                QuestionSet33.Items[1].Selected = true;

                            if (value == QuestionSet34.Items[0].Text)
                                QuestionSet34.Items[0].Selected = true;

                            if (value == QuestionSet34.Items[1].Text)
                                QuestionSet34.Items[1].Selected = true;

                            if (value == QuestionSet35.Items[0].Text)
                                QuestionSet35.Items[0].Selected = true;

                            if (value == QuestionSet35.Items[1].Text)
                                QuestionSet35.Items[1].Selected = true;

                            if (value == QuestionSet36.Items[0].Text)
                                QuestionSet36.Items[0].Selected = true;

                            if (value == QuestionSet36.Items[1].Text)
                                QuestionSet36.Items[1].Selected = true;

                            if (value == QuestionSet37.Items[0].Text)
                                QuestionSet37.Items[0].Selected = true;

                            if (value == QuestionSet37.Items[1].Text)
                                QuestionSet37.Items[1].Selected = true;

                            if (value == QuestionSet38.Items[0].Text)
                                QuestionSet38.Items[0].Selected = true;

                            if (value == QuestionSet38.Items[1].Text)
                                QuestionSet38.Items[1].Selected = true;

                        }//end for

                    }//end else

                }//end if

            }//end else

        }//end event

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            #region DECLARE ARRAYS TO SCORES

            ArrayList section1 = new ArrayList();
            ArrayList section2 = new ArrayList();
            ArrayList section3 = new ArrayList();
            ArrayList section4 = new ArrayList();

            #endregion

            #region DECLARE VARIABLES TO HOLD POSSIBLE SCORES

            string extrovert = "Extrovert";
            string introvert = "Introvert";
            string sensing = "Sensing";
            string intuitive = "Intuitive";
            string thinking = "Thinking";
            string feeling = "Feeling";
            string judging = "Judging";
            string percieving = "Percieving";

            #endregion

            #region DECLARE STRING VARIABLES

            string Q1 = "";
            string Q2 = "";
            string Q3 = "";
            string Q4 = "";
            string Q5 = "";
            string Q6 = "";
            string Q7 = "";
            string Q8 = "";
            string Q9 = "";
            string Q10 = "";
            string Q11 = "";
            string Q12 = "";
            string Q13 = "";
            string Q14 = "";
            string Q15 = "";
            string Q16 = "";
            string Q17 = "";
            string Q18 = "";
            string Q19 = "";
            string Q20 = "";
            string Q21 = "";
            string Q22 = "";
            string Q23 = "";
            string Q24 = "";
            string Q25 = "";
            string Q26 = "";
            string Q27 = "";
            string Q28 = "";
            string Q29 = "";
            string Q30 = "";
            string Q31 = "";
            string Q32 = "";
            string Q33 = "";
            string Q34 = "";
            string Q35 = "";
            string Q36 = "";
            string Q37 = "";
            string Q38 = "";

            #endregion

            #region ADD EACH PREFERENCE SCORE TO CORRECT ARRAY BASED ON SCORE

            #region SECTION #1

            if (QuestionSet1.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q1 = QuestionSet1.SelectedValue;

            }//end if
            else if (QuestionSet1.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q1 = QuestionSet1.SelectedValue;

            }//end else if


            if (QuestionSet2.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q2 = QuestionSet2.SelectedValue;

            }//end if
            else if (QuestionSet2.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q2 = QuestionSet2.SelectedValue;

            }//end else if


            if (QuestionSet3.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q3 = QuestionSet3.SelectedValue;

            }//end if
            else if (QuestionSet3.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q3 = QuestionSet3.SelectedValue;

            }//end else if


            if (QuestionSet4.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q4 = QuestionSet4.SelectedValue;

            }//end if
            else if (QuestionSet4.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q4 = QuestionSet4.SelectedValue;

            }//end else if


            if (QuestionSet5.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q5 = QuestionSet5.SelectedValue;

            }//end if
            else if (QuestionSet5.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q5 = QuestionSet5.SelectedValue;

            }//end else if


            if (QuestionSet6.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q6 = QuestionSet6.SelectedValue;

            }//end if
            else if (QuestionSet6.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q6 = QuestionSet6.SelectedValue;

            }//end else if


            if (QuestionSet7.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q7 = QuestionSet7.SelectedValue;

            }//end if
            else if (QuestionSet7.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q7 = QuestionSet7.SelectedValue;

            }//end else if


            if (QuestionSet8.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q8 = QuestionSet8.SelectedValue;

            }//end if
            else if (QuestionSet8.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q8 = QuestionSet8.SelectedValue;

            }//end else if


            if (QuestionSet9.SelectedIndex == 0)
            {
                section1.Add(extrovert);
                Q9 = QuestionSet9.SelectedValue;

            }//end if
            else if (QuestionSet9.SelectedIndex == 1)
            {
                section1.Add(introvert);
                Q9 = QuestionSet9.SelectedValue;

            }//end else if

            #endregion

            #region SECTION #2

            if (QuestionSet10.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q10 = QuestionSet10.SelectedValue;

            }//end if
            else if (QuestionSet10.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q10 = QuestionSet10.SelectedValue;

            }//end else if


            if (QuestionSet11.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q11 = QuestionSet11.SelectedValue;

            }//end if
            else if (QuestionSet11.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q11 = QuestionSet11.SelectedValue;

            }//end else if


            if (QuestionSet12.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q12 = QuestionSet12.SelectedValue;

            }//end if
            else if (QuestionSet12.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q12 = QuestionSet12.SelectedValue;

            }//end else if


            if (QuestionSet13.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q13 = QuestionSet13.SelectedValue;

            }//end if
            else if (QuestionSet13.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q13 = QuestionSet13.SelectedValue;

            }//end else if


            if (QuestionSet14.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q14 = QuestionSet14.SelectedValue;

            }//end if
            else if (QuestionSet14.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q14 = QuestionSet14.SelectedValue;

            }//end else if


            if (QuestionSet15.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q15 = QuestionSet15.SelectedValue;

            }//end if
            else if (QuestionSet15.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q15 = QuestionSet15.SelectedValue;

            }//end else if


            if (QuestionSet16.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q16 = QuestionSet16.SelectedValue;

            }//end if
            else if (QuestionSet16.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q16 = QuestionSet16.SelectedValue;

            }//end else if


            if (QuestionSet17.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q17 = QuestionSet17.SelectedValue;

            }//end if
            else if (QuestionSet17.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q17 = QuestionSet17.SelectedValue;

            }//end else if


            if (QuestionSet18.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q18 = QuestionSet18.SelectedValue;

            }//end if
            else if (QuestionSet18.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q18 = QuestionSet18.SelectedValue;

            }//end else if


            if (QuestionSet19.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q19 = QuestionSet19.SelectedValue;

            }//end if
            else if (QuestionSet19.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q19 = QuestionSet19.SelectedValue;

            }//end else if


            if (QuestionSet20.SelectedIndex == 0)
            {
                section2.Add(sensing);
                Q20 = QuestionSet20.SelectedValue;

            }//end if
            else if (QuestionSet20.SelectedIndex == 1)
            {
                section2.Add(intuitive);
                Q20 = QuestionSet20.SelectedValue;

            }//end else if

            #endregion

            #region SECTION #3

            if (QuestionSet21.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q21 = QuestionSet21.SelectedValue;

            }//end if
            else if (QuestionSet21.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q21 = QuestionSet21.SelectedValue;

            }//end else if


            if (QuestionSet22.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q22 = QuestionSet22.SelectedValue;

            }//end if
            else if (QuestionSet22.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q22 = QuestionSet22.SelectedValue;

            }//end else if


            if (QuestionSet23.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q23 = QuestionSet23.SelectedValue;

            }//end if
            else if (QuestionSet23.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q23 = QuestionSet23.SelectedValue;

            }//end else if


            if (QuestionSet24.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q24 = QuestionSet24.SelectedValue;

            }//end if
            else if (QuestionSet24.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q24 = QuestionSet24.SelectedValue;

            }//end else if


            if (QuestionSet25.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q25 = QuestionSet25.SelectedValue;

            }//end if
            else if (QuestionSet25.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q25 = QuestionSet25.SelectedValue;

            }//end else if


            if (QuestionSet26.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q26 = QuestionSet26.SelectedValue;

            }//end if
            else if (QuestionSet26.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q26 = QuestionSet26.SelectedValue;

            }//end else if


            if (QuestionSet27.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q27 = QuestionSet27.SelectedValue;

            }//end if
            else if (QuestionSet27.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q27 = QuestionSet27.SelectedValue;

            }//end else if


            if (QuestionSet28.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q28 = QuestionSet28.SelectedValue;

            }//end if
            else if (QuestionSet28.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q28 = QuestionSet28.SelectedValue;

            }//end else if


            if (QuestionSet29.SelectedIndex == 0)
            {
                section3.Add(thinking);
                Q29 = QuestionSet29.SelectedValue;

            }//end if
            else if (QuestionSet29.SelectedIndex == 1)
            {
                section3.Add(feeling);
                Q29 = QuestionSet29.SelectedValue;

            }//end else if

            #endregion

            #region SECTION #4

            if (QuestionSet30.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q30 = QuestionSet30.SelectedValue;

            }//end if
            else if (QuestionSet30.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q30 = QuestionSet30.SelectedValue;

            }//end else if


            if (QuestionSet31.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q31 = QuestionSet31.SelectedValue;

            }//end if
            else if (QuestionSet31.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q31 = QuestionSet31.SelectedValue;

            }//end else if


            if (QuestionSet32.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q32 = QuestionSet32.SelectedValue;

            }//end if
            else if (QuestionSet32.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q32 = QuestionSet32.SelectedValue;

            }//end else if


            if (QuestionSet33.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q33 = QuestionSet33.SelectedValue;

            }//end if
            else if (QuestionSet33.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q33 = QuestionSet33.SelectedValue;

            }//end else if


            if (QuestionSet34.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q34 = QuestionSet34.SelectedValue;

            }//end if
            else if (QuestionSet34.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q34 = QuestionSet34.SelectedValue;

            }//end else if


            if (QuestionSet35.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q35 = QuestionSet35.SelectedValue;

            }//end if
            else if (QuestionSet35.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q35 = QuestionSet35.SelectedValue;

            }//end else if


            if (QuestionSet36.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q36 = QuestionSet36.SelectedValue;

            }//end if
            else if (QuestionSet36.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q36 = QuestionSet36.SelectedValue;

            }//end else if


            if (QuestionSet37.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q37 = QuestionSet37.SelectedValue;

            }//end if
            else if (QuestionSet37.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q37 = QuestionSet37.SelectedValue;

            }//end else if


            if (QuestionSet38.SelectedIndex == 0)
            {
                section4.Add(judging);
                Q38 = QuestionSet38.SelectedValue;

            }//end if
            else if (QuestionSet38.SelectedIndex == 1)
            {
                section4.Add(percieving);
                Q38 = QuestionSet38.SelectedValue;

            }//end else if

            #endregion

            #endregion

            #region SCORE ASSESSMENT

            #region DECLARE COUNTERS FOR SCORING ASSESSMENT

            int extrovertCount = 0;
            int introvertCount = 0;
            int sensingCount = 0;
            int intuitiveCount = 0;
            int thinkingCount = 0;
            int feelingCount = 0;
            int judgingCount = 0;
            int percievingCount = 0;

            #endregion

            #region TRANSFER VALUES IN ARRAYS TO COUNTERS

            //SECTION #1

            for (int index = 0; index < section1.Count ; index++)
            {
                if (section1[index] == extrovert)
                {
                    extrovertCount++;

                }//end if

                else if (section1[index] == introvert)
                {
                    introvertCount++;

                }//end else if

            }//end for loop

            
            //SECTION #2

            for (int index = 0; index < section2.Count; index++)
            {
                if (section2[index] == sensing)
                {
                    sensingCount++;

                }//end if

                else if (section2[index] == intuitive)
                {
                    intuitiveCount++;

                }//end else if

            }//end for loop


            //SECTION #3

            for (int index = 0; index < section3.Count; index++)
            {
                if (section3[index] == thinking)
                {
                    thinkingCount++;

                }//end if

                else if (section3[index] == feeling)
                {
                    feelingCount++;

                }//end else if

            }//end for loop


            //SECTION #4

            for (int index = 0; index < section4.Count; index++)
            {
                if (section4[index] == judging)
                {
                    judgingCount++;

                }//end if

                else if (section4[index] == percieving)
                {
                    percievingCount++;

                }//end else if

            }//end for loop

            #endregion

            #region TRANSFER VALUES IN COUNTERS TO SECTION SCORES

            //DECLARE VARIABLES FOR ASSESSMENT SCORES
            string section1score = "UNSCORED";
            string section2score = "UNSCORED";
            string section3score = "UNSCORED";
            string section4score = "UNSCORED";

            //SCORE SECTION #1

            if (extrovertCount > introvertCount)
            {
                section1score = extrovert;

            }//end if

            else if (extrovertCount < introvertCount)
            {
                section1score = introvert;

            }//end else if


            //SCORE SECTION #2

            if (sensingCount > intuitiveCount)
            {
                section2score = sensing;

            }//end if

            else if (sensingCount < intuitiveCount)
            {
                section2score = intuitive;

            }//end else if


            //SCORE SECTION #3

            if (thinkingCount > feelingCount)
            {
                section3score = thinking;

            }//end if

            else if (thinkingCount < feelingCount)
            {
                section3score = feeling;

            }//end else if


            //SCORE SECTION #4

            if (judgingCount > percievingCount)
            {
                section4score = judging;

            }//end if

            else if (judgingCount < percievingCount)
            {
                section4score = percieving;

            }//end else if

            #endregion

            #endregion

            #region SET LABELS

            if (section1score == extrovert)
            {
                Label1.Text = "This personality subtype's focus is most comfortably on the outer world of people and things. Their regular sociable interactions with other people and the verbal exchange of information actually enhances these subtypes’ energy. These subtypes are known for actively doing things, building relationships with others, and interacting with the world around themselves, as a predominant part of their life.";
                lblSection1Score.Text = "Outwardly social";

            }//end if

            if (section1score == introvert)
            {
                Label1.Text = "This personality subtype's focus is most comfortably on the inner world of their ideas and impressions. These subtypes are very territorial, desiring private space in their minds and environments. These subtypes are known for being able to concentrate and pursue their tasks alone or in small stable groups, with adequate time to reflect before acting.";
                lblSection1Score.Text = "Inwardly reflective";

            }//end if

            if (section2score == sensing)
            {
                Label2.Text = "This personality subtype gathers information in the present through concrete evidence, hard facts, and information that they have gained through their senses. For these subtypes, evidence needs to be seen, heard, touched, et cetera. These subtypes are known for a realistic, practical, fact-based, and detail-oriented style.";
                lblSection2Score.Text = "Sensory-grounded realism";

            }//end if

            if (section2score == intuitive)
            {
                Label2.Text = "This personality subtype gathers information with a focus on the future and a view towards patterns and possibilities. These visionaries need a lot of latitude to dream and look at different options, but also need support with the necessary details. These subtypes are known for having an imaginative, big-picture, and innovative style.";
                lblSection2Score.Text = "Big-picture possibilities";

            }//end if

            if (section3score == thinking)
            {
                Label3.Text = "This personality subtype's decisions are based upon logic and objective analyses of cause and effect. These subtypes are very dispassionate, impersonal, impartial, and prefer to use their intellects to reach their results. These subtypes are known for a decisive, policy-oriented, and get the job done style.";
                lblSection3Score.Text = "Rationally logical";

            }//end if

            if (section3score == feeling)
            {
                Label3.Text = "This personality subtype's decisions are based upon values and a consideration of other people. These subtypes are very aware and sensitive to the needs of the other people that are involved, and how each will be affected by the decisions that are made. These subtypes are known for having a sympathetic, persuasive, and consensus-building style.";
                lblSection3Score.Text = "Person-centered values";

            }//end if

            if (section4score == judging)
            {
                Label4.Text = "This personality subtype likes to see things planned, organized, and settled reasonably quickly. They desire deadlines, for themselves as well as for others, and expect them to be met. These subtypes are known for having a prepared, determined, and scheduled style.";
                lblSection4Score.Text = "Orderly-controlled closure";

            }//end if

            if (section4score == percieving)
            {
                Label4.Text = "This personality subtype likes to keep things flexible and spontaneous with all options open on the table. They are known for having a willingness, even desire, to adjust during a project, which allows for new ideas and information to be added to the mix at any given time. These subtypes are known for an open-minded, easy-going, and non-hurried style.";
                lblSection4Score.Text = "Openly-spontaneous flexibility";

            }//end if

            #endregion

            string Q39 = lblSection1Score.Text;
            string Q40 = Label1.Text;
            string Q42 = lblSection2Score.Text;
            string Q43 = Label2.Text;
            string Q45 = lblSection3Score.Text;
            string Q46 = Label3.Text;
            string Q48 = lblSection4Score.Text;
            string Q49 = Label4.Text;

            Validate validationObject = new Validate();

            Q1 = validationObject.Truncate(Q1, 100);
            Q2 = validationObject.Truncate(Q2, 100);
            Q3 = validationObject.Truncate(Q3, 100);
            Q4 = validationObject.Truncate(Q4, 100);
            Q5 = validationObject.Truncate(Q5, 100);
            Q6 = validationObject.Truncate(Q6, 100);
            Q7 = validationObject.Truncate(Q7, 100);
            Q8 = validationObject.Truncate(Q8, 100);
            Q9 = validationObject.Truncate(Q9, 100);
            Q10 = validationObject.Truncate(Q10, 100);
            Q11 = validationObject.Truncate(Q11, 100);
            Q12 = validationObject.Truncate(Q12, 100);
            Q13 = validationObject.Truncate(Q13, 100);
            Q14 = validationObject.Truncate(Q14, 100);
            Q15 = validationObject.Truncate(Q15, 100);
            Q16 = validationObject.Truncate(Q16, 100);
            Q17 = validationObject.Truncate(Q17, 100);
            Q18 = validationObject.Truncate(Q18, 100);
            Q19 = validationObject.Truncate(Q19, 100);
            Q20 = validationObject.Truncate(Q20, 100);
            Q21 = validationObject.Truncate(Q21, 100);
            Q22 = validationObject.Truncate(Q22, 100);
            Q23 = validationObject.Truncate(Q23, 100);
            Q24 = validationObject.Truncate(Q24, 100);
            Q25 = validationObject.Truncate(Q25, 100);
            Q26 = validationObject.Truncate(Q26, 100);
            Q27 = validationObject.Truncate(Q27, 100);
            Q28 = validationObject.Truncate(Q28, 100);
            Q29 = validationObject.Truncate(Q29, 100);
            Q30 = validationObject.Truncate(Q30, 100);
            Q31 = validationObject.Truncate(Q31, 100);
            Q32 = validationObject.Truncate(Q32, 100);
            Q33 = validationObject.Truncate(Q33, 100);
            Q34 = validationObject.Truncate(Q34, 100);
            Q35 = validationObject.Truncate(Q35, 100);
            Q36 = validationObject.Truncate(Q36, 100);
            Q37 = validationObject.Truncate(Q37, 100);
            Q38 = validationObject.Truncate(Q38, 100);

            Q39 = validationObject.Truncate(Q39, 900);
            Q42 = validationObject.Truncate(Q42, 900);
            Q45 = validationObject.Truncate(Q45, 900);
            Q48 = validationObject.Truncate(Q48, 900);

            Q40 = validationObject.Truncate(Q40, 900);
            Q43 = validationObject.Truncate(Q43, 900);
            Q46 = validationObject.Truncate(Q46, 900);
            Q49 = validationObject.Truncate(Q49, 900);

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Personal_Management_Style(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError.Text = errorMessage;
                lblError.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else if (recordExists == true)
            {

            }//end else if

            else if (recordExists == false)
            {
                string errorMessage2;

                errorMessage2 = Insert.Insert_Personal_Management_Style(username, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15, Q16, Q17, Q18, Q19, Q20, Q21, Q22, Q23, Q24, Q25, Q26, Q27, Q28, Q29, Q30, Q31, Q32, Q33, Q34, Q35, Q36, Q37, Q38, Q39, Q40, Q42, Q43, Q45, Q46, Q48, Q49);

                if (errorMessage2 != null)
                {
                    lblError.Text = errorMessage2;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View2);

                }//end else

            }//end else if

        }//end event

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            string Q41 = TextBox1.InnerText;
            string Q44 = TextBox2.InnerText;
            string Q47 = TextBox3.InnerText;
            string Q50 = TextBox4.InnerText;

            Validate validationObject = new Validate();

            Q41 = validationObject.Truncate(Q41, 900);
            Q44 = validationObject.Truncate(Q44, 900);
            Q47 = validationObject.Truncate(Q47, 900);
            Q50 = validationObject.Truncate(Q50, 900);

            string errorMessage;

            errorMessage = Update.Update_Personal_Management_Style(username, Q41, Q44, Q47, Q50);

            if (errorMessage != null)
            {
                lblError2.Text = errorMessage;
                lblError2.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                string errorMessage2;

                errorMessage2 = Update.Update_Personal_Management_Style_Status(username);

                if (errorMessage2 != null)
                {
                    lblError2.Text = errorMessage2;
                    lblError2.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View3);

                }//end else

            }//end else

        }//end event

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View2);

        }//end event

        protected void btnContinue2_Click(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
            Session sessionObject = new Session();
            FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddMinutes(sessionObject.getSessionTimeLimit()), ticket.IsPersistent, ticket.UserData);
            string encryptedTicket = FormsAuthentication.Encrypt(newTicket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            cookie.Expires = newTicket.Expiration;
            Response.Cookies.Add(cookie);

            string username = ticket.Name;

            MultiView1.SetActiveView(View3);

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