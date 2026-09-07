using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5;
    private Rigidbody2D rb2D;

    private float move;

    public float jumpForce = 5;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundRadius = 0.1f;
    public LayerMask groundLayer;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        rb2D.linearVelocity = new Vector2(move * speed, rb2D.linearVelocity.y);

        if (move != 0)
            transform.localScale = new Vector3(move, 1, 1);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}