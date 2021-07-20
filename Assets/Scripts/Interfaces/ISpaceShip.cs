namespace Assets.Scripts.Interfaces
{
    public interface ISpaceShip
    {
        /// <summary>
        /// The maximum speed this <see cref="ISpaceShip"/>
        /// can fly.
        /// </summary>
        //  float MaxSpeed { get; set; }

        /// <summary>
        ///     The health of this <see cref="ISpaceShip" />.
        /// </summary>
        int Health { get; set; }

        // TODO: Add a collection of IWeapons.

        /// <summary>
        ///     The <see cref="IWeapon" /> this <see cref="ISpaceShip" />
        ///     uses.
        /// </summary>
        IWeapon Weapon { get; set; }

        /// <summary>
        ///     Determines the behavior how this <see cref="ISpaceShip" />
        ///     flies.
        /// </summary>
        void Fly();

        /// <summary>
        ///     Determines the behaviour of how this <see cref="ISpaceShip" />
        ///     should shoot.
        /// </summary>
        void Shoot();
    }
}