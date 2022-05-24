using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestControlPoints : MonoBehaviour, TestControls.IPlayerMovementActions
{
    private TestControls input;

    private void Awake()
    {
        input = new TestControls();
        input.PlayerMovement.SetCallbacks(this);
        
        input.PlayerMovement.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("Space Key Pressed");
            PointsManager.Instance.SetPoint(PointsManager.TypesOfPoints.OnHitZombie);
        }
    }
}
