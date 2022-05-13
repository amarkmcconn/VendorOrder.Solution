using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Description { get; set; }
    public double Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set; }
    private static List<Order> _instances = new List<Order> {};
   
  }
}