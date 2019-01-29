using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizeGroups.Models.ViewModels
{
    public class RandomizeGroupsIndexVM
    {
        public List<SelectListItem> ChosenEmployees { get; set; }
        public List<string> SelectedEmployees { get; set; }
        public List<List<string>> employees { get; set; }

        public string Num_Groups { get; set; }

        //public SelectedEmployeesVM ChosenEmployeesVM { get; set; }
        //////public List<string> NewEmployeesList { get; set; }
        //public EmployeesRandomizeVM RandomizeVM { get; set; }

    }
}
