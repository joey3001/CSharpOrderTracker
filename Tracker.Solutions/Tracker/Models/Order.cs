
namespace Tracker.Models 
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public Order(string orderTitle)
    {
      OrderTitle = "blah";
    }
  }
}