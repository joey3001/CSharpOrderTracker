
namespace Tracker.Models 
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public Order(string orderTitle, string orderDescription, int orderPrice)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription; 
      OrderPrice = 3; 
    }
  }
}