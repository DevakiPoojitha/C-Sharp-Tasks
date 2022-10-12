

/*"Write a C# program that uses a Queue to store a list of people. Create a class called Person.cs with two properties (name and age) 
and a ToString() method to print the result.

Then define a Queue and request the information (name and age) of 5 people from the user, you will have to 
store the information in the queue.  Finally print the result of the queue on screen. "*/


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }



    public override string ToString()
    {
        return Name + " - " + Age;
    }
}
class Program
{
    static void Main(string[] args)
    {



        Queue<Person> persons = new Queue<Person>();



        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter name of employee " + (i + 1) + " :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age of employee " + (i + 1) + " :");
            int age = int.Parse(Console.ReadLine());
            persons.Enqueue(new Person()
            {
                Name = name,
                Age = age
            });
        }
        Console.WriteLine("\nPrinting all employee details:");
        Console.WriteLine("Name - Age");
        foreach (Person p in persons)
        {
            Console.WriteLine(p.ToString());
        }
    }
}