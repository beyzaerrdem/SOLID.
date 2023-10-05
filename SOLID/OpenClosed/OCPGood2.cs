using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.OCPGood2
{
   
    public class LowSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MiddleSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 3;
        }
    }

    public class HighSalaryCalculate 
    { 

        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class ManagerSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 5;
        }
    }

    public class SalaryCalculator
    {
        public decimal SalaryCalculate(decimal salary, Func<decimal, decimal> salaryCalculateDelegate) //delegate
        {
            return salaryCalculateDelegate(salary);
        }
    } 
}
