using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using U2A5.Models;

namespace U2A5.Services
{
    public class ClasificacionServices
    {
       
            public List<Clase> Clases { get; set; }

            public ClasificacionServices()
            {
                using (animalesContext context = new animalesContext())
                {
                    Clases = context.Clase.OrderBy(x => x.Nombre).ToList();
                }
            }
     
    }
}
