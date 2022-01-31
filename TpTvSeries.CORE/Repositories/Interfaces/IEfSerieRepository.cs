using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TpTvSeries.CORE.Dto;
using TpTvSeries.CORE.Models;

namespace TpTvSeries.CORE.Repositories.Interfaces
{
    public interface IEfSerieRepository : IGenericRepository<Serie>
    {
        #region READ
        Task<IEnumerable<Serie>> GetAllWithSeasonAsync();
        Task<Serie> GetAllWithSeasonByIdAsync(int id);
        Task<List<SerieFullDto>> GetSerieFull(Expression<Func<Serie, bool>> predicate);
        #endregion
    }
}
