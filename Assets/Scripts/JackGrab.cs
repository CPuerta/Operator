using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackGrab : MonoBehaviour {
    public GameObject OtherJack;
    public GameObject ThisJack;
    public GameObject Wire;
    public float speedlimit;
    public bool grab;
    public bool ungrab;
     bool grabbed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ungrab)
        {
            LetGo();
            ungrab = false;
        }
        if (grab)
        {
            Grab();
            grab = false;
        }
        if (grabbed)
        {
            Rigidbody rb = OtherJack.GetComponent<Rigidbody>();
            float vel = rb.velocity.magnitude;
            if (vel > speedlimit)
            {
                rb.velocity = Vector3.zero;
                GameObject temp = Wire;
                while (true)
                {   

                    Rigidbody rb2 = temp.GetComponent<Rigidbody>();
                    rb2.velocity = Vector3.zero;
                    if (temp.transform.childCount==0)
                    {
                        break;
                    }
                    temp = temp.transform.GetChild(0).gameObject;
                    
                }

            }
        }
	}
    public void Grab()
    {
        grabbed = true;
        OtherJack.transform.GetComponent<Rigidbody>().isKinematic = false;
    }
    public void LetGo()
    {
        grabbed = false;
        OtherJack.GetComponent<Rigidbody>().isKinematic = true;
    }
    
}
