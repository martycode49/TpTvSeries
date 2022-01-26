using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTvSeries.CORE.Models
{
    public class Episode : Entity
    {
        public int Number { get; set; }
        public double Duration { get; set; }
        public int IdSeason { get; set; }
        public Season Season { get; set; }
    }
}
