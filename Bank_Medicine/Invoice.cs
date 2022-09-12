using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Bank_Medicine
{
    public partial class Invoice : Form
    {

        public double resultTotal = 0;     // I am using this variable globally..
        public void UpdateMedQty(string paramName, string paramQty, TextBox paramPrice, TextBox paramTotal)
        {

           string con = ConfigurationManager.ConnectionStrings["MedicineData"].ConnectionString;
           SqlConnection sqlconn = new SqlConnection(con);

            try
            {
                SqlDataAdapter adap = new SqlDataAdapter("select * from table1 where Medicine_Name = @MedName", sqlconn);
                adap.SelectCommand.Parameters.AddWithValue("@MedName", paramName);
  
                SqlCommandBuilder cmd = new SqlCommandBuilder(adap);
                DataSet ds = new DataSet();
                adap.Fill(ds, "table1");
                DataRow dr = ds.Tables["table1"].Rows[0];  // if medicine found in the database then it returns greater than 0
                if (dr != null)                            // if medicine not found in the database then it returns 0 and since I am try and catch block 
                                                           // so command will come to catch block and print the statement.
                {
                    dr["Quantity"] = Convert.ToInt32(dr["Quantity"]) - Convert.ToInt32(paramQty);

                    paramPrice.Text = Convert.ToString(dr["Rupees"]);
                    paramTotal.Text = Convert.ToString(Convert.ToDouble(dr["Rupees"]) * Convert.ToInt32(paramQty));
                   
                    double sTotal = Convert.ToDouble(dr["Rupees"]) * Convert.ToDouble(paramQty);
                    resultTotal += sTotal;    
                    adap.Update(ds, "table1");    //  without this line database datas will not update.
                }
            }
            catch(Exception)
            {
                MessageBox.Show(paramName + " Spelling Mistake");
                resultTotal = 0;   // whenever user input wrong medicine name then resulTotal value will be 0 and start 
                                   // start the process from starting.
            }
        }

        public void foo(TextBox tBox, TextBox tQty, TextBox tPrice, TextBox tTotal)
        {
            if (tBox.Text == "")
            {
                MessageBox.Show("Please Enter Medicine Name");
            }
            else if (tQty.Text == "")
            {
                MessageBox.Show("Please Enter Medicine Quantity");
            }
            else
            {
                string textValueName1 = tBox.Text.ToString();
                string textValueQty1 = tQty.Text.ToString();
                UpdateMedQty(textValueName1, textValueQty1, tPrice, tTotal);
            }
        }

        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
           

        }
        private void BACK_Click(object sender, EventArgs e)
        {
            Menu_Page mn = new Menu_Page();
            mn.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                foo(textBox1, textQty1, textPrice1, textTotal1);
            }
            if (textBox2.Text != "")
            {
                foo(textBox2, textQty2, textPrice2, textTotal2);
            }
            if (textBox3.Text != "")
            {
                foo(textBox3, textQty3, textPrice3, textTotal3);
            }
            if (textBox4.Text != "")
            {
                foo(textBox4, textQty4, textPrice4, textTotal4);
            }
            if (textBox5.Text != "")
            {
                foo(textBox5, textQty5, textPrice5, textTotal5);
            }
            if(textBox6.Text != "")
            {
                foo(textBox6, textQty6, textPrice6, textTotal6);
            }
             if(textBox7.Text != "")
            {
                foo(textBox7, textQty7, textPrice7, textTotal7);
            }
            if(textBox8.Text != "")
            {
                foo(textBox8, textQty8, textPrice8, textTotal8);
            }
             if (textBox9.Text != "")
            {
                foo(textBox9, textQty9, textPrice9, textTotal9);
            }
            if (textBox10.Text != "")
            {
                foo(textBox10, textQty10, textPrice10, textTotal10);
            }
            if(textBox11.Text != "")
            {
                foo(textBox11, textQty11, textPrice11, textTotal11);
            }

            // display the value on the sub total text box
            if(Convert.ToDouble(resultTotal) > 0)
            {
                textSubTotal.Text = Convert.ToString(resultTotal);

                double gst = (double)resultTotal*(double)0.18;
                textTax.Text = Convert.ToString(gst);
                double gstPlusTotal = (resultTotal + gst);
                textTotal.Text = Convert.ToString(gstPlusTotal);

                btnSave.Enabled = false;   // to disable the btnSave
            }
            
        }

        private void Home_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out?", "Logout", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Logout Successfully", "Logout Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login_Page1 lg  = new Login_Page1();
                lg.Show();
                this.Hide();
            }
        }
    }
}
