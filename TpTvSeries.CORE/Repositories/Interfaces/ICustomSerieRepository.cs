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
        IEnumerable<Serie> ComplexQuery();
        #endregion
    }
}
