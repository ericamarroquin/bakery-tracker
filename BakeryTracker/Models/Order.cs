using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public string OrderDate { get; set; } 

    public Order(string title, string description, int price, string date)
    {
      OrderTitle = title;
      OrderDescription = description;
      OrderPrice = price;
      OrderDate = date;
    }
  }
}