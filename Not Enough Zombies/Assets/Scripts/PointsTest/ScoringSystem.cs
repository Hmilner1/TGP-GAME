using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{

    //public GameObject pointsText;
    //public static int points;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pointsText.GetComponent<Text>().text = "POINTS: " + points;
        //GetPoints();
    }

    private void FixedUpdate()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null)
            return;
        
        if (keyboard.spaceKey.wasReleasedThisFrame)
        {
            PointsManager.Instance.AddPoint();
        }
    }

    void GetPoints()
    {
        /*if (Input.GetKeyUp(KeyCode.Space))
        {
            PointsManager.Instance.AddPoint();
        }*/

        /*if (Input.GetButtonDown("fire2"))
        {
            PointsManager.Instance.AddPoint();
        }*/

        if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            PointsManager.Instance.AddPoint();
        }
        
        
        
    }
}

