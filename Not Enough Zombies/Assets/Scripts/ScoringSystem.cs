using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    
    public GameObject pointsText;
    [FormerlySerializedAs("Points")] public static int points;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.GetComponent<Text>().text = "POINTS: " + points;
    }
}
