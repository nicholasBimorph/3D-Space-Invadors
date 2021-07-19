using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    /// <summary>
    /// A contract for the movement of all space ships
    /// in the 3D Space Invadors Game.
    /// </summary>
    public interface ISpaceShipMove
    {
        /// <summary>
        /// Determines how a space ship moves.
        /// </summary>
        void Move();
    }
}
