using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class AcademicDegree : EmployeeDecorator
    {
        public string DissertationTitle;
        public int Year;
        public string ScienceArea;

        public AcademicDegree(Employee employee, string dissertationTitle, int year, string scienceArea)
        {
            this.employee = employee;
            DissertationTitle = dissertationTitle;
            Year = year;
            ScienceArea = scienceArea;
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                $"------------------------\n" +
                $"Научная работа: {DissertationTitle}\n" +
                $"Год защиты: {Year}\n" +
                $"Область: {ScienceArea}\n";
        }
    }
}
