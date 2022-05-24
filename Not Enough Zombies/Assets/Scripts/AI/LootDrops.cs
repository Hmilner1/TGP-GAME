using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootDrops : MonoBehaviour
{
    public List<GameObject> m_WeaponDrop = new List<GameObject>();

    public int[] m_LootTable =
    {
        50,
        30,
        15,
        5
    };

    public int total;

    public int RandomNumber;

    private void Start()
    {
        foreach (var item in m_LootTable)
        {
            total += item;
        }
        
        RandomNumber = UnityEngine.Random.Range(0, total);
    }

    public void DropItem(Transform SpawnPosition)
    { 
        for (int i = 0; i < m_LootTable.Length; i++)
        {
            if (RandomNumber <= m_LootTable[i])
            {
                GameObject WeaponDrop = Instantiate(m_WeaponDrop[i]) as GameObject;
                WeaponDrop.transform.position = SpawnPosition.position;
                return;
            }
            else
            {
                RandomNumber -= m_LootTable[i];
            }
        }
    }
}
