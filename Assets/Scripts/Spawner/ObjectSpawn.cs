using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectSpawn : MonoBehaviour
{
    protected virtual void OnSpawn()
    {
        print("Spawn");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.TryGetComponent(out ObjectSpawn enemy))
        {
            gameObject.SetActive(false);
        }
    }
}
