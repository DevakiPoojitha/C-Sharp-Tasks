using System.Numerics;
using System.Transactions;

namespace Prog2test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Write a C# program to create a Phonebook. 
            /*The Phonebook should take inputs from the user and store their numbers. 
Also ask for the user age and store their numbers as Students in a sub class. If the user gives a profession, store the numbers in the Service subclass.
Display the numbers as a collection.
Input: Rekha, 45, Doctor: Hema, 17 : Dheeraj, 34, Tennis player: Gaurav, 12: Bhavna, 33: Umang 24: Suresh, 66: Soni, 14, Siddhant, 28, Professor.
Output: Students:
Hema, 17, Ph:No
Gaurav, 12, Ph:No
Soni, 14, Ph.No
Services and Professionals:
Rekha, 45, Doctor, Ph.No
Dheeraj, 34, Tennis player, Ph.No
Siddhant, 28, Professor, Ph.No
Citizens:
Bhavna, 33, Ph.No
Umang, 24, Ph.No
Suresh, 66, Ph.No"
*/
            float phno;
            Console.WriteLine("Enter the Phone number ");
            phno = Convert.ToSingle(Console.ReadLine());





        }

        class Student
        {
            public int Id { get; set; }
        }
        class service
        {
            
        }
}
}