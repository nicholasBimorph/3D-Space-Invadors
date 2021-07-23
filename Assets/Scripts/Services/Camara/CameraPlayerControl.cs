using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Services
{
    public class CameraPlayerControl : MonoBehaviour
    {
        [SerializeField] private Transform _playerShipFighter; // TODO: set automatically 

        private  float CameraDistanceDamp = 0.08f;

        private readonly Vector3 _distance = new Vector3(0, 1.5f, -5f);

        private Vector3 _velocity = new Vector3(0,0,0);

        private Transform _camaraTransform;
        public void Start()
        {
            _camaraTransform = this.transform;
        }

        public void LateUpdate()
        {
            var targetPosition = _playerShipFighter.position + _playerShipFighter.rotation * _distance;

            var delta = Vector3.SmoothDamp(_camaraTransform.position, targetPosition, ref _velocity, CameraDistanceDamp);

            _camaraTransform.position = delta;

            _camaraTransform.LookAt(_playerShipFighter, _playerShipFighter.up);

        }
    }
}
