using UnityEngine;

public class GroundCheck2D : MonoBehaviour
{
    private bool isgrounded = false;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isgrounded = true;
            Debug.Log("Collision con suelo");
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isgrounded = false;
        }
    }

    public bool isGrounded()
    { return isgrounded; }
}
