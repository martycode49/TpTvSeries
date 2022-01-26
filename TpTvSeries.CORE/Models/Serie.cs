using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTvSeries.CORE.Models
{
    public class Serie : Entity
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public IEnumerable<Season> Seasons { get; set; }
    }
}
