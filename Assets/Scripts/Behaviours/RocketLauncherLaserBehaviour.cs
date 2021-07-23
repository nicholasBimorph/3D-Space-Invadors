using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Weapons;
using UnityEngine;

namespace Assets.Scripts.Behaviours
{
    [RequireComponent(typeof(LineRenderer))]
    public class RocketLauncherLaserBehaviour : MonoBehaviour
    {

        public ILaser RocketLauncherLaser;

        public void Start()
        {
            RocketLauncherLaser = new RocketLauncherLaser(this.transform, this.GetComponent<LineRenderer>());

        }
    }
}
