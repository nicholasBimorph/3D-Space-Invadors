using Assets.Scripts.Interfaces;
using Assets.Scripts.Weapons;
using UnityEngine;

namespace Assets.Scripts.PlayerShip
{
    /// <summary>
    ///     This <see cref="PlayerSpaceShipBehaviour" /> is what
    ///     will actually get attached to the <see cref="GameObject" />
    ///     int Unity.
    /// </summary>
    public class PlayerSpaceShipBehaviour : MonoBehaviour
    {
        [SerializeField] private int _initHealth;
        [SerializeField] private float _maxSpeed;
        [SerializeField] private int _maxSteerSpeed;

        private IPlayerSpaceShipMove _playerSpaceShipMove;
        private RocketLauncher _rocketLauncher;
        public ISpaceShip PlayerSpaceShip;

        public void Start()
        {
            _rocketLauncher = new RocketLauncher();

            //float horizontalAxis = Input.GetAxis("Horizontal");

            //float verticalAxis = Input.GetAxis("Vertical");

            _playerSpaceShipMove = new PlayerSpaceShipMove(this.transform, _maxSpeed, _maxSteerSpeed);

            PlayerSpaceShip = new PlayerSpaceShip(_initHealth, _rocketLauncher, _playerSpaceShipMove);
        }

        public void Update()
        {
            this.UpdateProperties();

            PlayerSpaceShip.Fly();

            //this.PlayerSpaceShip.Shoot();
        }

        /// <summary>
        ///     Updates any public properties which can be set
        ///     by a user in the UI.
        /// </summary>
        private void UpdateProperties()
        {
            _playerSpaceShipMove.MaxSpeed = _maxSpeed;

            _playerSpaceShipMove.MaxSteerSpeed = _maxSteerSpeed;

            _playerSpaceShipMove.HorizontalAxis = Input.GetAxis("Horizontal");

            _playerSpaceShipMove.VerticalAxis = Input.GetAxis("Vertical");
        }
    }
}