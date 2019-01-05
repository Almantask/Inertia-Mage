using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaMage.SpellEditor.Core
{
    public static class LogicalOperationsTest
    {
        public static void LogicalTest1()
        {
            var a = 0;
            var b = 5;
            var c = true;
            var d = false;//    F    T   T    T T    F
            var predicate1 = a == b || c && !d || !c;
            Console.WriteLine(predicate1);

            bool t = true;
            bool f = false;
            var predicate2 = f && f && t || f && f || t;
            Console.WriteLine(predicate2);

            var predicate3 = f && f && t || f && (f || t);
            Console.WriteLine(predicate3);

            var l1 = new Logic();

            var predicate4 = l1.Condition & l1.Condition;
            Console.WriteLine(predicate4);

            var predicate5 = l1.Condition && l1.Condition;
            Console.WriteLine(predicate5);
        }


    }
}
