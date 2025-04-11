using UnityEngine;
public class movent : MonoBehaviour
{     
    private Rigidbody2D _rb;
    private Animator anim;
    private float _checkRadius = 0.5f;
    private bool _isGrounded;
    private float moveInput;
    public float Speed = 10f;
    public float JumpForce = 30f;
    public Transform feetPos;
    public Transform PosSpawn;
    public LayerMask whatIsGround;
    private bool facingRight;

    void Start()
    {
        anim = GetComponent<Animator>();
         facingRight = !facingRight;  
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {     
        moveInput = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(moveInput * Speed, _rb.velocity.y);
        _isGrounded = Physics2D.OverlapCircle(feetPos.position,
        _checkRadius, whatIsGround);
   
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(PosSpawn.position.x, PosSpawn.position.y, PosSpawn.rotation.z);
            transform.rotation = Quaternion.Euler(0f, 0f, PosSpawn.rotation.z);
        }
        if (_isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector2.up * JumpForce;
        }
        if (facingRight == false && _rb.velocity.x > 0)
        {
            Flip();           
        }
        else if (facingRight == true && _rb.velocity.x < 0)
        {
            Flip();
        }
        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }



    }
    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}