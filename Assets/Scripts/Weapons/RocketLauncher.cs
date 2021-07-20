using System;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Weapons
{
    /// <summary>
    ///     The most simple weapon a <see cref="ISpaceShip" />
    ///     can have in the 3D Space Invaders game.
    /// </summary>
    internal class RocketLauncher : IWeapon
    {
        /// <summary>
        ///     Construct a new <see cref="RocketLauncher" />.
        /// </summary>
        internal RocketLauncher()
        {
            this.Damage = 50;
        }

        /// <summary>
        ///     The amount of damage this <see cref="IWeapon" />
        ///     does in a single shot.
        /// </summary>
        public int Damage { get; }

        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}