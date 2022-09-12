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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bank_Medicine
{
    public partial class ForgetPasswordPage : Form
    {
        public ForgetPasswordPage()
        {
            InitializeComponent();
        }

        private void ButtonUpdatePassword_Click(object sender, EventArgs e)
        {

            SqlConnection Sqlforgot;
            Sqlforgot = ConnectionHelper.GetConnection();
            TextUpdateEmail.Text = TextUpdateEmail.Text.ToLower();  // convert all input text into lowercase.

            try
            {
                Sqlforgot.Open();

                if (TextUpdatePass.TextLength < 8)
                {
                    MessageBox.Show("Password should be contain 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (TextUpdatePass.Text != TextConPass.Text)
                    {
                        MessageBox.Show("New Password not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String forgotquery = "update table1 set Password=@passkey where EmailID=@email";
                        SqlCommand fogotcmd = new SqlCommand(forgotquery, Sqlforgot);
                        fogotcmd.Parameters.AddWithValue("@passkey", TextUpdatePass.Text);
                        fogotcmd.Parameters.AddWithValue("@email", TextUpdateEmail.Text);

                        int u = fogotcmd.ExecuteNonQuery();
                        Sqlforgot.Close();
                        if (u > 0)
                        {
                            MessageBox.Show("Password Changed Sucessfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Password Not Changed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Below codes check and if password match then show this "✔️" message and if not then "❌"
        private void TextConPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (TextUpdatePass.Text == TextConPass.Text)
            {
                CheckBoxShow.Text = "✔️";
                CheckBoxShow.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                CheckBoxShow.Text = "❌";
                CheckBoxShow.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(TextConPass.PasswordChar == '*')
            {
                btnHide.BringToFront();
                TextConPass.PasswordChar = '\0';
            }
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (TextConPass.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                TextConPass.PasswordChar = '*';
            }
         
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            Login_Page1 lg = new Login_Page1();
            lg.Show();
            this.Hide();
        }
    }
}
