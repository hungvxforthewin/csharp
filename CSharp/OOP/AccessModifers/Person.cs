using System;

namespace AccessModifierTutorial
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        // non-static method
        private void ShowSecret()
        {
            Console.WriteLine("Secret of " + name);
        }

        // static method
        private static void DoSomething(string jobs)
        {
            Console.WriteLine("Do something with " + jobs);
        }


        class Daily
        {
            
            public void Logging()
            {
                DoSomething("IT");   
                //ShowSecret(); 
            }
        }        
    
    }
}