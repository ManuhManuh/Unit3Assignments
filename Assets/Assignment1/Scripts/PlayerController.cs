using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;

    [Header("Keyboard inputs")]
    [SerializeField] KeyCode moveLeft = KeyCode.A;
    [SerializeField] KeyCode moveRight = KeyCode.D;
    [SerializeField] KeyCode moveForward = KeyCode.W;
    [SerializeField] KeyCode moveBack = KeyCode.S;

    [Header("Action speeds")]
    [SerializeField] private float moveSpeed = 3.0f;
    [SerializeField] private float viewSpeed = 3.0f;

    void Update()
    {
        // move player with keyboard keys

        if (Input.GetKey(moveLeft))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(moveRight))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(moveForward))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(moveBack))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        // rotate player and camera with mouse

        // rotate the player and the camera(child) horizontally
        float horizontal = Input.GetAxis("Mouse X");
        float newHorizontalRotation = transform.localRotation.eulerAngles.y + viewSpeed * horizontal;
        transform.localRotation = Quaternion.Euler(0, newHorizontalRotation, 0);

        // rotate the just the camera vertically
        float vertical = Input.GetAxis("Mouse Y");
        float newVerticalRotation = playerCamera.localRotation.eulerAngles.x - viewSpeed * vertical;
        playerCamera.localRotation = Quaternion.Euler(newVerticalRotation, 0, 0);

    }
}
