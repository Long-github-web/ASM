using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {

            if (tb1.Text.ToLower() == "dam huu hoang long" && tb2.Text.ToLower() == "1234")
            {
                Form4 caculateForm = new Form4();
                this.Hide();
                caculateForm.ShowDialog();


            }
            else
            {
                DialogResult exit = MessageBox.Show("Please enter correct account password", "Notice",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure about to exit ?", "Notice",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
