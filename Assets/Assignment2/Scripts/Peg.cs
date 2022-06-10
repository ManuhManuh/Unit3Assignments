using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peg : MonoBehaviour
{
    [SerializeField] private int pointValue;

    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.PegHit(pointValue);
    }
}
