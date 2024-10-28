using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class ObjectMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;

    protected void Move()
    {
        _rigidbody2D.velocity = Vector2.left * (_speed * Time.fixedDeltaTime);
    }
}
