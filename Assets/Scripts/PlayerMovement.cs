using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    [SerializeField] float speed = 5f;
    [SerializeField] Rigidbody2D rb;
    Vector2 movement;

    private bool canDash = true;
    private bool isDashing;
    

    [Header("Dash Settings")]
    [SerializeField] float dashSpeed = 10f;
    [SerializeField] float dashingTime = .5f;
    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] float dashingCooldown = 3f;
    void Update()
    { //Input
        if(isDashing){
            return;
        }
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
        animator.SetFloat("Speed", movement.magnitude * speed);
        animator.SetFloat("xDirection", movement.x);
        animator.SetFloat("yDirection", movement.y);

        if(Input.GetKeyDown(KeyCode.Space) && canDash){
            StartCoroutine(Dash());
        }

    }

    void FixedUpdate() 
    { //called 50 times a second. Movement
        if(isDashing){
            return;
        }
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime); //move character (use fixed delta time because in fixedUpdate())
    }

    private IEnumerator Dash(){
        canDash = false;
        isDashing = true;
        rb.velocity = new Vector2(movement.x * dashSpeed, movement.y * dashSpeed);
        trailRenderer.emitting = true;

        yield return new WaitForSeconds(dashingTime);

        trailRenderer.emitting = false;
        isDashing = false;

        yield return new WaitForSeconds(dashingCooldown);

        canDash = true;
    }
}
