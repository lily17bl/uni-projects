internal class Program
{
    private static void Main(string[] args)
    {
        int seed = 0;
        int constant = 0;
        int digits = 4;
        int iterations = 0;

        seed = readSeed();
        constant = readConstant();
        iterations = readIterations();

        printHeader();
        constantMultiplierMethod(0, seed, constant, digits, iterations);
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

    static int readConstant()
    {
        bool flag = false;
        int constant = 0;
        do
        {
            try
            {
                Console.Write("Ingrese una constante de 4 dígitos, entera, positiva y mayor a 0: ");
                constant = int.Parse(Console.ReadLine());

                if (constant > 9999 || constant <= 0)
                {
                    throw new FormatException();
                }

                flag = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("La constante debe ser entera, positiva, mayor a 0 y de máximo 4 dígitos");
                Console.ReadKey();
                Console.Clear();
            }
        }
        while (!flag);

        return constant;
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

    static void constantMultiplierMethod(int i, int seed, int constant, int digits, int iterations)
    {
        if (i == iterations)
        {
            Console.ReadKey();
        }
        else
        {
            string sI = stringfy(i, 4);
            string sSeed = stringfy(seed, digits);
            string sConstant = stringfy(constant, digits);

            int number = seed * constant;
            string sNumber = stringfy(number, digits * 2);

            string sNewSeed = sNumber.Substring(2, 4);
            int newSeed = int.Parse(sNewSeed);

            string sRandomNumber = String.Format("0.{0}", sNewSeed);
            printRow(sI, sConstant, sSeed, sNumber, sNewSeed, sRandomNumber);

            i++;

            constantMultiplierMethod(i, newSeed, constant, digits, iterations);
        }
    }

    static void printHeader()
    {
        Console.WriteLine("  i  |   a  |   X  |  a  *  X |  i*  |  ri");
    }

    static void printRow(string i, string constant, string seed, string number, string newSeed, string randomNumber)
    {
        String row = String.Format("{0} | {1} | {2} | {3} | {4} | {5}", i, constant, seed, number, newSeed, randomNumber);
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