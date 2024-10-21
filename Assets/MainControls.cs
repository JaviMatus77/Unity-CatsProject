//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/MainControls.inputactions
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

public partial class @MainControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""Player01"",
            ""id"": ""2159c456-20aa-43e9-89d5-df970d0450e2"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6915ec95-223c-4c57-9e9b-b60dcf2493ae"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c92631f0-96e9-4577-b3d2-672d232ae976"",
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
                    ""id"": ""113b713b-c2ed-4508-a2dc-cff7081e2297"",
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
                    ""id"": ""de125ca4-f3ce-4f37-9f1d-f82e4513b35b"",
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
                    ""id"": ""98fbc268-1c05-4400-8738-ae282f2e2932"",
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
                    ""id"": ""059ffa7f-9058-47e2-b387-be548397698d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player02"",
            ""id"": ""6fa64393-d860-4adc-9d2c-d39be22bde6b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0dbf31e6-bc4d-4fca-9dd1-994f11307432"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9eee19f0-b38b-44e3-bf1c-1a8f19048c4c"",
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
                    ""id"": ""bae1ac9f-2ab7-43e4-96af-3c1e42a66bb3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f17d5229-6e3b-470a-859f-c3e1fac66863"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7638aa14-b651-4e0d-90b7-86f2c3152dcf"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""97665594-de69-4ed6-b37f-5c438930232c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Players"",
            ""bindingGroup"": ""Players"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player01
        m_Player01 = asset.FindActionMap("Player01", throwIfNotFound: true);
        m_Player01_Move = m_Player01.FindAction("Move", throwIfNotFound: true);
        // Player02
        m_Player02 = asset.FindActionMap("Player02", throwIfNotFound: true);
        m_Player02_Move = m_Player02.FindAction("Move", throwIfNotFound: true);
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

    // Player01
    private readonly InputActionMap m_Player01;
    private List<IPlayer01Actions> m_Player01ActionsCallbackInterfaces = new List<IPlayer01Actions>();
    private readonly InputAction m_Player01_Move;
    public struct Player01Actions
    {
        private @MainControls m_Wrapper;
        public Player01Actions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player01_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player01; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player01Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer01Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player01ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player01ActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayer01Actions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayer01Actions instance)
        {
            if (m_Wrapper.m_Player01ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer01Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player01ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player01ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player01Actions @Player01 => new Player01Actions(this);

    // Player02
    private readonly InputActionMap m_Player02;
    private List<IPlayer02Actions> m_Player02ActionsCallbackInterfaces = new List<IPlayer02Actions>();
    private readonly InputAction m_Player02_Move;
    public struct Player02Actions
    {
        private @MainControls m_Wrapper;
        public Player02Actions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player02_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player02; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player02Actions set) { return set.Get(); }
        public void AddCallbacks(IPlayer02Actions instance)
        {
            if (instance == null || m_Wrapper.m_Player02ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Player02ActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayer02Actions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayer02Actions instance)
        {
            if (m_Wrapper.m_Player02ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayer02Actions instance)
        {
            foreach (var item in m_Wrapper.m_Player02ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Player02ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Player02Actions @Player02 => new Player02Actions(this);
    private int m_PlayersSchemeIndex = -1;
    public InputControlScheme PlayersScheme
    {
        get
        {
            if (m_PlayersSchemeIndex == -1) m_PlayersSchemeIndex = asset.FindControlSchemeIndex("Players");
            return asset.controlSchemes[m_PlayersSchemeIndex];
        }
    }
    public interface IPlayer01Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayer02Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}