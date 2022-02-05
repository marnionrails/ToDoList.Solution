using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Marni's To Do List");
      Console.WriteLine("____________________");
      Console.WriteLine("Would you like to add an item to your list or view your list?(Add/View>");
      string option = Console.ReadLine();


      if (option == "Add" || option == "add")
      {
        Console.WriteLine("Item: ");
        string description = Console.ReadLine();
        Item item = new Item(description);
      }
      else if (option == "View" || option == "view")
      {
        Item item = new Item("CLEAN YOUR HOUSE");
        Console.WriteLine("Your Items");
        Console.WriteLine("____________");
        List<Item> allItems = Item.GetAll();
        foreach (Item thing in allItems)
        {
          Console.WriteLine(thing.Description);
        }
      }
      else
      {
        Console.WriteLine("Thank you!");
      }
    }
  }
}