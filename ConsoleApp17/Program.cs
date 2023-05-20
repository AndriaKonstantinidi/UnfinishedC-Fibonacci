class Program
{
    static void Main()
    {
        foreach(var item in Evend(21))
        {
            Console.WriteLine(item);
        }
    }
    static IEnumerable<int> Evend(int a)
    {
        for(int i = 0; i <= a; i++)
        {
            int c = i + 1;
            if(i + i == c)
            {
                yield return c;
            }
        }
    }
}