using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    private bool m_started = false;
    public GameObject plank;
    public LayerMask m_LayerMask;

    // Start is called before the first frame update
    void Start()
    {
        m_started = true;
    }


    private void OnCollisionEnter(Collision collision)
    {

        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale * 2, Quaternion.identity, m_LayerMask);
        for(int i = 0; i < hitColliders.Length; i++)
        {
            Debug.Log($"Raycast found {hitColliders[i].name}");
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if (m_started)
        {
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}
