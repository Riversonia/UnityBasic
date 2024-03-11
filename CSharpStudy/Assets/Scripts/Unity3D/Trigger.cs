using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        print("triggering");

    }
    private void OnTriggerExit(Collider other)
    {
        print("trigger Exit");
    }
}
