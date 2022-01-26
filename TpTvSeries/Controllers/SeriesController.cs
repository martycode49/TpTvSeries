using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using TpTvSeries.CORE.Models;
using TpTvSeries.CORE.Services;
using TpTvSeries.DATA;
using TpTvSeries.Services.Services;

namespace TpTvSeries.Controllers
{
    public class SeriesController : Controller
    {
        private readonly ISerieService _serieService;

        public SeriesController(ISerieService serieService)
        {
            this._serieService = serieService;
        }

        // Get: Series/All
        public async Task<IActionResult> Index()
        {
            var list = await _serieService.GetAllSerie();
            return View(list);
        }

        // View Serie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Serie/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Serie serie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _serieService.CreateSerie(new Serie
                    {
                        Title = serie.Title,
                        Rating = serie.Rating,
                    });
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(serie);
        }
    }
}
