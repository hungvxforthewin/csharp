using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Me[] a = new Me[4];
            a[0] = new Me();
            a[1] = new Con1();
            a[2] = new Con2();
            a[3] = new Con3();


            foreach (var item in a)
            {
                item.Draw();
            }
        }
    }
    class Me
    {
        public virtual void Draw()
        {
            Console.WriteLine("Toi la me");
        }
    }

    class Con1 : Me
    {
        public override void Draw()
        {
            Console.WriteLine("Toi la con1");
        }
    }

    class Con2 : Me
    {
        public override void Draw()
        {
            Console.WriteLine("Toi la con2");
        }
    }

    class Con3 : Me
    {
        public override void Draw()
        {
            Console.WriteLine("Toi la con3");
        }
    }
}
