using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Student_Register
{
    public partial class Register_Page : System.Web.UI.Page
    {
        string connstr = @"Server = NDVORSVR02\SQL2014; Initial Catalog=student_info;User ID=wmuser1;Password=wmuser1";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();

            }
        }


        public void BindGrid()
        {

            using (SqlConnection con = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand("GetStudentDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@studentId", SqlDbType.VarChar).Value = "Select";
                    //cmd.Parameters.Add("@studentFirst_name", SqlDbType.VarChar).Value = "Select";
                    con.Open();

                    DataTable dt = new DataTable();
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.Fill(dt);
                    }
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    con.Close();
                }
            }
        }
        protected void Insert(string studentFirst_name, string studentLast_name, string student_gender, string dateOfBirth, string Password, string student_mobileno, string student_address)
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand("GetStudentData", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@studentId", SqlDbType.Int).Value = txtstudentId.Text;
                    cmd.Parameters.Add("@studentFirst_name", SqlDbType.VarChar).Value = txtName.Text;
                    cmd.Parameters.Add("@studentLast_name", SqlDbType.VarChar).Value = txtLastName.Text;
                    cmd.Parameters.Add("@student_gender", SqlDbType.VarChar).Value = RadioButtonList1.Text;
                    cmd.Parameters.Add("@student_Dob", SqlDbType.Date).Value = txtDob.Text;
                    cmd.Parameters.Add("@Passsword", SqlDbType.VarChar).Value = TextPassword.Text;
                    cmd.Parameters.Add("@student_mobileno", SqlDbType.VarChar).Value = txtMblNo.Text;
                    cmd.Parameters.Add("@student_address", SqlDbType.VarChar).Value = txtAddress.Text;
                    cmd.Parameters.Add("@statementType", SqlDbType.VarChar).Value = "Insert";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    BindGrid();
                }
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Insert(txtName.Text, txtLastName.Text, RadioButtonList1.Text, txtDob.Text, TextPassword.Text, txtMblNo.Text, txtAddress.Text);
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            txtstudentId.Text = String.Empty;
            txtName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            RadioButtonList1.Text = String.Empty;
            txtDob.Text = String.Empty;
            TextPassword.Text = String.Empty;
            txtDob.Text = String.Empty;
            txtMblNo.Text = String.Empty;
            txtAddress.Text = String.Empty;
        }
       

         protected void Delete()
        {
            using (SqlConnection con = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand("GetStudentData", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@statementType", "Delete");  
                    cmd.Parameters.AddWithValue("@studentId", txtstudentId.Text);
                    cmd.Parameters.AddWithValue("@studentFirst_name", txtName.Text);
                    cmd.Parameters.AddWithValue("@studentLast_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@student_gender", RadioButtonList1.Text);
                    cmd.Parameters.AddWithValue("@student_Dob", txtDob.Text);
                    cmd.Parameters.AddWithValue("@Passsword", TextPassword.Text);
                    cmd.Parameters.AddWithValue("@student_mobileno", txtMblNo.Text);
                    cmd.Parameters.AddWithValue("@student_address", txtAddress.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    BindGrid();
                }
            }
        }
        protected void ButtonDelte_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }

}


