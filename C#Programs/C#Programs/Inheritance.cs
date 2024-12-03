using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programs
{
    public class Inheritance
    {
        public int id;
        public Inheritance(int i) 
        {
            id = i;
            Console.WriteLine(id);
        }

        public virtual void Method1() { Console.WriteLine("Parent"); }
        public void Sagar()
        {
            Console.WriteLine("Sagar");
        }

        //public void Display()
        //{
        //    Console.WriteLine(id);
        //}
    }

    public class Child : Inheritance
    {
        public Child(int i) : base(3) 
        {
            Console.WriteLine(base.id);
        }

        public new void Method1() { Console.WriteLine("Child"); }

        public new void Sagar()
        {
            Console.WriteLine("Sagar1");
        }

        //public void ChildMethod()
        //{
        //    base.Display();
        //}
    }

    public class GrandChild : Inheritance
    {
        public GrandChild(int i) : base(i)
        {
            Console.WriteLine(base.id);
        }

        public new void Sagar()
        {
            Console.WriteLine("Sagar2");
        }

        //public void GrandChildMethod()
        //{
        //    Console.WriteLine(base.id);
        //}
    }
}
