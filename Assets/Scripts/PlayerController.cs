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

    PlayerJump m_playerJump;
    /// <summary>
    /// ジャンプ力
    /// </summary>
    [SerializeField] float m_jumpPow = 3f;

    private void Start()
    {
        m_inputActions = m_inputController.InputActions;
        m_rb = GetComponent<Rigidbody2D>();

        m_playerMove = gameObject.AddComponent<PlayerMove>();
        m_playerMove.Init(m_inputActions, m_rb);

        m_playerJump = gameObject.AddComponent<PlayerJump>();
        m_playerJump.Init(m_inputActions, m_rb, m_jumpPow);
    }

    private void Update()
    {
        m_playerMove.Move(m_moveSpeed);
    }
}
