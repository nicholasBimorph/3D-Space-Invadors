using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.PlayerShip
{
    public class PlayerSpaceShip : ISpaceShip //: MonoBehaviour
    {

        //[SerializeField] private float _maxSpeed;

        //public PlayerSpaceShipMove Move;

        //void Start()
        //{
        //    _maxSpeed = 10;

        //    this.Move = new PlayerSpaceShipMove(this.transform, _maxSpeed);
        //}

        //// Update is called once per frame
        //void Update()
        //{

        //}

        /// <summary>
        /// The <see cref="IWeapon"/> this <see cref="ISpaceShip"/>
        /// uses.
        /// </summary>
        public IWeapon Weapon { get; set; }

        /// <summary>
        /// The maximum speed this <see cref="ISpaceShip"/>
        /// can fly.
        /// </summary>
        public float MaxSpeed { get; set; }

        /// <summary>
        /// The health of this <see cref="ISpaceShip"/>.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Construct a new <see cref="PlayerSpaceShip"/>.
        /// </summary>
        public PlayerSpaceShip(int initHealth, float maxSpeed, IWeapon weapon)
        {
            this.Health = initHealth;

            this.MaxSpeed = maxSpeed;

            this.Weapon = weapon;
        }

        /// <summary>
        /// Determines the behavior how this <see cref="ISpaceShip"/>
        /// flies.
        /// </summary>
        public void Fly()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines the behaviour of how this <see cref="ISpaceShip"/>
        /// should shoot.
        /// </summary>
        public void Shoot()
        {
            throw new NotImplementedException();
        }

    }
}
