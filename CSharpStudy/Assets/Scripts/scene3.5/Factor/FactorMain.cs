using Factor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MouseType
{
    None,
    DellMouse,
    HpMouse,
    AppleMouse
}

public class FactorMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // RunNormal();
        // RunSampleFactor();
        //RunFactor();
        RunAbstractFactor();
    }

    void RunNormal()
    {
        DellMouse dellMouse = new DellMouse();
        dellMouse.Print();

        HpMouse hpMouse = new HpMouse();
        hpMouse.Print();
    }

    void RunSampleFactor()
    {
        SampleFactor factor = new SampleFactor();
        AbstructMouse hpMouse = factor.CreateMouse(MouseType.HpMouse);
        hpMouse.Print();

        AbstructMouse dellMouse = factor.CreateMouse(MouseType.DellMouse);
        dellMouse.Print();

        AbstructMouse appleMouse = factor.CreateMouse(MouseType.AppleMouse);
        appleMouse.Print(); // 违反了开闭原则
    }

    void RunFactor()
    {
        DellBase dellFactor = new DellBase();
        AbstructMouse dellMouse = dellFactor.CreateMouse();
        dellMouse.Print();

        HpBase hpFactor = new HpBase();
        AbstructMouse hpMouse = hpFactor.CreateMouse();
        hpMouse.Print();

        AppleBase appleFactor = new AppleBase();
        AbstructMouse appleMouse = appleFactor.CreateMouse();
        appleMouse.Print();
    }

    void RunAbstractFactor()
    {
        AbstructFactor_Apple apple = new AbstructFactor_Apple();
        AbstructKeyboard appleKeyboard = apple.CreateKeyboard();
        appleKeyboard.Print();
        AbstructMouse appleMouse = apple.CreateMouse();
        appleMouse.Print();

        AbstructFactor_Dell dell = new AbstructFactor_Dell();
        AbstructKeyboard dellKeyboard = dell.CreateKeyboard();
        dellKeyboard.Print();
        AbstructMouse dellMouse = dell.CreateMouse();
        dellMouse.Print();

        AbstructFactor_Hp hp = new AbstructFactor_Hp();
        AbstructKeyboard hpKeyboard = hp.CreateKeyboard();
        hpKeyboard.Print();
        AbstructMouse hpMouse = hp.CreateMouse();
        hpMouse.Print();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
