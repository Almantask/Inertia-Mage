using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntertiaMage.Game.Core.Bad
{
    public class DamageSpell
    {
        public string Name { get; }
        public int Mana { get; }
        public float Damage { get; }

        private string _description;

        public string Description
        {
            get
            {
                return $"{Name} costs {Mana} {_description}";
            }
            set { _description = value; }
        }

        public DamageSpell(string name, int mana, float damage)
        {
            Name = name;
            Mana = mana;
            Damage = damage;
        }

        public void Apply(ITarget target)
        {
            target.Receive(this);
        }

        public override string ToString()
        {
            return Description;
        }
    }

    public interface ITarget
    {
        float HP { get; }
        void Receive(DamageSpell spell);
    }

    public class Enemey1:ITarget
    {
        public float HP { get; private set; }
        private bool _isDead;

        public Enemey1(float hp)
        {
            HP = hp;
        }

        public void Receive(DamageSpell spell)
        {
            TakeDamage(spell.Damage);
        }

        public void TakeDamage(float dmg)
        {
            HP -= dmg;
            if (HP <= 0 && !_isDead)
            {
                _isDead = true;
                Die();
            }
            else
            {
                Console.WriteLine($"HP left: {HP}");
            }
        }

        private void Die()
        {
            Console.WriteLine("Dead");
        }
    }

    public interface ICaster
    {
        void Cast(string name, ITarget target);
        void Learn(DamageSpell spell);
    }

    public class Caster : ICaster
    {
        private ISpellbook _spelboook;

        public Caster(string name)
        {
           _spelboook = new Spellbook(1);
        }

        public void Cast(string name, ITarget target)
        {
            var spell = _spelboook[name];
            target.Receive(spell);
        }

        public void Learn(DamageSpell spell)
        {
            _spelboook.Add(spell);
        }
    }

    public interface ISpellbook
    {
        DamageSpell this[string spellName] { get; }
        void Add(params DamageSpell[] spells);
    }

    public class Spellbook : ISpellbook
    {
        public DamageSpell this[string spellName]
        {
            get
            {
                return _spells.TryGetValue(spellName, out var spell) ? spell : throw new SpellbookNoSpellFoundException();
            }
        }

        private readonly Dictionary<string, DamageSpell> _spells;
        private readonly int _slots;

        public Spellbook(int slots, params DamageSpell[] spells)
        {
            _spells = new Dictionary<string, DamageSpell>();
            _slots = slots;

            Add(spells);
        }

        public void Add(params DamageSpell[] spells)
        {
            var neededSlots = _spells.Count + spells.Length;
            if(_slots < neededSlots)
                throw new SpellbookOutOfSlotsException(neededSlots, _slots);

            foreach (var spell in spells)
            {
                _spells.Add(spell.Name, spell);
            }
        }
    }

    internal class SpellbookNoSpellFoundException : Exception
    {
    }

    public class SpellbookOutOfSlotsException : Exception
    {
        public SpellbookOutOfSlotsException(int neededSlots, int actualSlots) : base(
            $"Needed {neededSlots}, available: {actualSlots}. Missing: {neededSlots - actualSlots}")
        {
        }
    }


   
}
