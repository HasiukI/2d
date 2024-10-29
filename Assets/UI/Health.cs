using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UI
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private TMP_Text _healthText;

        [SerializeField] private Player.Player _player;


        private void Awake()
        {
            OnChangeHealth(_player.HealthPl);
        }

        private void OnEnable()
        {
            _player.OnChangeHealth += OnChangeHealth;
        }

        private void OnDisable()
        {
            _player.OnChangeHealth -= OnChangeHealth;
        }


        private void OnChangeHealth(int health)
        {
            _healthText.text = $"Scope: {health}";
        }
    }
}

