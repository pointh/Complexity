using System;

namespace Complexity
{
    class Program
    {
        static int NajdiMaximalniHodnotu(int[] iArr) // O(n)
        {
            var zatimMax = int.MinValue;
            for(int i=0; i<iArr.Length; i++) // n krát
            {
                if (zatimMax < iArr[i]) 
                {
                    zatimMax = iArr[i];
                }
            }
            return zatimMax;
        }

        static double[] VypoctiKvadratickouRovnici(double a, double b, double c) // O(1)
        {
            double diskriminant;

            if (a == 0.0)
                return new double[] { -c/b, double.NaN };

            diskriminant = b * b - 4.0 * a * c;
            if (diskriminant < 0.0)
                return new double[] { double.NaN, double.NaN };

            return new double[]
                {
                    -1*b + Math.Sqrt(diskriminant),
                    -1*b - Math.Sqrt(diskriminant),
                };
        }

        static void VytiskniSudaNenulovaCislaNaDiagonale(int[,] sachovnice) // O(n*n)
        {
            if (sachovnice.GetLength(0) != sachovnice.GetLength(1))
                throw new ArgumentException("Vstupní pole musí být čtvercové!");

            for(int i = 0; i < sachovnice.GetLength(0); i++) // n krát
            {
                for(int j = 0; j < sachovnice.GetLength(1); j++) // * n
                {
                    if (i == j && sachovnice[i, j] != 0 && sachovnice[i,j] % 2 == 0) // n * n krát
                    {
                        Console.WriteLine(sachovnice[i, j]);
                    }
                }
            }
        }
        static void Main() // O(n*n) - nejhorší případ je složitosti O(n*n)
        {
            int[] hodyKostkou = { 1, 1, 3, 5, 1, 2, 1 };
            Console.WriteLine($"Maximální hodnota v poli je {NajdiMaximalniHodnotu(hodyKostkou)}");
            int[,] iArr2D = {   { 2, 2, 3 }, 
                                { 2, 0, 1 }, 
                                { 3, 1, 3 } };
            VytiskniSudaNenulovaCislaNaDiagonale(iArr2D);
        }
    }
}
