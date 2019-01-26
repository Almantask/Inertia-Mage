using System.Collections.Generic;
using System.Xml.Schema;

namespace InertiaMage.Game.Core
{
    public class Spell
    {
        private readonly List<ISpellEffect> _effects;

        public string Name { get; }
        public string Description { get; }

        private ITarget _owner;
        private int _manaCost;

        public Spell(string name, string description, List<ISpellEffect> effects, int manaCost)
        {
            _effects = effects;
            Name = name;
            Description = description;
            _manaCost = manaCost;
        }

        public void Apply(ITarget target = null)
        {
            if (_owner == null && _owner == null)
                throw new NoTargetException();

            foreach (var effect in _effects)
            {
                effect.Apply(_owner, target);
            }
        }
    }
}