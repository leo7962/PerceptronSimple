using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerceptronSimple.Model;

namespace PerceptronSimple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NeuronasController : ControllerBase
    {
        public double simoide (double tetha)
        {                        
            return tetha > 0 ? 1 : -1;
        }   
                       
        public double neurona ( double ent1, double ent2, double p1, double p2, double tetha)
        {
            return tetha + ent1 * p1 + ent2 * p2;
        }

        [HttpGet]
        public double evaluacion()
        {
            Random r = new Random();

            //Neurona neurona = new Neurona();
            //var p1 = neurona.W1;
            //var p2 = neurona.W2;
            //var error = neurona.error;
            //var tetha = neurona.tetha;
            var sw = false;
            while (!sw)
            {                
                sw = true;

                var p1 = Convert.ToDouble(r.NextDouble() - r.NextDouble());
                var p2 = Convert.ToDouble(r.NextDouble() - r.NextDouble());
                var tetha = Convert.ToDouble(r.NextDouble() - r.NextDouble());

                if (simoide(neurona(4.24, 8621.12, p1, p2, tetha)) != 1) sw = false;
                if (simoide(neurona(4.24, 8621.12, p1, p2, tetha)) != -1) sw = false;
                if (simoide(neurona(4.24, 8621.12, p1, p2, tetha)) != -1) sw = false;
                if (simoide(neurona(4.24, 8621.12, p1, p2, tetha)) != -1) sw = false;
            }

            return evaluacion();
        }
    }
}