using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalRay : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // from 0,0,0 to 0,1,0
        // Ray ray = new Ray(Vector3.zero, new Vector3(0, 1, 0));
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitinfo, 1000))
        {
            Debug.Log(string.Format("射线碰到了{0}, 在位置{1}",
                hitinfo.collider.gameObject.name,
                hitinfo.point));

            Debug.DrawLine(ray.origin, hitinfo.point, Color.blue );
        }
    }
}
