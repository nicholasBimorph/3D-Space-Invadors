using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Behaviours;
using Assets.Scripts.Data;
using Assets.Scripts.Interfaces;
using UnityEngine;


namespace Assets.Scripts.Populations
{
    /// <summary>
    /// This <see cref="MeteoritePopulation"/> stores all the
    /// <see cref="Meteorite"/>'s in the game.
    /// </summary>
    public class MeteoritePopulation : MonoBehaviour, IEnumerable<IMeteorite>
    {
        [SerializeField] private int _number;
        [SerializeField] private int _worldSize;

        private float _size;
        private IList<IMeteorite> _meteorites;

        public GameObject Prefab;


        public void Start()
        {
            _meteorites = new List<IMeteorite>();

            _size = Mathf.Ceil(Mathf.Pow(_number, 1.0f / 3.0f));

            this.Create();
        }

        /// <summary>
        /// Instantiates all <see cref="Meteorite"/>'s in the game.
        /// </summary>
        private void Create()
        {

            for (int i = 0; i < _number; i++)
            {
               var position = UnityEngine.Random.insideUnitSphere * _worldSize;

               var meteorite = Instantiate(Prefab.GetComponent<Meteorite>(), position, Quaternion.identity);

               meteorite.Exploded += this.Meteorite_Exploded;

              _meteorites.Add(meteorite);
            }
            
        }

        /// <summary>
        /// An event handler for all <see cref="Meteorite"/> explosions.
        /// </summary>
        private void Meteorite_Exploded(object sender, ExplosionData explosionData)
        {
            var f = (MonoBehaviour) sender;

            var explosion = Instantiate(explosionData.ExplosionPrefab, explosionData.HitPoint, Quaternion.identity);

            Destroy(explosion, 3f);

            Destroy(f.gameObject, 3f);

        }


        public IEnumerator<IMeteorite> GetEnumerator()
        {
            return _meteorites.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
