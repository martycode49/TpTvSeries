using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TpTvSeries.CORE.Dto;
using TpTvSeries.CORE.Models;
using TpTvSeries.CORE.Repositories;
using TpTvSeries.CORE.Repositories.Interfaces;

namespace TpTvSeries.DATA.Repositories
{
    public class EfSerieRepository : GenericRepository<Serie,DatabaseContext>, IEfSerieRepository
    {
        private DatabaseContext _databaseContext
        {
            get => _dbContext as DatabaseContext;
        }
        /// <summary>
        /// Initializes a new instance of the EfSerieRepository.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public EfSerieRepository(DatabaseContext dbContext)
        : base(dbContext)
    {
    }

    #region READ
    async Task<IEnumerable<Serie>> IEfSerieRepository.GetAllWithSeasonAsync()
        {
            return await _databaseContext.Series.Include(c => c.Seasons).ToListAsync();
        }

        async Task<Serie> IEfSerieRepository.GetAllWithSeasonByIdAsync(int id)
        {
            return await _databaseContext.Series.Include(s => s.Seasons).SingleOrDefaultAsync(s => s.Id == id);
        }

        async Task<List<SerieFullDto>> IEfSerieRepository.GetSerieFull(Expression<Func<Serie, bool>> predicate)
        {
            IQueryable<SerieFullDto> result = null;
                
            return await result.ToListAsync();
        }

        #endregion
    }
}
