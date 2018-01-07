using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenimente.Gradina
{
    public class MagistralaEvenimente
    {
        public static readonly Lazy<MagistralaEvenimente> Instanta = new Lazy<MagistralaEvenimente>(() => new MagistralaEvenimente());
        public MagistralaEvenimente()
        {

        }
    }
}
