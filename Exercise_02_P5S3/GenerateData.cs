

namespace Exercise_02_P5S3
{
    internal class GenerateData
    {
        public List<Employee> Employees;
        public List<GroupAge> GroupAges;
        public GenerateData(int num = 5)
        {
            Employees = new List<Employee>();
            GroupAges = new List<GroupAge>();
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
        public List<Employee> SortByAge()
        {
            return Employees.OrderBy(p => p.Section).ToList();
        }

        public List<IGrouping<int,GroupAge>> GroupofAge()
        {
           Employees = SortByAge();

            int groupTemp, sectionTemp;

            foreach(var item in Employees)
            {
                //Lamda C# v8
                groupTemp = item.Age switch
                 {
                     <= 30 => 1,
                     <= 40 => 2,
                     <= 50 => 3,
                     _ => 40,
                 };


                GroupAges.Add(new GroupAge { GroupofAge = groupTemp, Section = item.Section });
            }
            return GroupAges.GroupBy(p => p.GroupofAge).ToList();   
        }
        
    }
}
