using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using interview.Services;
using Newtonsoft.Json;
using interview.Models;
using System.Web.Http;

namespace interview.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        [System.Web.Mvc.Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Mvc.Authorize]
        [System.Web.Mvc.HttpGet]
        public ActionResult GetOrders()
        {
            var orderService = new OrderService();
            var result = orderService.GetOrders();
            return Content(JsonConvert.SerializeObject(result), "application/json");
        }

        [System.Web.Mvc.Authorize]
        [System.Web.Mvc.HttpPut]
        public ActionResult Confirm([FromBody]List<Order> orders)
        {
            var orderService = new OrderService();
            var result = orderService.Confirm(orders);
            return Content(JsonConvert.SerializeObject(new { isSuccess= result, orders}), "application/json");
        }

        //// GET: Order/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        [System.Web.Mvc.Authorize]
        [System.Web.Mvc.HttpPost]
        public ActionResult Create([FromBody]Order order)
        {
            var orderService = new OrderService();
            var result = orderService.Create(order);
            return Content(JsonConvert.SerializeObject(new { isSuccess = result, order }), "application/json");

        }

        //// POST: Order/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Order/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Order/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        [System.Web.Mvc.HttpDelete]
        public ActionResult Delete([FromBody]int orderId)
        {
            var orderService = new OrderService();
            var result = orderService.Delete(orderId);
            return Content(JsonConvert.SerializeObject(new { isSuccess = result, orderId }), "application/json");
        }

        //// POST: Order/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
