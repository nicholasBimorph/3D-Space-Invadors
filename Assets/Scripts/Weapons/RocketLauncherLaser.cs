using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    
    public class RocketLauncherLaser : ILaser
    {
        private LineRenderer _lineRenderer;

        private readonly Transform _transform;

        /// <summary>
        /// Determines if this <see cref="ILaser"/>
        /// can be displayed or not.
        /// </summary>
        public bool CanDisplay { get; set; }

        /// <summary>
        /// The origin of this <see cref="ILaser"/>.
        /// </summary>
        public Vector3 Origin => _transform.position;

        /// <summary>
        /// Construct a new <see cref="RocketLauncherLaser"/>.
        /// </summary>
        /// <param name="transform"></param>
        public RocketLauncherLaser(Transform transform, LineRenderer lineRenderer)
        {
            _transform = transform;

            _lineRenderer = lineRenderer;

            _lineRenderer.enabled = false;
        }


        /// <summary>
        /// Displays this <see cref="ILaser"/>.
        /// </summary>
        /// <param name="target">
        /// The target this <see cref="ILaser"/>
        /// will stop at.
        /// </param>
        public void Display(Vector3 target)
        {
            if (this.CanDisplay)
            {
                _lineRenderer.enabled = true;

                _lineRenderer.SetPosition(0, _transform.position);

                _lineRenderer.SetPosition(1, target);
                return;
            }


            _lineRenderer.enabled = false;

        }
    }
}
