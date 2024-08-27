using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static string ID = null;
        public static string Name = null;
        public static string Phone = null;
        public static int Typeofcustomer = -1;
        public static double Lastmonth = 0;
        public static double Thismonth = 0;
        public static int Numberofmembers = 0;
        public static double Amountofwater = 0;
        public static double Total = 0;
        public static double Price = 0;
        private void Form4_Load(object sender, EventArgs e)
        {

            {

                lsv1.View = View.Details;

                lsv1.Columns.Add("ID", 100);
                lsv1.Columns.Add("Name", 100);
                lsv1.Columns.Add("Phone", 150);
                lsv1.Columns.Add("Type of customer", 150);
                lsv1.Columns.Add("Number of members", 100);
                lsv1.Columns.Add("This month", 150);
                lsv1.Columns.Add("Last month", 150);
                lsv1.Columns.Add("Total", 150);
                lsv1.Columns.Add("Description", 150);

                ListViewItem row1 = new ListViewItem();
                row1.Text = "1";
                row1.SubItems.Add("D");
                row1.SubItems.Add("11111");
                row1.SubItems.Add("Household");
                row1.SubItems.Add("5");
                row1.SubItems.Add("200");
                row1.SubItems.Add("100");
                row1.SubItems.Add("100");
                lsv1.Items.Add(row1);


                ListViewItem row2 = new ListViewItem();
                row2.Text = "2";
                row2.SubItems.Add("M");
                row2.SubItems.Add("22222");
                row2.SubItems.Add("Business services");
                row2.SubItems.Add("5");
                row2.SubItems.Add("100");
                row2.SubItems.Add("50");
                row2.SubItems.Add("100");
                lsv1.Items.Add(row2);

                //tb1.Text = Form4.ID;
                //tb2.Text = Form4.Name;
                //tb3.Text = Form4.Phone;
                //if (Form4.Typeofcustomer == 0)
                //{
                //    cb1.Text = "Household\r\ncustomer";
                //}
                //else if (Form4.Typeofcustomer == 1)
                //{
                //    cb1.Text += "";
                //    cb1.Text = "Administrative\r\nagency,\r\n public services";
                //}
                //else if (Form4.Typeofcustomer == 2)
                //{
                //    cb1.Text = "Product\r\nunits";
                //}
                //else if (Form4.Typeofcustomer == 3)
                //{
                //    cb1.Text = "Business\r\nservices";
                //}
                //else
                //{
                //    lb4.Text = "";
                //}
                //tb6.Text = Form4.Thismonth.ToString();
                //tb7.Text = Form4.Lastmonth.ToString();
                //tb8.Text = Form4.Amountofwater.ToString();
                //double roundedPrice = Math.Round(Form4.Total, 2);
                //tb11.Text = roundedPrice.ToString();
                //double evrmt = Math.Round(Form4.Price * 0.1);
                //double roundedValue = Math.Round(evrmt, 2);
                //double roundedTotal = Math.Round(Form4.Total * 2);
                //tb9.Text = roundedPrice.ToString();
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {

            string ID = tb1.Text;

            string Name = tb2.Text;

            string Phone = tb3.Text;

            string Typeofcustomer = null;

            string Numberofmember = tb5.Text;

            string Thismonth = tb6.Text;

            string Lastmonth = tb7.Text;

            string Total = tb9.Text;

            string Description = tb10.Text;

            double cost = 0;

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please Enter ID Customer ", "Notice",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb1.Focus();
            }
            else if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please Enter Customer Name ", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb2.Focus();
            }
            else if (string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Please Enter Phone Number", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb3.Focus();
            }
            else if (string.IsNullOrEmpty(Numberofmember))
            {
                MessageBox.Show("Please Enter Number Of Member", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb1.Focus();
            }
            else if (string.IsNullOrEmpty(Thismonth))
            {
                MessageBox.Show("Please Enter Amount Of Water Used This Month", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb5.Focus();
            }
            else if (string.IsNullOrEmpty(Lastmonth))
            {
                MessageBox.Show("Please Enter Amount Of Water Used Last Month", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb6.Focus();
            }
            else if (string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Please Enter Description ", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb9.Focus();
            }

            if (cb1.SelectedIndex == 0)
            {
                Typeofcustomer = "Household";
            }
            else if (cb1.SelectedIndex == 1)
            {
                Typeofcustomer = "Administrative agency";
                cost = 9.955;
            }
            else if (cb1.SelectedIndex == 2)
            {
                Typeofcustomer = "Production units";
                cost = 11.615;
            }
            else if (cb1.SelectedIndex == 3)
            {
                Typeofcustomer = "Business services";
                cost = 22.068;
            }
            else
            {
                MessageBox.Show("Please enter Type of customer", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


                ListViewItem item = new ListViewItem();
                item.Text = ID;
                item.SubItems.Add(Name);
                item.SubItems.Add(Phone);
                item.SubItems.Add(Typeofcustomer);
                item.SubItems.Add(Numberofmember);
                item.SubItems.Add(Thismonth);
                item.SubItems.Add(Lastmonth);
                item.SubItems.Add(Total);
                item.SubItems.Add(Description);





                lsv1.Items.Add(item);


                tb1.Text = null;
                tb2.Text = null;
                tb3.Text = null;
                cb1.Text = null;
                tb5.Text = null;
                cb1.SelectedIndex = -1;
                tb5.Text = null;





            }
        }
        static double CalculateWaterBill(double price, double water, double members)
        {
            switch (price)
            {
                case 0:
                    price = Household(price, water, members);
                    break;
                case 1:
                    price = 9955 * water;
                    break;
                case 2:
                    price = 11615 * water;
                    break;
                case 3:
                    price = 22068 * water;
                    break;
            }
            return price;


        }
        static double Household(double price, double water, double members)
        {
            water = water / members;
            if (water > 30)
            {
                price = (5973 * 10 + 7052 * 10 + 8699 * 10 + 15929 * (water - 30));
            }
            else if (20 < water && water <= 30)
            {
                price = (5973 * 10 + 7052 * 10 + 8699 * (water - 20));
            }
            else if (10 < water && water <= 20)
            {
                price = (5973 * 10 + 7052 * (water - 10));
            }
            else
            {
                price = (5973 * (water));
            }
            return price * members;

        }
        private void bt5_Click(object sender, EventArgs e)
        {

            Form3 billform = new Form3();
            this.Hide();
            billform.ShowDialog();


        }
        private void tb9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb10_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex == 1)
            {
                tb5.ReadOnly = true;
                tb10.Text = $"Administrative agency, public services{"",-1}" +
                    $"|Totalprice" + $"\r\n{"",-64}|9.955 VND/m3" +
                $"_________________________________________\r\nEnvironment fees (10%)\r\nVAT (10%)";

                Typeofcustomer = 1;
                Numberofmembers = 0;
                Amountofwater = Thismonth - Lastmonth;
                Total = Price * 1.21;
                tb9.Text = Total.ToString("L2");
            }

            else if (cb1.SelectedIndex == 0)
            {
                tb5.ReadOnly = false;
                tb10.Text = $"Household customer,{"",-22}|Price{"",-15}\r\nTo 10m3/people/month{"",-16}|5.973 VND/m3"
                + $"\r\nFrom 10-20 m3/people/month{"",-6}|7.052VND/m3 \r\nFrom 20-30 m3/people/month{"",-5}|8.699 VND/m3 \r\nOver" +
                $" 30 m3/people/month{"",-12}|15.929 VND/m3" +
                $"_________________________________________\r\nEnvironment fees (10%)\r\nVAT (10%)";

                Typeofcustomer = 1;
                Numberofmembers = 0;
                Amountofwater = Thismonth - Lastmonth;
                Total = Price * 1.21;
                tb9.Text = Total.ToString("L2");
            }










        }

        private void bt2_Click(object sender, EventArgs e)
        {

        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb5.Text, out int members))
            {
                Numberofmembers = members;
            }
            if (double.TryParse(tb6.Text, out double thismonth))
            {
                Thismonth = thismonth;
            }
            if (double.TryParse(tb7.Text, out double lastmonth))
            {
                Lastmonth = lastmonth;
            }
            Amountofwater = Thismonth - Lastmonth;
            Price = CalculateWaterBill(Typeofcustomer, Amountofwater, Numberofmembers);
            Total = Price * 1.21;
            tb9.Text = Total.ToString("L2");

        }

        private void lsv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure about to delete ?", "Notice",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                lsv1.Items.Clear();
                lsv1.Columns.Clear();
                tb1.Text = null;
                tb2.Text = null;
                tb3.Text = null;
                cb1.SelectedIndex = -1;
                tb5.Text = null;
                tb6.Text = null;
                tb7.Text = null;
                tb9.Text = null;
                tb10.Text = null;
            }
            if (lsv1.SelectedItems.Count > 0)
            {
                lsv1.Items.Remove(lsv1.SelectedItems[0]);
                tb1.Text = null;
                tb2.Text = null;
                tb3.Text = null;
                cb1.SelectedIndex = -1;
                tb5.Text = null;
                tb6.Text = null;
                tb7.Text = null;
                tb9.Text = null;
                tb10.Text = null;
            }



        }

        private void bt4_Click(object sender, EventArgs e)
        {

            Form4 calculateform = new Form4();
            this.Hide();
            calculateform.ShowDialog();
        }

        private void lb10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt2_Click_1(object sender, EventArgs e)
        {
            if (lsv1.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv1.SelectedItems[0];
                item.SubItems.Clear();
                string ID = tb1.Text;

                string Name = tb2.Text;

                string Phone = tb3.Text;

                string Typeofcustomer = null;

                string Numberofmember = tb5.Text;

                string Thismonth = tb6.Text;

                string Lastmonth = tb7.Text;

                string Total = tb9.Text;

                string Description = tb10.Text;

                double cost = 0;

                if (string.IsNullOrEmpty(ID))
                {
                    MessageBox.Show("Please Enter ID Customer ", "Notice",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb1.Focus();
                }
                else if (string.IsNullOrEmpty(Name))
                {
                    MessageBox.Show("Please Enter Customer Name ", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb2.Focus();
                }
                else if (string.IsNullOrEmpty(Phone))
                {
                    MessageBox.Show("Please Enter Phone Number", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb3.Focus();
                }
                else if (string.IsNullOrEmpty(Numberofmember))
                {
                    MessageBox.Show("Please Enter Number Of Member", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cb1.Focus();
                }
                else if (string.IsNullOrEmpty(Thismonth))
                {
                    MessageBox.Show("Please Enter Amount Of Water Used This Month", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb5.Focus();
                }
                else if (string.IsNullOrEmpty(Lastmonth))
                {
                    MessageBox.Show("Please Enter Amount Of Water Used Last Month", "Notice",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb6.Focus();
                }
                

                if (cb1.SelectedIndex == 0)
                {
                    Typeofcustomer = "Household";
                }
                else if (cb1.SelectedIndex == 1)
                {
                    Typeofcustomer = "Administrative agency";
                    cost = 9.955;

                }
                else if (cb1.SelectedIndex == 2)
                {
                    Typeofcustomer = "Production units";
                    cost = 11.615;
                }
                else if (cb1.SelectedIndex == 3)
                {
                    Typeofcustomer = "Business services";
                    cost = 22.068;
                }
                else
                {
                    MessageBox.Show("Please enter Type of customer", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //ListViewItem item = new ListViewItem();
                item.Text = ID;
                item.SubItems.Add(Name);
                item.SubItems.Add(Phone);
                item.SubItems.Add(Typeofcustomer);
                item.SubItems.Add(Numberofmember);
                item.SubItems.Add(Thismonth);
                item.SubItems.Add(Lastmonth);
                item.SubItems.Add(Total);
                item.SubItems.Add(Description);





                //lsv1.Items.Add(item);


                tb1.Text = null;
                tb2.Text = null;
                tb3.Text = null;
                cb1.Text = null;
                tb5.Text = null;
                cb1.SelectedIndex = -1;
                tb5.Text = null;






            }
        }
        static double CalculateWaterBill(int consumption, int customerType, int numberOfPeople)
        {
            double money = 0;
            if (customerType == 0)
            {
                consumption /= numberOfPeople;
            }

            switch (customerType)
            {
                case 0:
                    if (consumption <= 10 )
                    {
                        money = 5.973 * consumption;
                    }
                    else if (consumption <= 20 )
                    {

                        money = 7.052 * (consumption - 10);
                    }
                    else if (consumption <= 30 - 20)
                    {
                        money = 8.699 * (consumption - 20);
                    }
                    else
                    {
                        money = 15.929 * (consumption - 30);
                    }
                    break;
                case 1:
                    money = 9.955 * consumption;
                    break;
                case 2:
                    money = 11.615 * consumption;
                    break;
                case 3:
                    money = 22.068 * consumption;
                    break;
            }
            return money  = money * 1.21;
        }
        public static string id = null;
        public static string name = null;
        public static string phone = null;
        public static int typeofcustomer = -1;
        public static double waterThismonth = 0;
        public static double waterLastmonth = 0;
        public static int numberOfmember = 0;
        public static double total = 0;

        private void bt1_Click_1(object sender, EventArgs e)
        {
            id = tb1.Text;

            name = tb2.Text;

            phone = tb3.Text;

            typeofcustomer = -1;

            if (int.TryParse(tb5.Text, out int member))
            {
                numberOfmember = member;
            }
            if (int.TryParse(tb6.Text, out int thismonth))
            {
                waterThismonth = thismonth;
            }
            if (int.TryParse(tb7.Text, out int lastmonth))
            {
                waterLastmonth = lastmonth;
            }

            double cost = 0;

            if (string.IsNullOrEmpty(tb1.Text))
            {
                MessageBox.Show("Please Enter ID Customer ", "Notice",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb1.Focus();
            }
            else if (string.IsNullOrEmpty(tb2.Text))
            {
                MessageBox.Show("Please Enter Customer Name ", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb2.Focus();
            }
            else if (string.IsNullOrEmpty(tb3.Text))
            {
                MessageBox.Show("Please Enter Phone Number", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb3.Focus();
            }
            else if (string.IsNullOrEmpty(tb5.Text))
            {
                MessageBox.Show("Please Enter Number Of Member", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb1.Focus();
            }
            else if (string.IsNullOrEmpty(tb6.Text))
            {
                MessageBox.Show("Please Enter Amount Of Water Used This Month", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb5.Focus();
            }
            else if (string.IsNullOrEmpty(tb7.Text))
            {
                MessageBox.Show("Please Enter Amount Of Water Used Last Month", "Notice",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb6.Focus();
            }
            //else if (string.IsNullOrEmpty(Description))
            //{
            //    MessageBox.Show("Please Enter Description ", "Notice",
            //     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tb9.Focus();
            //}

            if (cb1.SelectedIndex == 0)
            {
                cb1.Text = "Household";
            }
            else if (cb1.SelectedIndex == 1)
            {
                cb1.Text = "Administrative agency";
                cost = 9.955;
            }
            else if (cb1.SelectedIndex == 2)
            {
                cb1.Text = "Production units";
                cost = 11.615;
            }
            else if (cb1.SelectedIndex == 3)
            {
                cb1.Text = "Business services";
                cost = 22.068;
            }


            //MessageBox.Show("Please enter Type of customer", "Notice",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);


            ListViewItem item = new ListViewItem();
            item.Text = ID;
            item.SubItems.Add(Name);
            item.SubItems.Add(Phone);
            if (typeofcustomer == 0)
            {
                tb5.ReadOnly = true;
                item.SubItems.Add("Household");
            }
            else if (typeofcustomer == 1)
            {
                item.SubItems.Add("Administrative agency");
                tb5.ReadOnly = false;
                numberOfmember = 0;
            }
            else if (typeofcustomer == 2)
            {
                item.SubItems.Add("Production units");
                tb5.ReadOnly= false;
            }
            else if (typeofcustomer == 3)
            {
                item.SubItems.Add("Business services");
                tb5.ReadOnly= false;
            }
            else
            {
                tb5.ReadOnly = false;
                item.SubItems.Add("");
                numberOfmember = 0;
            }
            Total = Price * 1.21;

            item.SubItems.Add(waterThismonth.ToString());
            item.SubItems.Add(waterLastmonth.ToString());
            item.SubItems.Add(Total.ToString("L2"));
            lsv1.Items.Add(item);


            tb1.Text = null;
            tb2.Text = null;
            tb3.Text = null;
            cb1.Text = null;
            tb5.Text = null;
            cb1.SelectedIndex = -1;
            tb5.Text = null;






        }

        private void bt4_Click_1(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure about to resest ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                lsv1.Items.Clear();
                lsv1.Columns.Clear();
                tb1.Text = null;
                tb2.Text = null;
                tb3.Text = null;
                cb1.Text = null;
                tb5.Text = null;
                cb1.SelectedIndex = -1;
                tb5.Text = null;
            }
        



        }

        private void bt5_Click_1(object sender, EventArgs e)
        {
            Form3 billform = new Form3();
            this.Hide();
            billform.ShowDialog();
        }

        private void bt5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                Form3 billform = new Form3();
                this.Hide();
                billform.ShowDialog();


            }

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void lsv1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lsv1.SelectedItems.Count > 0)
            {
                ListViewItem selected_Item = lsv1.SelectedItems[0];
                string ID = selected_Item.SubItems[0].Text;
                string Name = selected_Item.SubItems[1].Text;
                string Phone = selected_Item.SubItems[2].Text;
                string Typeofcustomer = selected_Item.SubItems[3].Text;
                string Lastmonth = selected_Item.SubItems[4].Text;
                string Thismonth = selected_Item.SubItems[5].Text;
                string Numberofmembers = selected_Item.SubItems[6].Text;
                string Total = selected_Item.SubItems[7].Text;
                tb1.Text = ID;
                tb2.Text = Name;
                tb3.Text = Phone;
                if (Typeofcustomer == "Household")
                {
                    cb1.SelectedIndex = 0;
                }
                else if (Typeofcustomer == "Administrative agency")
                {
                    cb1.SelectedIndex = 1;
                }
                else if (Typeofcustomer == "Production units")
                {
                    cb1.SelectedIndex = 2;
                }
                else if (Typeofcustomer == "Business services")
                {
                    cb1.SelectedIndex = 3;
                }
                else cb1.SelectedIndex = -1;
                tb5.Text = Numberofmembers;
                tb6.Text = Lastmonth;
                tb7.Text = Thismonth;
                tb9.Text = Total;
            }
        }

        private void bt3_Click_1(object sender, EventArgs e)
        {
            if (lsv1.SelectedItems.Count > 0)
            {
                lsv1.Items.Remove(lsv1.SelectedItems[0]);
                tb1.Text = null;
                tb2.Text = null;
                tb3.Text = null;
                cb1.Text = null;
                tb5.Text = null;
                cb1.SelectedIndex = -1;
                tb5.Text = null;



            }











        }
    }

} 
