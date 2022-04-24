namespace PrimeNumbers;

class Program
{
    public static void Main(string[] args)
    {
        int num = 7;
        if (IsPrime(num))
        {
            Console.WriteLine($"{num} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a prime number.");
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
