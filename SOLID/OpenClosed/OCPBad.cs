using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.OCPBad
{
    public class SalaryCalculator
    {
        public decimal SalaryCalculate(decimal salary, SalaryType salaryType)
        {
            decimal newSalary = 0;
            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = salary * 2;
                    break;
                case SalaryType.Middle:
                    newSalary = salary * 3;
                    break;
                case SalaryType.High:
                    newSalary = salary * 4;
                    break;
                default:
                    break;
            }
            return newSalary;
        }

        public enum SalaryType
        {
            Low,
            Middle,
            High
        }
    } 
}
