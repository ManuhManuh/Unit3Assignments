using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeableObject : MonoBehaviour
{
    public bool IsShaking = false;

    [SerializeField] private float shakeSpeed = 2.0f;
    [SerializeField] private float shakeDistance = 7.0f;

    private float m_startX;
    private float m_startY;
    private float m_startZ;

    private void Awake()
    {
        m_startX = transform.position.x;
        m_startY = transform.position.y;
        m_startZ = transform.position.z;
    }
    private void Update()
    {
        if (IsShaking)
        {

            float newX = m_startX + Mathf.Sin(shakeSpeed * Time.deltaTime) * shakeDistance;
            float newY = m_startY + Mathf.Sin(shakeSpeed * Time.deltaTime) * shakeDistance;
            float newZ = m_startZ + Mathf.Sin(shakeSpeed * Time.deltaTime) * shakeDistance;


            transform.position = new Vector3(newX, newY, newZ);

        }
    }
}
