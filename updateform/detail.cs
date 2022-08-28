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
    public partial class detail : Form
    {
        public detail(string num, string date, string InvNum, string objName, string count, string price)
        {
            InitializeComponent();
            label1.Text = "number: " + num;
            label2.Text = "Date: " + date;
            label3.Text = "InvNum: " + InvNum.ToString();
            label4.Text = "objName: " + objName;
            label5.Text = "Count: " + count.ToString();
            label6.Text = "Price: " + price.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void detail_Load(object sender, EventArgs e)
        {

        }
    }
}
