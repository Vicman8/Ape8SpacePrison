using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardenLook : MonoBehaviour
{
    public Transform player;
    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        if (player.position.x < transform.position.x)
        {
            animator.SetBool("IsLookingLeft", true);
            animator.SetBool("IsLookingRight", false);
        }
        else
        {
            animator.SetBool("IsLookingLeft", false);
            animator.SetBool("IsLookingRight", true);
        }
    }
}
