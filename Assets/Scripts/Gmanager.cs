using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gmanager : MonoBehaviour {
    public static int importantCalls;
    // Use this for initialization
    Call c;
    public static Gmanager g;
    public GameObject[] days;
    GameObject currentDay;
    
    private void Awake()
    {
        g = new Gmanager();
    }

    void Start ()
    {
        currentDay = days[0];
        
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
