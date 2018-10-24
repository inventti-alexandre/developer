using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.APIs.Clima
{
    class ClimaResponse
    {
        public decimal temperature { get; set; }
        public string wind_direction { get; set; }
        public decimal wind_velocity { get; set; }
        public decimal humidity { get; set; }
        public string condition { get; set; }
        public decimal pressure { get; set; }
        public string icon { get; set; }
        public decimal sensation { get; set; }
        public string date { get; set; }
    }
}
