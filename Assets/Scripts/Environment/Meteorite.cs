//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Assets.Scripts.Data;
//using UnityEngine;
//using UnityEngine.Analytics;
//using Random = System.Random;

//namespace Assets.Scripts.Environment
//{
    
//    public class Meteorite
//    {
//        private readonly float _rotX, _rotY;
//        private readonly Transform _prefab;
//        private readonly GameObject _explosionPrefab;

//        /// <summary>
//        /// Occurs when this <see cref="Meteorite"/>'s
//        /// health reaches zero;
//        /// </summary>
//        public event EventHandler<ExplosionData> Exploded;

//        /// <summary>
//        /// The amount of damage this <see cref="Meteorite"/>
//        /// does when the player crashes in to it.
//        /// This value should change as levels increase.
//        /// </summary>
//        public int Damage { get; set; }

//        /// <summary>
//        /// The total health this <see cref="Meteorite"/>
//        /// has.
//        /// </summary>
//        public int Health { get; set; }

//        /// <summary>
//        /// Construct a new <see cref="Meteorite"/>.
//        /// </summary>
//        /// <param name="prefab"></param>
//        public Meteorite(Transform prefab, int damage, GameObject explosionPrefab)
//        {
//            _explosionPrefab = explosionPrefab;

//            _explosionPrefab.SetActive(false);

//            this.Damage = damage;

//            var random = new Random();

//            _prefab = prefab;

//            _rotX = random.Next(3, 15);

//            _rotY = random.Next(5, 20);

//            int scaleX = random.Next(4, 8);

//            int scaleY = random.Next(4, 8);

//            int scaleZ = random.Next(4, 8);

//            this.Health = (scaleX * scaleY * scaleZ);

//            _prefab.localScale = new Vector3(scaleX, scaleY, scaleZ);
//        }

//        private void Rotation()
//        {
//            _prefab.Rotate(_rotX * Time.deltaTime, _rotY * Time.deltaTime, 0);
//        }

//        private void OnExplosion(object sender, ExplosionData explosionData)
//        {
//            _explosionPrefab.SetActive(true);


//            var handler = this.Exploded;

//            handler?.Invoke(this,explosionData);
//        }

//        /// <summary>
//        /// Updates this <see cref="Meteorite"/> with a
//        /// specified behaviour.
//        /// </summary>
//        public void Update()
//        {
//            if (_prefab == null) return;


//            if (this.Health <= 0)
//            {
//                this._prefab.gameObject.GetComponent<Renderer>().material.color = Color.red;

//                var explosionData = new ExplosionData(_explosionPrefab, _prefab.transform.position);

//               this.OnExplosion(this, explosionData);

//               return;

//            }

//            this.Rotation();
//        }
//    }
//}
