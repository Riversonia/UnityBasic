using Factor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstructFactor_Dell : AbstructFactor_Base
{
    public override AbstructKeyboard CreateKeyboard()
    {
        return new DellKeyboard();
    }

    public override AbstructMouse CreateMouse()
    {
        return new DellMouse();
    }
}
