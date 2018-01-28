using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day : MonoBehaviour {
    public int numberOfCalls;
    public int currentCall = 0;
    Call current;
    public bool active = false;
    enum DayState
    {
        NOTHING,
        CALLING
    }
    DayState currentState = DayState.NOTHING;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(active)
        {
            if(currentState == DayState.NOTHING)
            {
                if (currentCall == numberOfCalls)
                    active = false;
                else
                {
                    current = this.transform.GetChild(currentCall).GetComponent<Call>();
                    current.active = true;
                    currentState = DayState.CALLING;
                }
            }
            if(currentState == DayState.CALLING && !current.active)
            {
                currentState = DayState.NOTHING;
                currentCall++;
            }
        }
	}
}
