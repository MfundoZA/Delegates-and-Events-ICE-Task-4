using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_and_Events__ICE_Task_4_
{
    public class Order
    {
        // Order class fields
        private string customerName;
        private int numberOfDonuts;
        private int numberOfCoffeCups;
        private bool isTakeAway;

        public Order(string customerName, int numberOfDonuts, int numberOfCoffeCups, bool isTakeAway)
        {
            this.customerName = customerName;
            this.numberOfDonuts = numberOfDonuts;
            this.numberOfCoffeCups = numberOfCoffeCups;
            this.isTakeAway = isTakeAway;
        }

        public string CustomerName { get => customerName; set => customerName = value; }
        public int NumberOfDonuts { get => numberOfDonuts; set => numberOfDonuts = value; }
        public int NumberOfCoffeCups { get => numberOfCoffeCups; set => numberOfCoffeCups = value; }
        public bool IsTakeAway { get => isTakeAway; set => isTakeAway = value; }

        
    }
}
