using System;

namespace DeMoExceptionHanding
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 3;
            double div = 0;

            try
            {
                div = y/x;
            }
            catch (Exception e)
            {

               System.Console.WriteLine("error: "+ e.Message);
            }
            finally
            {
                System.Console.WriteLine("result: "+div);
            }

        }

       
    }
}
