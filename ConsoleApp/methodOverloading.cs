using System;
namespace method_overloading
{
    class Program
    {
        public class Print
        {

            public void display(string name)
            {
                Console.WriteLine("Your name is : " + name);
            }

            public void display(int age, float marks)
            {
                Console.WriteLine("Your age is : " + age);
                Console.WriteLine("Your marks are :" + marks);
            }
        }

        static void Main(string[] args)
        {
            Print obj = new Print();
            obj.display("George");
            obj.display(34, 76.50f);
            Console.ReadLine();
        }
    }
}
