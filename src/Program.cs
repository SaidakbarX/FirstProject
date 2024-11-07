namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number please");
            var number = Convert.ToInt32(Console.ReadLine());
            var thors = number / 1000;
            var hondr = number % 1000 / 100;
            var ten =number % 1000 % 100 /10;
            var one = number % 10;
            var res = thors + ten + hondr + one;
            Console.WriteLine(res);
            
        }
    }
}
