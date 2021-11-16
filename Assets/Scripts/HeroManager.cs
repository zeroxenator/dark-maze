using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Input
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    transform.Translate(0, 1.75f, 0);
        //}

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    private void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
