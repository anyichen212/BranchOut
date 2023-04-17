using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float Horizontal;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float speed;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] float Vertical;
    [SerializeField] float jumpForce;
    [SerializeField] bool isGrounded;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigid=gameObject.GetComponent<Rigidbody2D();
        speed=3f;
        jumpForce=60f;
        isGround=false;
        
        
    }

    // Update is called once per frame --used for user input
    //do NOT use for physics & movement
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Verical");
        
    }

    //called potentially many times per frame
    //use for physics & movement
    private void FixedUpdate()
    {
        if (Horizontal>0.1f || horizontal<-0.1f)
        {
          rigid.AddForce(new Vector2(Horizontal*speed, 0f), ForceMode2D.Impulse);
        }
        if (!isGround && Vertical>0.1f)
        {
          rigid.AddForce(new Vector2(0f, Vertical*jumpForce), ForceMode2D.Impulse);
        }
        
    }

    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Ground")
           isGrounded = false;
    }
     private void OnCollisionExit2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Ground")
           isGrounded = true;
    }
}
