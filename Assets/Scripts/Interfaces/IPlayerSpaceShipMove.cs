namespace Assets.Scripts.Interfaces
{
    /// <summary>
    ///     A contract which determines the movement
    ///     specifically for any player space ship.
    /// </summary>
    public interface IPlayerSpaceShipMove : ISpaceShipMove
    {
        /// <summary>
        ///     Determines the maximum speed this  <see cref="IPlayerSpaceShipMove" />
        ///     can steer.
        /// </summary>
        float MaxSteerSpeed { get; set; }

        /// <summary>
        /// </summary>
        float HorizontalAxis { get; set; }

        /// <summary>
        /// </summary>
        float VerticalAxis { get; set; }
    }
}