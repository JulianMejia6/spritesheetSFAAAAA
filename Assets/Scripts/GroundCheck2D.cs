using UnityEngine;

public class GroundCheck2D : MonoBehaviour
{

    private bool isGrounded = false;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            //Debug.Log("Collision con suelo");
            animator.SetBool("Grounded", true);
            animator.SetBool("IsFalling", false);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            animator.SetBool("Grounded", false);
            animator.SetBool("IsFalling", true);
        }
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }
    
}
