using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace To_do_List
{
   public class Tasks
    {
        string filepath = @"C:\oop projects\To do List\To do List\tasklist.txt";
        string Add;
        string Read;
        string[] lines;
        string lineToRemoveContaining;
        string []update;
        int i = 1;
        string editTask;
        string done;

        private void printTsks()
        {
            lines = File.ReadAllLines(filepath);
            foreach (var task in lines)
            {
                Console.WriteLine(new string('\t', 4) + (i++) + "- " + task + "\n");
            }
        }

        public void AddTasks()
        {
            
                Console.Write(new string('\t', 4) + "Please add the task you want: ");
           
                Add = Console.ReadLine();
            File.AppendAllText(filepath, Add+ Environment.NewLine);
               // tasks.Add(Add);
                Console.WriteLine(new string('\t', 4) + "============================================");
            
        }

        public void ViewTaska()
        {
            Console.WriteLine(new string('\t', 4) + "Your Tasks: ");

            printTsks();
            Console.WriteLine(new string('\t', 4) + "============================================");
        }

        public void DeleteTask()
        {
            Console.WriteLine(new string('\t', 4) + "Please choose the task you want to dalete: ");
            printTsks();

            lineToRemoveContaining = Console.ReadLine();

                
                update = lines.Where(line => line != lineToRemoveContaining).ToArray();
                File.WriteAllLines(filepath, update);
            
        }

        public void EditTask()
        {
            Console.WriteLine(new string('\t', 4) + "Please choose the task you want to edit: ");
            printTsks();

            editTask = Console.ReadLine();
            //Console.Write(new string('\t', 4) + "Enter the task you want to modify: ");
            //done = Console.ReadLine();

            // لووب بتمشي على عناصر الملف 
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == editTask)
                {
                    Console.Write(new string('\t', 4) + "Enter the task you want to modify: ");
                    done = Console.ReadLine();
                    lines[i] = done;
                   
                }

                //else
                //{
                //    Console.WriteLine(new string('\t', 4) + "The task not found!");
                //}
            }
            Console.WriteLine(new string('\t', 4) + "//The task has been modified//");
            File.WriteAllLines(filepath, lines);



        }



    }
}
