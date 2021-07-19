using System;
using Assets.Scripts.Interfaces;
using UnityEngine;

/// <summary>
/// This <see cref="PlayerSpaceShipMove"/> depicts the behaviour movement of the
/// player space ship fighter.
/// </summary>
public class PlayerSpaceShipMove : ISpaceShipMove
{
    private float _maxSpeed;
    private readonly Transform _transform;

    /// <summary>
    /// The maximum speed this <see cref="PlayerSpaceShipMove"/> will move.
    /// values which are smaller than zero will be clamped to zero.
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
    /// Construct a new <see cref="PlayerSpaceShipMove"/>.
    /// </summary>
    /// <param name="transform"></param>
    /// <param name="maxSpeed"></param>
    internal PlayerSpaceShipMove(Transform transform, float maxSpeed)
    {
        _transform = transform;

        this.MaxSpeed = maxSpeed;
    }

    public void Move()
    {
        var delta = _transform.forward * (Time.deltaTime * this.MaxSpeed);

        _transform.position += delta;
    }
}