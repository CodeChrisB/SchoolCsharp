using System;
using System.Collections;
using Attributes;

namespace Test
{
    [Author("Your Name")]
    class Account
    {
        private ArrayList valOrders = new ArrayList();
     
        [IsTested()]
        public void AddOrder(Order orderToAdd)
        {
            valOrders.Add(orderToAdd);
        }

        public ArrayList GetOrders()
        {
            return valOrders;
        }
    }
}
