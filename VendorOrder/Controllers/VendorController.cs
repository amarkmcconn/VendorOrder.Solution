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
      List<vendor> allVendor = Vendor.GetAll();
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
    // This one creates new Items within a given Category, not new Categories:
    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create(int vendorId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      Item newItem = new Item(itemDescription);
      foundCategory.AddItem(newItem);
      List<Item> categoryItems = foundCategory.Items;
      model.Add("items", categoryItems);
      model.Add("category", foundCategory);
      return View("Show", model);
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Category selectedCategory = Category.Find(id);
    List<Item> categoryItems = selectedCategory.Items;
    model.Add("category", selectedCategory);
    model.Add("items", categoryItems);
    return View(model);
    }
  }
}