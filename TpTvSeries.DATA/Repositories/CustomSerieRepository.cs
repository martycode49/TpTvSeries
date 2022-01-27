using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TpTvSeries.CORE.Models;
using TpTvSeries.CORE.Repositories;
using TpTvSeries.CORE.Repositories.Interfaces;

namespace TpTvSeries.DATA.Repositories
{
    public class CustomSerieRepository : GenericRepository<Serie>, ICustomSerieRepository
    {
        /// <summary>
        /// Initializes a new instance of the CustomSerieRepository.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public CustomSerieRepository(DbContext dbContext)
            : base(dbContext)
        {

        }


        #region READ
        async Task<IEnumerable<Serie>> ICustomSerieRepository.GetAllWithSeasonAsync()
        {
            return await _dbSet.Include(c => c.Seasons).ToListAsync();
        }

        async Task<Serie> ICustomSerieRepository.GetAllWithSeasonByIdAsync(int id)
        {
            return await _dbSet.Include(s => s.Seasons).SingleOrDefaultAsync(s => s.Id == id);
        }
        #endregion
    }
}
