//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Settings/TankControls.inputactions
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

namespace Tanks
{
    public partial class @TankControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TankControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""TankControls"",
    ""maps"": [
        {
            ""name"": ""Tank"",
            ""id"": ""f8384fff-1c00-4583-a795-b9597e534a6d"",
            ""actions"": [
                {
                    ""name"": ""HandBreak"",
                    ""type"": ""Button"",
                    ""id"": ""b35b4a98-f290-4a34-953c-a1d5916223d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""59beeac4-18fc-4e3b-9e14-d79eb3afb37b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b0b35939-8f5a-4544-9708-ded072c1252c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HandBreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""e798c64a-bfa5-4945-9726-cf52bc59f815"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb4760a9-4cae-4d28-8dad-a7e2c9baafd3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d459717e-ed87-4df5-8a7a-e10232cdd0e7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f8a3d8ae-66ad-4567-83a3-c8faef0695f6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5d74f0ce-49db-49c0-ac3b-e8f550b4cb13"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Turret"",
            ""id"": ""e0edf8ed-0073-4d1f-a32c-2c0b0034b0c7"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""48896f76-e019-438e-9114-7b20fbbafcd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Focus"",
                    ""type"": ""Value"",
                    ""id"": ""58900bb4-cc6c-46a5-b853-95e25b0fbca3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a6caf9cd-46c5-4c65-baed-475b8b77f787"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4be628a1-f7fd-40d0-9a7a-077914939283"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Focus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Tank
            m_Tank = asset.FindActionMap("Tank", throwIfNotFound: true);
            m_Tank_HandBreak = m_Tank.FindAction("HandBreak", throwIfNotFound: true);
            m_Tank_Movement = m_Tank.FindAction("Movement", throwIfNotFound: true);
            // Turret
            m_Turret = asset.FindActionMap("Turret", throwIfNotFound: true);
            m_Turret_Fire = m_Turret.FindAction("Fire", throwIfNotFound: true);
            m_Turret_Focus = m_Turret.FindAction("Focus", throwIfNotFound: true);
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

        // Tank
        private readonly InputActionMap m_Tank;
        private List<ITankActions> m_TankActionsCallbackInterfaces = new List<ITankActions>();
        private readonly InputAction m_Tank_HandBreak;
        private readonly InputAction m_Tank_Movement;
        public struct TankActions
        {
            private @TankControls m_Wrapper;
            public TankActions(@TankControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @HandBreak => m_Wrapper.m_Tank_HandBreak;
            public InputAction @Movement => m_Wrapper.m_Tank_Movement;
            public InputActionMap Get() { return m_Wrapper.m_Tank; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
            public void AddCallbacks(ITankActions instance)
            {
                if (instance == null || m_Wrapper.m_TankActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TankActionsCallbackInterfaces.Add(instance);
                @HandBreak.started += instance.OnHandBreak;
                @HandBreak.performed += instance.OnHandBreak;
                @HandBreak.canceled += instance.OnHandBreak;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }

            private void UnregisterCallbacks(ITankActions instance)
            {
                @HandBreak.started -= instance.OnHandBreak;
                @HandBreak.performed -= instance.OnHandBreak;
                @HandBreak.canceled -= instance.OnHandBreak;
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
            }

            public void RemoveCallbacks(ITankActions instance)
            {
                if (m_Wrapper.m_TankActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITankActions instance)
            {
                foreach (var item in m_Wrapper.m_TankActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TankActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TankActions @Tank => new TankActions(this);

        // Turret
        private readonly InputActionMap m_Turret;
        private List<ITurretActions> m_TurretActionsCallbackInterfaces = new List<ITurretActions>();
        private readonly InputAction m_Turret_Fire;
        private readonly InputAction m_Turret_Focus;
        public struct TurretActions
        {
            private @TankControls m_Wrapper;
            public TurretActions(@TankControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Fire => m_Wrapper.m_Turret_Fire;
            public InputAction @Focus => m_Wrapper.m_Turret_Focus;
            public InputActionMap Get() { return m_Wrapper.m_Turret; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TurretActions set) { return set.Get(); }
            public void AddCallbacks(ITurretActions instance)
            {
                if (instance == null || m_Wrapper.m_TurretActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TurretActionsCallbackInterfaces.Add(instance);
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Focus.started += instance.OnFocus;
                @Focus.performed += instance.OnFocus;
                @Focus.canceled += instance.OnFocus;
            }

            private void UnregisterCallbacks(ITurretActions instance)
            {
                @Fire.started -= instance.OnFire;
                @Fire.performed -= instance.OnFire;
                @Fire.canceled -= instance.OnFire;
                @Focus.started -= instance.OnFocus;
                @Focus.performed -= instance.OnFocus;
                @Focus.canceled -= instance.OnFocus;
            }

            public void RemoveCallbacks(ITurretActions instance)
            {
                if (m_Wrapper.m_TurretActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITurretActions instance)
            {
                foreach (var item in m_Wrapper.m_TurretActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TurretActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TurretActions @Turret => new TurretActions(this);
        public interface ITankActions
        {
            void OnHandBreak(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
        }
        public interface ITurretActions
        {
            void OnFire(InputAction.CallbackContext context);
            void OnFocus(InputAction.CallbackContext context);
        }
    }
}
