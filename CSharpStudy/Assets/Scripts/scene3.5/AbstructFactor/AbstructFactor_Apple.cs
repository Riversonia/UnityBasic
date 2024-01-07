using Factor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstructFactor_Apple : AbstructFactor_Base
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
