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
            int? yesNull = null;
            Nullable num = null;
            //string text = null;
            string text = "Hello world!";
            PassNullReference(text); 
        }
        public static void PassNullReference (string str){
            Console.WriteLine("The first char is " + str[0]);
        }
    }
}
