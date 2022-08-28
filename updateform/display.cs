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
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }

        private void display_Load(object sender, EventArgs e)
        {
            foreach (var item in Class1.GetAllProducts())
            {
                productcard pc = new productcard();
                pc.number = item.number;
                pc.date = item.date;
                pc.InventoryNumber= item.InventoryNumber;
                pc.objectName = item.objectName;
                pc.count = item.count;
                pc.price = item.price;
                pc.Click += (Object o, EventArgs e2) =>
                {
                    detail d = new detail(item.number, item.date, item.InventoryNumber, item.objectName, item.count, item.price);
                    d.Show();
                };
               // flowLayoutPanel1.Controls.Add(pc);
            }
        }

        private void display_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
