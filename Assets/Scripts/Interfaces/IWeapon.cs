namespace Assets.Scripts.Interfaces
{
    /// <summary>
    ///     A contract for all concrete weapon implementations
    /// </summary>
    public interface IWeapon
    {
        /// <summary>
        ///     The amount of damage this <see cref="IWeapon" />
        ///     does in a single shot.
        /// </summary>
        int Damage { get; }

        void Shoot();
    }
}