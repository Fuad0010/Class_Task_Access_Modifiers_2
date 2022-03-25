using Class_Task_Access_Modifiers_2.Models;
using System;

namespace Class_Task_Access_Modifiers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student();

            Console.Write("Please enter your name: ");
            Student1.Name = Console.ReadLine();

            Console.Write("Please enter your surname: ");
            Student1.Surname = Console.ReadLine();

            Console.Write("Please enter your age: ");
            Student1.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your point: ");
            Student1.Point = Convert.ToInt32(Console.ReadLine());

            






        }
    }   
}
