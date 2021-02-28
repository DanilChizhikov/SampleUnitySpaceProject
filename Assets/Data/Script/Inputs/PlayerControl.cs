// GENERATED AUTOMATICALLY FROM 'Assets/Data/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Data.Script.Core.Inputs
{
    public class @PlayerControl : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControl()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""2a33e2e6-8ba5-419d-a6f3-032c49206569"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ea8b1968-668a-4e27-9ccd-3ed3a19d81e6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RollRight"",
                    ""type"": ""Button"",
                    ""id"": ""1d784b37-a05f-47b3-bc3d-24b5bc90b22b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RollLeft"",
                    ""type"": ""Button"",
                    ""id"": ""4c128118-882d-486b-b113-ec0889cc026d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""f23b5220-b726-4d17-9f3f-369b30c1f65c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Upping"",
                    ""type"": ""Button"",
                    ""id"": ""9c419ba3-e9ec-405e-8897-6358929d8b53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""92d9dc58-02ad-4303-ba8c-908275c6607d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scan"",
                    ""type"": ""Button"",
                    ""id"": ""3caf56d1-ce78-41e7-9dae-747f4235a326"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9de53e53-074e-41d1-abeb-383ddf680f49"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0dd9db9-62e4-4cdd-acd7-fd8b04b6ec86"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Scan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""32f9e9b2-8b08-476d-b396-7bfe68ab76d4"",
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
                    ""id"": ""f435418d-5a40-4c56-8406-1cecf8a6677c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7854ba0a-584d-487e-823e-87042140b045"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d165bdb9-fbc2-4193-9d82-716b74ed2388"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9b0594a3-4ad6-4b6d-8b8f-f612d34afb71"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0a22f57d-7584-4edd-a6b8-2d20617e3019"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Upping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f9c9699-dfee-4cda-8802-e3ece9c0b484"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d31a5aec-5537-41b9-bdc6-d640a0f18350"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""RollLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1efb9481-0cbd-46c7-a589-bba95a7fe582"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""RollRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and Keybord"",
            ""bindingGroup"": ""Mouse and Keybord"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
            m_Player_RollRight = m_Player.FindAction("RollRight", throwIfNotFound: true);
            m_Player_RollLeft = m_Player.FindAction("RollLeft", throwIfNotFound: true);
            m_Player_Down = m_Player.FindAction("Down", throwIfNotFound: true);
            m_Player_Upping = m_Player.FindAction("Upping", throwIfNotFound: true);
            m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
            m_Player_Scan = m_Player.FindAction("Scan", throwIfNotFound: true);
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

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Move;
        private readonly InputAction m_Player_RollRight;
        private readonly InputAction m_Player_RollLeft;
        private readonly InputAction m_Player_Down;
        private readonly InputAction m_Player_Upping;
        private readonly InputAction m_Player_Shoot;
        private readonly InputAction m_Player_Scan;
        public struct PlayerActions
        {
            private @PlayerControl m_Wrapper;
            public PlayerActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @RollRight => m_Wrapper.m_Player_RollRight;
            public InputAction @RollLeft => m_Wrapper.m_Player_RollLeft;
            public InputAction @Down => m_Wrapper.m_Player_Down;
            public InputAction @Upping => m_Wrapper.m_Player_Upping;
            public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
            public InputAction @Scan => m_Wrapper.m_Player_Scan;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @RollRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollRight;
                    @RollRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollRight;
                    @RollRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollRight;
                    @RollLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollLeft;
                    @RollLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollLeft;
                    @RollLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollLeft;
                    @Down.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
                    @Down.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
                    @Down.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
                    @Upping.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpping;
                    @Upping.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpping;
                    @Upping.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpping;
                    @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                    @Scan.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScan;
                    @Scan.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScan;
                    @Scan.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScan;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @RollRight.started += instance.OnRollRight;
                    @RollRight.performed += instance.OnRollRight;
                    @RollRight.canceled += instance.OnRollRight;
                    @RollLeft.started += instance.OnRollLeft;
                    @RollLeft.performed += instance.OnRollLeft;
                    @RollLeft.canceled += instance.OnRollLeft;
                    @Down.started += instance.OnDown;
                    @Down.performed += instance.OnDown;
                    @Down.canceled += instance.OnDown;
                    @Upping.started += instance.OnUpping;
                    @Upping.performed += instance.OnUpping;
                    @Upping.canceled += instance.OnUpping;
                    @Shoot.started += instance.OnShoot;
                    @Shoot.performed += instance.OnShoot;
                    @Shoot.canceled += instance.OnShoot;
                    @Scan.started += instance.OnScan;
                    @Scan.performed += instance.OnScan;
                    @Scan.canceled += instance.OnScan;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        private int m_MouseandKeybordSchemeIndex = -1;
        public InputControlScheme MouseandKeybordScheme
        {
            get
            {
                if (m_MouseandKeybordSchemeIndex == -1) m_MouseandKeybordSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keybord");
                return asset.controlSchemes[m_MouseandKeybordSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnRollRight(InputAction.CallbackContext context);
            void OnRollLeft(InputAction.CallbackContext context);
            void OnDown(InputAction.CallbackContext context);
            void OnUpping(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnScan(InputAction.CallbackContext context);
        }
    }
}
