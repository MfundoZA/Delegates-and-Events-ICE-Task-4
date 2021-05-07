using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_and_Events__ICE_Task_4_
{
    public class OrderProcessor
    {
        public delegate void processOrderDelegate(Order order);
        public event processOrderDelegate orderSubmitted;

        public void processOrder(Order order)
        {
            Cashier cashier = new Cashier();
            Donuteer donuteer = new Donuteer();
            Barista barista = new Barista();

            orderSubmitted += cashier.collectPayment;
            orderSubmitted += donuteer.packDonuts;
            orderSubmitted += barista.makeCoffee;

            if (order.IsTakeAway)
            {
                orderSubmitted += cashier.packageOrder;
            }
            

            onOrderSubmitted(order);
        }

        protected virtual void onOrderSubmitted(Order order)
        {
            if (orderSubmitted != null)
            {
                orderSubmitted(order);
            }
        }
    }
}
