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
    private readonly float _horizontalAxis;
    private readonly float _verticalAxis;
    private readonly float _pitch;
    private readonly float _roll;

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
    ///     Construct a new <see cref="PlayerSpaceShipMove" />.
    /// </summary>
    /// <param name="transform"></param>
    /// <param name="maxSpeed"></param>
    public PlayerSpaceShipMove(Transform transform, float maxSpeed, float maxSteerSpeed)
    {
        _horizontalAxis = Input.GetAxis("Horizontal");

        _verticalAxis = Input.GetAxis("Vertical");

        _pitch = Input.GetAxis("PlayerShipPitch");

        _roll = Input.GetAxis("PlayerShipRoll");

        _transform = transform;

        this.MaxSpeed = maxSpeed;

        this.MaxSteerSpeed = maxSteerSpeed; // TODO: I think this should be a public game setting.
    }


    /// <summary>
    ///     Determines how a <see cref="ISpaceShip" />
    ///     moves forward.
    /// </summary>
    public void Propulsion()
    {
        var delta = _transform.forward * (Time.deltaTime * this.MaxSpeed * _verticalAxis);

        _transform.position += delta;
    }

    /// <summary>
    ///     Determines how a <see cref="ISpaceShip" />
    ///     navigates and steers.
    /// </summary>
    public void Steer()
    {
        float yaw = Time.deltaTime * _horizontalAxis * this.MaxSteerSpeed;

        float pitch = Time.deltaTime * _pitch * this.MaxSteerSpeed;

        float roll = Time.deltaTime * _roll * this.MaxSteerSpeed;

        _transform.Rotate(pitch, yaw, roll);

        //float rotX = Input.GetAxis("Mouse X") * 500f * Time.deltaTime;

        //float rotY = Input.GetAxis("Mouse Y") * 100f * Time.deltaTime;

        //_transform.Rotate(_transform.up* rotX);
    }
}