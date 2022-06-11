using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
   
    public GameObject plank;
    public LayerMask m_LayerMask;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    private void OnCollisionEnter(Collision collision)
    {
       
        Collider[] hitColliders = Physics.OverlapBox(transform.position, collision.transform.localScale / 2, Quaternion.identity, m_LayerMask);
        for(int i = 0; i < hitColliders.Length; i++)
        {
            ShakeableObject obj = hitColliders[i].GetComponent<ShakeableObject>();
            if (obj != null)
            {
                obj.IsShaking = true;
            }
                
        }
        
    }



}
