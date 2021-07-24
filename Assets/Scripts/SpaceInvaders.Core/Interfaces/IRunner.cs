using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Interfaces
{
    /// <summary>
    /// A contract for all engine implementations.
    /// This <see cref="IRunner"/> computes the behaviour
    /// of a particular collection of entities.
    /// </summary>
    public interface IRunner
    {
        /// <summary>
        /// Runs this <see cref="IRunner"/>.
        /// </summary>
        void Run();
    }
}
