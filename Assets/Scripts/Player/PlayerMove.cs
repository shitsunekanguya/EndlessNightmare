using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    public AudioSource JumpA;
    public AudioSource BoostA;
    public AudioSource Crash;

    public static bool Collid;
    public GameObject BoostEffect;

    public Fadein fadein;

    public VariableJoystick joystick;
    public bool isPressed;


    public int score;

    public float OriginalMS = 5;
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;

    public float gravity = -50f;
    private CharacterController characterController;
    private Vector3 velocity;
    private bool isGrounded;
    private float verticalInput;

    public float JumpRate = 0.5f;
    private float nextJump = 0.0f;
    

    [SerializeField] LayerMask groundLayers;
    [SerializeField] private float jumpHeight = 2f;

    private Animator animator;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        BoostEffect.SetActive(false);

    }


    public void Update()
    {
        if (OriginalMS < 50)
        {
            OriginalMS += Time.deltaTime / 10;
        }
        if (moveSpeed < 50)
        {
            moveSpeed += Time.deltaTime / 10;
        }

        //TrySpeedUpppppppppppppppppp

        verticalInput = 1;

        //Face Forward
        transform.forward = new Vector3 (Mathf.Abs(verticalInput) - 1, 0, verticalInput);


        //isGrounded
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundLayers, QueryTriggerInteraction.Ignore);
        
        if (characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = 0;
            animator.SetBool("Run", true);
            animator.SetBool("Jump", false);
        }
        else
        {
            //add grivity
            velocity.y += gravity * Time.deltaTime;
        }

        //Jump
        if (Input.GetKeyDown ("space") && Time.time > nextJump)
        {
            JumpA.Play();
            nextJump = Time.time + JumpRate;
            Jump();
        }

        // Move Forward
        characterController.Move(new Vector3(0, 0, verticalInput * moveSpeed) * Time.deltaTime);

        //vertical velocity
        characterController.Move(velocity * Time.deltaTime);


        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || (joystick.Horizontal < 0)) // คีย์
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide) // ชนขอบไปต่อไม่ได้
            {
                characterController.Move(Vector3.left * Time.deltaTime * leftRightSpeed); // เคลื่อนที่
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || (joystick.Horizontal > 0))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide) 
            {
                characterController.Move(Vector3.left * Time.deltaTime * leftRightSpeed * -1); 
            }
        }

        if (moveSpeed <= 0)
        {
            moveSpeed = 0;
        }
        
    }


    public void Jump()
        {
            animator.SetBool("Run", false);
            animator.SetBool("Jump", true);
            velocity.y += Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

    public void JumpButton()
        {
            if (Time.time > nextJump)
            {
                nextJump = Time.time + JumpRate;
                JumpA.Play();
                animator.SetBool("Run", false);
                animator.SetBool("Jump", true);
                velocity.y += Mathf.Sqrt(jumpHeight * -2 * gravity);
            }
        }


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Crash.Play();
            StartCoroutine(Death());
        }
        if (collision.gameObject.tag == "Weed")
        {
            BoostA.Play();
            StartCoroutine(Weed());
        }
        if (collision.gameObject.tag == "coin")
        {
            score = score + 1;
            print(score);
        }
        if (collision.gameObject.tag == "Coffee")
        {
            BoostA.Play();
            StartCoroutine(Coffee());
        }
        if (collision.gameObject.tag == "M150")
        {
            BoostA.Play();
            StartCoroutine(M150());
        }
        if (collision.gameObject.tag == "Book")
        {
            BoostA.Play();
        }
    }

    IEnumerator Death()
        {
            animator.SetBool("Death", true);
            OriginalMS = 0;
            moveSpeed = OriginalMS;
            leftRightSpeed = 0;
            jumpHeight = 0;
            yield return new WaitForSeconds(3.0f);
            fadein.FadeIn();
            StartCoroutine(GameOver());
        }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }

    IEnumerator Weed()
    {
        Collid = true;
        BoostEffect.SetActive(true);
        moveSpeed = moveSpeed + 7;
        yield return new WaitForSeconds(4f);
        moveSpeed = OriginalMS;
        Collid = false;
        BoostEffect.SetActive(false);
    }
    IEnumerator Coffee()
    {
        Collid = true;
        BoostEffect.SetActive(true);
        moveSpeed = moveSpeed + 3;
        yield return new WaitForSeconds(4f);
        moveSpeed = OriginalMS;
        Collid = false;
        BoostEffect.SetActive(false);
    }
    IEnumerator M150()
    {
        Collid = true;
        BoostEffect.SetActive(true);
        moveSpeed = moveSpeed + 5;
        yield return new WaitForSeconds(4f);
        moveSpeed = OriginalMS;
        Collid = false;
        BoostEffect.SetActive(false);
    }

}
