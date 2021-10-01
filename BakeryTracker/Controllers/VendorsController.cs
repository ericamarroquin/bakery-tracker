using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models;

namespace BakeryTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor chosenVendor = Vendor.Find(id);
      List<Order> vendorsOrders = chosenVendor.Orders;
      model.Add("vendor", chosenVendor);
      model.Add("orders", vendorsOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor chosenVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      chosenVendor.AddOrder(newOrder);
      List<Order> vendorsOrders = chosenVendor.Orders;
      model.Add("orders", vendorsOrders);
      model.Add("vendor", chosenVendor);
      return View("Show", model);
    }
  }
}