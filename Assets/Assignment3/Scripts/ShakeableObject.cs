using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeableObject : MonoBehaviour
{
    public bool IsShaking = false;

    [SerializeField] private float shakeSpeed = 2.0f;
    [SerializeField] private float shakeDistance = 0.1f;

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
            Debug.Log($"{gameObject.name} is shaking");
            float newX = m_startX + Mathf.Sin(Time.deltaTime * shakeSpeed * shakeDistance);
            float newY = m_startY + Mathf.Sin(Time.deltaTime * shakeSpeed * shakeDistance);
            float newZ = m_startZ + Mathf.Sin(Time.deltaTime * shakeSpeed * shakeDistance);

            transform.position = new Vector3(newX, newY, newZ);
        }
    }
}
