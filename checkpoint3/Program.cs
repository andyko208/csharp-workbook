using System;
using System.Collections;
using System.Collections.Generic;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Controller
    {
        public table todos {get; set;}
        public Controller()
        {
            todos = new table();
        }
        public void add()
        {

        }
        public void delete()
        {
            
        }
        public void markdone()
        {
            
        }
        public void listPending()
        {
            
        }
        public void listDone()
        {
            
        }
        public void listAll()
        {

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
