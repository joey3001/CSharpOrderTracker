using System.Collections.Generic;

namespace Tracker.Models 
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public string OrderDate { get; set; }
    private static List<Order> _instances = new List<Order> {}; 
    public Order(string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription; 
      OrderPrice = orderPrice; 
      OrderDate = orderDate;
      _instances.Add(this); 
    }
    public static List<Order> GetAll() 
    {
      return _instances; 
    }
    public static void ClearAll()
    {
      _instances.Clear(); 
    }
  }
}