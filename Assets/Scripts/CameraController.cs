using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /// <summary>
    /// プレイヤーのトランスフォーム
    /// </summary>
    [SerializeField] Transform m_playerTrans;
    [SerializeField] Transform m_stageRSideTrans;
    [SerializeField] Transform m_stageLSideTrans;
    private void Update()
    {
        if (m_stageLSideTrans.position.x < m_playerTrans.position.x && m_stageRSideTrans.position.x > m_playerTrans.position.x)
        {
            transform.position = new Vector3(m_playerTrans.position.x, transform.position.y, transform.position.z);
        }
        
    }
}
