using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D m_rb;
    PlayerInputAction m_inputActions;
    public float JumpPow = 5f;
    bool m_isGrounded = true;

    public void Init( PlayerInputAction inputActions, Rigidbody2D rb, float jumpPow)
    {
        m_inputActions = inputActions;
        m_inputActions.Player.Jump.performed += context => Jump();
        m_rb = rb;
        JumpPow = jumpPow;
    }

    void Jump()
    {
        if (m_isGrounded)
        {
            m_rb.velocity = new Vector2(m_rb.velocity.x, JumpPow);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            m_isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            m_isGrounded = false;
        }
    }
}
