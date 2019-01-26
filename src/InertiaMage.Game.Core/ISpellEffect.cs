namespace InertiaMage.Game.Core
{
    public interface ISpellEffect
    {
        void Apply(ITarget self, ITarget other);
    }
}