using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    /// <summary>
    /// A contract for all engine implementations.
    /// This <see cref="IEngine"/> computes the behaviour
    /// of a particular collection of entities.
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// Runs this <see cref="IEngine"/>.
        /// </summary>
        void Run();
    }
}
