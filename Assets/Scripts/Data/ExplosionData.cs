using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Data
{
    /// <summary>
    /// Stores the data for an explosion event in the
    /// game.
    /// </summary>
    public readonly struct ExplosionData
    {
        /// <summary>
        /// The explosion prefab to instantiate.
        /// </summary>
        public GameObject ExplosionPrefab { get; }

        /// <summary>
        /// The hit point where the explosion happened.
        /// </summary>
        public Vector3 HitPoint { get; }

        /// <summary>
        /// Construct a new <see cref="ExplosionData"/>.
        /// </summary>
        /// <param name="explosionPrefab"></param>
        /// <param name="hitPoint"></param>
        /// <remarks>
        /// Stores the data for an explosion event in the
        /// game.
        /// </remarks>
        public ExplosionData(GameObject explosionPrefab, Vector3 hitPoint)
        {
            this.ExplosionPrefab = explosionPrefab;

            this.HitPoint = hitPoint;
        }
    }
}
