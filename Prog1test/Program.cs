namespace Prog1test
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            //Write a C# program to find the maximum and minum value in an array
            int[] arr1 = new int[100];
            int i, max, min, num;


            Console.Write("Find maximum and minimum element in an array :\n");
            

            Console.Write("Input the number of elements to be stored in the array :");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", num);
            for (i = 0; i < num; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            max = arr1[0];
            min = arr1[0];

            for (i = 1; i < num; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }


                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", max);
            Console.Write("Minimum element is : {0}\n\n", min);




        }

        
    }
}