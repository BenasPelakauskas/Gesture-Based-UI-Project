using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVelocity : MonoBehaviour
{

    public float thrust = 12.0f;
    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }
    }
}

   
