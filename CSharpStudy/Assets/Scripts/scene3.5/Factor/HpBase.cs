using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Factor;

public class HpBase : FactorBase
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
