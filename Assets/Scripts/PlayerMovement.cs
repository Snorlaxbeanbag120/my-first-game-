using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float ForwardForce = 2000f;
    public float SidewaysForce = 500f;
// This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // We marked this ass "Fixed"Update because
    // we are using it to mess with the physics
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
         if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }   
}
