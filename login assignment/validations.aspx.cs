using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace login_assignment
{
    public partial class validations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                GetCountry();
            }
        }
        public void GetCountry()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VSIH0EOS;Initial catalog=sql tutorial;Integrated security=true");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from country", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlcountry.DataTextField = "Country";
                ddlcountry.DataValueField = "CountryId";
                ddlcountry.DataSource = dt;
                ddlcountry.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VSIH0EOS;Initial catalog=sql tutorial;Integrated security=true");
            try
            {
                SqlCommand cmd = new SqlCommand("select * from countryState where countryid=@countryid", con);
                cmd.Parameters.AddWithValue("@countryid", ddlcountry.SelectedItem.Value);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                ddlstate.DataTextField = "state";
                ddlstate.DataValueField = "stateid";
                ddlstate.DataSource = dt;
                ddlstate.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VSIH0EOS;Initial catalog=sql tutorial;Integrated security=true");
            try
            {
                SqlCommand cmd = new SqlCommand("select * from countryState where countryid=@countryid", con);
                cmd.Parameters.AddWithValue("@countryid", ddlcountry.SelectedItem.Value);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                ddlstate.DataTextField = "state";
                ddlstate.DataValueField = "stateid";
                ddlstate.DataSource = dt;
                ddlstate.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}