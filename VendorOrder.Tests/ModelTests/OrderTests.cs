using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReturnsInstanceOfDescription_Order()
    {
      string description = "coffee cups";
      double price = 10.50;
      string date = 5/13/2022;
      Order newOrder = new Order (description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}