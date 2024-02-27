using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            print("hitted!");
            GameObject.Destroy(collision.gameObject);
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
}
