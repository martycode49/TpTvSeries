using System.Collections.Generic;
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
        public IEnumerable<Serie> ComplexQuery()
        {
            // Simulate a complex query
            return new List<Serie>();
        }
        #endregion
    }
}
