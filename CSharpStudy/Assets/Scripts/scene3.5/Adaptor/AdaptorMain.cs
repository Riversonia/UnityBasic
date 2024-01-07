using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Adaptor
{
    public class AdaptorMain : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Adaptor adaptor = new Adaptor();
            adaptor.Charge();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}

