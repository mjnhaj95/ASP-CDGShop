using CDGShop.Data.Infrastructure;
using CDGShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDGShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {

    }
   public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
