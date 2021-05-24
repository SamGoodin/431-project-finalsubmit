using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

//must include this namespace
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Runtime.InteropServices;


namespace CourseProject
{
    public partial class userDownload : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLinkUsers.Visible = false;
        }


        protected void Download_Click(object sender, EventArgs e)
        {
            pnlDownloadUsers.Visible = true;

            //create a file write to write to the file, if the doesn't exist, it will be created. If it exists, it will be overwritten.
            //Using a flimsy directory TODO change for server when ready
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\samue\Desktop\431-Project-master\CourseProjectDirectory\CourseProject\dataUsers.csv");

            ArrayList res = new ArrayList();
            res = DBAction.GetRows("select * from USERS");

            file.WriteLine("Users");
            //write the header line
            file.WriteLine("ID,Prefix,First Name,Last Name,Email,Password,Phone,Register Date,Approved,Approval Date,Last Login Date,Active,Confirmed,Notification Email");
            //write the values
            for (int j = 0; j < res.Count; j++)
            {
                //loop through each row to get the content, create each line with values as comman seperated and write each line to the file
                ArrayList oneRow = new ArrayList();
                oneRow = (ArrayList)res[j];
                string line = "";
                for (int field = 0; field < oneRow.Count; field++)
                {
                    //there should be no comma after the last value, carriage return in CSV files indicate a new row
                    if (field == (oneRow.Count - 1)) line = line + oneRow[field].ToString();
                    else line = line + oneRow[field].ToString() + ",";

                }

                file.WriteLine(line);
            }
            file.Flush();

            ArrayList res1 = new ArrayList();
            res1 = DBAction.GetRows("select * from MANAGER");

            file.WriteLine("Managers");
            //write the header line
            file.WriteLine("ManagerID,FirstName,LastName,Email,Password,Phone,Prefix,Suffix,Approved,ApprovalDate,RegisterDate,LastLoginDate,Active,NotificationEmail");
            //write the values
            for (int j = 0; j < res1.Count; j++)
            {
                //loop through each row to get the content, create each line with values as comman seperated and write each line to the file
                ArrayList oneRow = new ArrayList();
                oneRow = (ArrayList)res1[j];
                string line = "";
                for (int field = 0; field < oneRow.Count; field++)
                {
                    //there should be no comma after the last value, carriage return in CSV files indicate a new row
                    if (field == (oneRow.Count - 1)) line = line + oneRow[field].ToString();
                    else line = line + oneRow[field].ToString() + ",";

                }

                file.WriteLine(line);
            }
            file.Flush();

            ArrayList res2 = new ArrayList();
            res2 = DBAction.GetRows("select * from ADMIN");

            file.WriteLine("Admin");
            //write the header line
            file.WriteLine("ID,FirstName,LastName,Email,Password,Phone,AccessLevel,CreateDate,LastLoginDate,NotificationEmail");
            //write the values
            for (int j = 0; j < res2.Count; j++)
            {
                //loop through each row to get the content, create each line with values as comman seperated and write each line to the file
                ArrayList oneRow = new ArrayList();
                oneRow = (ArrayList)res2[j];
                string line = "";
                for (int field = 0; field < oneRow.Count; field++)
                {
                    //there should be no comma after the last value, carriage return in CSV files indicate a new row
                    if (field == (oneRow.Count - 1)) line = line + oneRow[field].ToString();
                    else line = line + oneRow[field].ToString() + ",";

                }

                file.WriteLine(line);
            }
            file.Flush();

            file.Close();

            HyperLinkUsers.Text = "Click here to download CSV file";
            //replace the root URL with your local host URL or a live URL
            HyperLinkUsers.NavigateUrl = @"dataUsers.csv";
            HyperLinkUsers.Visible = true;


        }

    }

}