using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Factor;
using System;

public class SampleFactor : MonoBehaviour
{
    public AbstructMouse CreateMouse(MouseType emMouseType)
    {
        AbstructMouse mouse = null;

        switch(emMouseType)
        {
            case MouseType.HpMouse:
                mouse = new HpMouse(); // ��̬�� ��������ำֵ
                break;
            case MouseType.DellMouse:
                mouse = new DellMouse();
                break;
            case MouseType.AppleMouse:
                mouse = new AppleMouse();
                break;
            default:
                break;
        }

        return mouse;
    }
}
