using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanOpen : MonoBehaviour
{
    public Animator animR;
    public Animator animL;
    public void OpenDoor()
    {
        if (animR.GetBool("isOpen") == true) {
            Debug.Log("Close");
            animR.SetBool("isOpen", false);
            animL.SetBool("isOpen", false);
        }
        else
        {
            animR.SetBool("isOpen", true);
            animL.SetBool("isOpen", true);
        }
    }
}
