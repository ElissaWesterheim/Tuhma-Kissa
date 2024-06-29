using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
//using UnityEditor.Callbacks;
using UnityEngine;

//majority of this code is from the following Youtube channel: https://www.youtube.com/watch?v=J77CMuAwVDY&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=11
//The playlist for this tutorial is currently Unlisted on YT.
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;
    private float dirX;
    private enum MovingState {idle, walking, jump, fall};
    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private AudioSource jumpSFX;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpSFX.Play();
            rb.velocity =  new Vector2(rb.velocity.x, jumpForce);
        
        }

        UpdateAnimationState();
        
    }
    
    private void UpdateAnimationState()
    {
        MovingState state;

        if (dirX > 0f)
        {
            state = MovingState.walking;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovingState.walking;
            sprite.flipX = true;
        }
        else 
        {
            state = MovingState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovingState.jump;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovingState.fall;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
