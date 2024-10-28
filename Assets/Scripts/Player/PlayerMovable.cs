using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMover : MonoBehaviour
    {
        [Header("General")]
        [SerializeField] private Rigidbody2D _rigidbody2D;


        [Header("Movement")]
        [SerializeField] private float _speed;
        [SerializeField] private Vector2Int _minMaxDistance;

        private void FixedUpdate()
        {
            if(transform.position.y >= _minMaxDistance.x && transform.position.y <= _minMaxDistance.y)
            {
                var verticalInput = Input.GetAxis("Vertical");

                var movementVector = new Vector2(0f, verticalInput * _speed);

                _rigidbody2D.MovePosition(_rigidbody2D.position + movementVector * Time.fixedDeltaTime);
            }

           
        }
    }
}

