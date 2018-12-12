using System;
using System.Collections;
using System.Collections.Generic;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller cont = new Controller();
            int index = 1;  //starting point of the id of items that will be listed
            string choice = "";
            while(choice != "quit")
            {
                Console.Clear();
                Console.WriteLine("Available functions");
                Console.WriteLine("add: to add an item");
                Console.WriteLine("delete: to delete an item");
                Console.WriteLine("mark done: the item to mark as done");
                Console.WriteLine("list pending: to list the pending items");
                Console.WriteLine("list done: to list the done items");
                Console.WriteLine("list all: to list all items");
                Console.WriteLine("quit: to exit");
                Console.WriteLine();
                Console.WriteLine("What would you like to do? ");
                choice = Console.ReadLine();
                choice = choice.ToLower();
                
                if(choice == "add")
                {
                    Console.WriteLine("Enter a description: ");
                    string nameOfItem = Console.ReadLine();
                    cont.add(index, nameOfItem);
                    index++;
                    Console.WriteLine();
                    Console.WriteLine("[item added]");
                    Console.WriteLine();
                    Console.WriteLine("[press enter]");
                    choice = Console.ReadLine();

                }
                else if(choice == "delete")
                {
                    Console.WriteLine("Enter an item id: ");
                    int delid = Convert.ToInt32(Console.ReadLine());
                    delid -= 1;   //user friendly
                    Console.WriteLine("id\t   : {0}",cont.todos_all.id[delid]);
                    Console.WriteLine("description: {0}",cont.todos_all.item[delid]);
                    Console.WriteLine("status\t   : {0}",cont.todos_all.status[delid]);
                    cont.delete(delid);
                    Console.WriteLine();
                    Console.WriteLine("[item deleted]");
                    Console.WriteLine();
                    Console.WriteLine("[press enter]");
                    choice = Console.ReadLine();
                }
                else if(choice == "mark done")
                {
                    Console.WriteLine("Enter an item id: ");
                    int doneid = Convert.ToInt32(Console.ReadLine());
                    doneid -= 1;    //user friendly
                    cont.markdone(doneid);
                    Console.WriteLine();
                    Console.WriteLine("[item updated]");
                    Console.WriteLine();
                    Console.WriteLine("[press enter]");
                    choice = Console.ReadLine();
                }
                else if(choice == "list pending")
                {
                    cont.listPending();
                    Console.WriteLine("[press enter]");
                    choice = Console.ReadLine();
                }
                else if(choice == "list done")
                {
                    cont.listDone();
                    Console.WriteLine("[press enter]");
                    choice = Console.ReadLine();
                }
                else if(choice == "list all")
                {
                    Console.WriteLine("this is crazy boi!");
                    cont.listAll();
                    Console.WriteLine("[press enter]");
                    choice = Console.ReadLine();
                }
                else
                {
                    if(choice != "quit")
                    {
                        Console.WriteLine("[ERROR] Invalid action");
                        Console.WriteLine();
                        Console.WriteLine("[press enter]");
                        choice = Console.ReadLine();   
                    }
                }
            }
        }
    }
    class Controller
    {
        public table todos_all {get; set;}
        // public table todos_pending {get; set;}
        // public table todos_done{get; set;}
        public Controller()
        {
            todos_all = new table();
            // todos_pending = new table();
            // todos_done = new table();

        }
        public void add(int id, string item)
        {
            todos_all.id.Add(id);       //set int i in main that increases as one item is added
            todos_all.item.Add(item);
            todos_all.status.Add("pending");
        }
        public void delete(int itemId)
        {
            todos_all.id.RemoveAt(itemId);
            todos_all.item.RemoveAt(itemId);
            todos_all.status.RemoveAt(itemId);
        }
        public void markdone(int itemId)
        {
            todos_all.status[itemId] = "done";
        }
        public void listPending()
        {
            Console.WriteLine(" id | item\t\t\t\t| status");
            Console.WriteLine("----+--------------------------------------------");
            for(int i = 0; i < todos_all.id.Count; i++)
            {
                if(todos_all.status[i] == "pending")
                {
                    Console.WriteLine(" {0}  | {1}                            | {2}", todos_all.id[i], todos_all.item[i], todos_all.status[i]);
                }
            }
        }
        public void listDone()
        {
            Console.WriteLine(" id | item\t\t\t\t| status");
            Console.WriteLine("----+--------------------------------------------");
            for(int i = 0; i < todos_all.id.Count; i++)
            {
                if(todos_all.status[i] == "done")
                {
                    Console.WriteLine(" {0}  | {1}\t\t\t\t| {2}", todos_all.id[i], todos_all.item[i], todos_all.status[i]);
                }
            }
        }
        public void listAll()
        {
            Console.WriteLine(" id | item\t\t\t\t| status");
            Console.WriteLine("----+--------------------------------------------");
            for(int i = 0; i < todos_all.id.Count; i++)
            {
                Console.WriteLine(" {0}  | {1}\t\t\t\t| {2}", todos_all.id[i], todos_all.item[i], todos_all.status[i]);
            }
        }
    }
    class table
    {
        public List<int> id {get; set;}     //index number of to-dos, starts at 1
        public List<string> item {get; set;}    //name of to-do
        public List<string> status {get; set;} //pending or done (boolean)
        public table()
        {
            id = new List<int>();
            item = new List<string>();
            status = new List<string>();
        }
    }
}
