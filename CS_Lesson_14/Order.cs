using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_14
{
    
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }

        public Order(int orderId, DateTime orderDateTime, Customer customer)
        {
            OrderId = orderId;
            OrderDateTime = orderDateTime;
            Customer = customer;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }


        public void ProccessOrder()
        {
            Console.WriteLine(this.ToString() + " выполнен");
        }

        public override string ToString()
        {
            return OrderId.ToString() + ", " + OrderDateTime.ToString() + ", " +
                    Customer.ToString() + ",\n" + Products.ToArray().ToString();
        }

    }
}
