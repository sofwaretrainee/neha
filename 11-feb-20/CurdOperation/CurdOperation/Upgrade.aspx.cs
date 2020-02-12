using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CurdOperation
{
    public partial class Upgrade : System.Web.UI.Page
    {
        SqlDataReader dataReader;
        string connectionString;
        SqlCommand command;
        SqlConnection cnn;
        String sql;
        int userId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnCancel.Visible = true;
            btnUpdate.Visible = false;
            if (Request.QueryString["userId"] != null)
            {
                userId = Convert.ToInt32(Request.QueryString["userId"].ToString());
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnAdd.Visible = false; ;

            }
            if (!IsPostBack)
            {
                BindTextBoxvalues();
            }

        }
        //protected void Insert(object sender, EventArgs e)
        //{
        //    DataTable dt = (DataTable)ViewState["Employee_details"];
        //    dt.Rows.Add(txtFirstName.Text.Trim(), txtLastname.Text.Trim());
        //    ViewState["Employee_details"] = dt;
        //    this.BindGrid();
        //    txtFirstName.Text = String.Empty;
        //    txtLastname.Text = String.Empty;
        //    txtmailid.Text = String.Empty;
        //    txtPassword.Text = String.Empty;
        //    txtGender.Text = String.Empty;
        //    txtDob.Text = String.Empty;
        //    txtMobile.Text = String.Empty;
        //    txtAddress.Text = String.Empty;
        //}

        private void BindGrid()
        {
            throw new NotImplementedException();
        }



        private void BindTextBoxvalues()
        {
            SqlConnection con = new SqlConnection(@"Server = NDVORSVR02\SQL2014; Initial Catalog=employee_details;User ID=wmuser1;Password=wmuser1");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee_details where userId='" + userId + "'", con);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataReader = cmd.ExecuteReader();
            if (dt.Rows.Count > 0)
            {
                txtFirstName.Text = dt.Rows[0][1].ToString();
                txtLastname.Text = dt.Rows[0][2].ToString();
                txtmailid.Text = dt.Rows[0][3].ToString();
                txtPassword.Text = dt.Rows[0][4].ToString();
                txtGender.Text = dt.Rows[0][5].ToString();
                txtDob.Text = dt.Rows[0][6].ToString();
                txtMobile.Text = dt.Rows[0][7].ToString();
                txtAddress.Text = dt.Rows[0][8].ToString();
            }

            con.Close();
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (userId != null)
            {
                SqlConnection con = new SqlConnection(@"Server = NDVORSVR02\SQL2014; Initial Catalog=employee_details;User ID=wmuser1;Password=wmuser1");
                con.Open();

                SqlCommand cmd = new SqlCommand("update Employee_details set First_Name='" + txtFirstName.Text + "',Last_name='" + txtLastname.Text + "',mailid='" + txtmailid.Text + "',Password='" + txtPassword.Text + "',Gender='" + txtGender.Text + "',dateOfBirth='" + txtDob.Text + "',Mobile='" + txtMobile.Text + "',Address='" + txtAddress.Text + "'  where userId=" + userId + "", con);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowSuccess", "javascript:alert('Record Updated Successfully');", true);
                }
                con.Close();
                Response.Redirect("~/Update.aspx");

            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[8] { new DataColumn("First_Name"), new DataColumn("Last_name"), new DataColumn("mailId"), new DataColumn("Password"), new DataColumn("Gender"), new DataColumn("dateOfBirth"), new DataColumn("Mobile"), new DataColumn("Address") });
                ViewState["Employee_details"] = dt;
                this.BindGrid();
            }
        }


        private void AddNewUser(string First_name, string Last_name,string mailId,string Password,string Gender,string dateOfBirth,string Mobile,string Address)
        {
            SqlConnection con = new SqlConnection(@"Server = NDVORSVR02\SQL2014; Initial Catalog=employee_details;User ID=wmuser1;Password=wmuser1");
           

            try
            {
                con.Open();
                String query = "INSERT INTO Employee_details  ([First_name],[Last_name],[mailId],[Password],[Gender],[dateOfBirth],[Mobile],[Address]) VALUES (@First_name,@Last_name,@mailId, @Password,@Gender,@dateOfBirth,@Mobile,@Address)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@First_name", First_name);
                cmd.Parameters.AddWithValue("@Last_name", Last_name);
                cmd.Parameters.AddWithValue("@mailId", mailId);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
                con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                //Console.ReadKey();
                //Response.Redirect("~/Update.aspx");
            }
           
            

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {

            txtFirstName.Text = String.Empty;
            txtLastname.Text = String.Empty;
            txtmailid.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtGender.Text = String.Empty;
            txtDob.Text = String.Empty;
            txtMobile.Text = String.Empty;
            txtAddress.Text = String.Empty;

        }
        protected void AddNewRowToGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[8] { new DataColumn("First_Name"), new DataColumn("Last_name"), new DataColumn("mailId"), new DataColumn("Password"), new DataColumn("Gender"), new DataColumn("dateOfBirth"), new DataColumn("Mobile"), new DataColumn("Address") });
            ViewState["Employee_details"] = dt;
            //this.BindGrid();
            Response.Redirect("~/Update.aspx");
            //DataTable dt = new DataTable();
            //DataRow dr = null;
            //dt.Columns.Add(new DataColumn("Column1", typeof(string)));
            //dt.Columns.Add(new DataColumn("Column2", typeof(string)));
            //dr = dt.NewRow();
            //dr["Column1"] = string.Empty;
            //dr["Column2"] = string.Empty;
            //dt.Rows.Add(dr);
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // AddNewRowToGrid();
            try
            {
                AddNewUser(txtFirstName.Text, txtLastname.Text, txtmailid.Text, txtPassword.Text, txtGender.Text, txtDob.Text, txtMobile.Text, txtAddress.Text);
                Response.Redirect("~/Update.aspx");
            }
            catch (Exception ex) { }
        }
    }

}

