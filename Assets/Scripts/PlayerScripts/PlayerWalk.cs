using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWalk : MonoBehaviour
{
    //Player walk
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 playerMove;

    //Player animator
    private Animator anim;

    private PlayerInventory inventory;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        inventory = new PlayerInventory();
        FindObjectOfType<UI>().OnItemAdded += HandleItemAdded;
    }

    private void HandleItemAdded(ItemData item)
    {
        inventory.AddItem(item);
    }

    private void FixedUpdate()
    {

        //Player move code
        playerMove = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = playerMove * moveSpeed;

        if (playerMove != Vector2.zero)
        {
            anim.SetBool("IsWalking", true);
            anim.SetFloat("XInput", playerMove.x);
            anim.SetFloat("YInput", playerMove.y);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }

}
