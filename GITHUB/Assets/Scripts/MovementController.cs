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
        speed = 7;
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        JumpDirection = new Vector2 (Input.GetAxisRaw("Horizontal"), 5);
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0) * speed;
        rb.linearVelocity = moveDirection;
        if (Input.GetButton("Jump")) {
            rb.AddForceY(jumpheight);
        }
    }
    void JumpLogic() {
        // Change for test commit
    }
}
