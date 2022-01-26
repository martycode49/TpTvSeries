using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TpTvSeries.CORE;
using TpTvSeries.CORE.Models;
using TpTvSeries.CORE.Repositories;
using TpTvSeries.CORE.Repositories.Interfaces;
using TpTvSeries.DATA.Repositories;

namespace TpTvSeries.DATA
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private ICustomSerieRepository _serieRepository;

        public UnitOfWork(DatabaseContext context)
        {
            this._context = context;
        }

        public ICustomSerieRepository Series => _serieRepository = _serieRepository ?? new CustomSerieRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
