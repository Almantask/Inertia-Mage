using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using InertiaMage.SpellEditor.Core;
#pragma warning disable 219

namespace InertiaMage.SpellEditor.Presentation.Consol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Testing.ForeachTest();
            LogicalOperationsTest.LogicalTest1();
            ArrayTest.Test2dArray();
            ArrayTest.JaggedArray();
        }
    }

    internal static class SalaryCalculator
    {
        public static float CalculateAfterTaxes(float salary)
        {
            const float tax1 = 0.85f;
            const float tax2 = 0.99f;
            const float bonus = 1.07f;
            return salary * tax1 * tax2 * bonus;
        }

        private static void Step1()
        {
            throw new System.NotImplementedException();
        }
    }


}


