using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float h = Input.GetAxis("Horizontal");   // -1 0 1 
    private float v = Input.GetAxis("Vertical");
    public float rate = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region InputManager
        /*
         

         */
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * rate, 
                                        Input.GetAxis("Vertical") * rate));
        #endregion
    }
}
