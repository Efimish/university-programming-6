using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class Sberbank : IBankService
    {
        public string Name
        {
            get
            {
                return "Сбербанк";
            }
        }
        public double CalculateSalary(double baseSalary)
        {
            return baseSalary * 0.99;
        }
    }
}
