using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaMage.SpellEditor.Core
{
    public class SpellAttributes
    {
        public static string Magesfire()
        {
            string name = "Mage's Fire";
            float dmg = 10;
            float boost = 1.02f;
            int firedmg = 4;
            int reqlevel = 6;
            bool areaofeffect = true;
            float aoeval = 10;
            string output = "";

            return output = $"Spell Attributes: {name}, " +
                            $"Damage: {dmg}, " +
                            $"Boost: {boost}, " +
                            $"Fire Damage: {firedmg}, " +
                            $"Area of Effect: {areaofeffect} {aoeval}m, " +
                            $"Required Level: {reqlevel}";

        }

        public static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}
