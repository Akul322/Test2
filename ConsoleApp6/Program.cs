using System;

namespace Interface_Final_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            ISum sum = new Summ();

            try
            {
                Console.WriteLine("Write first number");
                int a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You writed incorrect value!!!");

            }

            try
            {
                Console.WriteLine("Write second number");
                int b = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You writed incorrect value!!!");

            }

            sum.SumMethod(a, b);

            Console.ReadLine();
        }
    }

    public interface ISum
    {
        public void SumMethod(int a, int b);
    }

    public class Summ : ISum
    {
        void ISum.SumMethod(int a, int b)
        {
            int c = a + b;
            string str = c.ToString();
            Console.WriteLine(str);
        }

    }
}
