using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using UnityEngine.Events;


namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _health;

        public int HealthPl{ get => _health; }

        public event UnityAction OnCoinPickUp;
        public event UnityAction<int> OnChangeHealth;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.TryGetComponent(out Enemy.Enemy enemy))
            {
                if (_health <= 0)
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    _health -= 10;
                    OnChangeHealth!.Invoke(_health);
                }


            }
            else if(collision.gameObject.TryGetComponent(out Coin coin))
            {
                OnCoinPickUp!.Invoke();
            }
        }
    }
}


