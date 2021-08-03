using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    PlayerInputAction m_inputActions;
    public PlayerInputAction InputActions { private set { } get { return m_inputActions; } }

    void Start()
    {
        m_inputActions = new PlayerInputAction();
        m_inputActions.Enable();
    }
}
