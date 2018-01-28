using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoad : MonoBehaviour {
    public bool Pressed;
    public BriefingRoom BR;
    bool pressable = true;
    private void OnTriggerEnter(Collider other)
    {
        if (Pressed)
        {
            if (pressable)
            {
                transform.position = transform.position + new Vector3(0, -.02f, 0);
                StartCoroutine(Wait());
                BR.loadNext();
                // print out what's being heard
                pressable = false;
            }
            else
            {
                transform.position = transform.position + new Vector3(0, .02f, 0);
                StartCoroutine(Wait());
            }
            pressable = false;

        }
        else
        {

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
