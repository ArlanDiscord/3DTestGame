using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float xMouse,yMouse;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    int locked = 1;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        xMouse = Input.GetAxis("Mouse X");
        yMouse = Input.GetAxis("Mouse Y");
        
        transform.eulerAngles += new Vector3(-yMouse, 0f, 0f);
        player.transform.eulerAngles += new Vector3(0f, xMouse, 0f);

        transform.position = player.transform.position - (transform.forward*3);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (locked == 0)
            {
                Cursor.lockState = CursorLockMode.Locked;
                locked = 1;
            }
            else
            {
                locked = 0;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
