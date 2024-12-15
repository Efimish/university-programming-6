using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class Engineer : Employee
    {
        public override string GetInfo()
        {
            return base.GetInfo() +
                $"Должность: Инженер\n";
        }
    }
}
