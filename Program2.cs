internal class Program2
{
    private static void Main(string[] args)
    {
        int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));

        if (a > 99)
        {
            while (a > 999) { a = a / 10; }
            a = a % 10;
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
            Console.WriteLine("Число не трёхзначное");
        }
    }
}