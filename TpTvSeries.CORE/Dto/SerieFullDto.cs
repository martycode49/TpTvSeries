using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpTvSeries.CORE.Models;

namespace TpTvSeries.CORE.Dto
{
    public class SerieFullDto
    {
        public Serie Serie { get; set; }
        public IEnumerable<Season> Seasons { get; set; }
        public IEnumerable<Episode> Episodes { get; set; }
    }
}
