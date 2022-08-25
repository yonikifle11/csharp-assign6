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
    public partial class productcard : UserControl
    {
        private String _name;

        public String name
        {
            get { return name; }
            set { name = value; }
        }
        private String _description;

        public String description
        {
            get { return _description; }
            set { _description = value; }
        }

        internal productcard findOne(object text)
        {
            throw new NotImplementedException();
        }

        private int _price;

        public int price
        {
            get { return _price; }
            set { _price = value; }
        }
        //anonymous fuvtion on click//no func name but body yenorewal
        
        public productcard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productcard_Load(object sender, EventArgs e)
        {

        }
    }
}
