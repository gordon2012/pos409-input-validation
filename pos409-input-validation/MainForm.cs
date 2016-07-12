// Input Validation
// Gordon Doskas
// POS/409
// July 11, 2016
// Carole Mckinney

// Program Description
// ===================
// This program is a Windows Forms application that demonstrates input
// validation using regular expressions. It contains input fields for a customer
// name, a part number, an order quantity, a unit cost, a social security
// number, and a phone number. The program also performs a "sanity check" on
// the quantity field if the user enters a number above 500.


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
        public MainForm()
        {
            InitializeComponent();
            txtName.Select();
        }


        private bool ValidateRegex(Control control, string pattern, string error)
        {
            if (Regex.IsMatch(control.Text, pattern))
	        {
                return true;
        	}
            else
	        {
                errorProvider.SetError(control, error);
                return false;
	        }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool valid = true;

            // Validate name
            //
            valid = valid & ValidateRegex(txtName, @"^(?!\s*$).+", "Name must not be blank");

            // Validate part number
            //
            valid = valid & ValidateRegex(txtPart, @"^(\d|[A-Z]){8}-(0|1){2}$", "Invalid Part number");

            // Validate quantity
            //
            valid = valid & ValidateRegex(txtQty, @"^\d+$", "Invalid Quantity");

            // Validate cost
            //
            valid = valid & ValidateRegex(txtCost, @"(^\d+$)|(^\d*\.\d{1,2}$)", "Invalid Cost");

            // Validate SSN
            //
            valid = valid & ValidateRegex(txtSsn, @"^\d{3}-\d{2}-\d{4}$", "Invalid SSN");

            // Validate phone
            //
            valid = valid & ValidateRegex(txtPhone, @"^\d{3}-\d{3}-\d{4}$", "Invalid Phone number");


            // Sanity check
            //
            if(valid && int.Parse(txtQty.Text) > 500)
            {
                valid = valid & (MessageBox.Show("So many? Are you sure?", "Sanity Check", MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false);

                if (!valid)
                {
                    errorProvider.SetError(txtQty, "Quantity too high");
                }
            }

            
            // If preceding validation is successful, add new record
            //
            if (valid)
            {
                lstName.Items.Add(txtName.Text);
                lstPart.Items.Add(txtPart.Text);
                lstQty.Items.Add(txtQty.Text);
                lstCost.Items.Add(txtCost.Text);
                lstSsn.Items.Add(txtSsn.Text);
                lstPhone.Items.Add(txtPhone.Text);

                txtName.Clear();
                txtPart.Clear();
                txtQty.Clear();
                txtCost.Clear();
                txtSsn.Clear();
                txtPhone.Clear();
            }
        }
    }
}
