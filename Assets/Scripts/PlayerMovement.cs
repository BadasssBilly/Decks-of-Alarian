using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    private const string LastHorizontal = "LastHorizontal";
    private const string LastVertical = "LastVertical";

    void Update()
{
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");

    animator.SetFloat("Horizontal", movement.x);
    animator.SetFloat("Vertical", movement.y);
    animator.SetFloat("Speed", movement.sqrMagnitude);

    if (movement != Vector2.zero)
    {
        animator.SetFloat(LastHorizontal, movement.x);
        animator.SetFloat(LastVertical, movement.y);
    }
}

void FixedUpdate()
{
    rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime); 
}

}