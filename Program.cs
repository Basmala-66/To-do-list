namespace To_do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(new string('\t', 6) + "Menue");
                Class1 c1 = new Class1();
                c1.SelectProcesses();
                c1.Choice();
            }
        }
    }
}
