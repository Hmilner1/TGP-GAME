using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Movement m_MovementScript;
    [SerializeField]
    private ADSScript m_ADSScript;
    [SerializeField]
    private Weapon m_ShootScript;
    [SerializeField]
    private CameraController m_CameraController;
    Controls_Player m_Controls;
    Controls_Player.PlayerMovementActions m_Movement;
    private bool m_Paused = false;

    Vector2 m_HorizontalMovement;
    Vector2 m_MouseInput;

    Coroutine m_Fire;

    public static event Action OnPause;

    private void Awake()
    {
        m_Paused = false;
        m_Controls = new Controls_Player();
        m_Movement = m_Controls.PlayerMovement;

        m_Movement.HorizontalMovement.performed += ctx => m_HorizontalMovement = ctx.ReadValue<Vector2>();
        m_Movement.Jump.performed += _ => m_MovementScript.OnJump();
        m_Movement.Run.performed += _ => m_MovementScript.OnSprint();
        m_Movement.Run.canceled += _ => m_MovementScript.OnWalk();
        m_Movement.Shoot.started += _ => StartFire();
        m_Movement.Shoot.canceled += _ => StopFire();
        m_Movement.Interact.started += _ => Interact();
        m_Movement.Reload.started += _ => Reload();
        m_Movement.Pause.started += _ => Pause();
        m_Movement.ADS.performed += _ => ADS();
        m_Movement.ADSStop.performed += _ => StopADS();

        m_Movement.MouseX.performed += ctx => m_MouseInput.x = ctx.ReadValue<float>();
        m_Movement.MouseY.performed += ctx => m_MouseInput.y = ctx.ReadValue<float>();

    }

    private void Update()
    {
        if (m_Paused == false)
        {
            m_MovementScript.Input(m_HorizontalMovement);
            m_CameraController.MouseInput(m_MouseInput);
        }
    }

    private void OnEnable()
    {
        m_Controls.Enable();
    }

    private void OnDisable()
    {
        m_Controls.Disable();
    }

    private void StartFire()
    {
        m_Fire = StartCoroutine(m_ShootScript.RapitShoot());
    }

    private void Interact()
    {
        m_ShootScript.Interact();
    }

    private void Reload()
    {
        m_ShootScript.Reload();
        
    }

    private void ADS()
    {
        m_ADSScript.isAiming = true;
    }

    private void StopADS()
    {
        m_ADSScript.isAiming = false;
    }

    private void StopFire()
    {
        if (m_Fire != null)
        {
            StopCoroutine(m_Fire);
        }
    }

    private void Pause()
    {
        OnPause?.Invoke();
        if (m_Paused == true)
        {
            m_Paused = false;
        }
        else if (m_Paused == false)
        {
            m_Paused = true;
        }
    }
}
