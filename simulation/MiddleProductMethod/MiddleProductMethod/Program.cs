using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        int seed1 = 0;
        int seed2 = 0;
        int digits = 4;
        int iterations = 0;

        seed1 = readSeed();
        seed2 = readSeed();
        iterations = readIterations();

        printHeader();
        middleProductMethod(0, seed1, seed2, digits, iterations);
    }

    static int readSeed()
    {
        bool flag = false;
        int seed = 0;
        do
        {
            try
            {
                Console.Write("Ingrese una semilla de 4 dígitos, entera, positiva y mayor a 0: ");
                seed = int.Parse(Console.ReadLine());

                if (seed > 9999 || seed <= 0)
                {
                    throw new FormatException();
                }

                flag = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("La semilla debe ser entera, positiva, mayor a 0 y de máximo 4 dígitos");
                Console.ReadKey();
                Console.Clear();
            }
        }
        while (!flag);

        return seed;
    }

    static int readIterations()
    {
        bool flag = false;
        int iterations = 0;
        do
        {
            try
            {
                Console.Write("¿Cuántos números desea generar? ");
                iterations = int.Parse(Console.ReadLine());

                if (iterations > 9999 || iterations <= 0)
                {
                    throw new FormatException();
                }

                flag = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor especifique una cantidad entera, positiva y menor a 9999");
                Console.ReadKey();
                Console.Clear();
            }
        }
        while (!flag);

        return iterations;
    }

    static void middleProductMethod(int i, int seed1, int seed2, int digits, int iterations)
    {
        if (i == iterations)
        {
            Console.ReadKey();
        }
        else
        {
            string sI = stringfy(i, 4);
            string sSeed1 = stringfy(seed1, digits);
            string sSeed2 = stringfy(seed2, digits);

            int number = seed1 * seed2;
            string sNumber = stringfy(number, digits * 2);

            string sNewSeed = sNumber.Substring(2, 4);
            int newSeed = int.Parse(sNewSeed);

            string sRandomNumber = String.Format("0.{0}", sNewSeed);
            printRow(sI, sSeed1, sSeed2, sNumber, sNewSeed, sRandomNumber);

            i++;

            middleProductMethod(i, seed2, newSeed, digits, iterations);
        }
    }

    static void printHeader()
    {
        Console.WriteLine("  i  |  X1  |  X2  |  X1 * X2 |  i*  |  ri");
    }

    static void printRow(string i, string seed1, string seed2, string number, string newSeed, string randomNumber)
    {
        String row = String.Format("{0} | {1} | {2} | {3} | {4} | {5}", i, seed1, seed2, number, newSeed, randomNumber);
        Console.WriteLine(row);
    }

    static string stringfy(int value, int maxdigits)
    {
        string newString = value.ToString();

        int dif = maxdigits - newString.Length;

        while (newString.Length < maxdigits)
        {
            newString = "0" + newString;
        }

        return newString;
    }
}