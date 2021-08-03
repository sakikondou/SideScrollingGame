using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D m_rb;
    PlayerInputAction m_inputActions;
    public float JumpPow = 5f;

    public void Init( PlayerInputAction inputActions, Rigidbody2D rb, float jumpPow)
    {
        m_inputActions = inputActions;
        m_inputActions.Player.Jump.started += context => Jump();
        m_rb = rb;
        JumpPow = jumpPow;
    }

    void Jump()
    {
        m_rb.velocity = new Vector2(m_rb.velocity.x, JumpPow);
    }
}
