using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
        List<Item> allItems = new List<Item> {};
        Console.WriteLine("Would you like to add an item to your list or view your list?(Add/View)");
        string option = Console.ReadLine().ToUpper();  

          if (option == "ADD")
          {
            Console.WriteLine("Please enter the description for the new item: ");
            string description = Console.ReadLine();
            Item item = new Item(description);
            Main();
          }
          else if (option == "VIEW")
          {
            allItems = Item.GetAll();
            if (allItems.Count == 0)
            {
              Console.WriteLine("You have not added any items yet!");
            }
            else
            {
              foreach (Item thing in allItems)
              {
                Console.WriteLine(thing.Description);
              }
            }
            Main();
          }
          else
          {
            Console.WriteLine("Thank you!");
          }
    }
  }
}
  
