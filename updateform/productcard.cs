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
    public partial class productcard : Form
    {
        public productcard()
        {
            InitializeComponent();
        }

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
            private string m_num;
            public string number
            {
                get { return m_num; }
                set { m_num = value; label1.Text = value.ToString(); }
            }
            private string m_date;
            public string date
            {
                get { return m_date; }
                set { m_date = value; label2.Text = value; }
            }

            private string m_InvNum;
            public string InventoryNumber
            {
                get { return m_InvNum; }
                set { m_InvNum = value; label3.Text = value.ToString(); }
            }

            private string m_objName;
            public string objectName
            {
                get { return m_objName; }
                set { m_objName = value; label4.Text = value.ToString(); }
            }
            private string m_count;
            public string count
            {
                get { return m_count; }
                set { m_count = value; label5.Text = value.ToString(); }
            }

            private string m_price;
            public string price
            {
                get { return m_price; }
                set { m_price = value; label6.Text = value.ToString(); }
            }


            internal productcard findOne(object text)
            {
                throw new NotImplementedException();
            }

            private void productcard_Load(object sender, EventArgs e)
            {

            }
        }
        //anonymous fuvtion on click//no func name but body yenorewal

    }


   
    

