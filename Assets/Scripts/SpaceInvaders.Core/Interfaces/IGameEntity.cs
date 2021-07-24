using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    /// <summary>
    /// A contract for the most simplest of objects
    /// for the 3D space invaders game.
    /// </summary>
    public interface IGameEntity
    {
        /// <summary>
        /// The total health this <see cref="IGameEntity"/>
        /// has.
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// Computes the desired behaviour for this <see cref="IGameEntity"/>
        /// </summary>
        //void ComputeBehaviour();
    }
}
