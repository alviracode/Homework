internal class Program3
{
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());

        if (a % 6 == 0 || a % 7 == 0)
        {
            Console.WriteLine("Да, день выходной!");
        }
        else
        {
            Console.WriteLine("Нет, день не выходной!");
        }
    }
}