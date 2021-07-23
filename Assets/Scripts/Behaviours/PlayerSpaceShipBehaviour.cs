using Assets.Scripts.Interfaces;
using Assets.Scripts.PlayerShip;
using Assets.Scripts.Weapons;
using UnityEngine;

namespace Assets.Scripts.Behaviours
{
    /// <summary>
    ///     This <see cref="PlayerSpaceShipBehaviour" /> is what
    ///     will actually get attached to the <see cref="GameObject" />
    ///     int Unity.
    /// </summary>
    [RequireComponent(typeof(RocketLauncherLaserBehaviour))]
    public class PlayerSpaceShipBehaviour : MonoBehaviour
    {
        [SerializeField] private int _initHealth;
        [SerializeField] private float _maxSpeed;
        [SerializeField] private int _maxSteerSpeed;

        [SerializeField] private GameObject _rocketLauncherLaserPrefab;

        private Transform _transform;

        private IPlayerSpaceShipMove _playerSpaceShipMove;
    
        public ISpaceShip PlayerSpaceShip;


        public void Start()
        {
            _transform = this.transform;

          var rocketLauncherLaserBehaviour = _rocketLauncherLaserPrefab.GetComponent<RocketLauncherLaserBehaviour>();

          var rocketLauncherLaser  = rocketLauncherLaserBehaviour.RocketLauncherLaser;

          var rocketLauncher = new RocketLauncher(rocketLauncherLaser, _transform);

          _playerSpaceShipMove = new PlayerSpaceShipMove(_transform, _maxSpeed, _maxSteerSpeed);

          PlayerSpaceShip = new PlayerSpaceShip(_initHealth, rocketLauncher, _playerSpaceShipMove);

        }


        public void FixedUpdate()
        {
            this.PlayerSpaceShip.Shoot();
        }

        public void Update()
        {
            this.UpdateProperties();

            this.PlayerSpaceShip.Fly();
            
            //this.PlayerSpaceShip.Shoot();
        }

        /// <summary>
        ///     Updates any public properties which a user
        ///     can change in the UI.
        /// </summary>
        private void UpdateProperties()
        {
           
            _playerSpaceShipMove.MaxSpeed = _maxSpeed;

            _playerSpaceShipMove.MaxSteerSpeed = _maxSteerSpeed;

        }
    }
}