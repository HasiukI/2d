using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
           if(!collision.gameObject.TryGetComponent(out Enemy enemy))
            {
                gameObject.SetActive(false);
            }
        }
    }
}

