using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AnimController : MonoBehaviour
{
    Animator anim => GameObject.Find("Character").GetComponent<Animator>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isAiming", true);

        }
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("isIdle", false);
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
            }
            anim.SetBool("isCrouching", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("isIdle", false);
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
            }
            anim.SetBool("isCrouching", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("isIdle", false);
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
            }
            anim.SetBool("isCrouching", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("isIdle", false);
                anim.SetBool("isWalking", false);
                anim.SetBool("isRunning", true);
            }
            anim.SetBool("isCrouching", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isCrouching", false);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isCrouching", true);
        }
        
        if (!Input.GetKey(KeyCode.W)&&
            !Input.GetKey(KeyCode.S)&&
            !Input.GetKey(KeyCode.A)&&
            !Input.GetKey(KeyCode.D)&&
            !Input.GetKey(KeyCode.LeftControl)&&
            !Input.GetKey(KeyCode.LeftShift)&&
            !Input.GetKey(KeyCode.Mouse1))
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isCrouching", false);
        }
    }
}
