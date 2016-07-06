
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

namespace pos409_input_validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
