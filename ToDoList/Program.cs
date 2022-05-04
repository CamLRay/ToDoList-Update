using System;
using ToDoList.Models;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the To-Do list");
    AvoidIntro();
    static void AvoidIntro()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string addView = Console.ReadLine();
      if (addView.ToLower() == "add")
      {
        Console.WriteLine("What task would you like to add?");
        string task = Console.ReadLine();
        Item newItem = new Item (task);
        AvoidIntro();
      }
      else if (addView.ToLower() == "view")
      {
        List<Item> toDoList = Item.GetAll();
        if (toDoList.Count == 0) 
        {
          Console.WriteLine("You currently have nothing to do!");
        } 
        else
        {
          for (int i = 0; i <toDoList.Count; i++)
          {
            string number = (i + 1).ToString();
            Console.WriteLine(number + ": " +toDoList[i].Description);
          } 
        }
        AvoidIntro();
      }
      else if (addView.ToLower() == "exit" || addView.ToLower() == "ext")
      {
        return;
      }
      else if (addView.ToLower() == "complete" || addView.ToLower() == "done")
      {
        Item.ClearAll();
        Console.WriteLine("You've completed all your tasks!");
        AvoidIntro();
      }
      else
      {
        Console.WriteLine("Please choose add/view or exit");
        AvoidIntro();
      }
    }
  }
}