
using SOLID.OpenClosed.OCPGood;

//good way
SalaryCalculator salaryCalculator = new SalaryCalculator();

Console.WriteLine(salaryCalculator.SalaryCalculate(10000, new LowSalaryCalculate()));