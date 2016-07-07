
// This program is a Windows Forms application that demonstrates input validation using regular expressions.
// It contains input fields for a customer name, a part number, an order quantity, a unit cost, a social security number, and a phone number (+ custom?).
// Last the program should also perform a "sanity check" on one of the input fields.

// Describe validation?
// part: an 8 digit prefix consisting of capital letters or numbers followed by a dash followed by a two digit suffix that can only be zeroes or ones.
// SSN: (999-99-9999)
// phone: (999-999-9999)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace pos409_input_validation
{
    public partial class MainForm : Form
    {
        List<Order> orders = new List<Order>();


        public MainForm()
        {
            InitializeComponent();

            //dgvOrders.DataSource = orders;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //dgvOrders.
            //orders.Add(new Order(txtName.Text));
            //dgvOrders.Refresh();
            //dgvOrders.d

            // Validate all fields
            // part: an 8 digit prefix consisting of capital letters or numbers followed by a dash followed by a two digit suffix that can only be zeroes or ones.
            // >> regex: (\d|[A-Z]){8}-(0|1){2}
            // SSN: (999-99-9999)
            // phone: (999-999-9999)

            bool valid = true;

            if (txtName.Text.Equals(""))
            {
                errorProvider.SetError(txtName, "Name must not be blank");
                valid = false;
            }

            



            // name: not blank
            //valid = valid && !txtName.Text.Equals("");

            //valid = valid && Regex.IsMatch(txtPart.Text, @"^(\d|[A-Z]){8}-(0|1){2}$");

            //Reg

            if (valid)
            {
                
                lstName.Items.Add(txtName.Text);
                lstPart.Items.Add(txtPart.Text);
            }
            else
            {
                //MessageBox.Show("Invalid");

            }



        }
    }

    class Order
    {
        public string Name { get; set; }

        public Order(string name)
        {
            Name = name;
        }

    }


}
