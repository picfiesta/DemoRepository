using DemoRepository.Data;
using DemoRepository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository.Repository
{
    public class UnitOfWork : IDisposable
    {
        private readonly DemoRepositoryContext context;
        string errorMessage = string.Empty;   
        private bool disposed;
        private Dictionary<string, object> repositories;

        public UnitOfWork(DemoRepositoryContext context)
        {
            this.context = context;
        }

        public UnitOfWork()
        {
            context = new DemoRepositoryContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public RepositoryBase<T> Repository<T>() where T : BaseEntity
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repositoryInstance);
            }
            return (RepositoryBase<T>)repositories[type];
        }
    }   
}
