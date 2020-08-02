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
    public partial class _FocusAnalysisWorksheet : Page
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

            if (Page.IsPostBack == false)
            {
                MultiView1.SetActiveView(View10);

            }//end if

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Focus_Analysis_Worksheet(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError10.Text = errorMessage;
                lblError10.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists == true)
                {
                    string errorMessage2;

                    ArrayList record = new ArrayList();

                    record = Select.Select_Focus_Analysis_Record(username);

                    errorMessage2 = selectObject.getErrorMessage();

                    if (errorMessage2 != null)
                    {
                        lblError10.Text = errorMessage2;
                        lblError10.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        if (!Page.IsPostBack)
                        {
                            string nothing = "";

                            if ((record[0] != nothing) && (record[1] != nothing) && (record[2] != nothing) && (record[3] != nothing) && (record[4] != nothing) && (record[5] != nothing) && (record[6] != nothing) && (record[7] != nothing))
                            {
                                btnSubmit10.Visible = false;
                                btnContinue10.Visible = true;

                            }//end if

                            if ((record[8] != nothing) || (record[9] != nothing) || (record[10] != nothing) || (record[11] != nothing) || (record[12] != nothing) || (record[13] != nothing) || (record[14] != nothing) || (record[15] != nothing) || (record[16] != nothing) || (record[17] != nothing) || (record[18] != nothing) || (record[19] != nothing) || (record[20] != nothing) || (record[21] != nothing) || (record[22] != nothing) || (record[23] != nothing) || (record[24] != nothing) || (record[25] != nothing) || (record[26] != nothing) || (record[27] != nothing))
                            {
                                btnSubmit.Visible = false;
                                btnContinue.Visible = true;

                            }//end if

                            if ((record[28] != nothing) || (record[29] != nothing) || (record[30] != nothing) || (record[31] != nothing) || (record[32] != nothing) || (record[33] != nothing) || (record[34] != nothing) || (record[35] != nothing) || (record[36] != nothing) || (record[37] != nothing) || (record[38] != nothing) || (record[39] != nothing) || (record[40] != nothing) || (record[41] != nothing) || (record[42] != nothing) || (record[43] != nothing) || (record[44] != nothing) || (record[45] != nothing) || (record[46] != nothing) || (record[47] != nothing))
                            {
                                btnSubmit2.Visible = false;
                                btnContinue2.Visible = true;

                            }//end if

                            if ((record[48] != nothing) || (record[49] != nothing) || (record[50] != nothing) || (record[51] != nothing) || (record[52] != nothing) || (record[53] != nothing) || (record[54] != nothing) || (record[55] != nothing) || (record[56] != nothing) || (record[57] != nothing) || (record[58] != nothing) || (record[59] != nothing) || (record[60] != nothing) || (record[61] != nothing) || (record[62] != nothing) || (record[63] != nothing) || (record[64] != nothing) || (record[65] != nothing) || (record[66] != nothing) || (record[67] != nothing))
                            {
                                btnSubmit3.Visible = false;
                                btnContinue3.Visible = true;

                            }//end if

                            if ((record[68] != nothing) || (record[69] != nothing) || (record[70] != nothing) || (record[71] != nothing) || (record[72] != nothing) || (record[73] != nothing) || (record[74] != nothing) || (record[75] != nothing) || (record[76] != nothing) || (record[77] != nothing) || (record[78] != nothing) || (record[79] != nothing) || (record[80] != nothing) || (record[81] != nothing) || (record[82] != nothing) || (record[83] != nothing) || (record[84] != nothing) || (record[85] != nothing) || (record[86] != nothing) || (record[87] != nothing))
                            {
                                btnSubmit4.Visible = false;
                                btnContinue4.Visible = true;

                            }//end if

                            if ((record[88] != nothing) || (record[89] != nothing) || (record[90] != nothing) || (record[91] != nothing) || (record[92] != nothing) || (record[93] != nothing) || (record[94] != nothing) || (record[95] != nothing) || (record[96] != nothing) || (record[97] != nothing) || (record[98] != nothing) || (record[99] != nothing) || (record[100] != nothing) || (record[101] != nothing) || (record[102] != nothing) || (record[103] != nothing) || (record[104] != nothing) || (record[105] != nothing) || (record[106] != nothing) || (record[107] != nothing))
                            {
                                btnSubmit5.Visible = false;
                                btnContinue5.Visible = true;

                            }//end if

                            if ((record[108] != nothing) || (record[109] != nothing) || (record[110] != nothing) || (record[111] != nothing) || (record[112] != nothing) || (record[113] != nothing) || (record[114] != nothing) || (record[115] != nothing) || (record[116] != nothing) || (record[117] != nothing) || (record[118] != nothing) || (record[119] != nothing) || (record[120] != nothing) || (record[121] != nothing) || (record[122] != nothing) || (record[123] != nothing) || (record[124] != nothing) || (record[125] != nothing) || (record[126] != nothing) || (record[127] != nothing))
                            {
                                btnSubmit6.Visible = false;
                                btnContinue6.Visible = true;

                            }//end if

                            if ((record[128] != nothing) || (record[129] != nothing) || (record[130] != nothing) || (record[131] != nothing) || (record[132] != nothing) || (record[133] != nothing) || (record[134] != nothing) || (record[135] != nothing) || (record[136] != nothing) || (record[137] != nothing) || (record[138] != nothing) || (record[139] != nothing) || (record[140] != nothing) || (record[141] != nothing) || (record[142] != nothing) || (record[143] != nothing) || (record[144] != nothing) || (record[145] != nothing) || (record[146] != nothing) || (record[147] != nothing))
                            {
                                btnSubmit7.Visible = false;
                                btnContinue7.Visible = true;

                            }//end if

                            if ((record[148] != nothing) || (record[149] != nothing) || (record[150] != nothing) || (record[151] != nothing) || (record[152] != nothing) || (record[153] != nothing) || (record[154] != nothing) || (record[155] != nothing) || (record[156] != nothing) || (record[157] != nothing) || (record[158] != nothing) || (record[159] != nothing) || (record[160] != nothing) || (record[161] != nothing) || (record[162] != nothing) || (record[163] != nothing) || (record[164] != nothing) || (record[165] != nothing) || (record[166] != nothing) || (record[167] != nothing))
                            {
                                btnSubmit8.Visible = false;
                                btnContinue8.Visible = true;

                            }//end if

                            if ((record[168] != nothing) || (record[169] != nothing) || (record[170] != nothing) || (record[171] != nothing) || (record[172] != nothing) || (record[173] != nothing) || (record[174] != nothing) || (record[175] != nothing) || (record[176] != nothing) || (record[177] != nothing) || (record[178] != nothing) || (record[179] != nothing) || (record[180] != nothing) || (record[181] != nothing) || (record[182] != nothing) || (record[183] != nothing) || (record[184] != nothing) || (record[185] != nothing) || (record[186] != nothing) || (record[187] != nothing))
                            {
                                btnSubmit9.Visible = false;
                                btnContinue9.Visible = true;

                            }//end if

                        }//end if

                        TextBox23.Text = record[0].ToString();
                        lblExample1.Text = record[0].ToString();

                        TextBox24.Text = record[1].ToString();
                        lblExample2.Text = record[1].ToString();

                        TextBox25.Text = record[2].ToString();
                        lblExample3.Text = record[2].ToString();

                        TextBox26.Text = record[3].ToString();
                        lblExample4.Text = record[3].ToString();

                        TextBox27.Text = record[4].ToString();
                        lblExample5.Text = record[4].ToString();

                        TextBox28.Text = record[5].ToString();
                        lblExample6.Text = record[5].ToString();

                        TextBox29.Text = record[6].ToString();
                        lblExample7.Text = record[6].ToString();

                        TextBox30.Text = record[7].ToString();
                        lblExample8.Text = record[7].ToString();

                        for (int i = 8; i < 28; i++)
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

                        }//end for

                        for (int i = 28; i < 48; i++)
                        {
                            string value = (string)record[i];

                            if (value == CheckBox21.Text)
                                CheckBox21.Checked = true;

                            if (value == CheckBox22.Text)
                                CheckBox22.Checked = true;

                            if (value == CheckBox23.Text)
                                CheckBox23.Checked = true;

                            if (value == CheckBox24.Text)
                                CheckBox24.Checked = true;

                            if (value == CheckBox25.Text)
                                CheckBox25.Checked = true;

                            if (value == CheckBox26.Text)
                                CheckBox26.Checked = true;

                            if (value == CheckBox27.Text)
                                CheckBox27.Checked = true;

                            if (value == CheckBox28.Text)
                                CheckBox28.Checked = true;

                            if (value == CheckBox29.Text)
                                CheckBox29.Checked = true;

                            if (value == CheckBox30.Text)
                                CheckBox30.Checked = true;

                            if (value == CheckBox31.Text)
                                CheckBox31.Checked = true;

                            if (value == CheckBox32.Text)
                                CheckBox32.Checked = true;

                            if (value == CheckBox33.Text)
                                CheckBox33.Checked = true;

                            if (value == CheckBox34.Text)
                                CheckBox34.Checked = true;

                            if (value == CheckBox35.Text)
                                CheckBox35.Checked = true;

                            if (value == CheckBox36.Text)
                                CheckBox36.Checked = true;

                            if (value == CheckBox37.Text)
                                CheckBox37.Checked = true;

                            if (value == CheckBox38.Text)
                                CheckBox38.Checked = true;

                            if (value == CheckBox39.Text)
                                CheckBox39.Checked = true;

                            if (value == CheckBox40.Text)
                                CheckBox40.Checked = true;

                        }//end for                            

                        for (int i = 48; i < 68; i++)
                        {
                            string value = (string)record[i];

                            if (value == CheckBox41.Text)
                                CheckBox41.Checked = true;

                            if (value == CheckBox42.Text)
                                CheckBox42.Checked = true;

                            if (value == CheckBox43.Text)
                                CheckBox43.Checked = true;

                            if (value == CheckBox44.Text)
                                CheckBox44.Checked = true;

                            if (value == CheckBox45.Text)
                                CheckBox45.Checked = true;

                            if (value == CheckBox46.Text)
                                CheckBox46.Checked = true;

                            if (value == CheckBox47.Text)
                                CheckBox47.Checked = true;

                            if (value == CheckBox48.Text)
                                CheckBox48.Checked = true;

                            if (value == CheckBox49.Text)
                                CheckBox49.Checked = true;

                            if (value == CheckBox50.Text)
                                CheckBox50.Checked = true;

                            if (value == CheckBox51.Text)
                                CheckBox51.Checked = true;

                            if (value == CheckBox52.Text)
                                CheckBox52.Checked = true;

                            if (value == CheckBox53.Text)
                                CheckBox53.Checked = true;

                            if (value == CheckBox54.Text)
                                CheckBox54.Checked = true;

                            if (value == CheckBox55.Text)
                                CheckBox55.Checked = true;

                            if (value == CheckBox56.Text)
                                CheckBox56.Checked = true;

                            if (value == CheckBox57.Text)
                                CheckBox57.Checked = true;

                            if (value == CheckBox58.Text)
                                CheckBox58.Checked = true;

                            if (value == CheckBox59.Text)
                                CheckBox59.Checked = true;

                            if (value == CheckBox60.Text)
                                CheckBox60.Checked = true;

                        }//end for

                        for (int i = 68; i < 88; i++)
                        {
                            string value = (string)record[i];

                            if (value == CheckBox61.Text)
                                CheckBox61.Checked = true;

                            if (value == CheckBox62.Text)
                                CheckBox62.Checked = true;

                            if (value == CheckBox63.Text)
                                CheckBox63.Checked = true;

                            if (value == CheckBox64.Text)
                                CheckBox64.Checked = true;

                            if (value == CheckBox65.Text)
                                CheckBox65.Checked = true;

                            if (value == CheckBox66.Text)
                                CheckBox66.Checked = true;

                            if (value == CheckBox67.Text)
                                CheckBox67.Checked = true;

                            if (value == CheckBox68.Text)
                                CheckBox68.Checked = true;

                            if (value == CheckBox69.Text)
                                CheckBox69.Checked = true;

                            if (value == CheckBox70.Text)
                                CheckBox70.Checked = true;

                            if (value == CheckBox71.Text)
                                CheckBox71.Checked = true;

                            if (value == CheckBox72.Text)
                                CheckBox72.Checked = true;

                            if (value == CheckBox73.Text)
                                CheckBox73.Checked = true;

                            if (value == CheckBox74.Text)
                                CheckBox74.Checked = true;

                            if (value == CheckBox75.Text)
                                CheckBox75.Checked = true;

                            if (value == CheckBox76.Text)
                                CheckBox76.Checked = true;

                            if (value == CheckBox77.Text)
                                CheckBox77.Checked = true;

                            if (value == CheckBox78.Text)
                                CheckBox78.Checked = true;

                            if (value == CheckBox79.Text)
                                CheckBox79.Checked = true;

                            if (value == CheckBox80.Text)
                                CheckBox80.Checked = true;

                        }//end for

                        for (int i = 88; i < 108; i++)
                        {
                            string value = (string)record[i];

                            if (value == CheckBox81.Text)
                                CheckBox81.Checked = true;

                            if (value == CheckBox82.Text)
                                CheckBox82.Checked = true;

                            if (value == CheckBox83.Text)
                                CheckBox83.Checked = true;

                            if (value == CheckBox84.Text)
                                CheckBox84.Checked = true;

                            if (value == CheckBox85.Text)
                                CheckBox85.Checked = true;

                            if (value == CheckBox86.Text)
                                CheckBox86.Checked = true;

                            if (value == CheckBox87.Text)
                                CheckBox87.Checked = true;

                            if (value == CheckBox88.Text)
                                CheckBox88.Checked = true;

                            if (value == CheckBox89.Text)
                                CheckBox89.Checked = true;

                            if (value == CheckBox90.Text)
                                CheckBox90.Checked = true;

                            if (value == CheckBox91.Text)
                                CheckBox91.Checked = true;

                            if (value == CheckBox92.Text)
                                CheckBox92.Checked = true;

                            if (value == CheckBox93.Text)
                                CheckBox93.Checked = true;

                            if (value == CheckBox94.Text)
                                CheckBox94.Checked = true;

                            if (value == CheckBox95.Text)
                                CheckBox95.Checked = true;

                            if (value == CheckBox96.Text)
                                CheckBox96.Checked = true;

                            if (value == CheckBox97.Text)
                                CheckBox97.Checked = true;

                            if (value == CheckBox98.Text)
                                CheckBox98.Checked = true;

                            if (value == CheckBox99.Text)
                                CheckBox99.Checked = true;

                            if (value == CheckBox100.Text)
                                CheckBox100.Checked = true;

                        }//end for

                        for (int i = 108; i < 128; i++)
                        {
                            string value = (string)record[i];

                            if (value == CheckBox101.Text)
                                CheckBox101.Checked = true;

                            if (value == CheckBox102.Text)
                                CheckBox102.Checked = true;

                            if (value == CheckBox103.Text)
                                CheckBox103.Checked = true;

                            if (value == CheckBox104.Text)
                                CheckBox104.Checked = true;

                            if (value == CheckBox105.Text)
                                CheckBox105.Checked = true;

                            if (value == CheckBox106.Text)
                                CheckBox106.Checked = true;

                            if (value == CheckBox107.Text)
                                CheckBox107.Checked = true;

                            if (value == CheckBox108.Text)
                                CheckBox108.Checked = true;

                            if (value == CheckBox109.Text)
                                CheckBox109.Checked = true;

                            if (value == CheckBox110.Text)
                                CheckBox110.Checked = true;

                            if (value == CheckBox111.Text)
                                CheckBox111.Checked = true;

                            if (value == CheckBox112.Text)
                                CheckBox112.Checked = true;

                            if (value == CheckBox113.Text)
                                CheckBox113.Checked = true;

                            if (value == CheckBox114.Text)
                                CheckBox114.Checked = true;

                            if (value == CheckBox115.Text)
                                CheckBox115.Checked = true;

                            if (value == CheckBox116.Text)
                                CheckBox116.Checked = true;

                            if (value == CheckBox117.Text)
                                CheckBox117.Checked = true;

                            if (value == CheckBox118.Text)
                                CheckBox118.Checked = true;

                            if (value == CheckBox119.Text)
                                CheckBox119.Checked = true;

                            if (value == CheckBox120.Text)
                                CheckBox120.Checked = true;

                        }//end for 

                        for (int i = 128; i < 148; i++)
                        {
                            string value = (string)record[i];

                            if (value == CheckBox121.Text)
                                CheckBox121.Checked = true;

                            if (value == CheckBox122.Text)
                                CheckBox122.Checked = true;

                            if (value == CheckBox123.Text)
                                CheckBox123.Checked = true;

                            if (value == CheckBox124.Text)
                                CheckBox124.Checked = true;

                            if (value == CheckBox125.Text)
                                CheckBox125.Checked = true;

                            if (value == CheckBox126.Text)
                                CheckBox126.Checked = true;

                            if (value == CheckBox127.Text)
                                CheckBox127.Checked = true;

                            if (value == CheckBox128.Text)
                                CheckBox128.Checked = true;

                            if (value == CheckBox129.Text)
                                CheckBox129.Checked = true;

                            if (value == CheckBox130.Text)
                                CheckBox130.Checked = true;

                            if (value == CheckBox131.Text)
                                CheckBox131.Checked = true;

                            if (value == CheckBox132.Text)
                                CheckBox132.Checked = true;

                            if (value == CheckBox133.Text)
                                CheckBox133.Checked = true;

                            if (value == CheckBox134.Text)
                                CheckBox134.Checked = true;

                            if (value == CheckBox135.Text)
                                CheckBox135.Checked = true;

                            if (value == CheckBox136.Text)
                                CheckBox136.Checked = true;

                            if (value == CheckBox137.Text)
                                CheckBox137.Checked = true;

                            if (value == CheckBox138.Text)
                                CheckBox138.Checked = true;

                            if (value == CheckBox139.Text)
                                CheckBox139.Checked = true;

                            if (value == CheckBox140.Text)
                                CheckBox140.Checked = true;

                        }//end for 

                        for (int i = 148; i < 168; i++)
                        {
                            string value = (string)record[i];

                            if (value == CheckBox141.Text)
                                CheckBox141.Checked = true;

                            if (value == CheckBox142.Text)
                                CheckBox142.Checked = true;

                            if (value == CheckBox143.Text)
                                CheckBox143.Checked = true;

                            if (value == CheckBox144.Text)
                                CheckBox144.Checked = true;

                            if (value == CheckBox145.Text)
                                CheckBox145.Checked = true;

                            if (value == CheckBox146.Text)
                                CheckBox146.Checked = true;

                            if (value == CheckBox147.Text)
                                CheckBox147.Checked = true;

                            if (value == CheckBox148.Text)
                                CheckBox148.Checked = true;

                            if (value == CheckBox149.Text)
                                CheckBox149.Checked = true;

                            if (value == CheckBox150.Text)
                                CheckBox150.Checked = true;

                            if (value == CheckBox151.Text)
                                CheckBox151.Checked = true;

                            if (value == CheckBox152.Text)
                                CheckBox152.Checked = true;

                            if (value == CheckBox153.Text)
                                CheckBox153.Checked = true;

                            if (value == CheckBox154.Text)
                                CheckBox154.Checked = true;

                            if (value == CheckBox155.Text)
                                CheckBox155.Checked = true;

                            if (value == CheckBox156.Text)
                                CheckBox156.Checked = true;

                            if (value == CheckBox157.Text)
                                CheckBox157.Checked = true;

                            if (value == CheckBox158.Text)
                                CheckBox158.Checked = true;

                            if (value == CheckBox159.Text)
                                CheckBox159.Checked = true;

                            if (value == CheckBox160.Text)
                                CheckBox160.Checked = true;

                        }//end for 

                        for (int i = 168; i < 188; i++)
                        {
                            string value = (string)record[i];

                            if (value == CheckBox161.Text)
                                CheckBox161.Checked = true;

                            if (value == CheckBox162.Text)
                                CheckBox162.Checked = true;

                            if (value == CheckBox163.Text)
                                CheckBox163.Checked = true;

                            if (value == CheckBox164.Text)
                                CheckBox164.Checked = true;

                            if (value == CheckBox165.Text)
                                CheckBox165.Checked = true;

                            if (value == CheckBox166.Text)
                                CheckBox166.Checked = true;

                            if (value == CheckBox167.Text)
                                CheckBox167.Checked = true;

                            if (value == CheckBox168.Text)
                                CheckBox168.Checked = true;

                            if (value == CheckBox169.Text)
                                CheckBox169.Checked = true;

                            if (value == CheckBox170.Text)
                                CheckBox170.Checked = true;

                            if (value == CheckBox171.Text)
                                CheckBox171.Checked = true;

                            if (value == CheckBox172.Text)
                                CheckBox172.Checked = true;

                            if (value == CheckBox173.Text)
                                CheckBox173.Checked = true;

                            if (value == CheckBox174.Text)
                                CheckBox174.Checked = true;

                            if (value == CheckBox175.Text)
                                CheckBox175.Checked = true;

                            if (value == CheckBox176.Text)
                                CheckBox176.Checked = true;

                            if (value == CheckBox177.Text)
                                CheckBox177.Checked = true;

                            if (value == CheckBox178.Text)
                                CheckBox178.Checked = true;

                            if (value == CheckBox179.Text)
                                CheckBox179.Checked = true;

                            if (value == CheckBox180.Text)
                                CheckBox180.Checked = true;

                        }//end for 

                        if (!Page.IsPostBack)
                        {
                            TextBox17.InnerText = record[188].ToString();
                            TextBox18.InnerText = record[189].ToString();
                            TextBox19.InnerText = record[190].ToString();
                            TextBox20.InnerText = record[191].ToString();
                            TextBox21.InnerText = record[192].ToString();
                            TextBox22.InnerText = record[193].ToString();

                        }//end if

                    }//end else

                }//end if

            }//end else

            if (Request.Cookies["SkillsCookie"] != null)
            {
                Response.Cookies.Remove("SkillsCookie");

            }//end if

            HttpCookie skillsCookie = new HttpCookie("SkillsCookie");

            skillsCookie.Values.Clear();

            Session sessionObject2 = new Session();

            skillsCookie.Expires = DateTime.Now.AddMinutes(sessionObject2.getSessionTimeLimit());

            int count = 0;

            if (CheckBox161.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox161.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox161.Text);

                }//end else

            }//end outer if


            if (CheckBox162.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox162.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox162.Text);

                }//end else

            }//end outer if


            if (CheckBox163.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox163.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox163.Text);

                }//end else

            }//end outer if


            if (CheckBox164.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox164.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox164.Text);

                }//end else

            }//end outer if


            if (CheckBox165.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox165.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox165.Text);

                }//end else

            }//end outer if


            if (CheckBox166.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox166.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox166.Text);

                }//end else

            }//end outer if


            if (CheckBox167.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox167.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox167.Text);

                }//end else

            }//end outer if


            if (CheckBox168.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox168.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox168.Text);

                }//end else

            }//end outer if


            if (CheckBox169.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox169.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox169.Text);

                }//end else

            }//end outer if

            if (CheckBox170.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox170.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox170.Text);

                }//end else

            }//end outer if

            if (CheckBox171.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox171.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox171.Text);

                }//end else

            }//end outer if

            if (CheckBox172.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox172.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox172.Text);

                }//end else

            }//end outer if

            if (CheckBox173.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox173.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox173.Text);

                }//end else

            }//end outer if

            if (CheckBox174.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox174.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox174.Text);

                }//end else

            }//end outer if

            if (CheckBox175.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox175.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox175.Text);

                }//end else

            }//end outer if

            if (CheckBox176.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox176.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox176.Text);

                }//end else

            }//end outer if

            if (CheckBox177.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox177.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox177.Text);

                }//end else

            }//end outer if

            if (CheckBox178.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox178.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox178.Text);

                }//end else

            }//end outer if

            if (CheckBox179.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox179.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox179.Text);

                }//end else

            }//end outer if

            if (CheckBox180.Checked == true)
            {
                if (count >= 6)
                {
                    CheckBox180.Checked = false;

                    MsgBox("Checkbox selection is limited to six.");

                }//end inner if

                else
                {
                    count++;

                    string skillGroupNumber = "Skill " + count;

                    skillsCookie.Values.Add(skillGroupNumber, CheckBox180.Text);

                }//end else

            }//end outer if


            Response.Cookies.Add(skillsCookie);


            bool recordExists10;

            string errorMessage10;

            Select selectObject10 = new Select();

            recordExists10 = Select.Select_Focus_Analysis_Worksheet(username);

            errorMessage10 = selectObject10.getErrorMessage();

            if (errorMessage10 != null)
            {
                lblError10.Text = errorMessage10;
                lblError10.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists10 == true)
                {
                    string errorMessage2;

                    ArrayList record = new ArrayList();

                    record = Select.Select_Focus_Analysis_Record(username);

                    errorMessage2 = selectObject.getErrorMessage();

                    if (errorMessage2 != null)
                    {
                        lblError10.Text = errorMessage2;
                        lblError10.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                            string nothing = "";

                            if ((record[188] == nothing) || (record[188] == null) || (record[188] == "NULL"))
                            {  
                                if (count == 0)
                                {
                                    TextBox17.InnerText = "";
                                    TextBox18.InnerText = "";
                                    TextBox19.InnerText = "";
                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                }//end if

                                if (count == 1)
                                {
                                    TextBox17.InnerText = "";
                                    TextBox18.InnerText = "";
                                    TextBox19.InnerText = "";
                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                    string skillGroup1 = skillsCookie.Values.Get("Skill 1");

                                    if (skillGroup1 == null)
                                    {
                                        ClientScript.RegisterStartupScript(typeof(Page), "autoPostback", ClientScript.GetPostBackEventReference(this, String.Empty), true);

                                        skillGroup1 = Request.Cookies["SkillsCookie"]["Skill 1"];

                                    }//end if

                                    if (TextBox17.InnerText != skillGroup1)
                                    {

                                    }//end if

                                    if (TextBox17.InnerText == nothing)
                                    {
                                        TextBox17.InnerText = skillGroup1;

                                    }//end else

                                    TextBox18.InnerText = "";
                                    TextBox19.InnerText = "";
                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                }//end if

                                if (count == 2)
                                {
                                    TextBox17.InnerText = "";
                                    TextBox18.InnerText = "";
                                    TextBox19.InnerText = "";
                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                    string skillGroup1 = skillsCookie.Values.Get("Skill 1");

                                    if (skillGroup1 == null)
                                    {
                                        ClientScript.RegisterStartupScript(typeof(Page), "autoPostback", ClientScript.GetPostBackEventReference(this, String.Empty), true);

                                        skillGroup1 = Request.Cookies["SkillsCookie"]["Skill 1"];

                                    }//end if

                                    string skillGroup2 = skillsCookie.Values.Get("Skill 2");

                                    if (skillGroup2 == null)
                                    {
                                        skillGroup2 = Request.Cookies["SkillsCookie"]["Skill 2"];

                                    }//end if

                                    if (TextBox17.InnerText != skillGroup1)
                                    {

                                    }//end if

                                    if (TextBox17.InnerText == nothing)
                                    {
                                        TextBox17.InnerText = skillGroup1;

                                    }//end else

                                    if (TextBox18.InnerText != skillGroup2)
                                    {

                                    }//end if

                                    if (TextBox18.InnerText == nothing)
                                    {
                                        TextBox18.InnerText = skillGroup2;

                                    }//end else

                                    TextBox19.InnerText = "";
                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                }//end if

                                if (count == 3)
                                {
                                    TextBox17.InnerText = "";
                                    TextBox18.InnerText = "";
                                    TextBox19.InnerText = "";
                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                    string skillGroup1 = skillsCookie.Values.Get("Skill 1");

                                    if (skillGroup1 == null)
                                    {
                                        ClientScript.RegisterStartupScript(typeof(Page), "autoPostback", ClientScript.GetPostBackEventReference(this, String.Empty), true);

                                        skillGroup1 = Request.Cookies["SkillsCookie"]["Skill 1"];

                                    }//end if

                                    string skillGroup2 = skillsCookie.Values.Get("Skill 2");

                                    if (skillGroup2 == null)
                                    {
                                        skillGroup2 = Request.Cookies["SkillsCookie"]["Skill 2"];

                                    }//end if

                                    string skillGroup3 = skillsCookie.Values.Get("Skill 3");

                                    if (skillGroup3 == null)
                                    {
                                        skillGroup3 = Request.Cookies["SkillsCookie"]["Skill 3"];

                                    }//end if

                                    if (TextBox17.InnerText != skillGroup1)
                                    {

                                    }//end if

                                    if (TextBox17.InnerText == nothing)
                                    {
                                        TextBox17.InnerText = skillGroup1;

                                    }//end else

                                    if (TextBox18.InnerText != skillGroup2)
                                    {

                                    }//end if

                                    if (TextBox18.InnerText == nothing)
                                    {
                                        TextBox18.InnerText = skillGroup2;

                                    }//end else

                                    if (TextBox19.InnerText != skillGroup3)
                                    {

                                    }//end if

                                    if (TextBox19.InnerText == nothing)
                                    {
                                        TextBox19.InnerText = skillGroup3;

                                    }//end else

                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                }//end if

                                if (count == 4)
                                {
                                    TextBox17.InnerText = "";
                                    TextBox18.InnerText = "";
                                    TextBox19.InnerText = "";
                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                    string skillGroup1 = skillsCookie.Values.Get("Skill 1");

                                    if (skillGroup1 == null)
                                    {
                                        ClientScript.RegisterStartupScript(typeof(Page), "autoPostback", ClientScript.GetPostBackEventReference(this, String.Empty), true);

                                        skillGroup1 = Request.Cookies["SkillsCookie"]["Skill 1"];

                                    }//end if

                                    string skillGroup2 = skillsCookie.Values.Get("Skill 2");

                                    if (skillGroup2 == null)
                                    {
                                        skillGroup2 = Request.Cookies["SkillsCookie"]["Skill 2"];

                                    }//end if

                                    string skillGroup3 = skillsCookie.Values.Get("Skill 3");

                                    if (skillGroup3 == null)
                                    {
                                        skillGroup3 = Request.Cookies["SkillsCookie"]["Skill 3"];

                                    }//end if

                                    string skillGroup4 = skillsCookie.Values.Get("Skill 4");

                                    if (skillGroup4 == null)
                                    {
                                        skillGroup4 = Request.Cookies["SkillsCookie"]["Skill 4"];

                                    }//end if

                                    if (TextBox17.InnerText != skillGroup1)
                                    {

                                    }//end if

                                    if (TextBox17.InnerText == nothing)
                                    {
                                        TextBox17.InnerText = skillGroup1;

                                    }//end else

                                    if (TextBox18.InnerText != skillGroup2)
                                    {

                                    }//end if

                                    if (TextBox18.InnerText == nothing)
                                    {
                                        TextBox18.InnerText = skillGroup2;

                                    }//end else

                                    if (TextBox19.InnerText != skillGroup3)
                                    {

                                    }//end if

                                    if (TextBox19.InnerText == nothing)
                                    {
                                        TextBox19.InnerText = skillGroup3;

                                    }//end else

                                    if (TextBox20.InnerText != skillGroup4)
                                    {

                                    }//end if

                                    if (TextBox20.InnerText == nothing)
                                    {
                                        TextBox20.InnerText = skillGroup4;

                                    }//end else

                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                }//end if

                                if (count == 5)
                                {
                                    TextBox17.InnerText = "";
                                    TextBox18.InnerText = "";
                                    TextBox19.InnerText = "";
                                    TextBox20.InnerText = "";
                                    TextBox21.InnerText = "";
                                    TextBox22.InnerText = "";

                                    string skillGroup1 = skillsCookie.Values.Get("Skill 1");

                                    if (skillGroup1 == null)
                                    {
                                        ClientScript.RegisterStartupScript(typeof(Page), "autoPostback", ClientScript.GetPostBackEventReference(this, String.Empty), true);

                                        skillGroup1 = Request.Cookies["SkillsCookie"]["Skill 1"];

                                    }//end if

                                    string skillGroup2 = skillsCookie.Values.Get("Skill 2");

                                    if (skillGroup2 == null)
                                    {
                                        skillGroup2 = Request.Cookies["SkillsCookie"]["Skill 2"];

                                    }//end if

                                    string skillGroup3 = skillsCookie.Values.Get("Skill 3");

                                    if (skillGroup3 == null)
                                    {
                                        skillGroup3 = Request.Cookies["SkillsCookie"]["Skill 3"];

                                    }//end if

                                    string skillGroup4 = skillsCookie.Values.Get("Skill 4");

                                    if (skillGroup4 == null)
                                    {
                                        skillGroup4 = Request.Cookies["SkillsCookie"]["Skill 4"];

                                    }//end if

                                    string skillGroup5 = skillsCookie.Values.Get("Skill 5");

                                    if (skillGroup5 == null)
                                    {
                                        skillGroup5 = Request.Cookies["SkillsCookie"]["Skill 5"];

                                    }//end if

                                    if (TextBox17.InnerText != skillGroup1)
                                    {

                                    }//end if

                                    if (TextBox17.InnerText == nothing)
                                    {
                                        TextBox17.InnerText = skillGroup1;

                                    }//end else

                                    if (TextBox18.InnerText != skillGroup2)
                                    {

                                    }//end if

                                    if (TextBox18.InnerText == nothing)
                                    {
                                        TextBox18.InnerText = skillGroup2;

                                    }//end else

                                    if (TextBox19.InnerText != skillGroup3)
                                    {

                                    }//end if

                                    if (TextBox19.InnerText == nothing)
                                    {
                                        TextBox19.InnerText = skillGroup3;

                                    }//end else

                                    if (TextBox20.InnerText != skillGroup4)
                                    {

                                    }//end if

                                    if (TextBox20.InnerText == nothing)
                                    {
                                        TextBox20.InnerText = skillGroup4;

                                    }//end else

                                    if (TextBox21.InnerText != skillGroup5)
                                    {

                                    }//end if

                                    if (TextBox21.InnerText == nothing)
                                    {
                                        TextBox21.InnerText = skillGroup5;

                                    }//end else

                                    TextBox22.InnerText = "";

                                }//end if

                                if (count == 6)
                                {
                                    string skillGroup1 = skillsCookie.Values.Get("Skill 1");

                                    if (skillGroup1 != TextBox17.InnerText)
                                    {

                                    }//end if

                                    else
                                    {
                                        TextBox17.InnerText = "";
                                        TextBox18.InnerText = "";
                                        TextBox19.InnerText = "";
                                        TextBox20.InnerText = "";
                                        TextBox21.InnerText = "";
                                        TextBox22.InnerText = "";

                                        if (skillGroup1 == null)
                                        {
                                            ClientScript.RegisterStartupScript(typeof(Page), "autoPostback", ClientScript.GetPostBackEventReference(this, String.Empty), true);

                                            skillGroup1 = Request.Cookies["SkillsCookie"]["Skill 1"];

                                        }//end if

                                    }//end else

                                    string skillGroup2 = skillsCookie.Values.Get("Skill 2");

                                    if (skillGroup2 == null)
                                    {
                                        skillGroup2 = Request.Cookies["SkillsCookie"]["Skill 2"];

                                    }//end if

                                    string skillGroup3 = skillsCookie.Values.Get("Skill 3");

                                    if (skillGroup3 == null)
                                    {
                                        skillGroup3 = Request.Cookies["SkillsCookie"]["Skill 3"];

                                    }//end if

                                    string skillGroup4 = skillsCookie.Values.Get("Skill 4");

                                    if (skillGroup4 == null)
                                    {
                                        skillGroup4 = Request.Cookies["SkillsCookie"]["Skill 4"];

                                    }//end if

                                    string skillGroup5 = skillsCookie.Values.Get("Skill 5");

                                    if (skillGroup5 == null)
                                    {
                                        skillGroup5 = Request.Cookies["SkillsCookie"]["Skill 5"];

                                    }//end if

                                    string skillGroup6 = skillsCookie.Values.Get("Skill 6");

                                    if (skillGroup6 == null)
                                    {
                                        skillGroup6 = Request.Cookies["SkillsCookie"]["Skill 6"];

                                    }//end if


                                    if (TextBox17.InnerText != skillGroup1)
                                    {

                                    }//end if

                                    if (TextBox17.InnerText == nothing)
                                    {
                                        TextBox17.InnerText = skillGroup1;

                                    }//end else

                                    if (TextBox18.InnerText != skillGroup2)
                                    {

                                    }//end if

                                    if (TextBox18.InnerText == nothing)
                                    {
                                        TextBox18.InnerText = skillGroup2;

                                    }//end else

                                    if (TextBox19.InnerText != skillGroup3)
                                    {

                                    }//end if

                                    if (TextBox19.InnerText == nothing)
                                    {
                                        TextBox19.InnerText = skillGroup3;

                                    }//end else

                                    if (TextBox20.InnerText != skillGroup4)
                                    {

                                    }//end if

                                    if (TextBox20.InnerText == nothing)
                                    {
                                        TextBox20.InnerText = skillGroup4;

                                    }//end else

                                    if (TextBox21.InnerText != skillGroup5)
                                    {

                                    }//end if

                                    if (TextBox21.InnerText == nothing)
                                    {
                                        TextBox21.InnerText = skillGroup5;

                                    }//end else

                                    if (TextBox22.InnerText != skillGroup6)
                                    {

                                    }//end if

                                    if (TextBox22.InnerText == nothing)
                                    {
                                        TextBox22.InnerText = skillGroup6;

                                    }//end else

                                }//end if

                            }//end if

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

            if (selectionCount == 0)
            {
                MsgBox("Invalid. You must select at least one skill group from the selection.");

            }//end if

            else
            {
                string Q1_1 = "";
                string Q1_2 = "";
                string Q1_3 = "";
                string Q1_4 = "";
                string Q1_5 = "";
                string Q1_6 = "";
                string Q1_7 = "";
                string Q1_8 = "";
                string Q1_9 = "";
                string Q1_10 = "";
                string Q1_11 = "";
                string Q1_12 = "";
                string Q1_13 = "";
                string Q1_14 = "";
                string Q1_15 = "";
                string Q1_16 = "";
                string Q1_17 = "";
                string Q1_18 = "";
                string Q1_19 = "";
                string Q1_20 = "";

                if (CheckBox1.Checked == true)
                {
                    Q1_1 = CheckBox1.Text;

                }//end if

                if (CheckBox2.Checked == true)
                {
                    Q1_2 = CheckBox2.Text;

                }//end if

                if (CheckBox3.Checked == true)
                {
                    Q1_3 = CheckBox3.Text;

                }//end if

                if (CheckBox4.Checked == true)
                {
                    Q1_4 = CheckBox4.Text;

                }//end if

                if (CheckBox5.Checked == true)
                {
                    Q1_5 = CheckBox5.Text;

                }//end if

                if (CheckBox6.Checked == true)
                {
                    Q1_6 = CheckBox6.Text;

                }//end if

                if (CheckBox7.Checked == true)
                {
                    Q1_7 = CheckBox7.Text;

                }//end if

                if (CheckBox8.Checked == true)
                {
                    Q1_8 = CheckBox8.Text;

                }//end if

                if (CheckBox9.Checked == true)
                {
                    Q1_9 = CheckBox9.Text;

                }//end if

                if (CheckBox10.Checked == true)
                {
                    Q1_10 = CheckBox10.Text;

                }//end if

                if (CheckBox11.Checked == true)
                {
                    Q1_11 = CheckBox11.Text;

                }//end if

                if (CheckBox12.Checked == true)
                {
                    Q1_12 = CheckBox12.Text;

                }//end if

                if (CheckBox13.Checked == true)
                {
                    Q1_13 = CheckBox13.Text;

                }//end if

                if (CheckBox14.Checked == true)
                {
                    Q1_14 = CheckBox14.Text;

                }//end if

                if (CheckBox15.Checked == true)
                {
                    Q1_15 = CheckBox15.Text;

                }//end if

                if (CheckBox16.Checked == true)
                {
                    Q1_16 = CheckBox16.Text;

                }//end if

                if (CheckBox17.Checked == true)
                {
                    Q1_17 = CheckBox17.Text;

                }//end if

                if (CheckBox18.Checked == true)
                {
                    Q1_18 = CheckBox18.Text;

                }//end if

                if (CheckBox19.Checked == true)
                {
                    Q1_19 = CheckBox19.Text;

                }//end if

                if (CheckBox20.Checked == true)
                {
                    Q1_20 = CheckBox20.Text;

                }//end if

                Validate validationObject = new Validate();

                Q1_1 = validationObject.Truncate(Q1_1, 900);
                Q1_2 = validationObject.Truncate(Q1_2, 900);
                Q1_3 = validationObject.Truncate(Q1_3, 900);
                Q1_4 = validationObject.Truncate(Q1_4, 900);
                Q1_5 = validationObject.Truncate(Q1_5, 900);
                Q1_6 = validationObject.Truncate(Q1_6, 900);
                Q1_7 = validationObject.Truncate(Q1_7, 900);
                Q1_8 = validationObject.Truncate(Q1_8, 900);
                Q1_9 = validationObject.Truncate(Q1_9, 900);
                Q1_10 = validationObject.Truncate(Q1_10, 900);
                Q1_11 = validationObject.Truncate(Q1_11, 900);
                Q1_12 = validationObject.Truncate(Q1_12, 900);
                Q1_13 = validationObject.Truncate(Q1_13, 900);
                Q1_14 = validationObject.Truncate(Q1_14, 900);
                Q1_15 = validationObject.Truncate(Q1_15, 900);
                Q1_16 = validationObject.Truncate(Q1_16, 900);
                Q1_17 = validationObject.Truncate(Q1_17, 900);
                Q1_18 = validationObject.Truncate(Q1_18, 900);
                Q1_19 = validationObject.Truncate(Q1_19, 900);
                Q1_20 = validationObject.Truncate(Q1_20, 900);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet(username, Q1_1, Q1_2, Q1_3, Q1_4, Q1_5, Q1_6, Q1_7, Q1_8, Q1_9, Q1_10, Q1_11, Q1_12, Q1_13, Q1_14, Q1_15, Q1_16, Q1_17, Q1_18, Q1_19, Q1_20);

                if (errorMessage != null)
                {
                    lblError.Text = errorMessage;
                    lblError.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View2);

                }//end else

            }//end else

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

            if (CheckBox21.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox22.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox23.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox24.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox25.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox26.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox27.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox28.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox29.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox30.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox31.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox32.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox33.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox34.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox35.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox36.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox37.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox38.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox39.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox40.Checked == true)
            {
                selectionCount++;

            }//end if

            if (selectionCount == 0)
            {
                MsgBox("Invalid. You must select at least one skill group from the selection.");

            }//end if

            else
            {
                string Q2_1 = "";
                string Q2_2 = "";
                string Q2_3 = "";
                string Q2_4 = "";
                string Q2_5 = "";
                string Q2_6 = "";
                string Q2_7 = "";
                string Q2_8 = "";
                string Q2_9 = "";
                string Q2_10 = "";
                string Q2_11 = "";
                string Q2_12 = "";
                string Q2_13 = "";
                string Q2_14 = "";
                string Q2_15 = "";
                string Q2_16 = "";
                string Q2_17 = "";
                string Q2_18 = "";
                string Q2_19 = "";
                string Q2_20 = "";

                if (CheckBox21.Checked == true)
                {
                    Q2_1 = CheckBox21.Text;

                }//end if

                if (CheckBox22.Checked == true)
                {
                    Q2_2 = CheckBox22.Text;

                }//end if

                if (CheckBox23.Checked == true)
                {
                    Q2_3 = CheckBox23.Text;

                }//end if

                if (CheckBox24.Checked == true)
                {
                    Q2_4 = CheckBox24.Text;

                }//end if

                if (CheckBox25.Checked == true)
                {
                    Q2_5 = CheckBox25.Text;

                }//end if

                if (CheckBox26.Checked == true)
                {
                    Q2_6 = CheckBox26.Text;

                }//end if

                if (CheckBox27.Checked == true)
                {
                    Q2_7 = CheckBox27.Text;

                }//end if

                if (CheckBox28.Checked == true)
                {
                    Q2_8 = CheckBox28.Text;

                }//end if

                if (CheckBox29.Checked == true)
                {
                    Q2_9 = CheckBox29.Text;

                }//end if

                if (CheckBox30.Checked == true)
                {
                    Q2_10 = CheckBox30.Text;

                }//end if

                if (CheckBox31.Checked == true)
                {
                    Q2_11 = CheckBox31.Text;

                }//end if

                if (CheckBox32.Checked == true)
                {
                    Q2_12 = CheckBox32.Text;

                }//end if

                if (CheckBox33.Checked == true)
                {
                    Q2_13 = CheckBox33.Text;

                }//end if

                if (CheckBox34.Checked == true)
                {
                    Q2_14 = CheckBox34.Text;

                }//end if

                if (CheckBox35.Checked == true)
                {
                    Q2_15 = CheckBox35.Text;

                }//end if

                if (CheckBox36.Checked == true)
                {
                    Q2_16 = CheckBox36.Text;

                }//end if

                if (CheckBox37.Checked == true)
                {
                    Q2_17 = CheckBox37.Text;

                }//end if

                if (CheckBox38.Checked == true)
                {
                    Q2_18 = CheckBox38.Text;

                }//end if

                if (CheckBox39.Checked == true)
                {
                    Q2_19 = CheckBox39.Text;

                }//end if

                if (CheckBox40.Checked == true)
                {
                    Q2_20 = CheckBox40.Text;

                }//end if

                Validate validationObject = new Validate();

                Q2_1 = validationObject.Truncate(Q2_1, 900);
                Q2_2 = validationObject.Truncate(Q2_2, 900);
                Q2_3 = validationObject.Truncate(Q2_3, 900);
                Q2_4 = validationObject.Truncate(Q2_4, 900);
                Q2_5 = validationObject.Truncate(Q2_5, 900);
                Q2_6 = validationObject.Truncate(Q2_6, 900);
                Q2_7 = validationObject.Truncate(Q2_7, 900);
                Q2_8 = validationObject.Truncate(Q2_8, 900);
                Q2_9 = validationObject.Truncate(Q2_9, 900);
                Q2_10 = validationObject.Truncate(Q2_10, 900);
                Q2_11 = validationObject.Truncate(Q2_11, 900);
                Q2_12 = validationObject.Truncate(Q2_12, 900);
                Q2_13 = validationObject.Truncate(Q2_13, 900);
                Q2_14 = validationObject.Truncate(Q2_14, 900);
                Q2_15 = validationObject.Truncate(Q2_15, 900);
                Q2_16 = validationObject.Truncate(Q2_16, 900);
                Q2_17 = validationObject.Truncate(Q2_17, 900);
                Q2_18 = validationObject.Truncate(Q2_18, 900);
                Q2_19 = validationObject.Truncate(Q2_19, 900);
                Q2_20 = validationObject.Truncate(Q2_20, 900);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet2(username, Q2_1, Q2_2, Q2_3, Q2_4, Q2_5, Q2_6, Q2_7, Q2_8, Q2_9, Q2_10, Q2_11, Q2_12, Q2_13, Q2_14, Q2_15, Q2_16, Q2_17, Q2_18, Q2_19, Q2_20);

                if (errorMessage != null)
                {
                    lblError2.Text = errorMessage;
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

        protected void btnSubmit3_Click(object sender, EventArgs e)
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

            if (CheckBox41.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox42.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox43.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox44.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox45.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox46.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox47.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox48.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox49.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox50.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox51.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox52.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox53.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox54.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox55.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox56.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox57.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox58.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox59.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox60.Checked == true)
            {
                selectionCount++;

            }//end if

            if (selectionCount == 0)
            {
                MsgBox("Invalid. You must select at least one skill group from the selection.");

            }//end if

            else
            {
                string Q3_1 = "";
                string Q3_2 = "";
                string Q3_3 = "";
                string Q3_4 = "";
                string Q3_5 = "";
                string Q3_6 = "";
                string Q3_7 = "";
                string Q3_8 = "";
                string Q3_9 = "";
                string Q3_10 = "";
                string Q3_11 = "";
                string Q3_12 = "";
                string Q3_13 = "";
                string Q3_14 = "";
                string Q3_15 = "";
                string Q3_16 = "";
                string Q3_17 = "";
                string Q3_18 = "";
                string Q3_19 = "";
                string Q3_20 = "";

                if (CheckBox41.Checked == true)
                {
                    Q3_1 = CheckBox41.Text;

                }//end if

                if (CheckBox42.Checked == true)
                {
                    Q3_2 = CheckBox42.Text;

                }//end if

                if (CheckBox43.Checked == true)
                {
                    Q3_3 = CheckBox43.Text;

                }//end if

                if (CheckBox44.Checked == true)
                {
                    Q3_4 = CheckBox44.Text;

                }//end if

                if (CheckBox45.Checked == true)
                {
                    Q3_5 = CheckBox45.Text;

                }//end if

                if (CheckBox46.Checked == true)
                {
                    Q3_6 = CheckBox46.Text;

                }//end if

                if (CheckBox47.Checked == true)
                {
                    Q3_7 = CheckBox47.Text;

                }//end if

                if (CheckBox48.Checked == true)
                {
                    Q3_8 = CheckBox48.Text;

                }//end if

                if (CheckBox49.Checked == true)
                {
                    Q3_9 = CheckBox49.Text;

                }//end if

                if (CheckBox50.Checked == true)
                {
                    Q3_10 = CheckBox50.Text;

                }//end if

                if (CheckBox51.Checked == true)
                {
                    Q3_11 = CheckBox51.Text;

                }//end if

                if (CheckBox52.Checked == true)
                {
                    Q3_12 = CheckBox52.Text;

                }//end if

                if (CheckBox53.Checked == true)
                {
                    Q3_13 = CheckBox53.Text;

                }//end if

                if (CheckBox54.Checked == true)
                {
                    Q3_14 = CheckBox54.Text;

                }//end if

                if (CheckBox55.Checked == true)
                {
                    Q3_15 = CheckBox55.Text;

                }//end if

                if (CheckBox56.Checked == true)
                {
                    Q3_16 = CheckBox56.Text;

                }//end if

                if (CheckBox57.Checked == true)
                {
                    Q3_17 = CheckBox57.Text;

                }//end if

                if (CheckBox58.Checked == true)
                {
                    Q3_18 = CheckBox58.Text;

                }//end if

                if (CheckBox59.Checked == true)
                {
                    Q3_19 = CheckBox59.Text;

                }//end if

                if (CheckBox60.Checked == true)
                {
                    Q3_20 = CheckBox60.Text;

                }//end if

                Validate validationObject = new Validate();

                Q3_1 = validationObject.Truncate(Q3_1, 900);
                Q3_2 = validationObject.Truncate(Q3_2, 900);
                Q3_3 = validationObject.Truncate(Q3_3, 900);
                Q3_4 = validationObject.Truncate(Q3_4, 900);
                Q3_5 = validationObject.Truncate(Q3_5, 900);
                Q3_6 = validationObject.Truncate(Q3_6, 900);
                Q3_7 = validationObject.Truncate(Q3_7, 900);
                Q3_8 = validationObject.Truncate(Q3_8, 900);
                Q3_9 = validationObject.Truncate(Q3_9, 900);
                Q3_10 = validationObject.Truncate(Q3_10, 900);
                Q3_11 = validationObject.Truncate(Q3_11, 900);
                Q3_12 = validationObject.Truncate(Q3_12, 900);
                Q3_13 = validationObject.Truncate(Q3_13, 900);
                Q3_14 = validationObject.Truncate(Q3_14, 900);
                Q3_15 = validationObject.Truncate(Q3_15, 900);
                Q3_16 = validationObject.Truncate(Q3_16, 900);
                Q3_17 = validationObject.Truncate(Q3_17, 900);
                Q3_18 = validationObject.Truncate(Q3_18, 900);
                Q3_19 = validationObject.Truncate(Q3_19, 900);
                Q3_20 = validationObject.Truncate(Q3_20, 900);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet3(username, Q3_1, Q3_2, Q3_3, Q3_4, Q3_5, Q3_6, Q3_7, Q3_8, Q3_9, Q3_10, Q3_11, Q3_12, Q3_13, Q3_14, Q3_15, Q3_16, Q3_17, Q3_18, Q3_19, Q3_20);

                if (errorMessage != null)
                {
                    lblError3.Text = errorMessage;
                    lblError3.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View4);

                }//end else

            }//end else

        }//end event

        protected void btnContinue3_Click(object sender, EventArgs e)
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

            MultiView1.SetActiveView(View4);

        }//end event

        protected void btnSubmit4_Click(object sender, EventArgs e)
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

            if (CheckBox61.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox62.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox63.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox64.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox65.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox66.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox67.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox68.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox69.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox70.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox71.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox72.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox73.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox74.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox75.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox76.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox77.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox78.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox79.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox80.Checked == true)
            {
                selectionCount++;

            }//end if

            if (selectionCount == 0)
            {
                MsgBox("Invalid. You must select at least one skill group from the selection.");

            }//end if

            else
            {
                string Q4_1 = "";
                string Q4_2 = "";
                string Q4_3 = "";
                string Q4_4 = "";
                string Q4_5 = "";
                string Q4_6 = "";
                string Q4_7 = "";
                string Q4_8 = "";
                string Q4_9 = "";
                string Q4_10 = "";
                string Q4_11 = "";
                string Q4_12 = "";
                string Q4_13 = "";
                string Q4_14 = "";
                string Q4_15 = "";
                string Q4_16 = "";
                string Q4_17 = "";
                string Q4_18 = "";
                string Q4_19 = "";
                string Q4_20 = "";

                if (CheckBox61.Checked == true)
                {
                    Q4_1 = CheckBox61.Text;

                }//end if

                if (CheckBox62.Checked == true)
                {
                    Q4_2 = CheckBox62.Text;

                }//end if

                if (CheckBox63.Checked == true)
                {
                    Q4_3 = CheckBox63.Text;

                }//end if

                if (CheckBox64.Checked == true)
                {
                    Q4_4 = CheckBox64.Text;

                }//end if

                if (CheckBox65.Checked == true)
                {
                    Q4_5 = CheckBox65.Text;

                }//end if

                if (CheckBox66.Checked == true)
                {
                    Q4_6 = CheckBox66.Text;

                }//end if

                if (CheckBox67.Checked == true)
                {
                    Q4_7 = CheckBox67.Text;

                }//end if

                if (CheckBox68.Checked == true)
                {
                    Q4_8 = CheckBox68.Text;

                }//end if

                if (CheckBox69.Checked == true)
                {
                    Q4_9 = CheckBox69.Text;

                }//end if

                if (CheckBox70.Checked == true)
                {
                    Q4_10 = CheckBox70.Text;

                }//end if

                if (CheckBox71.Checked == true)
                {
                    Q4_11 = CheckBox71.Text;

                }//end if

                if (CheckBox72.Checked == true)
                {
                    Q4_12 = CheckBox72.Text;

                }//end if

                if (CheckBox73.Checked == true)
                {
                    Q4_13 = CheckBox73.Text;

                }//end if

                if (CheckBox74.Checked == true)
                {
                    Q4_14 = CheckBox74.Text;

                }//end if

                if (CheckBox75.Checked == true)
                {
                    Q4_15 = CheckBox75.Text;

                }//end if

                if (CheckBox76.Checked == true)
                {
                    Q4_16 = CheckBox76.Text;

                }//end if

                if (CheckBox77.Checked == true)
                {
                    Q4_17 = CheckBox77.Text;

                }//end if

                if (CheckBox78.Checked == true)
                {
                    Q4_18 = CheckBox78.Text;

                }//end if

                if (CheckBox79.Checked == true)
                {
                    Q4_19 = CheckBox79.Text;

                }//end if

                if (CheckBox80.Checked == true)
                {
                    Q4_20 = CheckBox80.Text;

                }//end if

                Validate validationObject = new Validate();

                Q4_1 = validationObject.Truncate(Q4_1, 350);
                Q4_2 = validationObject.Truncate(Q4_2, 350);
                Q4_3 = validationObject.Truncate(Q4_3, 350);
                Q4_4 = validationObject.Truncate(Q4_4, 350);
                Q4_5 = validationObject.Truncate(Q4_5, 350);
                Q4_6 = validationObject.Truncate(Q4_6, 350);
                Q4_7 = validationObject.Truncate(Q4_7, 350);
                Q4_8 = validationObject.Truncate(Q4_8, 350);
                Q4_9 = validationObject.Truncate(Q4_9, 350);
                Q4_10 = validationObject.Truncate(Q4_10, 350);
                Q4_11 = validationObject.Truncate(Q4_11, 350);
                Q4_12 = validationObject.Truncate(Q4_12, 350);
                Q4_13 = validationObject.Truncate(Q4_13, 350);
                Q4_14 = validationObject.Truncate(Q4_14, 350);
                Q4_15 = validationObject.Truncate(Q4_15, 350);
                Q4_16 = validationObject.Truncate(Q4_16, 350);
                Q4_17 = validationObject.Truncate(Q4_17, 350);
                Q4_18 = validationObject.Truncate(Q4_18, 350);
                Q4_19 = validationObject.Truncate(Q4_19, 350);
                Q4_20 = validationObject.Truncate(Q4_20, 350);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet4(username, Q4_1, Q4_2, Q4_3, Q4_4, Q4_5, Q4_6, Q4_7, Q4_8, Q4_9, Q4_10, Q4_11, Q4_12, Q4_13, Q4_14, Q4_15, Q4_16, Q4_17, Q4_18, Q4_19, Q4_20);

                if (errorMessage != null)
                {
                    lblError4.Text = errorMessage;
                    lblError4.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View5);

                }//end else

            }//end else

        }//end event

        protected void btnContinue4_Click(object sender, EventArgs e)
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

            MultiView1.SetActiveView(View5);

        }//end event

        protected void btnSubmit5_Click(object sender, EventArgs e)
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

            if (CheckBox81.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox82.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox83.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox84.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox85.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox86.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox87.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox88.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox89.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox90.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox91.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox92.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox93.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox94.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox95.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox96.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox97.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox98.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox99.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox100.Checked == true)
            {
                selectionCount++;

            }//end if

            if (selectionCount == 0)
            {
                MsgBox("Invalid. You must select at least one skill group from the selection.");

            }//end if

            else
            {
                string Q5_1 = "";
                string Q5_2 = "";
                string Q5_3 = "";
                string Q5_4 = "";
                string Q5_5 = "";
                string Q5_6 = "";
                string Q5_7 = "";
                string Q5_8 = "";
                string Q5_9 = "";
                string Q5_10 = "";
                string Q5_11 = "";
                string Q5_12 = "";
                string Q5_13 = "";
                string Q5_14 = "";
                string Q5_15 = "";
                string Q5_16 = "";
                string Q5_17 = "";
                string Q5_18 = "";
                string Q5_19 = "";
                string Q5_20 = "";

                if (CheckBox81.Checked == true)
                {
                    Q5_1 = CheckBox81.Text;

                }//end if

                if (CheckBox82.Checked == true)
                {
                    Q5_2 = CheckBox82.Text;

                }//end if

                if (CheckBox83.Checked == true)
                {
                    Q5_3 = CheckBox83.Text;

                }//end if

                if (CheckBox84.Checked == true)
                {
                    Q5_4 = CheckBox84.Text;

                }//end if

                if (CheckBox85.Checked == true)
                {
                    Q5_5 = CheckBox85.Text;

                }//end if

                if (CheckBox86.Checked == true)
                {
                    Q5_6 = CheckBox86.Text;

                }//end if

                if (CheckBox87.Checked == true)
                {
                    Q5_7 = CheckBox87.Text;

                }//end if

                if (CheckBox88.Checked == true)
                {
                    Q5_8 = CheckBox88.Text;

                }//end if

                if (CheckBox89.Checked == true)
                {
                    Q5_9 = CheckBox89.Text;

                }//end if

                if (CheckBox90.Checked == true)
                {
                    Q5_10 = CheckBox90.Text;

                }//end if

                if (CheckBox91.Checked == true)
                {
                    Q5_11 = CheckBox91.Text;

                }//end if

                if (CheckBox92.Checked == true)
                {
                    Q5_12 = CheckBox92.Text;

                }//end if

                if (CheckBox93.Checked == true)
                {
                    Q5_13 = CheckBox93.Text;

                }//end if

                if (CheckBox94.Checked == true)
                {
                    Q5_14 = CheckBox94.Text;

                }//end if

                if (CheckBox95.Checked == true)
                {
                    Q5_15 = CheckBox95.Text;

                }//end if

                if (CheckBox96.Checked == true)
                {
                    Q5_16 = CheckBox96.Text;

                }//end if

                if (CheckBox97.Checked == true)
                {
                    Q5_17 = CheckBox97.Text;

                }//end if

                if (CheckBox98.Checked == true)
                {
                    Q5_18 = CheckBox98.Text;

                }//end if

                if (CheckBox99.Checked == true)
                {
                    Q5_19 = CheckBox99.Text;

                }//end if

                if (CheckBox100.Checked == true)
                {
                    Q5_20 = CheckBox100.Text;

                }//end if

                Validate validationObject = new Validate();

                Q5_1 = validationObject.Truncate(Q5_1, 350);
                Q5_2 = validationObject.Truncate(Q5_2, 350);
                Q5_3 = validationObject.Truncate(Q5_3, 350);
                Q5_4 = validationObject.Truncate(Q5_4, 350);
                Q5_5 = validationObject.Truncate(Q5_5, 350);
                Q5_6 = validationObject.Truncate(Q5_6, 350);
                Q5_7 = validationObject.Truncate(Q5_7, 350);
                Q5_8 = validationObject.Truncate(Q5_8, 350);
                Q5_9 = validationObject.Truncate(Q5_9, 350);
                Q5_10 = validationObject.Truncate(Q5_10, 350);
                Q5_11 = validationObject.Truncate(Q5_11, 350);
                Q5_12 = validationObject.Truncate(Q5_12, 350);
                Q5_13 = validationObject.Truncate(Q5_13, 350);
                Q5_14 = validationObject.Truncate(Q5_14, 350);
                Q5_15 = validationObject.Truncate(Q5_15, 350);
                Q5_16 = validationObject.Truncate(Q5_16, 350);
                Q5_17 = validationObject.Truncate(Q5_17, 350);
                Q5_18 = validationObject.Truncate(Q5_18, 350);
                Q5_19 = validationObject.Truncate(Q5_19, 350);
                Q5_20 = validationObject.Truncate(Q5_20, 350);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet5(username, Q5_1, Q5_2, Q5_3, Q5_4, Q5_5, Q5_6, Q5_7, Q5_8, Q5_9, Q5_10, Q5_11, Q5_12, Q5_13, Q5_14, Q5_15, Q5_16, Q5_17, Q5_18, Q5_19, Q5_20);

                if (errorMessage != null)
                {
                    lblError5.Text = errorMessage;
                    lblError5.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View6);

                }//end else

            }//end else

        }//end event

        protected void btnContinue5_Click(object sender, EventArgs e)
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

            MultiView1.SetActiveView(View6);

        }//end event

        protected void btnSubmit6_Click(object sender, EventArgs e)
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

            if (CheckBox101.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox102.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox103.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox104.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox105.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox106.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox107.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox108.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox109.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox110.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox111.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox112.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox113.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox114.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox115.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox116.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox117.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox118.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox119.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox120.Checked == true)
            {
                selectionCount++;

            }//end if

            if (selectionCount == 0)
            {
                MsgBox("Invalid. You must select at least one skill group from the selection.");

            }//end if

            else
            {
                string Q6_1 = "";
                string Q6_2 = "";
                string Q6_3 = "";
                string Q6_4 = "";
                string Q6_5 = "";
                string Q6_6 = "";
                string Q6_7 = "";
                string Q6_8 = "";
                string Q6_9 = "";
                string Q6_10 = "";
                string Q6_11 = "";
                string Q6_12 = "";
                string Q6_13 = "";
                string Q6_14 = "";
                string Q6_15 = "";
                string Q6_16 = "";
                string Q6_17 = "";
                string Q6_18 = "";
                string Q6_19 = "";
                string Q6_20 = "";

                if (CheckBox101.Checked == true)
                {
                    Q6_1 = CheckBox101.Text;

                }//end if

                if (CheckBox102.Checked == true)
                {
                    Q6_2 = CheckBox102.Text;

                }//end if

                if (CheckBox103.Checked == true)
                {
                    Q6_3 = CheckBox103.Text;

                }//end if

                if (CheckBox104.Checked == true)
                {
                    Q6_4 = CheckBox104.Text;

                }//end if

                if (CheckBox105.Checked == true)
                {
                    Q6_5 = CheckBox105.Text;

                }//end if

                if (CheckBox106.Checked == true)
                {
                    Q6_6 = CheckBox106.Text;

                }//end if

                if (CheckBox107.Checked == true)
                {
                    Q6_7 = CheckBox107.Text;

                }//end if

                if (CheckBox108.Checked == true)
                {
                    Q6_8 = CheckBox108.Text;

                }//end if

                if (CheckBox109.Checked == true)
                {
                    Q6_9 = CheckBox109.Text;

                }//end if

                if (CheckBox110.Checked == true)
                {
                    Q6_10 = CheckBox110.Text;

                }//end if

                if (CheckBox111.Checked == true)
                {
                    Q6_11 = CheckBox111.Text;

                }//end if

                if (CheckBox112.Checked == true)
                {
                    Q6_12 = CheckBox112.Text;

                }//end if

                if (CheckBox113.Checked == true)
                {
                    Q6_13 = CheckBox113.Text;

                }//end if

                if (CheckBox114.Checked == true)
                {
                    Q6_14 = CheckBox114.Text;

                }//end if

                if (CheckBox115.Checked == true)
                {
                    Q6_15 = CheckBox115.Text;

                }//end if

                if (CheckBox116.Checked == true)
                {
                    Q6_16 = CheckBox116.Text;

                }//end if

                if (CheckBox117.Checked == true)
                {
                    Q6_17 = CheckBox117.Text;

                }//end if

                if (CheckBox118.Checked == true)
                {
                    Q6_18 = CheckBox118.Text;

                }//end if

                if (CheckBox119.Checked == true)
                {
                    Q6_19 = CheckBox119.Text;

                }//end if

                if (CheckBox120.Checked == true)
                {
                    Q6_20 = CheckBox120.Text;

                }//end if

                Validate validationObject = new Validate();

                Q6_1 = validationObject.Truncate(Q6_1, 350);
                Q6_2 = validationObject.Truncate(Q6_2, 350);
                Q6_3 = validationObject.Truncate(Q6_3, 350);
                Q6_4 = validationObject.Truncate(Q6_4, 350);
                Q6_5 = validationObject.Truncate(Q6_5, 350);
                Q6_6 = validationObject.Truncate(Q6_6, 350);
                Q6_7 = validationObject.Truncate(Q6_7, 350);
                Q6_8 = validationObject.Truncate(Q6_8, 350);
                Q6_9 = validationObject.Truncate(Q6_9, 350);
                Q6_10 = validationObject.Truncate(Q6_10, 350);
                Q6_11 = validationObject.Truncate(Q6_11, 350);
                Q6_12 = validationObject.Truncate(Q6_12, 350);
                Q6_13 = validationObject.Truncate(Q6_13, 350);
                Q6_14 = validationObject.Truncate(Q6_14, 350);
                Q6_15 = validationObject.Truncate(Q6_15, 350);
                Q6_16 = validationObject.Truncate(Q6_16, 350);
                Q6_17 = validationObject.Truncate(Q6_17, 350);
                Q6_18 = validationObject.Truncate(Q6_18, 350);
                Q6_19 = validationObject.Truncate(Q6_19, 350);
                Q6_20 = validationObject.Truncate(Q6_20, 350);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet6(username, Q6_1, Q6_2, Q6_3, Q6_4, Q6_5, Q6_6, Q6_7, Q6_8, Q6_9, Q6_10, Q6_11, Q6_12, Q6_13, Q6_14, Q6_15, Q6_16, Q6_17, Q6_18, Q6_19, Q6_20);

                if (errorMessage != null)
                {
                    lblError6.Text = errorMessage;
                    lblError6.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View7);

                }//end else

            }//end else

        }//end event

        protected void btnContinue6_Click(object sender, EventArgs e)
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

            MultiView1.SetActiveView(View7);

        }//end event

        protected void btnSubmit7_Click(object sender, EventArgs e)
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

            if (CheckBox121.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox122.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox123.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox124.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox125.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox126.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox127.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox128.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox129.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox130.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox131.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox132.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox133.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox134.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox135.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox136.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox137.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox138.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox139.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox140.Checked == true)
            {
                selectionCount++;

            }//end if

            if (selectionCount == 0)
            {
                MsgBox("Invalid. You must select at least one skill group from the selection.");

            }//end if

            else
            {
                string Q7_1 = "";
                string Q7_2 = "";
                string Q7_3 = "";
                string Q7_4 = "";
                string Q7_5 = "";
                string Q7_6 = "";
                string Q7_7 = "";
                string Q7_8 = "";
                string Q7_9 = "";
                string Q7_10 = "";
                string Q7_11 = "";
                string Q7_12 = "";
                string Q7_13 = "";
                string Q7_14 = "";
                string Q7_15 = "";
                string Q7_16 = "";
                string Q7_17 = "";
                string Q7_18 = "";
                string Q7_19 = "";
                string Q7_20 = "";

                if (CheckBox121.Checked == true)
                {
                    Q7_1 = CheckBox121.Text;

                }//end if

                if (CheckBox122.Checked == true)
                {
                    Q7_2 = CheckBox122.Text;

                }//end if

                if (CheckBox123.Checked == true)
                {
                    Q7_3 = CheckBox123.Text;

                }//end if

                if (CheckBox124.Checked == true)
                {
                    Q7_4 = CheckBox124.Text;

                }//end if

                if (CheckBox125.Checked == true)
                {
                    Q7_5 = CheckBox125.Text;

                }//end if

                if (CheckBox126.Checked == true)
                {
                    Q7_6 = CheckBox126.Text;

                }//end if

                if (CheckBox127.Checked == true)
                {
                    Q7_7 = CheckBox127.Text;

                }//end if

                if (CheckBox128.Checked == true)
                {
                    Q7_8 = CheckBox128.Text;

                }//end if

                if (CheckBox129.Checked == true)
                {
                    Q7_9 = CheckBox129.Text;

                }//end if

                if (CheckBox130.Checked == true)
                {
                    Q7_10 = CheckBox130.Text;

                }//end if

                if (CheckBox131.Checked == true)
                {
                    Q7_11 = CheckBox131.Text;

                }//end if

                if (CheckBox132.Checked == true)
                {
                    Q7_12 = CheckBox132.Text;

                }//end if

                if (CheckBox133.Checked == true)
                {
                    Q7_13 = CheckBox133.Text;

                }//end if

                if (CheckBox134.Checked == true)
                {
                    Q7_14 = CheckBox134.Text;

                }//end if

                if (CheckBox135.Checked == true)
                {
                    Q7_15 = CheckBox135.Text;

                }//end if

                if (CheckBox136.Checked == true)
                {
                    Q7_16 = CheckBox136.Text;

                }//end if

                if (CheckBox137.Checked == true)
                {
                    Q7_17 = CheckBox137.Text;

                }//end if

                if (CheckBox138.Checked == true)
                {
                    Q7_18 = CheckBox138.Text;

                }//end if

                if (CheckBox139.Checked == true)
                {
                    Q7_19 = CheckBox139.Text;

                }//end if

                if (CheckBox140.Checked == true)
                {
                    Q7_20 = CheckBox140.Text;

                }//end if

                Validate validationObject = new Validate();

                Q7_1 = validationObject.Truncate(Q7_1, 350);
                Q7_2 = validationObject.Truncate(Q7_2, 350);
                Q7_3 = validationObject.Truncate(Q7_3, 350);
                Q7_4 = validationObject.Truncate(Q7_4, 350);
                Q7_5 = validationObject.Truncate(Q7_5, 350);
                Q7_6 = validationObject.Truncate(Q7_6, 350);
                Q7_7 = validationObject.Truncate(Q7_7, 350);
                Q7_8 = validationObject.Truncate(Q7_8, 350);
                Q7_9 = validationObject.Truncate(Q7_9, 350);
                Q7_10 = validationObject.Truncate(Q7_10, 350);
                Q7_11 = validationObject.Truncate(Q7_11, 350);
                Q7_12 = validationObject.Truncate(Q7_12, 350);
                Q7_13 = validationObject.Truncate(Q7_13, 350);
                Q7_14 = validationObject.Truncate(Q7_14, 350);
                Q7_15 = validationObject.Truncate(Q7_15, 350);
                Q7_16 = validationObject.Truncate(Q7_16, 350);
                Q7_17 = validationObject.Truncate(Q7_17, 350);
                Q7_18 = validationObject.Truncate(Q7_18, 350);
                Q7_19 = validationObject.Truncate(Q7_19, 350);
                Q7_20 = validationObject.Truncate(Q7_20, 350);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet7(username, Q7_1, Q7_2, Q7_3, Q7_4, Q7_5, Q7_6, Q7_7, Q7_8, Q7_9, Q7_10, Q7_11, Q7_12, Q7_13, Q7_14, Q7_15, Q7_16, Q7_17, Q7_18, Q7_19, Q7_20);

                if (errorMessage != null)
                {
                    lblError7.Text = errorMessage;
                    lblError7.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    MultiView1.SetActiveView(View8);

                }//end else

            }//end else

        }//end event

        protected void btnContinue7_Click(object sender, EventArgs e)
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

            MultiView1.SetActiveView(View8);

        }//end event

        protected void btnSubmit8_Click(object sender, EventArgs e)
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

            if (CheckBox141.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox142.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox143.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox144.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox145.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox146.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox147.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox148.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox149.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox150.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox151.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox152.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox153.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox154.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox155.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox156.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox157.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox158.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox159.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox160.Checked == true)
            {
                selectionCount++;

            }//end if

            if (selectionCount == 0)
            {
                MsgBox("Invalid. You must select at least one skill group from the selection.");

            }//end if

            else
            {
                string Q8_1 = "";
                string Q8_2 = "";
                string Q8_3 = "";
                string Q8_4 = "";
                string Q8_5 = "";
                string Q8_6 = "";
                string Q8_7 = "";
                string Q8_8 = "";
                string Q8_9 = "";
                string Q8_10 = "";
                string Q8_11 = "";
                string Q8_12 = "";
                string Q8_13 = "";
                string Q8_14 = "";
                string Q8_15 = "";
                string Q8_16 = "";
                string Q8_17 = "";
                string Q8_18 = "";
                string Q8_19 = "";
                string Q8_20 = "";

                if (CheckBox141.Checked == true)
                {
                    Q8_1 = CheckBox141.Text;

                }//end if

                if (CheckBox142.Checked == true)
                {
                    Q8_2 = CheckBox142.Text;

                }//end if

                if (CheckBox143.Checked == true)
                {
                    Q8_3 = CheckBox143.Text;

                }//end if

                if (CheckBox144.Checked == true)
                {
                    Q8_4 = CheckBox144.Text;

                }//end if

                if (CheckBox145.Checked == true)
                {
                    Q8_5 = CheckBox145.Text;

                }//end if

                if (CheckBox146.Checked == true)
                {
                    Q8_6 = CheckBox146.Text;

                }//end if

                if (CheckBox147.Checked == true)
                {
                    Q8_7 = CheckBox147.Text;

                }//end if

                if (CheckBox148.Checked == true)
                {
                    Q8_8 = CheckBox148.Text;

                }//end if

                if (CheckBox149.Checked == true)
                {
                    Q8_9 = CheckBox149.Text;

                }//end if

                if (CheckBox150.Checked == true)
                {
                    Q8_10 = CheckBox150.Text;

                }//end if

                if (CheckBox151.Checked == true)
                {
                    Q8_11 = CheckBox151.Text;

                }//end if

                if (CheckBox152.Checked == true)
                {
                    Q8_12 = CheckBox152.Text;

                }//end if

                if (CheckBox153.Checked == true)
                {
                    Q8_13 = CheckBox153.Text;

                }//end if

                if (CheckBox154.Checked == true)
                {
                    Q8_14 = CheckBox154.Text;

                }//end if

                if (CheckBox155.Checked == true)
                {
                    Q8_15 = CheckBox155.Text;

                }//end if

                if (CheckBox156.Checked == true)
                {
                    Q8_16 = CheckBox156.Text;

                }//end if

                if (CheckBox157.Checked == true)
                {
                    Q8_17 = CheckBox157.Text;

                }//end if

                if (CheckBox158.Checked == true)
                {
                    Q8_18 = CheckBox158.Text;

                }//end if

                if (CheckBox159.Checked == true)
                {
                    Q8_19 = CheckBox159.Text;

                }//end if

                if (CheckBox160.Checked == true)
                {
                    Q8_20 = CheckBox160.Text;

                }//end if

                Validate validationObject = new Validate();

                Q8_1 = validationObject.Truncate(Q8_1, 350);
                Q8_2 = validationObject.Truncate(Q8_2, 350);
                Q8_3 = validationObject.Truncate(Q8_3, 350);
                Q8_4 = validationObject.Truncate(Q8_4, 350);
                Q8_5 = validationObject.Truncate(Q8_5, 350);
                Q8_6 = validationObject.Truncate(Q8_6, 350);
                Q8_7 = validationObject.Truncate(Q8_7, 350);
                Q8_8 = validationObject.Truncate(Q8_8, 350);
                Q8_9 = validationObject.Truncate(Q8_9, 350);
                Q8_10 = validationObject.Truncate(Q8_10, 350);
                Q8_11 = validationObject.Truncate(Q8_11, 350);
                Q8_12 = validationObject.Truncate(Q8_12, 350);
                Q8_13 = validationObject.Truncate(Q8_13, 350);
                Q8_14 = validationObject.Truncate(Q8_14, 350);
                Q8_15 = validationObject.Truncate(Q8_15, 350);
                Q8_16 = validationObject.Truncate(Q8_16, 350);
                Q8_17 = validationObject.Truncate(Q8_17, 350);
                Q8_18 = validationObject.Truncate(Q8_18, 350);
                Q8_19 = validationObject.Truncate(Q8_19, 350);
                Q8_20 = validationObject.Truncate(Q8_20, 350);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet8(username, Q8_1, Q8_2, Q8_3, Q8_4, Q8_5, Q8_6, Q8_7, Q8_8, Q8_9, Q8_10, Q8_11, Q8_12, Q8_13, Q8_14, Q8_15, Q8_16, Q8_17, Q8_18, Q8_19, Q8_20);

                if (errorMessage != null)
                {
                    lblError8.Text = errorMessage;
                    lblError8.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    Select selectObject = new Select();

                    string errorMessage3;

                    ArrayList record = new ArrayList();

                    record = Select.Select_Focus_Analysis_Record(username);

                    errorMessage3 = selectObject.getErrorMessage();

                    if (errorMessage3 != null)
                    {
                        lblError8.Text = errorMessage3;
                        lblError8.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        int counter1 = 0;
                        int counter2 = 0;
                        int counter3 = 0;
                        int counter4 = 0;
                        int counter5 = 0;
                        int counter6 = 0;
                        int counter7 = 0;
                        int counter8 = 0;
                        int counter9 = 0;
                        int counter10 = 0;
                        int counter11 = 0;
                        int counter12 = 0;
                        int counter13 = 0;
                        int counter14 = 0;
                        int counter15 = 0;
                        int counter16 = 0;
                        int counter17 = 0;
                        int counter18 = 0;
                        int counter19 = 0;
                        int counter20 = 0;


                        if (record[8].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[9].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[10].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[11].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[12].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[13].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[14].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[15].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[16].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[17].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[18].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[19].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[20].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[21].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[22].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[23].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[24].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[25].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[26].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[27].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[28].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[29].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[30].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[31].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[32].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[33].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[34].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[35].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[36].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[37].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[38].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[39].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[40].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[41].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[42].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[43].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[44].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[45].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[46].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[47].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[48].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[49].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[50].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[51].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[52].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[53].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[54].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[55].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[56].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[57].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[58].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[59].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[60].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[61].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[62].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[63].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[64].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[65].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[66].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[67].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[68].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[69].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[70].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[71].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[72].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[73].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[74].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[75].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[76].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[77].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[78].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[79].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[80].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[81].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[82].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[83].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[84].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[85].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[86].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[87].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[88].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[89].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[90].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[91].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[92].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[93].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[94].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[95].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[96].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[97].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[98].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[99].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[100].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[101].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[102].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[103].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[104].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[105].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[106].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[107].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[108].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[109].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[110].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[111].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[112].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[113].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[114].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[115].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[116].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[117].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[118].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[119].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[120].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[121].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[122].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[123].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[124].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[125].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[126].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[127].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[128].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[129].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[130].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[131].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[132].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[133].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[134].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[135].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[136].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[137].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[138].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[139].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[140].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[141].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[142].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[143].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[144].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[145].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[146].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[147].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[148].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[149].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[150].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[151].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[152].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[153].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[154].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[155].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[156].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[157].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[158].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[159].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[160].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[161].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[162].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[163].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[164].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[165].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[166].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[167].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        Label1.Text = counter1.ToString();
                        Label2.Text = counter2.ToString();
                        Label3.Text = counter3.ToString();
                        Label4.Text = counter4.ToString();
                        Label5.Text = counter5.ToString();
                        Label6.Text = counter6.ToString();
                        Label7.Text = counter7.ToString();
                        Label8.Text = counter8.ToString();
                        Label9.Text = counter9.ToString();
                        Label10.Text = counter10.ToString();
                        Label11.Text = counter11.ToString();
                        Label12.Text = counter12.ToString();
                        Label13.Text = counter13.ToString();
                        Label14.Text = counter14.ToString();
                        Label15.Text = counter15.ToString();
                        Label16.Text = counter16.ToString();
                        Label17.Text = counter17.ToString();
                        Label18.Text = counter18.ToString();
                        Label19.Text = counter19.ToString();
                        Label20.Text = counter20.ToString();

                        MultiView1.SetActiveView(View9);

                    }//end else

                }//end else

            }//end else

        }//end event

        protected void btnContinue8_Click(object sender, EventArgs e)
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
            
            Select selectObject = new Select();

                    string errorMessage3;

                    ArrayList record = new ArrayList();

                    record = Select.Select_Focus_Analysis_Record(username);

                    errorMessage3 = selectObject.getErrorMessage();

                    if (errorMessage3 != null)
                    {
                        lblError8.Text = errorMessage3;
                        lblError8.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        int counter1 = 0;
                        int counter2 = 0;
                        int counter3 = 0;
                        int counter4 = 0;
                        int counter5 = 0;
                        int counter6 = 0;
                        int counter7 = 0;
                        int counter8 = 0;
                        int counter9 = 0;
                        int counter10 = 0;
                        int counter11 = 0;
                        int counter12 = 0;
                        int counter13 = 0;
                        int counter14 = 0;
                        int counter15 = 0;
                        int counter16 = 0;
                        int counter17 = 0;
                        int counter18 = 0;
                        int counter19 = 0;
                        int counter20 = 0;


                        if (record[8].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[9].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[10].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[11].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[12].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[13].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[14].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[15].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[16].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[17].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[18].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[19].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[20].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[21].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[22].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[23].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[24].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[25].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[26].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[27].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[28].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[29].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[30].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[31].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[32].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[33].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[34].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[35].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[36].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[37].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[38].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[39].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[40].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[41].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[42].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[43].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[44].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[45].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[46].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[47].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[48].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[49].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[50].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[51].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[52].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[53].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[54].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[55].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[56].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[57].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[58].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[59].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[60].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[61].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[62].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[63].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[64].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[65].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[66].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[67].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[68].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[69].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[70].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[71].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[72].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[73].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[74].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[75].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[76].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[77].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[78].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[79].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[80].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[81].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[82].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[83].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[84].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[85].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[86].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[87].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[88].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[89].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[90].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[91].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[92].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[93].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[94].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[95].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[96].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[97].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[98].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[99].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[100].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[101].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[102].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[103].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[104].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[105].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[106].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[107].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[108].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[109].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[110].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[111].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[112].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[113].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[114].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[115].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[116].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[117].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[118].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[119].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[120].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[121].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[122].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[123].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[124].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[125].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[126].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[127].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[128].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[129].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[130].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[131].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[132].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[133].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[134].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[135].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[136].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[137].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[138].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[139].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[140].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[141].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[142].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[143].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[144].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[145].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[146].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[147].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        if (record[148].ToString() != "")
                        {
                            counter1++;

                        }//end if

                        if (record[149].ToString() != "")
                        {
                            counter2++;

                        }//end if

                        if (record[150].ToString() != "")
                        {
                            counter3++;

                        }//end if

                        if (record[151].ToString() != "")
                        {
                            counter4++;

                        }//end if

                        if (record[152].ToString() != "")
                        {
                            counter5++;

                        }//end if

                        if (record[153].ToString() != "")
                        {
                            counter6++;

                        }//end if

                        if (record[154].ToString() != "")
                        {
                            counter7++;

                        }//end if

                        if (record[155].ToString() != "")
                        {
                            counter8++;

                        }//end if

                        if (record[156].ToString() != "")
                        {
                            counter9++;

                        }//end if

                        if (record[157].ToString() != "")
                        {
                            counter10++;

                        }//end if

                        if (record[158].ToString() != "")
                        {
                            counter11++;

                        }//end if

                        if (record[159].ToString() != "")
                        {
                            counter12++;

                        }//end if

                        if (record[160].ToString() != "")
                        {
                            counter13++;

                        }//end if

                        if (record[161].ToString() != "")
                        {
                            counter14++;

                        }//end if

                        if (record[162].ToString() != "")
                        {
                            counter15++;

                        }//end if

                        if (record[163].ToString() != "")
                        {
                            counter16++;

                        }//end if

                        if (record[164].ToString() != "")
                        {
                            counter17++;

                        }//end if

                        if (record[165].ToString() != "")
                        {
                            counter18++;

                        }//end if

                        if (record[166].ToString() != "")
                        {
                            counter19++;

                        }//end if

                        if (record[167].ToString() != "")
                        {
                            counter20++;

                        }//end if

                        Label1.Text = counter1.ToString();
                        Label2.Text = counter2.ToString();
                        Label3.Text = counter3.ToString();
                        Label4.Text = counter4.ToString();
                        Label5.Text = counter5.ToString();
                        Label6.Text = counter6.ToString();
                        Label7.Text = counter7.ToString();
                        Label8.Text = counter8.ToString();
                        Label9.Text = counter9.ToString();
                        Label10.Text = counter10.ToString();
                        Label11.Text = counter11.ToString();
                        Label12.Text = counter12.ToString();
                        Label13.Text = counter13.ToString();
                        Label14.Text = counter14.ToString();
                        Label15.Text = counter15.ToString();
                        Label16.Text = counter16.ToString();
                        Label17.Text = counter17.ToString();
                        Label18.Text = counter18.ToString();
                        Label19.Text = counter19.ToString();
                        Label20.Text = counter20.ToString();

                        MultiView1.SetActiveView(View9);

                    }//end else

        }//end event

        protected void btnSubmit9_Click(object sender, EventArgs e)
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

            if (CheckBox161.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox162.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox163.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox164.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox165.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox166.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox167.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox168.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox169.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox170.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox171.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox172.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox173.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox174.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox175.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox176.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox177.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox178.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox179.Checked == true)
            {
                selectionCount++;

            }//end if

            if (CheckBox180.Checked == true)
            {
                selectionCount++;

            }//end if

            if (selectionCount != 6)
            {
                MsgBox("Invalid. You must select exactly six skill groups from the selection.");

            }//end if

            else if (selectionCount == 6)
            {
                string Q9_1 = "";
                string Q9_2 = "";
                string Q9_3 = "";
                string Q9_4 = "";
                string Q9_5 = "";
                string Q9_6 = "";
                string Q9_7 = "";
                string Q9_8 = "";
                string Q9_9 = "";
                string Q9_10 = "";
                string Q9_11 = "";
                string Q9_12 = "";
                string Q9_13 = "";
                string Q9_14 = "";
                string Q9_15 = "";
                string Q9_16 = "";
                string Q9_17 = "";
                string Q9_18 = "";
                string Q9_19 = "";
                string Q9_20 = "";

                if (CheckBox161.Checked == true)
                {
                    Q9_1 = CheckBox161.Text;

                }//end if

                if (CheckBox162.Checked == true)
                {
                    Q9_2 = CheckBox162.Text;

                }//end if

                if (CheckBox163.Checked == true)
                {
                    Q9_3 = CheckBox163.Text;

                }//end if

                if (CheckBox164.Checked == true)
                {
                    Q9_4 = CheckBox164.Text;

                }//end if

                if (CheckBox165.Checked == true)
                {
                    Q9_5 = CheckBox165.Text;

                }//end if

                if (CheckBox166.Checked == true)
                {
                    Q9_6 = CheckBox166.Text;

                }//end if

                if (CheckBox167.Checked == true)
                {
                    Q9_7 = CheckBox167.Text;

                }//end if

                if (CheckBox168.Checked == true)
                {
                    Q9_8 = CheckBox168.Text;

                }//end if

                if (CheckBox169.Checked == true)
                {
                    Q9_9 = CheckBox169.Text;

                }//end if

                if (CheckBox170.Checked == true)
                {
                    Q9_10 = CheckBox170.Text;

                }//end if

                if (CheckBox171.Checked == true)
                {
                    Q9_11 = CheckBox171.Text;

                }//end if

                if (CheckBox172.Checked == true)
                {
                    Q9_12 = CheckBox172.Text;

                }//end if

                if (CheckBox173.Checked == true)
                {
                    Q9_13 = CheckBox173.Text;

                }//end if

                if (CheckBox174.Checked == true)
                {
                    Q9_14 = CheckBox174.Text;

                }//end if

                if (CheckBox175.Checked == true)
                {
                    Q9_15 = CheckBox175.Text;

                }//end if

                if (CheckBox176.Checked == true)
                {
                    Q9_16 = CheckBox176.Text;

                }//end if

                if (CheckBox177.Checked == true)
                {
                    Q9_17 = CheckBox177.Text;

                }//end if

                if (CheckBox178.Checked == true)
                {
                    Q9_18 = CheckBox178.Text;

                }//end if

                if (CheckBox179.Checked == true)
                {
                    Q9_19 = CheckBox179.Text;

                }//end if

                if (CheckBox180.Checked == true)
                {
                    Q9_20 = CheckBox180.Text;

                }//end if

                string Q9 = TextBox17.InnerText;
                string Q10 = TextBox18.InnerText;
                string Q11 = TextBox19.InnerText;
                string Q12 = TextBox20.InnerText;
                string Q13 = TextBox21.InnerText;
                string Q14 = TextBox22.InnerText;

                Validate validationObject = new Validate();

                Q9_1 = validationObject.Truncate(Q9_1, 350);
                Q9_2 = validationObject.Truncate(Q9_2, 350);
                Q9_3 = validationObject.Truncate(Q9_3, 350);
                Q9_4 = validationObject.Truncate(Q9_4, 350);
                Q9_5 = validationObject.Truncate(Q9_5, 350);
                Q9_6 = validationObject.Truncate(Q9_6, 350);
                Q9_7 = validationObject.Truncate(Q9_7, 350);
                Q9_8 = validationObject.Truncate(Q9_8, 350);
                Q9_9 = validationObject.Truncate(Q9_9, 350);
                Q9_10 = validationObject.Truncate(Q9_10, 350);
                Q9_11 = validationObject.Truncate(Q9_11, 350);
                Q9_12 = validationObject.Truncate(Q9_12, 350);
                Q9_13 = validationObject.Truncate(Q9_13, 350);
                Q9_14 = validationObject.Truncate(Q9_14, 350);
                Q9_15 = validationObject.Truncate(Q9_15, 350);
                Q9_16 = validationObject.Truncate(Q9_16, 350);
                Q9_17 = validationObject.Truncate(Q9_17, 350);
                Q9_18 = validationObject.Truncate(Q9_18, 350);
                Q9_19 = validationObject.Truncate(Q9_19, 350);
                Q9_20 = validationObject.Truncate(Q9_20, 350);

                Q9 = validationObject.Truncate(Q9, 900);
                Q10 = validationObject.Truncate(Q10, 900);
                Q11 = validationObject.Truncate(Q11, 900);
                Q12 = validationObject.Truncate(Q12, 900);
                Q13 = validationObject.Truncate(Q13, 900);
                Q14 = validationObject.Truncate(Q14, 900);

                string errorMessage;

                errorMessage = Update.Update_Focus_Analysis_Worksheet9(username, Q9_1, Q9_2, Q9_3, Q9_4, Q9_5, Q9_6, Q9_7, Q9_8, Q9_9, Q9_10, Q9_11, Q9_12, Q9_13, Q9_14, Q9_15, Q9_16, Q9_17, Q9_18, Q9_19, Q9_20, Q9, Q10, Q11, Q12, Q13, Q14);

                if (errorMessage != null)
                {
                    lblError9.Text = errorMessage;
                    lblError9.Visible = true;

                    ErrorMessage message = new ErrorMessage();

                    MsgBox(message.SQLServerErrorMessage);

                }//end if

                else
                {
                    string errorMessage2;

                    errorMessage2 = Update.Update_Focus_Analysis_Status(username);

                    if (errorMessage2 != null)
                    {
                        lblError9.Text = errorMessage2;
                        lblError9.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        Response.Redirect("~/PL/FOP/FOP_ProgressMenu.aspx");

                    }//end else

                }//end else

            }//end else if

        }//end event

        protected void btnContinue9_Click(object sender, EventArgs e)
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

            Response.Redirect("~/PL/FOP/FOP_ProgressMenu.aspx");

        }//end event

        protected void btnSubmit10_Click(object sender, EventArgs e)
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

            string Q1 = TextBox23.Text;
            string Q2 = TextBox24.Text;
            string Q3 = TextBox25.Text;
            string Q4 = TextBox26.Text;
            string Q5 = TextBox27.Text;
            string Q6 = TextBox28.Text;
            string Q7 = TextBox29.Text;
            string Q8 = TextBox30.Text;

            Validate validationObject = new Validate();

            Q1 = validationObject.Truncate(Q1, 900);
            Q2 = validationObject.Truncate(Q2, 900);
            Q3 = validationObject.Truncate(Q3, 900);
            Q4 = validationObject.Truncate(Q4, 900);
            Q5 = validationObject.Truncate(Q5, 900);
            Q6 = validationObject.Truncate(Q6, 900);
            Q7 = validationObject.Truncate(Q7, 900);
            Q8 = validationObject.Truncate(Q8, 900);

            bool recordExists;

            string errorMessage;

            Select selectObject = new Select();

            recordExists = Select.Select_Focus_Analysis_Worksheet(username);

            errorMessage = selectObject.getErrorMessage();

            if (errorMessage != null)
            {
                lblError10.Text = errorMessage;
                lblError10.Visible = true;

                ErrorMessage message = new ErrorMessage();

                MsgBox(message.SQLServerErrorMessage);

            }//end if

            else
            {
                if (recordExists == false)
                {
                    string errorMessage2;

                    errorMessage2 = Insert.Insert_Focus_Analysis_Worksheet(username, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8);

                    if (errorMessage2 != null)
                    {
                        lblError10.Text = errorMessage2;
                        lblError10.Visible = true;

                        ErrorMessage message = new ErrorMessage();

                        MsgBox(message.SQLServerErrorMessage);

                    }//end if

                    else
                    {
                        string errorMessage3;

                        ArrayList record = new ArrayList();

                        record = Select.Select_Focus_Analysis_Record(username);

                        errorMessage3 = selectObject.getErrorMessage();

                        if (errorMessage3 != null)
                        {
                            lblError10.Text = errorMessage3;
                            lblError10.Visible = true;

                            ErrorMessage message = new ErrorMessage();

                            MsgBox(message.SQLServerErrorMessage);

                        }//end if

                        else
                        {
                            TextBox23.Text = record[0].ToString();
                            lblExample1.Text = record[0].ToString();

                            TextBox24.Text = record[1].ToString();
                            lblExample2.Text = record[1].ToString();

                            TextBox25.Text = record[2].ToString();
                            lblExample3.Text = record[2].ToString();

                            TextBox26.Text = record[3].ToString();
                            lblExample4.Text = record[3].ToString();

                            TextBox27.Text = record[4].ToString();
                            lblExample5.Text = record[4].ToString();

                            TextBox28.Text = record[5].ToString();
                            lblExample6.Text = record[5].ToString();

                            TextBox29.Text = record[6].ToString();
                            lblExample7.Text = record[6].ToString();

                            TextBox30.Text = record[7].ToString();
                            lblExample8.Text = record[7].ToString();

                            MultiView1.SetActiveView(View1);

                        }//end else

                    }//end else

                }//end if

            }//end else

        }//end event

        protected void btnContinue10_Click(object sender, EventArgs e)
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

            MultiView1.SetActiveView(View1);

        }//end method

        protected void CheckBox161_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox161.Focus();

        }//end event

        protected void CheckBox162_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox164.Focus();

        }//end event

        protected void CheckBox163_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox165.Focus();

        }//end event

        protected void CheckBox164_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox166.Focus();

        }//end event

        protected void CheckBox165_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox167.Focus();

        }//end event

        protected void CheckBox166_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox168.Focus();

        }//end event

        protected void CheckBox167_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox169.Focus();

        }//end event

        protected void CheckBox168_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox170.Focus();

        }//end event

        protected void CheckBox169_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox171.Focus();

        }//end event

        protected void CheckBox170_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox172.Focus();

        }//end event

        protected void CheckBox171_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox173.Focus();

        }//end event

        protected void CheckBox172_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox174.Focus();

        }//end event

        protected void CheckBox173_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox175.Focus();

        }//end event

        protected void CheckBox174_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox176.Focus();

        }//end event

        protected void CheckBox175_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox177.Focus();

        }//end event

        protected void CheckBox176_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox178.Focus();

        }//end event

        protected void CheckBox177_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox179.Focus();

        }//end event

        protected void CheckBox178_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox180.Focus();

        }//end event

        protected void CheckBox179_CheckedChanged(object sender, EventArgs e)
        {
            TextBox17.Focus();

        }//end event

        protected void CheckBox180_CheckedChanged(object sender, EventArgs e)
        {
            TextBox17.Focus();

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