using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPooler pool;

    private void Start()
    {
        pool = FindObjectOfType<ObjectPooler>();
    }

    private void OnDisable()
    {
        if (pool != null)
        {
            pool.ReturnGameObject(this.gameObject);
        }
    }
}
