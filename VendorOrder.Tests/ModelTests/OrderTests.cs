using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("coffee cups", 10.50, "5/13/2022");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReturnsInstanceOfDescription_Order()
    {
      string description = "coffee cups";
      double price = 10.50;
      string date = "5/13/2022";
      Order newOrder = new Order (description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsInstanceOfPrice_Order()
    {
      string description = "coffee cups";
      double price = 10.50;
      string date = "5/13/2022";
      Order newOrder = new Order (description, price, date);
      double result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void OrderConstructor_ReturnsInstanceOfDate_Order()
    {
      string description = "coffee cups";
      double price = 10.50;
      string date = "5/13/2022";
      Order newOrder = new Order (description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrderList_OrderList()
    {
      string description1 = "coffee cups";
      double price1 = 10.50;
      string date1 = "5/13/2022";
      Order newOrder1 = new Order (description1, price1, date1);
      string description2 = "plates";
      double price2 = 30.00;
      string date2 = "5/13/2022";
      Order newOrder2 = new Order (description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}