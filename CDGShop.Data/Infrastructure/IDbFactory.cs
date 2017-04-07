using System;

namespace CDGShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        CDGShopDbContext Init();
    }
}