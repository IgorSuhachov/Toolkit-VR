using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double weather;

            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            weather = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вас зовут " + name + ", Вам " + age + " лет, " + "на улице " + weather + " градусов");
        }
    }
}
