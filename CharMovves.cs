using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovves : MonoBehaviour {
    public float movementSpeed;
    public Rigidbody2D rb;

    //public GameObject magnet;

    public Animator anim;

    public static int FallCounter;

    public LayerMask WhereIsLadder;
    public float distance;

    public bool isClimb;
    public bool beClimb;
    public float climbSpeed;
    private float climbVel;
    private float gravStore;

    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayers;
    public LayerMask floatLayers;

    NextLevel nl;

    //[SerializeField]
   // private UI_Inventory UiInventory;

    Spring sp;

    public bool isRight;
    //public SpriteRenderer sora;

//private Inventory inventory;

private bool isJumping;

    float mx;

    private void Start()
    {
        anim.enabled = true;
        gravStore = rb.gravityScale;
        anim.GetComponent<Animator>();
        //sp = FindObjectOfType<Spring>();
        nl = FindObjectOfType<NextLevel>();

        //inventory = new Inventory();
        //UiInventory.SetInventory(inventory);
    }

    private void Update()
    {

        //magnet.transform.position = new Vector2(transform.position.x, transform.position.y);

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            isRight = false;
            
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            isRight = true;
        }

        isJumping = true;
        mx = Input.GetAxisRaw("Horizontal");
        if (nl.isEnd == false)
        {
            
            if (Input.GetButtonDown("Jump") && isGrounded())
            {
                Jump();
                //if (sp.isSpring == true)
                //{
                    //SoundKeeper.sndMan.PlayJmpSound();
               // }
            }

            if (Mathf.Abs(mx) > 0.05)
            {
                anim.enabled = true;
                anim.SetBool("isRunning", true);
                anim.SetBool("isClimbing", false);
            }
            else
            {
                anim.SetBool("isRunning", false);
            }
            if (mx > 0f)
            {
                transform.localScale = new Vector3(1f, 1f, 1);
            }
            else if (mx < 0f)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
        anim.SetBool("isGrounded", isGrounded());

        ///RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, WhereIsLadder);

        if (beClimb)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            {
                isClimb = true;
            }
        }
        if (isClimb)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) < 0.05)
            {
                
                rb.gravityScale = 0f;
                climbVel = climbSpeed * Input.GetAxisRaw("Vertical");
                rb.velocity = new Vector2(rb.velocity.x, climbVel);
            }
            if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            {
                anim.enabled = false;
            }else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            {
               
                   
                if (isRight == false)
                {
                    //beClimb = true;
                    anim.enabled = true;
                    anim.SetBool("isClimbing", true);
                    ///sora.flipX = true;
                }
                else if (isRight == true)
                {
                    //beClimb = true;
                    anim.enabled = true;
                    anim.SetBool("isClimbingR", true);
                    //sora.flipX = false;
                }


            }
        }
        ///If I want to switch back just comment out isClimb(below) and change the ladder boolean to isClimb~
        if (!beClimb)
        {
            isClimb = false;
            anim.SetBool("isClimbing", false);
            anim.SetBool("isClimbingR", false);
            rb.gravityScale = gravStore;
        }

        //if (hitInfo.collider != null)
        //{
        //    if (Input.GetKeyDown(KeyCode.UpArrow))
        //    {
        //        beClimb = true;
        //    }
        //} else
        //{
        //    if (Input.GetKeyDown(KeyCode.LeftArrow))
        //    {
        //        beClimb = false;
        //    }
        //}
        //if (beClimb == true && hitInfo.collider != null)
        //{
        //    mx = Input.GetAxisRaw("Vertical");
        //    rb.velocity = new Vector2(rb.position.x, mx * climbSpeed);
        //    rb.gravityScale = 0;
        //} else
        //{
        //    rb.gravityScale = 3;
        //}
    }

    private void FixedUpdate()
    {
        if (nl.isEnd == false)
        {
            Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
            rb.velocity = movement;
        }
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

    public bool isGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);
        Collider2D floatCheck = Physics2D.OverlapCircle(feet.position, 0.5f, floatLayers);

        if (groundCheck != null || floatCheck != null)
        {
            return true;

        }

        return false;
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name.Equals("Ground"))
        {
            isJumping = true;
            //this.transform.parent = other.transform;
        }
        if (other.gameObject.CompareTag("Floaty"))
        {
            isJumping = false;
            this.transform.parent = other.transform;
        }
        if (other.gameObject.CompareTag("FX"))
        {
            FallCounter += 1;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {

        if (other.gameObject.name.Equals("Ground"))
        {
            isJumping = false;
            //this.transform.parent = other.transform;
        }
        if (other.gameObject.CompareTag("Floaty"))
        {
            isJumping = true;
            this.transform.parent = null;
        }
        if (other.gameObject.CompareTag("FX"))
        {
           
        }
    }
}