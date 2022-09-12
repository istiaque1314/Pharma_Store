using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_Medicine
{
    public partial class Menu_Page : Form
    {
        public void mustinput()
        {
            if (textMname.Text == "")
            {
                MessageBox.Show("Please Type a Medicine Name");
                textMname.Focus();
            }
            else if (textMrp.Text == "")
            {
                MessageBox.Show("Please Enter MRP ");
                textMrp.Focus();
            }
            else if (textQty.Text == "")
            {
                MessageBox.Show("Please Enter Quantity");
                textQty.Focus();
            }
        }


        public Menu_Page()
        {
            InitializeComponent();
        }

        private void Menu_Page_Load(object sender, EventArgs e)
        {
            string loadConn = ConfigurationManager.ConnectionStrings["MedicineData"].ConnectionString;
            SqlConnection SqlLoadConn = new SqlConnection(loadConn);
            String medquery = "select*from table1";
            SqlCommand medcmd = new SqlCommand(medquery, SqlLoadConn);
            SqlDataAdapter ad = new SqlDataAdapter(medcmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            meddatatable.DataSource = dt;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            string SqlConn = ConfigurationManager.ConnectionStrings["MedicineData"].ConnectionString;
            using (SqlConnection searchCon = new SqlConnection(SqlConn))
            {
                using (SqlCommand cmd = new SqlCommand())  // if we use "using" then we dont need to open and close the connection
                {

                    string sql = "SELECT Sl_No, Medicine_Name, Rupees, Quantity FROM table1";
                    if (!string.IsNullOrEmpty(TextSearch.Text.Trim()))  // trim function remove all the white space.
                    {
                        sql += " WHERE Medicine_Name LIKE @Medicine_Name + '%'";    // like operator makes easy to search , like if user input one character 'R' then 
                                                                                    // all medicines start with 'R' display on the gridview
                        cmd.Parameters.AddWithValue("@Medicine_Name", TextSearch.Text.Trim());
                    }
                    cmd.CommandText = sql;
                    cmd.Connection = searchCon;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        meddatatable.DataSource = dt;
                    }
                }
            }

        }

        private void Home_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Logout Successfully", "Logout Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login_Page1 lg = new Login_Page1();
                lg.Show();
                this.Hide();
            }
        }

        private void meddatatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {

            string con = ConfigurationManager.ConnectionStrings["MedicineData"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(con);

            if (textMedName.Text == "")
            {
                MessageBox.Show("Please enter Medicine Name");
            }
            else if (textMedQty.Text == "")
            {
                MessageBox.Show("Please enter Medicine quantity");
            }
            else
            {

                SqlDataAdapter adap = new SqlDataAdapter("select * from table1 where Medicine_Name = @MedName", sqlconn);
                adap.SelectCommand.Parameters.AddWithValue("@MedName", textMedName.Text);
                SqlCommandBuilder cmd = new SqlCommandBuilder(adap);
                DataSet ds = new DataSet();
                adap.Fill(ds, "table1");
                DataRow dr = ds.Tables["table1"].Rows[0];

                if (dr != null)
                {
                    dr["Quantity"] = Convert.ToInt32(dr["Quantity"]) + Convert.ToInt32(textMedQty.Text);
                    MessageBox.Show("Medicine Inserted");
                    adap.Update(ds, "table1");
                }
            }

        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Invoice inc = new Invoice();
            inc.Show();
            this.Hide();

        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            string sqlconn = ConfigurationManager.ConnectionStrings["MedicineData"].ConnectionString;
            SqlConnection menucon = new SqlConnection(sqlconn);
            if (textMname.Text.Length == 0 || textMrp.Text.Length == 0 || textQty.Text.Length == 0)
            {
                mustinput();
            }
            else
            {
                try
                {
                    menucon.Open();

                    SqlDataAdapter adap = new SqlDataAdapter("select Medicine_Name from table1 where Medicine_Name='" + textMname.Text + "'", menucon);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("This Medicine already in Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        String medadd = "insert into table1 values(@medname,@mrp,@qty)";
                        SqlCommand cmd = new SqlCommand(medadd, menucon);
                        cmd.Parameters.AddWithValue("@medname", textMname.Text);
                        cmd.Parameters.AddWithValue("@mrp", textMrp.Text);
                        cmd.Parameters.AddWithValue("@qty", textQty.Text);

                        int i = cmd.ExecuteNonQuery();

                        menucon.Close();

                        if (i > 0)
                        {
                            MessageBox.Show("New medicine Stocked Sucessfully", "Medicine Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            textMname.Text = "";
                            textMrp.Text = "";
                            textQty.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to stock new Medicine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

   
    }
    
}   
