using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public string OrderDate { get; set; }
    public int Id { get; }
    private static List<Order> _orders = new List<Order> {};

    public Order(string title, string description, int price, string date)
    {
      OrderTitle = title;
      OrderDescription = description;
      OrderPrice = price;
      OrderDate = date;
      _orders.Add(this);
      Id = _orders.Count;
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }
  }
}