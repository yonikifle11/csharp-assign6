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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void searchbttn_Click(object sender, EventArgs e)
        {

                List<productcard> Data = new List<productcard>();
            var pro = Class1.findOne(tbsearch.Text);
            
            if (pro == null)
                     {
                         MessageBox.Show("product not found.", "no result");
                     }
                     else
                       {
                         MessageBox.Show("product  found.");
                       }

                     }

        private void tbsearch_Click(object sender, EventArgs e)
        {

        }
    }
             }
         
        
    
