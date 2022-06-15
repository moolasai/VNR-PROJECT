using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace login_assignment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-VSIH0EOS;initial catalog=sql tutorial;user id=sudha;password=akki1");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from akki_vnr where emailid=@emailid and password=@password", con);
                cmd.Parameters.AddWithValue("@emailid", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpwd.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["Status"].ToString().ToLower() == "true")
                    {
                        if (dr["Role"].ToString() == "Student")
                        {
                          
                            Response.Redirect("student.aspx");
                        }
                        if (dr["Role"].ToString() == "HOD")
                        {
                            Response.Redirect("hod.aspx");
                        }
                        else
                        {
                            Response.Redirect("home.aspx");
                        }



                    }
                    else
                    {
                        Response.Write("User is Inactive");
                    }

                }
                else
                {
                    Response.Write("Username or pwd is Invalid!");
                }
            }
            catch (Exception ex)
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