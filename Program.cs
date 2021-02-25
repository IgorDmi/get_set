using System;

namespace get_set
{
    class Timetable
    {
        private string _request;

        public string Request
        {
            get
            {
                return _request;
            }
            set
            {
                _request = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Timetable work1 = new Timetable();

            work1.Request = "cleaning";
            Console.WriteLine(work1.Request);
        }
    }
}
