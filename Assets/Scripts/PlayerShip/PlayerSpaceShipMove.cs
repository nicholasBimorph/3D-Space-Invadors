using Assets.Scripts.Interfaces;
using UnityEngine;

/// <summary>
///     This <see cref="PlayerSpaceShipMove" /> depicts the behaviour movement of the
///     player space ship fighter.
/// </summary>
public class PlayerSpaceShipMove : IPlayerSpaceShipMove
{
    private readonly Transform _transform;
    private float _maxSpeed;
    private float _maxSteerSpeed;

    /// <summary>
    ///     Construct a new <see cref="PlayerSpaceShipMove" />.
    /// </summary>
    /// <param name="transform"></param>
    /// <param name="maxSpeed"></param>
    public PlayerSpaceShipMove(Transform transform, float maxSpeed, float maxSteerSpeed)
    {
        _transform = transform;

        this.MaxSpeed = maxSpeed;

        this.MaxSteerSpeed = maxSteerSpeed; // TODO: I think this should be a public game setting.
    }

    /// <summary>
    ///     Determines the maximum speed this  <see cref="IPlayerSpaceShipMove" />
    ///     can steer.
    ///     values which are smaller than zero will be clamped to zero.
    /// </summary>
    public float MaxSteerSpeed
    {
        get => _maxSteerSpeed;

        set
        {
            if (value < 0)
                _maxSteerSpeed = 0;

            _maxSteerSpeed = value;
        }
    }

    public float HorizontalAxis { get; set; }

    /// <summary>
    /// </summary>
    public float VerticalAxis { get; set; }

    /// <summary>
    ///     The maximum speed this <see cref="PlayerSpaceShipMove" /> will move.
    ///     values which are smaller than zero will be clamped to zero.
    /// </summary>
    public float MaxSpeed
    {
        get => _maxSpeed;

        set
        {
            if (value < 0)
                _maxSpeed = 0;

            _maxSpeed = value;
        }
    }

    /// <summary>
    ///     Determines how a <see cref="ISpaceShip" />
    ///     moves forward.
    /// </summary>
    public void Propulsion()
    {
        var delta = _transform.forward * (Time.deltaTime * this.MaxSpeed * this.VerticalAxis);

        _transform.position += delta;
    }

    /// <summary>
    ///     Determines how a <see cref="ISpaceShip" />
    ///     navigates and steers.
    /// </summary>
    public void Steer()
    {
        float yaw = Time.deltaTime * this.HorizontalAxis * this.MaxSteerSpeed;

        float pitch = 0;

        float roll = 0;

        _transform.Rotate(pitch, yaw, roll);
    }
}