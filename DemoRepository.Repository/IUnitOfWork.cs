using System;
namespace DemoRepository.Repository
{
    public interface IUnitOfWork
    {
        void Dispose();
        void Dispose(bool disposing);
        RepositoryBase<T> Repository<T>() where T : DemoRepository.Entity.BaseEntity;
        void Save();
    }
}
