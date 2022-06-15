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
    public partial class register : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VSIH0EOS;initial catalog=sql tutorial;Integrated security=true");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sl_insert", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@emailid", txtemail.Text);
                cmd.Parameters.AddWithValue("@password", txtpwd.Text);
                cmd.Parameters.AddWithValue("@dob", txtdob.Text);
                cmd.Parameters.AddWithValue("@gender", rdgender.SelectedValue);
                cmd.Parameters.AddWithValue("@department", dddldept.SelectedValue);
                cmd.Parameters.AddWithValue("@role", ddlrole.SelectedValue);
                cmd.Parameters.AddWithValue("@status", ddlstatus.SelectedValue);
                int y = cmd.ExecuteNonQuery();
                if(y>0)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Response.Write("Oops ! something wrong");
                }

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        
    }
}