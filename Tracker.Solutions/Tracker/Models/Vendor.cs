
namespace Tracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
    }
  }
}