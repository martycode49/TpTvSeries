using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpTvSeries.CORE.Models;

namespace TpTvSeries.CORE.Repositories.Interfaces
{
    public interface ICustomSerieRepository : IGenericRepository<Serie>
    {
        #region READ
        Task<IEnumerable<Serie>> GetAllWithSeasonAsync();
        Task<Serie> GetAllWithSeasonByIdAsync(int id);
        #endregion
    }
}
