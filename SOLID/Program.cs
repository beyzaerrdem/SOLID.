
using SOLID.LiskovSubstitution.LSPGood;
using SOLID.OpenClosed.OCPGood2;

//good way
//SalaryCalculator salaryCalculator = new SalaryCalculator();
//Console.WriteLine(salaryCalculator.SalaryCalculate(10000, new LowSalaryCalculate()));

//good2 delegate
//Console.WriteLine(salaryCalculator.SalaryCalculate(10000, new LowSalaryCalculate().Calculate));
//Console.WriteLine(salaryCalculator.SalaryCalculate(10000, x =>
//{
//    return x * 10; //lambda ile metodu yazmadan bu şekilde
//}));

BasePhone basePhone = new IPhone();
basePhone.Call();
((ITakePhoto)basePhone).TakePhoto();

basePhone = new Nokia();
basePhone.Call();
