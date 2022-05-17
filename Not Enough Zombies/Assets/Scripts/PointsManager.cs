using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public enum TypesOfMobs
    {
        GeneralZombie,
        Zombie,
        BigZombie,
        SmolZombie
    }

    public static PointsManager Instance;

    //private TypesOfMobs _mobTypes;

    [FormerlySerializedAs("PointsText")] public Text pointsText;
    //public TextMeshPro pointsTextMeshPro;

    private int _points = 0;

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
        _points += 1;
        pointsText.text = "SCORE: " + _points.ToString();
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
            case TypesOfMobs.SmolZombie:
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
