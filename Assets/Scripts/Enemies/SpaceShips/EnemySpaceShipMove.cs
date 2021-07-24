using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    /// <summary>
    /// This class is responsible for the movement of
    /// enemy space ships in the game.
    /// </summary>
    public class EnemySpaceShipMove : IEnemyMove
    {
        private readonly Transform _playerShip;
        private readonly Transform _enemySpaceShip;
        private float _rotationDamp = 4f;
        private float _maxSpeed;

        /// <summary>
        /// The maximum speed which controls the movement.
        /// </summary>
        public float MaxSpeed
        {
            get => _maxSpeed;

            set
            {
                if (value < 0)
                    _maxSpeed = 0;

                _maxSpeed = value;
            }
        }

        /// <summary>
        /// The amount of damp applied to the rotation.
        /// smaller values have a larger damping effect.
        /// </summary>
        public float RotationDamp
        {
            get => _rotationDamp;

            set
            {
                if (value < 0)
                    _rotationDamp = 0;

                _rotationDamp = value;
            }
        }

        /// <summary>
        /// Construct a new <see cref="EnemySpaceShipMove"/>.
        /// </summary>
        /// <param name="playerShip">
        /// the player <see cref="ISpaceShip"/> this <see cref="EnemySpaceShipMove"/>
        /// should take in to account.
        /// </param>
        public EnemySpaceShipMove(Transform playerShip, Transform enemySpaceShip, float maxSpeed)
        {
            _playerShip = playerShip;

            _enemySpaceShip = enemySpaceShip;

            this.MaxSpeed = maxSpeed;
        }

        

        /// <summary>
        /// Follows a player in the game with the goal
        /// to make some damage to it.
        /// </summary>
        public void Follow()
        {
            var direction = _playerShip.position - _enemySpaceShip.position;

            var delta = Quaternion.LookRotation(direction, _enemySpaceShip.transform.up);

            _enemySpaceShip.rotation =
                Quaternion.Slerp(_enemySpaceShip.rotation, delta, Time.deltaTime * _rotationDamp);
        }

        /// <summary>
        /// Determines how an enemy in the
        /// game should move.
        /// </summary>
        public void Move()
        {
            float distance = (_playerShip.position - _enemySpaceShip.position).magnitude;

            float damping = 1;

            if (distance <= 10) damping = distance*0.1f;

            var delta = _enemySpaceShip.forward * (Time.deltaTime * this.MaxSpeed)* damping;

            _enemySpaceShip.position += delta;
        }
    }
}
