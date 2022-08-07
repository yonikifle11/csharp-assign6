using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updateform
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            string Email = tb1.Text;
            string Password = tb2.Text;
            if ((tb1.Text=="Admin") && (tb2.Text == "Admin"))
            {
                this.Hide();
                Form1 form = new Form1();
                MessageBox.Show("you are granted access");
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("you are not granted  access " +
                    " input correct pass");
            }

        }

    private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
