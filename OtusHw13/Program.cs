using OtusHw13;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var listPerson = new List<Person>()
        {
            new Person(){Name = "Alex", Age = 11},
            new Person(){Name = "Felix", Age = 21},
            new Person(){Name = "Ivan", Age = 31},
            new Person(){Name = "Nicola", Age = 41},
            new Person(){Name = "Julia", Age = 51},
        };
        list = list.Top(30).ToList();
        list.ForEach(Console.Write);
        Console.WriteLine();
        listPerson = listPerson.Top(30, person => person.Age).ToList();
        listPerson.ForEach(x => Console.WriteLine($"Name - {x.Name}. Age - {x.Age}."));
        Console.ReadLine();
    }
}