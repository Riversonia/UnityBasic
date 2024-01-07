using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factor
{
    public abstract class FactorBase
    {
        public abstract AbstructMouse CreateMouse();
        public abstract AbstructKeyboard CreateKeyboard();
    }
}
