using System;

namespace usesimple
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Person person = new Person(5))
            {
                Console.WriteLine(person.Guid);
                Console.WriteLine(person.Name);
                person.Name = 'Q';
                Console.WriteLine(person.Name);

                person.Print();
            }

            Console.ReadLine();
        }
    }
}