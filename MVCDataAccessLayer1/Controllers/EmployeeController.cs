using MVCDataAccessLayer.Models;
using MVCDataAccessLayer1.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;






namespace MVCDataAccessLayer1.Controllers
{
    public class EmployeeController : Controller
    {

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
            return View(empRecords);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }
        public ActionResult SaveEmployee(Employee e)
        {

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            empBal.SaveEmployee(e);
            return RedirectToAction("GetEmployees");
        }
    }
}

