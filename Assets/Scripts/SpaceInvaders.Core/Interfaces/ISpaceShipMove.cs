namespace Assets.Scripts.Interfaces
{
    /// <summary>
    ///     A contract for the movement of all space ships
    ///     in the 3D Space Invadors Game.
    /// </summary>
    public interface ISpaceShipMove
    {
        float MaxSpeed { get; set; }

        /// <summary>
        ///     Determines how a <see cref="ISpaceShip" />
        ///     moves forward.
        /// </summary>
        void Propulsion();

        /// <summary>
        ///     Determines how a <see cref="ISpaceShip" />
        ///     navigates and steers.
        /// </summary>
        void Steer();
    }
}