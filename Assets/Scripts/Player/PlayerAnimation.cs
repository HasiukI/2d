using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private readonly int _run = Animator.StringToHash("Run");

    private void Update()
    {
        var verticalInput = Input.GetAxis("Vertical");

        if( verticalInput >0 || verticalInput < 0)
        {
            _animator.SetBool(_run, true);
        }
        else
        {
            _animator.SetBool(_run, false);
        }
    }
}
