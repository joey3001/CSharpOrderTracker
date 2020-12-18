using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tracker.Test
{
  [TestClass]
  public class VendorTest
  {
    [TestMethod]
    public void VendorConstructor_CreateAnInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType()); 
    }
  }
}