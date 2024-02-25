using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward*1,Color.red);
        
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            CanOpen canOpen = hit.collider.gameObject.GetComponent<CanOpen>();
            if (canOpen && hit.distance <= 2)
            {
                canOpen.GetComponent<Renderer>().material.color = Color.red;
                if (Input.GetKeyDown(KeyCode.E))
                    canOpen.OpenDoor();
            }
        }

        Ray jumpRay = new Ray(transform.position, transform.up * -1f);
        Debug.DrawRay(transform.position, transform.up * -1f,Color.green);
        RaycastHit jumpHit;
        if(Physics.Raycast(jumpRay,out jumpHit))
        {
            if (jumpHit.distance <= 1)
            {
                PlayerMovement.start = 0;
            }
            if (jumpHit.transform.tag == "MovingPlatform")
            {
                GameObject.Find("Capsule").transform.parent = jumpHit.transform;
            }
        }
    }
}
