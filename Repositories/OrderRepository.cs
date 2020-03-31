using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using interview.DAL;
using interview.Models;

namespace interview.Repositories
{
    public class OrderRepository
    {
        private MyContext db = new MyContext();

        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }

        public bool Confirm(List<Order> orders)
        {
            foreach(var order in orders)
            {
                var orderToConfirm = db.Orders.Where(o => o.OrderId == order.OrderId).FirstOrDefault();
                orderToConfirm.Status = Order.OrderStatus.toBeShipped;
            }
            var result = db.SaveChanges();
            return result == orders.Count;
        }
    }
}