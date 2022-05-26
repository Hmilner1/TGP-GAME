using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class TestControlPoints : MonoBehaviour, TestControls.IPlayerMovementActions
{
    private TestControls _input;

    private void Awake()
    {
        _input = new TestControls();
        _input.PlayerMovement.SetCallbacks(this);
        
        _input.PlayerMovement.Enable();
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

    public void OnTakeDamage(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("A Key Pressed");
            //TakeDamage(Random.Range(5,10));
            //PlayerHealthTest.Instance.TakeDamage(Random.Range(5,10));
            PlayerHealthTest.Instance.TakeDamage(10);
        }
    }

    public void OnHealDamage(InputAction.CallbackContext context)
    {
        Debug.Log("D Key Pressed");
    }
}
