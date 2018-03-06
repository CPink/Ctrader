using System.Threading.Tasks;
using System;

namespace ctrader.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}