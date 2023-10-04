using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibility.SRPGood
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }          
    }

    public class ProductRepository
    {
        private static List<Product> productList = new List<Product>();

        public List<Product> products => productList;

        public ProductRepository()
        {
            productList = new()
            {
                new(){Id=1,Name="Kitap 1"},
                new(){Id=2, Name="Kitap 2"},
                new(){Id=3,Name="Kitap 3"},
                new(){Id=4,Name="Kitap 4"},
            };
        }

        public void SaveOrUpdate(Product product)
        {
            var hasProduct = productList.Any(p => p.Id == product.Id);

            var findIndex = productList.FindIndex(p => p.Id == product.Id);

            if (!hasProduct)
            {
                productList.Add(product);
            }

            productList[findIndex] = product;

        }

        public void Delete(int id)
        {
            var find = productList.Find(p => p.Id == id);

            if (find == null)
            {
                throw new Exception("Ürün bulunamadı");
            }
            productList.Remove(find);
        }

    }

    public class ProductPresenter
    {
        public void WriteProduct(List<Product> productList)
        {
            foreach (var product in productList)
            {
                Console.WriteLine($"{product.Id} - {product.Name}");
            }
        }
    }
}
