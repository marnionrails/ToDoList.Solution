using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
      public void GetDescription_ReturnsDescription_String()
    {
      string description = "Clean the porch.";
      Item newItem = new Item(description);

      string result = newItem.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Clean the porch.";
      Item newItem = new Item(description);
      string updatedDescription = "Put away all laundry.";

      newItem.Description = updatedDescription;
      string result = newItem.Description;

      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Item> testList = new List<Item> { };

      List<Item> result = Item.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      string description01 = "Clean the porch";
      string description02 = "Clean the bathrooms";
      string description03 = "Tidy up kitchen";
      string description04 = "Put all laundry away";
      string description05 = "Wash all sheets";
      Item item01 = new Item(description01);
      Item item02 = new Item(description02);
      Item item03 = new Item(description03);
      Item item04 = new Item(description04);
      Item item05 = new Item(description05);

      List<Item> testList = new List<Item> {item01, item02, item03, item04, item05};
      List<Item> result = Item.GetAll();

      CollectionAssert.AreEqual(testList, result);
    }
  }
}
