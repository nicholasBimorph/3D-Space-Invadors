using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.SpaceInvaders.Core
{
    /// <summary>
    /// A contract which determines how
    /// a <see cref="IEnemy"/> in this game should
    /// behave.
    /// </summary>
    public interface IEnemy
    {
        /// <summary>
        /// A value in radians which determines factor
        /// by which this <see cref="IEnemy"/> can spot
        /// a player.
        /// </summary>
        float SightThreshold { get; set; }

        /// <summary>
        /// A method which computes if the player is within
        /// the line of sight of this <see cref="IEnemy"/>.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the player is within the <see cref="SightThreshold"/>
        /// otherwise <see langword="false"/>.
        /// </returns>
        public bool IsInLineOfSight();
    }
}
