using Factor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstructFactor_Hp : AbstructFactor_Base
{
    public override AbstructKeyboard CreateKeyboard()
    {
        return new HpKeyboard();
    }

    public override AbstructMouse CreateMouse()
    {
        return new HpMouse();
    }
}
