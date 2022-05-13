using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendor = Vendor.GetAll();
      return View(allVendor);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName)
    {
    Vendor newVendor = new Vendor(vendorName);
    return RedirectToAction("Index");
    }
    
    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create(int vendorId, string orderDescription, double orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Vendor selectedVendor = Vendor.Find(id);
    List<Order> vendorOrders = selectedVendor.Orders;
    model.Add("vendor", selectedVendor);
    model.Add("order", vendorOrders);
    return View(model);
    }
  }
}