using JetBrains.Annotations;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    [Header("Movimiento")]
    public float MoveSpeed = 7f;
    public float JumpForce = 10f;

    private Rigidbody2D rb;
    private float moveInput;

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * MoveSpeed, rb.linearVelocityY);
        animator.SetFloat("Speed", Mathf.Abs(rb.linearVelocityX));


        if (moveInput > 0) { transform.localScale = new Vector3(1, 1, 1); } 
        if (moveInput < 0) { transform.localScale = new Vector3(-1, 1, 1);}

        if (rb.linearVelocityY < 0) { animator.SetBool("IsFalling", true); }

        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            animator.SetTrigger("Jump");
        }


        if (Input.GetKeyDown(KeyCode.J)) 
        {
            animator.SetTrigger("Attack");
        } else { animator.SetBool("IsAttacking", false); }
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("Attack2");
        }
        else { animator.SetBool("IsAttacking", false); }
        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("Attack3");
        }
        else { animator.SetBool("IsAttacking", false); }

    }

} 
