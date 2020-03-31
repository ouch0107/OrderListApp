﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using interview.Repositories;
using interview.Models;

namespace interview.Services
{
    public class OrderService
    {
        public List<Order> GetOrders()
        {
            var orderRepository = new OrderRepository();
            return orderRepository.GetOrders();
        }

        public bool Confirm(List<Order> orders)
        {
            var orderRepository = new OrderRepository();
            return orderRepository.Confirm(orders);
        }
    }
}