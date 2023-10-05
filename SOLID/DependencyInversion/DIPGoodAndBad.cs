using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    //Bad Way
    //public class ProductService //high level
    //{
    //    private readonly ProductRepositoryFromSqlServer _repositoryFromSqlServer; //low level - bad way
    //    public ProductService(ProductRepositoryFromSqlServer productRepositoryFromSqlServer) 
    //    {
    //        _repositoryFromSqlServer = productRepositoryFromSqlServer;
    //    }

    //    public List<string> GetProducts()
    //    {
    //        return _repositoryFromSqlServer.GetAll();
    //    }
    //}

    //public class ProductRepositoryFromSqlServer
    //{
    //    public List<string> GetAll()
    //    {
    //        return new List<string>() { "SqlServer Data1, SqlServer Data2" };
    //    }
    //}


    //Good Way
    public class ProductService 
    {
        private readonly IRepository _repository; 
        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetProducts()
        {
            return _repository.GetAll();
        }
    }

    public class ProductRepositoryFromSqlServer : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "SqlServer Data1, SqlServer Data2" };
        }
    }


    public interface IRepository
    {
        List<string> GetAll();
    }
}
