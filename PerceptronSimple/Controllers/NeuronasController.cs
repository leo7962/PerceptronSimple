using Microsoft.AspNetCore.Mvc;
using PerceptronSimple.Model;
using System;

namespace PerceptronSimple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NeuronasController : ControllerBase
    {
        public double simoide(double tetha)
        {
            return tetha > 0 ? 1 : -1;
        }

        public double neurona(double ent1, double ent2, int i)
        {
            Neurona Neurona = new Neurona();
            double y = Math.Tanh((ent1 * Neurona.W1) + (ent2 * Neurona.W2) - Neurona.tetha);
            if (i == 1000)
            {

            }
            else
            {
                
                i++;
                //neurona(ent1,ent2,neurona.W1,neurona.W2,neurona.tetha,i);

            }
            return y;
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
            bool sw = false;
            while (!sw)
            {
                sw = true;

                double p1 = Convert.ToDouble(r.NextDouble() - r.NextDouble());
                double p2 = Convert.ToDouble(r.NextDouble() - r.NextDouble());
                double tetha = Convert.ToDouble(r.NextDouble() - r.NextDouble());

                if (simoide(neurona(4.24, 8621.12,1)) != 1)
                {
                    sw = false;
                }

                if (simoide(neurona(4.24, 8621.12, 1)) != -1)
                {
                    sw = false;
                }

                if (simoide(neurona(4.24, 8621.12, 1)) != -1)
                {
                    sw = false;
                }

                if (simoide(neurona(4.24, 8621.12, 1)) != -1)
                {
                    sw = false;
                }
            }

            return evaluacion();
        }
    }
}