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
    private void OnEnable() => TheHealth.AddPoints += AddPoint;
    private void OnDisable() => TheHealth.AddPoints -= AddPoint;

    public enum TypesOfPoints
    {
        OnHitZombie,
        OnDeathNormalZombie,
        OnDeathBigZombie,
        OnDeathSmallZombie
    }

    public static PointsManager Instance;

    public GameObject FloatingTextPrefab;
    public GameObject OnHitFTP;
    public GameObject OnDeathFTP;
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
        //Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
        Vector3 offset = parentText.position + pointsPosition;
        var go = Instantiate(FloatingTextPrefab, offset, Quaternion.identity, transform);
        go.GetComponent<Text>().text = "+" + _pointsToAdd.ToString();
    }
    private void ShowFloatingTexts(GameObject FloatTextPrefab)
    {
        //Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
        Vector3 offset = parentText.position + pointsPosition;
        var GO = Instantiate(FloatTextPrefab, offset, Quaternion.identity, transform);
        GO.GetComponent<Text>().text = "+" + _pointsToAdd.ToString();
    }

    public void SetPoint(TypesOfPoints typesOfPoints)
    {
        switch (typesOfPoints)
        {
            case TypesOfPoints.OnHitZombie:
            {
                _pointsToAdd = 10;
                _points += _pointsToAdd;
                if (OnHitFTP)
                {
                    ShowFloatingTexts(OnHitFTP);
                }
                pointsText.text = "SCORE: " + _points.ToString();
            }
                break;
            case TypesOfPoints.OnDeathNormalZombie:
            {
                _pointsToAdd = 20;
                _points += _pointsToAdd;
                if (OnDeathFTP)
                {
                    ShowFloatingTexts(OnDeathFTP);
                }
                pointsText.text = "SCORE: " + _points.ToString();
            }
                break;
            case TypesOfPoints.OnDeathBigZombie:
            {
                _pointsToAdd = 50;
                _points += _pointsToAdd;
                if (FloatingTextPrefab)
                {
                    ShowFloatingText();
                }
                pointsText.text = "SCORE: " + _points.ToString();
            }
                break;
            case TypesOfPoints.OnDeathSmallZombie:
            {
                _pointsToAdd = 15;
                _points += _pointsToAdd;
                if (FloatingTextPrefab)
                {
                    ShowFloatingText();
                }
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

