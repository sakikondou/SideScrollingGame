using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputController m_inputController;
    PlayerInputAction m_inputActions;
    Rigidbody2D m_rb;

    PlayerMove m_playerMove;
    /// <summary>
    /// 移動速度
    /// </summary>
    [SerializeField] float m_moveSpeed = 5f;

    private void Start()
    {
        m_inputActions = m_inputController.InputActions;
        m_rb = GetComponent<Rigidbody2D>();

        m_playerMove = gameObject.AddComponent<PlayerMove>();
        m_playerMove.Init(m_inputActions, m_rb);
    }

    private void Update()
    {
        m_playerMove.Move(m_moveSpeed);
    }
}
