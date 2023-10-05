using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.ISPGoodAndBad
{
   
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //Bad Way farklı amaçları bir interfacede toplamak
    //public interface IProductRepository
    //{
    //    Product GetById(int id);

    //    List<Product> GetAll();

    //    void Add(Product product);

    //    void Update(Product product);

    //    void Delete(Product product);
    //}

    public interface IWriteProductRepository
    {
        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);
    }

    public interface IReadProductRepository
    {
        Product GetById(int id);

        List<Product> GetAll();
    }


    public class WriteProductRepository : IWriteProductRepository
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    public class ReadProductRepository : IReadProductRepository
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }
    }


}
