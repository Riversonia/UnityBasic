using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private bool isOnGround = true;

    public float Speed = 1.0f;
    public float JumpForce = 200.0f;



    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        MoveObject();
        JumpObject();
    }
/// <summary>
    /// Move
    /// </summary>
    void MoveObject()
    {
        float horizonal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");  // 实际跳跃实现不需要使用上下操作
        Vector3 dir = new Vector3(horizonal, 0, 0);
        transform.Translate(dir * Speed * Time.deltaTime);
    }

    void JumpObject()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb2D.AddForce(Vector2.up * JumpForce);
        }

    }
      
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            isOnGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            isOnGround = false;
    }


}
