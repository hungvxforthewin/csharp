namespace OverloadingOverride
{
    public class Animal
    {
        public virtual void soundAnimal()
        {
            System.Console.WriteLine("sound");
        }

        public void actionAnimal(){
            System.Console.WriteLine("action");
        }
    }
}