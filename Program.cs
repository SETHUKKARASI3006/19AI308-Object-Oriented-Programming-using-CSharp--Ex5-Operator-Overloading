using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class MyClass
    {
        private int value;

        public MyClass()
        {
            this.value = 11;
        }

        public MyClass(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return value;
        }

        public static bool operator ==(MyClass obj1, MyClass obj2)
        {

            if (obj1 is null || obj2 is null)
                return false;

            return obj1.value == obj2.value;
        }

        public static bool operator !=(MyClass obj1, MyClass obj2)
        {
            return !(obj1 == obj2);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(28);
            MyClass ob2 = new MyClass();
            MyClass ob3 = new MyClass(28);

            Console.WriteLine("Are object1 and object2 equal? " + (ob1 == ob2));
            Console.WriteLine("Are object1 and object3 equal? " + (ob1 == ob3));
        }
    }
}
