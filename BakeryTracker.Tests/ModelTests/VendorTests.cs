using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void GetId_ReturnVendorID_Int()
    {
      Vendor newVendor = new Vendor("name", "description");
      int id = 1;
      int result = newVendor.Id;
      Assert.AreEqual(id, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name2", "description2");
      List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnCorrectVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name2", "description2");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
  }
}