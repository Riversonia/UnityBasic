using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Factor;
public class AppleBase : FactorBase
{
    public override AbstructKeyboard CreateKeyboard()
    {
        return new AppleKeyboard();
    }

    public override AbstructMouse CreateMouse()
    {
        return new AppleMouse();
    }
}
