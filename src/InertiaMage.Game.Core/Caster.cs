using System.Collections.Generic;
using System.Data;

namespace InertiaMage.Game.Core
{
    public class Caster
    {
        private int _mana;
        private Spellbook _spellbook;

        public Caster(int mana)
        {
            _spellbook = new Spellbook(0);
            _mana = mana;
        }

        public void Learn(Spell spell)
        {
            _spellbook.Add(spell);
        }

        public void Cast(string spell, ITarget target)
        {
            _spellbook[spell].Apply(target);
        }


    }
}