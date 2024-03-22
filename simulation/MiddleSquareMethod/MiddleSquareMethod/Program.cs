internal class Program
{
    private static void Main(string[] args)
    {
        int seed = 0;
        int digits = 4;
        bool flag = false;
        List<int> history = new List<int>();

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

        middleSquareMethod(0, seed, digits, history);
    }

    static void middleSquareMethod(int i, int seed, int digits, List<int> history)
    {
        if (history.Contains(seed))
        {
            Console.WriteLine(String.Format("La semilla {0}, que se usó en la iteración {1} se repite en la iteración {2}", seed, history.IndexOf(seed), i));
            Console.ReadKey();
        }
        else
        {
            history.Add(seed);
            string sI = stringfy(i, 3);
            string sSeed = stringfy(seed, digits);

            int number = seed * seed;
            string sNumber = stringfy(number, digits * 2);

            string sNewSeed = sNumber.Substring(2, 4);
            int newSeed = int.Parse(sNewSeed);

            string sRandomNumber = String.Format("0.{0}", sNewSeed);

            printRow(sI, sSeed, sNumber, sNewSeed, sRandomNumber);

            i++;

            middleSquareMethod(i, newSeed, digits, history);
        }
    }

    static void printRow(string i, string seed, string number, string newSeed, string randomNumber)
    {
        String row = String.Format("{0} | {1} | {2} | {3} | {4} ", i, seed, number, newSeed, randomNumber);
        Console.WriteLine(row);
    }

    static string stringfy (int value, int maxdigits)
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