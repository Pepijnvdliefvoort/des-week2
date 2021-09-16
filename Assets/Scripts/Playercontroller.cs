using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] [Range(10, 15)] private int speed = 10;
    [SerializeField] private Rigidbody rb;
    private float _movementX;
    private float _movementZ;
    private Vector3 _movementToWorldSpace;

    // Start is called before the first frame update
    private void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue)
    {
        var movementVector = movementValue.Get<Vector2>();
        _movementX = movementVector.x;
        _movementZ = movementVector.y;
    }
    
    private void FixedUpdate()
    {
        var movement = new Vector3(_movementX, 0.0f, _movementZ);
        rb.AddForce(movement * speed);
    }
}
