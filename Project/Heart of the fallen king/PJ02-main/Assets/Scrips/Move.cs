using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f; // เดิน
    public float jumpForce = 10f; // กระโดด
    public Transform groundCheck; // ตรวจสอบการชนพื้น
    public LayerMask groundLayer; // เลเยอร์ที่พื้นดิน

    public ParticleSystem dustVFX; //vfxฝุ่น
    public Transform footPosition; //ตำแหน่งเท้าให้ vfx

    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        if(isGrounded && moveX !=0)
        {
            if(!dustVFX.isPlaying)
            {
                dustVFX.Play();
                Debug.Log("Dust is playing");
            }
        }
        else
        {
            if(dustVFX.isPlaying)
            {
                dustVFX.Stop();
            }
        }

        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        anim.SetFloat("Speed", Mathf.Abs(moveX));

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        anim.SetBool("isJumping", !isGrounded);

        if (moveX != 0)
        {
            transform.localScale = new Vector3(0.11f * Mathf.Sign(moveX), 0.11f, 1);
        }
    }

    public void OnLanding()
    {
        anim.SetBool("isJumping", false);
    }

}