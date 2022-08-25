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
            main screen = new main();
            string Email = tb1.Text;
            string Password = tb2.Text;
            if ((tb1.Text=="Admin") && (tb2.Text == "Admin"))
            {
                //this.Hide();
                directory form = new directory();
                MessageBox.Show("you're granted access");
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("you're not granted  access " +
                    " input correct pass");
            }

        }

    private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
