// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Locomotion"",
            ""id"": ""05b57f3b-7087-4062-9c8c-63f7e3eb2b62"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0e551135-ec24-495b-86b3-9b2cd9364190"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ad25b8de-ae09-4da4-a958-67cc7f224225"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""bc1b72d7-91e1-4b90-95aa-3b54d1b4b0e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""dacc8003-20bb-4775-a8b9-d9503db7750f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ec549b24-5162-4b01-9020-d4d833e0f815"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""55a26f75-bca9-4a60-b8f8-040ec4b19998"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""955b3617-313d-4331-b7e1-0ec9c8ac0252"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3da18f50-142d-4e06-a2d7-6d2837a61b23"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""16360479-425b-4273-b031-d7fa8d7d58bb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9136b0f1-0ef6-4ecb-bd4c-3bd83d146922"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bc2b5794-3302-4d14-b977-6c4ecc38a245"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""448d5762-8ca7-470e-a033-57744292de1d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ada64941-899c-4549-878b-dce4a51dd603"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7c4d265-d0fe-42ee-b410-766d704a5e86"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Locomotion
        m_Locomotion = asset.FindActionMap("Locomotion", throwIfNotFound: true);
        m_Locomotion_Move = m_Locomotion.FindAction("Move", throwIfNotFound: true);
        m_Locomotion_Jump = m_Locomotion.FindAction("Jump", throwIfNotFound: true);
        m_Locomotion_Pickup = m_Locomotion.FindAction("Pickup", throwIfNotFound: true);
        m_Locomotion_Sprint = m_Locomotion.FindAction("Sprint", throwIfNotFound: true);
        m_Locomotion_Look = m_Locomotion.FindAction("Look", throwIfNotFound: true);
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

    // Locomotion
    private readonly InputActionMap m_Locomotion;
    private ILocomotionActions m_LocomotionActionsCallbackInterface;
    private readonly InputAction m_Locomotion_Move;
    private readonly InputAction m_Locomotion_Jump;
    private readonly InputAction m_Locomotion_Pickup;
    private readonly InputAction m_Locomotion_Sprint;
    private readonly InputAction m_Locomotion_Look;
    public struct LocomotionActions
    {
        private @Controls m_Wrapper;
        public LocomotionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Locomotion_Move;
        public InputAction @Jump => m_Wrapper.m_Locomotion_Jump;
        public InputAction @Pickup => m_Wrapper.m_Locomotion_Pickup;
        public InputAction @Sprint => m_Wrapper.m_Locomotion_Sprint;
        public InputAction @Look => m_Wrapper.m_Locomotion_Look;
        public InputActionMap Get() { return m_Wrapper.m_Locomotion; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LocomotionActions set) { return set.Get(); }
        public void SetCallbacks(ILocomotionActions instance)
        {
            if (m_Wrapper.m_LocomotionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnJump;
                @Pickup.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnPickup;
                @Sprint.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSprint;
                @Look.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_LocomotionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public LocomotionActions @Locomotion => new LocomotionActions(this);
    public interface ILocomotionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
