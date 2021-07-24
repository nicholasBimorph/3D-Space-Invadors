using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Behaviours;
using Assets.Scripts.Data;

namespace Assets.Scripts.Interfaces
{
    /// <summary>
    /// A contract for all <see cref="IMeteorite"/>
    /// implementations in the 3D space invaders game.
    /// </summary>
    public interface IMeteorite: IGameEntity
    {
        /// <summary>
        /// Occurs when this <see cref="Meteorite"/>'s
        /// health reaches zero;
        /// </summary>
        event EventHandler<ExplosionData> Exploded;

        /// <summary>
        /// The amount of damage this <see cref="Meteorite"/>
        /// does when the player crashes in to it.
        /// This value should change as levels increase.
        /// </summary>
        int Damage { get; set; }


        /// <summary>
        /// Computes the desired behaviour for this <see cref="IGameEntity"/>
        /// </summary>
        void ComputeBehaviour();

    }
}
