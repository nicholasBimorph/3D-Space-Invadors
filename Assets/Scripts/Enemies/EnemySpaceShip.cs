using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class EnemySpaceShip : MonoBehaviour, IEnemy, ISpaceShip
    {
        /// <summary>
        /// The total health this <see cref="IGameEntity"/>
        /// has.
        /// </summary>
        public int Health { get; set; }


        public IWeapon Weapon { get; set; }




        /// <summary>
        /// 
        /// </summary>
        public void Follow()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Determines the behavior how this <see cref="ISpaceShip" />
        ///     flies.
        /// </summary>
        public void Fly()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines the behaviour of how this
        /// <see cref="IEnemy"/> should shoot.
        /// </summary>
        public void Shoot()
        {
            throw new NotImplementedException();
        }
    }
}
