using System.Threading.Tasks;
using ctrader.Core;

namespace ctrader.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CtraderDbContext context;

        public UnitOfWork(CtraderDbContext context)
        {
            this.context = context;

        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}