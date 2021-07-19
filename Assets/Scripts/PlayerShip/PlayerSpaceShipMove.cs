using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Interfaces;
using UnityEngine;

public class PlayerSpaceShipMove : IMove
{
    private readonly Transform _transform;

    public double MaxSpeed { get; set; }

    internal PlayerSpaceShipMove(Transform transform, double maxSpeed)
    {
        _transform = transform;

        this.MaxSpeed = maxSpeed;
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }
}
