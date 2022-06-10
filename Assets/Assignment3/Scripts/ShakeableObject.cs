using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeableObject : MonoBehaviour
{
    public bool IsShaking = false;

    [SerializeField] private float shakeSpeed = 20.0f;
    [SerializeField] private float startAngle = 0.5f;

    private void Update()
    {
        if (IsShaking)
        {
            float angleToMove = Mathf.Sin(Time.time * shakeSpeed);

            this.transform.localRotation = Quaternion.Euler(angleToMove, 0, 0);

        }
    }
}
