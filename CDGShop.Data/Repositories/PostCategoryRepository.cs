using CDGShop.Data.Infrastructure;
using CDGShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDGShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
        IEnumerable<PostCategory> GetMulti(Func<PostCategory, bool> p);
    }
    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<PostCategory> GetMulti(Func<PostCategory, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
