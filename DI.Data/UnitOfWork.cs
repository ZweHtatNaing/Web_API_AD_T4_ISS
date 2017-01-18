using System;
using System.Collections.Generic;
using DI.Core;

namespace DI.Data
{
   public class UnitOfWork:IDisposable
    {
        private readonly IDbContext _context;
        private bool _disposed;
        private Dictionary<string, object> _repositories;

        public UnitOfWork(IDbContext context)
        {
            this._context = context;
        }

        public UnitOfWork()
        {
            _context = new IDbContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public Respority<T> Repository<T>() where T : BaseEntity
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Respority<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                _repositories.Add(type, repositoryInstance);
            }
            return (Respority<T>)_repositories[type];
        }
    }
}
