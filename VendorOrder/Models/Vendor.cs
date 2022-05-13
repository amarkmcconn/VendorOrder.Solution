using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};
    // public List<Order> Orders { get; set; }
    public Vendor (string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      // Orders = new List<Order>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}