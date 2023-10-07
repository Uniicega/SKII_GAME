using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float forcePower;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float xInput;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }

    private void MoveLeftOrRight()
    {
        xInput = Input.GetAxis("Horizontal");
    }
}
