using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName { get; set; }
    public int Id { get; }
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
      Id = _instances.Count + 1;
    }

    public static void ClearAll()
    {
      _instances.Clear(); 
    }
  }
}