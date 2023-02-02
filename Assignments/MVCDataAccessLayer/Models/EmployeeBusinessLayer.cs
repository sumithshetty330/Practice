using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDataAccessLayer.DataAccessLayer;

namespace MVCDataAccessLayer.Models
{
    public class EmployeeBusinessLayer
    {
        MyCompanyContext saleDal;
        public EmployeeBusinessLayer()
        {
            saleDal = new MyCompanyContext();
        }
        public List<Employee> GetEmployee()
        {
            return saleDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            saleDal.Employees.Add(e);
            saleDal.SaveChanges();
            return e;
        }
        public bool IsValidUser(UserDetails u)
        {
            if(u.username=="Sumith" && u.password=="Sumith")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}