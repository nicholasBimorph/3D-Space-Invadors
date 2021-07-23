using System;
using Assets.Scripts.Behaviours;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    /// <summary>
    ///     The most simple weapon a <see cref="ISpaceShip" />
    ///     can have in the 3D Space Invaders game.
    /// </summary>
    internal class RocketLauncher : IWeapon
    {
        private  Transform _playerShipTransform;


        /// <summary>
        /// The <see cref="ILaser"/> used by this <see cref="IWeapon"/>.
        /// </summary>
        public ILaser Laser { get; }

        /// <summary>
        ///     The amount of damage this <see cref="IWeapon" />
        ///     does in a single shot.
        /// </summary>
        public int Damage { get; }

        /// <summary>
        /// The amount of units this <see cref="IWeapon"/>
        /// can reach. Not all weapons can have the same reach.
        /// </summary>
        public int Reach { get; }

        /// <summary>
        /// Construct a new <see cref="RocketLauncher" />.
        /// </summary>
        internal RocketLauncher(ILaser laser, Transform playerShipTransform)
        {
            this.Laser = laser;

            this.Damage = 300;

            this.Reach = 100;

            _playerShipTransform = playerShipTransform;

        }

        /// <summary>
        /// Performs a ray cast.
        /// </summary>
        /// <param name="direction"></param>
        private void RayCastShoot(Vector3 direction)
        {
            var ray = new Ray(this.Laser.Origin, direction);

            bool hit = Physics.Raycast(ray, out var hitInfo);

            if (!hit) return;

            var meteorite = hitInfo.transform.gameObject.GetComponent<IGameEntity>();

            meteorite.Health -= this.Damage;
        }

        public void Shoot()
        {

            if (!Input.GetKey(KeyCode.R))
            {
                this.Laser.CanDisplay = false;

                this.Laser.Display(Vector3.one);

                return;
            }

            var direction = _playerShipTransform.position + _playerShipTransform.forward * this.Reach;

            this.Laser.CanDisplay = true;

            this.RayCastShoot(direction);
            
            this.Laser.Display(direction);
            
        }
    }
}