using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Установка кодировки вывода
            Console.OutputEncoding = Encoding.UTF8;

            // Иван
            Employee ivan = new Manager()
            {
                Name = "Петров Иван Васильевич",
                BaseSalary = 45000,
                BankService = new Gazprombank()
            };
            ivan = new IntermediateEnglishSertificate(ivan, "Экзамен по английскому", 2007);
            Console.WriteLine(ivan.GetInfo());

            ivan.BankService = new Sberbank();
            Console.WriteLine(ivan.GetInfo());

            // Тамара
            Employee tamara = new Engineer()
            {
                Name = "Иванова Тамара Евгеньевна",
                BaseSalary = 60000,
                BankService = new Gazprombank()
            };
            Console.WriteLine(tamara.GetInfo());

            // Леонид
            Employee leonid = new Scientist()
            {
                Name = "Сидоров Леонид Аркадьевич",
                BaseSalary = 50000,
                BankService = new Gazprombank()
            };
            leonid = new AcademicDegree(
                leonid,
                "Влияние фазы луны на способность хомячков к полётам",
                2015,
                "Бесполезные исследования, требующие инвестиций правительства"
            );
            Console.WriteLine(leonid.GetInfo());
        }
    }
}
