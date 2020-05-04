using LearnToTech.Database;
using Microsoft.EntityFrameworkCore;
using System;

namespace LearnToTech.Infrastructure.DataAccess
{
    public abstract class BaseDataAccess : IDisposable
    {
        protected readonly DatabaseContext context;
        public BaseDataAccess(DbContextOptions<DatabaseContext> options)
        {
            context = new DatabaseContext(options);
        }

        #region IDisposable Support

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    context.Dispose();
                disposedValue = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }

        #endregion
    }
}
