using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpTvSeries.CORE;
using TpTvSeries.CORE.Dto;
using TpTvSeries.CORE.Models;
using TpTvSeries.CORE.Services;

namespace TpTvSeries.Services.Services
{
    public class SerieService : ISerieService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SerieService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Serie> CreateSerie(Serie newSerie)
        {
            await _unitOfWork.Series.AddAsync(newSerie);
            await _unitOfWork.CommitAsync();
            return newSerie;
        }


        public async Task<IEnumerable<Serie>> GetAllSerie()
        {
            return await _unitOfWork.Series.GetAllSerieAsync();
        }

        public async Task<Serie> GetSerieById(int id)
        {
            return await _unitOfWork.Series.GetAllWithSeasonByIdAsync(id);
        }

        public Task<SerieFullDto> GetSerieFull(int id)
        {
            SerieFullDto serieFullDto = new SerieFullDto();
            // Faire la liste des saisons et Episodes de la serie spécifiée
            //serieFullDto.Seasons.Join(Episode).
            return null;
        }
    }
}
