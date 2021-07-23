using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Engines;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Populations;
using UnityEngine;

namespace Assets.Scripts.Behaviours
{
    public class MeteoriteEngineBehaviour: MonoBehaviour
    {
        private  IEngine _meteoriteEngine;

        public GameObject MeteoritePopulation;

        public void Start()
        {
            _meteoriteEngine = new MeteoriteEngine(MeteoritePopulation.GetComponent<MeteoritePopulation>());
        }

        public void Update()
        {
            _meteoriteEngine.Run();
        }
    }
}
