using Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace UI
{
    public class Scope : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;

        [SerializeField] private Player.Player _player;

        private int _scope;

        private void OnEnable()
        {
            _player.OnCoinPickUp += OnCoinPickUp;
        }

        private void OnDisable()
        {
            _player.OnCoinPickUp -= OnCoinPickUp;
        }


        private void OnCoinPickUp()
        {
            _scope++;
            _scoreText.text = $"Scope: {_scope}";
        }
    }

}
