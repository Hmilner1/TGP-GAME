using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootDrops : MonoBehaviour
{
    public Transform m_ZombiePosition;

    private void OnEnable()
    {
        TheHealth.StartDrop += DropItem;
    }

    private void OnDisable()
    {
        TheHealth.StartDrop -= DropItem;
    }

    public static event Action<Transform> DropSuccess;

    private void DropItem()
    {
        int DropChance = UnityEngine.Random.Range(0, 5);
        if (DropChance < 2)
        {
            DropSuccess?.Invoke(m_ZombiePosition);
        }
    }
}
