using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lb6_Click(object sender, EventArgs e)
        {
            lb12.Text = Form4.id;
            lb13.Text = Form4.name;
            lb14.Text = Form4.phone;
            if (Form4.typeofcustomer == 0)
            {
                lb15.Text = "Household\r\ncustomer";

            }
            else if (Form4.typeofcustomer == 1)
            {
                lb15.Text = "Administrative\r\nagency";
            }
            else if (Form4.typeofcustomer == 2)
            {
                lb15.Text = "Production\r\nunits";
            }
            else if(Form4.typeofcustomer == 3)
            {
                lb15.Text = "Business\r\nservices";
            }
            else
            {
                lb15.Text = "";
            }
            lb16.Text = Form4.waterLastmonth.ToString();
            lb16.Text = Form4.waterThismonth.ToString();
            double amount = Form4.waterThismonth - Form4.waterLastmonth;
            lb18.Text = amount.ToString();




        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void lb9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
