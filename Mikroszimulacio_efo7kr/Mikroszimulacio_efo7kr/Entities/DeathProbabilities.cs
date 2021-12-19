using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulacio_efo7kr.Entities
{
    public class DeathProbabilities
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public double P { get; set; }
    }
}
