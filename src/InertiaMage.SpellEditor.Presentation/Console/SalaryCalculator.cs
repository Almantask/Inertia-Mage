namespace InertiaMage.SpellEditor.Presentation.Consol
{
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