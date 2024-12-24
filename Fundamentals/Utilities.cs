using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Utilities<T> where T : IComparable, new ()
    {
        //contraint types
        //where T:IComparable - for interface
        //where T:Product - for class
        //where T:struct - for value type
        //where T:class - for ref type
        //where T:new() - obj/class with default constr

        public int Max(int x, int y)
        {
            return x > y ? x : y;
        }

        //generic - constraints
        //where T:IComparable - for interface
        public T Max(T x,T y)
        {
         return x.CompareTo(y) > 0 ? x : y;
        }

        //where T:new() - obj/class with default constr
        public void DoSomeThing(T value)
        {
            var obj = new T();
        }
    }
}
