using System;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.PlayerShip
{
    public class PlayerSpaceShip : ISpaceShip
    {
        private readonly ISpaceShipMove _spaceShipMove;

        /// <summary>
        ///     The <see cref="IWeapon" /> this <see cref="ISpaceShip" />
        ///     uses.
        /// </summary>
        public IWeapon Weapon { get; set; }

        /// <summary>
        ///     The health of this <see cref="ISpaceShip" />.
        /// </summary>
        public int Health { get; set; }


        /// <summary>
        ///     Construct a new <see cref="PlayerSpaceShip" />.
        /// </summary>
        public PlayerSpaceShip(int initHealth, IWeapon weapon, ISpaceShipMove spaceShipMove)
        {
            this.Health = initHealth;

            this.Weapon = weapon;

            _spaceShipMove = spaceShipMove;
        }


        /// <summary>
        ///     Determines the behavior how this <see cref="ISpaceShip" />
        ///     flies.
        /// </summary>
        public void Fly()
        {
            _spaceShipMove.Steer();

            _spaceShipMove.Propulsion();
        }

        /// <summary>
        ///     Determines the behaviour of how this <see cref="ISpaceShip" />
        ///     should shoot.
        /// </summary>
        public void Shoot()
        {
            this.Weapon.Shoot();
        }

        /// <summary>
        /// Computes the desired behaviour for this <see cref="IGameEntity"/>
        /// </summary>
        public void ComputeBehaviour()
        {
            throw new NotImplementedException();
        }
    }
}