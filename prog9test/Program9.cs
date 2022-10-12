namespace prog9test
{
    delegate bool isPromote(Employee emp);
    class Employee
    {
        public int ID;
        public string Name;
        public int salary;
        public float Experience;
        public static void PromoteEmp(List<Employee> EmployeeList, isPromote IsEligible)
        {
            foreach (var emp in EmployeeList)
            {
                if (IsEligible(emp))
                {
                    Console.WriteLine(emp.Name + " is Promoted");
                }
            }
        }
        public static bool promote(Employee emp)
        {
            if (emp.Experience >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main()
        {
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID = 1, Name = "POOJITHA", salary = 600000, Experience = 1 });
            empl.Add(new Employee() { ID = 2, Name = "VARSHITHA", salary = 500000, Experience = 3 });
            empl.Add(new Employee() { ID = 3, Name = "MEHER", salary = 50000, Experience = 5 });
            empl.Add(new Employee() { ID = 4, Name = "RENUKA", salary = 10000, Experience = 6 });
            empl.Add(new Employee() { ID = 5, Name = "NAGU", salary = 500000, Experience = 9 });





            isPromote pro = new isPromote(promote);
            Employee.PromoteEmp(empl, pro);
        }
    }
}