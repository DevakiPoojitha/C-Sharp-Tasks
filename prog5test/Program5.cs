namespace prog5test
{
    internal class Program
    {
        int num,a,fact=1;
        public void factorial()
        {
            Console.WriteLine("User input for factorial ");
            num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial is " +fact);
            
        }

        public void tables()
        {
            Console.WriteLine("input for tables");
           int a = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} X {1} = {2}", a, j, a * j);
            }
        }

        static void Main(string[] args)
        {
            
            
            //Write a C# program to calculate the multiplication table and the factorial of the given number. Get the number as an input from the user. 
            Program p = new Program();
            p.factorial();
            p.tables();
            

            
            


        }
    }
}