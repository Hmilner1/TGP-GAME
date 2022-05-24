using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PointsManager : MonoBehaviour
{
    public enum TypesOfMobs
    {
        GeneralZombie,
        Zombie,
        BigZombie,
        SmallZombie
    }

    public static PointsManager Instance;

    public GameObject FloatingTextPrefab;
    public Text pointsText;

    public Transform parentText;
    //public TextMeshPro pointsTextMeshPro;

    private int _points = 0;
    private int _pointsToAdd = 0;

    [FormerlySerializedAs("pointspos")] public Vector3 pointsPosition = new Vector3(50, 50, 0);
    
    private void Awake()
    {
        Instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = "SCORE: " + _points.ToString();
    }

    public void AddPoint()
    {
        _pointsToAdd = Random.Range(1, 20);
        _points += _pointsToAdd;

        if (FloatingTextPrefab)
        {
            ShowFloatingText();
        }

        //_points += 1;
        pointsText.text = "SCORE: " + _points.ToString();
    }

    private void ShowFloatingText()
    {
        //Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity);
        //Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
        Vector3 offset = parentText.position + pointsPosition;
        var go = Instantiate(FloatingTextPrefab, offset, Quaternion.identity, transform);
        go.GetComponent<Text>().text = "+" + _pointsToAdd.ToString();
    }

    public void SetPoint(TypesOfMobs typesOfMobs)
    {
        switch (typesOfMobs)
        {
            case TypesOfMobs.GeneralZombie:
            {
                _points += 10;
                pointsText.text = "SCORE: " + _points.ToString();
            }
                break;
            case TypesOfMobs.Zombie:
            {
                _points += 20;
                pointsText.text = "SCORE: " + _points.ToString();
            }
                break;
            case TypesOfMobs.BigZombie:
            {
                _points += 50;
                pointsText.text = "SCORE: " + _points.ToString();
            }
                break;
            case TypesOfMobs.SmallZombie:
            {
                _points += 15;
                pointsText.text = "SCORE: " + _points.ToString();
            }
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}

