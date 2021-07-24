using Assets.Scripts.Interfaces;
using Assets.Scripts.Populations;

namespace Assets.Scripts.Engines
{
   

    /// <summary>
    /// This <see cref="MeteoriteRunner"/> computes
    /// the behaviour of all <see cref="IMeteorite"/>'s
    /// in the game.
    /// </summary>
    public class MeteoriteRunner : IRunner
    {
        private readonly MeteoritePopulation _meteoritePopulation;

        public MeteoriteRunner(MeteoritePopulation meteoritePopulation)
        {
            _meteoritePopulation = meteoritePopulation;
        }

        public void Run()
        {
            foreach (var meteorite in _meteoritePopulation)
            {
                meteorite.ComputeBehaviour();
            }
        }

    }
}
