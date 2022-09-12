using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Medicine
{

    public partial class Login_Page1 : Form
    {
        public Login_Page1()
        {
            InitializeComponent();

        }

        private void Login_Page1_Load(object sender, EventArgs e)
        {

        }

        private void LoginPageButtton_Click(object sender, EventArgs e)
        {

            SqlConnection LogConn;
            LogConn = ConnectionHelper.GetConnection();
            LoginID1.Text = LoginID1.Text.ToLower();

             SqlDataAdapter adapter = new SqlDataAdapter("select *from table1", LogConn);
             DataSet ds = new DataSet();
             adapter.Fill(ds, "table1");
             bool isEmail = false;
             bool isPassword = false;

             foreach (DataRow dr in ds.Tables["table1"].Rows)
             {
                 if ((LoginID1.Text.Equals(dr["EmailID"])) && (LoginPassword1.Text.Equals(dr["Password"])))
                 {
                     isEmail = true;
                     isPassword = true;
                     break;
                 }
                 else if((! LoginID1.Text.Equals(dr["EmailID"])) && (LoginPassword1.Text.Equals(dr["Password"])))
                 {
                     isEmail = false;
                     isPassword = true;
                     break;
                 }
                 else if ((LoginID1.Text.Equals(dr["EmailID"])) && (! LoginPassword1.Text.Equals(dr["Password"])))
                 {
                     isEmail = true;
                     isPassword = false;
                     break;
                 }
             }

                     if (isEmail == true && isPassword == true)
                     {
                         MessageBox.Show("Log in successfully", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         Menu_Page mn = new Menu_Page();
                         mn.Show();
                         this.Hide();
                     }
                     else if (isEmail == true && isPassword == false)
                     {
                         MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);       
                     }
                     else if (isPassword == true && isEmail == false)
                     {
                         MessageBox.Show("Email is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     else
                     {
                         MessageBox.Show("Either Email or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }

        }

        private void RegToHomeBtn_Click(object sender, EventArgs e)
        {
            HOME backHome = new HOME();
            backHome.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgetPasswordPage fpp = new ForgetPasswordPage();
            fpp.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Registration rs = new Registration();
            rs.Show();
            this.Hide();
        }


    }
}
 