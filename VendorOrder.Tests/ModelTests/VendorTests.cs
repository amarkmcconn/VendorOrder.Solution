using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {  
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Home Depot");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsNameOfVendor_String()
    {
      string name = "Home Depot";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetID_ReturnsID_Int()
    {
      string name = "Home Depot";
      Vendor newVendor = new Vendor(name);
      int Id = newVendor.Id;
      Assert.AreEqual(1, Id);
    }
  }
}