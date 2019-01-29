using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomizeGroups.Models;
using RandomizeGroups.Models.ViewModels;

namespace RandomizeGroups.Controllers
{
    public class RandomizeGroupsController : Controller
    {
        RandomizeGroupsService service;

        public RandomizeGroupsController(RandomizeGroupsService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("")]//RandomizeGroups/Index/{num_groups}
        public IActionResult Index(List<string> selectedEmployees, string num_groups)
        {
            RandomizeGroupsIndexVM model = service.GetEmployees(selectedEmployees, num_groups);
            return View(model);
        }


        //[HttpGet]
        //[Route("")]//RandomizeGroups/Index/{num_groups}
        //public IActionResult Randomize(List<string> selectedEmployeesFromCheckbox, string num_groups)
        //{
        //    EmployeesRandomizeVM model = service.GetRandomizedGroups(selectedEmployeesFromCheckbox, num_groups);
        //    return View(model);
        //}
      
    }
}