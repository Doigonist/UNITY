using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{
    public float speed;
    public float jumpheight;
    private Rigidbody2D rb;
    private Collider2D col;
    private Vector2 moveDirection;
    private Vector2 JumpDirection;
    private bool isGrounded;
    private GlobalValues Global;
    public static bool ifControlsEnabled = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 20;
        jumpheight = 2000;
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        isGrounded = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (MovementController.ifControlsEnabled)
        {
            moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0) * speed;
            rb.linearVelocity = moveDirection;
            if (Input.GetButton("Jump") && isGrounded)
            {
                rb.AddForceY(jumpheight, ForceMode2D.Impulse);

            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            MovementController.ifControlsEnabled = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Platform") {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag== "Platform") {
            isGrounded=false;
    
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform") {
            GlobalValues.Score++;
        }
    }
    void JumpLogic() {
        
    }
}
