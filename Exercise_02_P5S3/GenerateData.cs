

namespace Exercise_02_P5S3
{
    internal class GenerateData
    {
        public List<Employee> Employees;
        public GenerateData(int num = 5)
        {
            Employees = new List<Employee>();
            CreateEmployee(num);
        }

        public void CreateEmployee(int number)
        {
            Random random = new Random();

            for(int i = 0; i < number; i++)
            {
                Employees.Add(new Employee
                {
                    Id = i,
                    Section = random.Next(1, 6),
                    Age = random.Next(25, 61),
                }); ;
            }
            
        }
        public List<Employee> SortBysection()=>Employees.OrderBy(p=>p.Section).ToList();

        public List<IGrouping<int, Employee>> GroupOfSection()
        {
           Employees = SortBysection();
           return Employees.GroupBy(p=>p.Section).ToList();
        }
        
    }
}
