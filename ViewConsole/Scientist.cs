using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class Scientist : Employee
    {
        public override string GetInfo()
        {
            return base.GetInfo() +
                $"Должность: Научный сотрудник\n";
        }
    }
}
