using System;
using IntertiaMage.Game.Core.Bad;

#pragma warning disable 219

namespace InertiaMage.SpellEditor.Presentation.Consol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var simulation = new CasterExample();
            simulation.Run();
            Console.ReadLine();
        }

        public class CasterExample
        {
            public void Run()
            {
                var spell = new DamageSpell("Fireball", 10, 5)
                {
                    Description = "Big AOE"
                };

                var caster = new Caster("Deccer");
                caster.Learn(spell);

                var enemy1 = new Enemey1(10);

                caster.Cast("Fireball", enemy1);
                caster.Cast("Fireball", enemy1);
            }
        }


    }
}


