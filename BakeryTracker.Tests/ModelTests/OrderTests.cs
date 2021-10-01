using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryTracker.Models;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 1, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "meal";
      Order newOrder = new Order(title, "description", 1, "date");
      string result = newOrder.OrderTitle;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "fries";
      Order newOrder = new Order("title", description, 1, "date");
      string result = newOrder.OrderDescription;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 10;
      Order newOrder = new Order("title", "description", price, "date");
      int result = newOrder.OrderPrice;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "10/1/2021";
      Order newOrder = new Order("title", "description", 1, date);
      string result = newOrder.OrderDate;
      Assert.AreEqual(date, result);
    }
  }
}