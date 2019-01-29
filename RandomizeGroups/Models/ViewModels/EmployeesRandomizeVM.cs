using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizeGroups.Models.ViewModels
{
    public class EmployeesRandomizeVM
    {
        public List<List<string>> employees { get; set; }

        public string Num_Groups { get; set; }
    }
}
