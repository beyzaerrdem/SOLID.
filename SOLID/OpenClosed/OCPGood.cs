using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.OCPGood
{
    public interface ISalaryCalculate
    {
        public decimal Calculate(decimal salary);
    }

    public class LowSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MiddleSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 3;
        }
    }

    public class HighSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class ManagerSalaryCalculate : ISalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 5;
        }
    }

    public class SalaryCalculator
    {
        public decimal SalaryCalculate(decimal salary, ISalaryCalculate salaryCalculate)
        {
            return salaryCalculate.Calculate(salary);
        }
    } 
}
