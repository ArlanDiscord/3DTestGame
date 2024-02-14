using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanOpen : MonoBehaviour
{
    Animator anim => GetComponent<Animator>();
    public void OpenDoor()
    {
        anim.SetBool("isOpen", true);
    }
}
