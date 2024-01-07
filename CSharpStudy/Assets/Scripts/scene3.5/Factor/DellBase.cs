using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Factor;

public class DellBase : FactorBase
{
    public override AbstructKeyboard CreateKeyboard()
    {
        throw new System.NotImplementedException();
    }

    public override AbstructMouse CreateMouse()
    {
        return new DellMouse();
    }
}
