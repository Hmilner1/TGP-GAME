using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FloatingText : MonoBehaviour
{

    [FormerlySerializedAs("Destroytime")] public float destroytime = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroytime);
    }

}
