using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Medicine
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            Registration newForm = new Registration();
            newForm.Show();  // this line of code help to open new(REgistration page)
            this.Hide();     // to hide privious page in the registration
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_Page1 pgm = new Login_Page1();
            pgm.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME hm = new HOME();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About_Us au = new About_Us();
            au.Show();
            this.Hide();
        }
    }
}
