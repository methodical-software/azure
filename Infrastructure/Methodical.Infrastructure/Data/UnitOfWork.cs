using Methodical.Core.Interfaces;

namespace Methodical.Infrastructure.Data
{
    public sealed class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MethodicalDBContext _context;
        private bool _disposed;
        public UnitOfWork(MethodicalDBContext context)
        {
            this._context = context;
        }

        public void Dispose() => Dispose(true);

        public async Task Save()
        {
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                this._context.Dispose();
            }

            this._disposed = true;
        }
    }
}
