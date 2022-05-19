// GENERATED AUTOMATICALLY FROM 'Assets/Player/Controls_Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls_Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls_Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls_Player"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""f720a55f-e1bb-41ae-8279-9964ed3a2941"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""350be4f4-317d-4633-a1b6-59bdb1bce945"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""35e68889-a229-4480-974e-5dcdea8c5c76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""24c3feb4-21a1-4276-9552-caf7f03710cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2c108442-20fc-4a90-befc-ee7ae7995ecb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2899c833-ce0c-429a-bcae-604a6932bdc7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""6a4789f4-c830-4511-8faf-d6ff29e4100b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""08af9d16-2bb7-4649-8f1a-25be48e01ab1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""98e65c05-babf-4db7-8d07-761729dfecf5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a2a9447a-869b-45ee-a051-42a204841efa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ADS"",
                    ""type"": ""Button"",
                    ""id"": ""e2313c19-71fe-4791-a192-c86d9bcec08b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ADSStop"",
                    ""type"": ""Button"",
                    ""id"": ""621585f6-a494-4ee8-bb2b-144b45ae9f83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5c434225-1502-4bf8-95b2-5277737a37c3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""446900d3-6154-4f99-95b2-503a96eb7a16"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""906990c9-19a4-4caf-a0e8-16b542ff24db"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46809d4a-662e-4c91-b407-bf1aa3905e84"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Move"",
                    ""id"": ""c717b5d0-a172-4f63-b35b-c0d246927490"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""24ecfac5-f24a-4d26-a578-ed5081b9f0f3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ecd5c95a-af26-4e30-96a0-7892b38318a3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9eae7879-0ae7-4121-81b8-9f35ec38ea11"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6ecf5f3c-7215-4647-97a6-4739e4ecb920"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c05d0d5d-3d7d-480f-a0c7-f858c608fe34"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34478077-9dcc-49ec-a1a2-c6dd08ff6d98"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa5147e6-2c28-4656-a262-bde5e9349c1a"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be141cc6-a151-4e0c-a1e3-8aeb443c5eac"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8d386a8-6152-41c6-a535-2e473827f042"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ADS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c47efb8e-82ea-443c-99fb-7aee7ab2b962"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ADSStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_HorizontalMovement = m_PlayerMovement.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_PlayerMovement_Jump = m_PlayerMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovement_Run = m_PlayerMovement.FindAction("Run", throwIfNotFound: true);
        m_PlayerMovement_MouseX = m_PlayerMovement.FindAction("MouseX", throwIfNotFound: true);
        m_PlayerMovement_MouseY = m_PlayerMovement.FindAction("MouseY", throwIfNotFound: true);
        m_PlayerMovement_Shoot = m_PlayerMovement.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerMovement_Interact = m_PlayerMovement.FindAction("Interact", throwIfNotFound: true);
        m_PlayerMovement_Reload = m_PlayerMovement.FindAction("Reload", throwIfNotFound: true);
        m_PlayerMovement_Pause = m_PlayerMovement.FindAction("Pause", throwIfNotFound: true);
        m_PlayerMovement_ADS = m_PlayerMovement.FindAction("ADS", throwIfNotFound: true);
        m_PlayerMovement_ADSStop = m_PlayerMovement.FindAction("ADSStop", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_HorizontalMovement;
    private readonly InputAction m_PlayerMovement_Jump;
    private readonly InputAction m_PlayerMovement_Run;
    private readonly InputAction m_PlayerMovement_MouseX;
    private readonly InputAction m_PlayerMovement_MouseY;
    private readonly InputAction m_PlayerMovement_Shoot;
    private readonly InputAction m_PlayerMovement_Interact;
    private readonly InputAction m_PlayerMovement_Reload;
    private readonly InputAction m_PlayerMovement_Pause;
    private readonly InputAction m_PlayerMovement_ADS;
    private readonly InputAction m_PlayerMovement_ADSStop;
    public struct PlayerMovementActions
    {
        private @Controls_Player m_Wrapper;
        public PlayerMovementActions(@Controls_Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_PlayerMovement_HorizontalMovement;
        public InputAction @Jump => m_Wrapper.m_PlayerMovement_Jump;
        public InputAction @Run => m_Wrapper.m_PlayerMovement_Run;
        public InputAction @MouseX => m_Wrapper.m_PlayerMovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_PlayerMovement_MouseY;
        public InputAction @Shoot => m_Wrapper.m_PlayerMovement_Shoot;
        public InputAction @Interact => m_Wrapper.m_PlayerMovement_Interact;
        public InputAction @Reload => m_Wrapper.m_PlayerMovement_Reload;
        public InputAction @Pause => m_Wrapper.m_PlayerMovement_Pause;
        public InputAction @ADS => m_Wrapper.m_PlayerMovement_ADS;
        public InputAction @ADSStop => m_Wrapper.m_PlayerMovement_ADSStop;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnHorizontalMovement;
                @Jump.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnRun;
                @MouseX.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMouseY;
                @Shoot.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnShoot;
                @Interact.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnInteract;
                @Reload.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnReload;
                @Pause.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPause;
                @ADS.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnADS;
                @ADS.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnADS;
                @ADS.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnADS;
                @ADSStop.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnADSStop;
                @ADSStop.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnADSStop;
                @ADSStop.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnADSStop;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @ADS.started += instance.OnADS;
                @ADS.performed += instance.OnADS;
                @ADS.canceled += instance.OnADS;
                @ADSStop.started += instance.OnADSStop;
                @ADSStop.performed += instance.OnADSStop;
                @ADSStop.canceled += instance.OnADSStop;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);
    public interface IPlayerMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnADS(InputAction.CallbackContext context);
        void OnADSStop(InputAction.CallbackContext context);
    }
}
