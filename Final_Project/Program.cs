using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList ls = new LinkedList();

            ls.DisplayList();

            ls.Insert(new Student("John", "PiaPian", 10001));
            ls.Insert(new Student("Joe", "Rogan", 10002));
            ls.Insert(new Student("John", "Smith", 10003));
            ls.Insert(new Student("James", "Mcname", 10004));
            ls.Insert(new Student("Peter", "Yan", 10005));

            ls.DisplayList();

            ls.Remove(10004);

            ls.DisplayList();

            ls.Search(10002);

            //ls.DisplayPartial(2, "apple");

            ls.Sort(5);

            Console.WriteLine("This");
            ls.DisplayList();


            Console.ReadKey();
        }
    }
}
