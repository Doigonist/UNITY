using Unity.VisualScripting;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed;
    public float jumpheight;
    private Rigidbody2D rb;
    private Collider2D col;
    private Vector2 moveDirection;
    private Vector2 JumpDirection;
    private bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 15;
        jumpheight = 1800;
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        isGrounded = true;

    }

    // Update is called once per frame
    void Update()
    {
        JumpDirection = new Vector2 (Input.GetAxisRaw("Horizontal"), 5);
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0) * speed;
        rb.linearVelocity = moveDirection;
        if (Input.GetButton("Jump") && isGrounded) {
            rb.AddForceY(jumpheight, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground") {
            isGrounded=false;
        }
    }
    void JumpLogic() {
        // Change for test commit
    }
}
