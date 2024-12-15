using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    public class IntermediateEnglishSertificate : EmployeeDecorator
    {
        public string ExaminationTitle;
        public int YearOfSertificate;
        public IntermediateEnglishSertificate(Employee employee, string ExaminationTitle, int YearOfSertificate)
        {
            this.employee = employee;
            this.ExaminationTitle = ExaminationTitle;
            this.YearOfSertificate = YearOfSertificate;
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                $"------------------------\n" +
                $"Экзамен: {ExaminationTitle}\n" +
                $"Год получения сертификата: {YearOfSertificate}\n";
        }
    }
}
