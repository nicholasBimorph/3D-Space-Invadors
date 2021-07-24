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
        private  IRunner _meteoriteRunner;

        public GameObject MeteoritePopulation;

        public void Start()
        {
            _meteoriteRunner = new MeteoriteRunner(MeteoritePopulation.GetComponent<MeteoritePopulation>());
        }

        public void Update()
        {
            _meteoriteRunner.Run();
        }
    }
}
