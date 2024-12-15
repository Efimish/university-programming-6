using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class Employee
    {
        public virtual string Name { get; set; }
        public virtual double BaseSalary { get; set; }
        public virtual IBankService BankService { get; set; }
        public virtual string GetInfo()
        {
            return
                $"========================\n" +
                $"{Name}\n" +
                $"Базовая зарплата: {BaseSalary}\n" +
                $"Для перечисления зарплаты используется сервис {BankService.Name}\n" +
                $"Зарплата после удержания комиссии сервиса: {BankService.CalculateSalary(BaseSalary)}\n";
        }
        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }
}
