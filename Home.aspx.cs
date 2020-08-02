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
    public partial class _Home : Page
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

        }//end event

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=BestPath_Foundation_Resource_Tools.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Home/6/BestPath_Foundation_Resource_Tools.pdf"));
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
            try
            {
                Response.ContentType = "Application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=RUG_competitive_matrix.pdf");
                Response.TransmitFile(Server.MapPath("~/Docs/BLPDS/Home/5/RUG_competitive_matrix.pdf"));
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