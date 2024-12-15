using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class EmployeeDecorator : Employee
    {
        protected Employee employee;
        public override string Name
        {
            get => employee.Name;
            set => employee.Name = value;
        }
        public override double BaseSalary
        {
            get => employee.BaseSalary;
            set => employee.BaseSalary = value;
        }
        public override IBankService BankService
        {
            get => employee.BankService;
            set => employee.BankService = value;
        }
        public override string GetInfo()
        {
            return employee.GetInfo();
        }
        public override double CalculateSalary()
        {
            return employee.CalculateSalary();
        }
    }
}
