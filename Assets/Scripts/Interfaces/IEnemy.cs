using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    /// <summary>
    /// A contract which describes the behaviour of all
    /// <see cref="IEnemy"/>'s in this game.
    /// </summary>
    public interface IEnemy : IGameEntity
    {
        /// <summary>
        /// 
        /// </summary>
        void Follow();
    }
}
