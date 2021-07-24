using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    public interface ILaser
    {
        /// <summary>
        /// Determines if this <see cref="ILaser"/>
        /// can be displayed or not.
        /// </summary>
        bool CanDisplay { get; set; }

        /// <summary>
        /// The origin of this <see cref="ILaser"/>.
        /// </summary>
        Vector3 Origin { get; }

        /// <summary>
        /// Displays this <see cref="ILaser"/>.
        /// </summary>
        /// <param name="target">
        /// The target this <see cref="ILaser"/>
        /// will stop at.
        /// </param>
        void Display(Vector3 target);
    }
}
