using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace prog3test
{
   public  interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    
    public class Car : IVehicle
    {
        public int fuel { get; set; }
        int fu;
        public Car(int fu)
        {
            this.fu = fu;    
        }
        public void Drive()
        {
            if(fu>0)
                Console.WriteLine("Started Driving");
            else
            {
                Console.WriteLine("refuel");
            }
            
           
        }
        public bool Refuel(int amount)
        {
            if(fu>0)
             return true;
            else
            {
                return false;
            }
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.WriteLine("Enter the amount of fuel");
            f = Convert.ToInt32(Console.ReadLine());
            Car mycar = new Car(f);
            mycar.Drive();
            Console.WriteLine(mycar.Refuel(f));
            

        }
    }
}

