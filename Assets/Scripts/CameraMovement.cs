using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float xMouse,yMouse;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.Locked;
       
    }

    // Update is called once per frame
    void Update()
    {
        xMouse = Input.GetAxis("Mouse X");
        yMouse = Input.GetAxis("Mouse Y");
        
        transform.eulerAngles += new Vector3(-yMouse, 0f, 0f);
        player.transform.eulerAngles += new Vector3(0f, xMouse, 0f);

        transform.position = player.transform.position - (transform.forward*3);
        
    }
}
