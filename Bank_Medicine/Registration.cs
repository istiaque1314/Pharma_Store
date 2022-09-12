using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_Medicine
{
    public partial class Registration : Form
    {
        // check below codes whether user input all the details or not 
        public void EnterAllDetailsOrNot()
        {

            if (TextID.Text == "")
            {
                MessageBox.Show("Enter Employee ID");
                TextID.Focus();
            }
            else if (TextName.Text == "")
            {
                MessageBox.Show("Enter First Name");
                TextName.Focus();
            }
            else if (TextEmail.Text == "")
            {
                MessageBox.Show("Enter Last Name");
                TextEmail.Focus();
            }
            else if (TextPassword.Text == "")
            {
                MessageBox.Show("Enter Employee salary");
                TextPassword.Focus();
            }
        
        }

        public Registration()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConn;
            sqlConn = ConnectionHelper.GetConnection();
            TextEmail.Text = TextEmail.Text.ToLower();

            // Test.Length == 0, means text is equal to empty
            if (TextID.Text.Length == 0 || TextName.Text.Length == 0 || TextEmail.Text.Length == 0 || TextPassword.Text.Length == 0)
            {
                EnterAllDetailsOrNot();
            }
            else
            {

                try
                {

                 SqlDataAdapter adap = new SqlDataAdapter("select *from table1", sqlConn);
                 DataSet ds = new DataSet();
                 adap.Fill(ds, "table1");
                 bool IsEmail = false;
                 bool IsUserID = false;

                  foreach (DataRow dr in ds.Tables["table1"].Rows)
                  {
                     int id = Convert.ToInt32(TextID.Text);
                     if ((id.Equals(dr["UserID"])) && (!TextEmail.Text.Equals(dr["EmailID"])))
                     {
                        IsEmail = false;
                        IsUserID = true;
                        break;
                     }
                      else if ((!id.Equals(dr["UserID"])) && (TextEmail.Text.Equals(dr["EmailID"])))
                      {
                        IsEmail = true;
                         IsUserID = false;
                         break;
                      }
                  }

                if (IsEmail == false && IsUserID == true)
                {
                  MessageBox.Show("User ID is already exist");

                }
                else if (IsEmail == true && IsUserID == false)
                {
                  MessageBox.Show("Email ID is already exist");
                }

                else
                {
                   sqlConn.Open();

                if (TextPassword.TextLength < 8)
                {
                  MessageBox.Show("Password must be 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                if (!TextPassword.Text.Equals(TextConfirmPass.Text))
                {
                   MessageBox.Show("Password not Matched", " Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                  string query = "insert into table1(UserID, UserName, EmailID, Password, Registration_Date) values(@userId, @user_name, @email_id, @password, @registration)";
                  SqlCommand cmd = new SqlCommand(query, sqlConn);
                  cmd.Parameters.AddWithValue("@userId", TextID.Text);
                  cmd.Parameters.AddWithValue("@user_name", TextName.Text);
                  cmd.Parameters.AddWithValue("@email_id", TextEmail.Text);
                  cmd.Parameters.AddWithValue("@password", TextPassword.Text);
                  cmd.Parameters.AddWithValue("@registration", dateRegistration.Text);

                  int i = cmd.ExecuteNonQuery();
                  sqlConn.Close();
                  if (i > 0)
                  {
                    MessageBox.Show("Sign up successfully", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login_Page1 lp = new Login_Page1();
                    lp.Show();
                    this.Hide();
                  }
                else
                {
                   MessageBox.Show("Error!! Unable to SignUP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }

           }
         }                          
                            
      }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_Page1 pg = new Login_Page1();
            pg.Show();
            this.Hide();
        }

        private void RegToHomeBtn_Click(object sender, EventArgs e)
        {
            HOME backHome = new HOME();
            backHome.Show();
            this.Hide();
        }
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (TextConfirmPass.PasswordChar == '*')
            {
                btnHide.BringToFront();
                TextConfirmPass.PasswordChar = '\0';
            }
        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            if (TextConfirmPass.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                TextConfirmPass.PasswordChar = '*';
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            HOME hm = new HOME();
            hm.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void TextConfirmPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (TextPassword.Text == TextConfirmPass.Text)
            {
                lebelSign.Text = "✔️";
                lebelSign.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lebelSign.Text = "❌";
                lebelSign.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
