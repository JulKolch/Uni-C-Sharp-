using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            A a2 = new C();
            a2.F();
            a2.G();
            a2.H();

            B b2 = new C();
            b2.F();
            b2.G();
            b2.H();
        }
    }

    class A
    {
        public virtual void F()
        {
            Console.WriteLine("A.F");
        }
        public void G()
        {
            Console.WriteLine("A.G");
        }
        public virtual void H()
        {
            Console.WriteLine("A.H");
        }
    }

    class B : A
    {
        public new void F()
        {
            Console.WriteLine("B.F");
        }
        public new virtual void G()
        {
            Console.WriteLine("B.G");
        }
        public override void H()
        {
            Console.WriteLine("B.H");
        }
    }

    class C : B
    {
        public override void G()
        {
            Console.WriteLine("C.G");
        }
        public new virtual void H()
        {
            Console.WriteLine("C.H");
        }
    }
}
