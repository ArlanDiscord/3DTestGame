using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    // Start is called before the first frame update
    int entered = 0;
    public GameObject lamp;
    int enabledd = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && entered == 1)
        {
            if (enabledd == 1)
            {
                lamp.GetComponent<Light>().enabled = false;
                enabledd = 0;
            }
            else
            {
                enabledd = 1;
                lamp.GetComponent<Light>().enabled = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            entered = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            entered = 0;
        }
    }
}
