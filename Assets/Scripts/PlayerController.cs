using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem; // from package manager, code for moving player
    // uses Player Input component with an attached InputActions asset


public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX, movementY;
    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Use input system package to move character
    void OnMove(InputValue moveValue) {
        Vector2 movementVector = moveValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate() {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
}