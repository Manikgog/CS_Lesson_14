using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_14
{
    internal class Customer
    {
        public int CusomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAdderss { get; set; }

        public Customer(int customerId, string customerName, string customerAddress) 
        {
            CusomerId = customerId;
            CustomerName = customerName;
            CustomerAdderss = customerAddress;
        }
    }
}
