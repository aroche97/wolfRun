using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;


public class WolfJump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float jumpForce;
    private BoxCollider2D bc;
    public LayerMask platform;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();

    }
    
    // Update is called once per frame
    
    
    void Update()
    {
        Jump();

    } 

    void Jump()
    {
        if (!isGrounded())
        {
            return;
        } else {
           // jump 
        }
        //if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    bool isGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, platform);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }
}