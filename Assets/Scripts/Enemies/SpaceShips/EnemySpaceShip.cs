using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interfaces;
using Assets.Scripts.SpaceInvaders.Core;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class EnemySpaceShip : MonoBehaviour, ISpaceShip, IEnemy
    {
        private  IEnemyMove _enemySpaceShipMove;

        private Transform _transform;

        private  Transform _playerSpaceShip;

       [SerializeField] private GameObject _playerSpaceShipPrefab;

        /// <summary>
        /// The total health this <see cref="IGameEntity"/>
        /// has.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        ///     The <see cref="EnemySpaceShip" /> this <see cref="ISpaceShip" />
        ///     uses.
        /// </summary>
        public IWeapon Weapon { get; set; }

        /// <summary>
        /// A value in radians which determines factor
        /// by which this <see cref="IEnemy"/> can spot
        /// a player.
        /// </summary>
        public float SightThreshold { get; set; }

        public void Start()
        {
            _playerSpaceShip = _playerSpaceShipPrefab.transform;

            _transform = this.transform;

            _enemySpaceShipMove = new EnemySpaceShipMove(_playerSpaceShip, _transform, 20);
        }

      

        /// <summary>
        ///     Determines the behavior of how this <see cref="ISpaceShip" />
        ///     flies.
        /// </summary>
        public void Fly()
        {
            _enemySpaceShipMove.Follow();

          //  _enemySpaceShipMove.Move();
        }

        // TODO: Remove update method after EnemySpaceShipRunner is created
        public void Update()
        {
            _enemySpaceShipMove.Follow();

            _enemySpaceShipMove.Move();
        }

        /// <summary>
        /// Determines the behaviour of how this
        /// <see cref="IEnemyMove"/> should shoot.
        /// </summary>
        public void Shoot()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// A method which computes if the player is within
        /// the line of sight of this <see cref="IEnemy"/>.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the player is within the <see cref="IEnemy.SightThreshold"/>
        /// otherwise <see langword="false"/>.
        /// </returns>
        public bool IsInLineOfSight()
        {
            var directionToTarget = _playerSpaceShip.position - _transform.position;

            var ray = new Ray(_transform.position, directionToTarget);

            bool hit = Physics.Raycast(ray, out var hitInfo);

            if (hit)
            {

                float angle = Vector3.Angle(_transform.forward, directionToTarget);

                if (angle <= this.SightThreshold)
                {


                    return true;
                }
            }


            return false;
        }
    }
}
