using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    public float horizontalInput;
    float horizontalMultiplier = 2;

    private void FixedUpdate()
    {
        

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }
      private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

}
