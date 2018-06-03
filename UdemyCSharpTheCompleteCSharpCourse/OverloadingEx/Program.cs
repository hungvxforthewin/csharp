namespace OverloadingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, intResult;

            intResult = 0;
            a = 1;
            b = 2;
            c = 3;

            intResult = perFormAdd(a, b, c);

            System.Console.WriteLine(intResult);

        }
        static int PerFormAdd(int x, int y)
        {
            return x + y;
        }
        static int perFormAdd(int x,int y, int z)
        {
            return x + y + z;
        }
    }
}
