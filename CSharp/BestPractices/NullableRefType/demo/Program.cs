using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
           testNullable();
        }

        public static void testNullable()
        {
            //int notNull = null;  // Compiler warns here
            //int? yesNull = null;
            //Nullable num = null;
            //string text = null;
            //string text = "Hello world!";
            //string? text = null;
            //int? goal = null;
            //PassNullReference2(goal.Value.ToString()); 

            // call instance
            DemoNullable dn = new DemoNullable();
            dn.CallDisplay();
        }
        public static void PassNullReference (string str)
        {
            if(str != null)
            {
                Console.WriteLine("The first char is " + str[0]);
            }
        }
        public static void PassNullReference2 (string str)
        {
            if(str != null)
            {
                Console.WriteLine("The first char is " + str[0]);
            }
            else
            {
                System.Console.WriteLine("Nullable");
            }
        }
    }
}
