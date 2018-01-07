using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradinaDto;

namespace Commands.Gradina
{
    public class CommandAdaugaGradina:Command
    {
        public GradinaDto.GradinaDto gradina { get; set; }
    }
}
