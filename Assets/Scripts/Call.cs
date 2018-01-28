using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Scenario
{
    Normal,
    Eavesdrop,
    Failed,
    Incomplete
}

public class Call : MonoBehaviour
{
    public JackPosition JackNormalPosition1;
    public JackPosition JackNormalPosition2;
    public JackPosition JackEavesDropPosition1;
    public JackPosition JackEavesDropPosition2;
    public GameObject FailedCall;
    public GameObject NormalCall;
    public GameObject EavesDroppingCall;

    public Scenario Check(JackPosition jackPosition1, JackPosition jackPosition2)
    {
        if((jackPosition1 == JackNormalPosition1 && jackPosition2 == JackNormalPosition2) 
            || (jackPosition1 == JackNormalPosition2 && jackPosition2 == JackNormalPosition1))
        {
            return Scenario.Normal;
        }
        else if((jackPosition1 == JackEavesDropPosition1 && jackPosition2 == JackEavesDropPosition2) 
            || (jackPosition1 == JackEavesDropPosition2 && jackPosition2 == JackEavesDropPosition1))
        {
            return Scenario.Eavesdrop;
        }

        return Scenario.Failed;
    }

    public GameObject GetCall(Scenario callScenario)
    {
        switch(callScenario)
        {
            case Scenario.Normal:
                return NormalCall;
            case Scenario.Eavesdrop:
                return EavesDroppingCall;
            default:
                return FailedCall;
        }
    }
}
