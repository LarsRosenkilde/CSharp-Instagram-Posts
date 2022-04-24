namespace PrimeNumbers;

class Program
{
    public static void Main(string[] args)
    {
        int num = 7;
        if (IsPrime(num))
        {
            Console.WriteLine("{0} is a prime number.", num);
        }
        else
        {
            Console.WriteLine("{0} is not a prime number.", num);
        }
    }

    private static bool IsPrime(int num)
    {
        if (num <= 1 || num % 2 == 0)
        {
            return false;
        } else if (num == 2)
        {
            return true;
        }
        var limit = (int)Math.Floor(Math.Sqrt(num));
        for (int i = 3; i <= limit; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

