using JetBrains.Annotations;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float speed = 0f;

    private Rigidbody body;

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.J))
        {
            speed = 5f;
        }
        else speed = 0f;

        if (Input.GetKey(KeyCode.Space))
        {
            speed = 5f;
        }
        else speed = 0f;

        if (Input.GetKeyDown(KeyCode.K)) 
        {
            animator.SetTrigger("Attack");
        } else { animator.SetBool("IsAttacking", false); }

        animator.SetFloat("Speed", speed);
    }
} 
