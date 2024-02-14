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
            if (canOpen && Input.GetKeyDown(KeyCode.E))
            {
                canOpen.OpenDoor();
            }
        }
    }
}
