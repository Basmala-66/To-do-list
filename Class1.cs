using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_List
{
    class Class1
    {
        private string AddTask {  get; set; }
        int select {get; set; }

        List<string> process = new List<string>()
            {
                "Add a new task ",
               "View the task list",
               "Delete a task",
               "Edit a task ",
               "Search for a task"
            };


        public void SelectProcesses()
        {
            Console.WriteLine(new string('\t', 4)+"============================================");
            Console.WriteLine(new string('\t', 4) + "Select the process you want to perform: \n");
            
            for (int i = 0; i < process.Count; i++)
            {
                Console.WriteLine(new string('\t', 4) + (i+1) + "- " +process[i]+"\n");
            }

            Console.WriteLine(new string('\t', 4)+"============================================");

             select = int.Parse(Console.ReadLine());
            Console.Write(new string('\t', 4) + $"|{select}|: ");
        }

        public void Choice()
        {
            //for (int i = 1; i <= process.Count; i++)
            //{
            //    switch(select)
            //    {
            //        case 1:
            //            Console.Write("You chose: " + process[i]);
            //            break;
            //    }
            //    }
            Tasks t1 = new Tasks();
            if (select == 1)
            {
                Console.Write("You chose: " + process[0] + "\n");
                t1.AddTasks();
            }

            else if (select == 2)
            {
                Console.Write("You chose: " + process[1] + "\n");
                t1.ViewTaska();
            }

            else if (select == 3)
            {
                Console.Write("You chose: " + process[2] + "\n");
                t1.DeleteTask();
            }

            else if (select == 4)
            {
                Console.Write("You chose: " + process[3] + "\n");
                t1.EditTask();
            }
        }
    }
}
