using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizeGroups.Models.ViewModels
{
    //[Bind(Prefix = nameof(RandomizeGroupsIndexVM.ChosenEmployeesVM))]
    public class SelectedEmployeesVM
    {
        public List<SelectListItem> ChosenEmployees { get; set; }
        public List<string> SelectedEmployees { get; set; }

        
    }
}
