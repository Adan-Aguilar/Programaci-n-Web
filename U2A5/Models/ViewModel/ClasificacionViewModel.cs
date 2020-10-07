using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U2A5.Models.ViewModel
{
    public class ClasificacionViewModel
    {
        public int NumImagen { get; set; }

        public IEnumerable<Clase> Clase { get; set; }


    }
}
