using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseProject
{
    public partial class WebFrame : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["email"] == null)
            {
                //Guest
                login.Visible = true;
                registeruser.Visible = true;
                profile.Visible = false;
                createprogram.Visible = false;
                createadmin.Visible = false;
                programmaintenance.Visible = false;
                logout.Visible = false;
                spreadsheetDownload.Visible = false;
                userDownload.Visible = false;
            }
            else if (Session["email"] != null && Convert.ToInt32(Session["role"]) == 1 && Session["ApprovalStatus"].ToString() == "No")
            {
                //Pgm Manager - unapproved
                login.Visible = false;
                registeruser.Visible = true;
                profile.Visible = true;
                createprogram.Visible = false;
                createadmin.Visible = false;
                programmaintenance.Visible = false;
                logout.Visible = true;
                spreadsheetDownload.Visible = false;
                userDownload.Visible = false;

            }
            else if (Session["email"] != null && Convert.ToInt32(Session["role"]) == 1 && Session["ApprovalStatus"].ToString() == "Yes" && Session["ActiveStatus"].ToString() == "Yes")
            {
                //Pgm Manager - approved and active
                login.Visible = false;
                registeruser.Visible = true;
                profile.Visible = true;
                createprogram.Visible = true;
                createadmin.Visible = false;
                programmaintenance.Visible = false;
                logout.Visible = true;
                spreadsheetDownload.Visible = false;
                userDownload.Visible = false;
            }
            else if (Session["email"] != null && Convert.ToInt32(Session["role"]) == 1 && Session["ApprovalStatus"].ToString() == "Yes" && Session["ActiveStatus"].ToString() == "No")
            {
                //Pgm Manager - approved and not active
                login.Visible = false;
                registeruser.Visible = true;
                profile.Visible = true;
                createprogram.Visible = false;
                createadmin.Visible = false;
                programmaintenance.Visible = false;
                logout.Visible = true;
                spreadsheetDownload.Visible = false;
                userDownload.Visible = false;
            }
            else if (Session["email"] != null && Convert.ToInt32(Session["role"]) == 2)
            {
                //Admin
                login.Visible = false;
                registeruser.Visible = true;
                profile.Visible = true;
                createprogram.Visible = true;
                createadmin.Visible = false;
                programmaintenance.Visible = true;
                logout.Visible = true;
                spreadsheetDownload.Visible = true;
                userDownload.Visible = true;

            }
            else if (Session["email"] != null && Convert.ToInt32(Session["role"]) == 3)
            {
                //Super Admin
                login.Visible = false;
                registeruser.Visible = true;
                profile.Visible = true;
                createprogram.Visible = true;
                createadmin.Visible = true;
                programmaintenance.Visible = true;
                logout.Visible = true;
                spreadsheetDownload.Visible = true;
                userDownload.Visible = true;
            }
            else
            {   //This is for 0 (USER)
                login.Visible = false;
                registeruser.Visible = true;
                profile.Visible = true;
                createprogram.Visible = false;
                createadmin.Visible = false;
                programmaintenance.Visible = false;
                logout.Visible = true;
                spreadsheetDownload.Visible = false;
                userDownload.Visible = false;

            }







        }
    }
}