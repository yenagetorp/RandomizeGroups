using Microsoft.AspNetCore.Mvc.Rendering;
using RandomizeGroups.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizeGroups.Models
{
    public class RandomizeGroupsService
    {
        Employee[] allemployees = new Employee[]
       {
             new Employee {Name= "Aaron John" },
             new Employee {Name=  "Emilia Agetorp" },
             new Employee {Name= "Elias Agetorp" },
             new Employee {Name= "Linnea Scott" },
             new Employee {Name= "Adam Theodor"},
             new Employee {Name= "Benson Edward" },
             new Employee {Name= "Benney Svensson" },
             new Employee {Name= "Lisa Li" },
             new Employee {Name= "Tony Ganegård" },
             new Employee {Name= "Samuel Agetorp" },
             new Employee {Name= "Yen Agetorp" },
             new Employee {Name= "Chris Rufus" },
             new Employee {Name= "Eva Francis" },
             new Employee {Name= "Nina Kim" }
       };
        List<string> newEmployeesList;
        internal RandomizeGroupsIndexVM GetEmployees(List<string> selectedEmployeesFromCheckbox, string num_groups)
        {
            List<SelectListItem> selectLisEmployees = allemployees.Select(e => new SelectListItem { Value = e.Name, Text = e.Name }).ToList();

            if (selectedEmployeesFromCheckbox == null)
            {
                return new RandomizeGroupsIndexVM()
                {
                        ChosenEmployees = selectLisEmployees,
                        SelectedEmployees = allemployees.Select(e => e.Name).ToList()
                };
            }
            else
            {
                return new RandomizeGroupsIndexVM()
                {
                    ChosenEmployees = selectLisEmployees,
                    SelectedEmployees = allemployees.Select(e => e.Name).ToList(),
                    Num_Groups = num_groups,
                    employees= GetRandomizedGroups(selectedEmployeesFromCheckbox,  num_groups)
                };
            }
            //if (selectedEmployeesFromCheckbox == null)
            //{
            //    return new RandomizeGroupsIndexVM()
            //    {
            //        ChosenEmployeesVM = new SelectedEmployeesVM()
            //        {
            //            ChosenEmployees = selectLisEmployees,
            //            SelectedEmployees = allemployees.Select(e => e.Name).ToList()
            //        },
            //    };
            //}
            //else
            //{
            //    return new RandomizeGroupsIndexVM()
            //    {
            //        ChosenEmployeesVM = new SelectedEmployeesVM()
            //        {
            //            ChosenEmployees = selectLisEmployees,
            //            SelectedEmployees = allemployees.Select(e => e.Name).ToList()
            //        },
            //        RandomizeVM = GetRandomizedGroups(selectedEmployeesFromCheckbox, num_groups)
            //    };
            //}
        }

        internal List<List<string>> GetRandomizedGroups(List<string> selectedEmployeesFromCheckbox, string num_groups)
        {

            int group_num = 0;
            
            string[] newEmployeesArray = selectedEmployeesFromCheckbox.ToArray();
            newEmployeesArray.RandomizeMethod();

            List<string> randomOrderedEmployees = new List<string>();

            if (num_groups == null)
            {
                for (int i = 0; i < newEmployeesArray.Length; i++)
                {
                    randomOrderedEmployees.Add(newEmployeesArray[i]);
                }
                List<List<string>> splitGroups = randomOrderedEmployees.ChunkBy(1);
                return splitGroups;

            }
            else
            {
                int numOfGroups = int.Parse(num_groups);
                for (int i = 0; i < newEmployeesArray.Length; i++)
                {
                    randomOrderedEmployees.Add(newEmployeesArray[i]);
                    group_num = ++group_num % numOfGroups;
                }
                List<List<string>> splitGroups = randomOrderedEmployees.ChunkBy(numOfGroups);

                return splitGroups;
            }
        }




    }
}
