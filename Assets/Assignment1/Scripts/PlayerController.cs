using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] KeyCode moveLeft = KeyCode.A;
    [SerializeField] KeyCode moveRight = KeyCode.D;
    [SerializeField] KeyCode moveForward = KeyCode.W;
    [SerializeField] KeyCode moveBack = KeyCode.S;

    [SerializeField] private float speed = 3.0f;


    void Update()
    {
        // move player with keyboard keys

        if (Input.GetKey(moveLeft))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(moveRight))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(moveForward))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(moveBack))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
       
    }
}
