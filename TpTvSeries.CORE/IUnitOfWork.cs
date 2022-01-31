using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TpTvSeries.CORE.Models;
using TpTvSeries.CORE.Repositories.Interfaces;

namespace TpTvSeries.CORE
{
    public interface IUnitOfWork : IDisposable
    {
        IEfSerieRepository Series { get; }
        Task<int> CommitAsync();
    }
}
