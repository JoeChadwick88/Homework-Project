using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_Project
{
    internal class Program
    {
        struct Homework
        {
            public string Title;
            public string subject;
            public DateTime DateSet;
            public DateTime DateDue;

        }
        static void Main(string[] args)
        {
            Homework[] Homeworks = new Homework[20];
            loadHomework(ref Homeworks);
            displayMenu();
            Console.WriteLine("enter the number soresponding to your choice");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ViewHomework(ref Homeworks);

                case "2":
                    Addhomework(ref Homeworks);

                case "3":
                    CompleteHomework(ref Homeworks);

                case "4":
                    break;
            }

        }
        static void loadHomework(ref Homework[] Homeworks)
        {
            int count = 0;
            string title = "";
            DateTime dueDate = DateTime.MinValue;
            string subject = "";
            DateTime setDate = DateTime.MinValue;
            StreamReader file = new StreamReader("Homework.txt");
            Homework Homeworks1 = new Homework();
            while (file.EndOfStream != true)
            {
                title = file.ReadLine();
                subject = file.ReadLine();
                setDate = DateTime.Parse(file.ReadLine());
                dueDate = DateTime.Parse(file.ReadLine());

                Homeworks1.Title = title;
                Homeworks1.subject = subject;
                Homeworks1.DateSet = setDate;
                Homeworks1.DateDue = dueDate;
                Homeworks[count] = Homeworks1;
                count++;

            }


        }
        static void ViewHomework(ref Homework[] Homeworks)
        {
            StreamReader file = new StreamReader("Homework.txt");

            while (file.EndOfStream != true)
            {
                Console.WriteLine(file.ReadLine());
            }
        }

        static void Addhomework(ref Homework[] Homeworks)
        {

        }

        static void CompleteHomework(ref Homework[] Homeworks)
        {

        }
        
        static void displayMenu()
        {
            Console.WriteLine("==================================================================================");
            Console.WriteLine("HOMEWORK");
            Console.WriteLine("==================================================================================");
            
            Console.WriteLine("1. View Homework");
            Console.WriteLine("2. Add Homework");
            Console.WriteLine("3. Complete homework");
            Console.WriteLine("4. Quit");
            Console.WriteLine("==================================================================================");
           

        }
    }
}
