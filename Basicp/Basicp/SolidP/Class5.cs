using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicp.SolidP
{
    // Dependency Inversion Principle
    // The Dependency Inversion Principle (DIP) states that
    // high-level modules/classes should not depend on low-level modules/classes.
    // Both should depend upon abstractions. Secondly, abstractions should not depend upon details.
    // Details should depend upon abstractions   
}
namespace SOLID_PRINCIPLES.DIP
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}

namespace SOLID_PRINCIPLES.DIP
{
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}

namespace SOLID_PRINCIPLES.DIP
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}

namespace SOLID_PRINCIPLES.DIP
{
    public class EmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hard coded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}

// A high-level module is a module that always depends on other modules.
// So, in our example, the EmployeeBusinessLogic class depends on EmployeeDataAccess class,
// so here the EmployeeBusinessLogic class is the high-level module and the EmployeeDataAccess class is the low-level module.

namespace SOLID_PRINCIPLES.DIP
{
    public interface IEmployeeDataAccess1
    {
        Employee GetEmployeeDetails(int id);
    }
}

namespace SOLID_PRINCIPLES.DIP
{
    public class EmployeeDataAccess1 : IEmployeeDataAccess1
    {
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hardcoded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}

namespace SOLID_PRINCIPLES.DIP
{
    public class DataAccessFactory1
    {
        public static IEmployeeDataAccess1 GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess1();
        }
    }
}

namespace SOLID_PRINCIPLES.DIP
{
    public class EmployeeBusinessLogic1
    {
        IEmployeeDataAccess1 _EmployeeDataAccess;
        public EmployeeBusinessLogic1()
        {
            _EmployeeDataAccess = DataAccessFactory1.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
