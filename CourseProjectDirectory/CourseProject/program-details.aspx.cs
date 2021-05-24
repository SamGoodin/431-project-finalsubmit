using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseProject
{
    public partial class program_details : System.Web.UI.Page
    {
        string programID; 
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["email"] == null)
            //{
            //    Response.Redirect("login.aspx");
            //}

            ltrlError1.Visible = false;
            if (Session["programselected"] == null)
            {
                ltrlError1.Visible = true;
                ltrlError1.Text = "Something went wrong. Please try search again.";
            }
            else
            {
                programID = Session["programselected"].ToString();

                PopulateProgram(programID);
            }



        }//End Page_Load





        // Populates the Inactivated managers for Activation
        void PopulateProgram(string programID)
        {

            DataTable dtbl = new DataTable();
            string cs = WebConfigurationManager.ConnectionStrings["localConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string sql = "select * from ProgramsView where programID = '"+ programID +"'";
            try
            {
                ArrayList res = new ArrayList();
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if(reader.Read())
                {
                    programName.Text = reader["Name"].ToString();
                    DateTime dt = new DateTime();
                    dt = (DateTime)reader["StartDate"];
                    lblStartDateText.Text = dt.ToString("dd/mm/yyyy");
                    DateTime dtApplicationDeadline = new DateTime();
                    dtApplicationDeadline = (DateTime)reader["ApplicationDeadline"];
                    lblApplicationDeadlineText.Text = dtApplicationDeadline.ToString("dd/mm/yyyy");
                    lblDescriptionText.Text = reader["Description"].ToString();
                    lblAdditionalRestrictionsText.Text = reader["AdditionalRestriction"].ToString();
                    lblWebsiteText.Text = reader["Website"].ToString();
                    lblCostText.Text = reader["CostAmount"].ToString();
                    lblFieldText.Text = reader["fieldName"].ToString();
                    lblLengthText.Text = reader["Length"].ToString();
                    lblGradeLevelText.Text = reader["GradeLevel"].ToString();
                    lblResidenceText.Text = reader["ResidentialType"].ToString();
                    lblSeasonText.Text = reader["SeasonName"].ToString();
                    lblServiceAreaText.Text = reader["ServiceArea"].ToString();
                    lblStipendText.Text = reader["Participants"].ToString();
                    DateTime dt2 = new DateTime();
                    dt2 = (DateTime)reader["LastUpdated"];
                    lblLastUpdatedText.Text = dt2.ToString("dd/mm/yyyy");



                }

                //for (int field = 0; field < reader.FieldCount; field++)
                //{
                //    string oneValue = reader.GetValue(field).ToString();

                //    res.Add(oneValue);
                //}
                reader.Close();
                con.Close();                
            }
            catch (Exception err)
            {
                ltrlSqlError.Text = err.ToString();
                
            }
            finally
            {
                con.Close();

            }

        }//End PopulateProgram





        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("search.aspx");
            
        }










    }//End programdetails
}