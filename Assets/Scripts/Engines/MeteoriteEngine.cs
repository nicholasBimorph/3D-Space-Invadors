using Assets.Scripts.Interfaces;
using Assets.Scripts.Populations;

namespace Assets.Scripts.Engines
{
   

    /// <summary>
    /// This <see cref="MeteoriteEngine"/> computes
    /// the behaviour of all <see cref="IMeteorite"/>'s
    /// in the game.
    /// </summary>
    public class MeteoriteEngine : IEngine
    {
        private readonly MeteoritePopulation _meteoritePopulation;

        public MeteoriteEngine(MeteoritePopulation meteoritePopulation)
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
