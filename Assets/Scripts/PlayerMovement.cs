using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float speed=5;
    [SerializeField] float jumpForce;
    [SerializeField] GameObject mainCamera;
    // Start is called before the first frame update
    int start = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        speed = 5;
        if (Input.GetKey(KeyCode.W))
            movement += mainCamera.transform.forward;
        if (Input.GetKey(KeyCode.S))
            movement -= mainCamera.transform.forward;
        if (Input.GetKey(KeyCode.D))
            movement += mainCamera.transform.right;
        if (Input.GetKey(KeyCode.A))
            movement -= mainCamera.transform.right;
        movement.Normalize();
        rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movement.z * speed);

        if (Input.GetKey(KeyCode.LeftShift))
            speed = 10;
        if (Input.GetKeyDown(KeyCode.Space) && start < 2)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            start += 1;
            rb.velocity = new Vector3(movement.x*speed, rb.velocity.y, movement.z*speed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            start = 0;
        }
    }
}
