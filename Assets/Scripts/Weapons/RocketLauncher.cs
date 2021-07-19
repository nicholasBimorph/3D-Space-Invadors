using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Weapons
{
    /// <summary>
    /// The most simple weapon a <see cref="ISpaceShip"/>
    /// can have in the 3D Space Invaders game.
    /// </summary>
    internal class RocketLauncher : IWeapon
    {
        /// <summary>
        /// The amount of damage this <see cref="IWeapon"/>
        /// does in a single shot.
        /// </summary>
        public int Damage { get; }

        /// <summary>
        /// Construct a new <see cref="RocketLauncher"/>.
        /// </summary>
        internal RocketLauncher()
        {
            this.Damage = 50;
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
