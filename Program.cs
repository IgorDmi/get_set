using System;

namespace get_set
{
    class Timetable
    {
        private string _prioryty;
        private string _work;
        private string _employee;

        public void enterPrioryty(string prioryty)
        {
            _prioryty = prioryty;
        }
        public string readPrioryty()
        {
            return _prioryty;
        }

        public string Work
        {
            get
            {
                return _work;
            }
            set
            {
                _work = value;
            }
        }

        public string Employee
        {
            get => _employee;
            set => _employee = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Timetable work1 = new Timetable();

            Console.Write("Enter prioryty: ");
            text = Console.ReadLine();
            work1.enterPrioryty(text);

            Console.Write("Enter work: ");
            text = Console.ReadLine();
            work1.Work = text;

            Console.Write("Enter name employee: ");
            text = Console.ReadLine();
            work1.Employee = text;

            Console.WriteLine(work1.readPrioryty());
            Console.WriteLine(work1.Work);
            Console.WriteLine(work1.Employee);


        }
    }
}
