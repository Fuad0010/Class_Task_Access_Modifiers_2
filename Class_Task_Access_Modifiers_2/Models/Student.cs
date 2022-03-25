using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Task_Access_Modifiers_2.Models
{
    internal class Student:Person
    {
        private int _point;
        public int Point
        {
            get { return _point; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _point = value;
                }
                else
                {
                    Console.WriteLine("Point is false");
                }
            }

        }
        

        public Student(int point,int age,string name):base(name,age)
        {
            Point = point;
        }
        public Student()
        {
            
        }

        


    }

}
