using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller cont = new Controller();
            string choice = "";
            cont.listAll();
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
                    cont.add(nameOfItem);
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
                    Console.WriteLine("id\t   : {0}", cont.context.todos.Find(delid).id);
                    Console.WriteLine("description: {0}",cont.context.todos.Find(delid).item);
                    Console.WriteLine("status\t   : {0}",cont.context.todos.Find(delid).status);
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
        // public table todos_all {get; set;}
        public Context context;
        public Controller()     //DAO
        {
            // todos_all = new table();
            context = new Context();
            context.Database.EnsureCreated();

        }
        public List<table> list(){
            List<table> theResult = new List<table>();
            foreach(table aTable in context.todos){
                theResult.Add(aTable);
            }  
            return theResult;
        }
        public void add(string item)    //(int id, string item)
        {
            // todos_all.id.Add(id);       //set int i in main that increases as one item is added
            // todos_all.item.Add(item);
            // todos_all.status.Add("pending");
            context.todos.Add(new table(item));
            context.SaveChanges();
        }
        public void delete(int itemId)
        {
            // todos_all.id.RemoveAt(itemId);
            // todos_all.item.RemoveAt(itemId);
            // todos_all.status.RemoveAt(itemId); 
            context.todos.Remove(context.todos.Find(itemId));
            context.SaveChanges();
        }
        public void markdone(int itemId)
        {
            // todos_all.status[itemId] = "done";
            context.todos.Find(itemId).status = true;
        }
        public void listPending()
        {
            Console.WriteLine("id | item\t\t\t| status");
            Console.WriteLine("---+----------------------------+------------");
            // for(int i = 0; i < todos_all.id.Count; i++)
            // {
            //     if(todos_all.status[i] == "pending")
            //     {
            //         Console.WriteLine(" {0}  | {1}                            | {2}", todos_all.id[i], todos_all.item[i], todos_all.status[i]);
            //     }
            // }
            foreach(table aTable in context.todos)
            {
                if(aTable.status == false)
                {
                    Console.WriteLine(aTable);
                }
            }
            
        }
        public void listDone()
        {
            Console.WriteLine("id | item\t\t\t| status");
            Console.WriteLine("---+----------------------------+------------");
            // for(int i = 0; i < todos_all.id.Count; i++)
            // {
            //     if(todos_all.status[i] == "done")
            //     {
            //         Console.WriteLine(" {0}  | {1}\t\t\t\t| {2}", todos_all.id[i], todos_all.item[i], todos_all.status[i]);
            //     }
            // }
            foreach(table aTable in context.todos)
            {
                if(aTable.status == true)
                {
                    Console.WriteLine(aTable);
                }
            }
        }
        public void listAll()
        {
            Console.WriteLine("id | item\t\t\t| status");
            Console.WriteLine("---+----------------------------+------------");
            // for(int i = 0; i < todos_all.id.Count; i++)
            // {
            //     Console.WriteLine(" {0}  | {1}\t\t\t\t| {2}", todos_all.id[i], todos_all.item[i], todos_all.status[i]);
            // }
            foreach(table aTable in context.todos)
            {
                Console.WriteLine(aTable);
            }
        }
        public table GetStudent(int id)
        {
            foreach(table aTable in context.todos)
            {
                if(aTable.id == id)
                    return aTable;
            }
            return null;
        }
    }
    public class Context : DbContext
    {
        public DbSet<table> todos {get; set;}
        override
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Filename = ./todos.db");
        }
    }
    // public class ConsoleUtils
    // {
    //     public static void print(List<table> toPrint)
    //     {
    //         foreach(table aTable in toPrint)
    //         {
    //             Console.WriteLine(aTable);
    //         }
    //     }
    // }
    public class table
    {
        public int id {get; set;}           //index number of to-dos, starts at 1
        public string item {get; set;}      //name of to-do
        public bool status {get; set;}      //pending or done (boolean)
        public table()
        {
            this.id = 1;
        }
        public table(int id, string item)
        {
            this.id = id;
            this.item = item;
        }
        public table(string item)
        {
            this.item = item;
            this.status = false;
        }
        override
        public String ToString(){
            return id + "  | " + item + " \t\t\t|  " + (status? " done" : "pending");
        }
    }
}
