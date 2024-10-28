using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawner
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _template;
        [SerializeField] private int _spawnSize;
        [SerializeField] private int _spawnRange;


        private List<GameObject> _spawnedObject = new List<GameObject> ();

        private void Start()
        {
            for(var i=0; i<_spawnSize; i++)
            {
                var newObject = Instantiate(_template, RandomePosition(), Quaternion.identity);

                _spawnedObject.Add( newObject );
            }
        }

        private void Update()
        {
            foreach(var spawned in _spawnedObject)
            {
                if (!spawned.activeInHierarchy)
                {
                    spawned.SetActive(true);
                    spawned.transform.position = RandomePosition();
                }
            }
        }

        private Vector2 RandomePosition()
        {
            return new Vector2(transform.position.x, Random.Range(-_spawnRange, _spawnRange));
        }
    }
}

