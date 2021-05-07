using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Delegates_and_Events__ICE_Task_4_
{
    class Barista
    {
        public void makeCoffee(Order order)
        {
            MessageBox.Show("Making coffee...");
        }
    }
}
