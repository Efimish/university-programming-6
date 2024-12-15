using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class Gazprombank : IBankService
    {
        public string Name
        {
            get
            {
                return "Газпромбанк";
            }
        }
        public double CalculateSalary(double baseSalary)
        {
            return baseSalary * 0.985;
        }
    }
}
