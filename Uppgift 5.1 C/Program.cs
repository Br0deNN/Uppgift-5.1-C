using System;
namespace C_Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många meningar vill du skriva in?");
            string xm = Console.ReadLine();
            int xa = int.Parse(xm);
            string[] xme = new string[xa];
            for (int i = 0; i < xme.Length; i++)
            {
                Console.WriteLine("Mata in en mening");
                xme[i] = Console.ReadLine();
            }
            Console.WriteLine("Här är de meningar du skrev");
            for (int i = 0;i < xme.Length; i++)
            {
                Console.WriteLine(xme[i]);
                Console.WriteLine();
            }
        }
    }
}