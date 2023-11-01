﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Exercise_02_P5S3
{
    internal class ShowData
    {
        public GenerateData GenerateData { get; set; }
        public ShowData()
        {
            GenerateData = new GenerateData(10);
        }

        public void DisplayBySection()
        {
            foreach(var emp in GenerateData.SortBysection())
            {
                Console.WriteLine($"{emp.Section,5} {NameOfSection(emp.Section),-15} {emp.Id ,5} {emp.Age ,5}");
            }    
        }
        public void DisplayBySectionGroup()
        {
          foreach(var group in GenerateData.GroupOfSection())
            {
                Console.WriteLine(NameOfSection(group.Key));
                foreach(var emp in group)
                {
                Console.WriteLine($"{emp.Section,5} {emp.Id} {emp.Age ,5}");
                }
            }
         
        }
        public string NameOfSection(int section)
        {
            string name = string.Empty;

            switch (section)
            {
                case 1: name = "Account"; break;
                case 2: name = "Person"; break;
                case 3: name = "IT"; break;
                case 4: name = "Marketing"; break;
                case 5: name = "Sale"; break;

            }

               return name;
        }
    }
}