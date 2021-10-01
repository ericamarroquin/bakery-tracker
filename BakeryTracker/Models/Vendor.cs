using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      VendorName = name;
      VendorDescription = description;
      _vendors.Add(this);
      Id = _vendors.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public static Vendor Find(int vendorId)
    {
      return _vendors[vendorId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}