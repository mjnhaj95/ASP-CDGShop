namespace CDGShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}