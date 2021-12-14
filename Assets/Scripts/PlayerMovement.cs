using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float speed;

    private bool right = true;
    private Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        (float x, float y) = (movement.x, movement.y);

        // this way if the user doesn't do anything, nothing changes
        if (y > 0)
        {
            animator.SetBool("FacingBack", true);
        }
        else if (y < 0)
        {
            animator.SetBool("FacingBack", false);
        }

        if (x > 0)
        {
            right = true;
        }
        else if (x < 0)
        {
            right = false;
        }

        transform.localScale = new Vector3(right ? 1 : -1, 1, 1);

        if ((x < 0.5 && y < 0.5) && (x > -0.5 && y > -0.5)) animator.SetLayerWeight(1, 0);
        else animator.SetLayerWeight(1, 1);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}
