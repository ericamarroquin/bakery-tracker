using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnNameAndDescription_String()
    {
      string name = "name";
      string description = "description";
      Vendor newVendor = new Vendor(name, description);
      string nameResult = newVendor.VendorName;
      string descriptionResult = newVendor.VendorDescription;
      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(description, descriptionResult);
    }
  }
}