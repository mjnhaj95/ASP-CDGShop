using CDGShop.Data.Infrastructure;
using CDGShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDGShop.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {

    }
  public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
       public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
