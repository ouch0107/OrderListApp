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
            int result = 0;
            using(var myContext = new MyContext())
            {
                using(var transaction = myContext.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var order in orders)
                        {
                            var orderToConfirm = myContext.Orders.Where(o => o.OrderId == order.OrderId).FirstOrDefault();
                            orderToConfirm.Status = Order.OrderStatus.toBeShipped;

                            var shippingOrder = new ShippingOrder
                            {
                                OrderId = order.OrderId,
                                Status = ShippingOrder.ShippingOrderStatus.New,
                                CreatedTime = DateTime.UtcNow
                            };
                            myContext.ShippingOrders.Add(shippingOrder);
                        }
                        result = myContext.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }                    
                }
            }                        
            return result == orders.Count;
        }

        public bool Create(Order order)
        {
            db.Orders.Add(order);
            var result = db.SaveChanges();
            return result == 1;
        }

        public bool Delete(int orderId)
        {
            var order = db.Orders.Where(o => o.OrderId == orderId).FirstOrDefault();
            db.Orders.Remove(order);
            var result = db.SaveChanges();
            return result == 1;
            
        }
    }
}