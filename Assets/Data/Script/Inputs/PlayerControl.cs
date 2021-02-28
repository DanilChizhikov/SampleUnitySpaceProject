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
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Value"",
                    ""id"": ""e488b105-e7a7-4ad9-8cd6-fa55567351b5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""644ec204-0c68-45b1-a230-18c687ed5946"",
                    ""expectedControlType"": """",
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
                    ""name"": ""QE"",
                    ""id"": ""6208c222-b294-4ad8-9ede-82a296630694"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""52f8e269-da8c-4e76-a34d-1f8cfb3053e6"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9b263952-59bc-4eb9-bf25-86265eaf8f7c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""CtrlSpace"",
                    ""id"": ""f03f2065-c6c7-4121-9ccc-a3efbbc0aa89"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""10de0388-ac34-4aae-b907-8e7afa81543e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4d7de5cb-b923-4829-b09d-ed40fe7d219d"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keybord"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
            m_Player_MoveY = m_Player.FindAction("MoveY", throwIfNotFound: true);
            m_Player_Roll = m_Player.FindAction("Roll", throwIfNotFound: true);
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
        private readonly InputAction m_Player_MoveY;
        private readonly InputAction m_Player_Roll;
        private readonly InputAction m_Player_Shoot;
        private readonly InputAction m_Player_Scan;
        public struct PlayerActions
        {
            private @PlayerControl m_Wrapper;
            public PlayerActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @MoveY => m_Wrapper.m_Player_MoveY;
            public InputAction @Roll => m_Wrapper.m_Player_Roll;
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
                    @MoveY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                    @MoveY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                    @MoveY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                    @Roll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                    @Roll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                    @Roll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
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
                    @MoveY.started += instance.OnMoveY;
                    @MoveY.performed += instance.OnMoveY;
                    @MoveY.canceled += instance.OnMoveY;
                    @Roll.started += instance.OnRoll;
                    @Roll.performed += instance.OnRoll;
                    @Roll.canceled += instance.OnRoll;
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
            void OnMoveY(InputAction.CallbackContext context);
            void OnRoll(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnScan(InputAction.CallbackContext context);
        }
    }
}
