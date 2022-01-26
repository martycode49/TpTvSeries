using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTvSeries.CORE.Models
{
    public class Season : Entity
    {
        // So we extends the Entity class
        public string Title { get; set; }
        public double Rating { get; set; }
        public IEnumerable<Season> Seasons { get; set; }

    }
}
