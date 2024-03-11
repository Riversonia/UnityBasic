using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity3D : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Enter");
        Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Exit");
        Debug.Log(collision.gameObject.name);

    }

    private void OnCollisionStay(Collision collision)
    {
        print("Stay");
        Debug.Log(collision.gameObject.name);

    }
}
