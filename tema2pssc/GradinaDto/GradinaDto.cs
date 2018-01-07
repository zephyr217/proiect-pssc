using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Gradina;



namespace GradinaDto
{
    public class GradinaDto
    {

        public int nrLocatie;
        public Flori Flori { get; internal set; }
        public Legume Legume { get; internal set; }
        public Pomi Pomi { get; internal set; }
    }
}
