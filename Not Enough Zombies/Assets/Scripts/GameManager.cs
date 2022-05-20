using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
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

    private void OnEnable()
    {
        PlayerHealth.PlayerDead += GameOver;
        LootDrops.DropSuccess += ItemRoll;
    }
    private void OnDisable()
    {
        PlayerHealth.PlayerDead -= GameOver;
        LootDrops.DropSuccess -= ItemRoll;
    }

    private void Start()
    {
        UnityEngine.Object[] subListObjects = Resources.LoadAll("Prefabs", typeof(GameObject));
        //This may be sloppy (I've only been programing for a short time) 
        //It works though :) 
        foreach (GameObject subListObject in subListObjects)
        {
            GameObject lo = (GameObject)subListObject;

            m_WeaponDrop.Add(lo);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
        Debug.Log("GameOver");
    }

    public void ItemRoll(Transform SpawnPosition)
    {
        foreach (var item in m_LootTable)
        {
            total += item;
        }
        RandomNumber = UnityEngine.Random.Range(0, total);

        for(int i =0; i < m_LootTable.Length; i++)
        {
            if (RandomNumber <= m_LootTable[i])
            {
                //award item
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
