using MVCDataAccessLayer.Models;
using MVCDataAccessLayer.ViewModel;
using MVCDataAccessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataAccessLayer.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetEmployees()
        {
            EmployeeRecordsViewModel empRecords = new EmployeeRecordsViewModel();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployee();
            foreach (Employee emp in employees)
            {
                EmployeeViewModel evm = new EmployeeViewModel();
                evm.EmployeeId = emp.EmployeeId;
                evm.EmployeeName = emp.FirstName + " " + emp.LastName;
                evm.Salary = (int)emp.Salary;
                if (emp.Salary > 13000)
                {
                    evm.SalaryColor = "yellow";
                }
                else
                {
                    evm.SalaryColor = "green";
                }
                empViewModels.Add(evm);
            }
            empRecords.MyEmployees = empViewModels;
            return View("GetEmployee", empRecords);
        }



        public ActionResult AddNew()
        {

            return View("CreateEmployee",new CreateEmployeeViewModel());
        }



        public ActionResult SaveEmployee(Employee e,string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("GetEmployee");
                    }
                    else
                    {
                        //return view("Ctrateemployee");
                        //To retain value back in case of validation failure
                        CreateEmployeeViewModel vm=new CreateEmployeeViewModel();
                        vm.FirstName = e.FirstName;
                        vm.LastName = e.LastName;
                        if (e.Salary.HasValue)
                        {
                            vm.Salary = e.Salary.ToString();
                        }
                        else
                        {
                            vm.Salary = ModelState["Salary"].Value.AttemptedValue;

                        }
                        return View("CreateEmployee", vm);
                    }
                case "Cancel":
                    return RedirectToAction("GetEmployee");
            }

            return new EmptyResult();
        



            
        }
        [Authorize]
        public string SayHello()
        {
            return "Hello";
        }
    }
}