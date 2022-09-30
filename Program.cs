using System;

namespace harmonics
{
    class Program
    {
        static double getHarmonicMagnitude(double[] samples, int numFundamentalCycles, int harmonicN)
        {
            //TODO: implement this
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            var squareWave = new double[100];
            //one cycle, amplitude 1
            for (int i = 0; i < 50; i++)
            {
                squareWave[i] = 1;
            }
            for (int i = 50; i < 100; i++)
            {
                squareWave[i] = -1;
            }
            var h3 = getHarmonicMagnitude(squareWave, 1, 3);
            Console.WriteLine($"Square wave H3 Calculated: {h3:F3} Expected: {4 / (3 * Math.PI):F3}"); //expect some rounding error

            var sineWave = new double[1000];
            //5 cycles, amplitude 2, 35 degree phase shift
            for (int i = 0; i < 1000; i++)
            {
                sineWave[i] = 2 * Math.Sin(5 * i * 2 * Math.PI / 1000 + (35 * Math.PI / 180));
            }
            var h1 = getHarmonicMagnitude(sineWave, 5, 1);
            Console.WriteLine($"Sine H1 Calculated: {h1:F3} Expected: {2:F3}");

            Console.ReadLine();
        }
    }
}
