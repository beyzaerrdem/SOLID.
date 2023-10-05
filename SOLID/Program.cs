
using SOLID.DependencyInversion;
using SOLID.LiskovSubstitution.LSPGood;
using SOLID.OpenClosed.OCPGood2;
using System.Net.Http.Headers;

//good way
//SalaryCalculator salaryCalculator = new SalaryCalculator();
//Console.WriteLine(salaryCalculator.SalaryCalculate(10000, new LowSalaryCalculate()));

//good2 delegate
//Console.WriteLine(salaryCalculator.SalaryCalculate(10000, new LowSalaryCalculate().Calculate));
//Console.WriteLine(salaryCalculator.SalaryCalculate(10000, x =>
//{
//    return x * 10; //lambda ile metodu yazmadan bu şekilde
//}));

//ISP
//BasePhone basePhone = new IPhone();
//basePhone.Call();
//((ITakePhoto)basePhone).TakePhoto();

//basePhone = new Nokia();
//basePhone.Call();


//DIP
ProductService productService = new ProductService(new ProductRepositoryFromSqlServer());
productService.GetProducts().ForEach(product => Console.WriteLine(product));