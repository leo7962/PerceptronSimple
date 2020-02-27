using Microsoft.AspNetCore.Mvc;
using PerceptronSimple.Model;
using System;

namespace PerceptronSimple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NeuronasController : ControllerBase
    {
        //int[,] input = new int[,] { { 1, 0 }, { 1, 1 }, { 0, 1 }, { 0, 0 } };
        //int[] output = { 0, 1, 0, 0 };
        //Neurona neurona = new Neurona();        


        //double[] weight = { , , };

        //public double simoide(double tetha)
        //{
        //    return tetha > 0 ? 1 : -1;
        //}

        //public double Evaluate (double ent1, double ent2, int i)
        //{            
        //    double y = Math.Tanh((ent1 * neurona.W1) + (ent2 * neurona.W2) - neurona.tetha);
        //    if (i == 1000)
        //    {

        //    }
        //    else
        //    {

        //        i++;
        //        //neurona(ent1,ent2,neurona.W1,neurona.W2,neurona.tetha,i);

        //    }
        //    return y;

        static void Neurona()
        {
            int[,] input = new int[,] { { 1, 0 }, { 1, 1 }, { 0, 1 }, { 0, 0 } };
            int[] outputs = { 0, 1, 0, 0 };

            Random r = new Random();

            double[] weights = { r.NextDouble(), r.NextDouble(), r.NextDouble() };

            double learningRate = 1;
            double totalError = 1;

            while (totalError > 0.2)
            {
                totalError = 0;
                for (int i = 0; i < 4; i++)
                {
                    int output = calculateOutput(input[i, 0], input[i, 1], weights);

                    int error = outputs[i] - output;

                    weights[0] += learningRate * error * input[i, 0];
                    weights[1] += learningRate * error * input[i, 1];
                    weights[2] += learningRate * error * 1;

                    totalError += Math.Abs(error);
                }

            }

            Console.WriteLine("Results:");
            for (int i = 0; i < 4; i++)
                Console.WriteLine(calculateOutput(input[i, 0], input[i, 1], weights));

            Console.ReadLine();

        }

        private static int calculateOutput(double input1, double input2, double[] weights)
        {
            double sum = input1 * weights[0] + input2 * weights[1] + 1 * weights[2];
            return (sum >= 0) ? 1 : 0;
        }
    }
}      
    