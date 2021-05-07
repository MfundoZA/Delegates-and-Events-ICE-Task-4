using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_and_Events__ICE_Task_4_
{
    public partial class frmMain : Form
    {
        string customerName;
        int numberOfDonuts;
        int numberOfCoffeeCups;
        bool isTakeAway;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            customerName = txtCustomerName.Text;
            numberOfDonuts = Convert.ToInt32(txtNumDonuts.Text);
            numberOfCoffeeCups = Convert.ToInt32(txtNumCoffee.Text);
            
            if (rdbYes.Checked)
            {
                isTakeAway = true;
            } else
            {
                isTakeAway = false;
            }

            Order order = new Order(customerName, numberOfDonuts, numberOfCoffeeCups, isTakeAway);

            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.orderSubmitted(order);
        }
    }
}
