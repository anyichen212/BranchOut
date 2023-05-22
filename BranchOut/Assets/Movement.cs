using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] const int SPEED = 15;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] bool jumpPressed = false;
    [SerializeField] float jumpForce = 500.0f;
    [SerializeField] bool isGrounded = true;
    int count = 0;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame --used for user input
    //do NOT use for physics & movement
    void Update()
    {
        //movement = Input.GetAxis("Horizontal");
        //if (Input.GetButtonDown("Jump"))
            //jumpPressed = true;
        //if(count == 0){
            
            //if(Input.GetKeyDown(KeyCode.RightArrow)){
                //InvokeRepeating("MoveLeft", 5.0f, 5.0f);
                //count++;
                //Debug.Log("right");
            //}
        //}
    }

    //level 1 button
    public void RightClick(){
        //InvokeRepeating("MoveRight", 0.5f, 0.1f);
        transform.position = new Vector3(5f, 4f, 0);;
    }

    void MoveRight()
    {
        //if(transform.position.x > 4.5){
            //CancelInvoke("MoveRight");
            //rigid.gravityScale = 1;
        //}

        //transform.Translate(13* Time.deltaTime , -4*Time.deltaTime ,0);

    }

    public void LeftClick(){
        Flip();
        transform.position = new Vector3(-5f, 4f, 0);
        //InvokeRepeating("MoveLeft", 0.5f, 0.1f);
    }
    

    void MoveLeft()
    {
        //if(transform.position.x < -4.5){
            //CancelInvoke("MoveLeft");
            //rigid.gravityScale = 1;
        //}

        //transform.Translate(13* Time.deltaTime , -4*Time.deltaTime ,0);
    }

    //level2 buttons
    public void Button1(){
        transform.position = new Vector3(-7f, 1.2f, 0);
    }

    public void Button2(){
        transform.position = new Vector3(-3f, 1.2f, 0);

    }

    public void Button3(){
        transform.position = new Vector3(3f, 1.2f, 0);
    }

    public void Button4(){
        transform.position = new Vector3(7f, 1.2f, 0);

    }

    //level3 buttons
    public void ButtonX1(){
        transform.position = new Vector3(-9f, -1.2f, 0);
    }
    public void ButtonX2(){
        transform.position = new Vector3(-7f, -3.5f, 0);
    }
    public void ButtonX3(){
        transform.position = new Vector3(-4f, -1.2f, 0);
    }
    public void ButtonX4(){
        transform.position = new Vector3(-2.5f, -3.5f, 0);
    }
    public void ButtonX5(){
        transform.position = new Vector3(1.5f, -3.5f, 0);
    }
    public void ButtonX6(){
        transform.position = new Vector3(4f, -1.2f, 0);
    }
    public void ButtonX7(){
        transform.position = new Vector3(6f, -1.2f, 0);
    }
    public void ButtonX8(){
        transform.position = new Vector3(9f, -1f, 0);
    }

    //called potentially many times per frame
    //use for physics & movement
    private void FixedUpdate()
    {
        //rigid.velocity = new Vector2(SPEED * movement, rigid.velocity.y);
        //if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            //Flip();
        //if (jumpPressed && isGrounded)
            //Jump();
        //else
            //jumpPressed = false;

        anim.SetBool("Walking", movement != 0);
        
    }

    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    private void Jump()
    {
        rigid.velocity = new Vector2(rigid.velocity.x, 0);
        rigid.AddForce(new Vector2(0, jumpForce));
        //Debug.Log("jumped");
        jumpPressed = false;
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Ground")
            isGrounded = true;
        else
            Debug.Log(collision.gameObject.tag);
    }
}