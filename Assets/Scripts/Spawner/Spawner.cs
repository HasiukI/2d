using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawner
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private List<ObjectSpawn> _template;
        [SerializeField] private int _spawnSize;
        [SerializeField] private int _spawnRange;
        [SerializeField] private float _spawnDelay;


        private List<ObjectSpawn> _spawnedObject = new List<ObjectSpawn> ();

        private void Awake()=> InititaliazeSpawner();

        private void Start() => StartCoroutine(ActiveSSelfChecker());


        private void InititaliazeSpawner()
        {
            for (var i = 0; i < _spawnSize; i++)
            {
                var newObject = Instantiate(_template[Random.Range(0,_template.Count)], RandomePosition(), Quaternion.identity);
                newObject.gameObject.SetActive(false);
                _spawnedObject.Add(newObject);
            }
        }

        private IEnumerator ActiveSSelfChecker()
        {
            while (true)
            {
                foreach (var spawned in _spawnedObject)
                {
                    if (!spawned.gameObject.activeInHierarchy)
                    {

                        yield return new WaitForSeconds(_spawnDelay);

                        spawned.gameObject.SetActive(true);
                        spawned.transform.position = RandomePosition();
                    }
                }
            }    
        }



        private Vector2 RandomePosition()
        {
            return new Vector2(transform.position.x, Random.Range(-_spawnRange, _spawnRange));
        }
    }
}

