using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Delegates_and_Events__ICE_Task_4_
{
    public class Cashier
    {

        public void collectPayment(Order order)
        {
            MessageBox.Show("Collecting cash...");
        }

        public void packageOrder(Order order)
        {
            MessageBox.Show("Packaging order...");
        }
    }
}
