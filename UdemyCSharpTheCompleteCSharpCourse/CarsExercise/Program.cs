using System;

namespace CarsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes a = new Mercedes();
            a.DisplayInfo();
        }
    }
    #region Class Car
    class Car
    {
        private decimal price;
        protected int maxSpeed;
        public string color;

        protected decimal Price
        {
            get { return price;}
            set { price = value;}
        }


        public virtual void DisplayInfo()
        {
            price = 1000;
            maxSpeed = 30;
            color = "Black";

            Console.WriteLine($"Default value: price is {price}, max speed is: {maxSpeed}, color is: {color}");
        }
    }
    #endregion
    class Mercedes : Car
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            base.Price = 15000;
            base.maxSpeed = 200;
            base.color = "blue";

            Console.WriteLine($"Override value: price is {Price}, max speed is: {maxSpeed}, color is: {color}");
        }
    }
}
