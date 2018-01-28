using System;
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
    //public JackPosition JackNormalPosition1;
    //public JackPosition JackNormalPosition2;
    //public JackPosition JackEavesDropPosition1;
    //public JackPosition JackEavesDropPosition2;
    //public GameObject FailedCall;
    //public GameObject NormalCall;
    //public GameObject EavesDroppingCall;
    public int Sx;
    public int Sy;
    public int dx;
    public int dy;
    public Jack source;
    public Jack destination;
    public Plug p1;
    public Plug p2;
    public Plug opPlug;
    public Board b;
    private AudioSource speaker;
    public AudioClip intro;
    public AudioClip call;
    public bool eavesdropping = false;
    public bool active;

    //int state = -1;

    enum CallState
    {
        WAIT,
        OPERATOR,
        WAITPLUGS,
        WAITDIALOGUE,
        WAITUNPLUG
    }
    CallState state = CallState.WAIT;

    private void Start()
    {
        speaker = GameObject.FindGameObjectWithTag("Speaker").GetComponent<AudioSource>();
        source = b.GetJack(Sx, Sy);
        destination = b.GetJack(dx, dy);
    }

    public void Update()
    {
        if (active)
        {
            switch (state)
            {
                case CallState.WAIT:
                    source.lightUp();
                    state = CallState.OPERATOR;
                    break;
                case CallState.OPERATOR:
                    if (opPlug.currentJack == source)
                    {
                        speaker.clip = intro;
                        speaker.Play();

                        state = CallState.WAITPLUGS;
                    }
                    break;
                case CallState.WAITPLUGS:
                    if (!speaker.isPlaying)
                    {
                        destination.lightUp();
                        PlayCallWhenPortsCorrect();
                    }
                    break;
                case CallState.WAITDIALOGUE:
                    if (speaker.isPlaying)
                    {
                        MuteIfNotEavesdropping();
                    }
                    else
                    {
                        source.lightOff();
                        destination.lightOff();
                        state = CallState.WAITUNPLUG;
                    }
                    break;
                case CallState.WAITUNPLUG:
                    if (p1.currentJack == null && p2.currentJack == null)
                    {
                        active = false;
                    }
                    break;
            }
        }
    }

    private void MuteIfNotEavesdropping()
    {
        if (eavesdropping)
        {
            speaker.volume = 1;
        }
        else
        {
            speaker.volume = 0;
        }
    }

    private void PlayCallWhenPortsCorrect()
    {
        if (p1.currentJack != null && p2.currentJack != null)
        {
            bool error = false;
            if (p1.currentJack != source)
            {
                p1.error();
                print("Jack 1 in wrong position");
                error = true;
            }
            if (p2.currentJack != destination)
            {
                p2.error();
                print("Jack 2 in wrong position");
                error = true;
            }

            if (!error)
            {
                p2.currentJack.lightUp();
                state = CallState.WAITDIALOGUE;
                speaker.clip = call;
                speaker.Play();
            }
        }
    }
    //    public Scenario Check(JackPosition jackPosition1, JackPosition jackPosition2)
    //    {
    //        if((jackPosition1 == JackNormalPosition1 && jackPosition2 == JackNormalPosition2) 
    //            || (jackPosition1 == JackNormalPosition2 && jackPosition2 == JackNormalPosition1))
    //        {
    //            return Scenario.Normal;
    //        }
    //        else if((jackPosition1 == JackEavesDropPosition1 && jackPosition2 == JackEavesDropPosition2) 
    //            || (jackPosition1 == JackEavesDropPosition2 && jackPosition2 == JackEavesDropPosition1))
    //        {
    //            return Scenario.Eavesdrop;
    //        }

    //        return Scenario.Failed;
    //    }

    //    public GameObject GetCall(Scenario callScenario)
    //    {
    //        switch(callScenario)
    //        {
    //            case Scenario.Normal:
    //                return NormalCall;
    //            case Scenario.Eavesdrop:
    //                return EavesDroppingCall;
    //            default:
    //                return FailedCall;
    //        }
    //    }
}