using System;

namespace Class_Task_Access_Modifiers_2.Models
{
    internal class Person
    {
        private string _name;
        private string _surname;
        public int Age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 30 && SurnameName(value) == true)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name duzgun deyildir");
                }
            }
        }

        public Person()
        {

        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length >= 3 && value.Length <= 35 && SurnameName(value) == true)
                {
                    _name = value;
                }
                else

                {
                    Console.WriteLine("Surname duzgun deyildir");
                }
            }

        }

        public Person(string name, int age)
            {
            _name = name;
            Age = age;
            }

        
        

        

    public bool SurnameName(string word)
        {
            bool a;
            bool b = char.IsUpper(word[0]);
            if (b == true)
            {

                a = true;

            }
            else
            {
                a = false;
            }
            return a;
        }
    }
}
