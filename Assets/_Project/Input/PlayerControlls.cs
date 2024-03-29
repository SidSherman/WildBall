//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/_Project/Input/PlayerControlls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControlls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""Ball"",
            ""id"": ""59ac1a43-c411-4c82-8cee-5a4c7a56b006"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""79f738ef-73f8-48cf-b53d-6bf5dcccf4af"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""395b9159-189d-479b-95f5-48d833d70327"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""01f9376a-a7dc-4b49-865e-908d849d37de"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""57e753ca-98e9-4859-8eeb-84e0598609fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b00f9544-a8a1-4b90-bda4-ac532e45787c"",
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
                    ""id"": ""00fe7a8a-c3c1-4872-ab5f-89e284de1985"",
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
                    ""id"": ""de04abbe-792a-4cec-afec-9cc1bacaea3d"",
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
                    ""id"": ""6f26a3ae-1ab0-4960-b8fb-8380d7b4e886"",
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
                    ""id"": ""6ebac74c-1d11-44b7-b62a-7e71f3691eeb"",
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
                    ""id"": ""d3552d3c-856e-4148-9762-9775b8c9a50b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftRight"",
                    ""id"": ""1d848911-12f3-49fd-acec-3d283ca1c17f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bd3ce0b7-7a1a-4d1b-86b1-45cf33b46904"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f1e8a88f-ac3b-40ad-93cf-b6af6f37de97"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5f60cfc1-c9f4-4263-b8c8-c342e2786a1b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ball
        m_Ball = asset.FindActionMap("Ball", throwIfNotFound: true);
        m_Ball_Move = m_Ball.FindAction("Move", throwIfNotFound: true);
        m_Ball_Jump = m_Ball.FindAction("Jump", throwIfNotFound: true);
        m_Ball_Mouse = m_Ball.FindAction("Mouse", throwIfNotFound: true);
        m_Ball_Use = m_Ball.FindAction("Use", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Ball
    private readonly InputActionMap m_Ball;
    private IBallActions m_BallActionsCallbackInterface;
    private readonly InputAction m_Ball_Move;
    private readonly InputAction m_Ball_Jump;
    private readonly InputAction m_Ball_Mouse;
    private readonly InputAction m_Ball_Use;
    public struct BallActions
    {
        private @PlayerControlls m_Wrapper;
        public BallActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Ball_Move;
        public InputAction @Jump => m_Wrapper.m_Ball_Jump;
        public InputAction @Mouse => m_Wrapper.m_Ball_Mouse;
        public InputAction @Use => m_Wrapper.m_Ball_Use;
        public InputActionMap Get() { return m_Wrapper.m_Ball; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BallActions set) { return set.Get(); }
        public void SetCallbacks(IBallActions instance)
        {
            if (m_Wrapper.m_BallActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BallActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BallActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BallActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_BallActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_BallActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_BallActionsCallbackInterface.OnJump;
                @Mouse.started -= m_Wrapper.m_BallActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_BallActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_BallActionsCallbackInterface.OnMouse;
                @Use.started -= m_Wrapper.m_BallActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_BallActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_BallActionsCallbackInterface.OnUse;
            }
            m_Wrapper.m_BallActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
            }
        }
    }
    public BallActions @Ball => new BallActions(this);
    public interface IBallActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
    }
}
