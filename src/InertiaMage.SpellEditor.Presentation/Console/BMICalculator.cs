using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaMage.SpellEditor.Presentation.Consol
{
    public static class BMICalculator
    {
        public static float CalculateV1(float height, float weight)
        {
            const float indexH = 0.8f;
            const float indexW = 0.9f;
            return height / weight * indexH * indexW;
        }

    }

    public class Person
    {
        public object Height { get; set; }
        public object Weight { get; set; }
    }
}
