using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    float powerOfJump;

    Rigidbody2D rb;

    [SerializeField]
    bool isGround = false;

    private void Start()
    {

        rb = gameObject.transform.parent.GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {

        Move();


    }
    private void Update()
    {
        Jump();

    }
    private void Move()
    {
        if (rb.velocity.x < speed)
        {
            rb.AddForce(Vector2.right, ForceMode2D.Impulse);
        }
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround)
            {

                rb.AddForce(Vector2.up * powerOfJump, ForceMode2D.Impulse);

                isGround = false;
            }
        }
    }
    private void IsGroundSwitch(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //        isGround = true;
    //}
    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    isGround = true;
    //}
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //        isGround = false;
    //}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGround = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            isGround = false;
    }
}
