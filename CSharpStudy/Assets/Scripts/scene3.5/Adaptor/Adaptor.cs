using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Adaptor
{
    public interface IAdaptor
    {
        void Charge();            
    }
    public class Adaptor : IAdaptor
    {
        AndroidLine androidLine = new AndroidLine();

        public void Charge()
        {
            androidLine.AndroidCharge();
        }
    }

}
