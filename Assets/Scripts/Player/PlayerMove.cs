using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    PlayerInputAction m_inputActions;
    Rigidbody2D m_rb;

    Vector2 m_inputAxis;

    public void Init(PlayerInputAction inputActions, Rigidbody2D rb)
    {
        m_inputActions = inputActions;
        m_rb = rb;
    }

    /// <summary>
    /// 移動する
    /// </summary>
    /// <param name="speed">移動速度</param>
    public void Move(float speed)
    {
        m_inputAxis = m_inputActions.Player.Move.ReadValue<Vector2>();
        
        //横移動
        m_rb.velocity = new Vector2(m_inputAxis.x * speed, m_rb.velocity.y);
    }
}
