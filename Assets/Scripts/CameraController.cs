using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /// <summary>
    /// プレイヤーのトランスフォーム
    /// </summary>
    [SerializeField] Transform m_playerTrans;
    /// <summary>
    /// Stageの右端
    /// </summary>
    [SerializeField] Transform m_stageRSideTrans;
    /// <summary>
    /// Stageの左端
    /// </summary>
    [SerializeField] Transform m_stageLSideTrans;
    /// <summary>
    /// Stageの端からカメラの位置までの距離
    /// </summary>
    float m_sideDistance;

    private void Start()
    {
        m_sideDistance = transform.position.x - m_stageLSideTrans.position.x;
        Mathf.Abs(m_sideDistance);
    }

    private void Update()
    {
        if (m_stageLSideTrans.position.x < m_playerTrans.position.x - m_sideDistance && 
            m_stageRSideTrans.position.x > m_playerTrans.position.x + m_sideDistance)
        {
            transform.position = new Vector3(m_playerTrans.position.x, transform.position.y, transform.position.z);
        }
    }
}
