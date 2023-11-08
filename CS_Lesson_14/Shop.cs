using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_14
{
    internal class Shop
    {
        public List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void ProcessOrders()
        {
            for(int i = 0; i < orders.Count; i++)
            {

            }
        }


    }
}
