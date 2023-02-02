using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataAccessLayer.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Salary { get; set; }

        public string SalaryColor { get; set; }
    }
}