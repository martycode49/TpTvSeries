using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpTvSeries.CORE.Models;

namespace TpTvSeries.CORE.Services
{
    public interface ISerieService
    {
        Task<IEnumerable<Serie>> GetAllSerie();
        Task<Serie> GetSerieById(int id);
        Task<Serie> CreateSerie(Serie newSerie);
        //Task UpdateSerie(Serie serieToBeUpdate, Serie serie);
        //Task DeleteSerie(Serie serie);
    }
}
