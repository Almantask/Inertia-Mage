using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InertiaMage.Game.Core
{
    public class Spellbook
    {
        public Spell this[string name]
        {
            get { return _spells[name]; }
        }

        private Dictionary<string, Spell> _spells;
        private int _slots;

        public Spellbook(int slots, params Spell[] spells)
        {
            int neededSlots = spells.Length;
            if (slots < neededSlots)
                throw new SpellbookOutOfSlotsException(neededSlots, slots);

            _slots = slots;
            _spells = new Dictionary<string, Spell>();
            Add(spells);
        }

        public void Add(params Spell[] spells)
        {
            foreach(var spell in spells)
                _spells.Add(spell.Name, spell);
        }

        public void AddSlot() => _slots++;
    }

    public class SpellbookOutOfSlotsException:Exception
    {
        public SpellbookOutOfSlotsException(int needed, int available) : base($"Ran out of slots. Needed- {needed}, provided- {available}")
        { }
    }
}
