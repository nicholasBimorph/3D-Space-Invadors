using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Data;
//using Assets.Scripts.Environment;
using Assets.Scripts.Interfaces;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts.Behaviours
{
    
    public class Meteorite : MonoBehaviour , IMeteorite
    {

        private float _rotX, _rotY;

        private Transform _transform;

        [SerializeField] private GameObject _explosionPrefab;

        /// <summary>
        /// Occurs when this <see cref="Meteorite"/>'s
        /// health reaches zero;
        /// </summary>
        public event EventHandler<ExplosionData> Exploded;


        /// <summary>
        /// The amount of damage this <see cref="Meteorite"/>
        /// does when the player crashes in to it.
        /// This value should change as levels increase.
        /// </summary>
        public int Damage { get; set; }


        /// <summary>
        /// The total health this <see cref="IGameEntity"/>
        /// has.
        /// </summary>
        public int Health { get; set; }


        // public Meteorite Meteorite { get; private set; }


        public void Start()
        {
            _transform = this.transform;

            _explosionPrefab.SetActive(false);

            this.Damage = 10;

            var random = new Random();

             _rotX = random.Next(3, 15);

            _rotY = random.Next(5, 20);

            int scaleX = random.Next(4, 8);

            int scaleY = random.Next(4, 8);

            int scaleZ = random.Next(4, 8);

            this.Health = (scaleX * scaleY * scaleZ);

            _transform.localScale = new Vector3(scaleX, scaleY, scaleZ);

        }

        private void Rotation()
        {
            _transform.Rotate(_rotX * Time.deltaTime, _rotY * Time.deltaTime, 0);
        }

        private void OnExplosion(object sender, ExplosionData explosionData)
        {
            _explosionPrefab.SetActive(true);

            var handler = this.Exploded;

            handler?.Invoke(sender, explosionData);
        }

        /// <summary>
        /// Computes the desired behaviour for this <see cref="Meteorite"/>
        /// </summary>
        public void ComputeBehaviour()
        {
            if (_transform == null) return;


            if (this.Health <= 0)
            {
                _transform.gameObject.GetComponent<Renderer>().material.color = Color.red;

                var explosionData = new ExplosionData(_explosionPrefab, _transform.transform.position);

                this.OnExplosion(this, explosionData);


                return;

            }

            this.Rotation();
        }


    }
}
