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
    public partial class _TotalSpiritualGifts : Page
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

            Label42.Visible = true;
            Label43.Visible = true;
            Label44.Visible = true;
            Label45.Visible = true;
            Label46.Visible = true;
            Label21.Font.Bold = true;
            Label22.Font.Bold = true;
            Label23.Font.Bold = true;
            Label47.Font.Bold = true;
            Label48.Font.Bold = true;

            if (!Page.IsPostBack)
            {
                MultiView1.SetActiveView(View1);

            }//end if

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Total_Spiritual_Gifts(username);

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

                    record = Select.Select_Total_Spiritual_Gifts_Record(username);

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
                        if (!Page.IsPostBack)
                        {
                            string nothing = "";

                            if ((record[0] != nothing) && (record[1] != nothing) && (record[2] != nothing) && (record[3] != nothing) && (record[4] != nothing) && (record[5] != nothing) && (record[6] != nothing) && (record[7] != nothing) && (record[8] != nothing) && (record[9] != nothing) && (record[10] != nothing) && (record[11] != nothing) && (record[12] != nothing) && (record[13] != nothing) && (record[14] != nothing) && (record[15] != nothing) && (record[16] != nothing) && (record[17] != nothing) && (record[18] != nothing) && (record[19] != nothing))
                            {
                                btnSubmit.Visible = false;
                                btnContinue.Visible = true;

                            }//end if

                            if ((record[20] != nothing) && (record[21] != nothing) && (record[22] != nothing) && (record[23] != nothing) && (record[24] != nothing) && (record[25] != nothing))
                            {
                                btnSubmit2.Visible = false;
                                btnContinue2.Visible = true;

                            }//end if

                        }//end if

                        string errorMessage3;

                        ArrayList record2 = new ArrayList();

                        Select selectObject3 = new Select();

                        record2 = Select.Select_Spiritual_Gifts_Record(username);

                        errorMessage3 = selectObject3.getErrorMessage();

                        if (errorMessage3 != null)
                        {
                            lblError.Text = errorMessage3;
                            lblError.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else
                        {
                            TextBox1.Text = record[0].ToString();
                            TextBox2.Text = record[1].ToString();
                            TextBox3.Text = record[2].ToString();
                            TextBox4.Text = record[3].ToString();
                            TextBox5.Text = record[4].ToString();
                            TextBox6.Text = record[5].ToString();
                            TextBox7.Text = record[6].ToString();
                            TextBox8.Text = record[7].ToString();
                            TextBox9.Text = record[8].ToString();
                            TextBox10.Text = record[9].ToString();
                            TextBox11.Text = record[10].ToString();
                            TextBox12.Text = record[11].ToString();
                            TextBox13.Text = record[12].ToString();
                            TextBox14.Text = record[13].ToString();
                            TextBox15.Text = record[14].ToString();
                            TextBox16.Text = record[15].ToString();
                            TextBox17.Text = record[16].ToString();
                            TextBox18.Text = record[17].ToString();
                            TextBox19.Text = record[18].ToString();
                            TextBox20.Text = record[19].ToString();
                            TextBox21.Text = record[20].ToString();

                            if (!Page.IsPostBack)
                            {
                                TextBox50.InnerText = record[24].ToString();
                                TextBox51.InnerText = record[25].ToString();
                                TextBox52.InnerText = record[26].ToString();

                            }//end if

                            for (int i = 21; i < 24; i++)
                            {
                                string value = (string)record[i];

                                if (value == CheckBox1.Text)
                                    CheckBox1.Checked = true;

                                if (value == CheckBox2.Text)
                                    CheckBox2.Checked = true;

                                if (value == CheckBox3.Text)
                                    CheckBox3.Checked = true;

                                if (value == CheckBox4.Text)
                                    CheckBox4.Checked = true;

                                if (value == CheckBox5.Text)
                                    CheckBox5.Checked = true;

                                if (value == CheckBox6.Text)
                                    CheckBox6.Checked = true;

                                if (value == CheckBox7.Text)
                                    CheckBox7.Checked = true;

                                if (value == CheckBox8.Text)
                                    CheckBox8.Checked = true;

                                if (value == CheckBox9.Text)
                                    CheckBox9.Checked = true;

                                if (value == CheckBox10.Text)
                                    CheckBox10.Checked = true;

                                if (value == CheckBox11.Text)
                                    CheckBox11.Checked = true;

                                if (value == CheckBox12.Text)
                                    CheckBox12.Checked = true;

                                if (value == CheckBox13.Text)
                                    CheckBox13.Checked = true;

                                if (value == CheckBox14.Text)
                                    CheckBox14.Checked = true;

                                if (value == CheckBox15.Text)
                                    CheckBox15.Checked = true;

                                if (value == CheckBox16.Text)
                                    CheckBox16.Checked = true;

                                if (value == CheckBox17.Text)
                                    CheckBox17.Checked = true;

                                if (value == CheckBox18.Text)
                                    CheckBox18.Checked = true;

                                if (value == CheckBox19.Text)
                                    CheckBox19.Checked = true;

                                if (value == CheckBox20.Text)
                                    CheckBox20.Checked = true;

                                if (value == CheckBox21.Text)
                                    CheckBox21.Checked = true;

                            }//end for

                            int x1;
                            int x2;
                            int x3;
                            int x4;
                            int x5;
                            int x6;
                            int x7;
                            int x8;
                            int x9;
                            int x10;
                            int x11;
                            int x12;
                            int x13;
                            int x14;
                            int x15;
                            int x16;
                            int x17;
                            int x18;
                            int x19;
                            int x20;
                            int x21;

                            int.TryParse(record[0].ToString(), out x1);
                            int.TryParse(record[1].ToString(), out x2);
                            int.TryParse(record[2].ToString(), out x3);
                            int.TryParse(record[3].ToString(), out x4);
                            int.TryParse(record[4].ToString(), out x5);
                            int.TryParse(record[5].ToString(), out x6);
                            int.TryParse(record[6].ToString(), out x7);
                            int.TryParse(record[7].ToString(), out x8);
                            int.TryParse(record[8].ToString(), out x9);
                            int.TryParse(record[9].ToString(), out x10);
                            int.TryParse(record[10].ToString(), out x11);
                            int.TryParse(record[11].ToString(), out x12);
                            int.TryParse(record[12].ToString(), out x13);
                            int.TryParse(record[13].ToString(), out x14);
                            int.TryParse(record[14].ToString(), out x15);
                            int.TryParse(record[15].ToString(), out x16);
                            int.TryParse(record[16].ToString(), out x17);
                            int.TryParse(record[17].ToString(), out x18);
                            int.TryParse(record[18].ToString(), out x19);
                            int.TryParse(record[19].ToString(), out x20);
                            int.TryParse(record[20].ToString(), out x21);

                            string q1 = record2[0].ToString();
                            string q2 = record2[1].ToString();
                            string q3 = record2[2].ToString();
                            string q4 = record2[3].ToString();
                            string q5 = record2[4].ToString();
                            string q6 = record2[5].ToString();
                            string q7 = record2[6].ToString();
                            string q8 = record2[7].ToString();
                            string q9 = record2[8].ToString();
                            string q10 = record2[9].ToString();
                            string q11 = record2[10].ToString();
                            string q12 = record2[11].ToString();
                            string q13 = record2[12].ToString();
                            string q14 = record2[13].ToString();
                            string q15 = record2[14].ToString();
                            string q16 = record2[15].ToString();
                            string q17 = record2[16].ToString();
                            string q18 = record2[17].ToString();
                            string q19 = record2[18].ToString();
                            string q20 = record2[19].ToString();
                            string q21 = record2[20].ToString();

                            q1 = q1.Trim();
                            q2 = q2.Trim();
                            q3 = q3.Trim();
                            q4 = q4.Trim();
                            q5 = q5.Trim();
                            q6 = q6.Trim();
                            q7 = q7.Trim();
                            q8 = q8.Trim();
                            q9 = q9.Trim();
                            q10 = q10.Trim();
                            q11 = q11.Trim();
                            q12 = q12.Trim();
                            q13 = q13.Trim();
                            q14 = q14.Trim();
                            q15 = q15.Trim();
                            q16 = q16.Trim();
                            q17 = q17.Trim();
                            q18 = q18.Trim();
                            q19 = q19.Trim();
                            q20 = q20.Trim();
                            q21 = q21.Trim();

                            if (q1 == "Mercy")
                            {
                                x1 = x1 + 1;
                                Label1.Text = x1.ToString();

                            }//end if

                            else
                            {
                                Label1.Text = x1.ToString();

                            }//end else


                            if (q2 == "Service")
                            {
                                x2 = x2 + 1;
                                Label2.Text = x2.ToString();

                            }//end if

                            else
                            {
                                Label2.Text = x2.ToString();

                            }//end else


                            if (q3 == "Hospitality")
                            {
                                x3 = x3 + 1;
                                Label3.Text = x3.ToString();

                            }//end if

                            else
                            {
                                Label3.Text = x3.ToString();

                            }//end else


                            if (q4 == "Giving")
                            {
                                x4 = x4 + 1;
                                Label4.Text = x4.ToString();

                            }//end if

                            else
                            {
                                Label4.Text = x4.ToString();

                            }//end else


                            if (q5 == "Administration")
                            {
                                x5 = x5 + 1;
                                Label5.Text = x5.ToString();

                            }//end if

                            else
                            {
                                Label5.Text = x5.ToString();

                            }//end else


                            if (q6 == "Leadership")
                            {
                                x6 = x6 + 1;
                                Label6.Text = x6.ToString();

                            }//end if

                            else
                            {
                                Label6.Text = x6.ToString();

                            }//end else


                            if (q7 == "Faith")
                            {
                                x7 = x7 + 1;
                                Label7.Text = x7.ToString();

                            }//end if

                            else
                            {
                                Label7.Text = x7.ToString();

                            }//end else


                            if (q8 == "Discernment")
                            {
                                x8 = x8 + 1;
                                Label8.Text = x8.ToString();

                            }//end if

                            else
                            {
                                Label8.Text = x8.ToString();

                            }//end else


                            if (q9 == "Knowledge")
                            {
                                x9 = x9 + 1;
                                Label9.Text = x9.ToString();

                            }//end if

                            else
                            {
                                Label9.Text = x9.ToString();

                            }//end else


                            if (q10 == "Wisdom")
                            {
                                x10 = x10 + 1;
                                Label10.Text = x10.ToString();

                            }//end if

                            else
                            {
                                Label10.Text = x10.ToString();

                            }//end else


                            if (q11 == "Preaching")
                            {
                                x11 = x11 + 1;
                                Label11.Text = x11.ToString();

                            }//end if

                            else
                            {
                                Label11.Text = x11.ToString();

                            }//end else


                            if (q12 == "Teaching")
                            {
                                x12 = x12 + 1;
                                Label12.Text = x12.ToString();

                            }//end if

                            else
                            {
                                Label12.Text = x12.ToString();

                            }//end else


                            if (q13 == "Evangelism")
                            {
                                x13 = x13 + 1;
                                Label13.Text = x13.ToString();

                            }//end if

                            else
                            {
                                Label13.Text = x13.ToString();

                            }//end else


                            if (q14 == "Apostleship")
                            {
                                x14 = x14 + 1;
                                Label14.Text = x14.ToString();

                            }//end if

                            else
                            {
                                Label14.Text = x14.ToString();

                            }//end else


                            if (q15 == "Shepherding")
                            {
                                x15 = x15 + 1;
                                Label15.Text = x15.ToString();

                            }//end if

                            else
                            {
                                Label15.Text = x15.ToString();

                            }//end else


                            if (q16 == "Encouragement")
                            {
                                x16 = x16 + 1;
                                Label16.Text = x16.ToString();

                            }//end if

                            else
                            {
                                Label16.Text = x16.ToString();

                            }//end else


                            if (q17 == "Tongues")
                            {
                                x17 = x17 + 1;
                                Label17.Text = x17.ToString();

                            }//end if

                            else
                            {
                                Label17.Text = x17.ToString();

                            }//end else


                            if (q18 == "Interpretation of Tongues")
                            {
                                x18 = x18 + 1;
                                Label18.Text = x18.ToString();

                            }//end if

                            else
                            {
                                Label18.Text = x18.ToString();

                            }//end else


                            if (q19 == "Miracles")
                            {
                                x19 = x19 + 1;
                                Label19.Text = x19.ToString();

                            }//end if

                            else
                            {
                                Label19.Text = x19.ToString();

                            }//end else


                            if (q20 == "Healing")
                            {
                                x20 = x20 + 1;
                                Label20.Text = x20.ToString();

                            }//end if

                            else
                            {
                                Label20.Text = x20.ToString();

                            }//end else

                            if (q21 == "Intercession (praying for others)")
                            {
                                x21 = x21 + 1;
                                Label49.Text = x21.ToString();

                            }//end if

                            else
                            {
                                Label49.Text = x21.ToString();

                            }//end else

                        }//end else

                    }//end else

                }//end if

            }//end else

            //CREATE ARRAYLISTS TO HOLD SELECTED VALUES
            ArrayList selectedValues = new ArrayList();
            ArrayList selectedDescription = new ArrayList();

            //LIMIT CHECKBOXES SELECTION TO 3
            int count = 0;

            if (CheckBox1.Checked == true)
            {
                selectedValues.Add(CheckBox1.Text);
                selectedDescription.Add(Label27.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox1.Text);
                    selectedDescription.Remove(Label27.Text);
                    CheckBox1.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if


            if (CheckBox2.Checked == true)
            {
                selectedValues.Add(CheckBox2.Text);
                selectedDescription.Add(Label28.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox2.Text);
                    selectedDescription.Remove(Label28.Text);
                    CheckBox2.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if


            if (CheckBox3.Checked == true)
            {
                selectedValues.Add(CheckBox3.Text);
                selectedDescription.Add(Label29.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox3.Text);
                    selectedDescription.Remove(Label29.Text);
                    CheckBox3.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if


            if (CheckBox4.Checked == true)
            {
                selectedValues.Add(CheckBox4.Text);
                selectedDescription.Add(Label30.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox4.Text);
                    selectedDescription.Remove(Label30.Text);
                    CheckBox4.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if


            if (CheckBox5.Checked == true)
            {
                selectedValues.Add(CheckBox5.Text);
                selectedDescription.Add(Label31.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox5.Text);
                    selectedDescription.Remove(Label31.Text);
                    CheckBox5.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if


            if (CheckBox6.Checked == true)
            {
                selectedValues.Add(CheckBox6.Text);
                selectedDescription.Add(Label32.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox6.Text);
                    selectedDescription.Remove(Label32.Text);
                    CheckBox6.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if


            if (CheckBox7.Checked == true)
            {
                selectedValues.Add(CheckBox7.Text);
                selectedDescription.Add(Label33.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox7.Text);
                    selectedDescription.Remove(Label33.Text);
                    CheckBox7.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if


            if (CheckBox8.Checked == true)
            {
                selectedValues.Add(CheckBox8.Text);
                selectedDescription.Add(Label34.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox8.Text);
                    selectedDescription.Remove(Label34.Text);
                    CheckBox8.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if


            if (CheckBox9.Checked == true)
            {
                selectedValues.Add(CheckBox9.Text);
                selectedDescription.Add(Label35.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox9.Text);
                    selectedDescription.Remove(Label35.Text);
                    CheckBox9.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox10.Checked == true)
            {
                selectedValues.Add(CheckBox10.Text);
                selectedDescription.Add(Label36.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox10.Text);
                    selectedDescription.Remove(Label36.Text);
                    CheckBox10.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox11.Checked == true)
            {
                selectedValues.Add(CheckBox11.Text);
                selectedDescription.Add(Label37.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox11.Text);
                    selectedDescription.Remove(Label37.Text);
                    CheckBox11.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox12.Checked == true)
            {
                selectedValues.Add(CheckBox12.Text);
                selectedDescription.Add(Label38.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox12.Text);
                    selectedDescription.Remove(Label38.Text);
                    CheckBox12.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox13.Checked == true)
            {
                selectedValues.Add(CheckBox13.Text);
                selectedDescription.Add(Label39.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox13.Text);
                    selectedDescription.Remove(Label39.Text);
                    CheckBox13.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox14.Checked == true)
            {
                selectedValues.Add(CheckBox14.Text);
                selectedDescription.Add(Label40.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox14.Text);
                    selectedDescription.Remove(Label40.Text);
                    CheckBox14.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox15.Checked == true)
            {
                selectedValues.Add(CheckBox15.Text);
                selectedDescription.Add(Label41.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox15.Text);
                    selectedDescription.Remove(Label41.Text);
                    CheckBox15.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox16.Checked == true)
            {
                selectedValues.Add(CheckBox16.Text);
                selectedDescription.Add(Label42.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox16.Text);
                    selectedDescription.Remove(Label42.Text);
                    CheckBox16.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox17.Checked == true)
            {
                selectedValues.Add(CheckBox17.Text);
                selectedDescription.Add(Label43.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox17.Text);
                    selectedDescription.Remove(Label43.Text);
                    CheckBox17.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox18.Checked == true)
            {
                selectedValues.Add(CheckBox18.Text);
                selectedDescription.Add(Label44.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox18.Text);
                    selectedDescription.Remove(Label44.Text);
                    CheckBox18.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox19.Checked == true)
            {
                selectedValues.Add(CheckBox19.Text);
                selectedDescription.Add(Label45.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox19.Text);
                    selectedDescription.Remove(Label45.Text);
                    CheckBox19.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox20.Checked == true)
            {
                selectedValues.Add(CheckBox20.Text);
                selectedDescription.Add(Label46.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox20.Text);
                    selectedDescription.Remove(Label46.Text);
                    CheckBox20.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            if (CheckBox21.Checked == true)
            {
                selectedValues.Add(CheckBox21.Text);
                selectedDescription.Add(Label50.Text);
                count++;

                if (count > 3)
                {
                    selectedValues.Remove(CheckBox21.Text);
                    selectedDescription.Remove(Label50.Text);
                    CheckBox21.Checked = false;
                    count--;

                    MsgBox("Checkbox selection is limited to three.");

                }//end inner if

            }//end outer if

            //UPDATE LABELS AT BOTTOM OF PAGE TO SELECTED VALUES
            Label21.Text = "";
            Label22.Text = "";
            Label23.Text = "";
            Label24.Text = "";
            Label25.Text = "";
            Label26.Text = "";

            int selectedCount = selectedValues.Count;

            if (selectedCount >= 1)
            {
                Label21.Text = selectedValues[0].ToString();
                Label21.Visible = true;
                Label24.Text = selectedDescription[0].ToString();
                Label24.Visible = true;

            }//end if

            if (selectedCount >= 2)
            {
                Label22.Text = selectedValues[1].ToString();
                Label22.Visible = true;
                Label25.Text = selectedDescription[1].ToString();
                Label25.Visible = true;

            }//end if

            if (selectedCount >= 3)
            {
                Label23.Text = selectedValues[2].ToString();
                Label23.Visible = true;
                Label26.Text = selectedDescription[2].ToString();
                Label26.Visible = true;
                lblError.Visible = false;

            }//end if

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

            string Q1 = TextBox1.Text;
            string Q2 = TextBox2.Text;
            string Q3 = TextBox3.Text;
            string Q4 = TextBox4.Text;
            string Q5 = TextBox5.Text;
            string Q6 = TextBox6.Text;
            string Q7 = TextBox7.Text;
            string Q8 = TextBox8.Text;
            string Q9 = TextBox9.Text;
            string Q10 = TextBox10.Text;
            string Q11 = TextBox11.Text;
            string Q12 = TextBox12.Text;
            string Q13 = TextBox13.Text;
            string Q14 = TextBox14.Text;
            string Q15 = TextBox15.Text;
            string Q16 = TextBox16.Text;
            string Q17 = TextBox17.Text;
            string Q18 = TextBox18.Text;
            string Q19 = TextBox19.Text;
            string Q20 = TextBox20.Text;
            string Q21 = TextBox21.Text;

            Validate validationObject = new Validate();

            Q1 = validationObject.Truncate(Q1, 3);
            Q2 = validationObject.Truncate(Q2, 3);
            Q3 = validationObject.Truncate(Q3, 3);
            Q4 = validationObject.Truncate(Q4, 3);
            Q5 = validationObject.Truncate(Q5, 3);
            Q6 = validationObject.Truncate(Q6, 3);
            Q7 = validationObject.Truncate(Q7, 3);
            Q8 = validationObject.Truncate(Q8, 3);
            Q9 = validationObject.Truncate(Q9, 3);
            Q10 = validationObject.Truncate(Q10, 3);
            Q11 = validationObject.Truncate(Q11, 3);
            Q12 = validationObject.Truncate(Q12, 3);
            Q13 = validationObject.Truncate(Q13, 3);
            Q14 = validationObject.Truncate(Q14, 3);
            Q15 = validationObject.Truncate(Q15, 3);
            Q16 = validationObject.Truncate(Q16, 3);
            Q17 = validationObject.Truncate(Q17, 3);
            Q18 = validationObject.Truncate(Q18, 3);
            Q19 = validationObject.Truncate(Q19, 3);
            Q20 = validationObject.Truncate(Q20, 3);
            Q21 = validationObject.Truncate(Q21, 3);

            int y1;
            int y2;
            int y3;
            int y4;
            int y5;
            int y6;
            int y7;
            int y8;
            int y9;
            int y10;
            int y11;
            int y12;
            int y13;
            int y14;
            int y15;
            int y16;
            int y17;
            int y18;
            int y19;
            int y20;
            int y21;

            int.TryParse(Q1, out y1);
            int.TryParse(Q2, out y2);
            int.TryParse(Q3, out y3);
            int.TryParse(Q4, out y4);
            int.TryParse(Q5, out y5);
            int.TryParse(Q6, out y6);
            int.TryParse(Q7, out y7);
            int.TryParse(Q8, out y8);
            int.TryParse(Q9, out y9);
            int.TryParse(Q10, out y10);
            int.TryParse(Q11, out y11);
            int.TryParse(Q12, out y12);
            int.TryParse(Q13, out y13);
            int.TryParse(Q14, out y14);
            int.TryParse(Q15, out y15);
            int.TryParse(Q16, out y16);
            int.TryParse(Q17, out y17);
            int.TryParse(Q18, out y18);
            int.TryParse(Q19, out y19);
            int.TryParse(Q20, out y20);
            int.TryParse(Q21, out y21);

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Total_Spiritual_Gifts(username);

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
                    

                }//end if

                else if (recordExists == false)
                {
                    string errorMessage2;

                    errorMessage2 = Insert.Insert_Total_Spiritual_Gifts(username, y1, y2, y3, y4, y5, y6, y7, y8, y9, y10, y11, y12, y13, y14, y15, y16, y17, y18, y19, y20, y21);

                    if (errorMessage2 != null)
                    {
                        lblError.Text = errorMessage2;
                        lblError.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        string errorMessage3;

                        ArrayList record2 = new ArrayList();

                        Select selectObject3 = new Select();

                        record2 = Select.Select_Spiritual_Gifts_Record(username);

                        errorMessage3 = selectObject3.getErrorMessage();

                        if (errorMessage3 != null)
                        {
                            lblError.Text = errorMessage3;
                            lblError.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else
                        {
                            string q1 = record2[0].ToString();
                            string q2 = record2[1].ToString();
                            string q3 = record2[2].ToString();
                            string q4 = record2[3].ToString();
                            string q5 = record2[4].ToString();
                            string q6 = record2[5].ToString();
                            string q7 = record2[6].ToString();
                            string q8 = record2[7].ToString();
                            string q9 = record2[8].ToString();
                            string q10 = record2[9].ToString();
                            string q11 = record2[10].ToString();
                            string q12 = record2[11].ToString();
                            string q13 = record2[12].ToString();
                            string q14 = record2[13].ToString();
                            string q15 = record2[14].ToString();
                            string q16 = record2[15].ToString();
                            string q17 = record2[16].ToString();
                            string q18 = record2[17].ToString();
                            string q19 = record2[18].ToString();
                            string q20 = record2[19].ToString();
                            string q21 = record2[20].ToString();

                            q1 = q1.Trim();
                            q2 = q2.Trim();
                            q3 = q3.Trim();
                            q4 = q4.Trim();
                            q5 = q5.Trim();
                            q6 = q6.Trim();
                            q7 = q7.Trim();
                            q8 = q8.Trim();
                            q9 = q9.Trim();
                            q10 = q10.Trim();
                            q11 = q11.Trim();
                            q12 = q12.Trim();
                            q13 = q13.Trim();
                            q14 = q14.Trim();
                            q15 = q15.Trim();
                            q16 = q16.Trim();
                            q17 = q17.Trim();
                            q18 = q18.Trim();
                            q19 = q19.Trim();
                            q20 = q20.Trim();
                            q21 = q21.Trim();

                            if (q1 == "Mercy")
                            {
                                y1 = y1 + 1;
                                Label1.Text = y1.ToString();

                            }//end if

                            else
                            {
                                Label1.Text = y1.ToString();

                            }//end else


                            if (q2 == "Service")
                            {
                                y2 = y2 + 1;
                                Label2.Text = y2.ToString();

                            }//end if

                            else
                            {
                                Label2.Text = y2.ToString();

                            }//end else


                            if (q3 == "Hospitality")
                            {
                                y3 = y3 + 1;
                                Label3.Text = y3.ToString();

                            }//end if

                            else
                            {
                                Label3.Text = y3.ToString();

                            }//end else


                            if (q4 == "Giving")
                            {
                                y4 = y4 + 1;
                                Label4.Text = y4.ToString();

                            }//end if

                            else
                            {
                                Label4.Text = y4.ToString();

                            }//end else


                            if (q5 == "Administration")
                            {
                                y5 = y5 + 1;
                                Label5.Text = y5.ToString();

                            }//end if

                            else
                            {
                                Label5.Text = y5.ToString();

                            }//end else


                            if (q6 == "Leadership")
                            {
                                y6 = y6 + 1;
                                Label6.Text = y6.ToString();

                            }//end if

                            else
                            {
                                Label6.Text = y6.ToString();

                            }//end else


                            if (q7 == "Faith")
                            {
                                y7 = y7 + 1;
                                Label7.Text = y7.ToString();

                            }//end if

                            else
                            {
                                Label7.Text = y7.ToString();

                            }//end else


                            if (q8 == "Discernment")
                            {
                                y8 = y8 + 1;
                                Label8.Text = y8.ToString();

                            }//end if

                            else
                            {
                                Label8.Text = y8.ToString();

                            }//end else


                            if (q9 == "Knowledge")
                            {
                                y9 = y9 + 1;
                                Label9.Text = y9.ToString();

                            }//end if

                            else
                            {
                                Label9.Text = y9.ToString();

                            }//end else


                            if (q10 == "Wisdom")
                            {
                                y10 = y10 + 1;
                                Label10.Text = y10.ToString();

                            }//end if

                            else
                            {
                                Label10.Text = y10.ToString();

                            }//end else


                            if (q11 == "Preaching")
                            {
                                y11 = y11 + 1;
                                Label11.Text = y11.ToString();

                            }//end if

                            else
                            {
                                Label11.Text = y11.ToString();

                            }//end else


                            if (q12 == "Teaching")
                            {
                                y12 = y12 + 1;
                                Label12.Text = y12.ToString();

                            }//end if

                            else
                            {
                                Label12.Text = y12.ToString();

                            }//end else


                            if (q13 == "Evangelism")
                            {
                                y13 = y13 + 1;
                                Label13.Text = y13.ToString();

                            }//end if

                            else
                            {
                                Label13.Text = y13.ToString();

                            }//end else


                            if (q14 == "Apostleship")
                            {
                                y14 = y14 + 1;
                                Label14.Text = y14.ToString();

                            }//end if

                            else
                            {
                                Label14.Text = y14.ToString();

                            }//end else


                            if (q15 == "Shepherding")
                            {
                                y15 = y15 + 1;
                                Label15.Text = y15.ToString();

                            }//end if

                            else
                            {
                                Label15.Text = y15.ToString();

                            }//end else


                            if (q16 == "Encouragement")
                            {
                                y16 = y16 + 1;
                                Label16.Text = y16.ToString();

                            }//end if

                            else
                            {
                                Label16.Text = y16.ToString();

                            }//end else


                            if (q17 == "Tongues")
                            {
                                y17 = y17 + 1;
                                Label17.Text = y17.ToString();

                            }//end if

                            else
                            {
                                Label17.Text = y17.ToString();

                            }//end else


                            if (q18 == "Interpretation of Tongues")
                            {
                                y18 = y18 + 1;
                                Label18.Text = y18.ToString();

                            }//end if

                            else
                            {
                                Label18.Text = y18.ToString();

                            }//end else


                            if (q19 == "Miracles")
                            {
                                y19 = y19 + 1;
                                Label19.Text = y19.ToString();

                            }//end if

                            else
                            {
                                Label19.Text = y19.ToString();

                            }//end else


                            if (q20 == "Healing")
                            {
                                y20 = y20 + 1;
                                Label20.Text = y20.ToString();

                            }//end if

                            else
                            {
                                Label20.Text = y20.ToString();

                            }//end else

                            if (q21 == "Intercession (praying for others)")
                            {
                                y21 = y21 + 1;
                                Label49.Text = y21.ToString();

                            }//end if

                            else
                            {
                                Label49.Text = y21.ToString();

                            }//end else

                            MultiView1.SetActiveView(View2);

                        }//end else

                    }//end else

                }//end else if

            }//end else

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

            int selectionCount = 0;

            if (CheckBox1.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox2.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox3.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox4.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox5.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox6.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox7.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox8.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox9.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox10.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox11.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox12.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox13.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox14.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox15.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox16.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox17.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox18.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox19.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox20.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox21.Checked == true)
            {
                selectionCount++;

            }//end if

            if ((selectionCount > 3) || (selectionCount < 3))
            {
                MsgBox("You must select exactly three spiritual gifts from the selection.");

            }//end if

            else if (selectionCount == 3)
            {
                string Q21 = Label21.Text;
                string Q22 = Label22.Text;
                string Q23 = Label23.Text;
                string Q24 = TextBox50.InnerText;
                string Q25 = TextBox51.InnerText;
                string Q26 = TextBox52.InnerText;

                Validate validationObject = new Validate();

                Q21 = validationObject.Truncate(Q21, 900);
                Q22 = validationObject.Truncate(Q22, 900);
                Q23 = validationObject.Truncate(Q23, 900);
                Q24 = validationObject.Truncate(Q24, 900);
                Q25 = validationObject.Truncate(Q25, 900);
                Q26 = validationObject.Truncate(Q26, 900);
                
                string errorMessage;

                errorMessage = Update.Update_Total_Spiritual_Gifts(username, Q21, Q22, Q23, Q24, Q25, Q26);

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

                    errorMessage2 = Update.Update_Total_Spiritual_Gifts_Status(username);

                    if (errorMessage2 != null)
                    {
                        lblError2.Text = errorMessage2;
                        lblError2.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        Response.Redirect("~/PL/FOP/FOP_ProgressMenu.aspx");

                    }//end if

                }//end else

            }//end else if

        }//end event

        protected void btnContinue_Click(object sender, EventArgs e)
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

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox4.Focus();

        }//end event

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox5.Focus();

        }//end event

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox6.Focus();

        }//end event

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox7.Focus();

        }//end event

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox8.Focus();

        }//end event

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox8.Focus();

        }//end event

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox21.Focus();

        }//end event

        protected void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox9.Focus();

        }//end event

        protected void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox12.Focus();

        }//end event

        protected void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox13.Focus();

        }//end event

        protected void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox14.Focus();

        }//end event

        protected void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox15.Focus();

        }//end event

        protected void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox16.Focus();

        }//end event

        protected void CheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox17.Focus();

        }//end event

        protected void CheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox18.Focus();

        }//end event

        protected void CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox19.Focus();

        }//end event

        protected void CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox20.Focus();

        }//end event

        protected void CheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox20.Focus();

        }//end event

        protected void CheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox20.Focus();

        }//end event

        protected void CheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            TextBox50.Focus();

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