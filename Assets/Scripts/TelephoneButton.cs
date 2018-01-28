using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneButton : MonoBehaviour {
    public bool Pressed;
    public bool pressable = true;
    public Day d;
    private void OnTriggerEnter(Collider other)
    {
        if (!Pressed)
        {
            if (pressable)
            {
                transform.position = transform.position + new Vector3(0, -.02f, 0);
                d.transform.GetChild(d.currentCall).gameObject.GetComponent<Call>().eavesdropping = true;
                Pressed = true;
                StartCoroutine(Wait());
                // print out what's being heard
                pressable = false;
            }
            else
            {
               
            }
            pressable = false;

        }
        else
        {
            if (pressable)
            {
                transform.position = transform.position + new Vector3(0, .02f, 0);
                d.transform.GetChild(d.currentCall).gameObject.GetComponent<Call>().eavesdropping = false;
                Pressed = false;
                StartCoroutine(Wait());
            }
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2.0f);
        pressable = true;
    }
}
