using System;

namespace usesimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person是托管对象，使用using
            using (Person person = new Person(5))
            {
                Console.WriteLine(person.Guid());
                Console.WriteLine(person.GetName());
                person.SetName('Q');
                Console.WriteLine(person.GetName());

                person.Print();
            }

            Console.ReadLine();
        }
    }
}