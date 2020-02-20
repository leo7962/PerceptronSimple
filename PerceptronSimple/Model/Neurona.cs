using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerceptronSimple.Model
{
    public class Neurona
    {
        public double W1 { get; set; }
        public double W2 { get; set; }
        public double error = 0.6;
        public double tetha = 0.4;      
    }
}
