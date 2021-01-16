using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    [Header("Movement Settings")]
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    [SerializeField] float HorizontalInput;
    [SerializeField] int jumpNumber = 0;
    private Animator anim;
    public Animator Anim { get { return anim; } }
    [SerializeField] float playerY;

    [Header("Bools")]
    [SerializeField] bool isGrounded = false;
    [SerializeField] bool isWalking = true;
    [SerializeField] bool isJumping = true;
    [SerializeField] private Transform player;
    [SerializeField] private Transform raspawnPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "KILLZONE")
        {
            int CS = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(CS);
        }
        if (other.gameObject.tag == "yenisahne")
        {
            int CS = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(CS + 1);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame 
    void Update()
    {
        //

        playerY = this.transform.position.y;
        if (isWalking)
        {
            HorizontalInput = Input.GetAxisRaw("Horizontal");
            float horizontal = Input.GetAxis("Horizontal");
            float moveby = moveSpeed * horizontal;
            rigidbody2d.velocity = new Vector2(moveby, rigidbody2d.velocity.y);
            anim.SetFloat("velocity", rigidbody2d.velocity.magnitude);
            // tsransform.position += Move * Time.deltaTime ;
        }

        Jump();

        if (HorizontalInput == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (HorizontalInput == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }


        if (jumpNumber >= 2)
        {
            isJumping = false;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other is null)
        {
            throw new System.ArgumentNullException(nameof(other));
        }

        if (other.gameObject.tag == "Zemin")
        {
            isGrounded = true;
            jumpNumber = 0;
            isJumping = true;
        }



    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isJumping)
        {
            rigidbody2d.AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);

            isGrounded = false;
            jumpNumber++;
        }
    }

    








}