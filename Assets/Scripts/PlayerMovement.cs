using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float xmove, zmove;
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
            movement += mainCamera.transform.forward;
        if (Input.GetKey(KeyCode.S))
            movement -= mainCamera.transform.forward;
        if (Input.GetKey(KeyCode.D))
            movement += mainCamera.transform.right;
        if (Input.GetKey(KeyCode.A))
            movement -= mainCamera.transform.right;
        movement.Normalize();

        rb.velocity = new Vector3(movement.x*speed, rb.velocity.y, movement.z*speed);
    }
}
