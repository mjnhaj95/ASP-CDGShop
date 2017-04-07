namespace CDGShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private CDGShopDbContext dbContext;

        public CDGShopDbContext Init()
        {
            return dbContext ?? (dbContext = new CDGShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}